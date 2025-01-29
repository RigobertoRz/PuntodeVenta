using ProyectoTienda.controladores;
using ProyectoTienda.modelos;
using System;
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
    public partial class FormLogin : Form
    {
        bool a = true;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string contraseña = txtContraseña.Text;
            string mensaje = "";
            Usuario usuario = null;
            if (Login.validarUsuario(nombre, contraseña, ref mensaje,ref usuario))
            {
                FormPrincipal vistaPrincipal = new FormPrincipal(usuario);
                this.Hide();
                vistaPrincipal.Show();
               // this.Close();
            }
            else
            {
                lblMensaje.Text = mensaje;
            }
        }

        private void lblOlvidarContraseña_Click(object sender, EventArgs e)
        {
            FormRecuperarCon formRecuperarCon = new FormRecuperarCon();
            this.Hide();
            formRecuperarCon.ShowDialog();
            //this.Close();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            
            if (a)
            {
                a = false;
                btnHide.BackgroundImage = Properties.Resources.eye;
                txtContraseña.PasswordChar = char.MinValue;
                txtContraseña.Focus();
            }
            else
            {
                a = true;
                btnHide.BackgroundImage = Properties.Resources.hidden;
                txtContraseña.PasswordChar = '*';
                txtContraseña.Focus();
            }
        }
    }
}
