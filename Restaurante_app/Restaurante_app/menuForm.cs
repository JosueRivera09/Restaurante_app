using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante_app
{
    public partial class menuForm : Form
    {
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

        }

        private void panelContenedorMenu_Paint(object sender, PaintEventArgs e)
        {
           panelContenedorMenu.BackColor = Color.FromArgb(37, 40, 54);
        }

        private void menuStripCategorias_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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

            protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
            {
                base.OnRenderItemText(e);
            }
        }

        private void LayoutPanelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
