using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; //sql conexion
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante_app
{

    public partial class restaurante_app : Form

    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        public restaurante_app()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelPrincipal.Controls.Add(leftBorderBtn);

            // esto quita la barra de titulo del formulario
            this.Text = string.Empty;
            this.ControlBox = true;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        // colores para los botones
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        // metodo para cambiar el color del boton
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //boton
                currentBtn = (IconButton)senderBtn;

                // camobiar color de fondo y letra
                currentBtn.BackColor = Color.FromArgb(31, 29, 43);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //borde izquierdo del boton
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 29, 43);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            abrirMenu(new menuForm());

        }
        //evento carga formularios
        private void abrirMenu(object formhijomenu)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fhijo = formhijomenu as Form;
            fhijo.TopLevel = false;
            fhijo.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fhijo);
            this.panelContenedor.Tag = fhijo;
            fhijo.Show();

        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            abrirMenu(new gestionForm());
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            abrirMenu(new registroForm());
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            abrirMenu(new reporteForm());
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            abrirMenu(new UsersForm());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);

            var resultado = MessageBox.Show(
                "¿Está seguro que desea salir de la aplicación?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                ReiniciarBoton();
            }
        }

        //logo y metodo para reiniciar el boton
        private void ImageLogo_Click(object sender, EventArgs e)
        {
            ReiniciarBoton();
        }

        private void ReiniciarBoton()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }
        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {
            panelPrincipal.BackColor = Color.FromArgb(31, 29, 43);
        }
        private void panelTitulo_Paint(object sender, PaintEventArgs e)
        {
            panelTitulo.BackColor = Color.FromArgb(31, 29, 43);
        }
        // movimiento fluido

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panelShadow_Paint(object sender, PaintEventArgs e)
        {
            panelShadow.BackColor = Color.FromArgb(31, 29, 43);
        }
        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {
            panelContenedor.BackColor = Color.FromArgb(31, 29, 43);

        }

        
    }
}
