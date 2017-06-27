using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Conexion;
using System.Data;
using System.Windows.Forms;

namespace MotorHack.Modelos
{
    public class Usuarios:Modelo
    {
        public int id_usuario { get; set; }
        public string usuario_n { get; set; }
        public string contrasena { get; set; }
        public string correo { get; set; }
        public int tipo_usuario { get; set; }
        public int id_cliente { get; set; }
        public int estado { get; set; }

        public Usuarios()
        {
            this.tabla = "usuarios";
            this.campos_tabla = "usuario,contrasena,correo,tipo_usuario,estado";
            this.valores = "@usuario,@contrasena,@correo,@tipo_usuario,@estado";
        }

        public static int agregarUsuario(string usuario,string contrasena,string correo)
        {
            try
            {
                Conexion.Conexion con = new Conexion.Conexion();

           
                    Usuarios usu = new Usuarios();
                    usu.agregarCampo("@usuario", usuario);
                    usu.agregarCampo("@contrasena", Conexion.Utilerias.Encriptar(contrasena));
                    usu.agregarCampo("@correo", correo);
                    usu.agregarCampo("@tipo_usuario", 2);
                    usu.agregarCampo("@estado", 1);
                    return usu.guardarRegistro();
           
            }
            catch
            {
                MessageBox.Show("Te falto llenar uno o mas campos");
            }
            return 0;
 
        }

        public DataTable consultaUsuario(string correo, string contrasena)
        {
            Usuarios usu = new Usuarios();
            return usu.buscarUsuario(correo,contrasena);
        }
        public DataTable consultaUsuario3(string id, string contrasena)
        {
            Usuarios usu = new Usuarios();
            return usu.buscarUsuario3(id, contrasena);
        }

        //*************
        
        public DataTable consultaUsuario1(string correo, string usuario)
        {
            Usuarios usu = new Usuarios();
            return usu.buscarUsuario1(correo, usuario);
        }


        public DataTable consultaUsuario2(string correo)
        {
            Usuarios usu = new Usuarios();
            return usu.buscarUsuario2(correo);
        }

        
        ///****************
        ///

        public static int actContrasena(string contrasena, string Ncontrasena)
        {
            Usuarios usu = new Usuarios();
            return usu.actualizarContrasena(Utilerias.Encriptar(Ncontrasena),Conexion.Utilerias.Encriptar(contrasena));       
        }

        public static int  actCorreo(string correo, string Ncorreo)
        {
            try
            {
                Usuarios usu = new Usuarios();
                return usu.actualizarCorreo(Ncorreo, correo);
            }
            catch
            {
                MessageBox.Show("Verifique");
            }
            return 0;
                
        }

        public static int eliminar(string correo, string contrasena)
        {
            Usuarios usu = new Usuarios();
            return usu.eliminarUsuario(correo,Utilerias.Encriptar(contrasena));
        }





    }
}