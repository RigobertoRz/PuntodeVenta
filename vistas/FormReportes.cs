using System;
using ProyectoTienda.modelos;
using ProyectoTienda.controladores;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfiumViewer;

namespace ProyectoTienda.vistas
{
    public partial class FormReportes : Form
    {
        Usuario user;
        List<Producto> productos = new List<Producto>();
        string mensaje = "";
        Producto producto = new Producto();
        List<Usuario> usuarios = new List<Usuario>();
        List<Proveedor> proveedores = new List<Proveedor>();
        Proveedor proveedor = new Proveedor();
        List<Cliente> clientes = new List<Cliente> ();
        Cliente cliente = new Cliente ();
        List<Venta> ventas = new List<Venta> ();
        Venta venta = new Venta ();
        List<Compra> compras = new List<Compra> ();
        Compra compra = new Compra ();
        public FormReportes(Usuario usuario)
        {
            user = usuario;
            InitializeComponent();
        }
        private void BotonesLaterales_Click(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            switch (Convert.ToByte(btn.Tag))
            {
                case 0: //boton Principal
                    FormPrincipal principal = new FormPrincipal(user);
                    Form.ActiveForm.Close();
                    principal.Show();
                    break;
                case 1: //boton Usuarios
                    FormCatalogoUsuario formUsuario = new FormCatalogoUsuario(user);
                    Form.ActiveForm.Close();
                    formUsuario.Show();
                    break;
                case 2: //boton Productos
                    FormCatalogoProducto formProductos = new FormCatalogoProducto(user);
                    Form.ActiveForm.Close();
                    formProductos.Show();
                    break;
                case 3: //Boton Proveedores
                    FormCatalogoProveedor formProveedor = new FormCatalogoProveedor(user);
                    Form.ActiveForm.Close();
                    formProveedor.Show();
                    break;
               /* case 4: //Boton Reportes
                    FormReportes reportes = new FormReportes(user);
                    Form.ActiveForm.Close();
                    reportes.Show();
                    break;*/
                case 5:
                    FormCompra compras = new FormCompra(user);
                    Form.ActiveForm.Close();
                    compras.Show();
                    break;
                case 6:
                    FormCatalogoClientes clientes = new FormCatalogoClientes(user);
                    Form.ActiveForm.Close();
                    clientes.Show();
                    break;
            }
        }
        private void Resolucionalta()
        {
            if (Screen.PrimaryScreen.Bounds.ToString().Contains("1920"))
            {
                pLateral.SetBounds(0, 0, 213, 1041);
                pMenuLateral.SetBounds(-6, 59, 115, 938);
                pHeader.SetBounds(213, 0, 1273, 158);
                //Menu Lateral

                btnPrincipal.SetBounds(23, 16, 66, 155);
                btnUsuarios.SetBounds(23, 200, 66, 155);
                btnProductos.SetBounds(23, 387, 66, 155);
                btnProveedores.SetBounds(23, 568, 66, 155);
                btnReportes.SetBounds(23, 756, 66, 155);

                cbSelecccionar.SetBounds(24, 103, 1300, 47);
                cbSelecccionar.Font = new Font("Century Gothic", 24);

                //Menu Superior

                PbUsuario.SetBounds(31, 28, 56, 50);
                lblUsuario.SetBounds(93, 22, 469, 63);
                lblUsuario.Font = new Font("Segoe Fluent Icons", 36, FontStyle.Bold);
                lblHora.SetBounds(1050, 22, 678, 76);
                lblHora.Font = new Font("Segoe Fluent Icons", 32, FontStyle.Bold);
                //dgv
                dgvPrincipal.SetBounds(229, 180, 1667, 791);
                //Menu Categorias
                //btnGenConsulta.SetBounds(1353, 103, 280, 47);
                //btnGenConsulta.Font = new Font("Segoe UI Semibold", 18);
            }
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            Resolucionalta();
            lblUsuario.Text = user.nombre;
            timer1.Start();
            Resolucionalta();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = String.Format("{0} de {1} de {2} {3} {4}", DateTime.Now.ToString("dddd d"), DateTime.Now.ToString("MMMM"), DateTime.Now.ToString("yyyy"), DateTime.Now.ToString("h:mm"), DateTime.UtcNow.ToString("tt", System.Globalization.CultureInfo.InvariantCulture));
        }

       

