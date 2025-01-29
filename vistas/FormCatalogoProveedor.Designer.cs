namespace ProyectoTienda.vistas
{
    partial class FormCatalogoProveedor
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            pLateral = new Panel();
            pMenuLateral = new Panel();
            btnComprar = new PictureBox();
            btnReportes = new PictureBox();
            btnClientes = new PictureBox();
            btnUsuarios = new PictureBox();
            btnProductos = new PictureBox();
            btnPrincipal = new PictureBox();
            btnProveedores = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pHeader = new Panel();
            cbBuscar = new ComboBox();
            btnAgregar = new Button();
            txtBuscar = new TextBox();
            PbUsuario = new PictureBox();
            lblHora = new Label();
            lblUsuario = new Label();
            dgvPrincipal = new DataGridView();
            C_ID = new DataGridViewTextBoxColumn();
            C_Nombre = new DataGridViewTextBoxColumn();
            C_RFC = new DataGridViewTextBoxColumn();
            C_Calle = new DataGridViewTextBoxColumn();
            C_Numero = new DataGridViewTextBoxColumn();
            C_Colonia = new DataGridViewTextBoxColumn();
            C_Municipio = new DataGridViewTextBoxColumn();
            C_Ciudad = new DataGridViewTextBoxColumn();
            C_Pais = new DataGridViewTextBoxColumn();
            C_CP = new DataGridViewTextBoxColumn();
            C_Email = new DataGridViewTextBoxColumn();
            C_Celular = new DataGridViewTextBoxColumn();
            C_RazonSocial = new DataGridViewTextBoxColumn();
            C_NombreCont = new DataGridViewTextBoxColumn();
            C_TelefonoContact = new DataGridViewTextBoxColumn();
            C_ApellidoP = new DataGridViewTextBoxColumn();
            C_ApellidoM = new DataGridViewTextBoxColumn();
            C_EmailC = new DataGridViewTextBoxColumn();
            C_Modificar = new DataGridViewButtonColumn();
            C_Eliminar = new DataGridViewButtonColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            pLateral.SuspendLayout();
            pMenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnComprar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnReportes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPrincipal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnProveedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPrincipal).BeginInit();
            SuspendLayout();
            // 
            // pLateral
            // 
            pLateral.BackColor = Color.FromArgb(41, 45, 74);
            pLateral.BackgroundImageLayout = ImageLayout.Center;
            pLateral.Controls.Add(pMenuLateral);
            pLateral.Dock = DockStyle.Left;
            pLateral.Location = new Point(0, 0);
            pLateral.Name = "pLateral";
            pLateral.Size = new Size(130, 780);
            pLateral.TabIndex = 4;
            // 
            // pMenuLateral
            // 
            pMenuLateral.Anchor = AnchorStyles.None;
            pMenuLateral.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pMenuLateral.BackColor = Color.Transparent;
            pMenuLateral.BackgroundImage = Properties.Resources.BarraLateral;
            pMenuLateral.BackgroundImageLayout = ImageLayout.Stretch;
            pMenuLateral.BorderStyle = BorderStyle.FixedSingle;
            pMenuLateral.Controls.Add(btnComprar);
            pMenuLateral.Controls.Add(btnReportes);
            pMenuLateral.Controls.Add(btnClientes);
            pMenuLateral.Controls.Add(btnUsuarios);
            pMenuLateral.Controls.Add(btnProductos);
            pMenuLateral.Controls.Add(btnPrincipal);
            pMenuLateral.Controls.Add(btnProveedores);
            pMenuLateral.Controls.Add(pictureBox1);
            pMenuLateral.Controls.Add(pictureBox2);
            pMenuLateral.Location = new Point(-6, 39);
            pMenuLateral.Name = "pMenuLateral";
            pMenuLateral.Size = new Size(68, 725);
            pMenuLateral.TabIndex = 15;
            // 
            // btnComprar
            // 
            btnComprar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnComprar.Cursor = Cursors.Hand;
            btnComprar.Image = Properties.Resources.Comprar_B;
            btnComprar.Location = new Point(15, 104);
            btnComprar.Margin = new Padding(0);
            btnComprar.MaximumSize = new Size(66, 155);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(41, 91);
            btnComprar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnComprar.TabIndex = 20;
            btnComprar.TabStop = false;
            btnComprar.Tag = "5";
            btnComprar.Click += BotonesLaterales_Click;
            // 
            // btnReportes
            // 
            btnReportes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnReportes.Cursor = Cursors.Hand;
            btnReportes.Image = Properties.Resources.Reportes_B;
            btnReportes.Location = new Point(15, 630);
            btnReportes.Margin = new Padding(0);
            btnReportes.MaximumSize = new Size(66, 155);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(41, 91);
            btnReportes.SizeMode = PictureBoxSizeMode.StretchImage;
            btnReportes.TabIndex = 19;
            btnReportes.TabStop = false;
            btnReportes.Tag = "4";
            btnReportes.Click += BotonesLaterales_Click;
            // 
            // btnClientes
            // 
            btnClientes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.Image = Properties.Resources.Clientes_B;
            btnClientes.Location = new Point(15, 312);
            btnClientes.Margin = new Padding(0);
            btnClientes.MaximumSize = new Size(66, 155);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(41, 91);
            btnClientes.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClientes.TabIndex = 21;
            btnClientes.TabStop = false;
            btnClientes.Tag = "6";
            btnClientes.Click += BotonesLaterales_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.Image = Properties.Resources.Usuarios_B;
            btnUsuarios.Location = new Point(15, 208);
            btnUsuarios.Margin = new Padding(0);
            btnUsuarios.MaximumSize = new Size(66, 155);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(41, 91);
            btnUsuarios.SizeMode = PictureBoxSizeMode.StretchImage;
            btnUsuarios.TabIndex = 16;
            btnUsuarios.TabStop = false;
            btnUsuarios.Tag = "1";
            btnUsuarios.Click += BotonesLaterales_Click;
            // 
            // btnProductos
            // 
            btnProductos.Cursor = Cursors.Hand;
            btnProductos.Image = Properties.Resources.Productos_B;
            btnProductos.Location = new Point(15, 417);
            btnProductos.Margin = new Padding(0);
            btnProductos.MaximumSize = new Size(66, 155);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(42, 91);
            btnProductos.SizeMode = PictureBoxSizeMode.StretchImage;
            btnProductos.TabIndex = 17;
            btnProductos.TabStop = false;
            btnProductos.Tag = "2";
            btnProductos.Click += BotonesLaterales_Click;
            // 
            // btnPrincipal
            // 
            btnPrincipal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnPrincipal.Cursor = Cursors.Hand;
            btnPrincipal.Image = Properties.Resources.Principal_B;
            btnPrincipal.Location = new Point(15, 3);
            btnPrincipal.Margin = new Padding(0);
            btnPrincipal.MaximumSize = new Size(66, 155);
            btnPrincipal.Name = "btnPrincipal";
            btnPrincipal.Size = new Size(41, 92);
            btnPrincipal.SizeMode = PictureBoxSizeMode.StretchImage;
            btnPrincipal.TabIndex = 15;
            btnPrincipal.TabStop = false;
            btnPrincipal.Tag = "0";
            btnPrincipal.Click += BotonesLaterales_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnProveedores.Cursor = Cursors.Hand;
            btnProveedores.Image = Properties.Resources.Proveedores_A;
            btnProveedores.Location = new Point(15, 520);
            btnProveedores.Margin = new Padding(0);
            btnProveedores.MaximumSize = new Size(66, 155);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(41, 91);
            btnProveedores.SizeMode = PictureBoxSizeMode.StretchImage;
            btnProveedores.TabIndex = 18;
            btnProveedores.TabStop = false;
            btnProveedores.Tag = "3";
            btnProveedores.Click += BotonesLaterales_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.Reportes_B;
            pictureBox1.Location = new Point(-180, 1946);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "4";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.Proveedores_B;
            pictureBox2.Location = new Point(-180, 1758);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(66, 155);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "3";
            // 
            // pHeader
            // 
            pHeader.Controls.Add(cbBuscar);
            pHeader.Controls.Add(btnAgregar);
            pHeader.Controls.Add(txtBuscar);
            pHeader.Controls.Add(PbUsuario);
            pHeader.Controls.Add(lblHora);
            pHeader.Controls.Add(lblUsuario);
            pHeader.Dock = DockStyle.Top;
            pHeader.Location = new Point(130, 0);
            pHeader.Name = "pHeader";
            pHeader.Size = new Size(1150, 137);
            pHeader.TabIndex = 16;
            // 
            // cbBuscar
            // 
            cbBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbBuscar.BackColor = SystemColors.Window;
            cbBuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBuscar.FlatStyle = FlatStyle.Popup;
            cbBuscar.Font = new Font("Century Gothic", 12F);
            cbBuscar.FormattingEnabled = true;
            cbBuscar.Items.AddRange(new object[] { "ID", "Nombre", "RFC", "Calle", "Numero", "Colonia", "Municipio", "Ciudad", "Pais", "`CP", "Email", "Telefono", "Razon Social", "Nombre Contacto", "Telefono Contacto", "Apellido Paterno", "Apellido Materno", "Email Contacto" });
            cbBuscar.Location = new Point(812, 90);
            cbBuscar.Name = "cbBuscar";
            cbBuscar.Size = new Size(116, 29);
            cbBuscar.TabIndex = 18;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAgregar.BackColor = Color.FromArgb(28, 78, 254);
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            btnAgregar.ForeColor = SystemColors.ButtonHighlight;
            btnAgregar.Location = new Point(931, 86);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(193, 33);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Agregar Proveedor";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Font = new Font("Century Gothic", 15.75F);
            txtBuscar.Location = new Point(15, 87);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar";
            txtBuscar.Size = new Size(791, 33);
            txtBuscar.TabIndex = 14;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // PbUsuario
            // 
            PbUsuario.Image = Properties.Resources.Usuario;
            PbUsuario.Location = new Point(11, 18);
            PbUsuario.Name = "PbUsuario";
            PbUsuario.Size = new Size(33, 33);
            PbUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            PbUsuario.TabIndex = 10;
            PbUsuario.TabStop = false;
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHora.Font = new Font("Segoe Fluent Icons", 24F);
            lblHora.Location = new Point(688, 14);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(450, 48);
            lblHora.TabIndex = 14;
            lblHora.Text = "Miercoles 27 de abril de 2022 4:24 PM ";
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblUsuario.Font = new Font("Segoe Fluent Icons", 24F, FontStyle.Bold);
            lblUsuario.Location = new Point(50, 14);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(283, 48);
            lblUsuario.TabIndex = 11;
            lblUsuario.Text = "Usuario";
            // 
            // dgvPrincipal
            // 
            dgvPrincipal.AllowUserToAddRows = false;
            dgvPrincipal.AllowUserToDeleteRows = false;
            dgvPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPrincipal.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(185, 185, 185);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPrincipal.ColumnHeadersHeight = 50;
            dgvPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPrincipal.Columns.AddRange(new DataGridViewColumn[] { C_ID, C_Nombre, C_RFC, C_Calle, C_Numero, C_Colonia, C_Municipio, C_Ciudad, C_Pais, C_CP, C_Email, C_Celular, C_RazonSocial, C_NombreCont, C_TelefonoContact, C_ApellidoP, C_ApellidoM, C_EmailC, C_Modificar, C_Eliminar });
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = SystemColors.Window;
            dataGridViewCellStyle22.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle22.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.False;
            dgvPrincipal.DefaultCellStyle = dataGridViewCellStyle22;
            dgvPrincipal.Location = new Point(141, 143);
            dgvPrincipal.Name = "dgvPrincipal";
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = SystemColors.Control;
            dataGridViewCellStyle23.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle23.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = DataGridViewTriState.True;
            dgvPrincipal.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            dgvPrincipal.RowHeadersVisible = false;
            dgvPrincipal.RowTemplate.Height = 50;
            dgvPrincipal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrincipal.Size = new Size(1127, 625);
            dgvPrincipal.TabIndex = 21;
            dgvPrincipal.CellContentClick += dgvPrincipal_CellContentClick;
            dgvPrincipal.EditingControlShowing += dgvPrincipal_EditingControlShowing;
            // 
            // C_ID
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 20.25F);
            C_ID.DefaultCellStyle = dataGridViewCellStyle2;
            C_ID.HeaderText = "ID";
            C_ID.Name = "C_ID";
            C_ID.ReadOnly = true;
            C_ID.Width = 60;
            // 
            // C_Nombre
            // 
            C_Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 20.25F);
            C_Nombre.DefaultCellStyle = dataGridViewCellStyle3;
            C_Nombre.FillWeight = 14.59854F;
            C_Nombre.HeaderText = "Nombre";
            C_Nombre.Name = "C_Nombre";
            C_Nombre.ReadOnly = true;
            C_Nombre.Width = 148;
            // 
            // C_RFC
            // 
            C_RFC.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 20.25F);
            C_RFC.DefaultCellStyle = dataGridViewCellStyle4;
            C_RFC.HeaderText = "RFC";
            C_RFC.Name = "C_RFC";
            C_RFC.ReadOnly = true;
            C_RFC.Width = 91;
            // 
            // C_Calle
            // 
            C_Calle.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 20.25F);
            C_Calle.DefaultCellStyle = dataGridViewCellStyle5;
            C_Calle.HeaderText = "Calle";
            C_Calle.Name = "C_Calle";
            C_Calle.ReadOnly = true;
            C_Calle.Width = 105;
            // 
            // C_Numero
            // 
            C_Numero.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 20.25F);
            C_Numero.DefaultCellStyle = dataGridViewCellStyle6;
            C_Numero.HeaderText = "Numero";
            C_Numero.Name = "C_Numero";
            C_Numero.ReadOnly = true;
            C_Numero.Width = 147;
            // 
            // C_Colonia
            // 
            C_Colonia.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 20.25F);
            C_Colonia.DefaultCellStyle = dataGridViewCellStyle7;
            C_Colonia.HeaderText = "Colonia";
            C_Colonia.Name = "C_Colonia";
            C_Colonia.ReadOnly = true;
            C_Colonia.Width = 140;
            // 
            // C_Municipio
            // 
            C_Municipio.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 20.25F);
            C_Municipio.DefaultCellStyle = dataGridViewCellStyle8;
            C_Municipio.HeaderText = "Municipio";
            C_Municipio.Name = "C_Municipio";
            C_Municipio.ReadOnly = true;
            C_Municipio.Width = 171;
            // 
            // C_Ciudad
            // 
            C_Ciudad.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 20.25F);
            C_Ciudad.DefaultCellStyle = dataGridViewCellStyle9;
            C_Ciudad.HeaderText = "Ciudad";
            C_Ciudad.Name = "C_Ciudad";
            C_Ciudad.ReadOnly = true;
            C_Ciudad.Width = 132;
            // 
            // C_Pais
            // 
            C_Pais.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 20.25F);
            C_Pais.DefaultCellStyle = dataGridViewCellStyle10;
            C_Pais.HeaderText = "Pais";
            C_Pais.Name = "C_Pais";
            C_Pais.ReadOnly = true;
            C_Pais.Width = 93;
            // 
            // C_CP
            // 
            C_CP.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 20.25F);
            C_CP.DefaultCellStyle = dataGridViewCellStyle11;
            C_CP.HeaderText = "CP";
            C_CP.Name = "C_CP";
            C_CP.ReadOnly = true;
            C_CP.Width = 76;
            // 
            // C_Email
            // 
            C_Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 20.25F);
            C_Email.DefaultCellStyle = dataGridViewCellStyle12;
            C_Email.HeaderText = "Email";
            C_Email.Name = "C_Email";
            C_Email.ReadOnly = true;
            C_Email.Width = 112;
            // 
            // C_Celular
            // 
            C_Celular.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 20.25F);
            C_Celular.DefaultCellStyle = dataGridViewCellStyle13;
            C_Celular.HeaderText = "Telefono";
            C_Celular.Name = "C_Celular";
            C_Celular.ReadOnly = true;
            C_Celular.Width = 154;
            // 
            // C_RazonSocial
            // 
            C_RazonSocial.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 20.25F);
            C_RazonSocial.DefaultCellStyle = dataGridViewCellStyle14;
            C_RazonSocial.HeaderText = "Razon Social";
            C_RazonSocial.Name = "C_RazonSocial";
            C_RazonSocial.ReadOnly = true;
            C_RazonSocial.Width = 204;
            // 
            // C_NombreCont
            // 
            C_NombreCont.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 20.25F);
            C_NombreCont.DefaultCellStyle = dataGridViewCellStyle15;
            C_NombreCont.HeaderText = "Nombre Contacto";
            C_NombreCont.Name = "C_NombreCont";
            C_NombreCont.ReadOnly = true;
            C_NombreCont.Width = 272;
            // 
            // C_TelefonoContact
            // 
            C_TelefonoContact.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle16.Font = new Font("Microsoft Sans Serif", 20.25F);
            C_TelefonoContact.DefaultCellStyle = dataGridViewCellStyle16;
            C_TelefonoContact.HeaderText = "Telefono Contacto";
            C_TelefonoContact.Name = "C_TelefonoContact";
            C_TelefonoContact.ReadOnly = true;
            C_TelefonoContact.Width = 278;
            // 
            // C_ApellidoP
            // 
            C_ApellidoP.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Font = new Font("Microsoft Sans Serif", 20.25F);
            dataGridViewCellStyle17.NullValue = null;
            C_ApellidoP.DefaultCellStyle = dataGridViewCellStyle17;
            C_ApellidoP.FillWeight = 385.4015F;
            C_ApellidoP.HeaderText = "ApellidoP";
            C_ApellidoP.Name = "C_ApellidoP";
            C_ApellidoP.ReadOnly = true;
            C_ApellidoP.Width = 168;
            // 
            // C_ApellidoM
            // 
            C_ApellidoM.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle18.Font = new Font("Microsoft Sans Serif", 20.25F);
            C_ApellidoM.DefaultCellStyle = dataGridViewCellStyle18;
            C_ApellidoM.HeaderText = "ApellidoM";
            C_ApellidoM.Name = "C_ApellidoM";
            C_ApellidoM.ReadOnly = true;
            C_ApellidoM.Width = 177;
            // 
            // C_EmailC
            // 
            C_EmailC.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle19.Font = new Font("Microsoft Sans Serif", 20.25F);
            C_EmailC.DefaultCellStyle = dataGridViewCellStyle19;
            C_EmailC.HeaderText = "Email Contacto";
            C_EmailC.Name = "C_EmailC";
            C_EmailC.Width = 236;
            // 
            // C_Modificar
            // 
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = Color.Yellow;
            dataGridViewCellStyle20.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            C_Modificar.DefaultCellStyle = dataGridViewCellStyle20;
            C_Modificar.FlatStyle = FlatStyle.Popup;
            C_Modificar.HeaderText = "";
            C_Modificar.Name = "C_Modificar";
            C_Modificar.Resizable = DataGridViewTriState.True;
            C_Modificar.SortMode = DataGridViewColumnSortMode.Automatic;
            C_Modificar.Text = "✎Modificar";
            C_Modificar.UseColumnTextForButtonValue = true;
            C_Modificar.Width = 150;
            // 
            // C_Eliminar
            // 
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = Color.Red;
            dataGridViewCellStyle21.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            C_Eliminar.DefaultCellStyle = dataGridViewCellStyle21;
            C_Eliminar.FlatStyle = FlatStyle.Popup;
            C_Eliminar.HeaderText = "";
            C_Eliminar.Name = "C_Eliminar";
            C_Eliminar.Resizable = DataGridViewTriState.True;
            C_Eliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            C_Eliminar.Text = "🗑Borrar";
            C_Eliminar.UseColumnTextForButtonValue = true;
            C_Eliminar.Width = 150;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FormCatalogoProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 780);
            Controls.Add(dgvPrincipal);
            Controls.Add(pHeader);
            Controls.Add(pLateral);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCatalogoProveedor";
            Text = "CatalogoProveedor";
            WindowState = FormWindowState.Maximized;
            Load += FormCatalogoProveedor_Load;
            pLateral.ResumeLayout(false);
            pMenuLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnComprar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnReportes).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPrincipal).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnProveedores).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pHeader.ResumeLayout(false);
            pHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPrincipal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pLateral;
        private Panel pHeader;
        private Button btnAgregar;
        private TextBox txtBuscar;
        private PictureBox PbUsuario;
        private Label lblHora;
        private Label lblUsuario;
        private DataGridView dgvPrincipal;
        private System.Windows.Forms.Timer timer1;
        private ComboBox cbBuscar;
        private DataGridViewTextBoxColumn C_ID;
        private DataGridViewTextBoxColumn C_Nombre;
        private DataGridViewTextBoxColumn C_RFC;
        private DataGridViewTextBoxColumn C_Calle;
        private DataGridViewTextBoxColumn C_Numero;
        private DataGridViewTextBoxColumn C_Colonia;
        private DataGridViewTextBoxColumn C_Municipio;
        private DataGridViewTextBoxColumn C_Ciudad;
        private DataGridViewTextBoxColumn C_Pais;
        private DataGridViewTextBoxColumn C_CP;
        private DataGridViewTextBoxColumn C_Email;
        private DataGridViewTextBoxColumn C_Celular;
        private DataGridViewTextBoxColumn C_RazonSocial;
        private DataGridViewTextBoxColumn C_NombreCont;
        private DataGridViewTextBoxColumn C_TelefonoContact;
        private DataGridViewTextBoxColumn C_ApellidoP;
        private DataGridViewTextBoxColumn C_ApellidoM;
        private DataGridViewTextBoxColumn C_EmailC;
        private DataGridViewButtonColumn C_Modificar;
        private DataGridViewButtonColumn C_Eliminar;
        private Panel pMenuLateral;
        private PictureBox btnComprar;
        private PictureBox btnReportes;
        private PictureBox btnClientes;
        private PictureBox btnUsuarios;
        private PictureBox btnProductos;
        private PictureBox btnPrincipal;
        private PictureBox btnProveedores;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}