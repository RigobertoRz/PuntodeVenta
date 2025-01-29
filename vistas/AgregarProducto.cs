using System;
using ProyectoTienda.controladores;
using ProyectoTienda.modelos;
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
    public partial class AgregarProducto : Form
    {
        Producto producto = new Producto();
        List<Producto> lista = new List<Producto>();
        string mensaje = "";
        public AgregarProducto(List<Producto> productos)
        {
            lista = productos;
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ComprobarLlenadoDeCampos())
            {
                producto.Id = lista.Count;
                producto.Nombre = txtNombre.Text; //añadir verificaciones
                if (cbCategoria.SelectedIndex < 6 && cbCategoria.SelectedIndex > -1 && cbCategoria.Text != "Categoria") producto.IdCategoria = cbCategoria.SelectedIndex;
                producto.Precio = Convert.ToInt32(txtPrecio.Text);
                producto.Stock = Convert.ToInt32(txtStock.Text);
                gbVistaPrevia.Visible = true;
                lblPNombre.Text = txtNombre.Text;
                lblPCategoria.Text = cbCategoria.Text;
                lblPPrecio.Text = "$" + txtPrecio.Text;
                lblPStock.Text = txtStock.Text;
                if ((MessageBox.Show("¿Esta Seguro que los datos proporcionados son correctos?", "Confirmacion",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                {
                    Productos.Insertar(ref mensaje, producto);
                    MessageBox.Show(mensaje, "Resultado",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else gbVistaPrevia.Visible = false;
            }
        }
        private bool ComprobarLlenadoDeCampos()
        {
            string faltallenar = "Los siguientes campos están incompletos: ";
            bool error = false;
            int nombre = txtNombre.Text.Length;
            int precio = txtPrecio.Text.Length;
            int stock = txtStock.Text.Length;

            if (nombre == 0)
            {
                faltallenar += "\n Nombre";
                error = true;
            }
            if (precio == 0)
            {
                faltallenar += "\n Precio";
                error = true;
            }
            if (stock == 0)
            {
                faltallenar += "\n Stock";
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

        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            cbCategoria.SelectedIndex = 0;
        }
    }
}
