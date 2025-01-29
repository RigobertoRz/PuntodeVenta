namespace ProyectoTienda.vistas
{
    partial class FormCatalogoProducto
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
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            timer1 = new System.Windows.Forms.Timer(components);
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
            C_Precio = new DataGridViewTextBoxColumn();
            C_Stock = new DataGridViewTextBoxColumn();
            C_Modificar = new DataGridViewButtonColumn();
            C_Borrar = new DataGridViewButtonColumn();
            btnPre = new PictureBox();
            btnAlimentosyB = new PictureBox();
            btnCreatina = new PictureBox();
            btnAminoacidos = new PictureBox();
            btnProteinas = new PictureBox();
            btnVitaminas = new PictureBox();
            pCategorias = new Panel();
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
            ((System.ComponentModel.ISupportInitialize)btnPre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAlimentosyB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCreatina).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAminoacidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnProteinas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnVitaminas).BeginInit();
            pCategorias.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
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
            pMenuLateral.TabIndex = 14;
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
            btnComprar.Size = new Size(42, 91);
            btnComprar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnComprar.TabIndex = 20;
            btnComprar.TabStop = false;
            btnComprar.Tag = "4";
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
            btnReportes.Size = new Size(42, 91);
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
            btnClientes.Size = new Size(42, 91);
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
            btnUsuarios.Size = new Size(42, 91);
            btnUsuarios.SizeMode = PictureBoxSizeMode.StretchImage;
            btnUsuarios.TabIndex = 16;
            btnUsuarios.TabStop = false;
            btnUsuarios.Tag = "1";
            btnUsuarios.Click += BotonesLaterales_Click;
            // 
            // btnProductos
            // 
            btnProductos.Cursor = Cursors.Hand;
            btnProductos.Image = Properties.Resources.Productos_A;
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
            btnPrincipal.Size = new Size(42, 92);
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
            btnProveedores.Image = Properties.Resources.Proveedores_B;
            btnProveedores.Location = new Point(15, 520);
            btnProveedores.Margin = new Padding(0);
            btnProveedores.MaximumSize = new Size(66, 155);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(42, 91);
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
            pictureBox1.Location = new Point(-113, 1635);
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
            pictureBox2.Location = new Point(-113, 1447);
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
            pHeader.TabIndex = 14;
            // 
            // cbBuscar
            // 
            cbBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbBuscar.BackColor = SystemColors.Window;
            cbBuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBuscar.FlatStyle = FlatStyle.Popup;
            cbBuscar.Font = new Font("Century Gothic", 12F);
            cbBuscar.FormattingEnabled = true;
            cbBuscar.Items.AddRange(new object[] { "ID", "Nombre", "Precio" });
            cbBuscar.Location = new Point(812, 88);
            cbBuscar.Name = "cbBuscar";
            cbBuscar.Size = new Size(116, 29);
            cbBuscar.TabIndex = 16;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAgregar.BackColor = Color.FromArgb(28, 78, 254);
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            btnAgregar.ForeColor = SystemColors.ButtonHighlight;
            btnAgregar.Location = new Point(947, 86);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(177, 33);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Agregar Producto";
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
            lblHora.Text = "Miércoles 27 de abril de 2022 4:24 PM ";
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblUsuario.Font = new Font("Segoe Fluent Icons", 24F, FontStyle.Bold);
            lblUsuario.Location = new Point(50, 14);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(145, 48);
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
            dgvPrincipal.Columns.AddRange(new DataGridViewColumn[] { C_ID, C_Nombre, C_Precio, C_Stock, C_Modificar, C_Borrar });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvPrincipal.DefaultCellStyle = dataGridViewCellStyle8;
            dgvPrincipal.Location = new Point(141, 143);
            dgvPrincipal.Name = "dgvPrincipal";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvPrincipal.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvPrincipal.RowHeadersVisible = false;
            dgvPrincipal.RowTemplate.Height = 50;
            dgvPrincipal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrincipal.Size = new Size(1123, 569);
            dgvPrincipal.TabIndex = 19;
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
            C_ID.Resizable = DataGridViewTriState.False;
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
            C_Nombre.Name = "C_Nombre";
            C_Nombre.ReadOnly = true;
            C_Nombre.Resizable = DataGridViewTriState.False;
            C_Nombre.Width = 169;
            // 
            // C_Precio
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 20.25F);
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            C_Precio.DefaultCellStyle = dataGridViewCellStyle4;
            C_Precio.FillWeight = 385.4015F;
            C_Precio.HeaderText = "Precio";
            C_Precio.Name = "C_Precio";
            C_Precio.ReadOnly = true;
            C_Precio.Resizable = DataGridViewTriState.False;
            C_Precio.Width = 300;
            // 
            // C_Stock
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 20.25F);
            C_Stock.DefaultCellStyle = dataGridViewCellStyle5;
            C_Stock.HeaderText = "Stock";
            C_Stock.Name = "C_Stock";
            C_Stock.ReadOnly = true;
            C_Stock.Resizable = DataGridViewTriState.False;
            C_Stock.Width = 300;
            // 
            // C_Modificar
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.Yellow;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            C_Modificar.DefaultCellStyle = dataGridViewCellStyle6;
            C_Modificar.FlatStyle = FlatStyle.Popup;
            C_Modificar.HeaderText = "";
            C_Modificar.Name = "C_Modificar";
            C_Modificar.ReadOnly = true;
            C_Modificar.Resizable = DataGridViewTriState.False;
            C_Modificar.SortMode = DataGridViewColumnSortMode.Automatic;
            C_Modificar.Text = "✎Modificar";
            C_Modificar.UseColumnTextForButtonValue = true;
            C_Modificar.Width = 150;
            // 
            // C_Borrar
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.Red;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            C_Borrar.DefaultCellStyle = dataGridViewCellStyle7;
            C_Borrar.FlatStyle = FlatStyle.Popup;
            C_Borrar.HeaderText = "";
            C_Borrar.Name = "C_Borrar";
            C_Borrar.ReadOnly = true;
            C_Borrar.Resizable = DataGridViewTriState.False;
            C_Borrar.SortMode = DataGridViewColumnSortMode.Automatic;
            C_Borrar.Text = "🗑Borrar";
            C_Borrar.UseColumnTextForButtonValue = true;
            C_Borrar.Width = 150;
            // 
            // btnPre
            // 
            btnPre.Anchor = AnchorStyles.Bottom;
            btnPre.Cursor = Cursors.Hand;
            btnPre.Image = Properties.Resources.Pre_Entreno_A;
            btnPre.Location = new Point(922, 12);
            btnPre.Name = "btnPre";
            btnPre.Size = new Size(151, 50);
            btnPre.SizeMode = PictureBoxSizeMode.StretchImage;
            btnPre.TabIndex = 22;
            btnPre.TabStop = false;
            btnPre.Tag = "6";
            btnPre.Click += BotonesCategorias_Click;
            // 
            // btnAlimentosyB
            // 
            btnAlimentosyB.Anchor = AnchorStyles.Bottom;
            btnAlimentosyB.Cursor = Cursors.Hand;
            btnAlimentosyB.Image = Properties.Resources.Alimentos_y_Bebidas_A;
            btnAlimentosyB.Location = new Point(689, 12);
            btnAlimentosyB.Name = "btnAlimentosyB";
            btnAlimentosyB.Size = new Size(217, 47);
            btnAlimentosyB.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAlimentosyB.TabIndex = 23;
            btnAlimentosyB.TabStop = false;
            btnAlimentosyB.Tag = "5";
            btnAlimentosyB.Click += BotonesCategorias_Click;
            // 
            // btnCreatina
            // 
            btnCreatina.Anchor = AnchorStyles.Bottom;
            btnCreatina.Cursor = Cursors.Hand;
            btnCreatina.Image = Properties.Resources.Creatina_A;
            btnCreatina.Location = new Point(532, 12);
            btnCreatina.Name = "btnCreatina";
            btnCreatina.Size = new Size(136, 47);
            btnCreatina.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCreatina.TabIndex = 24;
            btnCreatina.TabStop = false;
            btnCreatina.Tag = "4";
            btnCreatina.Click += BotonesCategorias_Click;
            // 
            // btnAminoacidos
            // 
            btnAminoacidos.Anchor = AnchorStyles.Bottom;
            btnAminoacidos.Cursor = Cursors.Hand;
            btnAminoacidos.Image = Properties.Resources.Aminoacidos_A;
            btnAminoacidos.Location = new Point(364, 12);
            btnAminoacidos.Name = "btnAminoacidos";
            btnAminoacidos.Size = new Size(146, 47);
            btnAminoacidos.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAminoacidos.TabIndex = 25;
            btnAminoacidos.TabStop = false;
            btnAminoacidos.Tag = "3";
            btnAminoacidos.Click += BotonesCategorias_Click;
            // 
            // btnProteinas
            // 
            btnProteinas.Anchor = AnchorStyles.Bottom;
            btnProteinas.Cursor = Cursors.Hand;
            btnProteinas.Image = Properties.Resources.Proteinas_A;
            btnProteinas.Location = new Point(214, 12);
            btnProteinas.Name = "btnProteinas";
            btnProteinas.Size = new Size(131, 47);
            btnProteinas.SizeMode = PictureBoxSizeMode.StretchImage;
            btnProteinas.TabIndex = 26;
            btnProteinas.TabStop = false;
            btnProteinas.Tag = "2";
            btnProteinas.Click += BotonesCategorias_Click;
            // 
            // btnVitaminas
            // 
            btnVitaminas.Anchor = AnchorStyles.Bottom;
            btnVitaminas.Cursor = Cursors.Hand;
            btnVitaminas.Image = Properties.Resources.Vitaminas_A;
            btnVitaminas.Location = new Point(55, 12);
            btnVitaminas.Name = "btnVitaminas";
            btnVitaminas.Size = new Size(140, 47);
            btnVitaminas.SizeMode = PictureBoxSizeMode.StretchImage;
            btnVitaminas.TabIndex = 27;
            btnVitaminas.TabStop = false;
            btnVitaminas.Tag = "1";
            btnVitaminas.Click += BotonesCategorias_Click;
            // 
            // pCategorias
            // 
            pCategorias.Controls.Add(btnProteinas);
            pCategorias.Controls.Add(btnPre);
            pCategorias.Controls.Add(btnVitaminas);
            pCategorias.Controls.Add(btnAlimentosyB);
            pCategorias.Controls.Add(btnAminoacidos);
            pCategorias.Controls.Add(btnCreatina);
            pCategorias.Dock = DockStyle.Bottom;
            pCategorias.Location = new Point(130, 718);
            pCategorias.Name = "pCategorias";
            pCategorias.Size = new Size(1150, 62);
            pCategorias.TabIndex = 28;
            // 
            // FormCatalogoProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 780);
            Controls.Add(pCategorias);
            Controls.Add(dgvPrincipal);
            Controls.Add(pHeader);
            Controls.Add(pLateral);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCatalogoProducto";
            Text = "FormCatalogoProducto";
            WindowState = FormWindowState.Maximized;
            Load += FormCatalogoProducto_Load;
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
            ((System.ComponentModel.ISupportInitialize)btnPre).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAlimentosyB).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCreatina).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAminoacidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnProteinas).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnVitaminas).EndInit();
            pCategorias.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Panel pLateral;
        private Panel pHeader;
        private TextBox txtBuscar;
        private PictureBox PbUsuario;
        private Label lblHora;
        private Label lblUsuario;
        private DataGridView dgvPrincipal;
        private PictureBox btnPre;
        private PictureBox btnAlimentosyB;
        private PictureBox btnCreatina;
        private PictureBox btnAminoacidos;
        private PictureBox btnProteinas;
        private PictureBox btnVitaminas;
        private Panel pCategorias;
        private Button btnAgregar;
        private ComboBox cbBuscar;
        private Panel pMenuLateral;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox btnComprar;
        private PictureBox btnReportes;
        private PictureBox btnClientes;
        private PictureBox btnUsuarios;
        private PictureBox btnProductos;
        private PictureBox btnPrincipal;
        private PictureBox btnProveedores;
        private DataGridViewTextBoxColumn C_ID;
        private DataGridViewTextBoxColumn C_Nombre;
        private DataGridViewTextBoxColumn C_Precio;
        private DataGridViewTextBoxColumn C_Stock;
        private DataGridViewButtonColumn C_Modificar;
        private DataGridViewButtonColumn C_Borrar;
    }
}