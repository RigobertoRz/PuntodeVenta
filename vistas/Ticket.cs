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
using IronPdf;

namespace ProyectoTienda.vistas
{
    public partial class Ticket : Form
    {
        PdfDocument ticket = null;
        List<dynamic> orden = new List<dynamic>();
        Usuario usr = new Usuario();
        Cliente cli = new Cliente();
        List<Venta> ventas = new List<Venta>();
        Venta venta = new Venta();
        String mensaje = "";
        public Ticket(PdfDocument a, List<dynamic> ordenordenada, Usuario user, Cliente cliente)
        {
            ticket = a;
            orden = ordenordenada;
            usr = user;
            cli = cliente;
            InitializeComponent();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            ventas = consultas.ConsultarVentas(ventas, ref mensaje, ref venta);
            pbTicket.Image = ticket.PageToBitmap(0);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ticket.SaveAs("../../../Tickets/"+CrearNombre()+"_ticket.pdf");
            this.Close();
            Principal.Venta(orden, usr, cli);
            MessageBox.Show("Compra Realizada con exito!", "Resultado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private string CrearNombre()
        {
            var nombre = "V" + ventas.Count.ToString();
            nombre = nombre + "_"+DateTime.Today.ToString("ddd_dd_MMM_yyy");
            return nombre;
        }
    }
}
