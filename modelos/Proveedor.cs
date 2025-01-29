using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace ProyectoTienda.modelos
{
    public class Proveedor
    {
        //Informacion de la empresa 
        public int id { get; set; }
        public string nombre { get; set; }
        public string rfc { get; set; }
        public string calle { get; set; }
        public string numero { get; set; }
        public string colonia { get; set; }
        public string ciudad { get; set; }
        public string municipio { get; set; }
        public string pais { get; set; }
        public string cp { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string razon_social { get; set; }
        //informacion del contacto de la empresa
        public string nombre_cont { get; set; }
        public string telefono_cont { get; set; }
        public string apellidoP_cont { get; set; }
        public string apellidoM_cont { get; set; }
        public string email_cont { get; set; }
        
        public Proveedor() { }

        public List<Proveedor> ObtenerProveedores()
        {
            List<Proveedor> proveedores = new List<Proveedor>();
            OdbcConnection coneccion = DatabaseConnection.GetConnection();
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand("SELECT ID_PROVEEDOR,NOMBRE_EMP,RFC,CALLE,NUMERO,COLONIA,MUNICIPIO,CIUDAD,PAIS,CP,EMAIL_EMP,TELEFONO_EMP,RAZON_SOCIAL,NOMBRE_CONT,TELEFONO_CONT,APELLIDO_P,APELLIDO_M,EMAIL_CONT FROM PROVEEDOR", coneccion);
            consulta.Prepare();
            OdbcDataReader resultado = consulta.ExecuteReader();
            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    Proveedor a = new Proveedor();
                    a.id = resultado.GetInt32(0);
                    a.nombre = resultado.GetString(1);
                    a.rfc = resultado.GetString(2);
                    a.calle = resultado.GetString(3);
                    a.numero = resultado.GetString(4);
                    a.colonia = resultado.GetString(5);
                    a.ciudad = resultado.GetString(6);
                    a.municipio = resultado.GetString(7);
                    a.pais = resultado.GetString(8);
                    a.cp = resultado.GetString(9);
                    a.email = resultado.GetString(10);
                    a.telefono = resultado.GetString(11);
                    a.razon_social = resultado.GetString(12);
                    a.nombre_cont = resultado.GetString(13);
                    a.telefono_cont = resultado.GetString(14);
                    a.apellidoP_cont = resultado.GetString(15);
                    a.apellidoM_cont = resultado.GetString(16);
                    a.email_cont = resultado.GetString(17);
                    proveedores.Add(a);
                }
            }
            else
            {
                //MessageBox(""); ERROR
                throw new Exception("no se encontraron proveedores");
            }
            return proveedores;
        }
        public bool insertarProveedor(Proveedor Prov)
        {
            OdbcConnection coneccion = DatabaseConnection.GetConnection();
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand("INSERT INTO PROVEEDOR(ID_PROVEEDOR,NOMBRE_EMP,RFC,CALLE,NUMERO,COLONIA,MUNICIPIO,CIUDAD,PAIS,CP,EMAIL_EMP,TELEFONO_EMP,RAZON_SOCIAL,NOMBRE_CONT,TELEFONO_CONT,APELLIDO_P,APELLIDO_M,EMAIL_CONT) VALUES(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)", coneccion);
            consulta.Parameters.Add("ID_PROVEEDOR", OdbcType.Int).Value = Prov.id;
            consulta.Parameters.Add("NOMBRE_EMP", OdbcType.Bit).Value = Prov.nombre;
            consulta.Parameters.Add("RFC", OdbcType.VarChar).Value = Prov.rfc;
            consulta.Parameters.Add("CALLE", OdbcType.VarChar).Value = Prov.calle;
            consulta.Parameters.Add("NUMERO", OdbcType.VarChar).Value = Prov.numero;
            consulta.Parameters.Add("COLONIA", OdbcType.VarChar).Value = Prov.colonia;
            consulta.Parameters.Add("MUNICIPIO", OdbcType.VarChar).Value = Prov.municipio;
            consulta.Parameters.Add("CIUDAD", OdbcType.VarChar).Value = Prov.ciudad;
            consulta.Parameters.Add("PAIS", OdbcType.VarChar).Value = Prov.pais;
            consulta.Parameters.Add("CP", OdbcType.VarChar).Value = Prov.cp;
            consulta.Parameters.Add("EMAIL_EMP", OdbcType.VarChar).Value = Prov.email;
            consulta.Parameters.Add("TELEFONO_EMP", OdbcType.VarChar).Value = Prov.telefono;
            consulta.Parameters.Add("RAZON_SOCIAL", OdbcType.VarChar).Value = Prov.razon_social;
            consulta.Parameters.Add("NOMBRE_CONT", OdbcType.VarChar).Value = Prov.nombre_cont;
            consulta.Parameters.Add("TELEFONO_CONT", OdbcType.VarChar).Value = Prov.telefono_cont;
            consulta.Parameters.Add("APELLIDO_P", OdbcType.VarChar).Value = Prov.apellidoP_cont;
            consulta.Parameters.Add("APELLIDO_M", OdbcType.VarChar).Value = Prov.apellidoM_cont;
            consulta.Parameters.Add("EMAIL_CONT", OdbcType.VarChar).Value = Prov.email_cont;
            consulta.Prepare();
            consulta.ExecuteNonQuery();
            return true;
        }
        public bool ModificarProveedor(Proveedor Prov)
        {
            OdbcConnection coneccion = DatabaseConnection.GetConnection();
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand("UPDATE PROVEEDOR SET ID_PROVEEDOR=?,NOMBRE_EMP=?,RFC=?,CALLE=?,NUMERO=?,COLONIA=?,MUNICIPIO=?,CIUDAD=?,PAIS=?,CP=?,EMAIL_EMP=?,TELEFONO_EMP=?,RAZON_SOCIAL=?,NOMBRE_CONT=?,TELEFONO_CONT=?,APELLIDO_P=?,APELLIDO_M=?,EMAIL_CONT=?", coneccion);
            consulta.Parameters.Add("ID_PROVEEDOR", OdbcType.Int).Value = Prov.id;
            consulta.Parameters.Add("NOMBRE_EMP", OdbcType.Bit).Value = Prov.nombre;
            consulta.Parameters.Add("RFC", OdbcType.VarChar).Value = Prov.rfc;
            consulta.Parameters.Add("CALLE", OdbcType.VarChar).Value = Prov.calle;
            consulta.Parameters.Add("NUMERO", OdbcType.VarChar).Value = Prov.numero;
            consulta.Parameters.Add("COLONIA", OdbcType.VarChar).Value = Prov.colonia;
            consulta.Parameters.Add("MUNICIPIO", OdbcType.VarChar).Value = Prov.municipio;
            consulta.Parameters.Add("CIUDAD", OdbcType.VarChar).Value = Prov.ciudad;
            consulta.Parameters.Add("PAIS", OdbcType.VarChar).Value = Prov.pais;
            consulta.Parameters.Add("CP", OdbcType.VarChar).Value = Prov.cp;
            consulta.Parameters.Add("EMAIL_EMP", OdbcType.VarChar).Value = Prov.email;
            consulta.Parameters.Add("TELEFONO_EMP", OdbcType.VarChar).Value = Prov.telefono;
            consulta.Parameters.Add("RAZON_SOCIAL", OdbcType.VarChar).Value = Prov.razon_social;
            consulta.Parameters.Add("NOMBRE_CONT", OdbcType.VarChar).Value = Prov.nombre_cont;
            consulta.Parameters.Add("TELEFONO_CONT", OdbcType.VarChar).Value = Prov.telefono_cont;
            consulta.Parameters.Add("APELLIDO_P", OdbcType.VarChar).Value = Prov.apellidoP_cont;
            consulta.Parameters.Add("APELLIDO_M", OdbcType.VarChar).Value = Prov.apellidoM_cont;
            consulta.Parameters.Add("EMAIL_CONT", OdbcType.VarChar).Value = Prov.email_cont;
            consulta.Prepare();
            consulta.ExecuteNonQuery();
            return true;
        }
        public bool Borrar(int id)
        {
            OdbcConnection coneccion = DatabaseConnection.GetConnection();
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand("DELETE FROM PROVEEDOR WHERE ID_PROVEEDOR=?", coneccion);
            consulta.Parameters.Add("ID_PROVEEDOR", OdbcType.Int).Value = id;
            consulta.Prepare();
            consulta.ExecuteNonQuery();
            return true;
        }
    }
}
