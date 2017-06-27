using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Conexion;

namespace MotorHack.Modelos
{
    public class Entrada:Modelo
    {
        public int id_entrada { get; set; }
        public int id_producto { get; set; }
        public int id_almacen { get; set; }
        public int cantidad { get; set; }
        public string fecha { get; set; }

        public Entrada()
        {
            this.tabla = "entradas";
            this.campos_tabla = "cantidad,fecha";
            this.valores = "@cantidad,@fecha";
        }

        public static int agregarEntrada(int cantidad, string fecha)
        {
            Entrada entra = new Entrada();
            entra.agregarCampo("@cantidad",cantidad);
            entra.agregarCampo("@fecha",fecha);
            return entra.guardarRegistro();
        }
    }
}