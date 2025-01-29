using System;
using System.Collections.Generic;
using ProyectoTienda.modelos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace ProyectoTienda.controladores
{
    public class Usuarios
    {
        Usuario usuario = new Usuario();
        public static List<Usuario> ConsultarUsuarios(List<Usuario> usuarios, ref string mensaje, ref Usuario usuario)
        {
            try
            {
                usuarios = usuario.ObtenerUsuarios();
                return usuarios;
            }
            catch (Exception ex)
            {
                mensaje = "algo salio mal";
                return usuarios;
            }
        }
        public static bool Insertar(ref string mensaje, Usuario usuario)
        {
            try
            {
                usuario.password = getMd5Hash("90segfjasdmflsj" + usuario.password + usuario.login);
                mensaje = "¡Registro Agregado con exito!";
                return usuario.insertar(usuario);
            }
            catch (Exception ex)
            {
                mensaje = "algo salio mal";
                return false;
            }
        }
        public static bool Modificar(ref string mensaje, Usuario usuario)
        {
            try
            {
                mensaje = "Registro modificado con exito";
                return usuario.ModificarUsuario(usuario);
            }
            catch (Exception ex)
            {
                mensaje = "algo salio mal";
                return false;
            }
        }
        public static string getMd5Hash(string input)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        public static bool Eliminar(int id, ref string mensaje, ref Usuario usuario)
        {
            try
            {
                return usuario.Borrar(id);

            }
            catch (Exception ex)
            {
                mensaje = "algo salio mal";
                return false;
            }
        }
        public static bool Modificar(Usuario usr)
        {
            return usr.ModificarUsuario(usr);
        }
    }
}