        private void btnConfirmar_Click(object sender, EventArgs e)
        {      
            string mes = cmbMeses.Text; 
            dgvPrincipal.DataSource = null;
            ventas = consultas.ConsultarVentasXMES(ventas, ref mensaje, ref venta,ref mes);
            dgvPrincipal.DataSource = ventas;
            foreach (DataGridViewColumn column in dgvPrincipal.Columns) column.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 24);
        }
        private void BtnMostrarAño_Click(object sender, EventArgs e)
        {
            btnComprasXMES.Visible = false;
            cmbMeses.Visible = false;
            BtnAño.Visible = true;
            btnConfirmar.Visible = false;
            btnConFecha1.Visible = false;
            btnComFechas.Visible = false;
            cmbAños.Visible = true;
            btnComFechas.Visible = false;
            txtDia.Visible = false;
            txtMes.Visible = false;
            txtAño.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            ventas = consultas.ConsultarVentas(ventas, ref mensaje, ref venta);
            dgvPrincipal.DataSource = ventas;
            foreach (DataGridViewColumn column in dgvPrincipal.Columns) column.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 24);
            MessageBox.Show("Seleccione el año", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void BtnAño_Click(object sender, EventArgs e)
        {
            string año = cmbAños.Text;
            dgvPrincipal.DataSource = null;
            ventas = consultas.ConsultarVentasXAÑO(ventas, ref mensaje, ref venta, ref año);
            dgvPrincipal.DataSource = ventas;
            foreach (DataGridViewColumn column in dgvPrincipal.Columns) column.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 24);
        }

        private void btnVentadXDia_Click(object sender, EventArgs e)
        {
            btnComprasXANIO.Visible = false;
            btnComprasXMES.Visible = false;
            cmbMeses.Visible = false;
            BtnAño.Visible = false;
            btnConfirmar.Visible = false;
            btnConFecha1.Visible = true;
            BtnAño.Visible = false;
            btnComFechas.Visible = false;
            cmbAños.Visible = false;
            btnComFechas.Visible = false;
            txtDia.Visible = true;
            txtMes.Visible = true;
            txtAño.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            txtDia.Text = DateTime.Now.ToString(String.Format(" dd"));
            txtMes.Text = DateTime.Now.ToString(String.Format(" MM"));
            txtAño.Text = DateTime.Now.ToString(String.Format("yyyy"));
            ventas = consultas.ConsultarVentas(ventas, ref mensaje, ref venta);
            dgvPrincipal.DataSource = ventas;
            foreach (DataGridViewColumn column in dgvPrincipal.Columns) column.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 24);
            MessageBox.Show("Ingrese la fecha o dejar el dia actual", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnConFecha1_Click(object sender, EventArgs e)
        {
            string fecha = txtAño.Text + "-"+txtMes.Text + "-" + txtDia.Text ;
            dgvPrincipal.DataSource = null;
            ventas = consultas.ConsultarVentasXFECHA(ventas, ref mensaje, ref venta, ref  fecha);
            dgvPrincipal.DataSource = ventas;
            foreach (DataGridViewColumn column in dgvPrincipal.Columns) column.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 24);
        }

