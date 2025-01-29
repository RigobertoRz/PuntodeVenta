using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProyectoTienda.modelos;
using ProyectoTienda.vistas;
using System.Threading.Tasks;

namespace ProyectoTienda.controladores
{
    public class Compras
    {
       public static List<ProvProducto> ConsultarProvProductos(List<ProvProducto> provProductos, ref string mensaje, ref ProvProducto prov)
        {
            try
            {
                mensaje = "se realizo con exito";
                provProductos = prov.ObtenerProvProductos();
                return provProductos;
            }
            catch (Exception ex)
            {
                mensaje = "Ocurrio un problema";
                return provProductos;
            }
            
        }
        public static bool Comp(List<dynamic> ordenordenada, Usuario user, Proveedor prov)
        {
            List<Compra> compras = new List<Compra>();
            Compra compra = new Compra();
            compras = compra.ObtenerCompras();
            Producto prod = new Producto();
            var costoTot = 0;
            var cantidadTot = 0;
            try
            {
                foreach (dynamic o in ordenordenada)
                {
                    prod.Stock = o.Producto.Stock + o.Contador;
                    Producto.updateSTOCk(prod);
                    costoTot += o.Contador * o.Producto.Precio;
                    cantidadTot += o.Contador;
                }
                compra.idCompra= compras.Count;
                compra.idProveedor = prov.id;
                compra.idUsuario = user.id;
                compra.compratot= costoTot;
                compra.cantidadtot= cantidadTot;
                compra.fecha = DateTime.Today;
                compra.numfact = compras.Count;
                compra.insertar(compra);
                foreach (dynamic o in ordenordenada)
                {
                    var importe = Convert.ToDecimal(o.Producto.Precio) * Convert.ToDecimal(o.Contador);
                    compra.insertarconcepto(compras.Count, o.Producto.Id, Convert.ToInt32(o.Contador), Convert.ToDecimal(o.Producto.Precio), importe);
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
