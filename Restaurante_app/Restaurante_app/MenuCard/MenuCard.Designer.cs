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
            this.labelNombre = new System.Windows.Forms.Label();
            this.btnOrden = new FontAwesome.Sharp.IconButton();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelExistencias = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.pictureBoxCont = new System.Windows.Forms.PictureBox();
            this.panelCardContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCont)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCardContainer
            // 
            this.panelCardContainer.BackColor = System.Drawing.Color.Gray;
            this.panelCardContainer.Controls.Add(this.labelNombre);
            this.panelCardContainer.Controls.Add(this.btnOrden);
            this.panelCardContainer.Controls.Add(this.labelDescripcion);
            this.panelCardContainer.Controls.Add(this.labelExistencias);
            this.panelCardContainer.Controls.Add(this.labelPrecio);
            this.panelCardContainer.Controls.Add(this.pictureBoxCont);
            this.panelCardContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCardContainer.Location = new System.Drawing.Point(0, 0);
            this.panelCardContainer.Name = "panelCardContainer";
            this.panelCardContainer.Size = new System.Drawing.Size(324, 414);
            this.panelCardContainer.TabIndex = 0;
            this.panelCardContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCardContainer_Paint);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelNombre.Location = new System.Drawing.Point(72, 228);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(73, 23);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNombre.Click += new System.EventHandler(this.labelNombre_Click);
            // 
            // btnOrden
            // 
            this.btnOrden.BackColor = System.Drawing.Color.Transparent;
            this.btnOrden.FlatAppearance.BorderSize = 0;
            this.btnOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrden.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOrden.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            this.btnOrden.IconColor = System.Drawing.Color.Gainsboro;
            this.btnOrden.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrden.Location = new System.Drawing.Point(274, 355);
            this.btnOrden.Name = "btnOrden";
            this.btnOrden.Size = new System.Drawing.Size(66, 69);
            this.btnOrden.TabIndex = 7;
            this.btnOrden.UseVisualStyleBackColor = false;
            this.btnOrden.Click += new System.EventHandler(this.btnOrden_Click);
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDescripcion.Location = new System.Drawing.Point(72, 284);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(87, 20);
            this.labelDescripcion.TabIndex = 2;
            this.labelDescripcion.Text = "Descripcion";
            this.labelDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDescripcion.Click += new System.EventHandler(this.labelDescripcion_Click);
            // 
            // labelExistencias
            // 
            this.labelExistencias.AutoSize = true;
            this.labelExistencias.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExistencias.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelExistencias.Location = new System.Drawing.Point(73, 398);
            this.labelExistencias.Name = "labelExistencias";
            this.labelExistencias.Size = new System.Drawing.Size(22, 17);
            this.labelExistencias.TabIndex = 5;
            this.labelExistencias.Text = "10";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelPrecio.Location = new System.Drawing.Point(3, 335);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(78, 28);
            this.labelPrecio.TabIndex = 3;
            this.labelPrecio.Text = "C$ 110";
            // 
            // pictureBoxCont
            // 
            this.pictureBoxCont.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCont.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCont.Image = global::Restaurante_app.Properties.Resources.bebida_sprite;
            this.pictureBoxCont.Location = new System.Drawing.Point(54, 3);
            this.pictureBoxCont.Name = "pictureBoxCont";
            this.pictureBoxCont.Size = new System.Drawing.Size(208, 200);
            this.pictureBoxCont.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCont.TabIndex = 0;
            this.pictureBoxCont.TabStop = false;
            this.pictureBoxCont.Click += new System.EventHandler(this.pictureBoxCont_Click);
            // 
            // MenuCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelCardContainer);
            this.Name = "MenuCard";
            this.Size = new System.Drawing.Size(324, 414);
            this.Load += new System.EventHandler(this.MenuCard_Load);
            this.panelCardContainer.ResumeLayout(false);
            this.panelCardContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCont)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCardContainer;
        private System.Windows.Forms.PictureBox pictureBoxCont;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelExistencias;
        private System.Windows.Forms.Label labelNombre;
        private FontAwesome.Sharp.IconButton btnOrden;
    }
}
