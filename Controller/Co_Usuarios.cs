using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;
using System.Data;

namespace Controller
{
    public class Co_Usuarios
    {
        SqlConnection cn = Conexion.getConexion();
        public DataTable CargaUsuarios()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_CargaUsuarios", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return dt;
        }
        public DataTable Busca_Usuario(string us, string pw)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_ObtieneUsuario", cn);
                cmd.Parameters.Add("@us", SqlDbType.Int).Value = us;
                cmd.Parameters.Add("@pw", SqlDbType.Int).Value = pw;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return dt;
        }
    }
}
