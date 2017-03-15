using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;
using System.Data;
using Entity;

namespace Controller
{
    public class Co_Menus
    {
        SqlConnection cn = Conexion.getConexion();
        public DataTable Menu_Asignados(int id, bool estado)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Carga_Menus", cn);
                cmd.Parameters.Add("@usuario_id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@estado", SqlDbType.Bit).Value = estado;
                
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
        public DataTable Menu_Usuario(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Carga_Menus_Usuarios", cn);
                cmd.Parameters.Add("@usuario_id", SqlDbType.Int).Value = id;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }
        public int Asigna_Menu(int usuario_id, int menu_sistema, bool estado_id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Usuario_Asigna_Menu", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@usuario_id", SqlDbType.Int).Value = usuario_id;
                cmd.Parameters.Add("@menu_sistema_id", SqlDbType.Int).Value = menu_sistema;
                cmd.Parameters.Add("@usuario_estado", SqlDbType.Bit).Value = estado_id;

                try
                {
                    cn.Open();
                    
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    cn.Close();
                    cmd.Dispose();
                }
            }
            catch (Exception exx)
            {
                throw new Exception(exx.Message);
            }
        }









    }
}
