using System;
using ProyectoTienda.controladores;
using ProyectoTienda.modelos;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class FormPrincipal : Form
    {
        Usuario user;
        List<Producto> productos = new List<Producto>();
        string mensaje = "";
        Producto producto = new Producto();
        List<Producto> orden = new List<Producto>();
        List<dynamic> ordenordenada = new List<dynamic>();
        byte on = 0;
        decimal total = 0;
        Cliente Cliente = new Cliente();
        List<Cliente> clientes = new List<Cliente>();
        List<Proveedor> Proveedores = new List<Proveedor>();
        Proveedor proveedor = new Proveedor();
        List<Venta> ventas = new List<Venta>();
        Venta venta = new Venta();

        int variableAux = 0;
        public FormPrincipal(Usuario usuario)
        {
            user = usuario;
            InitializeComponent();
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = user.nombre;
            CargarDGV();
            timer1.Start();
            Resolucionalta();
            clientes = consultas.ConsultarClientes(clientes, ref mensaje, ref Cliente);
            foreach (var cliente in clientes) cbCliente.Items.Add(cliente.nombre);
        }
        //Menu Lateral y Menu Categorias
        #region BotonesMenus 
        private void BotonesLaterales_Click(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            switch (Convert.ToByte(btn.Tag))
            {
                /*case 0: //boton Principal
                    FormPrincipal principal = new FormPrincipal(user);
                    Form.ActiveForm.Close();
                    principal.Show();
                    break;*/
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
                case 4: //Boton Reportes
                    FormReportes reportes = new FormReportes(user);
                    Form.ActiveForm.Close();
                    reportes.Show();
                    break;
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
        #endregion   
        private void CargarDGV()
        {
            dgvPrincipal.Rows.Clear();
            productos = Principal.ConsultarProductos(productos, ref mensaje, ref producto);
            foreach (Producto product in productos) dgvPrincipal.Rows.Add(product.Id, product.Nombre, product.Precio, product.Stock);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = String.Format("{0} de {1} de {2} {3} {4}", DateTime.Now.ToString("dddd d"), DateTime.Now.ToString("MMMM"), DateTime.Now.ToString("yyyy"), DateTime.Now.ToString("h:mm"), DateTime.UtcNow.ToString("tt", System.Globalization.CultureInfo.InvariantCulture));
        }
        private void Resolucionalta()
        {
            if (Screen.PrimaryScreen.Bounds.ToString().Contains("1920"))
            {
                pLateral.SetBounds(0, 0, 213, 1041);
                pMenuLateral.SetBounds(-6, 59, 115, 938);
                pHeader.SetBounds(213, 0, 1273, 158);
                pOrden.SetBounds(1486, 0, 418, 1041);
                pCategorias.SetBounds(213, 955, 1273, 86);
                pdata.SetBounds(213, 158, 1273, 797);
                //Menu Lateral

                btnPrincipal.SetBounds(23, 16, 66, 155);
                btnUsuarios.SetBounds(23, 200, 66, 155);
                btnProductos.SetBounds(23, 387, 66, 155);
                btnProveedores.SetBounds(23, 568, 66, 155);
                btnReportes.SetBounds(23, 756, 66, 155);



                //Menu Superior

                PbUsuario.SetBounds(17, 23, 56, 50);
                lblUsuario.SetBounds(79, 15, 469, 63);
                lblUsuario.Font = new Font("Segoe Fluent Icons", 36, FontStyle.Bold);
                lblHora.SetBounds(570, 15, 678, 76);
                lblHora.Font = new Font("Segoe Fluent Icons", 32, FontStyle.Bold);
                txtBuscar.SetBounds(17, 95, 1257, 47);
                txtBuscar.Font = new Font("Century Gothic", 24);


                //Menu Orden

                lblOrden.SetBounds(24, 25, 125, 48);
                lblOrden.Font = new Font("Segoe Fluent Icons", 36, FontStyle.Bold);
                btnReiniciar.SetBounds(336, 36, 51, 50);

                lblTotal.SetBounds(20, 775, 105, 48);
                lblTotal.Font = new Font("Microsoft Sans Serif", 30, FontStyle.Regular);
                btnPagar.SetBounds(80, 920, 260, 77);
                btnPagar.Font = new Font("Segoe UI", 18, FontStyle.Bold);
                //dgv
                dgvPrincipal.SetBounds(20, 0, 1254, 701);
                btnAgregarOrden.SetBounds(254, 730, 748, 77);
                btnAgregarOrden.Font = new Font("Segoe UI", 18, FontStyle.Bold);
                //Menu Categorias

                btnVitaminas.SetBounds(8, 5, 184, 68);
                btnProteinas.SetBounds(198, 5, 177, 68);
                btnAminoacidos.SetBounds(381, 5, 220, 68);
                btnCreatina.SetBounds(607, 5, 166, 68);
                btnAlimentosyB.SetBounds(779, 5, 305, 68);
                btnPre.SetBounds(1092, 5, 184, 68);


                dgvOrden.SetBounds(13, 103, 384, 669);
            }
        }
        private PdfDocument CrearPdf()
        {
            IronPdf.License.LicenseKey = "IRONPDF.RUCO2000.27833-C5760C1C86-HSEXALNI4UQRAI2B-NWYPAIE2EGSC-J64VL47S2MDV-FZMCYKZJFNV3-CQOUAFW235TN-RQYD3L-TESBLMNMGN2GEA-DEPLOYMENT.TRIAL-SLQXY2.TRIAL.EXPIRES.28.JUN.2022";
            var html = File.ReadAllText("ticketFormat.html");
            var rows = File.ReadAllText("fila.html");
            ventas = consultas.ConsultarVentas(ventas, ref mensaje, ref venta);
            List<fila> filas = new List<fila>();
            Orden ord = new Orden();
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
            ord.Fecha = DateTime.Today.ToShortDateString();
            ord.orden = "00"+ventas.Count.ToString();
            ord.vendedor = user.nombre;
            ord.cliente = Cliente.nombre;
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

        private void btnAgregarOrden_Click(object sender, EventArgs e)
        {
            dgvOrden.Rows.Clear();
            total = 0;
            orden.Add(productos.Find(x => x.Id.Equals(dgvPrincipal.Rows[dgvPrincipal.CurrentCell.RowIndex].Cells[0].Value)));
            ordenordenada = orden.GroupBy(x => x).Where(g => g.Count() > 0).Select(y => new { Producto = y.Key, Contador = y.Count() }).ToList<dynamic>();

            bool seguir = true;
            foreach (var a in ordenordenada) //si hay stock
            {
                if (orden[orden.Count - 1].Id == a.Producto.Id && a.Contador > a.Producto.Stock)
                {
                    seguir = false;
                }
            }
            if (seguir)
            {
                foreach (var o in ordenordenada) { dgvOrden.Rows.Add(o.Contador, o.Producto.Nombre, o.Producto.Precio); }
                for (int i = 0; i < orden.Count; i++) total += Convert.ToDecimal(orden[i].Precio);
                string a = string.Format("{0:#,0.00}", total);
                a = a.Replace('.', ',');
                lblTotal.Text = "Total: " + "$" + a;
            }
            else
            {
                orden.RemoveAt(orden.Count - 1);
                ordenordenada = orden.GroupBy(x => x).Where(g => g.Count() > 0).Select(y => new { Producto = y.Key, Contador = y.Count() }).ToList<dynamic>();
                foreach (var o in ordenordenada) { dgvOrden.Rows.Add(o.Contador, o.Producto.Nombre, o.Producto.Precio); }
                for (int i = 0; i < orden.Count; i++) total += Convert.ToDecimal(orden[i].Precio);
                string a = string.Format("{0:#,0.00}", total);
                a = a.Replace('.', ',');
                lblTotal.Text = "Total: " + "$" + a;
                MessageBox.Show("Stock insuficiente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                bool seguir = true;
                foreach (var a in ordenordenada) //si hay stock
                {
                    if (orden[orden.Count - 1].Id == a.Producto.Id && a.Contador > a.Producto.Stock)
                    {
                        seguir = false;
                    }
                }
                if (seguir)
                {
                    total = 0;
                    for (int i = 0; i < orden.Count; i++) total += Convert.ToDecimal(orden[i].Precio);
                    string a = string.Format("{0:#,0.00}", total);
                    a = a.Replace('.', ',');
                    lblTotal.Text = "Total: " + "$" + a;
                }
                else
                {
                    variableAux = orden[orden.Count - 1].Stock;
                    orden.RemoveAt(orden.Count - 1);
                    ordenordenada = orden.GroupBy(x => x).Where(g => g.Count() > 0).Select(y => new { Producto = y.Key, Contador = y.Count() }).ToList<dynamic>();
                    //dgvOrden.CurrentRow.Index = variableAux;
                    total = 0;
                    for (int i = 0; i < orden.Count; i++) total += Convert.ToDecimal(orden[i].Precio);
                    string a = string.Format("{0:#,0.00}", total);
                    a = a.Replace('.', ',');
                    lblTotal.Text = "Total: " + "$" + a;
                    MessageBox.Show("Stock insuficiente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
        private PdfDocument CrearPdfFactura()
        {
            IronPdf.License.LicenseKey = "IRONPDF.RUCO2000.27833-C5760C1C86-HSEXALNI4UQRAI2B-NWYPAIE2EGSC-J64VL47S2MDV-FZMCYKZJFNV3-CQOUAFW235TN-RQYD3L-TESBLMNMGN2GEA-DEPLOYMENT.TRIAL-SLQXY2.TRIAL.EXPIRES.28.JUN.2022";
            var html = File.ReadAllText("ticketFormat.html");
            var rows = File.ReadAllText("fila.html");
            ventas = consultas.ConsultarVentas(ventas, ref mensaje, ref venta);
            List<fila> filas = new List<fila>();
            Orden ord = new Orden();
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
            ord.Fecha = DateTime.Today.ToShortDateString();
            ord.orden = "00" + ventas.Count;
            ord.vendedor = user.nombre;
            ord.cliente = Cliente.nombre;
            ord.direccion = "Direccion:" + Cliente.colonia + Cliente.calle + Cliente.num_casa;
            ord.telefono = "Telefono:" + Cliente.celular;
            ord.ciudad = "Ciudad:" + "La Paz";
            ord.cp = "Codigo Postal:" + Cliente.cp;
            ord.rfc = "RFC:" + Cliente.rfc;
            ord.Numero = ord.Numero + 1;
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
            var pago = Convert.ToDecimal(txtPago.Text);
            if (ordenordenada.Count > 0)
            {
                if (pago >= total)
                {
                    Cliente = clientes.Find(x => x.id.Equals(cbCliente.SelectedIndex));
                    //Caja caja = new Caja(ordenordenada,user,Cliente);
                    //caja.ShowDialog();
                    if (rbFactura.Checked)
                    {
                        Ticket ticket = new Ticket(CrearPdfFactura(), ordenordenada, user, Cliente);
                        ticket.ShowDialog();
                    }
                    else
                    {
                        Ticket ticket = new Ticket(CrearPdf(), ordenordenada, user, Cliente);
                        ticket.ShowDialog();
                    }
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("¿Esta seguro de que desea abandonar la sesion?", "Confirmacion",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                FormLogin login = new FormLogin();
                this.Close();
                login.Show();
            }
        }

        private void PbUsuario_Click(object sender, EventArgs e)
        {
            UserInfo userinfo = new UserInfo(user);
            userinfo.Show();
        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {
            if (txtPago.Text.Length > 0)
                txtCambio.Text = Convert.ToString(Convert.ToDecimal(txtPago.Text) - total);
        }
    }
}
