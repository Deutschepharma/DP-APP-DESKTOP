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
        public int RegistraInventario(CargaInventario c)
        {
            
            try
            {

                SqlCommand cmd = new SqlCommand("Sp_Registro_Inventario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@bodega", SqlDbType.VarChar).Value = c.bodega;
                cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = c.codigo;
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = c.descripcion;
                cmd.Parameters.Add("@lote", SqlDbType.VarChar).Value = c.lote;
                cmd.Parameters.Add("@vencimiento", SqlDbType.Date).Value = DateTime.Parse(c.vencimiento);
                cmd.Parameters.Add("@unidades", SqlDbType.Float).Value = float.Parse(c.unidades);


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
        public int RegistraMatEnv(CargaInventario c)
        {

            try
            {

                SqlCommand cmd = new SqlCommand("Sp_Registro_MaterialEnvases", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = c.codigo;
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = c.descripcion;
                cmd.Parameters.Add("@bodega", SqlDbType.VarChar).Value = c.bodega;
                cmd.Parameters.Add("@unidades", SqlDbType.Float).Value = float.Parse(c.unidades);


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
