using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Conexion;

namespace MotorHack.Modelos
{
    public class Carrito:Modelo
    {
        public int id_usuario { get; set; }
        public int id_producto { get; set; }
        public string nombre_producto  {get; set; }
        public int cantidad { get; set; }
        public float precio { get; set; }
        public string fecha { get; set; }
        public int estado { get; set; }


        public Carrito()
        {
            this.tabla = "carrito";

            this.campos_tabla = "id_usuario,id_producto,nombre_producto,cantidad,precio,fecha,estado,total";

            this.valores = "@id_usuario,@id_producto,@nombre_producto,@cantidad,@precio,@fecha,@estado,@total";

            this.campo = "total";
        }


        public static int agregarACarrito(int id_usuario, int id_producto, string nombre_producto, int cantidad, float precio, float total)
        {
            Carrito car = new Carrito();
            car.agregarCampo("@id_usuario", id_usuario);
            car.agregarCampo("@id_producto", id_producto);
            car.agregarCampo("@nombre_producto", nombre_producto);
            car.agregarCampo("@cantidad", cantidad);
            car.agregarCampo("@precio", precio);
            car.agregarCampo("@fecha","2014-02-02");
            car.agregarCampo("@estado",1);
            car.agregarCampo("@total", total);
            return car.guardarRegistro();
        }

        public static int eliminarOrden(string usuarioid)
        {
            Carrito car = new Carrito();
            return car.eliminarRegistro("id_usuario","="+usuarioid);
        }

        private int eliminarRegistro()
        {
            throw new NotImplementedException();
        }



    }
}