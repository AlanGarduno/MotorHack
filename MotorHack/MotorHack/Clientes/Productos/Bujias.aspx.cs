using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Services;
using System.Windows.Forms;

namespace MotorHack.Clientes.Productos
{
    public partial class Bujias : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            Modelos.Productos pro = new Modelos.Productos();
            Listado.DataSource = pro.buscarRegistros("id_catalogo", "=2");
            Listado.DataBind();
        }


              
    }
}