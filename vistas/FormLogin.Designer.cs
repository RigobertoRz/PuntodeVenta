namespace ProyectoTienda.vistas
{
    partial class FormLogin
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
            txtNombre = new TextBox();
            txtContraseña = new TextBox();
            btnIngresar = new Button();
            lblMensaje = new Label();
            label2 = new Label();
            label3 = new Label();
            lblTitulo = new Label();
            lblOlvidarContraseña = new Label();
            btnHide = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.Font = new Font("Segoe UI", 14.25F);
            txtNombre.Location = new Point(411, 216);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(198, 33);
            txtNombre.TabIndex = 1;
            // 
            // txtContraseña
            // 
            txtContraseña.Anchor = AnchorStyles.None;
            txtContraseña.Font = new Font("Segoe UI", 15.75F);
            txtContraseña.Location = new Point(411, 261);
            txtContraseña.Margin = new Padding(3, 2, 3, 2);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(198, 35);
            txtContraseña.TabIndex = 2;
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.None;
            btnIngresar.BackColor = Color.Transparent;
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnIngresar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 18F);
            btnIngresar.ForeColor = SystemColors.ButtonHighlight;
            btnIngresar.Location = new Point(274, 361);
            btnIngresar.Margin = new Padding(3, 2, 3, 2);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(335, 45);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Iniciar Sesion";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.BackColor = Color.Transparent;
            lblMensaje.Dock = DockStyle.Bottom;
            lblMensaje.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblMensaje.ForeColor = Color.White;
            lblMensaje.Location = new Point(0, 455);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(884, 78);
            lblMensaje.TabIndex = 5;
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(303, 214);
            label2.Name = "label2";
            label2.Size = new Size(99, 32);
            label2.TabIndex = 6;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(274, 261);
            label3.Name = "label3";
            label3.Size = new Size(139, 32);
            label3.TabIndex = 7;
            label3.Text = "Contraseña:";
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.FlatStyle = FlatStyle.Flat;
            lblTitulo.Font = new Font("Segoe Fluent Icons", 48F, FontStyle.Bold);
            lblTitulo.ForeColor = SystemColors.ButtonHighlight;
            lblTitulo.Location = new Point(212, 104);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(516, 64);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "LOGIN DE USUARIO";
            // 
            // lblOlvidarContraseña
            // 
            lblOlvidarContraseña.Anchor = AnchorStyles.None;
            lblOlvidarContraseña.AutoSize = true;
            lblOlvidarContraseña.BackColor = Color.Transparent;
            lblOlvidarContraseña.Cursor = Cursors.Hand;
            lblOlvidarContraseña.Font = new Font("Segoe UI", 18F);
            lblOlvidarContraseña.ForeColor = SystemColors.ButtonHighlight;
            lblOlvidarContraseña.Location = new Point(317, 312);
            lblOlvidarContraseña.Name = "lblOlvidarContraseña";
            lblOlvidarContraseña.Size = new Size(262, 32);
            lblOlvidarContraseña.TabIndex = 9;
            lblOlvidarContraseña.Text = "¿Olvidaste Contraseña?";
            lblOlvidarContraseña.Click += lblOlvidarContraseña_Click;
            // 
            // btnHide
            // 
            btnHide.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnHide.BackgroundImage = Properties.Resources.hidden;
            btnHide.BackgroundImageLayout = ImageLayout.Zoom;
            btnHide.FlatStyle = FlatStyle.Popup;
            btnHide.Location = new Point(561, 261);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(48, 35);
            btnHide.TabIndex = 10;
            btnHide.UseVisualStyleBackColor = true;
            btnHide.Visible = false;
            btnHide.Click += btnHide_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(884, 533);
            Controls.Add(btnHide);
            Controls.Add(lblOlvidarContraseña);
            Controls.Add(lblTitulo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblMensaje);
            Controls.Add(btnIngresar);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombre);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormLogin";
            Text = "Inicio de Sesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNombre;
        private TextBox txtContraseña;
        private Button btnIngresar;
        private Label lblMensaje;
        private Label label2;
        private Label label3;
        private Label lblTitulo;
        private Label lblOlvidarContraseña;
        private Button btnHide;
    }
}