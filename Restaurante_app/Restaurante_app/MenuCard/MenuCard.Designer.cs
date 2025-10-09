namespace Restaurante_app.MenuCard
{
    partial class MenuCard
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelCardContainer = new System.Windows.Forms.Panel();
            this.pictureBoxCont = new System.Windows.Forms.PictureBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.iconButtonCheck = new FontAwesome.Sharp.IconButton();
            this.panelCardContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCont)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCardContainer
            // 
            this.panelCardContainer.BackColor = System.Drawing.Color.Gainsboro;
            this.panelCardContainer.Controls.Add(this.iconButtonCheck);
            this.panelCardContainer.Controls.Add(this.labelPrecio);
            this.panelCardContainer.Controls.Add(this.labelDescripcion);
            this.panelCardContainer.Controls.Add(this.labelNombre);
            this.panelCardContainer.Controls.Add(this.pictureBoxCont);
            this.panelCardContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCardContainer.Location = new System.Drawing.Point(0, 0);
            this.panelCardContainer.Name = "panelCardContainer";
            this.panelCardContainer.Size = new System.Drawing.Size(205, 265);
            this.panelCardContainer.TabIndex = 0;
            // 
            // pictureBoxCont
            // 
            this.pictureBoxCont.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCont.Image = global::Restaurante_app.Properties.Resources.restaurante_rotulacion_composicion_caligrafica_diseno_vintage;
            this.pictureBoxCont.Location = new System.Drawing.Point(48, 3);
            this.pictureBoxCont.Name = "pictureBoxCont";
            this.pictureBoxCont.Size = new System.Drawing.Size(106, 109);
            this.pictureBoxCont.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCont.TabIndex = 0;
            this.pictureBoxCont.TabStop = false;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(67, 126);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(56, 16);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(56, 161);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(79, 16);
            this.labelDescripcion.TabIndex = 2;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(3, 232);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(47, 16);
            this.labelPrecio.TabIndex = 3;
            this.labelPrecio.Text = "C$ 110";
            // 
            // iconButtonCheck
            // 
            this.iconButtonCheck.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonCheck.FlatAppearance.BorderSize = 0;
            this.iconButtonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCheck.ForeColor = System.Drawing.Color.Transparent;
            this.iconButtonCheck.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconButtonCheck.IconColor = System.Drawing.Color.Black;
            this.iconButtonCheck.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCheck.Location = new System.Drawing.Point(148, 213);
            this.iconButtonCheck.Name = "iconButtonCheck";
            this.iconButtonCheck.Size = new System.Drawing.Size(54, 48);
            this.iconButtonCheck.TabIndex = 4;
            this.iconButtonCheck.UseVisualStyleBackColor = false;
            // 
            // MenuCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelCardContainer);
            this.Name = "MenuCard";
            this.Size = new System.Drawing.Size(205, 265);
            this.panelCardContainer.ResumeLayout(false);
            this.panelCardContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCont)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCardContainer;
        private System.Windows.Forms.PictureBox pictureBoxCont;
        private FontAwesome.Sharp.IconButton iconButtonCheck;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelNombre;
    }
}
