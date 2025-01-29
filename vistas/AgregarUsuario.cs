using System;
using System.Collections.Generic;
using ProyectoTienda.controladores;
using ProyectoTienda.modelos;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTienda.vistas
{
    public partial class AgregarUsuario : Form
    {
        List<Usuario> users;
        string mensaje = "";
        public AgregarUsuario(List<Usuario> usuarios)
        {
            users = usuarios;
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ComprobarLlenadoDeCampos())
            {
                Usuario usuario = new Usuario();
                usuario.id = users.Count;
                usuario.rol = false;
                usuario.nombre = txtNombre.Text;
                usuario.apellidoP = txtApellidoP.Text;
                usuario.apellidoM = txtApellidoM.Text;
                usuario.rfc = txtRFC.Text;
                usuario.calle = txtCalle.Text;
                usuario.cp = "23142";
                usuario.colonia = txtColonia.Text;
                usuario.ciudad = txtCiudad.Text;
                usuario.municipio = txtMunicipio.Text;
                usuario.pais = txtPais.Text;
                usuario.celular = txtCelular.Text;
                if (IsValidEmail(txtEmail.Text) && txtEmail.TextLength > 0)
                {
                    usuario.email = txtEmail.Text;
                }
                else
                {
                    MessageBox.Show("Proporcione un formato de email adecuado", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                usuario.login = txtLogin.Text;
                if (txtpasssword.Text == txtPassword2.Text)
                {
                    usuario.password = txtpasssword.Text;
                    if (Usuarios.Insertar(ref mensaje, usuario))
                    {
                        MessageBox.Show(mensaje, "Resultado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show("Las contraseñas no Coinciden", "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool ComprobarLlenadoDeCampos()
        {
            string faltallenar = "Los siguientes campos están incompletos: ";
            bool error = false;
            int nombre = txtNombre.Text.Length;
            int apellidoP= txtApellidoP.Text.Length;
            int apellidoM= txtApellidoM.Text.Length;
            int rfc = txtRFC.Text.Length;
            int calle = txtCalle.Text.Length;
            int colonia = txtColonia.Text.Length;
            int ciudad = txtCiudad.Text.Length;
            int municipio = txtMunicipio.Text.Length;
            int pais = txtPais.Text.Length;
            int celular = txtCelular.Text.Length;
            int email = txtEmail.Text.Length;
            int login = txtLogin.Text.Length;
            int password = txtpasssword.Text.Length;
            int password2 = txtPassword2.Text.Length;

            if (nombre == 0)
            {
                faltallenar += "\n Nombre";
                error = true;
            }
            if (apellidoP == 0)
            {
                faltallenar += "\n Apellido Paterno";
                error = true;
            }
            if (apellidoM == 0)
            {
                faltallenar += "\n Apellido Materno";
                error = true;
            }
            if (rfc == 0)
            {
                faltallenar += "\n RFC";
                error = true;
            }
            if (calle == 0)
            {
                faltallenar += "\n Calle";
                error = true;
            }
            if (colonia == 0)
            {
                faltallenar += "\n Colonia";
                error = true;
            }
            if (ciudad == 0)
            {
                faltallenar += "\n Ciudad";
                error = true;
            }
            if (municipio==0)
            {
                faltallenar += "\n Municipio";
                error = true;
            }
            if (pais == 0)
            {
                faltallenar += "\n Pais";
                error = true;
            }
            if (celular == 0)
            {
                faltallenar += "\n Celular";
                error = true;
            }
            if (email==0)
            {
                faltallenar += "\n Email";
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
    }
}
