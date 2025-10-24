using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace Restaurante_app
{
    public partial class LoginPage : Form
    {
        private readonly DbHelper _db = new DbHelper();

        public LoginPage()
        {
            InitializeComponent();
        }

        private void panelLogoLogin_Paint(object sender, PaintEventArgs e)
        {
            panelLogoLogin.BackColor = Color.FromArgb(31, 29, 43);
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(37, 40, 54);
            textBoxName.BackColor = Color.FromArgb(31, 29, 43);
            textBoxPassword.BackColor = Color.FromArgb(31, 29, 43);
            btnAceptarLogin.BackColor = Color.FromArgb(31, 29, 43);
            btnCancelarLogin.BackColor = Color.FromArgb(31, 29, 43);
            CurvaturaBoton(btnAceptarLogin, 20);
            CurvaturaBoton(btnCancelarLogin, 20);
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void iconPictureBoxPassword_Click(object sender, EventArgs e)
        {
        }

        private void iconPictureBoxUser_Click(object sender, EventArgs e)
        {
        }

        private void btnAceptarLogin_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "Usuario" && textBoxPassword.Text != "Contraseña")
            {
                string sql = "SELECT COUNT(1) FROM Usuarios WHERE NombreUsuario = @usuario AND Contraseña = @contraseña";
                var p1 = new SqlParameter("@usuario", SqlDbType.NVarChar) { Value = textBoxName.Text };
                var p2 = new SqlParameter("@contraseña", SqlDbType.NVarChar) { Value = textBoxPassword.Text };

                object result = null;
                try
                {
                    result = _db.ExecuteScalar(sql, p1, p2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                    return;
                }

                int count = Convert.ToInt32(result ?? 0);
                if (count > 0)
                {
                    this.Hide();
                    restaurante_app mainForm = new restaurante_app();
                    mainForm.Size = new Size(1350, 900);
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese su usuario y contraseña");
            }
        }

        private void btnCancelarLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Usuario")
            {
                textBoxName.Text = "";
                textBoxName.ForeColor = Color.Gainsboro;
            }
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                textBoxName.Text = "Usuario";
                textBoxName.ForeColor = Color.DimGray;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Contraseña")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Gainsboro;
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Contraseña";
                textBoxPassword.ForeColor = Color.DimGray;
                textBoxPassword.UseSystemPasswordChar = false;
            }
        }

        private void iconButtonEye_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.UseSystemPasswordChar)
            {
                iconButtonEye.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                iconButtonEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void CurvaturaBoton(Button btn, int radio)
        {
            var path = new GraphicsPath();
            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(btn.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(btn.Width - radio, btn.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, btn.Height - radio, radio, radio, 90, 90);
            path.CloseAllFigures();
            btn.Region = new Region(path);
        }
    }
}