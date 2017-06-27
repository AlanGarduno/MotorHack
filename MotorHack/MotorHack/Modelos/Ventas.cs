using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Conexion;

namespace MotorHack.Modelos
{
    public class Ventas:Modelo
    {
        public int id_ventas { get; set; }
        public string fecha_venta { get; set; }
        public int id_usuario { get; set; }
        public float sub_total { get; set; }
        public float iva { get; set; }
        public float total { get; set; }
        public int estado { get; set; }

        public Ventas()
        {
            this.tabla = "ventas";
            this.campos_tabla = "fecha_venta,sub_total,iva,total,estado";
            this.valores = "@fecha_venta,@sub_total,@iva,total,@estado";
            this.campo = "estado";
        }


     public static int  agregarVenta(string fecha_venta, int id_usuario, double sub_total, double iva, float total)
     {
         Ventas ven = new Ventas();
         ven.agregarCampo("@fecha_venta",fecha_venta);
         ven.agregarCampo("@id_usuario",id_usuario);
         ven.agregarCampo("@sub_total", sub_total);
         ven.agregarCampo("@iva", iva);
         ven.agregarCampo("@total",total);
         ven.agregarCampo("@estado",1);
         return  ven.guardarRegistro();

     }


     public static int cambiarEstado(int estado, string id_ventas)
     {
         Ventas ven = new Ventas();
        return  ven.actualizarEstado(estado,"id_ventas",id_ventas);
     }






    }
}