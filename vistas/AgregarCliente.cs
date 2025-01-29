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

namespace ProyectoTienda.vistas
{
    public partial class AgregarCliente : Form
    {
        Cliente cliente = new Cliente();
        List<Cliente> lista = new List<Cliente>();
        string mensaje = "";
        public AgregarCliente(List<Cliente> clientes)
        {
            lista = clientes;
            InitializeComponent();
        }
        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
        private bool ComprobarLlenadoDeCampos()
        {
            string faltallenar = "Los siguientes campos están incompletos: ";
            bool error = false;
            int nombre = txtNombre.Text.Length;
            int apellidoP = txtApellidoP.Text.Length;
            int apellidoM = txtApellidoM.Text.Length;
            int RFC = txtRFC.Text.Length;
            int Celular = txtCelular.Text.Length;
            int Email = txtEmail.Text.Length;
            int calle = txtCalle.Text.Length;
            int cp = txtCP.Text.Length;
            int ciudad = txtnumcasa.Text.Length;
            int municipio = txtMunicipio.Text.Length;
            int pais = txtPais.Text.Length;
            int estado = txtEstado.Text.Length;


            if (nombre == 0)
            {
                faltallenar += "\n Nombre";
                error = true;
            }
            if (apellidoP == 0)
            {
                faltallenar += "\n apellido Paterno";
                error = true;
            }
            if (apellidoM == 0)
            {
                faltallenar += "\n apellido Materno";
                error = true;
            }
            if (RFC == 0)
            {
                faltallenar += "\n RFC";
                error = true;
            }
            if (Celular == 0)
            {
                faltallenar += "\n Celular";
                error = true;
            }
            if(Email == 0)
            {
                faltallenar += "\n Email";
                error = true;
            }
            if (calle == 0)
            {
                faltallenar += "\n Calle";
                error = true;
            }
            if (cp == 0)
            {
                faltallenar += "\n Codigo Postal";
                error = true;
            }
            if(ciudad == 0)
            {
                faltallenar += "\n ciudad";
                error = true;
            }
            if(municipio == 0)
            {
                faltallenar += "\n Municipio";
                error = true;
            }
            if (pais == 0)
            {
                faltallenar += "\n Pais";
                error = true;
            }
            if(estado == 0)
            {
                faltallenar += "\n Estado";
                error = true;
            }
            if (error)
            {
                MessageBox.Show(faltallenar, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void txtSoloLetras_TextChanged(object sender, EventArgs e)
        {
            TextBox a = (TextBox)sender;
            a.Text = string.Concat(a.Text.Where(char.IsLetter));
            a.SelectionStart = a.Text.Length + 1;
        }
        private void txtSoloLetrasyNumeros_TextChanged(object sender, EventArgs e)
        {
            TextBox a = (TextBox)sender;
            a.Text = string.Concat(a.Text.Where(char.IsLetterOrDigit));
            a.SelectionStart = a.Text.Length + 1;
        }
        private void txtSoloNumeros_TextChanged(object sender, EventArgs e)
        {
            TextBox a = (TextBox)sender;
            a.Text = string.Concat(a.Text.Where(char.IsDigit));
            a.SelectionStart = a.Text.Length + 1;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ComprobarLlenadoDeCampos())
            {
                cliente.id = lista.Count;
                cliente.nombre = txtNombre.Text;
                cliente.apellidoM=txtApellidoM.Text;
                cliente.apellidoP = txtApellidoP.Text;
                cliente.rfc = txtRFC.Text;
                cliente.celular = txtCelular.Text;
                cliente.email = txtEmail.Text;
                cliente.calle = txtCalle.Text;
                cliente.cp = txtCP.Text;
                cliente.num_casa = txtnumcasa.Text;
                cliente.municipio = txtMunicipio.Text;
                cliente.pais = txtPais.Text;
                cliente.estado = txtEstado.Text;

                if (IsValidEmail(txtEmail.Text))
                {
                    cliente.email = txtEmail.Text;
                    if ((MessageBox.Show("¿Esta Seguro que los datos proporcionados son correctos?", "Confirmacion",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                    {
                        Clientes.Insertar(ref mensaje,cliente);
                        MessageBox.Show(mensaje, "Resultado",
                                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }
                }
                else
                {
                    MessageBox.Show("El campo email de la empresa no corresponde a un correo con el formato adecuado", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
