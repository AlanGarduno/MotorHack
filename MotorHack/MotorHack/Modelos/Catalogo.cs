using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Conexion;

namespace MotorHack.Modelos
{
    public class Catalogo:Modelo
    {
        public int id_catalogo { get; set; }
        public string categoria { get; set; }
        public string descripcion { get; set; }

        public Catalogo()
        {
            this.tabla = "catalogo";
            this.campos_tabla = "categoria,descripcion";
            this.valores = "@categoria,@descripcion";
        }

        public static int agregarCatalogo(string categoria, string descripcion)
        {
            Catalogo cat = new Catalogo();
            cat.agregarCampo("@categoria",categoria);
            cat.agregarCampo("@descripcion",descripcion);
            return cat.guardarRegistro();
        }
    }
}