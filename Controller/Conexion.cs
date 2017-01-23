using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class Conexion
    {
        public static SqlConnection getConexion()
        {
            try
            {
                string archivoExiste = "C:\\DP-APP-DESKTOP\\conecta.ini";
                string leer;
                FileStream fs_inv = new FileStream(archivoExiste, FileMode.Open);
                StreamReader sr_inv = new StreamReader(fs_inv);
                leer = sr_inv.ReadLine();
                sr_inv.Close();
                SqlConnection cn = new SqlConnection(@"" + leer + "");
                return cn;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al conectar o no Existe Archivo de Conexion", ex);
            }
        }
    }
}
