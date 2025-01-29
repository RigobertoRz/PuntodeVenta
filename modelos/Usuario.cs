 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace ProyectoTienda.modelos
{
    public class Usuario
    {   //Informacion del usuario 
        public int id { get; set; }
        public bool rol { get; set; }
        public string nombre { get; set; }
        public string apellidoP { get; set; }
        public string apellidoM { get; set; }
        public string rfc { get; set; }
        public string calle { get; set; }
        public string colonia { get; set; }
        public string ciudad { get; set; }
        public string municipio { get; set; }
        public string pais { get; set; }
        public string celular { get; set; }
        public string cp { get; set; }
        //Informacion del login 
        public string login { get; set; }
        public string password { get; set; }
        public string email { get; set; }

        public Usuario(){}

        public Usuario(string login)
        {
            OdbcConnection coneccion = DatabaseConnection.GetConnection();
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand("SELECT ID_USUARIO,NOMBRE,ROL,APELLIDO_P,APELLIDO_M,RFC,CALLE,COLONIA,CIUDAD,MUNICIPIO,PAIS,CELULAR,CP,EMAIL,LOGIN,PASSWORD FROM USUARIO WHERE LOGIN=?", coneccion);
            consulta.Parameters.Add("LOGIN", OdbcType.VarChar).Value = login;
            consulta.Prepare();
            OdbcDataReader resultado = consulta.ExecuteReader();
            if (resultado.Read())
            {
                this.id = resultado.GetInt32(0);
                this.nombre = resultado.GetString(1);
                this.rol = resultado.GetBoolean(2);
                this.apellidoP = resultado.GetString(3);
                this.apellidoM = resultado.GetString(4);
                this.rfc = resultado.GetString(5);
                this.calle = resultado.GetString(6);
                this.colonia = resultado.GetString(7);
                this.ciudad = resultado.GetString(8);
                this.municipio = resultado.GetString(9);
                this.pais = resultado.GetString(10);
                this.celular = resultado.GetString(11);
                this.cp = resultado.GetString(12);
                this.email = resultado.GetString(13);
                this.login = resultado.GetString(14);
                this.password = resultado.GetString(15);
            }
            else
            {
                //MessageBox(""); ERROR
                throw new Exception("no se encontro el usuario");
            }
        }

        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            OdbcConnection coneccion = DatabaseConnection.GetConnection();
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand("SELECT ID_USUARIO,NOMBRE,APELLIDO_P,APELLIDO_M,RFC,CALLE,COLONIA,CIUDAD,MUNICIPIO,PAIS,CELULAR,CP,EMAIL,LOGIN FROM USUARIO", coneccion);
            consulta.Prepare();
            OdbcDataReader resultado = consulta.ExecuteReader();
            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    Usuario a = new Usuario();
                    a.id = resultado.GetInt32(0);
                    a.nombre = resultado.GetString(1);
                    a.apellidoP = resultado.GetString(2);
                    a.apellidoM = resultado.GetString(3);
                    a.rfc = resultado.GetString(4);
                    a.calle = resultado.GetString(5);
                    a.colonia = resultado.GetString(6);
                    a.ciudad = resultado.GetString(7);
                    a.municipio = resultado.GetString(8);
                    a.pais = resultado.GetString(9);
                    a.celular = resultado.GetString(10);
                    a.cp = resultado.GetString(11);
                    a.email = resultado.GetString(12);
                    a.login = resultado.GetString(13);
                    usuarios.Add(a);
                }
            }
            else
            {
                //MessageBox(""); ERROR
                throw new Exception("no se encontraron usuarios");
            }
            return usuarios;
        }
        public bool insertar(Usuario user)
        {
            OdbcConnection coneccion = DatabaseConnection.GetConnection();
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand("INSERT INTO USUARIO(ID_USUARIO,ROL,NOMBRE,APELLIDO_P,APELLIDO_M,RFC,CALLE,COLONIA,CIUDAD,MUNICIPIO,PAIS,CELULAR,CP,EMAIL,LOGIN,PASSWORD) VALUES(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)", coneccion);
            consulta.Parameters.Add("ID_USUARIO", OdbcType.Int).Value = user.id;
            consulta.Parameters.Add("ROL", OdbcType.Bit).Value = user.rol;
            consulta.Parameters.Add("NOMBRE", OdbcType.VarChar).Value = user.nombre;
            consulta.Parameters.Add("APELLIDO_P", OdbcType.VarChar).Value = user.apellidoP;
            consulta.Parameters.Add("APELLIDO_M",OdbcType.VarChar).Value = user.apellidoM;
            consulta.Parameters.Add("RFC", OdbcType.VarChar).Value = user.rfc;
            consulta.Parameters.Add("CALLE",OdbcType.VarChar).Value =user.calle;
            consulta.Parameters.Add("COLONIA", OdbcType.VarChar).Value = user.colonia;
            consulta.Parameters.Add("CIUDAD", OdbcType.VarChar).Value = user.ciudad;
            consulta.Parameters.Add("MUNICIPIO", OdbcType.VarChar).Value = user.municipio;
            consulta.Parameters.Add("PAIS", OdbcType.VarChar).Value = user.pais;
            consulta.Parameters.Add("CELULAR", OdbcType.VarChar).Value = user.celular;
            consulta.Parameters.Add("CP", OdbcType.VarChar).Value = user.cp;
            consulta.Parameters.Add("EMAIL", OdbcType.VarChar).Value = user.email;
            consulta.Parameters.Add("LOGIN", OdbcType.VarChar).Value = user.login;
            consulta.Parameters.Add("PASSWORD",OdbcType.VarChar).Value=user.password;
            consulta.Prepare();
            consulta.ExecuteNonQuery();
            return true;
        }
        public bool ModificarUsuario(Usuario usr)
        {
            OdbcConnection coneccion = DatabaseConnection.GetConnection();
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand("UPDATE USUARIO SET ROL=?,NOMBRE=?,APELLIDO_P=?,APELLIDO_M=?,RFC=?,CALLE=?,COLONIA=?,CIUDAD=?,MUNICIPIO=?,PAIS=?,CELULAR=?,CP=?,EMAIL=?,LOGIN=? WHERE ID_USUARIO=?", coneccion);
            consulta.Parameters.Add("ROL", OdbcType.Bit).Value = usr.rol;
            consulta.Parameters.Add("NOMBRE", OdbcType.VarChar).Value = usr.nombre;
            consulta.Parameters.Add("APELLIDO_P", OdbcType.VarChar).Value = usr.apellidoP;
            consulta.Parameters.Add("APELLIDO_M", OdbcType.VarChar).Value = usr.apellidoM;
            consulta.Parameters.Add("RFC", OdbcType.VarChar).Value = usr.rfc;
            consulta.Parameters.Add("CALLE", OdbcType.VarChar).Value = usr.calle;
            consulta.Parameters.Add("COLONIA", OdbcType.VarChar).Value = usr.colonia;
            consulta.Parameters.Add("CIUDAD", OdbcType.VarChar).Value = usr.ciudad;
            consulta.Parameters.Add("MUNICIPIO", OdbcType.VarChar).Value = usr.municipio;
            consulta.Parameters.Add("PAIS", OdbcType.VarChar).Value = usr.pais;
            consulta.Parameters.Add("CELULAR", OdbcType.VarChar).Value = usr.celular;
            consulta.Parameters.Add("CP", OdbcType.VarChar).Value = usr.cp;
            consulta.Parameters.Add("EMAIL", OdbcType.VarChar).Value = usr.email;
            consulta.Parameters.Add("LOGIN", OdbcType.VarChar).Value = usr.login;
            consulta.Parameters.Add("ID_USUARIO", OdbcType.Int).Value = usr.id;
            consulta.Prepare();
            consulta.ExecuteNonQuery();
            return true;
        }
        public bool Borrar(int id)
        {
            OdbcConnection coneccion = DatabaseConnection.GetConnection();
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand("DELETE FROM USUARIO WHERE ID_USUARIO=?", coneccion);
            consulta.Parameters.Add("ID_USUARIO", OdbcType.Int).Value = id;
            consulta.Prepare();
            consulta.ExecuteNonQuery();
            return true;
        }
        public static Usuario buscarNombre(string login)
        {
            //consulta la base de datos
            OdbcConnection coneccion = DatabaseConnection.GetConnection();
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand("SELECT ID_USUARIO, LOGIN, PASSWORD FROM USUARIO WHERE LOGIN=?", coneccion);
            consulta.Parameters.Add("LOGIN", OdbcType.VarChar).Value = login;
            consulta.Prepare();
            OdbcDataReader resultado = consulta.ExecuteReader();
            if (resultado.Read())
            {
                Usuario usuario = new Usuario();
                usuario.id = resultado.GetInt32(0);
                usuario.login = resultado.GetString(1);
                usuario.password = resultado.GetString(2);
                return usuario;
            }
            //MessageBox("xxxxx");//ERRROR
            //throw new Exception("el nombre de usuario no se encontro");
            return null;
        }
        public static Usuario buscarEmail(string Email)
        {
            //consulta la base de datos
            OdbcConnection coneccion = DatabaseConnection.GetConnection();
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand("SELECT ID_USUARIO,LOGIN, EMAIL FROM USUARIO WHERE Email=?", coneccion);
            consulta.Parameters.Add("Email", OdbcType.VarChar).Value = Email;
            consulta.Prepare();
            OdbcDataReader resultado = consulta.ExecuteReader();
            if (resultado.Read())
            {
                Usuario usuario = new Usuario();
                usuario.id = resultado.GetInt32(0);
                usuario.login= resultado.GetString(1);
                usuario.email = resultado.GetString(2);
                return usuario;
            }
            //MessageBox("xxxxx");//ERRROR
            //throw new Exception("el nombre de usuario no se encontro");
            return null;
        }
        public static bool CambiarContra(int id,string password)
        {
            OdbcConnection coneccion = DatabaseConnection.GetConnection();
            coneccion.Open();
            OdbcCommand consulta = new OdbcCommand("UPDATE USUARIO SET PASSWORD=? WHERE ID_USUARIO=?", coneccion);
            consulta.Parameters.Add("PASSWORD", OdbcType.VarChar).Value = password;
            consulta.Parameters.Add("ID_USUARIO", OdbcType.Int).Value = id;
            consulta.Prepare();
            consulta.ExecuteNonQuery();
            return true;
        }
    }
}
