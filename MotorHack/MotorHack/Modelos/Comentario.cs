using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Conexion;

namespace MotorHack.Modelos
{
    public class Comentario:Modelo
    {

        public string nombre { get; set; }
        public string  correo { get; set; }
        public string  telefono { get; set; }
        public string comentario { get; set; }


        public Comentario()
        {
            this.tabla = "comentarios";
            this.campos_tabla="nombre,correo,telefono,comentario";
            this.valores = "@nombre,@correo,@telefono,@comentario";
        }



        public static int agregarComentario(string nombre, string correo, string telefono, string comentario)
        {
            Comentario com = new Comentario();
            com.agregarCampo("@nombre", nombre);
            com.agregarCampo("@correo", correo);
            com.agregarCampo("@telefono", telefono);
            com.agregarCampo("@comentario", comentario);
            return com.guardarRegistro();
        }

    }
}