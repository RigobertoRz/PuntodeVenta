using System;
using System.Collections.Generic;
using ProyectoTienda.modelos;
using ProyectoTienda.vistas;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTienda.controladores
{
    public class Clientes
    {
        public static bool Eliminar(int id, ref string mensaje, ref Cliente cliente)
        {
            try
            {
                return cliente.Borrar(id);

            }
            catch (Exception ex)
            {
                mensaje = "algo salio mal";
                return false;
            }
        }
        public static bool Insertar(ref string mensaje, Cliente cliente)
        {
            try
            {
                mensaje = "¡Cliente Agregado con Exito!";
                return cliente.insertar(cliente);
            }
            catch (Exception ex)
            {
                mensaje = "algo salio mal";
                return false;
            }
        }
        public static bool Modificar(ref string mensaje, Cliente cliente)
        {
            try
            {
                mensaje = "¡Producto Modificado con Exito!";
                return cliente.Modificar(cliente);
            }
            catch (Exception ex)
            {
                mensaje = "algo salio mal";
                return false;
            }
        }
    }
}
