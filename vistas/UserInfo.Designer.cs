namespace ProyectoTienda.vistas
{
    partial class UserInfo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblColonia = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCambiarContra = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblCel = new System.Windows.Forms.Label();
            this.lblRFC = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoTienda.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(58, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.lblCalle.Location = new System.Drawing.Point(29, 171);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(69, 32);
            this.lblCalle.TabIndex = 3;
            this.lblCalle.Text = "Calle";
            // 
            // lblColonia
            // 
            this.lblColonia.AutoSize = true;
            this.lblColonia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.lblColonia.Location = new System.Drawing.Point(39, 212);
            this.lblColonia.Name = "lblColonia";
            this.lblColonia.Size = new System.Drawing.Size(101, 32);
            this.lblColonia.TabIndex = 4;
            this.lblColonia.Text = "Colonia";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.lblCiudad.Location = new System.Drawing.Point(29, 125);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(94, 32);
            this.lblCiudad.TabIndex = 5;
            this.lblCiudad.Text = "Ciudad";
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.lblMunicipio.Location = new System.Drawing.Point(37, 80);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(130, 32);
            this.lblMunicipio.TabIndex = 6;
            this.lblMunicipio.Text = "Municipio";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.lblPais.Location = new System.Drawing.Point(39, 38);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(59, 32);
            this.lblPais.TabIndex = 7;
            this.lblPais.Text = "Pais";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblColonia);
            this.groupBox1.Controls.Add(this.lblCalle);
            this.groupBox1.Controls.Add(this.lblPais);
            this.groupBox1.Controls.Add(this.lblCiudad);
            this.groupBox1.Controls.Add(this.lblMunicipio);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(303, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 260);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direccion";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnCambiarContra);
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.lblLogin);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(14, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 260);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login";
            // 
            // btnCambiarContra
            // 
            this.btnCambiarContra.BackColor = System.Drawing.Color.Black;
            this.btnCambiarContra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCambiarContra.Location = new System.Drawing.Point(54, 154);
            this.btnCambiarContra.Name = "btnCambiarContra";
            this.btnCambiarContra.Size = new System.Drawing.Size(156, 77);
            this.btnCambiarContra.TabIndex = 14;
            this.btnCambiarContra.Text = "Cambiar Contraseña";
            this.btnCambiarContra.UseVisualStyleBackColor = false;
            this.btnCambiarContra.Click += new System.EventHandler(this.btnCambiarContra_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(26, 54);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(76, 32);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(26, 105);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(78, 32);
            this.lblLogin.TabIndex = 13;
            this.lblLogin.Text = "Login";
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.lblCel.Location = new System.Drawing.Point(270, 90);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(94, 32);
            this.lblCel.TabIndex = 11;
            this.lblCel.Text = "Celular";
            // 
            // lblRFC
            // 
            this.lblRFC.AutoSize = true;
            this.lblRFC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.lblRFC.Location = new System.Drawing.Point(281, 47);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(57, 32);
            this.lblRFC.TabIndex = 10;
            this.lblRFC.Text = "RFC";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(256, 12);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(108, 32);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(82, 47);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(51, 32);
            this.lblRol.TabIndex = 11;
            this.lblRol.Text = "Rol";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(149, 181);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Nueva Contraseña";
            this.txtPassword.Size = new System.Drawing.Size(302, 39);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.Visible = false;
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(149, 248);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PlaceholderText = "Repetir Contraseña";
            this.txtPassword2.Size = new System.Drawing.Size(302, 39);
            this.txtPassword2.TabIndex = 13;
            this.txtPassword2.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(131, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(339, 57);
            this.button1.TabIndex = 15;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(601, 433);
            this.Controls.Add(this.lblCel);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblRFC);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.txtPassword);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UserInfo";
            this.Text = "UserInfo";
            this.Load += new System.EventHandler(this.UserInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblCalle;
        private Label lblColonia;
        private Label lblCiudad;
        private Label lblMunicipio;
        private Label lblPais;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnCambiarContra;
        private Label lblEmail;
        private Label lblLogin;
        private Label lblCel;
        private Label lblRFC;
        private Label lblNombre;
        private Label lblRol;
        private TextBox txtPassword;
        private TextBox txtPassword2;
        private Button button1;
    }
}