using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Conexion
{
    public class Conexion
    {
        public string servidor { get; set; }
        public string user { get; set; }
        public string password { get; set; }
        public string base_datos { get; set; }
        public string connection_string { get; set; }
        private SqlConnection cnn;
        private List<string> errores = new List<string>();

        public List<string> obtener_errores()
        {
            return this.errores;
        }

        public Conexion()
        {
            this.servidor = @"PROPIETARIO-PC\SQLALAN"; //@"PROPIETARIO-PC\SQLALAN"; 
            this.user = "sa";
            this.password = "sa1";
            this.base_datos = "MHDB";
            this.connection_string = string.Format("Server={0};Database={1};User Id={2};Password={3};", this.servidor, this.base_datos, this.user, this.password);
            this.cnn = new SqlConnection(this.connection_string);
        }

        private bool conectar()
        {
            try
            {
                this.cnn.Open();
                return true;
            }
            catch (Exception ex)
            {
                errores.Add("Conexion => " + ex.InnerException + ": " + ex.Message);
            }
            return false;
        }

        public int ejecutar(string sql)
        {
            if (conectar() == true)
            {
                SqlCommand cmd = new SqlCommand(sql, this.cnn);
                int resultado = cmd.ExecuteNonQuery();
                this.errores.Add("Ejecutar => Se ejecuto la sentencia: " + sql + ", afectado a " + resultado.ToString() + " registros");
                cerrarConexion();
                return resultado;
            }
            return -1;
        }
        public DataTable cliente(string rfc)
        {
        
            if(conectar()==true)
            {
                SqlCommand cmd = new SqlCommand("SELECT id_cliente,nombre_completo,rfc FROM  clientes WHERE rfc='"+rfc+"' ", this.cnn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                DataTable clientes = new DataTable();
                adat.Fill(clientes);
                return clientes;
            }
            return null;
        }

        public DataTable ventas(string idusuario)
        {
            if (conectar() == true)
            {
                SqlCommand cmd = new SqlCommand("SELECT id_ventas FROM ventas WHERE id_cliente='" + idusuario + "'  ", this.cnn);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable venta = new DataTable();
                adap.Fill(venta);
                return venta;
            }
            else
                return null;
        }

        public  DataTable usuario(string correo, string contrasena)
        {
            if (conectar() == true)
            {
                SqlCommand cmd = new SqlCommand("SELECT id_usuario,tipo_usuario,estado,usuario,correo,contrasena FROM usuarios WHERE correo='" + correo + "' AND contrasena ='" + Utilerias.Encriptar(contrasena) + "'", this.cnn);
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                DataTable usuarios = new DataTable();
                adt.Fill(usuarios);
                return usuarios;
            }
            return null;
          
  
        }
        public DataTable usuario3(string id ,string contrasena)
        {
            if (conectar() == true)
            {
              
                SqlCommand cmd = new SqlCommand("SELECT id_usuario,correo,contrasena FROM usuarios WHERE id_usuario ='"+id+"' AND  contrasena ='" +Utilerias.Encriptar(contrasena)+ "'",this.cnn);
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                DataTable usuarios = new DataTable();
                adt.Fill(usuarios);
                return usuarios;
            }
            return null;


        }

        public DataTable usuario2(string correo)
        {
            if (conectar() == true)
            {
                SqlCommand cmd = new SqlCommand("SELECT correo,contrasena FROM usuarios WHERE correo ='" +correo+ "'", this.cnn);
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                DataTable usuarios = new DataTable();
                adt.Fill(usuarios);
                return usuarios;
            }
            return null;


        }
      //******************
        public DataTable usuario1(string correo, string usuario)
        {
            if (conectar() == true)
            {
                SqlCommand cmd = new SqlCommand("SELECT id_usuario,usuario,correo FROM usuarios WHERE correo='" + correo + "' AND usuario ='" +usuario + "'", this.cnn);
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                DataTable usuarios = new DataTable();
                adt.Fill(usuarios);
                return usuarios;
            }
            return null;


        }

        public bool nota(string sql)
        {

                SqlCommand cmd = new SqlCommand(sql,this.cnn);
                SqlDataReader rdr = cmd.ExecuteReader();
                return rdr.Read();

        }
        //*********************

        public bool verificar(string correo, string contraseña)
        {
            if (conectar() == true)
            {
                string sql = "SELECT COUNT(*) FROM usuarios WHERE correo='"+correo+"' AND contrasena = '" + Utilerias.Encriptar(contraseña) + "' ";
                SqlCommand com = new SqlCommand(sql,this.cnn);
                int count = Convert.ToInt32(com.ExecuteScalar());
                if(count <= 0)
                    return false;
                else
                    return true;
            }
            return false;
        }
        public DataTable consultar(string sql)
        {
            if (conectar() == true)
            {
                SqlCommand cmd = new SqlCommand(sql, this.cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cerrarConexion();
                this.errores.Add("consultar => se ejecuto la sentencia: " + sql);
                return dt;
            }
            return null;
        }



        private bool cerrarConexion()
        {
            try
            {
                if (this.cnn.State != System.Data.ConnectionState.Closed)
                {
                    this.cnn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                errores.Add("Cerrar conexion => " + ex.InnerException + ": " + ex.Message);
            }
            return false;
        }

        public bool verificarCliente()
        {
            throw new NotImplementedException();
        }
    }
}
