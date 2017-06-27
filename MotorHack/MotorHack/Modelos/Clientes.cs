using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Conexion;
using System.Data;
using System.Windows.Forms;

namespace MotorHack.Modelos
{
    public class Clientes:Modelo
    {
        public int id_cliente { get; set; }
        public string nombre_completo { get; set; }
        public string rfc { get; set; }
        public int estado { get; set; }
        public int bandera_n { get; set;}

        public Clientes()
        {
            this.tabla = "clientes";
            this.campos_tabla = "nombre_completo, rfc, estado,bandera";
            this.valores = "@nombre_completo, @rfc, @estado,@bandera";
            this.campo="bandera";
                
        }


        public static int agregarCliente(string nombre, string rfc)
        {
            try
            {
                Clientes cli = new Clientes();
                cli.agregarCampo("@nombre_completo", nombre);
                cli.agregarCampo("@rfc", rfc);
                cli.agregarCampo("@estado", 1);
                cli.agregarCampo("@bandera", 0);
                return cli.guardarRegistro();
            }
            catch
            {
                
                MessageBox.Show("Te falto llenar uno o mas campos");
            }
            return 0;
        }

        public DataTable consultaCliente(string rfc)
        {
            Clientes cli = new Clientes();
            return cli.buscarCliente(rfc);
        }

        public static int eliminarCli(string rfc)
        {
            Clientes cli = new Clientes();
            return cli.eliminarCliente(rfc);
        }

    }
}