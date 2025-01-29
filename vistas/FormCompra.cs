using System;
using System.Collections.Generic;
using System.ComponentModel;
using ProyectoTienda.controladores;
using ProyectoTienda.modelos;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPdf;
using HandlebarsDotNet;

namespace ProyectoTienda.vistas
{
    public partial class FormCompra : Form
    {
        Usuario usr = new Usuario();
        List<Producto> productos = new List<Producto>();
        string mensaje = "";
        Producto producto = new Producto();
        List<Producto> orden = new List<Producto>();
        List<dynamic> ordenordenada = new List<dynamic>();
        byte on = 0;
        decimal total = 0;
        Cliente Cliente = new Cliente();
        List<Cliente> clientes = new List<Cliente>();
        List<Proveedor> proveedores = new List<Proveedor>();
        Proveedor proveedor = new Proveedor();
        List<Venta> ventas = new List<Venta>();
        Venta venta = new Venta();
        List<Compra> compras = new List<Compra>();
        Compra compra = new Compra();  
        ProvProducto provProd = new ProvProducto();
        List<ProvProducto> provProductos = new List<ProvProducto>();

        int variableAux = 0;
        public FormCompra(Usuario user)
        {
            usr = user;
            InitializeComponent();
        }

        private void cbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            total = 0;
            ordenordenada.Clear();
            orden.Clear();
            dgvOrden.Rows.Clear();
            dgvPrincipal.Rows.Clear();
            lblTotal.Text = "Total: " + "$" + total.ToString();
            List<ProvProducto> lista = provProductos.FindAll(x => x.id_prov == cbProveedor.SelectedIndex);
            for(int i=0;i<lista.Count;i++) { if (productos[i].Id == lista[i].id_prod) { productos[i].Precio = Convert.ToDouble(lista[i].precio); dgvPrincipal.Rows.Add(productos[i].Id, productos[i].Nombre, lista[i].precio); } }
        }
        private void CargarDGV()
        {
            dgvPrincipal.Rows.Clear();
            //productos = Principal.ConsultarProductos(productos, ref mensaje, ref producto);
            foreach (Producto product in productos) dgvPrincipal.Rows.Add(product.Id, product.Nombre, product.Precio, product.Stock);
        }
        private void BotonesLaterales_Click(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            switch (Convert.ToByte(btn.Tag))
            {
                case 0: //boton Principal
                    FormPrincipal principal = new FormPrincipal(usr);
                    Form.ActiveForm.Close();
                    principal.Show();
                    break;
                case 1: //boton Usuarios
                    FormCatalogoUsuario formUsuario = new FormCatalogoUsuario(usr);
                    Form.ActiveForm.Close();
                    formUsuario.Show();
                    break;
                case 2: //boton Productos
                    FormCatalogoProducto formProductos = new FormCatalogoProducto(usr);
                    Form.ActiveForm.Close();
                    formProductos.Show();
                    break;
                case 3: //Boton Proveedores
                    FormCatalogoProveedor formProveedor = new FormCatalogoProveedor(usr);
                    Form.ActiveForm.Close();
                    formProveedor.Show();
                    break;
                case 4: //Boton Reportes
                    FormReportes reportes = new FormReportes(usr);
                    Form.ActiveForm.Close();
                    reportes.Show();
                    break;
                /*case 5: //Boton Compras
                    FormCompra compras = new FormCompra(user);
                    Form.ActiveForm.Close();
                    compras.Show();
                    break;*/
                case 6: //Boton Clientes
                    FormCatalogoClientes clientes = new FormCatalogoClientes(usr);
                    Form.ActiveForm.Close();
                    clientes.Show();
                    break;
            }
        }

