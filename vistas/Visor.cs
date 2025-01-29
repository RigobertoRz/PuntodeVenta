using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfiumViewer;

namespace ProyectoTienda.vistas
{
    public partial class Visor : Form
    {
        PdfiumViewer.PdfDocument pdfDocument;
        public Visor(PdfiumViewer.PdfDocument pdf)
        {
            pdfDocument= pdf;
            InitializeComponent();
        }

        private void Visor_Load(object sender, EventArgs e)
        {
            pdfViewer1.Document = pdfDocument;
        }
    }
}
