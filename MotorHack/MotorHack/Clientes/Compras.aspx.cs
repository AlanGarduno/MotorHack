using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Windows.Forms;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf; 


namespace MotorHack.Clientes
{
    public partial class Compras : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string idusuario = HttpContext.Current.Session["UsuarioID"].ToString();
            Modelos.Carrito car = new Modelos.Carrito();
            DataTable dvtCarrito = car.todosResgistros(idusuario);
            int id_producto = Convert.ToInt32(dvtCarrito.Rows[0]["id_producto"].ToString());
            string nombre_producto = dvtCarrito.Rows[0]["nombre_producto"].ToString();
            int cantidad = Convert.ToInt32(dvtCarrito.Rows[0]["cantidad"].ToString());
            float precio = float.Parse(dvtCarrito.Rows[0]["precio"].ToString());
            string fecha = dvtCarrito.Rows[0]["fecha"].ToString();
            double  sub_total=Convert.ToDouble(dvtCarrito.Rows[0]["total"].ToString())/1.16;
            double iva = sub_total * 0.16;
            float total = float.Parse(Session["total"].ToString());
            int usuario = Convert.ToInt32(idusuario);
    
            Modelos.Ventas.agregarVenta(fecha,usuario,sub_total,iva,total);

            Modelos.Ventas ven = new Modelos.Ventas();

            DataTable dvtventas =  ven.ventas(idusuario);
            int id_venta = Convert.ToInt32(dvtventas.Rows[0]["id_venta"].ToString());

            Modelos.DetalleVenta.agregarDetalleVenta(id_venta,cantidad, id_producto,precio,total);

            Modelos.Productos pro = new Modelos.Productos();
          DataTable dvtProductos =  pro.buscarProducto(Convert.ToString(id_producto));
          int existencia = Convert.ToInt32(dvtProductos.Rows[0]["existencia"].ToString());
            pro.actualizarExistencia(existencia,cantidad,id_producto);



           

        }

        protected void btnNotaVenta_Click(object sender, EventArgs e)
        {

            try
            {
                iTextSharp.text.Document PDF = new iTextSharp.text.Document();
                PdfWriter.GetInstance(PDF, new FileStream(@"K:\Nota de Venta.pdf", FileMode.OpenOrCreate));
                MessageBox.Show("Nota de Venta creada con exito", "M e n s a j e", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PDF.Open();
                iTextSharp.text.Font MiFuente1 = new iTextSharp.text.Font(FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 30, iTextSharp.text.Font.BOLD));
                iTextSharp.text.Font MiFuente2 = new iTextSharp.text.Font(FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, iTextSharp.text.Font.NORMAL));
                iTextSharp.text.Font MiFuente3 = new iTextSharp.text.Font(FontFactory.GetFont(FontFactory.TIMES_ROMAN, 15, iTextSharp.text.Font.BOLD));
                iTextSharp.text.Image MiImagen = iTextSharp.text.Image.GetInstance(@"K:\Cohen 6IV6\Avanzada\WebApplication1\WebApplication1\escudo\MH.jpg");
                MiImagen.Alignment = iTextSharp.text.Image.ALIGN_LEFT;
                PDF.Add(MiImagen);
                PDF.Add(new iTextSharp.text.Paragraph("                      MotorHack", MiFuente1));
                PDF.Add(new iTextSharp.text.Paragraph("Av. Taxqueña 1620, Col. Paseos de Taxqueña, Del. Coyoacán.\nC.P. 04249\nCiudad de México, Distrito Federal\nTeléfono: 56127492\n" + DateTime.Now + "\n\n", MiFuente2));
                PdfPTable tabla = new PdfPTable(5);
                PdfPCell cell = new PdfPCell(new Phrase("Nota de Venta", MiFuente3));
                cell.Colspan = 5;
                cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                tabla.AddCell(cell);
                tabla.AddCell("Cantidad");
                tabla.AddCell("Producto");
                tabla.AddCell("Descripcion");
                tabla.AddCell("Valor unit");
                tabla.AddCell("Valor total");
                tabla.AddCell(" ");
                tabla.AddCell(" ");
                tabla.AddCell(" ");
                tabla.AddCell("$" + " ");
                tabla.AddCell("$" + " ");
                int usuario = Convert.ToInt32(Session["UsuarioID"].ToString());
                Conexion.Modelo red = new Conexion.Modelo();
                while(red.llenarNota(usuario))
                {
                   /* tabla.AddCell(red.llenarNota(usuario));
                    tabla.AddCell(red[1].ToString());*/
                }

                PDF.Add(tabla);



                PDF.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message, "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}