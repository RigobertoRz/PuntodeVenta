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
using IronPdf;

namespace ProyectoTienda.vistas
{
   
    public partial class Factura : Form
    {
        PdfDocument ticket = null;
        List<dynamic> orden = new List<dynamic>();
        Usuario user = new Usuario();
        Proveedor prov = new Proveedor();
        List<Compra> compras = new List<Compra>();
        Compra compra = new Compra();
        String mensaje = "";
        public Factura(PdfDocument a, List<dynamic> ordenordenada, Usuario usr, Proveedor provedor)
        {
            ticket = a;
            orden = ordenordenada;
            user = usr;
            prov = provedor;
            InitializeComponent();
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ticket.SaveAs("../../../FacturasCompra/" + CrearNombre() + "_ticket.pdf");
            this.Close();
            Compras.Comp(orden, user, prov);
            MessageBox.Show("Compra Realizada con exito!", "Resultado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private string CrearNombre()
        {
            var nombre = "C" + compras.Count.ToString();
            nombre = nombre + "_" + DateTime.Today.ToString("ddd_dd_MMM_yyy");
            return nombre;
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            compras = consultas.ConsultarCompra(compras, ref mensaje, ref compra);
            pbFactura.Image = ticket.PageToBitmap(0);
        }
    }
}
