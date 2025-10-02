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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(515, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 39);
            this.label1.TabIndex = 0;
            // 
            // panelContenedorMenu
            // 
            this.panelContenedorMenu.BackColor = System.Drawing.Color.White;
            this.panelContenedorMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelContenedorMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorMenu.Location = new System.Drawing.Point(0, 0);
            this.panelContenedorMenu.Name = "panelContenedorMenu";
            this.panelContenedorMenu.Size = new System.Drawing.Size(630, 375);
            this.panelContenedorMenu.TabIndex = 1;
            this.panelContenedorMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedorMenu_Paint);
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 375);
            this.Controls.Add(this.panelContenedorMenu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menuForm";
            this.Text = "menuForm";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.menuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContenedorMenu;
    }
}