namespace ProyectoTienda.vistas
{
    partial class FormCatalogoClientes
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
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
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
            pLateral = new Panel();
            pMenuLateral = new Panel();
            btnReportes = new PictureBox();
            pictureBox1 = new PictureBox();
            btnComprar = new PictureBox();
            pictureBox2 = new PictureBox();
            btnProductos = new PictureBox();
            btnUsuarios = new PictureBox();
            btnProveedores = new PictureBox();
            btnPrincipal = new PictureBox();
            btnClientes = new PictureBox();
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
            C_ApellidoP = new DataGridViewTextBoxColumn();
            C_ApellidoM = new DataGridViewTextBoxColumn();
            C_RFC = new DataGridViewTextBoxColumn();
            C_Calle = new DataGridViewTextBoxColumn();
            C_CP = new DataGridViewTextBoxColumn();
            C_Colonia = new DataGridViewTextBoxColumn();
            C_Municipio = new DataGridViewTextBoxColumn();
            C_Estado = new DataGridViewTextBoxColumn();
            C_Pais = new DataGridViewTextBoxColumn();
            C_Celular = new DataGridViewTextBoxColumn();
            C_Email = new DataGridViewTextBoxColumn();
            C_Modificar = new DataGridViewButtonColumn();
            C_Eliminar = new DataGridViewButtonColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            pLateral.SuspendLayout();
            pMenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnReportes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnComprar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnProveedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPrincipal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClientes).BeginInit();
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
            pLateral.TabIndex = 2;
            // 
            // pMenuLateral
            // 
            pMenuLateral.Anchor = AnchorStyles.None;
            pMenuLateral.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pMenuLateral.BackColor = Color.Transparent;
            pMenuLateral.BackgroundImage = Properties.Resources.BarraLateral;
            pMenuLateral.BackgroundImageLayout = ImageLayout.Stretch;
            pMenuLateral.Controls.Add(btnReportes);
            pMenuLateral.Controls.Add(pictureBox1);
            pMenuLateral.Controls.Add(btnComprar);
            pMenuLateral.Controls.Add(pictureBox2);
            pMenuLateral.Controls.Add(btnProductos);
            pMenuLateral.Controls.Add(btnUsuarios);
            pMenuLateral.Controls.Add(btnProveedores);
            pMenuLateral.Controls.Add(btnPrincipal);
            pMenuLateral.Controls.Add(btnClientes);
            pMenuLateral.Location = new Point(-6, 39);
            pMenuLateral.Name = "pMenuLateral";
            pMenuLateral.Size = new Size(68, 725);
            pMenuLateral.TabIndex = 14;
            // 
            // btnReportes
            // 
            btnReportes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnReportes.Cursor = Cursors.Hand;
            btnReportes.Image = Properties.Resources.Reportes_B;
            btnReportes.Location = new Point(15, 630);
            btnReportes.Margin = new Padding(0);
            btnReportes.MaximumSize = new Size(66, 104);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(41, 92);
            btnReportes.SizeMode = PictureBoxSizeMode.StretchImage;
            btnReportes.TabIndex = 12;
            btnReportes.TabStop = false;
            btnReportes.Tag = "4";
            btnReportes.Click += BotonesLaterales_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.Reportes_B;
            pictureBox1.Location = new Point(-109, 1687);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "4";
            // 
            // btnComprar
            // 
            btnComprar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnComprar.Cursor = Cursors.Hand;
            btnComprar.Image = Properties.Resources.Comprar_B;
            btnComprar.Location = new Point(15, 104);
            btnComprar.Margin = new Padding(0);
            btnComprar.MaximumSize = new Size(66, 104);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(41, 92);
            btnComprar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnComprar.TabIndex = 13;
            btnComprar.TabStop = false;
            btnComprar.Tag = "5";
            btnComprar.Click += BotonesLaterales_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.Proveedores_B;
            pictureBox2.Location = new Point(-109, 1499);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(66, 155);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "3";
            // 
            // btnProductos
            // 
            btnProductos.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnProductos.Cursor = Cursors.Hand;
            btnProductos.Image = Properties.Resources.Productos_B;
            btnProductos.Location = new Point(15, 417);
            btnProductos.Margin = new Padding(0);
            btnProductos.MaximumSize = new Size(66, 104);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(41, 92);
            btnProductos.SizeMode = PictureBoxSizeMode.StretchImage;
            btnProductos.TabIndex = 10;
            btnProductos.TabStop = false;
            btnProductos.Tag = "2";
            btnProductos.Click += BotonesLaterales_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.Image = Properties.Resources.Usuarios_B;
            btnUsuarios.Location = new Point(15, 208);
            btnUsuarios.Margin = new Padding(0);
            btnUsuarios.MaximumSize = new Size(66, 104);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(41, 92);
            btnUsuarios.SizeMode = PictureBoxSizeMode.StretchImage;
            btnUsuarios.TabIndex = 9;
            btnUsuarios.TabStop = false;
            btnUsuarios.Tag = "1";
            btnUsuarios.Click += BotonesLaterales_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnProveedores.Cursor = Cursors.Hand;
            btnProveedores.Image = Properties.Resources.Proveedores_B;
            btnProveedores.Location = new Point(15, 520);
            btnProveedores.Margin = new Padding(0);
            btnProveedores.MaximumSize = new Size(66, 110);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(41, 98);
            btnProveedores.SizeMode = PictureBoxSizeMode.StretchImage;
            btnProveedores.TabIndex = 11;
            btnProveedores.TabStop = false;
            btnProveedores.Tag = "3";
            btnProveedores.Click += BotonesLaterales_Click;
            // 
            // btnPrincipal
            // 
            btnPrincipal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnPrincipal.Cursor = Cursors.Hand;
            btnPrincipal.Image = Properties.Resources.Principal_B;
            btnPrincipal.Location = new Point(15, 3);
            btnPrincipal.Margin = new Padding(0);
            btnPrincipal.MaximumSize = new Size(66, 104);
            btnPrincipal.Name = "btnPrincipal";
            btnPrincipal.Size = new Size(41, 92);
            btnPrincipal.SizeMode = PictureBoxSizeMode.StretchImage;
            btnPrincipal.TabIndex = 4;
            btnPrincipal.TabStop = false;
            btnPrincipal.Tag = "0";
            btnPrincipal.Click += BotonesLaterales_Click;
            // 
            // btnClientes
            // 
            btnClientes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.Image = Properties.Resources.Clientes_A;
            btnClientes.Location = new Point(15, 312);
            btnClientes.Margin = new Padding(0);
            btnClientes.MaximumSize = new Size(66, 104);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(41, 92);
            btnClientes.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClientes.TabIndex = 14;
            btnClientes.TabStop = false;
            btnClientes.Tag = "6";
            btnClientes.Click += BotonesLaterales_Click;
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
            pHeader.TabIndex = 17;
            // 
            // cbBuscar
            // 
            cbBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbBuscar.BackColor = SystemColors.Window;
            cbBuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBuscar.FlatStyle = FlatStyle.Popup;
            cbBuscar.Font = new Font("Century Gothic", 14.25F);
            cbBuscar.FormattingEnabled = true;
            cbBuscar.Items.AddRange(new object[] { "ID", "Nombre", "Apellido_P", "Apellido_M", "RFC", "Calle", "Num_Casa", "CP", "Colonia", "Municipio", "Estado", "Pais", "Celular", "Email" });
            cbBuscar.Location = new Point(787, 87);
            cbBuscar.Name = "cbBuscar";
            cbBuscar.Size = new Size(116, 30);
            cbBuscar.TabIndex = 18;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAgregar.BackColor = Color.FromArgb(28, 78, 254);
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            btnAgregar.ForeColor = SystemColors.ButtonHighlight;
            btnAgregar.Location = new Point(926, 83);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(193, 33);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Agregar Cliente";
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
            txtBuscar.Size = new Size(757, 33);
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
            lblHora.Location = new Point(688, 18);
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
            lblUsuario.Size = new Size(331, 48);
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
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrincipal.Columns.AddRange(new DataGridViewColumn[] { C_ID, C_Nombre, C_ApellidoP, C_ApellidoM, C_RFC, C_Calle, C_CP, C_Colonia, C_Municipio, C_Estado, C_Pais, C_Celular, C_Email, C_Modificar, C_Eliminar });
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = SystemColors.Window;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle16.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.False;
            dgvPrincipal.DefaultCellStyle = dataGridViewCellStyle16;
            dgvPrincipal.Location = new Point(145, 143);
            dgvPrincipal.Name = "dgvPrincipal";
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = SystemColors.Control;
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle17.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            dgvPrincipal.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dgvPrincipal.RowHeadersVisible = false;
            dgvPrincipal.RowTemplate.Height = 50;
            dgvPrincipal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrincipal.Size = new Size(1123, 625);
            dgvPrincipal.TabIndex = 21;
            dgvPrincipal.CellContentClick += dgvPrincipal_CellContentClick;
            dgvPrincipal.EditingControlShowing += dgvPrincipal_EditingControlShowing;
            // 
            // C_ID
            // 
            C_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 20.25F);
            C_ID.DefaultCellStyle = dataGridViewCellStyle2;
            C_ID.HeaderText = "ID";
            C_ID.Name = "C_ID";
            C_ID.ReadOnly = true;
            C_ID.Width = 79;
            // 
            // C_Nombre
            // 
            C_Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 20.25F);
            C_Nombre.DefaultCellStyle = dataGridViewCellStyle3;
            C_Nombre.FillWeight = 14.59854F;
            C_Nombre.HeaderText = "Nombre";
            C_Nombre.MaxInputLength = 30;
            C_Nombre.Name = "C_Nombre";
            C_Nombre.ReadOnly = true;
            C_Nombre.Width = 169;
            // 
            // C_ApellidoP
            // 
            C_ApellidoP.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 20.25F);
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            C_ApellidoP.DefaultCellStyle = dataGridViewCellStyle4;
            C_ApellidoP.FillWeight = 385.4015F;
            C_ApellidoP.HeaderText = "ApellidoP";
            C_ApellidoP.MaxInputLength = 30;
            C_ApellidoP.Name = "C_ApellidoP";
            C_ApellidoP.ReadOnly = true;
            C_ApellidoP.Width = 192;
            // 
            // C_ApellidoM
            // 
            C_ApellidoM.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 20.25F);
            C_ApellidoM.DefaultCellStyle = dataGridViewCellStyle5;
            C_ApellidoM.HeaderText = "ApellidoM";
            C_ApellidoM.MaxInputLength = 30;
            C_ApellidoM.Name = "C_ApellidoM";
            C_ApellidoM.ReadOnly = true;
            C_ApellidoM.Width = 203;
            // 
            // C_RFC
            // 
            C_RFC.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 20.25F);
            C_RFC.DefaultCellStyle = dataGridViewCellStyle6;
            C_RFC.HeaderText = "RFC";
            C_RFC.MaxInputLength = 20;
            C_RFC.Name = "C_RFC";
            C_RFC.ReadOnly = true;
            C_RFC.Width = 103;
            // 
            // C_Calle
            // 
            C_Calle.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 20.25F);
            C_Calle.DefaultCellStyle = dataGridViewCellStyle7;
            C_Calle.HeaderText = "Calle";
            C_Calle.MaxInputLength = 30;
            C_Calle.Name = "C_Calle";
            C_Calle.ReadOnly = true;
            C_Calle.Width = 117;
            // 
            // C_CP
            // 
            C_CP.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 20.25F);
            C_CP.DefaultCellStyle = dataGridViewCellStyle8;
            C_CP.HeaderText = "CP";
            C_CP.MaxInputLength = 10;
            C_CP.Name = "C_CP";
            C_CP.ReadOnly = true;
            C_CP.Width = 85;
            // 
            // C_Colonia
            // 
            C_Colonia.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 20.25F);
            C_Colonia.DefaultCellStyle = dataGridViewCellStyle9;
            C_Colonia.HeaderText = "Colonia";
            C_Colonia.MaxInputLength = 30;
            C_Colonia.Name = "C_Colonia";
            C_Colonia.ReadOnly = true;
            C_Colonia.Width = 159;
            // 
            // C_Municipio
            // 
            C_Municipio.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 20.25F);
            C_Municipio.DefaultCellStyle = dataGridViewCellStyle10;
            C_Municipio.HeaderText = "Municipio";
            C_Municipio.MaxInputLength = 30;
            C_Municipio.Name = "C_Municipio";
            C_Municipio.ReadOnly = true;
            C_Municipio.Width = 196;
            // 
            // C_Estado
            // 
            C_Estado.HeaderText = "Estado";
            C_Estado.MaxInputLength = 30;
            C_Estado.Name = "C_Estado";
            // 
            // C_Pais
            // 
            C_Pais.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 20.25F);
            C_Pais.DefaultCellStyle = dataGridViewCellStyle11;
            C_Pais.HeaderText = "Pais";
            C_Pais.MaxInputLength = 30;
            C_Pais.Name = "C_Pais";
            C_Pais.ReadOnly = true;
            C_Pais.Width = 104;
            // 
            // C_Celular
            // 
            C_Celular.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 20.25F);
            C_Celular.DefaultCellStyle = dataGridViewCellStyle12;
            C_Celular.HeaderText = "Celular";
            C_Celular.MaxInputLength = 10;
            C_Celular.Name = "C_Celular";
            C_Celular.ReadOnly = true;
            C_Celular.Width = 149;
            // 
            // C_Email
            // 
            C_Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 20.25F);
            C_Email.DefaultCellStyle = dataGridViewCellStyle13;
            C_Email.HeaderText = "Email";
            C_Email.MaxInputLength = 255;
            C_Email.Name = "C_Email";
            C_Email.ReadOnly = true;
            C_Email.Width = 126;
            // 
            // C_Modificar
            // 
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = Color.Yellow;
            dataGridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            C_Modificar.DefaultCellStyle = dataGridViewCellStyle14;
            C_Modificar.FlatStyle = FlatStyle.Popup;
            C_Modificar.HeaderText = "";
            C_Modificar.Name = "C_Modificar";
            C_Modificar.ReadOnly = true;
            C_Modificar.Resizable = DataGridViewTriState.True;
            C_Modificar.SortMode = DataGridViewColumnSortMode.Automatic;
            C_Modificar.Text = "✎Modificar";
            C_Modificar.UseColumnTextForButtonValue = true;
            C_Modificar.Width = 150;
            // 
            // C_Eliminar
            // 
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = Color.Red;
            dataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            C_Eliminar.DefaultCellStyle = dataGridViewCellStyle15;
            C_Eliminar.FlatStyle = FlatStyle.Popup;
            C_Eliminar.HeaderText = "";
            C_Eliminar.Name = "C_Eliminar";
            C_Eliminar.ReadOnly = true;
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
            // FormCatalogoClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 780);
            Controls.Add(dgvPrincipal);
            Controls.Add(pHeader);
            Controls.Add(pLateral);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCatalogoClientes";
            Text = "FormCatalogoClientes";
            WindowState = FormWindowState.Maximized;
            Load += FormCatalogoClientes_Load;
            pLateral.ResumeLayout(false);
            pMenuLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnReportes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnComprar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnProveedores).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPrincipal).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClientes).EndInit();
            pHeader.ResumeLayout(false);
            pHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPrincipal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pLateral;
        private Panel pHeader;
        private ComboBox cbBuscar;
        private Button btnAgregar;
        private TextBox txtBuscar;
        private PictureBox PbUsuario;
        private Label lblHora;
        private Label lblUsuario;
        private DataGridView dgvPrincipal;
        private System.Windows.Forms.Timer timer1;
        private Panel pMenuLateral;
        private PictureBox btnReportes;
        private PictureBox pictureBox1;
        private PictureBox btnComprar;
        private PictureBox pictureBox2;
        private PictureBox btnProductos;
        private PictureBox btnUsuarios;
        private PictureBox btnProveedores;
        private PictureBox btnPrincipal;
        private PictureBox btnClientes;
        private DataGridViewTextBoxColumn C_ID;
        private DataGridViewTextBoxColumn C_Nombre;
        private DataGridViewTextBoxColumn C_ApellidoP;
        private DataGridViewTextBoxColumn C_ApellidoM;
        private DataGridViewTextBoxColumn C_RFC;
        private DataGridViewTextBoxColumn C_Calle;
        private DataGridViewTextBoxColumn C_CP;
        private DataGridViewTextBoxColumn C_Colonia;
        private DataGridViewTextBoxColumn C_Municipio;
        private DataGridViewTextBoxColumn C_Estado;
        private DataGridViewTextBoxColumn C_Pais;
        private DataGridViewTextBoxColumn C_Celular;
        private DataGridViewTextBoxColumn C_Email;
        private DataGridViewButtonColumn C_Modificar;
        private DataGridViewButtonColumn C_Eliminar;
    }
}