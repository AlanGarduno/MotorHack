using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Conexion;

namespace MotorHack.Modelos
{
    public class DetalleVenta:Modelo
    {
        public int id_detalle { get; set; }
        public int id_venta { get; set; }
        public int cantidad { get; set; }
        public int id_producto { get; set; }
        public float  precio_venta { get; set; }
        public float total { get; set; }

        public DetalleVenta()
        {
            this.tabla = "detalle_venta";
            this.campos_tabla = "id_venta,cantidad,id_producto,precio_venta,total";
            this.valores="@id_venta,@cantidad,@id_producto,@precio_venta,@total";
        }


        public static int agregarDetalleVenta  (int id_venta, int cantidad, int id_producto, double precio_venta, float total)
        {
            DetalleVenta dtVenta = new DetalleVenta();
            dtVenta.agregarCampo("@id_venta",id_venta);
            dtVenta.agregarCampo("@cantidad",cantidad);
            dtVenta.agregarCampo("@id_producto",id_producto);
            dtVenta.agregarCampo("@precio_venta",precio_venta);
            dtVenta.agregarCampo("@total",total);
            return dtVenta.guardarRegistro();
        }
    }

}