using System;
using ProyectoTienda.modelos;
using ProyectoTienda.vistas;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTienda.controladores
{
    public class Principal
    {
        Producto producto = new Producto();

        public static List<Producto> ConsultarProductos(List<Producto> productos,ref string mensaje ,ref Producto producto) {
            try
            {
                productos = producto.ObtenerProductos();
                return productos;
            }
            catch (Exception ex) {
                mensaje = "algo salio mal";
                return productos;
            }
        }
        public static bool Venta(List<dynamic> ordenordenada,Usuario user,Cliente cliente)
        {
            List<Venta> ventas = new List<Venta>();
            Venta venta = new Venta();
            ventas = venta.ObtenerVentas();
            Producto prod = new Producto();
            var costoTot = 0;
            var cantidadTot = 0;
            try
            {
                foreach (dynamic o in ordenordenada)
                {
                    prod.Id = o.Producto.Id;
                    prod.Nombre = o.Producto.Nombre;
                    prod.Precio = o.Producto.Precio;
                    prod.Stock = o.Producto.Stock - o.Contador;
                    Producto.ModificarProducto(prod);
                    costoTot += o.Contador * o.Producto.Precio;
                    cantidadTot += o.Contador; 
                }
                venta.idVenta = ventas.Count;
                venta.idUsuario = user.id;
                venta.idCliente = cliente.id;
                venta.costotot = costoTot;
                venta.cantidadtot = cantidadTot;
                venta.fecha = DateTime.Today;
                venta.insertar(venta);
                foreach(dynamic o in ordenordenada)
                {
                    var importe = Convert.ToDecimal(o.Producto.Precio) * Convert.ToDecimal(o.Contador);
                    prod.insertarconcepto(ventas.Count, o.Producto.Id, Convert.ToInt32(o.Contador), Convert.ToDecimal(o.Producto.Precio), importe);
                }

                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }

        //public static bool HayInventario()
    }
}
