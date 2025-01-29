using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTienda.modelos
{
   public class ProvProducto
    {
        public int id { get; set; }
        public int id_prov { get; set; }
        public int id_prod { get; set; }
        public decimal precio { get; set; }

        public ProvProducto() { }

        public List<ProvProducto> ObtenerProvProductos()
        {
            List<ProvProducto> productos = new List<ProvProducto>();
            OdbcConnection coneccion = DatabaseConnection.GetConnection();
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand("SELECT ID,ID_PROVEEDOR,ID_PRODUCTO,PRECIO FROM PROV_PROD", coneccion);
            consulta.Prepare();
            OdbcDataReader resultado = consulta.ExecuteReader();
            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    ProvProducto a = new ProvProducto();
                    a.id = resultado.GetInt32(0);
                    a.id_prov= resultado.GetInt32(1);
                    a.id_prod = resultado.GetInt32(2);
                    a.precio = resultado.GetDecimal(3);
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
    }
}
