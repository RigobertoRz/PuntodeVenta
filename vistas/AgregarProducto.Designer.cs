namespace ProyectoTienda.vistas
{
    partial class AgregarProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pTitulo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.pCuerpo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.C_check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.C_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbVistaPrevia = new System.Windows.Forms.GroupBox();
            this.lblPStock = new System.Windows.Forms.Label();
            this.lblPPrecio = new System.Windows.Forms.Label();
            this.lblPCategoria = new System.Windows.Forms.Label();
            this.lblPNombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbVistaPrevia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(66, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulario Producto";
            // 
            // pTitulo
            // 
            this.pTitulo.BackColor = System.Drawing.Color.Transparent;
            this.pTitulo.Controls.Add(this.pictureBox2);
            this.pTitulo.Controls.Add(this.label1);
            this.pTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pTitulo.Location = new System.Drawing.Point(0, 0);
            this.pTitulo.Name = "pTitulo";
            this.pTitulo.Size = new System.Drawing.Size(684, 101);
            this.pTitulo.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoTienda.Properties.Resources.Product;
            this.pictureBox2.Location = new System.Drawing.Point(37, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(79, 24);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Nombre";
            this.txtNombre.Size = new System.Drawing.Size(237, 33);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtSoloLetras_TextChanged);
            // 
            // cbCategoria
            // 
            this.cbCategoria.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Vitaminas",
            "Proteinas",
            "Aminoacidos",
            "Creatina",
            "Alimentos y Bebidas",
            "Pre-Entreno"});
            this.cbCategoria.Location = new System.Drawing.Point(79, 85);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(237, 33);
            this.cbCategoria.TabIndex = 2;
            this.cbCategoria.Text = "Categoria";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPrecio.Location = new System.Drawing.Point(79, 154);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PlaceholderText = "Precio";
            this.txtPrecio.Size = new System.Drawing.Size(237, 33);
            this.txtPrecio.TabIndex = 3;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtSoloNumeros_TextChanged);
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtStock.Location = new System.Drawing.Point(79, 219);
            this.txtStock.Name = "txtStock";
            this.txtStock.PlaceholderText = "Stock";
            this.txtStock.Size = new System.Drawing.Size(237, 33);
            this.txtStock.TabIndex = 5;
            this.txtStock.TextChanged += new System.EventHandler(this.txtSoloNumeros_TextChanged);
            // 
            // pCuerpo
            // 
            this.pCuerpo.BackColor = System.Drawing.Color.Transparent;
            this.pCuerpo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pCuerpo.Controls.Add(this.label2);
            this.pCuerpo.Controls.Add(this.dataGridView1);
            this.pCuerpo.Controls.Add(this.gbVistaPrevia);
            this.pCuerpo.Controls.Add(this.btnConfirmar);
            this.pCuerpo.Controls.Add(this.txtNombre);
            this.pCuerpo.Controls.Add(this.cbCategoria);
            this.pCuerpo.Controls.Add(this.txtPrecio);
            this.pCuerpo.Controls.Add(this.txtStock);
            this.pCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCuerpo.Location = new System.Drawing.Point(0, 101);
            this.pCuerpo.Name = "pCuerpo";
            this.pCuerpo.Size = new System.Drawing.Size(684, 400);
            this.pCuerpo.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(409, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Seleccionar Proveedores";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_check,
            this.C_Proveedor,
            this.C_Precio});
            this.dataGridView1.Location = new System.Drawing.Point(360, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 100;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(297, 298);
            this.dataGridView1.TabIndex = 14;
            // 
            // C_check
            // 
            this.C_check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.NullValue = false;
            this.C_check.DefaultCellStyle = dataGridViewCellStyle3;
            this.C_check.HeaderText = "Disponible";
            this.C_check.Name = "C_check";
            this.C_check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.C_check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.C_check.Width = 109;
            // 
            // C_Proveedor
            // 
            this.C_Proveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C_Proveedor.DefaultCellStyle = dataGridViewCellStyle4;
            this.C_Proveedor.HeaderText = "Proveedor";
            this.C_Proveedor.Name = "C_Proveedor";
            this.C_Proveedor.Width = 107;
            // 
            // C_Precio
            // 
            this.C_Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.C_Precio.DefaultCellStyle = dataGridViewCellStyle5;
            this.C_Precio.HeaderText = "Precio de Compra";
            this.C_Precio.Name = "C_Precio";
            this.C_Precio.Width = 145;
            // 
            // gbVistaPrevia
            // 
            this.gbVistaPrevia.Controls.Add(this.lblPStock);
            this.gbVistaPrevia.Controls.Add(this.lblPPrecio);
            this.gbVistaPrevia.Controls.Add(this.lblPCategoria);
            this.gbVistaPrevia.Controls.Add(this.lblPNombre);
            this.gbVistaPrevia.Controls.Add(this.pictureBox1);
            this.gbVistaPrevia.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbVistaPrevia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbVistaPrevia.Location = new System.Drawing.Point(79, 13);
            this.gbVistaPrevia.Name = "gbVistaPrevia";
            this.gbVistaPrevia.Size = new System.Drawing.Size(268, 265);
            this.gbVistaPrevia.TabIndex = 13;
            this.gbVistaPrevia.TabStop = false;
            this.gbVistaPrevia.Text = "Producto";
            this.gbVistaPrevia.Visible = false;
            // 
            // lblPStock
            // 
            this.lblPStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPStock.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPStock.ForeColor = System.Drawing.Color.Lavender;
            this.lblPStock.Location = new System.Drawing.Point(100, 226);
            this.lblPStock.Name = "lblPStock";
            this.lblPStock.Size = new System.Drawing.Size(73, 21);
            this.lblPStock.TabIndex = 4;
            this.lblPStock.Text = "Stock";
            this.lblPStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPPrecio
            // 
            this.lblPPrecio.AutoSize = true;
            this.lblPPrecio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPPrecio.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblPPrecio.Location = new System.Drawing.Point(190, 23);
            this.lblPPrecio.Name = "lblPPrecio";
            this.lblPPrecio.Size = new System.Drawing.Size(56, 25);
            this.lblPPrecio.TabIndex = 3;
            this.lblPPrecio.Text = "$140";
            // 
            // lblPCategoria
            // 
            this.lblPCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPCategoria.ForeColor = System.Drawing.Color.Aqua;
            this.lblPCategoria.Location = new System.Drawing.Point(100, 196);
            this.lblPCategoria.Name = "lblPCategoria";
            this.lblPCategoria.Size = new System.Drawing.Size(73, 21);
            this.lblPCategoria.TabIndex = 2;
            this.lblPCategoria.Text = "Categoria";
            this.lblPCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPNombre
            // 
            this.lblPNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPNombre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPNombre.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblPNombre.Location = new System.Drawing.Point(100, 163);
            this.lblPNombre.Name = "lblPNombre";
            this.lblPNombre.Size = new System.Drawing.Size(73, 21);
            this.lblPNombre.TabIndex = 1;
            this.lblPNombre.Text = "Nombre";
            this.lblPNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoTienda.Properties.Resources.Product;
            this.pictureBox1.Location = new System.Drawing.Point(85, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.White;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.Location = new System.Drawing.Point(79, 303);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(235, 60);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 491);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(684, 10);
            this.panel3.TabIndex = 14;
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(95)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(684, 501);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pCuerpo);
            this.Controls.Add(this.pTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AgregarProducto";
            this.Load += new System.EventHandler(this.AgregarProducto_Load);
            this.pTitulo.ResumeLayout(false);
            this.pTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pCuerpo.ResumeLayout(false);
            this.pCuerpo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbVistaPrevia.ResumeLayout(false);
            this.gbVistaPrevia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel pTitulo;
        private TextBox txtNombre;
        private ComboBox cbCategoria;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private Panel pCuerpo;
        private Panel panel3;
        private Button btnConfirmar;
        private GroupBox gbVistaPrevia;
        private Label lblPStock;
        private Label lblPPrecio;
        private Label lblPCategoria;
        private Label lblPNombre;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn C_check;
        private DataGridViewTextBoxColumn C_Proveedor;
        private DataGridViewTextBoxColumn C_Precio;
    }
}