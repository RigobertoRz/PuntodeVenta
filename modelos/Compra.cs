using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTienda.modelos
{
    public class Compra
    {
        public int idCompra { get; set; }
        public int idUsuario { get; set; }
        public int idProveedor { get; set; }
        public float compratot { get; set; }
        public int numfact  { get; set; }
        public float cantidadtot { get; set; }
        public DateTime fecha { get; set; }
        
        public Compra(){ }
        public List<Compra> ObtenerCompras()
        {
            List<Compra> compras= new List<Compra>();
            OdbcConnection coneccion = DatabaseConnection.GetConnection();
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand("SELECT ID_COMPRA,ID_USUARIO,ID_PROVEEDOR,COMPRA_TOT,NUMFACT,CANTIDAD_TOT,FECHA FROM COMPRA", coneccion);
            consulta.Prepare();
            OdbcDataReader resultado = consulta.ExecuteReader();
            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    Compra a = new Compra();
                    a.idCompra = resultado.GetInt32(0);
                    a.idUsuario = resultado.GetInt32(1);
                    a.idProveedor = resultado.GetInt32(2);
                    a.compratot = resultado.GetFloat(3);
                    a.numfact = resultado.GetInt32(4);
                    a.cantidadtot = resultado.GetFloat(5);
                    a.fecha = resultado.GetDate(6);
                    compras.Add(a);
                }
            }
            else
            {
                //MessageBox(""); ERROR
                throw new Exception("no se encontraron compras");
            }
            return compras;
        }
        public List<Compra> ComprasFECHA(ref string fecha)
        {
            //string v2 = DateTime.Now.ToString(String.Format("yyyy-MM-dd"));
            string ll = "SELECT * FROM COMPRA WHERE COMPRA.FECHA = '" + fecha + "';";
            List<Compra> compras  = new List<Compra>();
            OdbcConnection coneccion = DatabaseConnection.GetConnection();
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand(ll, coneccion);
            consulta.Prepare();
            OdbcDataReader resultado = consulta.ExecuteReader();
            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    Compra a = new Compra();
                    a.idCompra = resultado.GetInt32(0);
                    a.idUsuario = resultado.GetInt32(1);
                    a.idProveedor = resultado.GetInt32(2);
                    a.compratot = resultado.GetFloat(3);
                    a.numfact = resultado.GetInt32(4);
                    a.cantidadtot = resultado.GetFloat(5);
                    a.fecha = resultado.GetDate(6);
                    compras.Add(a);
                }
            }
            else
            {
                //MessageBox(""); ERROR
                throw new Exception("no se encontraron coincidencias");
            }
            return compras;
        }
        public List<Compra> ComprasANIO (ref string anio)
        {
            //string v2 = DateTime.Now.ToString(String.Format("yyyy-MM-dd"));
            string ll = "SELECT * FROM COMPRA WHERE YEAR(COMPRA.FECHA) = " + anio + ";";
            List<Compra> compras = new List<Compra>();
            OdbcConnection coneccion = DatabaseConnection.GetConnection();
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand(ll, coneccion);
            consulta.Prepare();
            OdbcDataReader resultado = consulta.ExecuteReader();
            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    Compra a = new Compra();
                    a.idCompra = resultado.GetInt32(0);
                    a.idUsuario = resultado.GetInt32(1);
                    a.idProveedor = resultado.GetInt32(2);
                    a.compratot = resultado.GetFloat(3);
                    a.numfact = resultado.GetInt32(4);
                    a.cantidadtot = resultado.GetFloat(5);
                    a.fecha = resultado.GetDate(6);
                    compras.Add(a);
                }
            }
            else
            {
                //MessageBox(""); ERROR
                throw new Exception("no se encontraron coincidencias");
            }
            return compras;
        }
        public List<Compra> ComprasMES(ref string mes)
        {
            //string v2 = DateTime.Now.ToString(String.Format("yyyy-MM-dd"));
            string ll = "SELECT * FROM COMPRA WHERE MONTH(COMPRA.FECHA) = " + mes + ";";
            List<Compra> compras = new List<Compra>();
            OdbcConnection coneccion = DatabaseConnection.GetConnection();
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand(ll, coneccion);
            consulta.Prepare();
            OdbcDataReader resultado = consulta.ExecuteReader();
            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    Compra a = new Compra();
                    a.idCompra = resultado.GetInt32(0);
                    a.idUsuario = resultado.GetInt32(1);
                    a.idProveedor = resultado.GetInt32(2);
                    a.compratot = resultado.GetFloat(3);
                    a.numfact = resultado.GetInt32(4);
                    a.cantidadtot = resultado.GetFloat(5);
                    a.fecha = resultado.GetDate(6);
                    compras.Add(a);
                }
            }
            else
            {
                //MessageBox(""); ERROR
                throw new Exception("no se encontraron coincidencias");
            }
            return compras;
        }
        public bool insertar(Compra comp)
        {
            OdbcConnection coneccion = DatabaseConnection.GetConnection();
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand("INSERT INTO COMPRA(ID_COMPRA,ID_USUARIO,ID_PROVEEDOR,COMPRA_TOT,NUMFACT,CANTIDAD_TOT,FECHA) VALUES(?,?,?,?,?,?,?)", coneccion);
            consulta.Parameters.Add("ID_COMPRA", OdbcType.Int).Value = comp.idCompra;
            consulta.Parameters.Add("ID_USUARIO", OdbcType.Int).Value = comp.idUsuario;
            consulta.Parameters.Add("ID_PROVEEDOR", OdbcType.VarChar).Value = comp.idProveedor;
            consulta.Parameters.Add("COMPRA_TOT", OdbcType.Decimal).Value = comp.compratot;
            consulta.Parameters.Add("NUMFACT", OdbcType.Int).Value = comp.numfact;
            consulta.Parameters.Add("CANTIDAD_TOT", OdbcType.Int).Value = comp.cantidadtot;
            consulta.Parameters.Add("FECHA", OdbcType.DateTime).Value = comp.fecha;
            consulta.Prepare();
            consulta.ExecuteNonQuery();
            return true;
        }
        public bool insertarconcepto(int compra, int idproducto, int cantidad, decimal Precio, decimal Importe)
        {
            OdbcConnection coneccion = DatabaseConnection.GetConnection();
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand("INSERT INTO CONCEPT_COMPRA(ID_COMPRA,ID_PRODUCTO,CANTIDAD,PRECIO,IMPORTE) VALUES(?,?,?,?,?)", coneccion);
            consulta.Parameters.Add("ID_COMPRA", OdbcType.Int).Value = compra;
            consulta.Parameters.Add("ID_PRODUCTO", OdbcType.Int).Value = idproducto;
            consulta.Parameters.Add("CANTIDAD", OdbcType.Int).Value = cantidad;
            consulta.Parameters.Add("PRECIO", OdbcType.Decimal).Value = Precio;
            consulta.Parameters.Add("IMPORTE", OdbcType.Decimal).Value = Importe;
            consulta.Prepare();
            consulta.ExecuteNonQuery();
            return true;
        }
    }
    
}
