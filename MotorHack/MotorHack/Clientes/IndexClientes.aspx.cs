using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MotorHack.Clientes
{
    public partial class IndexClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void verBujias(object sender, EventArgs e)
        {
            Response.Redirect("/Clientes/Productos/Bujias.aspx");
        }

        protected void verFiltrosAceite(object sender, EventArgs e)
        {
            Response.Redirect("/Clientes/Productos/FiltrosDeAceite.aspx");
        }

        protected void verFiltrosAire(object sender, EventArgs e)
        {
            Response.Redirect("/Clientes/Productos/FiltrosAire.aspx");
        }

        protected void verAceites(object sender, EventArgs e)
        {
            Response.Redirect("/Clientes/Productos/Aceites.aspx");
        }

        protected void verNeumaticos(object sender, EventArgs e)
        {
            Response.Redirect("/Clientes/Productos/Neumaticos.aspx");
        }

        protected void verRines(object sender, EventArgs e)
        {
            Response.Redirect("/Clientes/Productos/Rines.aspx");
        }

        protected void verCalipers(object sender, EventArgs e)
        {
            Response.Redirect("/Clientes/Productos/Calipers.aspx");
        }

        protected void verAmortiguadores(object sender, EventArgs e)
        {
            Response.Redirect("/Clientes/Productos/Amortiguadores.aspx");
        }

        protected void verSuspensiones(object sender, EventArgs e)
        {
            Response.Redirect("/Clientes/Productos/Suspensiones.aspx");
        }

        protected void verAnticongelantes(object sender, EventArgs e)
        {
            Response.Redirect("/Clientes/Productos/Anticongelantes.aspx");
        }

        protected void verBombasGasolina(object sender, EventArgs e)
        {
            Response.Redirect("/Clientes/Productos/BombasGasolina.aspx");
        }

    }
}