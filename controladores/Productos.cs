using System;
using ProyectoTienda.modelos;
using ProyectoTienda.vistas;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTienda.controladores
{
    public class Productos
    {
        public static bool Eliminar(int id,ref string mensaje ,ref Producto producto)
        {
            try
            {
                return producto.Borrar(id);
                
            }
            catch (Exception ex)
            {
                mensaje = "algo salio mal";
                return false;
            }
        }
        public static bool Insertar(ref string mensaje, Producto producto)
        {
            try
            {
                mensaje = "¡Producto Agregado con Exito!";
                return producto.Insertar(producto);
            }
            catch (Exception ex)
            {
                mensaje = "algo salio mal";
                return false;
            }
        }
        public static bool Modificar(ref string mensaje, Producto producto)
        {
            try
            {
                mensaje = "¡Producto Modificado con Exito!";
                return Producto.ModificarProducto(producto);
            }
            catch (Exception ex)
            {
                mensaje = "algo salio mal";
                return false;
            }
        }
    }
}
