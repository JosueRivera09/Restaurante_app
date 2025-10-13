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
            this.panelCards = new System.Windows.Forms.Panel();
            this.panelCategorias = new System.Windows.Forms.Panel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.menuStripCategorias = new System.Windows.Forms.MenuStrip();
            this.iconTodo = new FontAwesome.Sharp.IconMenuItem();
            this.iconComidas = new FontAwesome.Sharp.IconMenuItem();
            this.iconBebidas = new FontAwesome.Sharp.IconMenuItem();
            this.iconPostres = new FontAwesome.Sharp.IconMenuItem();
            this.panelContenedorMenu.SuspendLayout();
            this.panelCategorias.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.menuStripCategorias.SuspendLayout();
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
            this.panelContenedorMenu.Controls.Add(this.panelCards);
            this.panelContenedorMenu.Controls.Add(this.panelCategorias);
            this.panelContenedorMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorMenu.Location = new System.Drawing.Point(0, 0);
            this.panelContenedorMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelContenedorMenu.Name = "panelContenedorMenu";
            this.panelContenedorMenu.Size = new System.Drawing.Size(840, 462);
            this.panelContenedorMenu.TabIndex = 1;
            this.panelContenedorMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedorMenu_Paint);
            // 
            // panelCards
            // 
            this.panelCards.AutoScroll = true;
            this.panelCards.BackColor = System.Drawing.Color.Transparent;
            this.panelCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCards.Location = new System.Drawing.Point(0, 58);
            this.panelCards.Name = "panelCards";
            this.panelCards.Size = new System.Drawing.Size(840, 404);
            this.panelCards.TabIndex = 1;
            this.panelCards.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCards_Paint);
            // 
            // panelCategorias
            // 
            this.panelCategorias.Controls.Add(this.panelSearch);
            this.panelCategorias.Controls.Add(this.menuStripCategorias);
            this.panelCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCategorias.Location = new System.Drawing.Point(0, 0);
            this.panelCategorias.Name = "panelCategorias";
            this.panelCategorias.Size = new System.Drawing.Size(840, 58);
            this.panelCategorias.TabIndex = 0;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelSearch.Controls.Add(this.textBoxSearch);
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSearch.Location = new System.Drawing.Point(475, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(365, 58);
            this.panelSearch.TabIndex = 1;
            this.panelSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSearch_Paint);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxSearch.Location = new System.Drawing.Point(16, 9);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(243, 38);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearch.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 45;
            this.btnSearch.Location = new System.Drawing.Point(265, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 45);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = false;
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
            this.menuStripCategorias.Size = new System.Drawing.Size(840, 58);
            this.menuStripCategorias.TabIndex = 0;
            this.menuStripCategorias.Text = "menuStrip1";
            this.menuStripCategorias.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStripCategorias_ItemClicked);
            // 
            // iconTodo
            // 
            this.iconTodo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconTodo.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconTodo.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.iconTodo.IconColor = System.Drawing.Color.Gainsboro;
            this.iconTodo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTodo.IconSize = 50;
            this.iconTodo.Name = "iconTodo";
            this.iconTodo.Size = new System.Drawing.Size(86, 54);
            this.iconTodo.Text = "Todo";
            // 
            // iconComidas
            // 
            this.iconComidas.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconComidas.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconComidas.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            this.iconComidas.IconColor = System.Drawing.Color.Gainsboro;
            this.iconComidas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconComidas.IconSize = 50;
            this.iconComidas.Name = "iconComidas";
            this.iconComidas.Size = new System.Drawing.Size(116, 54);
            this.iconComidas.Text = "Comidas";
            // 
            // iconBebidas
            // 
            this.iconBebidas.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBebidas.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBebidas.IconChar = FontAwesome.Sharp.IconChar.WhiskeyGlass;
            this.iconBebidas.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBebidas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBebidas.IconSize = 50;
            this.iconBebidas.Name = "iconBebidas";
            this.iconBebidas.Size = new System.Drawing.Size(108, 54);
            this.iconBebidas.Text = "Bebidas";
            // 
            // iconPostres
            // 
            this.iconPostres.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconPostres.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPostres.IconChar = FontAwesome.Sharp.IconChar.IceCream;
            this.iconPostres.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPostres.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPostres.IconSize = 50;
            this.iconPostres.Name = "iconPostres";
            this.iconPostres.Size = new System.Drawing.Size(103, 54);
            this.iconPostres.Text = "Postres";
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "menuForm";
            this.Text = "menuForm";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.menuForm_Load);
            this.panelContenedorMenu.ResumeLayout(false);
            this.panelCategorias.ResumeLayout(false);
            this.panelCategorias.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.menuStripCategorias.ResumeLayout(false);
            this.menuStripCategorias.PerformLayout();
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
        private System.Windows.Forms.Panel panelCards;
        private System.Windows.Forms.TextBox textBoxSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.Panel panelSearch;
    }
}