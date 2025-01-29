using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using ProyectoTienda.modelos;
using ProyectoTienda.controladores;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTienda.vistas
{
    public partial class FormCatalogoClientes : Form
    {
        Usuario usr = new Usuario();
        List<Cliente> clientes = new List<Cliente>();
        string mensaje = "";
        Cliente cliente = new Cliente();
        byte on = 0;
        bool onmod = false;
        public FormCatalogoClientes(Usuario user)
        {
            usr = user;
            InitializeComponent();
        }

        private void FormCatalogoClientes_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = usr.nombre;
            CargarDGV();
            timer1.Start();
            //Resolucionalta();
            Auth();
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
                case 5:
                    FormCompra compras = new FormCompra(usr);
                    Form.ActiveForm.Close();
                    compras.Show();
                    break;
                    /*case 6:
                        FormCatalogoClientes clientes = new FormCatalogoClientes(usr);
                        Form.ActiveForm.Close();
                        clientes.Show();
                        break;*/
            }
        }
        private void Auth()
        {
            if (usr.rol == false)
            {
                btnAgregar.Enabled = false;
                dgvPrincipal.Columns.Remove(dgvPrincipal.Columns[dgvPrincipal.Columns.Count - 1]);
                dgvPrincipal.Columns.Remove(dgvPrincipal.Columns[dgvPrincipal.Columns.Count - 1]);
            }
        }
        private void dgvPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)//checa por la columna que tiene botones
            {
                Cliente modificado = new Cliente();
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
                            if (row.Index == e.RowIndex) { for (int i = 1; i < 13; i++) row.Cells[i].ReadOnly = false; } else { row.Visible = false; }
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
                                for (int i = 1; i < 13; i++) row.Cells[i].ReadOnly = true;

                                if (row.Cells[0].Value.ToString() != "") modificado.id = Convert.ToInt32(row.Cells[0].Value);
                                if (row.Cells[1].Value.ToString() != "") modificado.nombre = row.Cells[1].Value.ToString();
                                if (row.Cells[2].Value.ToString() != "") modificado.apellidoP = row.Cells[2].Value.ToString();
                                if (row.Cells[3].Value.ToString() != "") modificado.apellidoM = row.Cells[3].Value.ToString();
                                if (row.Cells[4].Value.ToString() != "") modificado.rfc = row.Cells[4].Value.ToString();
                                if (row.Cells[5].Value.ToString() != "") modificado.calle = row.Cells[5].Value.ToString();
                                if (row.Cells[6].Value.ToString() != "") modificado.num_casa = row.Cells[6].Value.ToString();
                                if (row.Cells[7].Value.ToString() != "") modificado.cp = row.Cells[7].Value.ToString();
                                if (row.Cells[8].Value.ToString() != "") modificado.colonia = row.Cells[8].Value.ToString();
                                if (row.Cells[9].Value.ToString() != "") modificado.municipio = row.Cells[9].Value.ToString();
                                if (row.Cells[10].Value.ToString() != "") modificado.estado = row.Cells[10].Value.ToString();
                                if (row.Cells[11].Value.ToString() != "") modificado.pais = row.Cells[11].Value.ToString();
                                if (row.Cells[12].Value.ToString() != "") modificado.celular = row.Cells[12].Value.ToString();
                                if (row.Cells[13].Value.ToString() != "") modificado.email = row.Cells[13].Value.ToString();
                            }
                            else { row.Visible = true; }
                        }
                        if ((MessageBox.Show("¿Desea Guardar Sus Cambios?", "Confirmacion",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                        {
                            Clientes.Modificar(ref mensaje, modificado);
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
                        Clientes.Eliminar(id, ref mensaje, ref cliente);
                }

            }
        }
        private void dgvPrincipal_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(C_SolonumerosKeyPress);
            if (dgvPrincipal.CurrentCell.ColumnIndex == 6 || dgvPrincipal.CurrentCell.ColumnIndex == 7 || dgvPrincipal.CurrentCell.ColumnIndex == 12) //Columnas con solo numeros
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(C_SolonumerosKeyPress);
                }
            }
            if (dgvPrincipal.CurrentCell.ColumnIndex == 1 || dgvPrincipal.CurrentCell.ColumnIndex == 2 || dgvPrincipal.CurrentCell.ColumnIndex == 3 || dgvPrincipal.CurrentCell.ColumnIndex == 9 || dgvPrincipal.CurrentCell.ColumnIndex == 10 || dgvPrincipal.CurrentCell.ColumnIndex == 11) //Columnas con solo letras
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(C_SololetrasKeyPress);
                }
            }
            if (dgvPrincipal.CurrentCell.ColumnIndex == 4 || dgvPrincipal.CurrentCell.ColumnIndex == 5 || dgvPrincipal.CurrentCell.ColumnIndex == 8) //Columnas con letras y numeros
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

        private void CargarDGV()
        {
            dgvPrincipal.Rows.Clear();
            clientes = consultas.ConsultarClientes(clientes, ref mensaje, ref cliente);
            foreach (Cliente cli in clientes) dgvPrincipal.Rows.Add(cli.id, cli.nombre, cli.apellidoP, cli.apellidoM, cli.rfc, cli.calle, cli.num_casa, cli.cp, cli.colonia, cli.municipio, cli.estado, cli.pais, cli.celular, cli.email);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = String.Format("{0} de {1} de {2} {3} {4}", DateTime.Now.ToString("dddd d"), DateTime.Now.ToString("MMMM"), DateTime.Now.ToString("yyyy"), DateTime.Now.ToString("h:mm"), DateTime.UtcNow.ToString("tt", System.Globalization.CultureInfo.InvariantCulture));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarCliente addcliente = new AgregarCliente(clientes);
            addcliente.ShowDialog();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Length > 0)
            {
                dgvPrincipal.Rows.Clear();
                switch (cbBuscar.SelectedIndex)
                {
                    case 0:
                        List<Cliente> listaid = clientes.FindAll(x => x.id.ToString().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listaid = listaid.OrderBy(x => x.id).ToList();
                        foreach (Cliente cli in listaid) dgvPrincipal.Rows.Add(cli.id, cli.nombre, cli.apellidoP, cli.apellidoM, cli.rfc, cli.calle, cli.cp, cli.colonia, cli.municipio, cli.estado, cli.pais, cli.celular, cli.email);
                        break;
                    case 1:
                        List<Cliente> listaN = clientes.FindAll(x => x.nombre.Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listaN = listaN.OrderBy(x => x.id).ToList();
                        foreach (Cliente cli in listaN) dgvPrincipal.Rows.Add(cli.id, cli.nombre, cli.apellidoP, cli.apellidoM, cli.rfc, cli.calle, cli.cp, cli.colonia, cli.municipio, cli.estado, cli.pais, cli.celular, cli.email);
                        break;
                    case 2:
                        List<Cliente> listaP = clientes.FindAll(x => x.apellidoP.ToString().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listaP = listaP.OrderBy(x => x.id).ToList();
                        foreach (Cliente cli in listaP) dgvPrincipal.Rows.Add(cli.id, cli.nombre, cli.apellidoP, cli.apellidoM, cli.rfc, cli.calle, cli.cp, cli.colonia, cli.municipio, cli.estado, cli.pais, cli.celular, cli.email);
                        break;
                    case 3:
                        List<Cliente> listaM = clientes.FindAll(x => x.apellidoM.ToString().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listaM = listaM.OrderBy(x => x.id).ToList();
                        foreach (Cliente cli in listaM) dgvPrincipal.Rows.Add(cli.id, cli.nombre, cli.apellidoP, cli.apellidoM, cli.rfc, cli.calle, cli.cp, cli.colonia, cli.municipio, cli.estado, cli.pais, cli.celular, cli.email);
                        break;
                    case 4:
                        List<Cliente> listaR = clientes.FindAll(x => x.rfc.ToString().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listaR = listaR.OrderBy(x => x.id).ToList();
                        foreach (Cliente cli in listaR) dgvPrincipal.Rows.Add(cli.id, cli.nombre, cli.apellidoP, cli.apellidoM, cli.rfc, cli.calle, cli.cp, cli.colonia, cli.municipio, cli.estado, cli.pais, cli.celular, cli.email);
                        break;
                    case 5:
                        List<Cliente> listaNu = clientes.FindAll(x => x.num_casa.ToString().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listaNu = listaNu.OrderBy(x => x.id).ToList();
                        foreach (Cliente cli in listaNu) dgvPrincipal.Rows.Add(cli.id, cli.nombre, cli.apellidoP, cli.apellidoM, cli.rfc, cli.calle, cli.cp, cli.colonia, cli.municipio, cli.estado, cli.pais, cli.celular, cli.email);
                        break;
                    case 6:
                        List<Cliente> listacp = clientes.FindAll(x => x.cp.ToString().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listacp = listacp.OrderBy(x => x.id).ToList();
                        foreach (Cliente cli in listacp) dgvPrincipal.Rows.Add(cli.id, cli.nombre, cli.apellidoP, cli.apellidoM, cli.rfc, cli.calle, cli.cp, cli.colonia, cli.municipio, cli.estado, cli.pais, cli.celular, cli.email);
                        break;
                    case 7:
                        List<Cliente> listacol = clientes.FindAll(x => x.colonia.ToString().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listacol = listacol.OrderBy(x => x.id).ToList();
                        foreach (Cliente cli in listacol) dgvPrincipal.Rows.Add(cli.id, cli.nombre, cli.apellidoP, cli.apellidoM, cli.rfc, cli.calle, cli.cp, cli.colonia, cli.municipio, cli.estado, cli.pais, cli.celular, cli.email);
                        break;
                    case 8:
                        List<Cliente> listamun = clientes.FindAll(x => x.municipio.ToString().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listamun = listamun.OrderBy(x => x.id).ToList();
                        foreach (Cliente cli in listamun) dgvPrincipal.Rows.Add(cli.id, cli.nombre, cli.apellidoP, cli.apellidoM, cli.rfc, cli.calle, cli.cp, cli.colonia, cli.municipio, cli.estado, cli.pais, cli.celular, cli.email);
                        break;
                    case 9:
                        List<Cliente> listaest = clientes.FindAll(x => x.estado.ToString().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listaest = listaest.OrderBy(x => x.id).ToList();
                        foreach (Cliente cli in listaest) dgvPrincipal.Rows.Add(cli.id, cli.nombre, cli.apellidoP, cli.apellidoM, cli.rfc, cli.calle, cli.cp, cli.colonia, cli.municipio, cli.estado, cli.pais, cli.celular, cli.email);
                        break;
                    case 10:
                        List<Cliente> listapais = clientes.FindAll(x => x.pais.ToString().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listapais = listapais.OrderBy(x => x.id).ToList();
                        foreach (Cliente cli in listapais) dgvPrincipal.Rows.Add(cli.id, cli.nombre, cli.apellidoP, cli.apellidoM, cli.rfc, cli.calle, cli.cp, cli.colonia, cli.municipio, cli.estado, cli.pais, cli.celular, cli.email);
                        break;
                    case 11:
                        List<Cliente> listacel= clientes.FindAll(x => x.celular.ToString().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listacel = listacel.OrderBy(x => x.id).ToList();
                        foreach (Cliente cli in listacel) dgvPrincipal.Rows.Add(cli.id, cli.nombre, cli.apellidoP, cli.apellidoM, cli.rfc, cli.calle, cli.cp, cli.colonia, cli.municipio, cli.estado, cli.pais, cli.celular, cli.email);
                        break;
                    case 12:
                        List<Cliente> listaema = clientes.FindAll(x => x.email.ToString().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase));
                        listaema = listaema.OrderBy(x => x.id).ToList();
                        foreach (Cliente cli in listaema) dgvPrincipal.Rows.Add(cli.id, cli.nombre, cli.apellidoP, cli.apellidoM, cli.rfc, cli.calle, cli.cp, cli.colonia, cli.municipio, cli.estado, cli.pais, cli.celular, cli.email);
                        break;

                }
            }
        }
    }
}
