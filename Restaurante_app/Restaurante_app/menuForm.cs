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
           
        }

        private void panelContenedorMenu_Paint(object sender, PaintEventArgs e)
        {
           panelContenedorMenu.BackColor = Color.FromArgb(31, 29, 43);
        }
    }
}
