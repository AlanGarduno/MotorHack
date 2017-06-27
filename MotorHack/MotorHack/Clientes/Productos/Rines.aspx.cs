using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Windows.Forms;

namespace MotorHack.Clientes.Productos
{
    public partial class Rines : System.Web.UI.Page
    {
        Modelos.Productos pro = new Modelos.Productos();
        protected void Page_Load(object sender, EventArgs e)
        {
            Listado.DataSource = pro.buscarRegistros("id_catalogo", "=4");
            Listado.DataBind();
        }

        
    }
}