using DataAccess;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Restaurante_app
{
    public partial class UsersForm : Form
    {
        private int radioBorde = 30;
        private bool modoEdicion = false; // Saber si estamos editando o agregando

        public UsersForm()
        {
            InitializeComponent();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarRoles();
            EstiloTexto();

            dgUsers.ReadOnly = true;
            dgUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgUsers.AllowUserToAddRows = false;
            dgUsers.AllowUserToDeleteRows = false;
            dgUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.BackColor = Color.FromArgb(37, 40, 54);
            this.Padding = new Padding(50);

            panelUserCont.Dock = DockStyle.Fill;
            panelUserCont.Margin = new Padding(0);
            panelUserCont.Padding = new Padding(12);
            panelUserCont.BackColor = Color.FromArgb(31, 29, 43);
            panelUserCont.BorderStyle = BorderStyle.None;

            panelUserCont.Paint += (sr, pe) =>
            {
                DibujarBordeRedondeado(panelUserCont, pe.Graphics, radioBorde, Color.FromArgb(24, 161, 251), 2f);
            };

            this.Resize += (s, ev) => CentrarPanelEdicion();
            panelUserCont.Resize += (s, ev) => CentrarPanelEdicion();

            panelUserCont.Resize += (s, ev) =>
            {
                AplicarRegionRedondeada(panelUserCont, radioBorde);
                AplicarRegionAHijos(panelUserCont, radioBorde);
                panelUserCont.Invalidate();
            };

            panelUserCont.ControlAdded += (s, ev) =>
            {
                AplicarRegionAHijos(panelUserCont, radioBorde);
            };

            panelUserCont.ControlRemoved += (s, ev) =>
            {
                if (ev.Control.Region != null)
                {
                    ev.Control.Region.Dispose();
                    ev.Control.Region = null;
                }
            };

            AplicarRegionRedondeada(panelUserCont, radioBorde);
            AplicarRegionAHijos(panelUserCont, radioBorde);
        }

        // ESTÉTICA Y DISEÑO 

        private void DibujarBordeRedondeado(Control ctrl, Graphics g, int radio, Color color, float grosor)
        {
            var rect = ctrl.ClientRectangle;
            rect.Inflate(-(int)grosor, -(int)grosor);

            using (var path = ObtenerCaminoRectRedondeado(rect, radio))
            using (var pen = new Pen(color, grosor))
            {
                pen.Alignment = PenAlignment.Inset;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.DrawPath(pen, path);
            }
        }

        private void AplicarRegionRedondeada(Control ctrl, int radio)
        {
            var rect = ctrl.ClientRectangle;
            if (rect.Width <= 0 || rect.Height <= 0) return;

            using (var path = ObtenerCaminoRectRedondeado(rect, radio))
            {
                ctrl.Region = new Region(path);
            }
        }

        private GraphicsPath ObtenerCaminoRectRedondeado(Rectangle r, int radio)
        {
            var path = new GraphicsPath();
            int d = radio * 2;

            if (radio <= 0)
            {
                path.AddRectangle(r);
                path.CloseFigure();
                return path;
            }

            if (d > r.Width) d = r.Width;
            if (d > r.Height) d = r.Height;

            path.StartFigure();
            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void AplicarRegionAHijos(Control padre, int radio)
        {
            foreach (Control hijo in padre.Controls)
            {
                if (hijo is ScrollBar || hijo is ToolStrip) continue;

                var rectHijo = hijo.ClientRectangle;
                if (rectHijo.Width <= 0 || rectHijo.Height <= 0) continue;

                using (var path = ObtenerCaminoRectRedondeado(rectHijo, radio))
                {
                    hijo.Region?.Dispose();
                    hijo.Region = new Region(path);
                }

                if (!(hijo is DataGridView) && !(hijo is TextBox))
                {
                    hijo.BackColor = panelUserCont.BackColor;
                }

                hijo.Resize -= Hijo_Resize;
                hijo.Resize += Hijo_Resize;
            }
        }

        private void Hijo_Resize(object sender, EventArgs e)
        {
            if (sender is Control hijo)
            {
                var rect = hijo.ClientRectangle;
                if (rect.Width <= 0 || rect.Height <= 0) return;

                using (var path = ObtenerCaminoRectRedondeado(rect, radioBorde))
                {
                    hijo.Region?.Dispose();
                    hijo.Region = new Region(path);
                }
            }
        }

        // FUNCIONES DE CARGA 

        private void CargarUsuarios()
        {
            try
            {
                DbHelper db = new DbHelper();
                string consulta = "SELECT IdUsuario, NombreUsuario, Rol FROM Usuarios";
                DataTable tabla = db.ExecuteQuery(consulta);
                dgUsers.DataSource = tabla;

                dgUsers.Columns["IdUsuario"].HeaderText = "ID";
                dgUsers.Columns["NombreUsuario"].HeaderText = "Usuario";
                dgUsers.Columns["Rol"].HeaderText = "Rol";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }
        }

        private void CargarRoles()
        {
            try
            {
                DbHelper db = new DbHelper();
                string consulta = "SELECT DISTINCT Rol FROM Usuarios ORDER BY Rol";
                DataTable tabla = db.ExecuteQuery(consulta);

                comboSelectRol.DataSource = tabla;
                comboSelectRol.DisplayMember = "Rol";
                comboSelectRol.ValueMember = "Rol";
                comboSelectRol.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar roles: " + ex.Message);
            }
        }

        private void CentrarPanelEdicion()
        {
            if (!panelEdicionUsuarios.Visible) return;

            int x = (panelUserCont.ClientSize.Width - panelEdicionUsuarios.Width) / 2;
            int y = panelUserCont.ClientSize.Height - panelEdicionUsuarios.Height - 12;

            panelEdicionUsuarios.Location = new Point(Math.Max(0, x), Math.Max(0, y));
        }

        // BOTONES PRINCIPALES

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            modoEdicion = false;
            LimpiarCampos();
            panelEdicionUsuarios.Visible = true;
            CentrarPanelEdicion();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un usuario para editar.");
                return;
            }

            DataGridViewRow fila = dgUsers.SelectedRows[0];
            int idUsuario = Convert.ToInt32(fila.Cells["IdUsuario"].Value);

            try
            {
                DbHelper db = new DbHelper();
                string sql = "SELECT * FROM Usuarios WHERE IdUsuario = @id";
                SqlParameter[] parametros = { new SqlParameter("@id", idUsuario) };

                DataTable dt = db.ExecuteQuery(sql, parametros);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    txtCarnet.Text = row["IdUsuario"].ToString();
                    txtNombre.Text = row["NombreUsuario"].ToString();
                    txtContraseña.Text = row["Contraseña"].ToString();
                    comboSelectRol.SelectedValue = row["Rol"].ToString();

                    modoEdicion = true; // Estamos editando
                    panelEdicionUsuarios.Visible = true;
                    CentrarPanelEdicion();
                }
                else
                {
                    MessageBox.Show("No se encontró información del usuario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del usuario: " + ex.Message);
            }
        }

        private void btnEliminar_Click1(object sender, EventArgs e)
        {
            if (dgUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un usuario para eliminar.");
                return;
            }

            DataGridViewRow fila = dgUsers.SelectedRows[0];
            int idUsuario = Convert.ToInt32(fila.Cells["IdUsuario"].Value);
            string nombre = fila.Cells["NombreUsuario"].Value.ToString();

            DialogResult respuesta = MessageBox.Show(
                $"¿Seguro que desea eliminar al usuario '{nombre}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    DbHelper db = new DbHelper();
                    string sql = "DELETE FROM Usuarios WHERE IdUsuario = @id";
                    SqlParameter[] parametros = { new SqlParameter("@id", idUsuario) };

                    int filasAfectadas = db.ExecuteNonQuery(sql, parametros);

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Usuario eliminado correctamente.");
                        CargarUsuarios();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el usuario.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar usuario: " + ex.Message);
                }
            }
        }

        // GUARDAR (AGREGAR / EDITAR) 

        private void btnLIsto_Click(object sender, EventArgs e)
        {
            GuardarUsuario();
        }

        private void GuardarUsuario()
        {
            if (!int.TryParse(txtCarnet.Text.Trim(), out int carnet) || carnet < 1000 || carnet > 9999)
            {
                MessageBox.Show("El carnet debe ser un número entre 1000 y 9999.");
                return;
            }

            string nombre = txtNombre.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();
            string rol = comboSelectRol.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(contraseña) || string.IsNullOrEmpty(rol))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            try
            {
                DbHelper db = new DbHelper();

                if (modoEdicion)
                {
                    string sqlUpdate = "UPDATE Usuarios SET NombreUsuario=@nombre, Contraseña=@clave, Rol=@rol WHERE IdUsuario=@id";
                    SqlParameter[] parametrosUpdate =
                    {
                        new SqlParameter("@id", carnet),
                        new SqlParameter("@nombre", nombre),
                        new SqlParameter("@clave", contraseña),
                        new SqlParameter("@rol", rol)
                    };

                    int result = db.ExecuteNonQuery(sqlUpdate, parametrosUpdate);
                    if (result > 0)
                    {
                        MessageBox.Show("Usuario actualizado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el usuario.");
                    }
                }
                else
                {
                    string consultaExistencia = "SELECT COUNT(*) FROM Usuarios WHERE IdUsuario = @id OR NombreUsuario = @nombre";
                    SqlParameter[] parametrosVerificacion =
                    {
                        new SqlParameter("@id", carnet),
                        new SqlParameter("@nombre", nombre)
                    };

                    int existe = Convert.ToInt32(db.ExecuteScalar(consultaExistencia, parametrosVerificacion));
                    if (existe > 0)
                    {
                        MessageBox.Show("Ya existe un usuario con ese carnet o nombre.");
                        return;
                    }

                    string sqlInsert = "INSERT INTO Usuarios (IdUsuario, NombreUsuario, Contraseña, Rol) VALUES (@id, @nombre, @clave, @rol)";
                    SqlParameter[] parametrosInsert =
                    {
                        new SqlParameter("@id", carnet),
                        new SqlParameter("@nombre", nombre),
                        new SqlParameter("@clave", contraseña),
                        new SqlParameter("@rol", rol)
                    };

                    int resultado = db.ExecuteNonQuery(sqlInsert, parametrosInsert);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Usuario agregado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el usuario.");
                    }
                }

                CargarUsuarios();
                LimpiarCampos();
                panelEdicionUsuarios.Visible = false;
                modoEdicion = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar usuario: " + ex.Message);
            }
        }


        private void LimpiarCampos()
        {
            txtCarnet.Text = "";
            txtNombre.Text = "";
            txtContraseña.Text = "";
            comboSelectRol.SelectedIndex = -1;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            panelEdicionUsuarios.Visible = false;
            modoEdicion = false;
        }
        private void EstiloTexto()
        {
            // Apariencia del DataGridView
            dgUsers.DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            dgUsers.DefaultCellStyle.ForeColor = Color.Gainsboro;
            dgUsers.DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 60);
            dgUsers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(24, 161, 251);
            dgUsers.DefaultCellStyle.SelectionForeColor = Color.White;

            dgUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            dgUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 29, 43);
            dgUsers.EnableHeadersVisualStyles = false;

            dgUsers.GridColor = Color.FromArgb(60, 60, 70);
            dgUsers.BackgroundColor = Color.FromArgb(37, 40, 54);
            dgUsers.BorderStyle = BorderStyle.None;

        }

        private void dgUsers_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void panelUserCont_Paint(object sender, PaintEventArgs e) { }
        private void panelEdicionUsuarios_Paint(object sender, PaintEventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void comboSelectRol_SelectedIndexChanged(object sender, EventArgs e) { }

        
    }
}
