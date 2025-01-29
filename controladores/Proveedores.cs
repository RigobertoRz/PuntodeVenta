using System;
using ProyectoTienda.modelos;
using ProyectoTienda.vistas;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTienda.controladores
{
    public class Proveedores
    {
        Proveedor proveedor = new Proveedor();
        public static List<Proveedor> ConsultarProveedores(List<Proveedor> proveedores, ref string mensaje, ref Proveedor proveedor)
        {
            try
            {
                proveedores = proveedor.ObtenerProveedores();
                return proveedores;
            }
            catch (Exception ex)
            {
                mensaje = "algo salio mal";
                return proveedores;
            }
        }
        public static List<ProvProducto> ConsultarProvProducto(List<ProvProducto> productoProv, ref string mensaje, ref ProvProducto prov)
        {
            try
            {
                productoProv = prov.ObtenerProvProductos();
                return productoProv;
            }
            catch (Exception ex)
            {
                mensaje = "algo salio mal";
                return productoProv;
            }
        }
        public static bool Insertar(ref string mensaje, Proveedor proveedor)
        {
            try
            {
                mensaje = "registro exitoso";
                return proveedor.insertarProveedor(proveedor);
            }
            catch (Exception ex)
            {
                mensaje = "algo salio mal";
                return false;
            }
        }

        public static bool Eliminar(int id, ref string mensaje, ref Proveedor proveedor)
        {
            try
            {
                return proveedor.Borrar(id);

            }
            catch (Exception ex)
            {
                mensaje = "algo salio mal";
                return false;
            }
        }
    }
}
