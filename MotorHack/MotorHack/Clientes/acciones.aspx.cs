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
    public partial class acciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Modelos.Carrito car = new Modelos.Carrito();
                string parametro = Request.QueryString["accion"].ToString();
                float total = 0;

                switch (parametro)
                {
                    case "agregar_aceites":
                        string id_p = Request.QueryString["id_producto"].ToString();
                        string cantidad = Request.QueryString["cantidad"].ToString();
                        string nom = Request.QueryString["nombre"].ToString();
                        string pres = Request.QueryString["precio"].ToString().Replace(",", ".");
                        string nombre = nom;
                        float precio = float.Parse(pres);
                        int p_cantidad = Convert.ToInt32(cantidad.Trim());
                        int p_idProducto = Convert.ToInt32(id_p);
                        total = p_cantidad * precio;
                        int usuario = Convert.ToInt32(Session["UsuarioID"].ToString());
                        if (usuario == 0)
                        {
                            Response.Write("Inicia Sesion para compar");
                        }
                        else
                        {
                            if (Modelos.Carrito.agregarACarrito(usuario, p_idProducto, nombre, p_cantidad, precio, total) > 0)
                            {
                                float total_venta = float.Parse(Session["total"].ToString());
                                total_venta += total;
                                Session["total"] = total_venta;
                                Response.Write("Se agrego al carrito");

                            }
                            else
                                Response.Write("No se agrego");
                        }
                        break;
                    //**************
                    case "agregar_bujias":
                        string id_p_b = Request.QueryString["id_producto"].ToString();
                        string cantidad_b = Request.QueryString["cantidad"].ToString();
                        string nom_b = Request.QueryString["nombre"].ToString();
                        string pres_b = Request.QueryString["precio"].ToString().Replace(",", ".");

                        string nombre_b = nom_b;
                        float precio_b = float.Parse(pres_b);
                        int p_cantidad_b = Convert.ToInt32(cantidad_b.Trim());
                        int p_idProducto_b = Convert.ToInt32(id_p_b);
                        total = p_cantidad_b * precio_b;
                        int usuario_b = Convert.ToInt32(Session["UsuarioID"].ToString());
                        if (usuario_b == 0)
                        {
                            Response.Write("Inicia Sesion para compar");
                        }
                        else
                        {
                            if (Modelos.Carrito.agregarACarrito(usuario_b, p_idProducto_b, nombre_b, p_cantidad_b, precio_b, total) > 0)
                            {
                                float total_venta = float.Parse(Session["total"].ToString());
                                total_venta += total;
                                Session["total"] = total_venta;
                                Response.Write("Se agrego al carrito");

                            }
                            else
                                Response.Write("No se agrego");
                        }
                        break;
                    //******************
                    case "agregar_amortiguadores":
                        string id_p_a = Request.QueryString["id_producto"].ToString();
                        string cantidad_a = Request.QueryString["cantidad"].ToString();
                        string nom_a = Request.QueryString["nombre"].ToString();
                        string pres_a = Request.QueryString["precio"].ToString().Replace(",", ".");

                        string nombre_a = nom_a;
                        float precio_a = float.Parse(pres_a);
                        int p_cantidad_a = Convert.ToInt32(cantidad_a.Trim());
                        int p_idProducto_a = Convert.ToInt32(id_p_a);
                        int usuario_a = Convert.ToInt32(Session["UsuarioID"].ToString());
                        total = p_cantidad_a * precio_a;
                        if (usuario_a == 0)
                        {
                            Response.Write("Inicia Sesión para compar");
                        }
                        else
                        {
                            if (Modelos.Carrito.agregarACarrito(usuario_a, p_idProducto_a, nombre_a, p_cantidad_a, precio_a, total) > 0)
                            {
                                
                                float total_venta = float.Parse(Session["total"].ToString());
                                total_venta += total;
                                Session["total"] = total_venta;
                                Response.Write("Se agrego al carrito");

                            }
                            else
                                Response.Write("No se agrego");
                        }
                        break;
                    //***********
                      
                         case "agregar_anticongelantes":
                          string id_p_an =Request.QueryString["id_producto"].ToString();
                         string cantidad_an = Request.QueryString["cantidad"].ToString();
                         string nom_an = Request.QueryString["nombre"].ToString();
                         string pres_an = Request.QueryString["precio"].ToString().Replace(",", ".");

                 string nombre_an = nom_an;
                 float precio_an = float.Parse(pres_an);
                 int p_cantidad_an = Convert.ToInt32(cantidad_an.Trim());
                 int p_idProducto_an = Convert.ToInt32(id_p_an);
                 int usuario_an = Convert.ToInt32(HttpContext.Current.Session["UsuarioID"].ToString());
                 total = precio_an * p_cantidad_an;
                 if (usuario_an == 0)
                 {
                     Response.Write("Inicia Sesion para compar");
                 }
                 else
                 {
                     if (Modelos.Carrito.agregarACarrito(usuario_an, p_idProducto_an, nombre_an, p_cantidad_an, precio_an,total) > 0)
                     {
                         float total_venta = float.Parse(Session["total"].ToString());
                         total_venta += total;
                         Session["total"] = total_venta;
                         Response.Write("Se agrego al carrito");

                     }
                      else
                     Response.Write("No se agrego");
                 }
                             break;

                            //*********

                         case "agregar_bombasGasolina":
                         string id_p_bg =Request.QueryString["id_producto"].ToString();
                         string cantidad_bg = Request.QueryString["cantidad"].ToString();
                         string nom_bg = Request.QueryString["nombre"].ToString();
                         string pres_bg = Request.QueryString["precio"].ToString().Replace(",", ".");

                 string nombre_bg = nom_bg;
                 float precio_bg = float.Parse(pres_bg);
                 int p_cantidad_bg = Convert.ToInt32(cantidad_bg.Trim());
                 int p_idProducto_bg = Convert.ToInt32(id_p_bg);
                 int usuario_bg = Convert.ToInt32(HttpContext.Current.Session["UsuarioID"].ToString());
                 total = precio_bg * p_cantidad_bg;
                 if (usuario_bg == 0)
                 {
                     Response.Write("Inicia Sesion para compar");
                 }
                 else
                 {
                     if (Modelos.Carrito.agregarACarrito(usuario_bg, p_idProducto_bg, nombre_bg, p_cantidad_bg, precio_bg,total) > 0)
                     {
                         float total_venta = float.Parse(Session["total"].ToString());
                         total_venta += total;
                         Session["total"] = total_venta;
                         Response.Write("Se agrego al carrito");

                     }
                     Response.Write("No se agrego");
                 }

                             break;

                             //*****
                         case "agregar_calipers":
                         string id_p_c =Request.QueryString["id_producto"].ToString();
                         string cantidad_c = Request.QueryString["cantidad"].ToString();
                         string nom_c = Request.QueryString["nombre"].ToString();
                         string pres_c = Request.QueryString["precio"].ToString().Replace(",", ".");

                 string nombre_c = nom_c;
                 float precio_c = float.Parse(pres_c);
                 int p_cantidad_c = Convert.ToInt32(cantidad_c.Trim());
                 int p_idProducto_c = Convert.ToInt32(id_p_c);
                 int usuario_c = Convert.ToInt32(HttpContext.Current.Session["UsuarioID"].ToString());
                 total = precio_c * p_cantidad_c;
                 if (usuario_c == 0)
                 {
                     Response.Write("Inicia Sesion para compar");
                 }
                 else
                 {
                     if (Modelos.Carrito.agregarACarrito(usuario_c, p_idProducto_c, nombre_c, p_cantidad_c, precio_c,total) > 0)
                     {
                         float total_venta = float.Parse(Session["total"].ToString());
                         total_venta += total;
                         Session["total"] = total_venta;
                         Response.Write("Se agrego al carrito");

                     }
                      else
                     Response.Write("No se agrego");
                 }

                             break;

                             //**********
                         case "agregar_filtroAire":
                         string id_p_f =Request.QueryString["id_producto"].ToString();
                         string cantidad_f = Request.QueryString["cantidad"].ToString();
                         string nom_f = Request.QueryString["nombre"].ToString();
                         string pres_f = Request.QueryString["precio"].ToString().Replace(",", ".");

                 string nombre_f = nom_f;
                 float precio_f = float.Parse(pres_f);
                 int p_cantidad_f = Convert.ToInt32(cantidad_f.Trim());
                 int p_idProducto_f = Convert.ToInt32(id_p_f);
                 int usuario_f = Convert.ToInt32(HttpContext.Current.Session["UsuarioID"].ToString());
                 total = precio_f * p_cantidad_f;
                 if (usuario_f == 0)
                 {
                     Response.Write("Inicia Sesion para compar");
                 }
                 else
                 {
                     if (Modelos.Carrito.agregarACarrito(usuario_f, p_idProducto_f, nombre_f, p_cantidad_f, precio_f,total) > 0)
                     {
                         float total_venta = float.Parse(Session["total"].ToString());
                         total_venta += total;
                         Session["total"] = total_venta;
                         Response.Write("Se agrego al carrito");

                     }
                     else
                     Response.Write("No se agrego");
                 }

                             break;
                             //********
                         case "agregar_filreosDeAceite":
                         string id_p_fa =Request.QueryString["id_producto"].ToString();
                         string cantidad_fa = Request.QueryString["cantidad"].ToString();
                         string nom_fa = Request.QueryString["nombre"].ToString();
                         string pres_fa = Request.QueryString["precio"].ToString().Replace(",", ".");

                 string nombre_fa = nom_fa;
                 float precio_fa = float.Parse(pres_fa);
                 int p_cantidad_fa = Convert.ToInt32(cantidad_fa.Trim());
                 int p_idProducto_fa = Convert.ToInt32(id_p_fa);
                 int usuario_fa = Convert.ToInt32(HttpContext.Current.Session["UsuarioID"].ToString());
                 total = precio_fa * p_cantidad_fa;
                 if (usuario_fa == 0)
                 {
                     Response.Write("Inicia Sesion para compar");
                 }
                 else
                 {
                     if (Modelos.Carrito.agregarACarrito(usuario_fa, p_idProducto_fa, nombre_fa, p_cantidad_fa, precio_fa,total) > 0)
                     {
                         float total_venta = float.Parse(Session["total"].ToString());
                         total_venta += total;
                         Session["total"] = total_venta;
                         Response.Write("Se agrego al carrito");

                     }
                     else
                     Response.Write("No se agrego");
                 }

                             break;

                         case "agregar_neumatico":
                         string id_p_n =Request.QueryString["id_producto"].ToString();
                         string cantidad_n = Request.QueryString["cantidad"].ToString();
                         string nom_n = Request.QueryString["nombre"].ToString();
                         string pres_n = Request.QueryString["precio"].ToString().Replace(",", ".");
                    

                 string nombre_n = nom_n;
                 float precio_n = float.Parse(pres_n);
                 int p_cantidad_n = Convert.ToInt32(cantidad_n.Trim());
                 int p_idProducto_n = Convert.ToInt32(id_p_n);
                 int usuario_n = Convert.ToInt32(HttpContext.Current.Session["UsuarioID"].ToString());
                 total = p_cantidad_n * precio_n; 
                 if (usuario_n == 0)
                 {
                     Response.Write("Inicia Sesion para compar");
                 }
                 else
                 {
                     if (Modelos.Carrito.agregarACarrito(usuario_n, p_idProducto_n, nombre_n, p_cantidad_n, precio_n,total) > 0)
                     {
                         float total_venta = float.Parse(Session["total"].ToString());
                         total_venta += total;
                         Session["total"] = total_venta;
                         Response.Write("Se agrego al carrito");

                     }
                     else
                     Response.Write("No se agrego");
                 }


                             break;

                         case"agregar_rines":
                         string id_p_r =Request.QueryString["id_producto"].ToString();
                         string cantidad_r = Request.QueryString["cantidad"].ToString();
                         string nom_r = Request.QueryString["nombre"].ToString();
                         string pres_r = Request.QueryString["precio"].ToString().Replace(",", ".");

                 string nombre_r = nom_r;
                 float precio_r = float.Parse(pres_r);
                 int p_cantidad_r = Convert.ToInt32(cantidad_r.Trim());
                 int p_idProducto_r = Convert.ToInt32(id_p_r);
                 int usuario_r = Convert.ToInt32(HttpContext.Current.Session["UsuarioID"].ToString());
                 total = precio_r * p_cantidad_r;
                 if (usuario_r == 0)
                 {
                     Response.Write("Inicia Sesion para compar");
                 }
                 else
                 {
                     if (Modelos.Carrito.agregarACarrito(usuario_r, p_idProducto_r, nombre_r, p_cantidad_r, precio_r,total) > 0)
                     {
                         float total_venta = float.Parse(Session["total"].ToString());
                         total_venta += total;
                         Session["total"] = total_venta;
                         Response.Write("Se agrego al carrito");

                     }
                     else
                     Response.Write("No se agrego");
                 }

                             break;

                         case "agregar_suspenciones":

                         string id_p_s =Request.QueryString["id_producto"].ToString();
                         string cantidad_s = Request.QueryString["cantidad"].ToString();
                         string nom_s = Request.QueryString["nombre"].ToString();
                         string pres_s = Request.QueryString["precio"].ToString().Replace(",", ".");

                 string nombre_s = nom_s;
                 float precio_s = float.Parse(pres_s);
                 int p_cantidad_s = Convert.ToInt32(cantidad_s.Trim());
                 int p_idProducto_s = Convert.ToInt32(id_p_s);
                 int usuario_s = Convert.ToInt32(HttpContext.Current.Session["UsuarioID"].ToString());
                 total = p_cantidad_s * precio_s;
                 if (usuario_s == 0)
                 {
                     Response.Write("Inicia Sesion para compar");
                 }
                 else
                 {
                     if (Modelos.Carrito.agregarACarrito(usuario_s, p_idProducto_s, nombre_s, p_cantidad_s, precio_s,total) > 0)
                     {
                         float total_venta = float.Parse(Session["total"].ToString());
                         total_venta += total;
                         Session["total"] = total_venta;
                         Response.Write("Se agrego al carrito");

                     }
                     else
                     Response.Write("No se agrego");
                 }
                             break;




                     }
                }
          
            catch (Exception ex)
            {
                Response.Write("Necesitas iniciar sesion para agregar al carrito");
            }

        }

    }
}