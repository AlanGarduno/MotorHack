using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MotorHack.Clientes
{
    public partial class Carrito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string idusuario = HttpContext.Current.Session["UsuarioID"].ToString();
                Modelos.Carrito car = new Modelos.Carrito();
                Listado.DataSource = car.todosResgistros(idusuario);
                Listado.DataBind();
                lblTotal.Text = Session["total"].ToString();
            }
            catch
            {
                Response.Write("Necesitas iniciar sesion para entrar al carrito");
            }
        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("Compras.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuarioid = HttpContext.Current.Session["UsuarioID"].ToString();
                
            }
            catch
            {
                Response.Write("Necesitas iniciar sesion");
            }
        }

    }
}