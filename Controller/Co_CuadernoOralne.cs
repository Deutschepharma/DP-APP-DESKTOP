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
        public int RegistraCuaderno(En_CuadernoOralne c)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Registra_Cuaderno_Oralne", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@OPCION", SqlDbType.Int).Value = c.Opcion;
                cmd.Parameters.Add("@CUADERNO_NRO", SqlDbType.Int).Value = int.Parse(c.NRO_CUADERNO);
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
                cmd.Parameters.Add("@FECHA_REGISTRO", SqlDbType.Date).Value = c.FECHA_REGISTRO; 
                cmd.Parameters.Add("@PRESCRIPTOR_FARMACIA", SqlDbType.VarChar).Value = c.PRESCRIPTOR_FARMACIA;
                cmd.Parameters.Add("@CUADERNO_USUARIO_ID", SqlDbType.Int).Value = c.CUADERNO_USUARIO_ID;

                SqlParameter SqLog = new SqlParameter("@LOG", 0);
                SqLog.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(SqLog);

                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    int log = Int32.Parse(cmd.Parameters["@LOG"].Value.ToString());
                    return log;
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
        public int RegistraCuadernoProducto(En_CuadernoOralneProducto c)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Registra_Cuaderno_Oralne_Productos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@PRODUCTO_MAESTRO_CODIGO", SqlDbType.Int).Value = c.PRODUCTO_MAESTRO_CODIGO;
                cmd.Parameters.Add("@LOTE", SqlDbType.VarChar).Value = c.LOTE;
                cmd.Parameters.Add("@Nro_Cuaderno", SqlDbType.Int).Value = c.Nro_Cuaderno;
                cmd.Parameters.Add("@Cantidad", SqlDbType.Int).Value = c.Cantidad;
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
        public int CuadernoRegistraMedico(En_CuadernoRegistraMedico r)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Cuaderno_Registro_Medico", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@rut", SqlDbType.Int).Value = r.rut;
                cmd.Parameters.Add("@dv", SqlDbType.Char).Value = r.dv;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = r.nombre;
                cmd.Parameters.Add("@paterno", SqlDbType.VarChar).Value = r.paterno;
                cmd.Parameters.Add("@materno", SqlDbType.VarChar).Value = r.materno;
                cmd.Parameters.Add("@especialidad", SqlDbType.VarChar).Value = r.especialidad;
                cmd.Parameters.Add("@nacimiento", SqlDbType.Date).Value = r.nacimiento;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = r.email;
                cmd.Parameters.Add("@fono", SqlDbType.VarChar).Value = r.fono;

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
        public int CuadernoRegistraEspecialidad(string cod, string descripcion)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Registra_Cuaderno_Especialidad_Medica", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@cod", SqlDbType.VarChar).Value = cod;
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = descripcion;

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
        public int CuadernoRegistraInstitucion(string nombre, string direccion, string fono)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Registra_Cuaderno_Institucion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
                cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = direccion;
                cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = fono;

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
        public int CuadernoRegistraFarmacia(string nombre)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Registra_Cuaderno_Farmacia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;

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

        //reportes de cuaderno oralne
        public DataTable ListarCuadernos(int val)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Marketing_Listar_Registros", cn);
                cmd.Parameters.Add("@val", SqlDbType.VarChar).Value = val;
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
        public DataTable ListarProductos_NroCuaderno(int cod)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Marketing_Listar_Productos_NroCuaderno", cn);
                cmd.Parameters.Add("@nroCuaderno", SqlDbType.Int).Value = cod;
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
        public DataTable ListarCuaderno_Fecha(string fecDesde, string fecHasta)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Marketing_Listar_Cuaderno_Fecha", cn);
                cmd.Parameters.Add("@fecDesde", SqlDbType.VarChar).Value = fecDesde;
                cmd.Parameters.Add("@fecHasta", SqlDbType.VarChar).Value = fecHasta;
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
        public DataTable ListarCuadernos_Medico(int val)
        {//lista los cuadernos registrados y quedan en grilla pra poder dar clic por cuaderno y ver su informacion
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Marketing_Listar_Registros_Medico", cn);
                cmd.Parameters.Add("@val", SqlDbType.Int).Value = val;
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
        
        public DataTable ExportarData_Medico(int val)
        {//exporta la data en base a los productos comprador por cuaderno
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Marketing_Exportar_Data_Medico", cn);
                cmd.Parameters.Add("@val", SqlDbType.Int).Value = val;
                //cmd.Parameters.Add("@rutMedico", SqlDbType.Int).Value = rutMedico;
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


        public DataTable ExportarData_Fecha(string fecDesde, string fecHasta)
        {//exporta la data en base a los rangos de fechas seleccionados.
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Marketing_Exportar_Data_Cuaderno_Fecha", cn);
                cmd.Parameters.Add("@fecDesde", SqlDbType.VarChar).Value = fecDesde;
                cmd.Parameters.Add("@fecHasta", SqlDbType.VarChar).Value = fecHasta;
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

        public DataTable ListarCuadernos_Productos(int val)
        {//lista los cuadernos registrados filtrador por productos
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Marketing_Listar_Registros_Productos", cn);
                cmd.Parameters.Add("@val", SqlDbType.Int).Value = val;
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


        //Modificaciones del Cuaderno Beneficio 1+1 
        public DataTable Marketing_Buscar_NroCuaderno(int val)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Marketing_Buscar_NroCuaderno", cn);
                cmd.Parameters.Add("@nro_cuaderno", SqlDbType.VarChar).Value = val;
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
        public DataTable Marketing_Buscar_Productos_NroCuaderno(int val)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Marketing_Buscar_Productos_NroCuaderno", cn);
                cmd.Parameters.Add("@nro_cuaderno", SqlDbType.VarChar).Value = val;
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

        public int Marketing_Registra_Cuaderno_Producto(En_CuadernoOralneProducto c)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Marketing_Registra_Cuaderno_Producto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = c.PRODUCTO_MAESTRO_CODIGO;
                cmd.Parameters.Add("@nro_cuaderno", SqlDbType.Int).Value = c.Nro_Cuaderno;
                cmd.Parameters.Add("@lote", SqlDbType.VarChar).Value = c.LOTE;
                cmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = c.Cantidad;
                cmd.Parameters.Add("@flag", SqlDbType.Int).Value = c.flag;

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
        public int Marketing_Registra_Cuaderno(En_CuadernoOralne c)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Marketing_Registra_Cuaderno", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nro_cuaderno", SqlDbType.Int).Value = int.Parse(c.NRO_CUADERNO);
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = c.CLIENTE_NOMBRE;
                cmd.Parameters.Add("@paterno", SqlDbType.VarChar).Value = c.CLIENTE_PATERNO;
                cmd.Parameters.Add("@materno", SqlDbType.VarChar).Value = c.CLIENTE_MATERNO;
                cmd.Parameters.Add("@nacimiento", SqlDbType.Date).Value = c.CLIENTE_NACIMIENTO;
                cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = c.CLIENTE_DIRECCION;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = c.CLIENTE_EMAIL;
                cmd.Parameters.Add("@fono", SqlDbType.VarChar).Value = c.CLIENTE_FONO;
                cmd.Parameters.Add("@compra", SqlDbType.Date).Value = c.RECETA_FECHA_COMPRA;
                cmd.Parameters.Add("@observacion", SqlDbType.VarChar).Value = c.RECETA_OBSERVACION;

                SqlParameter SqLog = new SqlParameter("@log", 0);
                SqLog.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(SqLog);

                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    int log = Int32.Parse(cmd.Parameters["@log"].Value.ToString());
                    return log;
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