        private void btnCDIA_Click(object sender, EventArgs e)
        {
            btnComprasXANIO.Visible = false;
            btnComprasXMES.Visible = false;
            cmbMeses.Visible = false;
            BtnAño.Visible = false;
            btnVentasXMES.Visible = false;
            btnVentadXDia.Visible = false;
            btnConfirmar.Visible = false;
            btnConFecha1.Visible = false;
            BtnAño.Visible = false;
            btnComFechas.Visible = false;
            cmbAños.Visible = false;
            btnComFechas.Visible = true;
            txtDia.Visible = true;
            txtMes.Visible = true;
            txtAño.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            txtDia.Text = DateTime.Now.ToString(String.Format(" dd"));
            txtMes.Text = DateTime.Now.ToString(String.Format(" MM"));
            txtAño.Text = DateTime.Now.ToString(String.Format("yyyy"));
            compras = consultas.ConsultarCompra(compras, ref mensaje, ref compra);
            dgvPrincipal.DataSource = compras;
            foreach (DataGridViewColumn column in dgvPrincipal.Columns) column.Width = 300;
            MessageBox.Show("Ingrese la fecha o dejar el dia actual", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void dgvPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)//checa por la columna que tiene botones
            {
                if (e.ColumnIndex == dgvPrincipal.Columns.Count - 1) //checa si la columna es la de borrar
                {
                    var pdfpath = "V" + dgvPrincipal[0, e.RowIndex].Value;
                    var fecha = ventas[Convert.ToInt32(dgvPrincipal[0, e.RowIndex].Value)].fecha.ToString("ddd_dd_MMM_yyy");
                    pdfpath = pdfpath+"_"+fecha;
                    pdfpath = "../../../Tickets/" + pdfpath + "_ticket.pdf";
                    var pdf = PdfiumViewer.PdfDocument.Load(pdfpath);
                    Visor visor = new Visor(pdf);
                    visor.Show();
                }
            }
        }
        private string CrearNombre()
        {
            var nombre = "V" + ventas.Count.ToString();
            nombre = " " + nombre + DateTime.Today.ToString("ddd_dd_MMM_yyy");
            return nombre;
        }
        private void btnComFechas_Click(object sender, EventArgs e)
        {
            string fecha = txtAño.Text + "-" + txtMes.Text + "-" + txtDia.Text;
            dgvPrincipal.DataSource = null;
            compras = consultas.ConsultarCompraXFECHA(compras, ref mensaje, ref compra, ref fecha);
            dgvPrincipal.DataSource = compras;
            foreach (DataGridViewColumn column in dgvPrincipal.Columns) column.Width = 300;
        }

