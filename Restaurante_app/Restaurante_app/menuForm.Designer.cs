namespace Restaurante_app
{
    partial class menuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panelContenedorMenu = new System.Windows.Forms.Panel();
            this.panelCategorias = new System.Windows.Forms.Panel();
            this.menuStripCategorias = new System.Windows.Forms.MenuStrip();
            this.iconTodo = new FontAwesome.Sharp.IconMenuItem();
            this.iconComidas = new FontAwesome.Sharp.IconMenuItem();
            this.iconBebidas = new FontAwesome.Sharp.IconMenuItem();
            this.iconPostres = new FontAwesome.Sharp.IconMenuItem();
            this.panelMenuOrden = new System.Windows.Forms.Panel();
            this.LayoutPanelContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panelContenedorMenu.SuspendLayout();
            this.panelCategorias.SuspendLayout();
            this.menuStripCategorias.SuspendLayout();
            this.panelMenuOrden.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(687, 402);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 52);
            this.label1.TabIndex = 0;
            // 
            // panelContenedorMenu
            // 
            this.panelContenedorMenu.BackColor = System.Drawing.Color.White;
            this.panelContenedorMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelContenedorMenu.Controls.Add(this.panelMenuOrden);
            this.panelContenedorMenu.Controls.Add(this.panelCategorias);
            this.panelContenedorMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorMenu.Location = new System.Drawing.Point(0, 0);
            this.panelContenedorMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContenedorMenu.Name = "panelContenedorMenu";
            this.panelContenedorMenu.Size = new System.Drawing.Size(840, 462);
            this.panelContenedorMenu.TabIndex = 1;
            this.panelContenedorMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedorMenu_Paint);
            // 
            // panelCategorias
            // 
            this.panelCategorias.Controls.Add(this.menuStripCategorias);
            this.panelCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCategorias.Location = new System.Drawing.Point(0, 0);
            this.panelCategorias.Name = "panelCategorias";
            this.panelCategorias.Size = new System.Drawing.Size(840, 40);
            this.panelCategorias.TabIndex = 0;
            // 
            // menuStripCategorias
            // 
            this.menuStripCategorias.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.menuStripCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStripCategorias.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripCategorias.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconTodo,
            this.iconComidas,
            this.iconBebidas,
            this.iconPostres});
            this.menuStripCategorias.Location = new System.Drawing.Point(0, 0);
            this.menuStripCategorias.Name = "menuStripCategorias";
            this.menuStripCategorias.Size = new System.Drawing.Size(840, 40);
            this.menuStripCategorias.TabIndex = 0;
            this.menuStripCategorias.Text = "menuStrip1";
            this.menuStripCategorias.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStripCategorias_ItemClicked);
            // 
            // iconTodo
            // 
            this.iconTodo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconTodo.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconTodo.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.iconTodo.IconColor = System.Drawing.Color.Gainsboro;
            this.iconTodo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTodo.Name = "iconTodo";
            this.iconTodo.Size = new System.Drawing.Size(81, 36);
            this.iconTodo.Text = "Todo";
            // 
            // iconComidas
            // 
            this.iconComidas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconComidas.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconComidas.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            this.iconComidas.IconColor = System.Drawing.Color.Gainsboro;
            this.iconComidas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconComidas.Name = "iconComidas";
            this.iconComidas.Size = new System.Drawing.Size(110, 36);
            this.iconComidas.Text = "Comidas";
            // 
            // iconBebidas
            // 
            this.iconBebidas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBebidas.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBebidas.IconChar = FontAwesome.Sharp.IconChar.WhiskeyGlass;
            this.iconBebidas.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBebidas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBebidas.Name = "iconBebidas";
            this.iconBebidas.Size = new System.Drawing.Size(96, 36);
            this.iconBebidas.Text = "Bebidas";
            // 
            // iconPostres
            // 
            this.iconPostres.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconPostres.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPostres.IconChar = FontAwesome.Sharp.IconChar.IceCream;
            this.iconPostres.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPostres.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPostres.Name = "iconPostres";
            this.iconPostres.Size = new System.Drawing.Size(98, 36);
            this.iconPostres.Text = "Postres";
            // 
            // panelMenuOrden
            // 
            this.panelMenuOrden.Controls.Add(this.LayoutPanelContainer);
            this.panelMenuOrden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenuOrden.Location = new System.Drawing.Point(0, 40);
            this.panelMenuOrden.Name = "panelMenuOrden";
            this.panelMenuOrden.Size = new System.Drawing.Size(840, 422);
            this.panelMenuOrden.TabIndex = 1;
            // 
            // LayoutPanelContainer
            // 
            this.LayoutPanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutPanelContainer.Location = new System.Drawing.Point(0, 0);
            this.LayoutPanelContainer.Name = "LayoutPanelContainer";
            this.LayoutPanelContainer.Size = new System.Drawing.Size(840, 422);
            this.LayoutPanelContainer.TabIndex = 0;
            this.LayoutPanelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.LayoutPanelContainer_Paint);
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 462);
            this.Controls.Add(this.panelContenedorMenu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStripCategorias;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "menuForm";
            this.Text = "menuForm";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.menuForm_Load);
            this.panelContenedorMenu.ResumeLayout(false);
            this.panelCategorias.ResumeLayout(false);
            this.panelCategorias.PerformLayout();
            this.menuStripCategorias.ResumeLayout(false);
            this.menuStripCategorias.PerformLayout();
            this.panelMenuOrden.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContenedorMenu;
        private System.Windows.Forms.Panel panelCategorias;
        private System.Windows.Forms.MenuStrip menuStripCategorias;
        private FontAwesome.Sharp.IconMenuItem iconTodo;
        private FontAwesome.Sharp.IconMenuItem iconComidas;
        private FontAwesome.Sharp.IconMenuItem iconBebidas;
        private FontAwesome.Sharp.IconMenuItem iconPostres;
        private System.Windows.Forms.Panel panelMenuOrden;
        private System.Windows.Forms.FlowLayoutPanel LayoutPanelContainer;
    }
}