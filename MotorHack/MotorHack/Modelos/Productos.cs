using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Conexion;

namespace MotorHack.Modelos
{
    public class Productos:Modelo
    {
        public int id_producto { get; set; }
        public string nombre { get; set; }
        public float precio_venta { get; set; }
        public float precio_compra { get; set; }
        public int id_catalogo { get; set; }
        public int existencia { get; set; }
        public int estado { get; set; }

        public Productos()
        {
            this.tabla = "productos";
            this.campos_tabla = "nombre, precio_venta, precio_compra, existencia, estado";
            this.valores = "@nombre, @precio_venta, @precio_compra, @existencia, @estado";
        }


        public static int agregarProducto(string nombre, float precio_venta, float precio_compra, int existencia)
        {
            Productos prod = new Productos();
            prod.agregarCampo("@nombre", nombre);
            prod.agregarCampo("@precio_venta", precio_venta);
            prod.agregarCampo("@precio_compra", precio_compra);
            prod.agregarCampo("@existencia", existencia);
            prod.agregarCampo("@estado", 1);
            return prod.guardarRegistro();
        }

        public DataTable buscarProducto(string idproducto)
        {
            Productos pro = new Productos();
           return pro.producto(idproducto);
           
        }
    }
}