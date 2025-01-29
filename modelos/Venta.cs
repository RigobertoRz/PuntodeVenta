using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTienda.modelos
{
    public class Venta
    {
        public int idVenta { get; set; }
        public int idUsuario { get; set; }
        public int idCliente { get; set; }
        public float costotot { get; set; }
        public float cantidadtot { get; set; }
        public DateTime fecha { get; set; }

        public Venta() { }

        public List<Venta> ObtenerVentas()
        {
            List<Venta> ventas = new List<Venta>();
            OdbcConnection coneccion = DatabaseConnection.GetConnection();
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand("SELECT ID_VENTA,ID_USUARIO,ID_CLIENTE,COSTO_TOT,CANTIDAD_TOT,FECHA FROM VENTA", coneccion);
            consulta.Prepare();
            OdbcDataReader resultado = consulta.ExecuteReader();
            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    Venta a = new Venta();
                    a.idVenta = resultado.GetInt32(0);
                    a.idUsuario = resultado.GetInt32(1);
                    a.idCliente = resultado.GetInt32(2);
                    a.costotot = resultado.GetFloat(3);
                    a.cantidadtot = resultado.GetFloat(4);
                    a.fecha = resultado.GetDate(5);
                    ventas.Add(a);
                }
            }
            else
            {
                //MessageBox(""); ERROR
                throw new Exception("no se encontraron compras");
            }
            return ventas;
        }
        public bool insertar(Venta venta)
        {
            OdbcConnection coneccion = DatabaseConnection.GetConnection();
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand("INSERT INTO VENTA(ID_VENTA,ID_USUARIO,ID_CLIENTE,COSTO_TOT,CANTIDAD_TOT,FECHA) VALUES(?,?,?,?,?,?)", coneccion);
            consulta.Parameters.Add("ID_VENTA", OdbcType.Int).Value = venta.idVenta;
            consulta.Parameters.Add("ID_USUARIO", OdbcType.Int).Value = venta.idUsuario;
            consulta.Parameters.Add("ID_CLIENTE", OdbcType.VarChar).Value = venta.idCliente;
            consulta.Parameters.Add("COSTO_TOT", OdbcType.Decimal).Value = venta.costotot;
            consulta.Parameters.Add("CANTIDAD_TOT", OdbcType.Int).Value = venta.cantidadtot;
            consulta.Parameters.Add("FECHA", OdbcType.DateTime).Value = venta.fecha;
            consulta.Prepare();
            consulta.ExecuteNonQuery();
            return true;
        }

        public  List<Venta> VentasKK( ref string mes)
        {
            string ll= "SELECT * FROM VENTA WHERE MONTH(VENTA.FECHA) = "+mes+";";
            List<Venta> ventas = new List<Venta>();
            OdbcConnection coneccion = DatabaseConnection.GetConnection();
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand(ll, coneccion);
            consulta.Prepare();
            OdbcDataReader resultado = consulta.ExecuteReader();
            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    Venta a = new Venta();
                    a.idVenta = resultado.GetInt32(0);
                    a.idUsuario = resultado.GetInt32(1);
                    a.idCliente = resultado.GetInt32(2);
                    a.costotot = resultado.GetFloat(3);
                    a.cantidadtot = resultado.GetFloat(4);
                    a.fecha = resultado.GetDate(5);
                    ventas.Add(a);
                }
            }
            else
            {
                //MessageBox(""); ERROR
                throw new Exception("no se encontraron coincidencias");
            }
            return ventas;
        }

        public List<Venta> VentasAÑO(ref string año)
        {
            string ll = "SELECT * FROM VENTA WHERE YEAR(VENTA.FECHA) = " + año + ";";
            List<Venta> ventas = new List<Venta>();
            OdbcConnection coneccion = DatabaseConnection.GetConnection();
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand(ll, coneccion);
            consulta.Prepare();
            OdbcDataReader resultado = consulta.ExecuteReader();
            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    Venta a = new Venta();
                    a.idVenta = resultado.GetInt32(0);
                    a.idUsuario = resultado.GetInt32(1);
                    a.idCliente = resultado.GetInt32(2);
                    a.costotot = resultado.GetFloat(3);
                    a.cantidadtot = resultado.GetFloat(4);
                    a.fecha = resultado.GetDate(5);
                    ventas.Add(a);
                }
            }
            else
            {
                //MessageBox(""); ERROR
                throw new Exception("no se encontraron coincidencias");
            }
            return ventas;
        }

        public List<Venta> VentasFECHA(ref string fecha)
        {
            string v2 = DateTime.Now.ToString(String.Format("yyyy-MM-dd"));
            string ll = "SELECT * FROM VENTA WHERE VENTA.FECHA = '" + fecha+ "';";
            List<Venta> ventas = new List<Venta>();
            OdbcConnection coneccion = DatabaseConnection.GetConnection();
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand(ll, coneccion);
            consulta.Prepare();
            OdbcDataReader resultado = consulta.ExecuteReader();
            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    Venta a = new Venta();
                    a.idVenta = resultado.GetInt32(0);
                    a.idUsuario = resultado.GetInt32(1);
                    a.idCliente = resultado.GetInt32(2);
                    a.costotot = resultado.GetFloat(3);
                    a.cantidadtot = resultado.GetFloat(4);
                    a.fecha = resultado.GetDate(5);
                    ventas.Add(a);
                }
            }
            else
            {
                //MessageBox(""); ERROR
                throw new Exception("no se encontraron coincidencias");
            }
            return ventas;
        }
    }
}
