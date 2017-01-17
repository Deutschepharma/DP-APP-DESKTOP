using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Windows.Forms;

namespace Controller
{
    public class Co_CuadernoOralne
    {
        SqlConnection cn = Conexion.getConexion();

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
        public int RegistraCuaderno(CuadernoOralne c)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Registra_Cuaderno_Oralne", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CLIENTE_NOMBRE", SqlDbType.VarChar).Value = c.CLIENTE_NOMBRE;
                cmd.Parameters.Add("@CLIENTE_PATERNO", SqlDbType.VarChar).Value = c.CLIENTE_PATERNO;
                cmd.Parameters.Add("@CLIENTE_MATERNO", SqlDbType.VarChar).Value = c.CLIENTE_MATERNO;
                cmd.Parameters.Add("@CLIENTE_NACIMIENTO", SqlDbType.Date).Value = c.CLIENTE_NACIMIENTO;
                cmd.Parameters.Add("@CLIENTE_DIRECCION", SqlDbType.VarChar).Value = c.CLIENTE_DIRECCION;
                cmd.Parameters.Add("@CLIENTE_EMAIL", SqlDbType.VarChar).Value = c.CLIENTE_EMAIL;
                cmd.Parameters.Add("@CLIENTE_FONO", SqlDbType.VarChar).Value = c.CLIENTE_FONO;
                cmd.Parameters.Add("@CLIENTE_AUTORIZA_CONTACTO", SqlDbType.Char).Value = c.CLIENTE_AUTORIZA_CONTACTO;
                cmd.Parameters.Add("@RECETA_NRO_BOLETA", SqlDbType.Int).Value = c.RECETA_NRO_BOLETA;
                cmd.Parameters.Add("@RECETA_FECHA_COMPRA", SqlDbType.Date).Value = c.RECETA_FECHA_COMPRA;
                cmd.Parameters.Add("@RECETA_FUNCIONARIO", SqlDbType.VarChar).Value = c.RECETA_FUNCIONARIO;
                cmd.Parameters.Add("@RECETA_OBSERVACION", SqlDbType.VarChar).Value = c.RECETA_OBSERVACION;
                cmd.Parameters.Add("@PRESCRIPTOR_MEDICO", SqlDbType.VarChar).Value = c.PRESCRIPTOR_MEDICO;
                cmd.Parameters.Add("@PRESCRIPTOR_CENTRO_MEDICO", SqlDbType.VarChar).Value = c.PRESCRIPTOR_CENTRO_MEDICO;
                
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
        public int RegistraCuadernoProducto(CuadernoOralneProducto c)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Registra_Cuaderno_Oralne_Productos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@PRODUCTO_MAESTRO_CODIGO", SqlDbType.Int).Value = c.PRODUCTO_MAESTRO_CODIGO;
                cmd.Parameters.Add("@LOTE", SqlDbType.VarChar).Value = c.LOTE;
                cmd.Parameters.Add("@Nro_Cuaderno", SqlDbType.Int).Value = c.Nro_Cuaderno;


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
        public int ObtieneNroCuaderno()
        {
            try
            {
                
                SqlCommand cmd = new SqlCommand("Sp_Obtiene_NroCuaderno", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("@tipo_evento", SqlDbType.Int).Value = e.tipo_evento;
                ////cmd.Parameters.Add("@usuario_rut", SqlDbType.Int).Value = e.usuario_rut;
                //cmd.Parameters.Add("@cliente_rut", SqlDbType.Int).Value = e.cliente_rut;
                //cmd.Parameters.Add("@maquina_id", SqlDbType.Int).Value = e.maquina_id;
                //cmd.Parameters.Add("@detalle_evento", SqlDbType.VarChar).Value = e.detalle_eventos;
                //cmd.Parameters.Add("@id_user", SqlDbType.Int).Value = e.id_user;

                SqlParameter NroEvento = new SqlParameter("@NRO_CUADERNO", 0);
                NroEvento.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(NroEvento);

                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    int nro_evento = Int32.Parse(cmd.Parameters["@NRO_CUADERNO"].Value.ToString());
                    return nro_evento;
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
        public static void SoloNumeros(KeyPressEventArgs V)
        {
            if (Char.IsDigit(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (Char.IsSeparator(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }
            else
            {
                V.Handled = true;
            }

        }




    }
}
