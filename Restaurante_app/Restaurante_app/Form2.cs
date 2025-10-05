using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; //sql conexion
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante_app
{
    public partial class LoginPage : Form
    {
       
        public LoginPage()
        {
            InitializeComponent();
        }

        private void panelLogoLogin_Paint(object sender, PaintEventArgs e)
        {
            panelLogoLogin.BackColor = Color.FromArgb(31, 29, 43);
        }

        SqlConnection conexion = new SqlConnection("server=JOSUE\\SQLEXPRESS; database=RestauranteDB; integrated security=true");

        private void LoginPage_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(37, 40, 54);
            textBoxName.BackColor = Color.FromArgb(31, 29, 43);
            textBoxPassword.BackColor = Color.FromArgb(31, 29, 43);
            btnAceptarLogin.BackColor = Color.FromArgb(31, 29, 43);
            btnCancelarLogin.BackColor = Color.FromArgb(31, 29, 43);
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
                conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT * FROM Usuarios WHERE NombreUsuario = @usuario AND Contraseña = @contraseña", conexion);
                comando.Parameters.AddWithValue("@usuario", textBoxName.Text);
                comando.Parameters.AddWithValue("@contraseña", textBoxPassword.Text);
                SqlDataReader lector = comando.ExecuteReader();
                if (lector.HasRows)
                {
                    // Si el usuario y la contraseña son correctos, abrir el formulario principal
                    this.Hide();
                    restaurante_app mainForm = new restaurante_app();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
                conexion.Close();
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

        // eventos para textBox
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
    }
}
