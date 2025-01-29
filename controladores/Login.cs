using ProyectoTienda.modelos;
using ProyectoTienda.vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace ProyectoTienda.controladores
{
    public class Login
    {
        public static void insertarUsuario(string login, string password)
        {
            Usuario user = new Usuario();
            user.login = login;
            user.password = getMd5Hash("90segfjasdmflsj" + password + login);
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

        public static bool validarUsuario(string login, string contraseña, ref string mensaje, ref Usuario usuario)
        {
            try
            {
                usuario = new Usuario(login);
            }
            catch (Exception)
            {
                mensaje = "*nombre de usuario o contraseña incorrectos";
                return false;
            }
            if (usuario.password == getMd5Hash("90segfjasdmflsj" + contraseña + login)) //getMd5Hash("2-5#3FEF" + contraseña + nombre))
            {
                return true;
            }
            usuario = null;
            mensaje = "*nombre de usuario o contraseña incorrectos";
            //MessageBox.Show(mensaje);
            return false;
        }
        public static bool validarCorreo(string mail, ref string mensaje,ref Usuario user)
        {
            try
            {
                user = Usuario.buscarEmail(mail);
            }
            catch(Exception ex)
            {
                mensaje = "El correo que proporciono no corresponde con nuestros registros";
                return false;
            }
            if(user.email == mail)
            {
                mensaje = "El correo que proporciono corresponde con nuestros registros y se le ha enviado un correo con una contraseña para acceder";
                string contra = Crearcontra();
                bool a = MandarCorreoContra(user.email, contra);
                string contraseña = getMd5Hash("90segfjasdmflsj" + contra + user.login);
                if (a) { Usuario.CambiarContra(user.id, contraseña); };
                return true;
            }
            user = null;
            mensaje = "El correo que proporciono no corresponde con nuestros registros";
            return false;
        }
        private static string Crearcontra()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random rand = new Random();
            return new string(Enumerable.Repeat(chars, 8).Select(s => s[rand.Next(s.Length)]).ToArray());
        }
        public static bool MandarCorreoContra(string to, string contra)//1JAL1FZ3hCbdPi@
        {
                    string from = "SuplementosStich@hotmail.com";
                    string displayName = "Suplementos El Stitch";
                    string body = @"<style>
                            h1{color:Black;}
                            h1{font-size: 22;}
                            h1{font-family: Arial, Helvetica, sans-serif;}
                            h1{text-align: justify;}
                            </style>
                            <h1>A continuación le daremos una nueva contraseña para que pueda inciar sesión, 
                                le recomendamos que la cambie cuando antes. <br>
                                Contraseña: 
                            </h1>";
                    body += contra;
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress(from, displayName);
                    mail.To.Add(to);

                    mail.Subject = "Recuperacion de Contraseña";
                    mail.Body = body;
                    mail.IsBodyHtml = true;

                    SmtpClient client = new SmtpClient("smtp.office365.com", 587); //Servidor SMTP y el puerto
                    client.Credentials = new NetworkCredential(from, "Suplementos12");
                    client.EnableSsl = true;
                    client.Send(mail);
                    return true;
        }
    }
}