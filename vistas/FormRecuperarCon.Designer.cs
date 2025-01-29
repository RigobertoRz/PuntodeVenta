namespace ProyectoTienda.vistas
{
    partial class FormRecuperarCon
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
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRecuperarContra = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCorreo
            // 
            this.lblCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCorreo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCorreo.Location = new System.Drawing.Point(207, 264);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(91, 32);
            this.lblCorreo.TabIndex = 8;
            this.lblCorreo.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCorreo.Location = new System.Drawing.Point(304, 267);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(344, 33);
            this.txtCorreo.TabIndex = 7;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe Fluent Icons", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(71, 166);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(703, 64);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "RECUPERAR CONTRASEÑA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRecuperarContra
            // 
            this.btnRecuperarContra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRecuperarContra.BackColor = System.Drawing.Color.Transparent;
            this.btnRecuperarContra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecuperarContra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRecuperarContra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRecuperarContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecuperarContra.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRecuperarContra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRecuperarContra.Location = new System.Drawing.Point(250, 335);
            this.btnRecuperarContra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRecuperarContra.Name = "btnRecuperarContra";
            this.btnRecuperarContra.Size = new System.Drawing.Size(335, 45);
            this.btnRecuperarContra.TabIndex = 10;
            this.btnRecuperarContra.Text = "Recuperar Contraseña";
            this.btnRecuperarContra.UseVisualStyleBackColor = false;
            this.btnRecuperarContra.Click += new System.EventHandler(this.btnRecuperarContra_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMensaje.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMensaje.ForeColor = System.Drawing.Color.White;
            this.lblMensaje.Location = new System.Drawing.Point(0, 455);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(884, 78);
            this.lblMensaje.TabIndex = 11;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegresar.Location = new System.Drawing.Point(12, 12);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(197, 67);
            this.btnRegresar.TabIndex = 12;
            this.btnRegresar.Text = "Regresar al Login";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FormRecuperarCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoTienda.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(884, 533);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnRecuperarContra);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtCorreo);
            this.Name = "FormRecuperarCon";
            this.Text = "FormRecuperarCon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCorreo;
        private TextBox txtCorreo;
        private Label lblTitulo;
        private Button btnRecuperarContra;
        private Label lblMensaje;
        private Button btnRegresar;
    }
}