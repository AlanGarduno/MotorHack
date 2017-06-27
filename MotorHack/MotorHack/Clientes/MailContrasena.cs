using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Text;

namespace MotorHack.Clientes
{
    public class MailContrasena
    {

        string Mensaje = "Con esta contraseña podra ingresar al sistema, por favor una vez que ingrese actualice su contraseña";
        string contrasena = "";



        public string generarContrasena()
        {
            Random ram = new Random();
            int n1 = ram.Next(100, 200);
            int n2 = ram.Next(10, 50);
            int n3 = ram.Next(500, 999);
            this.contrasena = Convert.ToString("/n Su neuva contraseña es:  " + n1 + n2 + n3);
            return contrasena;
        }
        public void SendMail(string correo, string Cont)
        {

            try
            {
                //Configuración del Mensaje
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 443);
                //Especificamos el correo desde el que se enviará el Email y el nombre de la persona que lo envía
                mail.From = new MailAddress("motorhack0@gmail.com ", "MotorHack", Encoding.UTF8);
                //Aquí ponemos el asunto del correo
                mail.Subject = "Recuperacion de Contraseña";
                //Aquí ponemos el mensaje que incluirá el correo
                mail.Body = Mensaje + Cont;
                //Especificamos a quien enviaremos el Email, no es necesario que sea Gmail, puede ser cualquier otro proveedor
                mail.To.Add(correo);
                mail.IsBodyHtml = true;
                mail.BodyEncoding = System.Text.Encoding.UTF8;
                ////Si queremos enviar archivos adjuntos tenemos que especificar la ruta en donde se encuentran

                //mail.Attachments.Add(new System.Net.Mail.Attachment(fichero));
                //Configuracion del SMTP
                SmtpServer.Port = 443; //Puerto que utiliza Gmail para sus servicios
                //Especificamos las credenciales con las que enviaremos el mail
                SmtpServer.Credentials = new System.Net.NetworkCredential("motorhack0@gmail.com", "edcoalal");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            }catch(Exception ex){
                
            }
        }

        public void ContestarCom(string correo, string respuesta)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com",587);
            mail.From = new MailAddress("motorhack0@gmail.com");
            mail.Subject = "Respuesta Comentario";
            mail.Body = respuesta;
            mail.To.Add(correo);
            mail.IsBodyHtml = true;
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            smtpServer.Port = 587;
            smtpServer.Credentials = new System.Net.NetworkCredential("motorhack0@gmail.com","edcoalal");
            smtpServer.Send(mail);
        }

    }
}