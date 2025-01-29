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
    public partial class UserInfo : Form
    {
        Usuario usuario = new Usuario();
        String mensaje = "";
        public UserInfo(Usuario user)
        {
            usuario = user;
            InitializeComponent();
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            lblNombre.Text = usuario.nombre + " "+usuario.apellidoP+" " + usuario.apellidoM;
            lblLogin.Text = usuario.login;
            lblCel.Text = usuario.celular;
            lblCalle.Text = usuario.calle;
            lblCiudad.Text = usuario.ciudad;
            lblColonia.Text = usuario.colonia;
            lblMunicipio.Text = usuario.municipio;
            lblPais.Text = usuario.pais;
            lblRFC.Text = usuario.rfc;
            lblEmail.Text = usuario.email;
            if (usuario.rol == false) lblRol.Text = "Usuario";
            else lblRol.Text = "Administrador";
        }

        private void btnCambiarContra_Click(object sender, EventArgs e)
        {
            lblNombre.Visible=false;
            lblLogin.Visible=false;
            lblCel.Visible=false;
            lblCalle.Visible=false;
            lblCiudad.Visible=false;
            lblColonia.Visible=false;
            lblMunicipio.Visible=false;
            lblPais.Visible=false;
            lblEmail.Visible=false;
            if (txtPassword.Text == txtPassword2.Text)
            {
                usuario.password = txtPassword.Text;
                if (Usuario.CambiarContra(usuario.id, Usuarios.getMd5Hash("90segfjasdmflsj" + txtPassword.Text + usuario.login)))
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
}
