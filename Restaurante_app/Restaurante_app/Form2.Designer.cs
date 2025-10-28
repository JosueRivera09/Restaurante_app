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
            this.iconButtonEye = new FontAwesome.Sharp.IconButton();
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
            this.panelLogoLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogoLogin.Name = "panelLogoLogin";
            this.panelLogoLogin.Size = new System.Drawing.Size(377, 554);
            this.panelLogoLogin.TabIndex = 0;
            this.panelLogoLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogoLogin_Paint);
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.Image = global::Restaurante_app.Properties.Resources.restaurante_rotulacion_composicion_caligrafica_diseno_vintage;
            this.pictureBoxLogin.Location = new System.Drawing.Point(0, 88);
            this.pictureBoxLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(377, 316);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogin.TabIndex = 0;
            this.pictureBoxLogin.TabStop = false;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxName.Location = new System.Drawing.Point(564, 224);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(505, 36);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Text = "Usuario";
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxPassword.Location = new System.Drawing.Point(564, 316);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(505, 36);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.Text = "Contraseña";
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitle.Location = new System.Drawing.Point(665, 9);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(271, 54);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Iniciar Sesión";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // iconPictureBoxPassword
            // 
            this.iconPictureBoxPassword.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBoxPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBoxPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPictureBoxPassword.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBoxPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxPassword.IconSize = 70;
            this.iconPictureBoxPassword.Location = new System.Drawing.Point(474, 297);
            this.iconPictureBoxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconPictureBoxPassword.Name = "iconPictureBoxPassword";
            this.iconPictureBoxPassword.Size = new System.Drawing.Size(74, 76);
            this.iconPictureBoxPassword.TabIndex = 7;
            this.iconPictureBoxPassword.TabStop = false;
            this.iconPictureBoxPassword.Click += new System.EventHandler(this.iconPictureBoxPassword_Click);
            // 
            // iconPictureBoxUser
            // 
            this.iconPictureBoxUser.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBoxUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBoxUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBoxUser.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBoxUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxUser.IconSize = 70;
            this.iconPictureBoxUser.Location = new System.Drawing.Point(474, 203);
            this.iconPictureBoxUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconPictureBoxUser.Name = "iconPictureBoxUser";
            this.iconPictureBoxUser.Size = new System.Drawing.Size(74, 76);
            this.iconPictureBoxUser.TabIndex = 8;
            this.iconPictureBoxUser.TabStop = false;
            this.iconPictureBoxUser.Click += new System.EventHandler(this.iconPictureBoxUser_Click);
            // 
            // btnAceptarLogin
            // 
            this.btnAceptarLogin.BackColor = System.Drawing.Color.Turquoise;
            this.btnAceptarLogin.FlatAppearance.BorderSize = 0;
            this.btnAceptarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarLogin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAceptarLogin.Location = new System.Drawing.Point(564, 401);
            this.btnAceptarLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnAceptarLogin.Name = "btnAceptarLogin";
            this.btnAceptarLogin.Size = new System.Drawing.Size(160, 70);
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
            this.btnCancelarLogin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancelarLogin.Location = new System.Drawing.Point(909, 401);
            this.btnCancelarLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelarLogin.Name = "btnCancelarLogin";
            this.btnCancelarLogin.Size = new System.Drawing.Size(160, 70);
            this.btnCancelarLogin.TabIndex = 10;
            this.btnCancelarLogin.Text = "Cancelar";
            this.btnCancelarLogin.UseVisualStyleBackColor = false;
            this.btnCancelarLogin.Click += new System.EventHandler(this.btnCancelarLogin_Click);
            // 
            // iconButtonEye
            // 
            this.iconButtonEye.FlatAppearance.BorderSize = 0;
            this.iconButtonEye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconButtonEye.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonEye.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEye.IconSize = 40;
            this.iconButtonEye.Location = new System.Drawing.Point(1065, 316);
            this.iconButtonEye.Name = "iconButtonEye";
            this.iconButtonEye.Size = new System.Drawing.Size(58, 37);
            this.iconButtonEye.TabIndex = 11;
            this.iconButtonEye.UseVisualStyleBackColor = true;
            this.iconButtonEye.Click += new System.EventHandler(this.iconButtonEye_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1240, 554);
            this.Controls.Add(this.iconButtonEye);
            this.Controls.Add(this.btnCancelarLogin);
            this.Controls.Add(this.btnAceptarLogin);
            this.Controls.Add(this.iconPictureBoxUser);
            this.Controls.Add(this.iconPictureBoxPassword);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.panelLogoLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private FontAwesome.Sharp.IconButton iconButtonEye;
    }
}