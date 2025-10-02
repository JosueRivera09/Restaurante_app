namespace Restaurante_app
{
    partial class LoginPage
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
            this.panelLogoLogin = new System.Windows.Forms.Panel();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.iconPictureBoxPassword = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBoxUser = new FontAwesome.Sharp.IconPictureBox();
            this.btnAceptarLogin = new System.Windows.Forms.Button();
            this.btnCancelarLogin = new System.Windows.Forms.Button();
            this.panelLogoLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogoLogin
            // 
            this.panelLogoLogin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelLogoLogin.Controls.Add(this.pictureBoxLogin);
            this.panelLogoLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogoLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogoLogin.Name = "panelLogoLogin";
            this.panelLogoLogin.Size = new System.Drawing.Size(178, 298);
            this.panelLogoLogin.TabIndex = 0;
            this.panelLogoLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogoLogin_Paint);
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.Image = global::Restaurante_app.Properties.Resources.restaurante_rotulacion_composicion_caligrafica_diseno_vintage;
            this.pictureBoxLogin.Location = new System.Drawing.Point(0, 66);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(178, 153);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogin.TabIndex = 0;
            this.pictureBoxLogin.TabStop = false;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.ForeColor = System.Drawing.Color.White;
            this.textBoxName.Location = new System.Drawing.Point(302, 88);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(20);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(258, 13);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.ForeColor = System.Drawing.Color.White;
            this.textBoxPassword.Location = new System.Drawing.Point(302, 137);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(20);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(258, 13);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(377, 19);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(72, 24);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "LOGIN";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // iconPictureBoxPassword
            // 
            this.iconPictureBoxPassword.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBoxPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPictureBoxPassword.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxPassword.IconSize = 30;
            this.iconPictureBoxPassword.Location = new System.Drawing.Point(263, 131);
            this.iconPictureBoxPassword.Name = "iconPictureBoxPassword";
            this.iconPictureBoxPassword.Size = new System.Drawing.Size(38, 34);
            this.iconPictureBoxPassword.TabIndex = 7;
            this.iconPictureBoxPassword.TabStop = false;
            this.iconPictureBoxPassword.Click += new System.EventHandler(this.iconPictureBoxPassword_Click);
            // 
            // iconPictureBoxUser
            // 
            this.iconPictureBoxUser.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBoxUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBoxUser.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxUser.IconSize = 30;
            this.iconPictureBoxUser.Location = new System.Drawing.Point(261, 81);
            this.iconPictureBoxUser.Name = "iconPictureBoxUser";
            this.iconPictureBoxUser.Size = new System.Drawing.Size(37, 46);
            this.iconPictureBoxUser.TabIndex = 8;
            this.iconPictureBoxUser.TabStop = false;
            this.iconPictureBoxUser.Click += new System.EventHandler(this.iconPictureBoxUser_Click);
            // 
            // btnAceptarLogin
            // 
            this.btnAceptarLogin.BackColor = System.Drawing.Color.Turquoise;
            this.btnAceptarLogin.FlatAppearance.BorderSize = 0;
            this.btnAceptarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarLogin.ForeColor = System.Drawing.Color.White;
            this.btnAceptarLogin.Location = new System.Drawing.Point(302, 205);
            this.btnAceptarLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnAceptarLogin.Name = "btnAceptarLogin";
            this.btnAceptarLogin.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarLogin.TabIndex = 9;
            this.btnAceptarLogin.Text = "Aceptar";
            this.btnAceptarLogin.UseVisualStyleBackColor = false;
            this.btnAceptarLogin.Click += new System.EventHandler(this.btnAceptarLogin_Click);
            // 
            // btnCancelarLogin
            // 
            this.btnCancelarLogin.BackColor = System.Drawing.Color.Turquoise;
            this.btnCancelarLogin.FlatAppearance.BorderSize = 0;
            this.btnCancelarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarLogin.ForeColor = System.Drawing.Color.White;
            this.btnCancelarLogin.Location = new System.Drawing.Point(485, 205);
            this.btnCancelarLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelarLogin.Name = "btnCancelarLogin";
            this.btnCancelarLogin.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarLogin.TabIndex = 10;
            this.btnCancelarLogin.Text = "Cancelar";
            this.btnCancelarLogin.UseVisualStyleBackColor = false;
            this.btnCancelarLogin.Click += new System.EventHandler(this.btnCancelarLogin_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(712, 298);
            this.Controls.Add(this.btnCancelarLogin);
            this.Controls.Add(this.btnAceptarLogin);
            this.Controls.Add(this.iconPictureBoxUser);
            this.Controls.Add(this.iconPictureBoxPassword);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.panelLogoLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.panelLogoLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogoLogin;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.Label labelTitle;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxPassword;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxUser;
        private System.Windows.Forms.Button btnAceptarLogin;
        private System.Windows.Forms.Button btnCancelarLogin;
    }
}