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
using System.Net.Mail;

namespace ProyectoTienda.vistas
{
    public partial class FormRecuperarCon : Form
    {
        public FormRecuperarCon()
        {
            InitializeComponent();
        }


        private void btnRecuperarContra_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string mail = txtCorreo.Text ;
            string mensaje = "";
            Usuario usuario = null;
            if(Login.validarCorreo(mail,ref mensaje,ref usuario))
            {
                lblMensaje.Text = mensaje;
                
            }
            else
            {
                lblMensaje.Text = mensaje;
            }
            this.Cursor = Cursors.Default;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            this.Close();
            fl.Show();
            
        }
    }
}
