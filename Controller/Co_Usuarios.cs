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
        public int UsuarioCambiaEstado(int id, int estado)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Usuario_Cambia_Estado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@estado", SqlDbType.Int).Value = estado;
                SqlParameter log = new SqlParameter("@log", 0);
                log.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(log);

                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    int error = Int32.Parse(cmd.Parameters["@log"].Value.ToString());
                    return error;
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
        public int UsuarioCambiaClave(int id, string clave)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Usuario_Cambia_Clave", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@clave", SqlDbType.VarChar).Value = clave;

                SqlParameter log = new SqlParameter("@log", 0);
                log.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(log);

                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    int error = Int32.Parse(cmd.Parameters["@log"].Value.ToString());
                    return error;
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
        public DataTable CargaUsuariosEstados()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Carga_Estados_Usuarios", cn);
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
        public int UsuarioDesbloquea(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Usuario_Desbloquea", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlParameter log = new SqlParameter("@log", 0);
                log.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(log);

                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    int error = Int32.Parse(cmd.Parameters["@log"].Value.ToString());
                    return error;
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
        //Cargara los Combos que se usen de usaurio
        public DataTable CargarComboBox(int flag, int ddlFlag)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Carga_Combo_Box", cn);
                cmd.Parameters.Add("@flag", SqlDbType.Int).Value = flag;
                cmd.Parameters.Add("@ddlFlag", SqlDbType.Int).Value = ddlFlag;
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
        public int UsuarioRegistraNuevo(En_Usuarios u)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Usuario_Registra_Nuevo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = u.nombre;
                cmd.Parameters.Add("@apellido", SqlDbType.VarChar).Value = u.apellido;
                cmd.Parameters.Add("@us", SqlDbType.VarChar).Value = u.us;
                cmd.Parameters.Add("@tipo_user", SqlDbType.Int).Value = u.tipo_us;

                SqlParameter log = new SqlParameter("@log", 0);
                log.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(log);

                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    int error = Int32.Parse(cmd.Parameters["@log"].Value.ToString());
                    return error;
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
        public int UsuarioRegistraListadoMenus(int id_menu, int id_usu)//modificar
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Usuario_Registra_Listado_Menu", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id_menu", SqlDbType.Int).Value = id_menu;
                cmd.Parameters.Add("@id_usu", SqlDbType.Int).Value = id_usu;

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
