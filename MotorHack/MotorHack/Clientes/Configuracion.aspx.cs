using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data;

namespace MotorHack.Clientes
{
    public partial class Configuracion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UsuarioID"] == null)
            {
                Response.Write("<script language=javascript> alert('Debes iniciar sesion para acceder a las configuraciones de la cuenta')</script>");
                Response.Redirect("IndexClientes.aspx");

            }
        }

        protected void btnGuardarContra_Click(object sender, EventArgs e)
        {
            string id = Session["UsuarioID"].ToString();
            Modelos.Usuarios usu = new Modelos.Usuarios();
            DataTable dvtUsuarios = usu.consultaUsuario3(id,txtContra.Text);
            if (dvtUsuarios.Rows.Count == 1)
            {
                if (txtNuevaContra.Text.Length < 6)
                {
                    Response.Write("<script language=javascript> alert('La contraseña debe tener al menos 6 caracteres')</script>");
                }
                else
                {
                    if (txtNuevaContra.Text == txtConfirmNcontra.Text)
                    {

                        if (Modelos.Usuarios.actContrasena(txtNuevaContra.Text, txtContra.Text) > 0)
                        {
                            Response.Write("<script language=javascript> alert('Se actualizo la contraseña correctamente')</script>");

                        }
                        else
                        {
                            Response.Write("<script language=javascript> alert('No se ha actualizado')</script>");
                        }
                    }
                    else
                    {
                        Response.Write("<script language=javascript> alert('Las contraseñas no coinciden verifique')</script>");
                    }
                }
            }
            else
            {
                Response.Write("<script language=javascript> alert('La contraseña que introdujo es incorrecta por favor verifique')</script>");
            }
        }

        protected void btnGuardarCorreo_Click(object sender, EventArgs e)
        {
            Modelos.Usuarios usu = new Modelos.Usuarios();
            DataTable dtvUsuarios = usu.consultaUsuario2(txtCorreo.Text);
            try
            {
                if (dtvUsuarios.Rows.Count > 0)
                {
                    if (txtConfrimNcorreo.Text == txtNuevoCorreo.Text)
                    {
                        if (Modelos.Usuarios.actCorreo(txtNuevoCorreo.Text, txtCorreo.Text) > 0)
                        {
                            Response.Write("<script language=javascript> alert('El correo se ha actualizado')</script>");

                        }
                        else
                        {
                            Response.Write("<script language=javascript> alert('No se ha actualizado')</script>");
                        }
                    }
                    else
                    {
                        Response.Write("<script language=javascript> alert('Los correos no coinciden')</script>");
                    }
                }
                else
                {
                    Response.Write("<script language=javascript> alert('El correo que ingreso no esta registrado')</script>");
                }
            }
            catch
            {
                Response.Write("<script language=javascript> alert('Verifique')</script>");
            }
        }

        protected void btnEliminaCuenta_Click(object sender, EventArgs e)
        {
            Modelos.Usuarios usu = new Modelos.Usuarios();
            Modelos.Clientes cli = new Modelos.Clientes();
           DataTable dtvUsuarios = usu.buscarUsuario(txtECorreo.Text, txtEContrasena.Text);
           DataTable dtvClientes = cli.consultaCliente(txtERFC.Text);

           if (txtERFC.Text.Length < 12)
           {
               Response.Write("<script language=javascript> alert('RFC demaciado corto')</script>");
           }
           else
           {

               if (dtvUsuarios.Rows.Count > 0 && dtvClientes.Rows.Count > 0)
               {
                   if (Modelos.Usuarios.eliminar(txtECorreo.Text, txtEContrasena.Text) > 0 && Modelos.Clientes.eliminarCli(txtERFC.Text) > 0)
                   {
                       Response.Write("<script language=javascript> alert('Usuario eliminado correctamente, Hasta Pronto!')</script>");
                       Response.Redirect("../Index.aspx", false);
                   }
                   else
                   {
                       Response.Write("<script language=javascript> alert('No se elimino el usuario')</script>");
                   }
               }
               else
               {
                   Response.Write("<script language=javascript> alert('El usuario que intenta eliminar no esta registrado')</script>");
               }
           }

        }

    }
}