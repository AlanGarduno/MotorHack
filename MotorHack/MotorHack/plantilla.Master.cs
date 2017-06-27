using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data.SqlClient;
using Conexion;
using System.Data;


namespace MotorHack
{
    public partial class plantilla : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Session["UsuarioID"] = null;
           /* string userid = (string)Session["UsuarioID"];
            if (IsPostBack)
            {
                if (userid == "" || userid == null)
                {
                    Response.Redirect("Index.aspx");
                }
            }*/

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Modelos.Usuarios usu = new Modelos.Usuarios();
                Modelos.Clientes cli = new Modelos.Clientes();
                Conexion.Conexion com = new Conexion.Conexion();
                DataTable dvtClientes = cli.consultaCliente(txtRFC.Text);
                DataTable dvtUsuario = usu.consultaUsuario1(txtCorreo.Text, txtUsuario.Text);
                
                if (txtContrasena.Text.Length < 6)
                {
                    Response.Write("<script language=javascript> alert('La contraseña debe tener almenos 6 caracteres')</script>");
                }
                else
                {
                    if (txtRFC.Text.Length < 12)
                    {
                        Response.Write("<script language=javascript> alert('El RFC es demasiado corto')</script>");
                    }
                    else
                    {
                        if (txtConfContra.Text == txtContrasena.Text)
                        {
                            if (dvtUsuario.Rows.Count > 0 && dvtClientes.Rows.Count > 0)
                            {
                                Response.Write("<script language=javascript> alert('No se registro usuario o el usuario ya existe')</script>");

                            }
                            else
                            {
                                if (Modelos.Usuarios.agregarUsuario(txtUsuario.Text, txtContrasena.Text, txtCorreo.Text) > 0 && Modelos.Clientes.agregarCliente(txtNombreCompleto.Text, txtRFC.Text) > 0)
                                {
                                    Response.Write("<script language=javascript> alert('Registrado Correctamente, Ya puedes iniciar sesion')</script>");
                               
                                }
                                else
                                    Response.Write("<script language=javascript> alert('No se registro usuario o el usuario ya existe')</script>");

                            }
                        }
                        else
                        {
                            Response.Write("<script language=javascript> alert('Las contraseñas no coinciden')</script>");

                        }
                    }
                }
            }
            catch
            {
                Response.Write("<script language=javascript> alert('Verifica tus datos')</script>");

            }
        }

        protected void btnInic_Click(object sender, EventArgs e)
        {
            String usuario = txtEmail.Text.Replace(";", "").Replace("'", "").Replace("/", "").Replace("--", "");
            String contrasena = txtPassword.Text.Replace(";", "").Replace("'", "").Replace("/", "").Replace("--", "");
            Conexion.Conexion con = new Conexion.Conexion();
            if (con.verificar(usuario, contrasena) == true)
            {
                Modelos.Usuarios usu = new Modelos.Usuarios();
                DataTable dtvUsuarios = usu.consultaUsuario(usuario, contrasena);
                int estado = Convert.ToInt32( dtvUsuarios.Rows[0]["estado"].ToString());
                if (estado == 1)
                {
                    Session["UsuarioID"] = dtvUsuarios.Rows[0]["id_usuario"].ToString();
                    Session["total"] = 0;
                    int tipo_usuario = Convert.ToInt32(dtvUsuarios.Rows[0]["tipo_usuario"].ToString());
                    switch (tipo_usuario)
                    {
                        case 1:
                            //Response.Redirect("");
                            Response.Write("<script language=javascript> alert('Admi')</script>");
                        break;

                        case 2:
                        Response.Write("<script language=javascript> alert('Bienvenido')</script>");
                        Response.Redirect("/Clientes/IndexClientes.aspx");
                        
                        break;
                    }

                  

                    //MessageBox.Show("EXITO");
                }
                else
                    Response.Write("<script language=javascript> alert('Usuario inhabilitado')</script>");
                    
            }
            else
            {
                Response.Write("<script language=javascript> alert('Usuario o contraseña incorrecta')</script>");
                
            }
        }

    }
}