        private void BotonesCategorias_Click(object sender, EventArgs e)
        {
            btnVitaminas.Image = Properties.Resources.Vitaminas_A;
            btnProteinas.Image = Properties.Resources.Proteinas_A;
            btnAminoacidos.Image = Properties.Resources.Aminoacidos_A;
            btnCreatina.Image = Properties.Resources.Creatina_A;
            btnAlimentosyB.Image = Properties.Resources.Alimentos_y_Bebidas_A;
            btnPre.Image = Properties.Resources.Pre_Entreno_A;
            PictureBox btn = (PictureBox)sender;
            byte id = on != 0 && on == Convert.ToByte(btn.Tag) ? (byte)0 : Convert.ToByte(btn.Tag);
            switch (id)
            {
                case 0: CargarDGV(); on = 0; break;
                case 1: //Boton Vitaminas
                    on = id;
                    dgvPrincipal.Rows.Clear();
                    btn.Image = ProyectoTienda.Properties.Resources.Vitaminas_B;
                    foreach (Producto product in productos)
                        if (product.IdCategoria == id - 1) { dgvPrincipal.Rows.Add(product.Id, product.Nombre, product.Precio); }
                    break;
                case 2: //Boton Proteinas
                    on = id;
                    dgvPrincipal.Rows.Clear();
                    btn.Image = ProyectoTienda.Properties.Resources.Proteinas_B;
                    foreach (Producto product in productos)
                        if (product.IdCategoria == id - 1) { dgvPrincipal.Rows.Add(product.Id, product.Nombre, product.Precio); }
                    break;
                case 3: //Boton Aminoacidos
                    on = id;
                    dgvPrincipal.Rows.Clear();
                    btn.Image = ProyectoTienda.Properties.Resources.Aminoacidos_B;
                    foreach (Producto product in productos)
                        if (product.IdCategoria == id - 1) { dgvPrincipal.Rows.Add(product.Id, product.Nombre, product.Precio); }
                    break;
                case 4: //Boton Creatina
                    on = id;
                    dgvPrincipal.Rows.Clear();
                    btn.Image = ProyectoTienda.Properties.Resources.Creatina_B;
                    foreach (Producto product in productos)
                        if (product.IdCategoria == id - 1) { dgvPrincipal.Rows.Add(product.Id, product.Nombre, product.Precio); }
                    break;
                case 5: //Boton Alimentos y Bebidas
                    on = id;
                    dgvPrincipal.Rows.Clear();
                    btn.Image = ProyectoTienda.Properties.Resources.Alimentos_y_Bebidas_B;
                    foreach (Producto product in productos)
                        if (product.IdCategoria == id - 1) { dgvPrincipal.Rows.Add(product.Id, product.Nombre, product.Precio); }
                    break;
                case 6: //Boton Pre-Entreno
                    on = id;
                    dgvPrincipal.Rows.Clear();
                    btn.Image = ProyectoTienda.Properties.Resources.Pre_Entreno_B;
                    foreach (Producto product in productos)
                        if (product.IdCategoria == id - 1) { dgvPrincipal.Rows.Add(product.Id, product.Nombre, product.Precio); }
                    break;
            }
        }
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            total = 0;
            lblTotal.Text = "Total: " + "$" + total.ToString();
            dgvOrden.Rows.Clear();
            orden.Clear();
        }
        private void dgvOrden_CellValueChanged(object sender, DataGridViewCellEventArgs e) //CORREGIR
        {
            if (dgvOrden.Rows.Count > 0)
            {
                total = 0;
                for (int i = ordenordenada[dgvOrden.CurrentRow.Index].Contador; i < Convert.ToInt32(dgvOrden.Rows[dgvOrden.CurrentCell.RowIndex].Cells[0].Value); i++) orden.Add(productos.Find(x => x.Nombre.Contains(dgvPrincipal.Rows[dgvPrincipal.CurrentCell.RowIndex].Cells[1].Value.ToString())));
                ordenordenada.Clear();
                ordenordenada = orden.GroupBy(x => x).Where(g => g.Count() > 0).Select(y => new { Producto = y.Key, Contador = y.Count() }).ToList<dynamic>();
                total = 0;
                for (int i = 0; i < orden.Count; i++) total += Convert.ToDecimal(orden[i].Precio);
                string a = string.Format("{0:#,0.00}", total);
                a = a.Replace('.', ',');
                lblTotal.Text = "Total: " + "$" + a;
            }
        }

        private void dgvOrden_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var producto = dgvOrden.Rows[dgvOrden.CurrentCell.RowIndex].Cells[1].Value.ToString();
                orden.RemoveAll(x => x.Nombre == producto);
                /*var contador = orden.Count;
                var producto = dgvPrincipal.Rows[dgvPrincipal.CurrentCell.RowIndex].Cells[1].Value.ToString();
                while(])
                    if (orden[i].Nombre.Contains(producto))
                    {
                        orden.Remove(orden[i]);
                        i--;
                    }*/
                ordenordenada.Clear(); total = 0;
                ordenordenada = orden.GroupBy(x => x).Where(g => g.Count() > 0).Select(y => new { Producto = y.Key, Contador = y.Count() }).ToList<dynamic>();
                for (int i = 0; i < orden.Count; i++) total += Convert.ToDecimal(orden[i].Precio);
                string a = string.Format("{0:#,0.00}", total);
                a = a.Replace('.', ',');
                lblTotal.Text = "Total: " + "$" + a;
                dgvOrden.Rows.RemoveAt(dgvOrden.CurrentCell.RowIndex);
            }
        }

        private void FormCompra_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = usr.nombre;
            //CargarDGV();
            timer1.Start();
            // Resolucionalta();
            productos = Principal.ConsultarProductos(productos, ref mensaje, ref producto);
            provProductos = Compras.ConsultarProvProductos(provProductos, ref mensaje, ref provProd);
            proveedores = Proveedores.ConsultarProveedores(proveedores, ref mensaje, ref proveedor);
            foreach (var prov in proveedores) cbProveedor.Items.Add(prov.nombre);
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = String.Format("{0} de {1} de {2} {3} {4}", DateTime.Now.ToString("dddd d"), DateTime.Now.ToString("MMMM"), DateTime.Now.ToString("yyyy"), DateTime.Now.ToString("h:mm"), DateTime.UtcNow.ToString("tt", System.Globalization.CultureInfo.InvariantCulture));
        }

        private void btnAgregarOrden_Click(object sender, EventArgs e)
        {
            dgvOrden.Rows.Clear();
            total = 0;
            orden.Add(productos.Find(x => x.Id.Equals(dgvPrincipal.Rows[dgvPrincipal.CurrentCell.RowIndex].Cells[0].Value)));
            ordenordenada = orden.GroupBy(x => x).Where(g => g.Count() > 0).Select(y => new { Producto = y.Key, Contador = y.Count() }).ToList<dynamic>();
            foreach (var o in ordenordenada) { dgvOrden.Rows.Add(o.Contador, o.Producto.Nombre, o.Producto.Precio); }
            for (int i = 0; i < orden.Count; i++) total += Convert.ToDecimal(orden[i].Precio);
            string a = string.Format("{0:#,0.00}", total);
            a = a.Replace('.', ',');
            lblTotal.Text = "Total: " + "$" + a;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
                if (txtBuscar.Text.Length > 0)
                {
                    dgvPrincipal.Rows.Clear();
                    List<Producto> lista = productos.FindAll(x => x.Nombre.Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                    lista = lista.OrderBy(x => x.Id).ToList();
                    foreach (Producto producto in lista) dgvPrincipal.Rows.Add(producto.Id, producto.Nombre, producto.Precio);
                }
                else
                {
                    dgvPrincipal.Rows.Clear();
                    foreach (Producto producto in productos) dgvPrincipal.Rows.Add(producto.Id, producto.Nombre, producto.Precio);
                }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtPago.Text.Length > 0)
                txtCambio.Text = Convert.ToString(Convert.ToDecimal(txtPago.Text) - total);
        }
        private PdfDocument CrearPdf()
        {
            IronPdf.License.LicenseKey = "IRONPDF.RUCO2000.27833-C5760C1C86-HSEXALNI4UQRAI2B-NWYPAIE2EGSC-J64VL47S2MDV-FZMCYKZJFNV3-CQOUAFW235TN-RQYD3L-TESBLMNMGN2GEA-DEPLOYMENT.TRIAL-SLQXY2.TRIAL.EXPIRES.28.JUN.2022";
            var html = File.ReadAllText("compraFormat.html");
            var rows = File.ReadAllText("fila.html");
            compras = consultas.ConsultarCompra(compras, ref mensaje, ref compra);
            List<fila> filas = new List<fila>();
            OrdenCompra ord = new OrdenCompra();
            proveedor = proveedores[cbProveedor.SelectedIndex];
            for (int i = 0; i < ordenordenada.Count; i++)
            {
                fila fila = new fila();
                fila.orden = i;
                fila.nombre = ordenordenada[i].Producto.Nombre;
                fila.Cantidad = ordenordenada[i].Contador;
                //fila.Unidades = ordenordenada[i].Contador;
                fila.preciounidad = ordenordenada[i].Producto.Precio;
                /*filas[i].orden = 0;
                filas[i].nombre = ordenordenada[i].Producto.Nombre;
                filas[i].Cantidad = ordenordenada[i].Contador;
                filas[i].Unidades = ordenordenada[i].Contador;
                filas[i].preciounidad = ordenordenada[i].Producto.Precio;*/
                filas.Add(fila);
            }
            ord.fecha = DateTime.Today.ToShortDateString();
            ord.orden = "00" + compras.Count.ToString();
            ord.empresa = proveedor.nombre;
            ord.razon_social = proveedor.razon_social;
            ord.calle = proveedor.calle;
            ord.Numero = proveedor.numero;
            ord.Colonia = proveedor.colonia;
            ord.CP = proveedor.cp;
            ord.telefono = proveedor.telefono;
            ord.rfc = proveedor.rfc;
            ord.comprador = usr.nombre;
            ord.rfcempleado = usr.rfc;
            ord.Numero = ventas.Count.ToString();
            ord.Positions = filas;
            Handlebars.RegisterTemplate("positionRow", rows);
            var handleBars = Handlebars.Compile(html);
            var parsed = handleBars(ord);
            using (var renderer = new HtmlToPdf())
            {
                var baseUri = new Uri(AppDomain.CurrentDomain.BaseDirectory);
                var pdf = renderer.RenderHtmlAsPdf(parsed, baseUri);
                return pdf;
                //return pdf.PageToBitmap(0);
            }


        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            decimal pago=0;
            if (txtPago.TextLength > 0)
            {
                 pago = Convert.ToDecimal(txtPago.Text);
            }
            if (ordenordenada.Count > 0)
            {
                
                if (pago >= total)
                {
                    proveedor = proveedores.Find(x => x.id.Equals(cbProveedor.SelectedIndex));
                    //Caja caja = new Caja(ordenordenada,user,Cliente);
                    //caja.ShowDialog();
                        Factura fact = new Factura(CrearPdf(), ordenordenada, usr, proveedor);
                        fact.ShowDialog();
                }
                else
                    MessageBox.Show("No es suficiente dinero para pagar la orden", "Respuesta",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("Agrega objetos al carrito para poder realizar una transaccion", "Respuesta",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {
            if (txtPago.Text.Length > 0)
                txtCambio.Text = Convert.ToString(Convert.ToDecimal(txtPago.Text) - total);
        }
    }
}
