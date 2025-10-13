using Restaurante_app;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Restaurante_app.MenuCard
{
    public partial class MenuCard : UserControl
    {
        public MenuCard()
        {
            InitializeComponent();
            this.Size = new Size(264, 355);

          

        }

        public void CargarDatos(Producto p)
        {
            labelNombre.Text = p.NombreProducto;
            labelDescripcion.Text = p.Descripcion;
            labelPrecio.Text = $"C$ {p.Precio:N2}";
            labelExistencias.Text = $"Existencias: {p.Existencias}";

            pictureBoxCont.Image = ObtenerImagenDesdeRecursos(p.ImagenNombre);
            pictureBoxCont.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private Image ObtenerImagenDesdeRecursos(string nombreRecurso)
        {
            var imagen = (Image)Properties.Resources.ResourceManager.GetObject(nombreRecurso);
            return imagen ?? Properties.Resources.restaurante_rotulacion_composicion_caligrafica_diseno_vintage;
        }

        private void panelCardContainer_Paint(object sender, PaintEventArgs e)
        {
            panelCardContainer.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, panelCardContainer.Width, panelCardContainer.Height, 20, 20));
            panelCardContainer.BackColor = Color.FromArgb(31, 29, 43);
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        private void MenuCard_Load(object sender, EventArgs e)
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));

            btnOrden.IconColor = Color.FromArgb(172, 126, 241);
            btnOrden.FlatStyle = FlatStyle.Flat;
            btnOrden.FlatAppearance.BorderSize = 0;
            btnOrden.FlatAppearance.MouseOverBackColor = btnOrden.BackColor;
            btnOrden.FlatAppearance.MouseDownBackColor = btnOrden.BackColor;
        }

        private void pictureBoxCont_Click(object sender, EventArgs e)
        {
            // Acción al hacer clic en la imagen (por ejemplo, abrir detalle)
        }

        private void labelNombre_Click(object sender, EventArgs e)
        {
           
        }


        private void labelDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void btnOrden_Click(object sender, EventArgs e)
        {

        }
    }
}