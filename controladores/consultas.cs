using System;
using ProyectoTienda.modelos;
using ProyectoTienda.vistas;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTienda.controladores
{
    public class consultas
    {
        public static List<Cliente> ConsultarClientes(List<Cliente> clientes, ref string mensaje, ref Cliente cliente)
        {
            try
            {
                clientes = cliente.ObtenerClientes();
                return clientes;
            }
            catch (Exception )
            {
                mensaje = "algo salio mal";
                return clientes;
            }
        }
        public static List<Venta> ConsultarVentas(List<Venta> ventas, ref string mensaje, ref Venta venta)
        {
            try
            {
                ventas= venta.ObtenerVentas();
                return ventas;
            }
            catch (Exception )
            {
                mensaje = "algo salio mal";
                return ventas;
            }
        }
        public static List<Compra> ConsultarCompra(List<Compra> compras, ref string mensaje, ref Compra compra)
        {
            try
            {
                compras= compra.ObtenerCompras();
                return compras;
            }
            catch (Exception ex)
            {
                mensaje = "algo salio mal";
                return compras;
            }
        }

        public static List<Venta> ConsultarVentasXMES(List<Venta> ventas, ref string mensaje, ref Venta venta,ref string mes)
        {
            try
            {
                ventas = venta.VentasKK(ref mes);
                return ventas;
            }
            catch (Exception)
            {
                mensaje = "algo salio mal";
                return ventas;
            }
        }

        public static List<Venta> ConsultarVentasXAÑO(List<Venta> ventas, ref string mensaje, ref Venta venta, ref string año)
        {
            try
            {
                ventas = venta.VentasAÑO(ref año);
                return ventas;
            }
            catch (Exception)
            {
                mensaje = "algo salio mal";
                return ventas;
            }
        }

        public static List<Venta> ConsultarVentasXFECHA(List<Venta> ventas, ref string mensaje, ref Venta venta, ref string fecha)
        {
            try
            {
                ventas = venta.VentasFECHA(ref fecha);
                return ventas;
            }
            catch (Exception)
            {
                mensaje = "algo salio mal";
                return ventas;
            }
        }
        public static List<Compra> ConsultarCompraXFECHA(List<Compra> compras, ref string mensaje, ref Compra compra, ref string fecha)
        {
            try
            {
                compras = compra.ComprasFECHA(ref fecha);
                return compras;
            }
            catch (Exception )
            {
                mensaje = "algo salio mal";
                return compras;
            }
        }
        public static List<Compra> ConsultarCompraXANIO(List<Compra> compras, ref string mensaje, ref Compra compra, ref string anio)
        {
            try
            {
                compras = compra.ComprasANIO(ref anio);
                return compras;
            }
            catch (Exception)
            {
                mensaje = "algo salio mal";
                return compras;
            }
        }
        public static List<Compra> ConsultarCompraXMES(List<Compra> compras, ref string mensaje, ref Compra compra, ref string mes)
        {
            try
            {
                compras = compra.ComprasMES(ref mes);
                return compras;
            }
            catch (Exception)
            {
                mensaje = "algo salio mal";
                return compras;
            }
        }

    }

   
}
