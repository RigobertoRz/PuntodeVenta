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

namespace ProyectoTienda.vistas
{
    public partial class FormCatalogoProveedor : Form
    {
        Usuario user;
        List<Proveedor> proveedores = new List<Proveedor>();
        string mensaje = "";
        Proveedor proveedor = new Proveedor();
        bool onmod = false;
        public FormCatalogoProveedor(Usuario usuario)
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
                /*case 3: //Boton Proveedores
                    FormCatalogoProveedor formProveedor = new FormCatalogoProveedor(user);
                    Form.ActiveForm.Close();
                    formProveedor.Show();
                    break;*/
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
                cbBuscar.SelectedIndex = 0;
                //dgv
                dgvPrincipal.SetBounds(237, 180, 1655, 849);
                btnAgregar.SetBounds(1353, 103, 280, 47);
                btnAgregar.Font = new Font("Segoe UI Semibold", 18);
            }
        }

        private void FormCatalogoProveedor_Load(object sender, EventArgs e)
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
                dgvPrincipal.Columns.Remove(dgvPrincipal.Columns[dgvPrincipal.Columns.Count - 1]);
                dgvPrincipal.Columns.Remove(dgvPrincipal.Columns[dgvPrincipal.Columns.Count - 1]);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = String.Format("{0} de {1} de {2} {3} {4}", DateTime.Now.ToString("dddd d"), DateTime.Now.ToString("MMMM"), DateTime.Now.ToString("yyyy"), DateTime.Now.ToString("h:mm"), DateTime.UtcNow.ToString("tt", System.Globalization.CultureInfo.InvariantCulture));
        }
        private void CargarDGV()
        {
            dgvPrincipal.Rows.Clear();
            proveedores = Proveedores.ConsultarProveedores(proveedores, ref mensaje, ref proveedor);
            foreach (Proveedor prov in proveedores) dgvPrincipal.Rows.Add(prov.id, prov.nombre, prov.rfc, prov.calle, prov.numero, prov.colonia, prov.ciudad, prov.municipio, prov.pais, prov.cp, prov.email, prov.telefono,prov.razon_social, prov.nombre_cont,prov.telefono_cont, prov.apellidoP_cont, prov.apellidoM_cont, prov.email_cont);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Length > 0)
            {
                dgvPrincipal.Rows.Clear();
                switch (cbBuscar.SelectedIndex)
                {
                    case 0:
                        List<Proveedor> listaid = proveedores.FindAll(x => x.id.ToString().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listaid = listaid.OrderBy(x => x.id).ToList();
                        foreach (Proveedor prov in listaid) dgvPrincipal.Rows.Add(prov.id, prov.nombre, prov.rfc, prov.calle, prov.numero, prov.colonia, prov.ciudad, prov.municipio, prov.pais, prov.cp, prov.email, prov.telefono, prov.razon_social, prov.nombre_cont, prov.telefono_cont, prov.apellidoP_cont, prov.apellidoM_cont, prov.email_cont);
                        break;
                    case 1:
                        List<Proveedor> listanombre = proveedores.FindAll(x => x.nombre.ToString().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listanombre = listanombre.OrderBy(x => x.id).ToList();
                        foreach (Proveedor prov in listanombre) dgvPrincipal.Rows.Add(prov.id, prov.nombre, prov.rfc, prov.calle, prov.numero, prov.colonia, prov.ciudad, prov.municipio, prov.pais, prov.cp, prov.email, prov.telefono, prov.razon_social, prov.nombre_cont, prov.telefono_cont, prov.apellidoP_cont, prov.apellidoM_cont, prov.email_cont);
                        break;
                    case 2:
                        List<Proveedor> listarfc = proveedores.FindAll(x => x.rfc.ToString().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listarfc = listarfc.OrderBy(x => x.id).ToList();
                        foreach (Proveedor prov in listarfc) dgvPrincipal.Rows.Add(prov.id, prov.nombre, prov.rfc, prov.calle, prov.numero, prov.colonia, prov.ciudad, prov.municipio, prov.pais, prov.cp, prov.email, prov.telefono, prov.razon_social, prov.nombre_cont, prov.telefono_cont, prov.apellidoP_cont, prov.apellidoM_cont, prov.email_cont);
                        break;
                    case 3:
                        List<Proveedor> listacalle = proveedores.FindAll(x => x.calle.ToString().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listacalle = listacalle.OrderBy(x => x.id).ToList();
                        foreach (Proveedor prov in listacalle) dgvPrincipal.Rows.Add(prov.id, prov.nombre, prov.rfc, prov.calle, prov.numero, prov.colonia, prov.ciudad, prov.municipio, prov.pais, prov.cp, prov.email, prov.telefono, prov.razon_social, prov.nombre_cont, prov.telefono_cont, prov.apellidoP_cont, prov.apellidoM_cont, prov.email_cont);
                        break;
                    case 4:
                        List<Proveedor> listanumero = proveedores.FindAll(x => x.numero.ToString().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listanumero = listanumero.OrderBy(x => x.id).ToList();
                        foreach (Proveedor prov in listanumero) dgvPrincipal.Rows.Add(prov.id, prov.nombre, prov.rfc, prov.calle, prov.numero, prov.colonia, prov.ciudad, prov.municipio, prov.pais, prov.cp, prov.email, prov.telefono, prov.razon_social, prov.nombre_cont, prov.telefono_cont, prov.apellidoP_cont, prov.apellidoM_cont, prov.email_cont);
                        break;
                    case 5:
                        List<Proveedor> listacol = proveedores.FindAll(x => x.colonia.ToString().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listacol = listacol.OrderBy(x => x.id).ToList();
                        foreach (Proveedor prov in listacol) dgvPrincipal.Rows.Add(prov.id, prov.nombre, prov.rfc, prov.calle, prov.numero, prov.colonia, prov.ciudad, prov.municipio, prov.pais, prov.cp, prov.email, prov.telefono, prov.razon_social, prov.nombre_cont, prov.telefono_cont, prov.apellidoP_cont, prov.apellidoM_cont, prov.email_cont);
                        break;
                    case 6:
                        List<Proveedor> listaci = proveedores.FindAll(x => x.ciudad.ToString().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listaci = listaci.OrderBy(x => x.id).ToList();
                        foreach (Proveedor prov in listaci) dgvPrincipal.Rows.Add(prov.id, prov.nombre, prov.rfc, prov.calle, prov.numero, prov.colonia, prov.ciudad, prov.municipio, prov.pais, prov.cp, prov.email, prov.telefono, prov.razon_social, prov.nombre_cont, prov.telefono_cont, prov.apellidoP_cont, prov.apellidoM_cont, prov.email_cont);
                        break;
                    case 7:
                        List<Proveedor> listamuni = proveedores.FindAll(x => x.municipio.ToString().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listamuni = listamuni.OrderBy(x => x.id).ToList();
                        foreach (Proveedor prov in listamuni) dgvPrincipal.Rows.Add(prov.id, prov.nombre, prov.rfc, prov.calle, prov.numero, prov.colonia, prov.ciudad, prov.municipio, prov.pais, prov.cp, prov.email, prov.telefono, prov.razon_social, prov.nombre_cont, prov.telefono_cont, prov.apellidoP_cont, prov.apellidoM_cont, prov.email_cont);
                        break;
                    case 8:
                        List<Proveedor> listapais = proveedores.FindAll(x => x.pais.ToString().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listapais = listapais.OrderBy(x => x.id).ToList();
                        foreach (Proveedor prov in listapais) dgvPrincipal.Rows.Add(prov.id, prov.nombre, prov.rfc, prov.calle, prov.numero, prov.colonia, prov.ciudad, prov.municipio, prov.pais, prov.cp, prov.email, prov.telefono, prov.razon_social, prov.nombre_cont, prov.telefono_cont, prov.apellidoP_cont, prov.apellidoM_cont, prov.email_cont);
                        break;
                    case 9:
                        List<Proveedor> listacp = proveedores.FindAll(x => x.cp.Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listacp = listacp.OrderBy(x => x.id).ToList();
                        foreach (Proveedor prov in listacp) dgvPrincipal.Rows.Add(prov.id, prov.nombre, prov.rfc, prov.calle, prov.numero, prov.colonia, prov.ciudad, prov.municipio, prov.pais, prov.cp, prov.email, prov.telefono, prov.razon_social, prov.nombre_cont, prov.telefono_cont, prov.apellidoP_cont, prov.apellidoM_cont, prov.email_cont);
                        break;
                    case 10:
                        List<Proveedor> listaemail = proveedores.FindAll(x => x.email.Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listaemail = listaemail.OrderBy(x => x.id).ToList();
                        foreach (Proveedor prov in listaemail) dgvPrincipal.Rows.Add(prov.id, prov.nombre, prov.rfc, prov.calle, prov.numero, prov.colonia, prov.ciudad, prov.municipio, prov.pais, prov.cp, prov.email, prov.telefono, prov.razon_social, prov.nombre_cont, prov.telefono_cont, prov.apellidoP_cont, prov.apellidoM_cont, prov.email_cont);
                        break;
                    case 11:
                        List<Proveedor> listatel = proveedores.FindAll(x => x.telefono.Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));;
                        listatel = listatel.OrderBy(x => x.id).ToList();
                        foreach (Proveedor prov in listatel) dgvPrincipal.Rows.Add(prov.id, prov.nombre, prov.rfc, prov.calle, prov.numero, prov.colonia, prov.ciudad, prov.municipio, prov.pais, prov.cp, prov.email, prov.telefono, prov.razon_social, prov.nombre_cont, prov.telefono_cont, prov.apellidoP_cont, prov.apellidoM_cont, prov.email_cont);
                        break;
                    case 12:
                        List<Proveedor> listarazon = proveedores.FindAll(x => x.razon_social.Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase)); ;
                        listarazon = listarazon.OrderBy(x => x.id).ToList();
                        foreach (Proveedor prov in listarazon) dgvPrincipal.Rows.Add(prov.id, prov.nombre, prov.rfc, prov.calle, prov.numero, prov.colonia, prov.ciudad, prov.municipio, prov.pais, prov.cp, prov.email, prov.telefono, prov.razon_social, prov.nombre_cont, prov.telefono_cont, prov.apellidoP_cont, prov.apellidoM_cont, prov.email_cont);
                        break;
                    case 13:
                        List<Proveedor> listanombrecont = proveedores.FindAll(x => x.nombre_cont.Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase)); ;
                        listanombrecont = listanombrecont.OrderBy(x => x.id).ToList();
                        foreach (Proveedor prov in listanombrecont) dgvPrincipal.Rows.Add(prov.id, prov.nombre, prov.rfc, prov.calle, prov.numero, prov.colonia, prov.ciudad, prov.municipio, prov.pais, prov.cp, prov.email, prov.telefono, prov.razon_social, prov.nombre_cont, prov.telefono_cont, prov.apellidoP_cont, prov.apellidoM_cont, prov.email_cont);
                        break;
                    case 14:
                        List<Proveedor> listatelefonocont = proveedores.FindAll(x => x.telefono_cont.Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase)); ;
                        listatelefonocont = listatelefonocont.OrderBy(x => x.id).ToList();
                        foreach (Proveedor prov in listatelefonocont) dgvPrincipal.Rows.Add(prov.id, prov.nombre, prov.rfc, prov.calle, prov.numero, prov.colonia, prov.ciudad, prov.municipio, prov.pais, prov.cp, prov.email, prov.telefono, prov.razon_social, prov.nombre_cont, prov.telefono_cont, prov.apellidoP_cont, prov.apellidoM_cont, prov.email_cont);
                        break;
                    case 15:
                        List<Proveedor> listapellidoPcont = proveedores.FindAll(x => x.apellidoP_cont.Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase)); ;
                        listapellidoPcont = listapellidoPcont.OrderBy(x => x.id).ToList();
                        foreach (Proveedor prov in listapellidoPcont) dgvPrincipal.Rows.Add(prov.id, prov.nombre, prov.rfc, prov.calle, prov.numero, prov.colonia, prov.ciudad, prov.municipio, prov.pais, prov.cp, prov.email, prov.telefono, prov.razon_social, prov.nombre_cont, prov.telefono_cont, prov.apellidoP_cont, prov.apellidoM_cont, prov.email_cont);
                        break;
                    case 16:
                        List<Proveedor> listapellidoMcont = proveedores.FindAll(x => x.apellidoM_cont.Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase)); ;
                        listapellidoMcont = listapellidoMcont.OrderBy(x => x.id).ToList();
                        foreach (Proveedor prov in listapellidoMcont) dgvPrincipal.Rows.Add(prov.id, prov.nombre, prov.rfc, prov.calle, prov.numero, prov.colonia, prov.ciudad, prov.municipio, prov.pais, prov.cp, prov.email, prov.telefono, prov.razon_social, prov.nombre_cont, prov.telefono_cont, prov.apellidoP_cont, prov.apellidoM_cont, prov.email_cont);
                        break;
                    case 17:
                        List<Proveedor> listemailcont = proveedores.FindAll(x => x.email_cont.Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase)); ;
                        listemailcont = listemailcont.OrderBy(x => x.id).ToList();
                        foreach (Proveedor prov in listemailcont) dgvPrincipal.Rows.Add(prov.id, prov.nombre, prov.rfc, prov.calle, prov.numero, prov.colonia, prov.ciudad, prov.municipio, prov.pais, prov.cp, prov.email, prov.telefono, prov.razon_social, prov.nombre_cont, prov.telefono_cont, prov.apellidoP_cont, prov.apellidoM_cont, prov.email_cont);
                        break;
                }
            }
            else
            {
                dgvPrincipal.Rows.Clear();
                foreach (Proveedor prov in proveedores) dgvPrincipal.Rows.Add(prov.id, prov.nombre, prov.rfc, prov.calle, prov.numero, prov.colonia, prov.ciudad, prov.municipio, prov.pais, prov.cp, prov.email, prov.telefono, prov.razon_social, prov.nombre_cont, prov.telefono_cont, prov.apellidoP_cont, prov.apellidoM_cont, prov.email_cont);
            }
        }

        private void dgvPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)//checa por la columna que tiene botones
            {
                Proveedor Usr = new Proveedor();
                if (e.ColumnIndex == dgvPrincipal.Columns.Count - 2) //checa si la columna es la de modificar
                {
                    if (onmod == false)
                    {
                        int id = Convert.ToInt32(dgvPrincipal.Rows[e.RowIndex].Cells[0].Value);
                        pHeader.Enabled = false;
                        dgvPrincipal.SelectionMode = DataGridViewSelectionMode.CellSelect;
                        dgvPrincipal[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Blue;
                        dgvPrincipal[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.White;
                        foreach (DataGridViewRow row in dgvPrincipal.Rows)
                            if (row.Index == e.RowIndex) { row.Cells[1].ReadOnly = false; row.Cells[2].ReadOnly = false; row.Cells[3].ReadOnly = false; row.Cells[4].ReadOnly = false; row.Cells[5].ReadOnly = false; row.Cells[6].ReadOnly = false; row.Cells[7].ReadOnly = false; row.Cells[8].ReadOnly = false; row.Cells[9].ReadOnly = false; row.Cells[10].ReadOnly = false; row.Cells[11].ReadOnly = false; row.Cells[12].ReadOnly = false; row.Cells[13].ReadOnly = false; row.Cells[14].ReadOnly = false; row.Cells[15].ReadOnly = false; row.Cells[16].ReadOnly = false; row.Cells[17].ReadOnly = false; } else { row.Visible = false; }
                        onmod = true;
                    }
                    else
                    {
                        pHeader.Enabled = true;
                        dgvPrincipal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvPrincipal[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Yellow;
                        dgvPrincipal[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Black;
                        foreach (DataGridViewRow row in dgvPrincipal.Rows)
                        {
                            if (row.Index == e.RowIndex)
                            {
                                row.Cells[1].ReadOnly = true; row.Cells[2].ReadOnly = true; row.Cells[3].ReadOnly = true; row.Cells[4].ReadOnly = true; row.Cells[5].ReadOnly = true; row.Cells[6].ReadOnly = true; row.Cells[7].ReadOnly = true; row.Cells[8].ReadOnly = true; row.Cells[9].ReadOnly = true; row.Cells[10].ReadOnly = true; row.Cells[11].ReadOnly = true; row.Cells[12].ReadOnly = true; row.Cells[13].ReadOnly = true; row.Cells[14].ReadOnly = true; row.Cells[15].ReadOnly = true; row.Cells[16].ReadOnly = true; row.Cells[17].ReadOnly = true;

                                if (row.Cells[0].Value != "") Usr.id = Convert.ToInt32(row.Cells[0].Value);
                                if (row.Cells[1].Value != "") Usr.nombre = row.Cells[1].Value.ToString();
                                if (row.Cells[2].Value != "") Usr.rfc = row.Cells[2].Value.ToString();
                                if (row.Cells[3].Value != "") Usr.calle= row.Cells[3].Value.ToString();
                                if (row.Cells[4].Value != "") Usr.numero = row.Cells[4].Value.ToString();
                                if (row.Cells[5].Value != "") Usr.colonia = row.Cells[5].Value.ToString();
                                if (row.Cells[6].Value != "") Usr.municipio = row.Cells[6].Value.ToString();
                                if (row.Cells[7].Value != "") Usr.ciudad = row.Cells[7].Value.ToString();
                                if (row.Cells[8].Value != "") Usr.pais = row.Cells[8].Value.ToString();
                                if (row.Cells[9].Value != "") Usr.cp = row.Cells[9].Value.ToString();
                                if (row.Cells[10].Value != "") Usr.email= row.Cells[10].Value.ToString();
                                if (row.Cells[11].Value != "") Usr.telefono = row.Cells[11].Value.ToString();
                                if (row.Cells[12].Value != "") Usr.razon_social = row.Cells[12].Value.ToString();
                                if (row.Cells[13].Value != "") Usr.nombre_cont = row.Cells[13].Value.ToString();
                                if (row.Cells[14].Value != "") Usr.telefono_cont = row.Cells[14].Value.ToString();
                                if (row.Cells[15].Value != "") Usr.apellidoP_cont = row.Cells[15].Value.ToString();
                                if (row.Cells[16].Value != "") Usr.apellidoM_cont = row.Cells[16].Value.ToString();
                                if (row.Cells[17].Value != "") Usr.email_cont = row.Cells[17].Value.ToString();

                            }
                            else { row.Visible = true; }
                        }
                        if ((MessageBox.Show("¿Desea Guardar Sus Cambios?", "Confirmacion",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                        {
                            proveedor.ModificarProveedor(Usr);
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
                if (e.ColumnIndex == dgvPrincipal.Columns.Count - 1) //checa si la columna es la de borrar
                {
                    int id = Convert.ToInt32(dgvPrincipal.Rows[e.RowIndex].Cells[0].Value);
                    if ((MessageBox.Show("¿Esta Seguro que quiere borrar este registro?,Los cambios efectuados no seran reversibles", "Confirmacion",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                        Proveedores.Eliminar(id, ref mensaje, ref proveedor);
                }
            }
        }
        private void dgvPrincipal_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(C_SolonumerosKeyPress);
            if (dgvPrincipal.CurrentCell.ColumnIndex == 9 || dgvPrincipal.CurrentCell.ColumnIndex == 11) //Columnas con solo numeros
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(C_SolonumerosKeyPress);
                }
            }
            if (dgvPrincipal.CurrentCell.ColumnIndex == 2 || dgvPrincipal.CurrentCell.ColumnIndex == 3  || dgvPrincipal.CurrentCell.ColumnIndex == 5|| dgvPrincipal.CurrentCell.ColumnIndex == 6||dgvPrincipal.CurrentCell.ColumnIndex==7||dgvPrincipal.CurrentCell.ColumnIndex==8||dgvPrincipal.CurrentCell.ColumnIndex==12|| dgvPrincipal.CurrentCell.ColumnIndex == 13|| dgvPrincipal.CurrentCell.ColumnIndex == 15|| dgvPrincipal.CurrentCell.ColumnIndex == 16) //Columnas con solo letras
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(C_SololetrasKeyPress);
                }
            }
            if (dgvPrincipal.CurrentCell.ColumnIndex == 1 || dgvPrincipal.CurrentCell.ColumnIndex == 2) //Columnas con letras y numeros
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
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarProveedor addP = new AgregarProveedor(proveedores);
            addP.ShowDialog();
        }
    }
}
