using Business;
using Entity;
using System;

using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilities
{
    public class Ut_Cargas
    {
        SqlConnection cn = Controller.Conexion.getConexion();
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

     
        public void Inserta(DataGridView dt, string tabla)
        {
            switch (tabla)
            {
                case "CUADERNOS":
                    InsertCuadernos(dt);
                    break;
                case "CUADERNOS_PRODUCTOS":
                    InsertContactosMailing(dt);
                    break;
                case "MAILING":
                    InsertContactosMailing(dt);
                    break;
                default:
                    break;
            }
            
            
        }

        private void InsertContactosMailing(DataGridView dt)
        {
            En_Mailing m = new En_Mailing();

            foreach (DataGridViewRow i in dt.Rows)
            {
                try
                {
                    
                    SqlCommand cmd = new SqlCommand("Sp_Utilidades_Registra_Contactos_Mailing", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@EMAIL_RUT", SqlDbType.Int).Value = int.Parse(i.Cells["EMAIL_RUT"].Value.ToString());
                    cmd.Parameters.Add("@EMAIL_DV", SqlDbType.Char).Value = i.Cells["EMAIL_DV"].Value.ToString();
                    cmd.Parameters.Add("@EMAIL_NOMBRES", SqlDbType.VarChar).Value = i.Cells["EMAIL_NOMBRES"].Value.ToString();
                    DateTime nacimiento = DateTime.Parse(i.Cells["EMAIL_NACIMIENTO"].Value.ToString());
                    cmd.Parameters.Add("@EMAIL_NACIMIENTO", SqlDbType.Date).Value = nacimiento;
                    cmd.Parameters.Add("@EMAIL_CORREO", SqlDbType.VarChar).Value = i.Cells["EMAIL_CORREO"].Value.ToString();
                    cmd.Parameters.Add("@EMAIL_USUARIO_ID", SqlDbType.Int).Value = i.Cells["EMAIL_USUARIO_ID"].Value.ToString();
                    cmd.Parameters.Add("@EMAIL_ESTADO", SqlDbType.Char).Value = i.Cells["EMAIL_ESTADO"].Value.ToString();
                    cmd.Parameters.Add("@EMAIL_USR_SEND", SqlDbType.VarChar).Value = i.Cells["EMAIL_USR_SEND"].Value.ToString();


                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
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

        private void InsertCuadernos(DataGridView dt)
        {
            Bu_CuadernoOralne co = new Bu_CuadernoOralne();
            foreach (DataGridViewRow r in dt.Rows)
            {
                En_CuadernoOralne c = new En_CuadernoOralne();

                if (!r.Cells["NRO_CUADERNO"].Value.ToString().Equals(""))
                {
                    c.Opcion = 2;//opcion de registro para insert masivo de cuadernos.
                    c.NRO_CUADERNO = r.Cells["NRO_CUADERNO"].Value.ToString().ToUpper();
                    c.CLIENTE_NOMBRE = r.Cells["CLIENTE_NOMBRE"].Value.ToString().ToUpper();
                    c.CLIENTE_PATERNO = r.Cells["CLIENTE_PATERNO"].Value.ToString().ToUpper();
                    c.CLIENTE_MATERNO = r.Cells["CLIENTE_MATERNO"].Value.ToString().ToUpper();
                    DateTime nacimiento = DateTime.Parse(r.Cells["CLIENTE_NACIMIENTO"].Value.ToString());
                    c.CLIENTE_NACIMIENTO = nacimiento;
                    c.CLIENTE_DIRECCION = r.Cells["CLIENTE_DIRECCION"].Value.ToString().ToUpper();
                    c.CLIENTE_EMAIL = r.Cells["CLIENTE_EMAIL"].Value.ToString().ToUpper();
                    c.CLIENTE_FONO = r.Cells["CLIENTE_FONO"].Value.ToString().ToUpper();
                    c.CLIENTE_AUTORIZA_CONTACTO = char.Parse(r.Cells["CLIENTE_AUTORIZA_CONTACTO"].Value.ToString());
                    c.RECETA_NRO_BOLETA = int.Parse(r.Cells["RECETA_NRO_BOLETA"].Value.ToString());
                    DateTime fecha_compra = DateTime.Parse(r.Cells["RECETA_FECHA_COMPRA"].Value.ToString());
                    c.RECETA_FECHA_COMPRA = fecha_compra;
                    c.RECETA_FUNCIONARIO = r.Cells["RECETA_FUNCIONARIO"].Value.ToString().ToUpper();
                    c.RECETA_OBSERVACION = r.Cells["RECETA_OBSERVACION"].Value.ToString().ToUpper();
                    c.PRESCRIPTOR_MEDICO = int.Parse(r.Cells["CUADERNO_MEDICO_RUT"].Value.ToString());
                    c.PRESCRIPTOR_CENTRO_MEDICO = int.Parse(r.Cells["CUADERNO_INSTITUCION_ID"].Value.ToString());
                    DateTime fecha_registro = DateTime.Parse(r.Cells["FECHA_REGISTRO"].Value.ToString());
                    c.FECHA_REGISTRO = fecha_registro;
                    c.PRESCRIPTOR_FARMACIA = int.Parse(r.Cells["CUADERNO_FARMACIA_ID"].Value.ToString());
                    c.CUADERNO_USUARIO_ID = int.Parse(r.Cells["CUADERNO_USUARIO_ID"].Value.ToString());
                    co.RegistraCuaderno(c);
                    
                }
                
            }
        }
    }
}
