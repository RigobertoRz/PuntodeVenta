using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace ProyectoTienda.modelos
{
    public class Producto
    {
        public int Id { get; set; }
        public int IdCategoria { get; set; }    
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }

        public Producto(){}

        public List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new List<Producto>();
            OdbcConnection coneccion = DatabaseConnection.GetConnection();
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand("SELECT ID_PRODUCTO,ID_CATEGORIA,NOMBRE,PRECIO,STOCK FROM PRODUCTO", coneccion);
            consulta.Parameters.Add("NOMBRE", OdbcType.VarChar).Value = Nombre;
            consulta.Parameters.Add("PRECIO", OdbcType.Double).Value = Precio;
            consulta.Prepare();
            OdbcDataReader resultado = consulta.ExecuteReader();
            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    Producto a = new Producto();
                    a.Id = resultado.GetInt32(0);
                    a.IdCategoria = resultado.GetInt32(1);
                    a.Nombre = resultado.GetString(2);
                    a.Precio = resultado.GetDouble(3);
                    a.Stock = resultado.GetInt32(4);
                    productos.Add(a);
                }
            }
            else
            {
                //MessageBox(""); ERROR
                throw new Exception("no se encontraron productos");
            }
            return productos;
        }
        public bool Insertar(Producto producto)
        {
            OdbcConnection coneccion = DatabaseConnection.GetConnection();
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand("INSERT INTO PRODUCTO(ID_PRODUCTO,ID_CATEGORIA,NOMBRE,PRECIO,STOCK) VALUES(?,?,?,?,?)", coneccion);
            consulta.Parameters.Add("ID_PRODUCTO", OdbcType.Int).Value = producto.Id;
            consulta.Parameters.Add("ID_CATEGORIA", OdbcType.Int).Value = producto.IdCategoria;
            consulta.Parameters.Add("NOMBRE",OdbcType.VarChar).Value = producto.Nombre;
            consulta.Parameters.Add("PRECIO", OdbcType.Decimal).Value = producto.Precio;
            consulta.Parameters.Add("STOCK", OdbcType.Int).Value = producto.Stock;
            consulta.Prepare();
            consulta.ExecuteNonQuery();
            return true;
        }
        public static bool ModificarProducto(Producto producto)
        {
            OdbcConnection coneccion = DatabaseConnection.GetConnection();
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand("UPDATE PRODUCTO SET ID_CATEGORIA=?,NOMBRE=?,PRECIO=?,STOCK=? WHERE ID_PRODUCTO=?", coneccion);
            consulta.Parameters.Add("ID_CATEGORIA", OdbcType.Int).Value = producto.IdCategoria;
            consulta.Parameters.Add("NOMBRE", OdbcType.VarChar).Value = producto.Nombre;
            consulta.Parameters.Add("PRECIO", OdbcType.Decimal).Value = producto.Precio;
            consulta.Parameters.Add("STOCK", OdbcType.Int).Value = producto.Stock;
            consulta.Parameters.Add("ID_PRODUCTO", OdbcType.Int).Value = producto.Id;
            consulta.Prepare();
            consulta.ExecuteNonQuery();
            return true;
        }
        public bool Borrar(int id)
        {
            OdbcConnection coneccion = DatabaseConnection.GetConnection();
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand("DELETE FROM PRODUCTO WHERE ID_PRODUCTO=?",coneccion);
            consulta.Parameters.Add("ID_PRODUCTO", OdbcType.Int).Value = id;
            consulta.Prepare();
            consulta.ExecuteNonQuery();
            return true;
        }
        public bool insertarconcepto(int venta,int idproducto,int cantidad,decimal Precio,decimal Importe)
        {
            OdbcConnection coneccion = DatabaseConnection.GetConnection();
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand("INSERT INTO CONCEPT_VENTA(ID_VENTA,ID_PRODUCTO,CANTIDAD,PRECIO,IMPORTE) VALUES(?,?,?,?,?)", coneccion);
            consulta.Parameters.Add("ID_VENTA", OdbcType.Int).Value = venta;
            consulta.Parameters.Add("ID_PRODUCTO", OdbcType.Int).Value = idproducto;
            consulta.Parameters.Add("CANTIDAD", OdbcType.Int).Value = cantidad;
            consulta.Parameters.Add("PRECIO", OdbcType.Decimal).Value = Precio;
            consulta.Parameters.Add("IMPORTE", OdbcType.Decimal).Value = Importe;
            consulta.Prepare();
            consulta.ExecuteNonQuery();
            return true;
        }
        public static bool updateSTOCk(Producto producto)
        {
            OdbcConnection coneccion = DatabaseConnection.GetConnection();
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand("UPDATE PRODUCTO SET STOCK=? WHERE ID_PRODUCTO=?", coneccion);
            consulta.Parameters.Add("STOCK", OdbcType.Int).Value = producto.Stock;
            consulta.Parameters.Add("ID_PRODUCTO", OdbcType.Int).Value = producto.Id;
            consulta.Prepare();
            consulta.ExecuteNonQuery();
            return true;
        }
    }
}
