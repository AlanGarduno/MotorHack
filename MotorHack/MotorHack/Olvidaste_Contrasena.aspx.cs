using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Windows.Forms;

namespace MotorHack
{
    public partial class Olvidaste_Contrasena : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Modelos.Usuarios usu = new Modelos.Usuarios();
            DataTable dvtUsuarios = usu.buscarUsuario2(txtCorreo.Text);
            if (dvtUsuarios.Rows.Count == 1)
            {
                Clientes.MailContrasena mail = new Clientes.MailContrasena();
               string contra = mail.generarContrasena();
                mail.SendMail(txtCorreo.Text,contra);
                usu.olvidoContrasena(contra,txtCorreo.Text);
                Response.Write("<script language=javascript> alert('Correo enviado, por favor revise su correo electronico')</script>");
                
            }
            else
            {
                Response.Write("<script language=javascript> alert('Este correo no esta registrado')</script>");
            }
        }
    }
}