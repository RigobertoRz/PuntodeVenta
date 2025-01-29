﻿namespace ProyectoTienda.vistas
{
    partial class FormPrincipal
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            timer1 = new System.Windows.Forms.Timer(components);
            pLateral = new Panel();
            btnSalir = new Button();
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
            pOrden = new Panel();
            rbFactura = new CheckBox();
            cbCliente = new ComboBox();
            label3 = new Label();
            txtCambio = new TextBox();
            label1 = new Label();
            lblcb = new Label();
            txtPago = new TextBox();
            btnPagar = new Button();
            lblTotal = new Label();
            btnReiniciar = new Button();
            lblOrden = new Label();
            dgvOrden = new DataGridView();
            C_Cantidad = new DataGridViewTextBoxColumn();
            C_Producto = new DataGridViewTextBoxColumn();
            C_PecioOrden = new DataGridViewTextBoxColumn();
            pHeader = new Panel();
            lblTitulo = new Label();
            txtBuscar = new TextBox();
            PbUsuario = new PictureBox();
            lblHora = new Label();
            lblUsuario = new Label();
            dgvPrincipal = new DataGridView();
            C_ID = new DataGridViewTextBoxColumn();
            C_Nombre = new DataGridViewTextBoxColumn();
            C_Precio = new DataGridViewTextBoxColumn();
            btnAgregarOrden = new Button();
            pCategorias = new Panel();
            btnPre = new PictureBox();
            btnAlimentosyB = new PictureBox();
            btnCreatina = new PictureBox();
            btnAminoacidos = new PictureBox();
            btnProteinas = new PictureBox();
            btnVitaminas = new PictureBox();
            pdata = new Panel();
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
            pOrden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrden).BeginInit();
            pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPrincipal).BeginInit();
            pCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnPre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAlimentosyB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCreatina).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAminoacidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnProteinas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnVitaminas).BeginInit();
            pdata.SuspendLayout();
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
            pLateral.Controls.Add(btnSalir);
            pLateral.Controls.Add(pMenuLateral);
            pLateral.Dock = DockStyle.Left;
            pLateral.Location = new Point(0, 0);
            pLateral.Name = "pLateral";
            pLateral.Size = new Size(130, 780);
            pLateral.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.Dock = DockStyle.Top;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSalir.ForeColor = SystemColors.ButtonHighlight;
            btnSalir.Location = new Point(0, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(130, 30);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Cerrar Sesion";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
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
            pMenuLateral.TabIndex = 13;
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
            btnReportes.Size = new Size(42, 92);
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
            pictureBox1.Location = new Point(-43, 1375);
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
            btnComprar.Size = new Size(42, 92);
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
            pictureBox2.Location = new Point(-43, 1187);
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
            btnProductos.Size = new Size(42, 92);
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
            btnUsuarios.Size = new Size(42, 92);
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
            btnProveedores.Size = new Size(42, 98);
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
            btnPrincipal.Image = Properties.Resources.Principal_A;
            btnPrincipal.Location = new Point(15, 3);
            btnPrincipal.Margin = new Padding(0);
            btnPrincipal.MaximumSize = new Size(66, 104);
            btnPrincipal.Name = "btnPrincipal";
            btnPrincipal.Size = new Size(42, 92);
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
            btnClientes.Image = Properties.Resources.Clientes_B;
            btnClientes.Location = new Point(15, 312);
            btnClientes.Margin = new Padding(0);
            btnClientes.MaximumSize = new Size(66, 104);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(42, 92);
            btnClientes.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClientes.TabIndex = 14;
            btnClientes.TabStop = false;
            btnClientes.Tag = "6";
            btnClientes.Click += BotonesLaterales_Click;
            // 
            // pOrden
            // 
            pOrden.BackColor = SystemColors.ControlLightLight;
            pOrden.Controls.Add(rbFactura);
            pOrden.Controls.Add(cbCliente);
            pOrden.Controls.Add(label3);
            pOrden.Controls.Add(txtCambio);
            pOrden.Controls.Add(label1);
            pOrden.Controls.Add(lblcb);
            pOrden.Controls.Add(txtPago);
            pOrden.Controls.Add(btnPagar);
            pOrden.Controls.Add(lblTotal);
            pOrden.Controls.Add(btnReiniciar);
            pOrden.Controls.Add(lblOrden);
            pOrden.Controls.Add(dgvOrden);
            pOrden.Dock = DockStyle.Right;
            pOrden.Location = new Point(954, 0);
            pOrden.Name = "pOrden";
            pOrden.Size = new Size(326, 780);
            pOrden.TabIndex = 2;
            // 
            // rbFactura
            // 
            rbFactura.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            rbFactura.AutoSize = true;
            rbFactura.FlatStyle = FlatStyle.Popup;
            rbFactura.Font = new Font("Segoe UI", 9.75F);
            rbFactura.Location = new Point(176, 731);
            rbFactura.Name = "rbFactura";
            rbFactura.Size = new Size(123, 21);
            rbFactura.TabIndex = 33;
            rbFactura.Text = "Requiere Factura";
            rbFactura.UseVisualStyleBackColor = true;
            // 
            // cbCliente
            // 
            cbCliente.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            cbCliente.FormattingEnabled = true;
            cbCliente.ItemHeight = 25;
            cbCliente.Location = new Point(120, 470);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(179, 33);
            cbCliente.TabIndex = 29;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 18F);
            label3.Location = new Point(25, 667);
            label3.Name = "label3";
            label3.Size = new Size(97, 29);
            label3.TabIndex = 32;
            label3.Text = "Cambio";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCambio
            // 
            txtCambio.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtCambio.Enabled = false;
            txtCambio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtCambio.Location = new Point(135, 667);
            txtCambio.Name = "txtCambio";
            txtCambio.Size = new Size(158, 33);
            txtCambio.TabIndex = 31;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F);
            label1.Location = new Point(8, 532);
            label1.Name = "label1";
            label1.Size = new Size(140, 29);
            label1.TabIndex = 30;
            label1.Text = "Pagara Con";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblcb
            // 
            lblcb.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblcb.AutoSize = true;
            lblcb.Font = new Font("Microsoft Sans Serif", 18F);
            lblcb.Location = new Point(25, 470);
            lblcb.Name = "lblcb";
            lblcb.Size = new Size(89, 29);
            lblcb.TabIndex = 28;
            lblcb.Text = "Cliente";
            lblcb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPago
            // 
            txtPago.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtPago.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtPago.Location = new Point(155, 532);
            txtPago.Name = "txtPago";
            txtPago.Size = new Size(144, 33);
            txtPago.TabIndex = 27;
            txtPago.TextChanged += txtPago_TextChanged;
            // 
            // btnPagar
            // 
            btnPagar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPagar.BackColor = Color.FromArgb(28, 78, 254);
            btnPagar.FlatStyle = FlatStyle.Popup;
            btnPagar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnPagar.ForeColor = SystemColors.ButtonHighlight;
            btnPagar.Location = new Point(8, 721);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(156, 43);
            btnPagar.TabIndex = 25;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Microsoft Sans Serif", 18F);
            lblTotal.Location = new Point(46, 592);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(68, 29);
            lblTotal.TabIndex = 26;
            lblTotal.Text = "Total";
            lblTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReiniciar.BackColor = Color.Transparent;
            btnReiniciar.BackgroundImage = Properties.Resources.Cancel1;
            btnReiniciar.BackgroundImageLayout = ImageLayout.Stretch;
            btnReiniciar.Cursor = Cursors.Hand;
            btnReiniciar.FlatAppearance.BorderColor = Color.White;
            btnReiniciar.FlatAppearance.BorderSize = 0;
            btnReiniciar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnReiniciar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnReiniciar.FlatStyle = FlatStyle.Flat;
            btnReiniciar.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnReiniciar.ForeColor = SystemColors.ActiveCaptionText;
            btnReiniciar.Location = new Point(253, 12);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(44, 44);
            btnReiniciar.TabIndex = 13;
            btnReiniciar.Text = "X";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // lblOrden
            // 
            lblOrden.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblOrden.Font = new Font("Segoe Fluent Icons", 24F, FontStyle.Bold);
            lblOrden.Location = new Point(12, 14);
            lblOrden.Name = "lblOrden";
            lblOrden.Size = new Size(90, 32);
            lblOrden.TabIndex = 12;
            lblOrden.Text = "Orden";
            // 
            // dgvOrden
            // 
            dgvOrden.AllowUserToAddRows = false;
            dgvOrden.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrden.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvOrden.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvOrden.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrden.ColumnHeadersVisible = false;
            dgvOrden.Columns.AddRange(new DataGridViewColumn[] { C_Cantidad, C_Producto, C_PecioOrden });
            dgvOrden.Location = new Point(12, 68);
            dgvOrden.Name = "dgvOrden";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvOrden.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvOrden.RowHeadersVisible = false;
            dgvOrden.RowTemplate.Height = 50;
            dgvOrden.Size = new Size(302, 399);
            dgvOrden.TabIndex = 13;
            dgvOrden.CellValueChanged += dgvOrden_CellValueChanged;
            dgvOrden.KeyDown += dgvOrden_KeyDown;
            // 
            // C_Cantidad
            // 
            C_Cantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.NullValue = null;
            C_Cantidad.DefaultCellStyle = dataGridViewCellStyle2;
            C_Cantidad.HeaderText = "Cantidad";
            C_Cantidad.Name = "C_Cantidad";
            C_Cantidad.Width = 5;
            // 
            // C_Producto
            // 
            C_Producto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F);
            C_Producto.DefaultCellStyle = dataGridViewCellStyle3;
            C_Producto.HeaderText = "Producto";
            C_Producto.Name = "C_Producto";
            C_Producto.ReadOnly = true;
            // 
            // C_PecioOrden
            // 
            C_PecioOrden.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            C_PecioOrden.DefaultCellStyle = dataGridViewCellStyle4;
            C_PecioOrden.HeaderText = "Precio";
            C_PecioOrden.Name = "C_PecioOrden";
            C_PecioOrden.ReadOnly = true;
            C_PecioOrden.Width = 5;
            // 
            // pHeader
            // 
            pHeader.Controls.Add(lblTitulo);
            pHeader.Controls.Add(txtBuscar);
            pHeader.Controls.Add(PbUsuario);
            pHeader.Controls.Add(lblHora);
            pHeader.Controls.Add(lblUsuario);
            pHeader.Dock = DockStyle.Top;
            pHeader.Location = new Point(130, 0);
            pHeader.Name = "pHeader";
            pHeader.Size = new Size(824, 137);
            pHeader.TabIndex = 13;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTitulo.FlatStyle = FlatStyle.Popup;
            lblTitulo.Font = new Font("Segoe Fluent Icons", 24F, FontStyle.Bold);
            lblTitulo.Location = new Point(708, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(116, 32);
            lblTitulo.TabIndex = 15;
            lblTitulo.Text = "Venta";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Font = new Font("Century Gothic", 15.75F);
            txtBuscar.Location = new Point(15, 87);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar";
            txtBuscar.Size = new Size(803, 33);
            txtBuscar.TabIndex = 14;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // PbUsuario
            // 
            PbUsuario.Image = Properties.Resources.Usuario;
            PbUsuario.Location = new Point(7, 39);
            PbUsuario.Name = "PbUsuario";
            PbUsuario.Size = new Size(33, 33);
            PbUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            PbUsuario.TabIndex = 10;
            PbUsuario.TabStop = false;
            PbUsuario.Click += PbUsuario_Click;
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHora.Font = new Font("Segoe Fluent Icons", 24F);
            lblHora.Location = new Point(298, 35);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(508, 32);
            lblHora.TabIndex = 14;
            lblHora.Text = "Miercoles 27 de abril de 2022 4:24 PM ";
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblUsuario.Font = new Font("Segoe Fluent Icons", 24F, FontStyle.Bold);
            lblUsuario.Location = new Point(46, 35);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(104, 49);
            lblUsuario.TabIndex = 11;
            lblUsuario.Text = "Usuario";
            // 
            // dgvPrincipal
            // 
            dgvPrincipal.AllowUserToAddRows = false;
            dgvPrincipal.AllowUserToDeleteRows = false;
            dgvPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPrincipal.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(185, 185, 185);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrincipal.Columns.AddRange(new DataGridViewColumn[] { C_ID, C_Nombre, C_Precio });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvPrincipal.DefaultCellStyle = dataGridViewCellStyle10;
            dgvPrincipal.Location = new Point(17, 6);
            dgvPrincipal.Name = "dgvPrincipal";
            dgvPrincipal.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvPrincipal.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvPrincipal.RowHeadersVisible = false;
            dgvPrincipal.RowTemplate.Height = 50;
            dgvPrincipal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrincipal.Size = new Size(793, 520);
            dgvPrincipal.TabIndex = 18;
            // 
            // C_ID
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 20.25F);
            C_ID.DefaultCellStyle = dataGridViewCellStyle7;
            C_ID.HeaderText = "ID";
            C_ID.Name = "C_ID";
            C_ID.ReadOnly = true;
            C_ID.Width = 60;
            // 
            // C_Nombre
            // 
            C_Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 20.25F);
            C_Nombre.DefaultCellStyle = dataGridViewCellStyle8;
            C_Nombre.FillWeight = 14.59854F;
            C_Nombre.HeaderText = "Nombre";
            C_Nombre.Name = "C_Nombre";
            C_Nombre.ReadOnly = true;
            // 
            // C_Precio
            // 
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 20.25F);
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.NullValue = null;
            C_Precio.DefaultCellStyle = dataGridViewCellStyle9;
            C_Precio.FillWeight = 385.4015F;
            C_Precio.HeaderText = "Precio";
            C_Precio.Name = "C_Precio";
            C_Precio.ReadOnly = true;
            C_Precio.Width = 300;
            // 
            // btnAgregarOrden
            // 
            btnAgregarOrden.Anchor = AnchorStyles.Bottom;
            btnAgregarOrden.BackColor = Color.FromArgb(28, 78, 254);
            btnAgregarOrden.Cursor = Cursors.Hand;
            btnAgregarOrden.FlatAppearance.BorderColor = Color.White;
            btnAgregarOrden.FlatAppearance.BorderSize = 5;
            btnAgregarOrden.FlatStyle = FlatStyle.Popup;
            btnAgregarOrden.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnAgregarOrden.ForeColor = SystemColors.ButtonHighlight;
            btnAgregarOrden.Location = new Point(144, 533);
            btnAgregarOrden.Name = "btnAgregarOrden";
            btnAgregarOrden.Size = new Size(498, 42);
            btnAgregarOrden.TabIndex = 19;
            btnAgregarOrden.Text = "Agregar a la orden";
            btnAgregarOrden.UseVisualStyleBackColor = false;
            btnAgregarOrden.Click += btnAgregarOrden_Click;
            // 
            // pCategorias
            // 
            pCategorias.Controls.Add(btnPre);
            pCategorias.Controls.Add(btnAlimentosyB);
            pCategorias.Controls.Add(btnCreatina);
            pCategorias.Controls.Add(btnAminoacidos);
            pCategorias.Controls.Add(btnProteinas);
            pCategorias.Controls.Add(btnVitaminas);
            pCategorias.Dock = DockStyle.Bottom;
            pCategorias.Location = new Point(130, 718);
            pCategorias.Name = "pCategorias";
            pCategorias.Size = new Size(824, 62);
            pCategorias.TabIndex = 20;
            // 
            // btnPre
            // 
            btnPre.Anchor = AnchorStyles.Bottom;
            btnPre.Cursor = Cursors.Hand;
            btnPre.Image = Properties.Resources.Pre_Entreno_A;
            btnPre.Location = new Point(648, 16);
            btnPre.Name = "btnPre";
            btnPre.Size = new Size(118, 41);
            btnPre.SizeMode = PictureBoxSizeMode.StretchImage;
            btnPre.TabIndex = 21;
            btnPre.TabStop = false;
            btnPre.Tag = "6";
            btnPre.Click += BotonesCategorias_Click;
            // 
            // btnAlimentosyB
            // 
            btnAlimentosyB.Anchor = AnchorStyles.Bottom;
            btnAlimentosyB.Cursor = Cursors.Hand;
            btnAlimentosyB.Image = Properties.Resources.Alimentos_y_Bebidas_A;
            btnAlimentosyB.Location = new Point(524, 16);
            btnAlimentosyB.Name = "btnAlimentosyB";
            btnAlimentosyB.Size = new Size(118, 41);
            btnAlimentosyB.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAlimentosyB.TabIndex = 21;
            btnAlimentosyB.TabStop = false;
            btnAlimentosyB.Tag = "5";
            btnAlimentosyB.Click += BotonesCategorias_Click;
            // 
            // btnCreatina
            // 
            btnCreatina.Anchor = AnchorStyles.Bottom;
            btnCreatina.Cursor = Cursors.Hand;
            btnCreatina.Image = Properties.Resources.Creatina_A;
            btnCreatina.Location = new Point(400, 16);
            btnCreatina.Name = "btnCreatina";
            btnCreatina.Size = new Size(118, 41);
            btnCreatina.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCreatina.TabIndex = 21;
            btnCreatina.TabStop = false;
            btnCreatina.Tag = "4";
            btnCreatina.Click += BotonesCategorias_Click;
            // 
            // btnAminoacidos
            // 
            btnAminoacidos.Anchor = AnchorStyles.Bottom;
            btnAminoacidos.Cursor = Cursors.Hand;
            btnAminoacidos.Image = Properties.Resources.Aminoacidos_A;
            btnAminoacidos.Location = new Point(276, 16);
            btnAminoacidos.Name = "btnAminoacidos";
            btnAminoacidos.Size = new Size(118, 41);
            btnAminoacidos.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAminoacidos.TabIndex = 21;
            btnAminoacidos.TabStop = false;
            btnAminoacidos.Tag = "3";
            btnAminoacidos.Click += BotonesCategorias_Click;
            // 
            // btnProteinas
            // 
            btnProteinas.Anchor = AnchorStyles.Bottom;
            btnProteinas.Cursor = Cursors.Hand;
            btnProteinas.Image = Properties.Resources.Proteinas_A;
            btnProteinas.Location = new Point(156, 16);
            btnProteinas.Name = "btnProteinas";
            btnProteinas.Size = new Size(118, 41);
            btnProteinas.SizeMode = PictureBoxSizeMode.StretchImage;
            btnProteinas.TabIndex = 21;
            btnProteinas.TabStop = false;
            btnProteinas.Tag = "2";
            btnProteinas.Click += BotonesCategorias_Click;
            // 
            // btnVitaminas
            // 
            btnVitaminas.Anchor = AnchorStyles.Bottom;
            btnVitaminas.Cursor = Cursors.Hand;
            btnVitaminas.Image = Properties.Resources.Vitaminas_A;
            btnVitaminas.Location = new Point(32, 17);
            btnVitaminas.Name = "btnVitaminas";
            btnVitaminas.Size = new Size(118, 41);
            btnVitaminas.SizeMode = PictureBoxSizeMode.StretchImage;
            btnVitaminas.TabIndex = 21;
            btnVitaminas.TabStop = false;
            btnVitaminas.Tag = "1";
            btnVitaminas.Click += BotonesCategorias_Click;
            // 
            // pdata
            // 
            pdata.Controls.Add(btnAgregarOrden);
            pdata.Controls.Add(dgvPrincipal);
            pdata.Dock = DockStyle.Fill;
            pdata.Location = new Point(130, 137);
            pdata.Name = "pdata";
            pdata.Size = new Size(824, 581);
            pdata.TabIndex = 21;
            // 
            // FormPrincipal
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            ClientSize = new Size(1280, 780);
            Controls.Add(pdata);
            Controls.Add(pCategorias);
            Controls.Add(pHeader);
            Controls.Add(pOrden);
            Controls.Add(pLateral);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.Manual;
            WindowState = FormWindowState.Maximized;
            Load += Principal_Load;
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
            pOrden.ResumeLayout(false);
            pOrden.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrden).EndInit();
            pHeader.ResumeLayout(false);
            pHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPrincipal).EndInit();
            pCategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnPre).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAlimentosyB).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCreatina).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAminoacidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnProteinas).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnVitaminas).EndInit();
            pdata.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Panel pLateral;
        private Panel pMenuLateral;
        private PictureBox btnReportes;
        private PictureBox pictureBox1;
        private PictureBox btnProveedores;
        private PictureBox pictureBox2;
        private PictureBox btnProductos;
        private PictureBox btnPrincipal;
        private PictureBox btnUsuarios;
        private Panel pOrden;
        private Button btnReiniciar;
        private Label lblOrden;
        private DataGridView dgvOrden;
        private Panel pHeader;
        private TextBox txtBuscar;
        private PictureBox PbUsuario;
        private Label lblHora;
        private Label lblUsuario;
        private DataGridView dgvPrincipal;
        private DataGridViewTextBoxColumn C_ID;
        private DataGridViewTextBoxColumn C_Nombre;
        private DataGridViewTextBoxColumn C_Precio;
        private Button btnAgregarOrden;
        private Panel pCategorias;
        private PictureBox btnPre;
        private PictureBox btnAlimentosyB;
        private PictureBox btnCreatina;
        private PictureBox btnAminoacidos;
        private PictureBox btnProteinas;
        private PictureBox btnVitaminas;
        private Panel pdata;
        private DataGridViewTextBoxColumn C_Cantidad;
        private DataGridViewTextBoxColumn C_Producto;
        private DataGridViewTextBoxColumn C_PecioOrden;
        private Button button1;
        private Button btnSalir;
        private CheckBox rbFactura;
        private ComboBox cbCliente;
        private Label label3;
        private TextBox txtCambio;
        private Label label1;
        private Label lblcb;
        private TextBox txtPago;
        private Button btnPagar;
        private Label lblTotal;
        private Label lblTitulo;
        private PictureBox btnComprar;
        private PictureBox btnClientes;
    }
}