        private void btnCAÑO_Click(object sender, EventArgs e)
        {
            btnComprasXANIO.Visible = true;
            btnComprasXMES.Visible = false;
            cmbMeses.Visible = false;
            BtnAño.Visible = false;
            btnVentasXMES.Visible = false;
            btnVentadXDia.Visible = false;
            btnConfirmar.Visible = false;
            btnConFecha1.Visible = false;
            BtnAño.Visible = false;
            btnComFechas.Visible = false;
            cmbAños.Visible = true;
            btnComFechas.Visible = false;
            txtDia.Visible = false;
            txtMes.Visible = false;
            txtAño.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            compras = consultas.ConsultarCompra(compras, ref mensaje, ref compra);
            dgvPrincipal.DataSource = compras;
            foreach (DataGridViewColumn column in dgvPrincipal.Columns) column.Width = 300;
            MessageBox.Show("Seleccione el año", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void cbSelecccionar_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbSelecccionar.SelectedIndex)
            {
                case 0:
                    btnComprasXANIO.Visible = false;
                    btnComprasXMES.Visible = false;
                    cmbMeses.Visible = false;
                    BtnAño.Visible = false;
                    btnVentasXMES.Visible = false;
                    btnVentadXDia.Visible = false;
                    btnConfirmar.Visible = false;
                    btnConFecha1.Visible = false;
                    BtnAño.Visible = false;
                    btnComFechas.Visible = false;
                    cmbAños.Visible = false;
                    btnComFechas.Visible = false;
                    txtDia.Visible = false;
                    txtMes.Visible = false;
                    txtAño.Visible = false;
                    label1.Visible = false;
                    BtnMostrarAño.Visible = false;
                    btnVentasXMES.Visible = false;
                    btnVentadXDia.Visible = false;
                    btnCAÑO.Visible = false;
                    btnCDIA.Visible = false;
                    btnCMES.Visible = false;
                    dgvPrincipal.DataSource = null;
                    clientes = consultas.ConsultarClientes(clientes, ref mensaje, ref cliente);
                    dgvPrincipal.DataSource = clientes;
                    foreach (DataGridViewColumn column in dgvPrincipal.Columns) { column.Width = 300; column.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 24); };
                    break;
                case 1:
                    btnComprasXANIO.Visible = false;
                    btnComprasXMES.Visible = false;
                    cmbMeses.Visible = false;
                    BtnAño.Visible = false;
                    btnVentasXMES.Visible = false;
                    btnVentadXDia.Visible = false;
                    btnConfirmar.Visible = false;
                    btnConFecha1.Visible = false;
                    BtnAño.Visible = false;
                    btnComFechas.Visible = false;
                    cmbAños.Visible = false;
                    btnComFechas.Visible = false;
                    txtDia.Visible = false;
                    txtMes.Visible = false;
                    txtAño.Visible = false;
                    label1.Visible = false;
                    btnCAÑO.Visible = false;
                    btnCDIA.Visible = false;
                    btnCMES.Visible = false;
                    BtnMostrarAño.Visible = true;
                    btnVentasXMES.Visible = true;
                    btnVentadXDia.Visible = true;
                    dgvPrincipal.DataSource = null;
                    ventas = consultas.ConsultarVentas(ventas, ref mensaje, ref venta);
                    dgvPrincipal.DataSource = ventas;
                    foreach (DataGridViewColumn column in dgvPrincipal.Columns) column.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 24);
                   DataGridViewButtonColumn btnclm = new DataGridViewButtonColumn();
                    btnclm.Name = "Ticket";
                    dgvPrincipal.Columns.Add(btnclm);
                    break;
                case 2:
                    btnComprasXANIO.Visible = false;
                    btnComprasXMES.Visible = false;
                    cmbMeses.Visible = false;
                    BtnAño.Visible = false;
                    btnVentasXMES.Visible = false;
                    btnVentadXDia.Visible = false;
                    btnConfirmar.Visible = false;
                    btnConFecha1.Visible = false;
                    BtnAño.Visible = false;
                    btnComFechas.Visible = false;
                    cmbAños.Visible = false;
                    btnComFechas.Visible = false;
                    txtDia.Visible = false;
                    txtMes.Visible = false;
                    txtAño.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    BtnMostrarAño.Visible = false;
                    btnVentasXMES.Visible = false;
                    btnVentadXDia.Visible = false;
                    btnCAÑO.Visible = true;
                    btnCDIA.Visible = true;
                    btnCMES.Visible = true;
                    dgvPrincipal.DataSource = null;
                    compras = consultas.ConsultarCompra(compras, ref mensaje, ref compra);
                    dgvPrincipal.DataSource = compras;
                    foreach (DataGridViewColumn column in dgvPrincipal.Columns) column.Width = 300;
                    break;

            }
        }

        private void btnComprasXANIO_Click(object sender, EventArgs e)
        {
            string anio = cmbAños.Text;
            dgvPrincipal.DataSource = null;
            compras = consultas.ConsultarCompraXANIO(compras, ref mensaje, ref compra, ref anio);
            dgvPrincipal.DataSource = compras;
            foreach (DataGridViewColumn column in dgvPrincipal.Columns) column.Width = 300;
        }

        private void btnCMES_Click(object sender, EventArgs e)
        {
            btnComprasXANIO.Visible = false;
            btnComprasXMES.Visible = true;
            cmbMeses.Visible = true;
            BtnAño.Visible = false;
            btnVentasXMES.Visible = false;
            btnVentadXDia.Visible = false;
            btnConfirmar.Visible = false;
            btnConFecha1.Visible = false;
            BtnAño.Visible = false;
            btnComFechas.Visible = false;
            cmbAños.Visible = false;
            btnComFechas.Visible = false;
            txtDia.Visible = false;
            txtMes.Visible = false;
            txtAño.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            compras = consultas.ConsultarCompra(compras, ref mensaje, ref compra);
            dgvPrincipal.DataSource = compras;
            foreach (DataGridViewColumn column in dgvPrincipal.Columns) column.Width = 300;
            MessageBox.Show("Seleccione el mes", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnComprasXMES_Click(object sender, EventArgs e)
        {
            string mes = cmbMeses.Text;
            dgvPrincipal.DataSource = null;
            compras = consultas.ConsultarCompraXMES(compras, ref mensaje, ref compra, ref mes);
            dgvPrincipal.DataSource = compras;
            foreach (DataGridViewColumn column in dgvPrincipal.Columns) column.Width = 300;
        }

        private void btnVentasXMES_Click_1(object sender, EventArgs e)
        {
            btnComprasXMES.Visible = false;
            cmbMeses.Visible = true;
            BtnAño.Visible = false;
            btnConfirmar.Visible = true;
            btnConFecha1.Visible = false;
            BtnAño.Visible = false;
            btnComFechas.Visible = false;
            cmbAños.Visible = false;
            btnComFechas.Visible = false;
            txtDia.Visible = false;
            txtMes.Visible = false;
            txtAño.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            ventas = consultas.ConsultarVentas(ventas, ref mensaje, ref venta);
            dgvPrincipal.DataSource = ventas;
            foreach (DataGridViewColumn column in dgvPrincipal.Columns) column.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 24);
            MessageBox.Show("Seleccione el mes", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}
