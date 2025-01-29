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
    public partial class AgregarProveedor : Form
    {
        List<Proveedor> proveedor = new List<Proveedor>();
        Proveedor prov = new Proveedor();
        string mensaje = "";
        public AgregarProveedor(List<Proveedor> proveedores)
        {
            proveedor = proveedores;
            InitializeComponent();
        }

        private void AgregarProveedor_Load(object sender, EventArgs e)
        {

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
                prov.id = proveedor.Count;
                prov.nombre = txtNombre.Text;
                prov.rfc = txtRFC.Text;
                prov.calle = txtCalle.Text;
                prov.numero = txtNumero.Text;
                prov.colonia = txtColoinia.Text;
                prov.municipio = txtMunicipio.Text;
                prov.ciudad = txtCiudad.Text;
                prov.pais = txtPais.Text;
                prov.cp = "21324";
                if (IsValidEmail(txtEmail.Text))
                {
                    prov.email = txtEmail.Text;
                }
                else
                {
                    MessageBox.Show("El campo email de la empresa no corresponde a un correo con el formato adecuado", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                prov.telefono = txtTelefono.Text;
                prov.razon_social = txtRazonSocial.Text;
                prov.nombre_cont = txtNombreCont.Text;
                prov.telefono_cont = txtTelContac.Text;
                prov.apellidoP_cont = txtApellidoP.Text;
                prov.apellidoM_cont = txtApellidoM.Text;
                if (IsValidEmail(txtEmailContac.Text))
                {
                    prov.email_cont = txtEmailContac.Text;
                    if ((MessageBox.Show("¿Esta Seguro que los datos proporcionados son correctos?", "Confirmacion",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                    {
                        prov.insertarProveedor(prov);
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
            int rfc = txtRFC.Text.Length;
            int calle = txtCalle.Text.Length;
            int numero = txtNumero.Text.Length;
            int colonia = txtColoinia.Text.Length;
            int municipio = txtMunicipio.Text.Length;
            int ciudad = txtCiudad.Text.Length;
            int pais = txtPais.Text.Length;
            int email = txtEmail.Text.Length;
            int telefono = txtTelefono.Text.Length;
            int razonsocial = txtRazonSocial.Text.Length;
            int nombrecont = txtNombreCont.Text.Length;
            int telefonocont = txtTelContac.Text.Length;
            int apellidoP = txtApellidoP.Text.Length;
            int apellidoM = txtApellidoM.Text.Length;
            int emailcont = txtEmailContac.Text.Length;
            if (nombre == 0)
            {
                faltallenar += "\n Nombre";
                error = true;
            }
            if (rfc == 0)
            {
                faltallenar += "\n RFC";
                error = true;
            }
            if (calle == 0)
            {
                faltallenar += "\n calle";
                error = true;
            }
            if (numero == 0)
            {
                faltallenar += "\n numero";
                error = true;
            }
            if (colonia == 0)
            {
                faltallenar += "\n colonia";
                error = true;
            }
            if (municipio == 0)
            {
                faltallenar += "\n municipio";
                error = true;
            }
            if (ciudad == 0)
            {
                faltallenar += "\n ciudad";
                error = true;
            }
            if (pais == 0)
            {
                faltallenar += "\n pais";
                error = true;
            }
            if (email == 0)
            {
                faltallenar += "\n email";
                error = true;
            }
            if (telefono == 0)
            {
                faltallenar += "\n telefono";
                error = true;
            }
            if (razonsocial == 0)
            {
                faltallenar += "\n razon social:";
                error = true;
            }
            if (nombrecont == 0)
            {
                faltallenar += "\n nombrecont";
                error = true;
            }
            if (telefonocont == 0)
            {
                faltallenar += "\n telefono contacto";
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
            if (emailcont == 0)
            {
                faltallenar += "\n email contacto";
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
    }
}
