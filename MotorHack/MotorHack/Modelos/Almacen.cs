using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Conexion;

namespace MotorHack.Modelos
{
    public class Almacen:Modelo
    {
        public int id_almacen { get; set; }

        public string nombre { get; set; }

        public string ubicacion { get; set; }

        public Almacen()
        {
            this.tabla = "almacen";
            this.campos_tabla = "nombre, ubicacion";
            this.valores = "@nombre, @ubicacion";
        }

        public static int agregarAlmacen(string nombre, string ubicacion)
        {
            Almacen al = new Almacen();
            al.agregarCampo("@nombre",nombre);
            al.agregarCampo("@ubicaion",ubicacion);
            return al.guardarRegistro();

        }
    }

}