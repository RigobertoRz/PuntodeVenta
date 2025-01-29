using System;
using System.Collections.Generic;
using ProyectoTienda.modelos;
using ProyectoTienda.controladores;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoTienda.vistas
{
    public partial class FormCatalogoProducto : Form
    {
        Usuario user;
        List<Producto> productos = new List<Producto>();
        string mensaje = "";
        Producto producto = new Producto();
        byte on = 0;
        bool onmod = false;
        public FormCatalogoProducto(Usuario usuario)
        {
            user = usuario;
            InitializeComponent();
        }
        private void FormCatalogoProducto_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = user.nombre;
            CargarDGV();
            timer1.Start();
            Resolucionalta();
            Auth();
        }
        private void Auth()
        {
            if (user.rol == false)
            {
                btnAgregar.Enabled = false;
                dgvPrincipal.Columns.Remove(dgvPrincipal.Columns[dgvPrincipal.Columns.Count-1]);
                dgvPrincipal.Columns.Remove(dgvPrincipal.Columns[dgvPrincipal.Columns.Count-1]);
            }
        }
        //Menu Lateral y Menu Categorias
        #region BotonesMenus
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
                /*case 2: //boton Productos
                    FormCatalogoProducto formProductos = new FormCatalogoProducto(user);
                    Form.ActiveForm.Close();
                    formProductos.Show();
                    break;*/
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
                case 1: //boton Vitaminas
                    on = id;
                    dgvPrincipal.Rows.Clear();
                    btn.Image = ProyectoTienda.Properties.Resources.Vitaminas_B;
                    foreach (Producto product in productos)
                        if (product.IdCategoria == id - 1) { dgvPrincipal.Rows.Add(product.Id, product.Nombre, product.Precio,product.Stock); }
                    break;
                case 2: //boton Proteinas
                    on = id;
                    dgvPrincipal.Rows.Clear();
                    btn.Image = ProyectoTienda.Properties.Resources.Proteinas_B;
                    foreach (Producto product in productos)
                        if (product.IdCategoria == id - 1) { dgvPrincipal.Rows.Add(product.Id, product.Nombre, product.Precio, product.Stock); }
                    break;
                case 3: //Boton Aminoacidos
                    on = id;
                    dgvPrincipal.Rows.Clear();
                    btn.Image = ProyectoTienda.Properties.Resources.Aminoacidos_B;
                    foreach (Producto product in productos)
                        if (product.IdCategoria == id - 1) { dgvPrincipal.Rows.Add(product.Id, product.Nombre, product.Precio, product.Stock); }
                    break;
                case 4: //Boton Creatina
                    on = id;
                    dgvPrincipal.Rows.Clear();
                    btn.Image = ProyectoTienda.Properties.Resources.Creatina_B;
                    foreach (Producto product in productos)
                        if (product.IdCategoria == id - 1) { dgvPrincipal.Rows.Add(product.Id, product.Nombre, product.Precio, product.Stock); }
                    break;
                case 5: //Boton Alimentos y Bebidas
                    on = id;
                    dgvPrincipal.Rows.Clear();
                    btn.Image = ProyectoTienda.Properties.Resources.Alimentos_y_Bebidas_B;
                    foreach (Producto product in productos)
                        if (product.IdCategoria == id - 1) { dgvPrincipal.Rows.Add(product.Id, product.Nombre, product.Precio, product.Stock); }
                    break;
                case 6: //Boton Pre-Entreno
                    on = id;
                    dgvPrincipal.Rows.Clear();
                    btn.Image = ProyectoTienda.Properties.Resources.Pre_Entreno_B;
                    foreach (Producto product in productos)
                        if (product.IdCategoria == id - 1) { dgvPrincipal.Rows.Add(product.Id, product.Nombre, product.Precio, product.Stock); }
                    break;
            }
        }
        #endregion 
        private void CargarDGV()
        {
            dgvPrincipal.Rows.Clear();
            productos = Principal.ConsultarProductos(productos, ref mensaje, ref producto);
            foreach (Producto product in productos) dgvPrincipal.Rows.Add(product.Id, product.Nombre, product.Precio,product.Stock); 
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
                pCategorias.SetBounds(213, 955, 1273, 86);
                //Menu Lateral

                btnPrincipal.SetBounds(23, 16, 66, 155);
                btnUsuarios.SetBounds(23, 200, 66, 155);
                btnProductos.SetBounds(23, 387, 66, 155);
                btnProveedores.SetBounds(23, 568, 66, 155);
                btnReportes.SetBounds(23, 756, 66, 155);



                //Menu Superior

                PbUsuario.SetBounds(31, 28, 56, 50);
                lblUsuario.SetBounds(93, 22, 469, 63);
                lblUsuario.Font = new Font("Segoe Fluent Icons", 36, FontStyle.Bold);
                lblHora.SetBounds(1050, 22, 678, 76);
                lblHora.Font = new Font("Segoe Fluent Icons", 32, FontStyle.Bold);
                txtBuscar.SetBounds(24, 103, 1000, 47);
                txtBuscar.Font = new Font("Century Gothic", 24);
                cbBuscar.SetBounds(1050, 103, 250, 47);
                cbBuscar.Font = new Font("Century Gothic", 24);
                cbBuscar.SelectedIndex = 1;
                //dgv
                dgvPrincipal.SetBounds(229, 180, 1667, 791);
                //Menu Categorias

                btnVitaminas.SetBounds(148, 5, 184, 68);
                btnProteinas.SetBounds(338, 5, 177, 68);
                btnAminoacidos.SetBounds(521, 5, 220, 68);
                btnCreatina.SetBounds(747, 5, 166, 68);
                btnAlimentosyB.SetBounds(919, 5, 305, 68);
                btnPre.SetBounds(1232, 5, 184, 68);
                btnAgregar.SetBounds(1353, 103, 280, 47);
                btnAgregar.Font = new Font("Segoe UI Semibold", 18 );
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Length > 0)
            {
                dgvPrincipal.Rows.Clear();
                switch (cbBuscar.SelectedIndex)
                {
                    case 0:
                        List<Producto> listaid = productos.FindAll(x => x.Id.ToString().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listaid = listaid.OrderBy(x => x.Id).ToList();
                        foreach (Producto producto in listaid) dgvPrincipal.Rows.Add(producto.Id, producto.Nombre, producto.Precio, producto.Stock);
                        break;
                    case 1:
                        List<Producto> listaN = productos.FindAll(x => x.Nombre.Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listaN = listaN.OrderBy(x => x.Id).ToList();
                        foreach (Producto producto in listaN) dgvPrincipal.Rows.Add(producto.Id, producto.Nombre, producto.Precio, producto.Stock);
                        break;
                    case 2:
                        List<Producto> listaP = productos.FindAll(x => x.Precio.ToString().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listaP = listaP.OrderBy(x => x.Id).ToList();
                        foreach (Producto producto in listaP) dgvPrincipal.Rows.Add(producto.Id, producto.Nombre, producto.Precio, producto.Stock);
                        break;
                }
                
            }
            else
            {
                dgvPrincipal.Rows.Clear();
                foreach (Producto producto in productos) dgvPrincipal.Rows.Add(producto.Id, producto.Nombre, producto.Precio, producto.Stock);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarProducto agregarProducto = new AgregarProducto(productos);
            agregarProducto.ShowDialog();

        }

        private void dgvPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)//checa por la columna que tiene botones
            {
                Producto modificado = new Producto();
                if (e.ColumnIndex == dgvPrincipal.Columns.Count - 2) //checa si la columna es la de modificar
                {
                    if (onmod == false)
                    {
                        int id = Convert.ToInt32(dgvPrincipal.Rows[e.RowIndex].Cells[0].Value);
                        pHeader.Enabled = false;
                        pCategorias.Enabled = false;
                        dgvPrincipal.SelectionMode = DataGridViewSelectionMode.CellSelect;
                        dgvPrincipal[e.ColumnIndex,e.RowIndex].Style.BackColor= Color.Blue;
                        dgvPrincipal[e.ColumnIndex, e.RowIndex].Style.ForeColor= Color.White;
                        foreach (DataGridViewRow row in dgvPrincipal.Rows)
                            if (row.Index == e.RowIndex) { row.Cells[1].ReadOnly = false; row.Cells[2].ReadOnly = false; row.Cells[3].ReadOnly = false; row.Cells[2].Value = row.Cells[2].Value.ToString().Replace("$", "");  } else { row.Visible = false; }
                        onmod = true;
                    }
                    else
                    {
                        pHeader.Enabled = true;
                        pCategorias.Enabled = true;
                        dgvPrincipal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvPrincipal[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Yellow;
                        dgvPrincipal[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Black;
                        foreach (DataGridViewRow row in dgvPrincipal.Rows) {
                            if (row.Index == e.RowIndex) {
                                row.Cells[1].ReadOnly = true; row.Cells[2].ReadOnly = true; row.Cells[3].ReadOnly = true;
                                
                                if(row.Cells[0].Value!="")modificado.Id = Convert.ToInt32(row.Cells[0].Value);
                                if (row.Cells[1].Value != "") modificado.Nombre = row.Cells[1].Value.ToString();
                                if (row.Cells[2].Value != "") modificado.Precio = Convert.ToDouble(row.Cells[2].Value);
                                if (row.Cells[3].Value != "") modificado.Stock = Convert.ToInt32(row.Cells[3].Value);
                            } else { row.Visible = true; }
                        }
                        if ((MessageBox.Show("¿Desea Guardar Sus Cambios?", "Confirmacion",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                        {
                            Productos.Modificar(ref mensaje, modificado);
                            onmod = false;
                            
                        }
                        else
                        {
                            onmod = false;
                            
                        }
                      CargarDGV();
                        foreach (DataGridViewRow row in dgvPrincipal.Rows) row.ReadOnly = true;
                    }

                }
                if (e.ColumnIndex == dgvPrincipal.Columns.Count-1) //checa si la columna es la de borrar
                {
                    int id = Convert.ToInt32(dgvPrincipal.Rows[e.RowIndex].Cells[0].Value);
                    if ((MessageBox.Show("¿Esta Seguro que quiere borrar este registro?,Los cambios efectuados no seran reversibles", "Confirmacion",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                        Productos.Eliminar(id, ref mensaje, ref producto);
                }
                
            }
        }
        private void dgvPrincipal_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void dgvPrincipal_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(C_SolonumerosKeyPress);
            if (dgvPrincipal.CurrentCell.ColumnIndex == 2 || dgvPrincipal.CurrentCell.ColumnIndex == 3) //Columnas con solo numeros
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(C_SolonumerosKeyPress);
                }
            }
            /*if (dgvPrincipal.CurrentCell.ColumnIndex == 2 || dgvPrincipal.CurrentCell.ColumnIndex == 3) //Columnas con solo letras
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(C_SololetrasKeyPress);
                }
            }*/
            if (dgvPrincipal.CurrentCell.ColumnIndex == 1 ) //Columnas con letras y numeros
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(C_SololetrasynumerosKeyPress);
                }
            }
        }
        private void C_SolonumerosKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void C_SololetrasKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void C_SololetrasynumerosKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
