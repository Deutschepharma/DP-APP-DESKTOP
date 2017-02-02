using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;
using System.Data.SqlClient;

namespace Controller
{
    public class Co_Inventario_Diario
    {
        SqlConnection cn = Conexion.getConexion();
        public int RegistraInventario(En_CargaMatVta mv)
        {
            
            try
            {

                SqlCommand cmd = new SqlCommand("Sp_Registro_MaterialVentas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@bodega", SqlDbType.VarChar).Value = mv.bodega;
                cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = mv.codigo;
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = mv.descripcion;
                cmd.Parameters.Add("@lote", SqlDbType.VarChar).Value = mv.lote;
                cmd.Parameters.Add("@vencimiento", SqlDbType.Date).Value = DateTime.Parse(mv.vencimiento);
                cmd.Parameters.Add("@unidades", SqlDbType.Float).Value = float.Parse(mv.unidades);


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
        public int RegistraMatEnv(En_CargaMatEnv me)
        {

            try
            {

                SqlCommand cmd = new SqlCommand("Sp_Registro_MaterialEnvases", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = me.codigo;
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = me.descripcion;
                cmd.Parameters.Add("@bodega", SqlDbType.VarChar).Value = me.bodega;
                cmd.Parameters.Add("@unidades", SqlDbType.Float).Value = float.Parse(me.unidades);


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
