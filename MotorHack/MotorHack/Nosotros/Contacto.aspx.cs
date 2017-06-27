using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MotorHack.Nosotros
{
    public partial class Contacto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnContactar_Click(object sender, EventArgs e)
        {
            if(Modelos.Comentario.agregarComentario(nombre.Text,txtcorreo.Text,txttelefono.Text, txtdescripcion.Text)>0)
            Response.Write("<script language=javascript> alert('Comentario Enviado')</script>");
            else
            Response.Write("<script language=javascript> alert('Comentario no  Enviado')</script>");
            
        }
    }
}