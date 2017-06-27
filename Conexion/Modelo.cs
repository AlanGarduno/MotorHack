using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Conexion
{
    public class Modelo:Conexion
    {
        public string tabla { get; set; }
        public string campos_tabla { get; set; }
        public string valores { get; set; }

        public string campo { get; set; }

        private Dictionary<string, string> campos = new Dictionary<string, string>();
        public DataTable registro;

        public Modelo()
        {
        }

        public void agregarCampo(string campo, string valor)
        {
            this.valores = this.valores.Replace(campo, "'" + valor + "'");
        }
        public void agregarCampo(string campo, double valor)
        {
            this.valores = this.valores.Replace(campo, "'" + valor + "'");
        }
        public void agregarCampo(string campo, int valor)
        {
            this.valores = this.valores.Replace(campo, "'" + valor.ToString() + "'");
        }
        public void agregarCampo(string campo, float valor)
        {
            this.valores = this.valores.Replace(campo, "'" + valor.ToString() + "'");
        }


        public DataTable producto (string id_producto)
        {
            string sql = ("SELECT * FROM productos WHERE id_producto = '"+id_producto+"' ");
            return consultar(sql);

        }


        public int guardarRegistro()
        {
            string sql = string.Format("INSERT INTO {0}({1}) VALUES({2});", this.tabla, this.campos_tabla, this.valores);
            return ejecutar(sql);
        }

        public bool llenarNota(int id_usuario)
        {
            string sql = string.Format("SELECT * FROM carrito WHERE id_usuario='"+id_usuario+"' ");
            return nota(sql);
            
        }
        public int actualizarEstado(int estado,string campo, string condicion)
        {
            condicion = (campo.Trim() == "") ? "" : "WHERE" + campo + " " + condicion;
            string sql = string.Format("UPDATE {0}  SET estado = '"+estado+"'  WHERE {1} ", this.tabla,condicion);
            return ejecutar(sql);
        }

        public int guardarRegistro(float totalote)
        {
            string sql = string.Format("INSERT INTO {0}({1}) VALUES('"+totalote+"');", this.tabla, this.campo);
            return ejecutar(sql);
        }

        public DataTable buscarRegistros()
        {
            return buscarRegistros("", "");
        }

        public int eliminarRegistro(string campo,string condicion)
        {
            condicion = (campo.Trim() == "") ? "" : "WHERE" + campo + " " + condicion;
            string sql = string.Format("DELETE FROM {0} WHERE {1}",this.tabla,condicion);
            return ejecutar(sql);
        }

        public DataTable buscarRegistros(string campo, string condicion)
        {
            condicion = (campo.Trim() == "") ? "" : " WHERE " + campo + " " + condicion;
            string sql = string.Format("SELECT * FROM {0}{1}", this.tabla, condicion);
            return consultar(sql);
        }



        public int actualizarExistencia(int existecia, int cantidad, int id_producto)
        {
            string sql = "UPDATE productos SET existencia = '" + existecia + "' -  '" + cantidad + "' WHERE id_producto = '" + id_producto + "' ";
            return ejecutar(sql);
        }
        public int aumentarExistencia(int existencia, int cantidad, int id_producto)
        {
            string sql = "UPDATE productos SET existencia = '"+existencia+"'  +  '"+cantidad+"' WHERE id_producto = '"+id_producto+"'   ";
            return ejecutar(sql);
        }
        public DataTable todosResgistros(string idusuario)
        {
            string sql = string.Format("SELECT * FROM carrito  WHERE id_usuario='"+idusuario+"' ");
            return consultar(sql);
        }

        public DataTable buscarUsuario(string correo, string contrasena)
        {
            Conexion usu = new Conexion();
            return usu.usuario(correo, contrasena);    
        }
        public DataTable buscarProducto(string idproducto)
        {
            string sql = string.Format("SELECT * FROM productos WHERE id_producto= '" + idproducto + "'  ");
            return consultar(sql);
        }
        public DataTable buscarUsuario3(string id, string contrasena)
        {
            Conexion usu = new Conexion();
            return usu.usuario3(id, contrasena);

        } 
        //***********
        public DataTable buscarUsuario2(string correo)
        {
            Conexion usu = new Conexion();
            return usu.usuario2(correo);

        }
        //***************
        public DataTable buscarCliente(string rfc)
        {
            Conexion cli = new Conexion();
            return cli.cliente(rfc);
        }
        //*************
        public DataTable buscarUsuario1(string correo, string usuario)
        {
            Conexion usu = new Conexion();
            return usu.usuario1(correo, usuario);

        }
        //************
        public DataTable buscarRegistro()
        {
            return buscarRegistro("", "");
        }

        public DataTable buscarRegistro(string campo, string condicion)
        {
            condicion = (campo.Trim() == "") ? "" : " WHERE " + campo + " " + condicion;
            string sql = string.Format("SELECT TOP 1 * FROM {0}{1}", this.tabla, condicion);
            this.registro = consultar(sql);
            cargarRegistro();
            return this.registro;
        }

        //****************************

        public int actualizarContrasena(string contrasena, string Ncontrasnea)
        {

         string sql = "UPDATE usuarios SET contrasena = '"+Ncontrasnea+"' WHERE contrasena = '"+contrasena+"'  ";
         return ejecutar(sql);
     
        }

        public int actualizarCorreo(string correo, string Ncorreo)
        {
            string sql="UPDATE usuarios SET correo = '"+Ncorreo+"' WHERE correo='"+correo+"' ";
            return ejecutar(sql);
        }

        public int eliminarUsuario(string correo, string contrasena)
        {
            string sql = "DELETE FROM usuarios WHERE correo='"+correo+"' AND contrasena ='"+contrasena+"' ";
            return ejecutar(sql);
        }

        public int eliminarCliente(string rfc)
        {
            string sql = "DELETE FROM clientes WHERE rfc='"+rfc+"' ";
            return ejecutar(sql);
        }

        public int olvidoContrasena(string contragen, string correo)
        {
            string sql = "UPDATE usuarios SET contrasena = '" +Utilerias.Encriptar( contragen )+ "' WHERE correo = '" + correo + "'  ";
            return ejecutar(sql);
        }
      
        public void cargarRegistro()
        {
            if (this.registro.Rows.Count > 0)
            {
                DataRow fila = this.registro.Rows[0];
                foreach (DataColumn columna in registro.Columns)
                {
                    this.campos.Add(columna.ColumnName, fila[columna].ToString());
                }
            }
        }


 
    }
}
