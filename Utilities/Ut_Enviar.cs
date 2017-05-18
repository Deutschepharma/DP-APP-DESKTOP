using Controller;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Ut_Enviar
    {
        SqlConnection cn = Conexion.getConexion();

        

        //public ComboBox cmbUsuario { get; set; }
        //public ComboBox cmbBase { get; set; }

        //public Enviar(string para, string to, string subjet, string cuerpo, string ruta, string response, string clave, string smtpCuenta, int pto, bool ssl, string usuario)
        //{
        //    this.para = para;
        //    this.to = to;
        //    this.subjet = subjet;
        //    this.cuerpo = cuerpo;
        //    this.ruta = ruta;
        //    this.response = response;
        //    this.clave = clave;
        //    this.smtpCuenta = smtpCuenta;
        //    this.pto = pto;
        //    this.ssl = ssl;
        //    this.usuario = usuario;
        //    Envio();
        //}

        public void Envio(En_Mailing m)
        {
            cn.Close();
            //string log;
            string html;
            try
            {
                MailMessage mensaje = new MailMessage(m.response, m.to);

                mensaje.Subject = m.subjet;
                string Titulo = @"<h4>" + "Estimado(a): " + m.para + "</h4>";
                string Cuerpo = "<p>" + m.cuerpo + "</p>";
                string logo = @"<img src=""cid:logo""/><br />";
                if (m.para!=null)
                {
                    html = Titulo + Cuerpo + logo;
                }
                else
                {
                    html = Cuerpo + logo;
                }

                AlternateView htmlView = AlternateView.CreateAlternateViewFromString(html, Encoding.UTF8, MediaTypeNames.Text.Html);

                if (m.ruta != "")
                {
                    LinkedResource img = new LinkedResource(m.ruta);
                    img.ContentId = "logo";
                    htmlView.LinkedResources.Add(img);
                }
                mensaje.AlternateViews.Add(htmlView);
                SmtpClient smtp = new SmtpClient(m.smtpCuenta, m.pto);
                smtp.EnableSsl = m.ssl;
                smtp.Credentials = new NetworkCredential(m.response, m.clave);
                try
                {
                    smtp.Send(mensaje);
                    switch (m.usuario)
                    {
                        case "ISIS_P":
                            CambiaEstado(m.to, "E", 1);
                            break;
                        case "DOUGLAS_P":
                            CambiaEstado(m.to, "E", 1);
                            break;
                        case "JOANNA_P":
                            CambiaEstado(m.to, "E", 1);
                            break;
                        default:
                            CambiaEstado(m.to, "E", 0);
                            break;
                    }
                }
                catch (Exception e)
                {
                    //aqui caen los errores de tipo ascii
                    switch (m.usuario)
                    {
                        case "ISIS_P":
                            CambiaEstado(m.to, "X", 1);
                            InsertaError(m.to, e.ToString(), "X");
                            break;
                        case "DOUGLAS_P":
                            CambiaEstado(m.to, "X", 1);
                            InsertaError(m.to, e.ToString(), "X");
                            break;
                        case "JOANNA_P":
                            CambiaEstado(m.to, "X", 1);
                            InsertaError(m.to, e.ToString(), "X");
                            break;
                        default:
                            CambiaEstado(m.to, "X", 0);
                            InsertaError(m.to, e.ToString(), "X");
                            break;
                    }
                }

            }
            catch (Exception ex)
            {
                switch (m.usuario)
                {
                    case "ISIS_P":
                        CambiaEstado(m.to, "F", 1);
                        InsertaError(m.to, ex.ToString(), "F");
                        break;
                    case "DOUGLAS_P":
                        CambiaEstado(m.to, "F", 1);
                        InsertaError(m.to, ex.ToString(), "F");
                        break;
                    case "JOANNA_P":
                        CambiaEstado(m.to, "F", 1);
                        InsertaError(m.to, ex.ToString(), "F");
                        break;
                    default:
                        CambiaEstado(m.to, "F", 0);
                        InsertaError(m.to, ex.ToString(), "F");
                        break;
                }
            }

        }
        private void InsertaError(string to, string error, string tipo)
        {
            string log;
            log = @"insert into MAILING_LOG values ('" + to + "',GETDATE(), '" + tipo + "','" + error + "')";
            SqlCommand cmd = new SqlCommand(log, cn);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void CambiaEstado(string to, string estado, int tipo)
        {
            string Consulta;
            switch (tipo)
            {
                case 1:
                    Consulta = @"update MAILING set EMAIL_ESTADO='" + estado + "' where EMAIL_CORREO='" + to + "' ";
                    break;
                default:
                    Consulta = @"update MAILING set EMAIL_ESTADO='" + estado + "' where EMAIL_CORREO='" + to + "'";
                    break;
            }
            SqlCommand cmd = new SqlCommand(Consulta, cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public SqlDataReader CargaEnviar(string QueryEnvio)
        {
            cn.Close();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = cn;
            cmd.CommandText = QueryEnvio;
            cmd.CommandType = CommandType.Text;
            cn.Open();
            dr = cmd.ExecuteReader();
            return dr;
            
        }
            



    }
}
