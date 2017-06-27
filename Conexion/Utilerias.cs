using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Conexion
{
    public class Utilerias
    {
        public static string Encriptar(string cadena)
        {
            cadena += ""; //A esto se le llama token, semilla 
            SHA1 encriptar = SHA1CryptoServiceProvider.Create();
            Byte[] texto_original = ASCIIEncoding.Default.GetBytes(cadena);
            Byte[] texto_encriptado = encriptar.ComputeHash(texto_original);
            StringBuilder stream = new StringBuilder();

            foreach (byte i in texto_encriptado)
            {
                stream.AppendFormat("{0:x2}", i);
            }

            return stream.ToString();
        }
    }
}
