using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Restaurante_app
{
    public partial class reporteForm : Form
    {
        private string connectionString = "Server=DESKTOP-VOTBPSI\\SQLEXPRESS;Database=RestauranteDB;Trusted_Connection=True;";

        public reporteForm()
        {
            InitializeComponent();
        }

        private void reporteForm_Load(object sender, EventArgs e)
        {
            cmbReporte.Items.Add("Semanal");
            cmbReporte.Items.Add("Mensual");
            cmbReporte.SelectedIndex = 0;

            ConfigurarChart();
            EstiloVisualChart();

            CurvaturaBoton(btnConsultar, 20);
        }

        private void EstiloVisualChart()
        {
            this.BackColor = Color.FromArgb(31, 29, 43);

            lblReporte.ForeColor = Color.Gainsboro;
            lblReporte.Font = new Font("Segoe UI", 14, FontStyle.Bold);

            cmbReporte.BackColor = Color.FromArgb(37, 40, 54);
            cmbReporte.ForeColor = Color.Gainsboro;
            cmbReporte.FlatStyle = FlatStyle.Flat;
            cmbReporte.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            chartVentas.BackColor = Color.FromArgb(37, 40, 54);
            chartVentas.ChartAreas[0].BackColor = Color.FromArgb(37, 40, 54);

            chartVentas.ChartAreas[0].AxisX.Title = "Periodo";
            chartVentas.ChartAreas[0].AxisY.Title = "Total de Ventas ($)";
            chartVentas.ChartAreas[0].AxisX.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
            chartVentas.ChartAreas[0].AxisY.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
            chartVentas.ChartAreas[0].AxisX.TitleForeColor = Color.Gainsboro;
            chartVentas.ChartAreas[0].AxisY.TitleForeColor = Color.Gainsboro;

            chartVentas.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.Gainsboro;
            chartVentas.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.Gainsboro;
            chartVentas.ChartAreas[0].AxisX.LineColor = Color.Gainsboro;
            chartVentas.ChartAreas[0].AxisY.LineColor = Color.Gainsboro;
            chartVentas.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(60, 60, 60);
            chartVentas.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(60, 60, 60);

            chartVentas.Titles.Clear();
            chartVentas.Titles.Add("Reporte de Ventas");
            chartVentas.Titles[0].Font = new Font("Segoe UI", 12, FontStyle.Bold);
            chartVentas.Titles[0].ForeColor = Color.Gainsboro;
        }

        private void ConfigurarChart()
        {
            chartVentas.Series.Clear();
            chartVentas.Titles.Clear();
            chartVentas.Titles.Add("Reporte de Ventas");
            chartVentas.ChartAreas[0].AxisX.Title = "Periodo";
            chartVentas.ChartAreas[0].AxisY.Title = "Total de Ventas ($)";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string tipo = cmbReporte.SelectedItem.ToString();

            if (tipo == "Semanal")
                CargarReporteSemanal();
            else
                CargarReporteMensual();
        }

        private void CargarReporteSemanal()
        {
            string query = "SELECT CONCAT('Año ', Año, ' - Semana ', Semana) AS Periodo, TotalSemanal FROM ReporteVentasSemanal";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                DataTable dt = new DataTable();
                conn.Open();
                dt.Load(cmd.ExecuteReader());

                MostrarDatosEnChart(dt, "TotalSemanal", "Periodo", "Reporte Semanal de Ventas");
            }
        }

        private void CargarReporteMensual()
        {
            string query = "SELECT CONCAT('Año ', Año, ' - Mes ', Mes) AS Periodo, TotalMensual FROM ReporteVentasMensual";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                DataTable dt = new DataTable();
                conn.Open();
                dt.Load(cmd.ExecuteReader());

                MostrarDatosEnChart(dt, "TotalMensual", "Periodo", "Reporte Mensual de Ventas");
            }
        }

        private void MostrarDatosEnChart(DataTable dt, string valorCampo, string etiquetaCampo, string titulo)
        {
            chartVentas.Series.Clear();
            chartVentas.Titles.Clear();

            Series serie = new Series("Ventas")
            {
                ChartType = SeriesChartType.Column,
                XValueMember = etiquetaCampo,
                YValueMembers = valorCampo,
                IsValueShownAsLabel = true,
                Color = Color.FromArgb(95, 77, 221),
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                LabelForeColor = Color.Gainsboro
            };

            chartVentas.DataSource = dt;
            chartVentas.Series.Add(serie);

            Title chartTitle = new Title(titulo, Docking.Top, new Font("Segoe UI", 12, FontStyle.Bold), Color.Gainsboro);
            chartVentas.Titles.Add(chartTitle);

            chartVentas.DataBind();
        }

        private void chartVentas_Click(object sender, EventArgs e)
        {
            var me = e as MouseEventArgs;
            if (me == null) return;

            var result = chartVentas.HitTest(me.X, me.Y);
            if (result == null) return;

            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                var dp = result.Object as DataPoint;
                if (dp != null)
                {
                    string periodo = dp.AxisLabel;
                    double valor = dp.YValues != null && dp.YValues.Length > 0 ? dp.YValues[0] : double.NaN;
                    MessageBox.Show($"Periodo: {periodo}\nVentas: C$ {valor:N2}", "Detalle del punto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cmbReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lblReporte_Click(object sender, EventArgs e)
        {
        }
        private void CurvaturaBoton(Button btn, int radio)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(btn.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(btn.Width - radio, btn.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, btn.Height - radio, radio, radio, 90, 90);
            path.CloseAllFigures();
            btn.Region = new Region(path);
        }
    }
}