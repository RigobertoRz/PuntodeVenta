using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTienda.modelos
{
    public class Cliente
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidoP{ get; set; }
        public string apellidoM { get; set; }
        public string rfc { get; set; }
        public string calle { get; set; }
        public string num_casa { get; set; }
        public string cp { get; set; }
        public string colonia { get; set; }
        public string municipio { get; set; }
        public string estado { get; set; }
        public string pais { get; set; }
        public string celular { get; set; }
        public string email { get; set; }

        public Cliente() { }
        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            OdbcConnection coneccion = DatabaseConnection.GetConnection();
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand("SELECT ID_CLIENTE,NOMBRE,APELLIDO_P,APELLIDO_M,RFC,CALLE,NUM_CASA,CP,COLONIA,MUNICIPIO,ESTADO,PAIS,CELULAR,EMAIL FROM CLIENTE", coneccion);
            consulta.Prepare();
            OdbcDataReader resultado = consulta.ExecuteReader();
            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    Cliente a = new Cliente();
                    a.id = resultado.GetInt32(0);
                    a.nombre = resultado.GetString(1);
                    a.apellidoP = resultado.GetString(2);
                    a.apellidoM = resultado.GetString(3);
                    a.rfc = resultado.GetString(4);
                    a.calle = resultado.GetString(5);
                    a.num_casa = resultado.GetString(6);
                    a.cp = resultado.GetString(7);
                    a.colonia = resultado.GetString(8);
                    a.municipio = resultado.GetString(9);
                    a.estado = resultado.GetString(10);
                    a.pais = resultado.GetString(11);
                    a.celular = resultado.GetString(12);
                    a.email = resultado.GetString(13);
                    clientes.Add(a);
                }
            }
            else
            {
                //MessageBox(""); ERROR
                throw new Exception("no se encontraron proveedores");
            }
            return clientes;
        }
        public bool insertar(Cliente cli)
        {
            OdbcConnection coneccion = DatabaseConnection.GetConnection();
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand("INSERT INTO CLIENTE(ID_CLIENTE,NOMBRE,APELLIDO_P,APELLIDO_M,RFC,CALLE,NUM_CASA,CP,COLONIA,MUNICIPIO,ESTADO,PAIS,CELULAR,EMAIL) VALUES(?,?,?,?,?,?,?,?,?,?,?,?,?,?)", coneccion);
            consulta.Parameters.Add("ID_CLIENTE", OdbcType.Int).Value = cli.id;
            consulta.Parameters.Add("NOMBRE", OdbcType.VarChar).Value = cli.nombre;
            consulta.Parameters.Add("APELLIDO_P", OdbcType.VarChar).Value = cli.apellidoP;
            consulta.Parameters.Add("APELLIDO_M", OdbcType.VarChar).Value = cli.apellidoM;
            consulta.Parameters.Add("RFC", OdbcType.VarChar).Value = cli.rfc;
            consulta.Parameters.Add("CALLE", OdbcType.VarChar).Value = cli.calle;
            consulta.Parameters.Add("NUM_CASA", OdbcType.VarChar).Value = cli.num_casa;
            consulta.Parameters.Add("CP", OdbcType.VarChar).Value = cli.cp;
            consulta.Parameters.Add("COLONIA", OdbcType.VarChar).Value = cli.colonia;
            consulta.Parameters.Add("MUNICIPIO", OdbcType.VarChar).Value = cli.municipio;
            consulta.Parameters.Add("ESTADO", OdbcType.VarChar).Value = cli.estado;
            consulta.Parameters.Add("PAIS", OdbcType.VarChar).Value = cli.pais;
            consulta.Parameters.Add("CELULAR", OdbcType.VarChar).Value = cli.celular;
            consulta.Parameters.Add("EMAIL", OdbcType.VarChar).Value = cli.email;
            consulta.Prepare();
            consulta.ExecuteNonQuery();
            return true;
        }
        public bool Modificar(Cliente cli)
        {
            OdbcConnection coneccion = new OdbcConnection(
                "Driver={ODBC Driver 17 for SQL Server};" +
               "Server=VAZZLAP\\SQLEXPRESS;" +
                "Database=Tienda;" +
                "UID=rigo;" +
                "PWD=123;");
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand("UPDATE CLIENTE SET ID_CLIENTE=?,NOMBRE=?,APELLIDO_P=?,APELLIDO_M=?,RFC=?,CALLE=?,NUM_CASA=?,CP=?,COLONIA=?,MUNICIPIO=?,ESTADO=?,PAIS=?,CELULAR=?,EMAIL=? WHERE ID_CLIENTE=?", coneccion);
            consulta.Parameters.Add("NOMBRE", OdbcType.VarChar).Value = cli.nombre;
            consulta.Parameters.Add("APELLIDO_P", OdbcType.VarChar).Value = cli.apellidoP;
            consulta.Parameters.Add("APELLIDO_M", OdbcType.VarChar).Value = cli.apellidoM;
            consulta.Parameters.Add("RFC", OdbcType.VarChar).Value = cli.rfc;
            consulta.Parameters.Add("CALLE", OdbcType.VarChar).Value = cli.calle;
            consulta.Parameters.Add("NUM_CASA", OdbcType.VarChar).Value = cli.num_casa;
            consulta.Parameters.Add("CP", OdbcType.VarChar).Value = cli.cp;
            consulta.Parameters.Add("COLONIA", OdbcType.VarChar).Value = cli.colonia;
            consulta.Parameters.Add("MUNICIPIO", OdbcType.VarChar).Value = cli.municipio;
            consulta.Parameters.Add("ESTADO", OdbcType.VarChar).Value = cli.estado;
            consulta.Parameters.Add("PAIS", OdbcType.VarChar).Value = cli.pais;
            consulta.Parameters.Add("CELULAR", OdbcType.VarChar).Value = cli.celular;
            consulta.Parameters.Add("EMAIL", OdbcType.VarChar).Value = cli.email;
            consulta.Parameters.Add("ID_CLIENTE", OdbcType.Int).Value = cli.id;
            consulta.Prepare();
            consulta.ExecuteNonQuery();
            return true;
        }
        public bool Borrar(int id)
        {
            OdbcConnection coneccion = DatabaseConnection.GetConnection();
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand("DELETE FROM CLIENTE WHERE ID_CLIENTE=?", coneccion);
            consulta.Parameters.Add("ID_CLIENTE", OdbcType.Int).Value = id;
            consulta.Prepare();
            consulta.ExecuteNonQuery();
            return true;
        }
    }
}
