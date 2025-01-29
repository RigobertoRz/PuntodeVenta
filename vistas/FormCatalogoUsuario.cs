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


namespace ProyectoTienda.vistas
{
    public partial class FormCatalogoUsuario : Form
    {
        Usuario user = new Usuario();
        List<Usuario> usuarios = new List<Usuario>();
        string mensaje = "";
        bool onmod = false;
        public FormCatalogoUsuario(Usuario usuario)
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
                case 4: //Boton Reportes
                    FormReportes reportes = new FormReportes(user);
                    Form.ActiveForm.Close();
                    reportes.Show();
                    break;
                case 5: //Boton Compras
                    FormCompra compras = new FormCompra(user);
                    Form.ActiveForm.Close();
                    compras.Show();
                    break;
                case 6: //Boton clientes
                    FormCatalogoClientes clientes = new FormCatalogoClientes(user);
                    Form.ActiveForm.Close();
                    clientes.Show();
                    break;
            }
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
                cbBuscar.SetBounds(1050, 103, 250, 47);
                cbBuscar.Font = new Font("Century Gothic", 24);
                cbBuscar.SelectedIndex = 0;
                txtBuscar.Font = new Font("Century Gothic", 24);
                //dgv
                dgvPrincipal.SetBounds(237, 180, 1655, 849);
                btnAgregar.SetBounds(1353, 103, 280, 47);
                btnAgregar.Font = new Font("Segoe UI Semibold", 18);
            }
        }

        private void FormCatalogoUsuario_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = user.nombre;
            CargarDGV();
            timer1.Start();
            Resolucionalta();
            Auth();
        }
        private void CargarDGV()
        {
            dgvPrincipal.Rows.Clear();
            usuarios = Usuarios.ConsultarUsuarios(usuarios, ref mensaje, ref user);
            foreach (Usuario us in usuarios) dgvPrincipal.Rows.Add(us.id,us.nombre,us.apellidoP,us.apellidoM,us.rfc,us.calle,us.colonia,us.ciudad,us.municipio,us.pais,us.celular,us.cp,us.email,us.login);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = String.Format("{0} de {1} de {2} {3} {4}", DateTime.Now.ToString("dddd d"), DateTime.Now.ToString("MMMM"), DateTime.Now.ToString("yyyy"), DateTime.Now.ToString("h:mm"), DateTime.UtcNow.ToString("tt", System.Globalization.CultureInfo.InvariantCulture));
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        { //Agregar combobox
            if (txtBuscar.Text.Length > 0)
            {
                dgvPrincipal.Rows.Clear();
                switch(cbBuscar.SelectedIndex)
                {
                    case 0:
                        List<Usuario> listaid = usuarios.FindAll(x => x.id.ToString().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listaid = listaid.OrderBy(x => x.id).ToList();
                        foreach (Usuario us in listaid) dgvPrincipal.Rows.Add(us.id, us.nombre, us.apellidoP, us.apellidoM, us.rfc, us.calle, us.colonia, us.ciudad, us.municipio, us.pais, us.celular, us.cp, us.email);
                        break;
                    case 1:
                        List<Usuario> listan = usuarios.FindAll(x => x.nombre.Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listan = listan.OrderBy(x => x.id).ToList();
                        foreach (Usuario us in listan) dgvPrincipal.Rows.Add(us.id, us.nombre, us.apellidoP, us.apellidoM, us.rfc, us.calle, us.colonia, us.ciudad, us.municipio, us.pais, us.celular, us.cp, us.email);
                        break;
                    case 2:
                        List<Usuario> listaP = usuarios.FindAll(x => x.apellidoP.Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listaP = listaP.OrderBy(x => x.id).ToList();
                        foreach (Usuario us in listaP) dgvPrincipal.Rows.Add(us.id, us.nombre, us.apellidoP, us.apellidoM, us.rfc, us.calle, us.colonia, us.ciudad, us.municipio, us.pais, us.celular, us.cp, us.email);
                        break;
                    case 3:
                        List<Usuario> listaM = usuarios.FindAll(x => x.apellidoM.Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listaM = listaM.OrderBy(x => x.id).ToList();
                        foreach (Usuario us in listaM) dgvPrincipal.Rows.Add(us.id, us.nombre, us.apellidoP, us.apellidoM, us.rfc, us.calle, us.colonia, us.ciudad, us.municipio, us.pais, us.celular, us.cp, us.email);
                        break;
                    case 4:
                        List<Usuario> listarfc = usuarios.FindAll(x => x.rfc.ToString().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listarfc = listarfc.OrderBy(x => x.id).ToList();
                        foreach (Usuario us in listarfc) dgvPrincipal.Rows.Add(us.id, us.nombre, us.apellidoP, us.apellidoM, us.rfc, us.calle, us.colonia, us.ciudad, us.municipio, us.pais, us.celular, us.cp, us.email);
                        break;
                    case 5:
                        List<Usuario> listacalle = usuarios.FindAll(x => x.calle.ToString().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listacalle = listacalle.OrderBy(x => x.id).ToList();
                        foreach (Usuario us in listacalle) dgvPrincipal.Rows.Add(us.id, us.nombre, us.apellidoP, us.apellidoM, us.rfc, us.calle, us.colonia, us.ciudad, us.municipio, us.pais, us.celular, us.cp, us.email);
                        break;
                    case 6:
                        List<Usuario> listacolonia = usuarios.FindAll(x => x.colonia.ToString().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listacolonia = listacolonia.OrderBy(x => x.id).ToList();
                        foreach (Usuario us in listacolonia) dgvPrincipal.Rows.Add(us.id, us.nombre, us.apellidoP, us.apellidoM, us.rfc, us.calle, us.colonia, us.ciudad, us.municipio, us.pais, us.celular, us.cp, us.email);
                        break;
                    case 7:
                        List<Usuario> listaciudad = usuarios.FindAll(x => x.ciudad.ToString().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listaciudad= listaciudad.OrderBy(x => x.id).ToList();
                        foreach (Usuario us in listaciudad) dgvPrincipal.Rows.Add(us.id, us.nombre, us.apellidoP, us.apellidoM, us.rfc, us.calle, us.colonia, us.ciudad, us.municipio, us.pais, us.celular, us.cp, us.email);
                        break;
                    case 8:
                        List<Usuario> listamunicipio = usuarios.FindAll(x => x.municipio.ToString().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listamunicipio = listamunicipio.OrderBy(x => x.id).ToList();
                        foreach (Usuario us in listamunicipio) dgvPrincipal.Rows.Add(us.id, us.nombre, us.apellidoP, us.apellidoM, us.rfc, us.calle, us.colonia, us.ciudad, us.municipio, us.pais, us.celular, us.cp, us.email);
                        break;
                    case 9:
                        List<Usuario> listapais = usuarios.FindAll(x => x.pais.ToString().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listapais = listapais.OrderBy(x => x.id).ToList();
                        foreach (Usuario us in listapais) dgvPrincipal.Rows.Add(us.id, us.nombre, us.apellidoP, us.apellidoM, us.rfc, us.calle, us.colonia, us.ciudad, us.municipio, us.pais, us.celular, us.cp, us.email);
                        break;
                    case 10:
                        List<Usuario> listacelular = usuarios.FindAll(x => x.celular.ToString().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listacelular = listacelular.OrderBy(x => x.id).ToList();
                        foreach (Usuario us in listacelular) dgvPrincipal.Rows.Add(us.id, us.nombre, us.apellidoP, us.apellidoM, us.rfc, us.calle, us.colonia, us.ciudad, us.municipio, us.pais, us.celular, us.cp, us.email);
                        break;
                    case 11:
                        List<Usuario> listacp = usuarios.FindAll(x => x.cp.ToString().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listacp = listacp.OrderBy(x => x.id).ToList();
                        foreach (Usuario us in listacp) dgvPrincipal.Rows.Add(us.id, us.nombre, us.apellidoP, us.apellidoM, us.rfc, us.calle, us.colonia, us.ciudad, us.municipio, us.pais, us.celular, us.cp, us.email);
                        break;
                    case 12:
                        List<Usuario> listaemail = usuarios.FindAll(x => x.email.ToString().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listaemail = listaemail.OrderBy(x => x.id).ToList();
                        foreach (Usuario us in listaemail) dgvPrincipal.Rows.Add(us.id, us.nombre, us.apellidoP, us.apellidoM, us.rfc, us.calle, us.colonia, us.ciudad, us.municipio, us.pais, us.celular, us.cp, us.email);
                        break;
                }
                List<Usuario> lista = usuarios.FindAll(x => x.nombre.Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                lista = lista.OrderBy(x => x.id).ToList();
                foreach (Usuario us in lista) dgvPrincipal.Rows.Add(us.id, us.nombre, us.apellidoP, us.apellidoM, us.rfc, us.calle, us.colonia, us.ciudad, us.municipio, us.pais, us.celular, us.cp, us.email);
            }
            else
            {
                dgvPrincipal.Rows.Clear();
                foreach (Usuario us in usuarios) dgvPrincipal.Rows.Add(us.id, us.nombre, us.apellidoP, us.apellidoM, us.rfc, us.calle, us.colonia, us.ciudad, us.municipio, us.pais, us.celular, us.cp, us.email);
            }
        }

        private void dgvPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)//checa por la columna que tiene botones
            {
                Usuario Usr = new Usuario();
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
                            if (row.Index == e.RowIndex) { row.Cells[1].ReadOnly = false; row.Cells[2].ReadOnly = false; row.Cells[3].ReadOnly = false; row.Cells[4].ReadOnly = false; row.Cells[5].ReadOnly = false; row.Cells[6].ReadOnly = false; row.Cells[7].ReadOnly = false; row.Cells[8].ReadOnly = false; row.Cells[9].ReadOnly = false; row.Cells[10].ReadOnly = false; row.Cells[11].ReadOnly = false; row.Cells[12].ReadOnly = false; row.Cells[13].ReadOnly = false; ; } else { row.Visible = false; }
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
                                row.Cells[1].ReadOnly = true; row.Cells[2].ReadOnly = true; row.Cells[3].ReadOnly = true; row.Cells[4].ReadOnly = true; row.Cells[5].ReadOnly = true; row.Cells[6].ReadOnly = true; row.Cells[7].ReadOnly = true; row.Cells[8].ReadOnly = true; row.Cells[9].ReadOnly = true; row.Cells[10].ReadOnly = true; row.Cells[11].ReadOnly = true; row.Cells[12].ReadOnly = true; row.Cells[13].ReadOnly = true;

                                if (row.Cells[0].Value != "") Usr.id = Convert.ToInt32(row.Cells[0].Value);
                                if (row.Cells[1].Value != "") Usr.nombre = row.Cells[1].Value.ToString();
                                if (row.Cells[2].Value != "") Usr.apellidoP = row.Cells[2].Value.ToString();
                                if (row.Cells[3].Value != "") Usr.apellidoM = row.Cells[3].Value.ToString();
                                if (row.Cells[4].Value != "") Usr.rfc = row.Cells[4].Value.ToString();
                                if (row.Cells[5].Value != "") Usr.calle = row.Cells[5].Value.ToString();
                                if (row.Cells[6].Value != "") Usr.colonia = row.Cells[6].Value.ToString();
                                if (row.Cells[7].Value != "") Usr.ciudad = row.Cells[7].Value.ToString();
                                if (row.Cells[8].Value != "") Usr.municipio = row.Cells[8].Value.ToString();
                                if (row.Cells[9].Value != "") Usr.pais = row.Cells[9].Value.ToString();
                                if(row.Cells[10].Value != "") Usr.celular = row.Cells[10].Value.ToString();
                                if (row.Cells[11].Value != "") Usr.cp = row.Cells[11].Value.ToString();
                                if (row.Cells[12].Value != "") Usr.email = row.Cells[12].Value.ToString();
                                if (row.Cells[13].Value != "") Usr.login = row.Cells[13].Value.ToString();
                            }
                            else { row.Visible = true; }
                        }
                        if ((MessageBox.Show("¿Desea Guardar Sus Cambios?", "Confirmacion",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                        {
                            Usuarios.Modificar(Usr);
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
                        Usuarios.Eliminar(id, ref mensaje, ref user);
                }
            }
        }
        private void dgvPrincipal_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(C_SolonumerosKeyPress);
            if (dgvPrincipal.CurrentCell.ColumnIndex == 10|| dgvPrincipal.CurrentCell.ColumnIndex == 11) //Columnas con solo numeros
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(C_SolonumerosKeyPress);
                }
            }
            if (dgvPrincipal.CurrentCell.ColumnIndex == 1 || dgvPrincipal.CurrentCell.ColumnIndex == 2 || dgvPrincipal.CurrentCell.ColumnIndex == 3 || dgvPrincipal.CurrentCell.ColumnIndex == 6 || dgvPrincipal.CurrentCell.ColumnIndex == 7 || dgvPrincipal.CurrentCell.ColumnIndex == 8 || dgvPrincipal.CurrentCell.ColumnIndex == 9) //Columnas con solo letras
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(C_SololetrasKeyPress);
                }
            }
            if (dgvPrincipal.CurrentCell.ColumnIndex == 4 || dgvPrincipal.CurrentCell.ColumnIndex == 5||dgvPrincipal.CurrentCell.ColumnIndex==13) //Columnas con letras y numeros
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
            AgregarUsuario addusuario = new AgregarUsuario(usuarios);
            addusuario.ShowDialog();
        }
    }
}
