using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MotorHack.Clientes.Productos
{
    public partial class Anticongelantes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Modelos.Productos pro = new Modelos.Productos();
            Listado.DataSource = pro.buscarRegistros("id_catalogo", "=11");
            Listado.DataBind();
        }

    }
}