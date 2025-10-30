using Restaurante_app.MenuCard;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante_app
{
    public partial class menuForm : Form
    {
        private List<Producto> todosLosProductos;
        private ToolStripMenuItem itemSeleccionado;
        private string categoriaActual = "Todo";

        public menuForm()
        {
            InitializeComponent();
        }

        private void menuForm_Load(object sender, EventArgs e)
        {
            menuStripCategorias.Renderer = new MenuRendererPersonalizado();
            menuStripCategorias.BackColor = Color.FromArgb(31, 29, 43);

            foreach (ToolStripMenuItem item in menuStripCategorias.Items)
            {
                item.Padding = new Padding(10, 5, 10, 5);
                item.Margin = new Padding(5, 0, 5, 0);
            }

            panelCards.AutoScroll = true;
            panelCards.Dock = DockStyle.Fill;
            panelCards.BackColor = Color.Transparent;

            todosLosProductos = ObtenerProductos();
            PintarTarjetas(todosLosProductos);

            this.Resize += (s, args) =>
            {
                PintarTarjetas(todosLosProductos);
            };

            menuStripCategorias.ItemClicked += menuStripCategorias_ItemClicked;

            textBoxSearch.BackColor = Color.FromArgb(37, 40, 54);
            btnSearch.Click += (s, args) => BuscarProducto();

            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseOverBackColor = btnSearch.BackColor;
            btnSearch.FlatAppearance.MouseDownBackColor = btnSearch.BackColor;
        }

        public List<Producto> ObtenerProductos()
        {
            var lista = new List<Producto>();
            //string cadena = "Server=JORDANAVILES\\SQLEXPRESS;Database=RestauranteDB;Trusted_Connection=True;";
            string cadena = "Server=DESKTOP-VOTBPSI\\SQLEXPRESS;Database=RestauranteDB;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(cadena))
            {
                conn.Open();
                string query = "SELECT NombreProducto, Descripcion, Precio, Existencias, Categoria, ImagenNombre FROM Productos WHERE Estado = 'Activo'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Producto
                    {
                        NombreProducto = reader["NombreProducto"].ToString(),
                        Descripcion = reader["Descripcion"].ToString(),
                        Precio = Convert.ToDecimal(reader["Precio"]),
                        Existencias = Convert.ToInt32(reader["Existencias"]),
                        Categoria = reader["Categoria"].ToString(),
                        ImagenNombre = reader["ImagenNombre"].ToString()
                    });
                }
            }

            return lista;
        }

        private void PintarTarjetas(List<Producto> productos)
        {
            panelCards.Controls.Clear();

            int x = 10;
            int y = 10;
            int cardWidth = 264;
            int cardHeight = 355;
            int espacio = 10;

            int anchoVentana = this.ClientSize.Width;
            int columnas = anchoVentana <= 1311 ? 4 : 6;

            for (int i = 0; i < productos.Count; i++)
            {
                var p = productos[i];
                var card = new Restaurante_app.MenuCard.MenuCard();
                card.Size = new Size(cardWidth, cardHeight);
                card.CargarDatos(p);

                int col = i % columnas;
                int fila = i / columnas;

                int posX = x + col * (cardWidth + espacio);
                int posY = y + fila * (cardHeight + espacio);

                card.Location = new Point(posX, posY);
                panelCards.Controls.Add(card);
            }
        }

        private void menuStripCategorias_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (itemSeleccionado != null)
            {
                itemSeleccionado.BackColor = Color.FromArgb(31, 29, 43);
                itemSeleccionado.ForeColor = Color.White;
                itemSeleccionado.Font = new Font(itemSeleccionado.Font, FontStyle.Regular);
            }

            itemSeleccionado = (ToolStripMenuItem)e.ClickedItem;
            itemSeleccionado.BackColor = Color.FromArgb(50, 53, 70);
            itemSeleccionado.ForeColor = Color.FromArgb(172, 126, 241);
            itemSeleccionado.Font = new Font(itemSeleccionado.Font, FontStyle.Bold);

            string texto = itemSeleccionado.Text.Trim();
            string categoria = texto.Contains(" ") ? texto.Substring(texto.IndexOf(" ") + 1) : texto;

            categoriaActual = categoria;
            FiltrarPorCategoria(categoriaActual);
        }

        private void FiltrarPorCategoria(string categoria)
        {
            List<Producto> filtrados;

            if (categoria.Equals("Todo", StringComparison.OrdinalIgnoreCase))
            {
                filtrados = todosLosProductos;
            }
            else
            {
                filtrados = todosLosProductos
                    .Where(p => p.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            PintarTarjetas(filtrados);
        }

        public class MenuRendererPersonalizado : ToolStripProfessionalRenderer
        {
            private Color colorHover = Color.FromArgb(37, 40, 54);

            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                base.OnRenderMenuItemBackground(e);

                if (e.Item.Selected)
                {
                    Rectangle rect = new Rectangle(Point.Empty, e.Item.Size);
                    e.Graphics.FillRectangle(new SolidBrush(colorHover), rect);
                }
            }
        }

        private void panelContenedorMenu_Paint(object sender, PaintEventArgs e)
        {
            panelContenedorMenu.BackColor = Color.FromArgb(37, 40, 54);
        }

        private void panelCards_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panelSearch_Paint(object sender, PaintEventArgs e)
        {
            panelSearch.BackColor = Color.FromArgb(31, 29, 43);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private async void BuscarProducto()
        {
            var originalColor = btnSearch.IconColor;
            btnSearch.IconColor = Color.FromArgb(172, 126, 241);
            await Task.Delay(300);
            btnSearch.IconColor = originalColor;

            string textoBusqueda = textBoxSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(textoBusqueda))
            {
                FiltrarPorCategoria(categoriaActual);
                return;
            }

            var filtrados = todosLosProductos
                .Where(p =>
                    p.NombreProducto.IndexOf(textoBusqueda, StringComparison.OrdinalIgnoreCase) >= 0 &&
                    (categoriaActual.Equals("Todo", StringComparison.OrdinalIgnoreCase) ||
                     p.Categoria.Equals(categoriaActual, StringComparison.OrdinalIgnoreCase)))
                .ToList();

            PintarTarjetas(filtrados);
        }
    }
}