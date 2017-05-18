using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using System.Data.SqlClient;
using Utilities;
using System.Threading;

namespace DP_APP_DESKTOP.view.Utilidades
{
    public partial class frmMailing : Form
    {
        List<En_Cliente_Correo> listadoMail = new List<En_Cliente_Correo>();
        Ut_Enviar en = null; 

        int j = 0;
        string response;
        string clave;
        string smtpCuenta;
        int pto;
        bool ssl;
        string QueryEnvio;
        public frmMailing()
        {
            InitializeComponent();
        }

        private void btnAbrirArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Imagenes a Subir";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtArchivo.Text = open.FileName;
            }
            open.Dispose();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            btnEnviar.Enabled = false;
            if (cmbUsuario.Text != "" && cmbCuentaRemitente.Text != "")
            {
                en = new Ut_Enviar();
                SqlDataReader dr = en.CargaEnviar(QueryEnvio);
                while (dr.Read())
                {
                    En_Cliente_Correo cli = new En_Cliente_Correo();
                    switch (cmbUsuario.Text)
                    {
                        case "ISIS":
                            cli.email = dr.GetString(dr.GetOrdinal("EMAIL_CORREO"));
                            listadoMail.Add(cli);
                            break;
                        case "ISIS_P":
                            cli.nombres = dr.GetString(dr.GetOrdinal("EMAIL_NOMBRES"));
                            cli.email = dr.GetString(dr.GetOrdinal("EMAIL_CORREO"));
                            listadoMail.Add(cli);
                            break;
                        //case "DOUGLAS_P":
                        //    cli.nombres = dr.GetString(dr.GetOrdinal("EMAIL_NOMBRES"));
                        //    cli.email = dr.GetString(dr.GetOrdinal("EMAIL_CORREO"));
                        //    listadoMail.Add(cli);
                        //    break;
                        //case "JOANNA_P":
                        //    cli.nombres = dr.GetString(dr.GetOrdinal("EMAIL_NOMBRES"));
                        //    cli.email = dr.GetString(dr.GetOrdinal("EMAIL_CORREO"));
                        //    listadoMail.Add(cli);
                        //    break;
                        default:
                            break;
                    }
                }

                foreach (En_Cliente_Correo c in listadoMail)
                {
                    En_Mailing m = new En_Mailing();

                    m.para = c.nombres;
                    m.to = c.email;
                    m.subjet = txtAsunto.Text.Trim();

                    m.cuerpo = txtCuerpo.Text.Trim();
                    m.ruta = @"" + txtArchivo.Text.Trim() + "";
                    m.response = response;
                    m.clave = clave;
                    m.smtpCuenta = smtpCuenta;
                    m.pto = pto;
                    m.ssl = ssl;
                    m.usuario = cmbUsuario.Text;

                    //Ut_Enviar send = new cli(para, to, subjet, cuerpo, ruta, response, clave, smtpCuenta, pto, ssl, cmbUsuario.Text);
                    en.Envio(m);
                    Thread.Sleep(50000);
                    bar.PerformStep();
                }
                MessageBox.Show("Envio Completado.");
                
                //limpiarPantalla();
            }
            else
            {
                MessageBox.Show("NO HA SELECCIONADO UNA BASE O CUENTA REMITENTE");
                btnEnviar.Enabled = true;
            }
        }

        private void cmbCuentaRemitente_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbCuentaRemitente.Text)
            {
                case "GOOGLE":
                    response = "response.deutschepharma@gmail.com";
                    clave = "Deutsche2016";
                    smtpCuenta = "smtp.gmail.com";
                    pto = 587;
                    ssl = true;
                    break;
                //case "USYS":
                //    response = "response@usystem.cl";
                //    clave = "deu#2016";
                //    smtpCuenta = "mail.usystem.cl";
                //    pto = 25;
                //    ssl = false;

                 //   break;
                case "SUNWORK":
                    response = "contacto@sunwork.cl";
                    clave = "Chile.123";
                    smtpCuenta = "mail.sunwork.cl";
                    pto = 25;
                    ssl = false;

                    break;
                default:
                    break;
            }
        
    }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            QueryEnvio = "";
            switch (cmbUsuario.Text)
            {
                case "ISIS":
                    string conta1 = "select count(*) 'No enviado' from MAILING where EMAIL_ESTADO='N' and EMAIL_USR_SEND = '" + cmbUsuario.Text + "' ";
                    contarEnvio(conta1);
                    QueryEnvio = "select * from MAILING where EMAIL_USR_SEND = '" + cmbUsuario.Text.Trim() + "' and EMAIL_ESTADO = 'N' ";

                    break;
                //case "DOUGLAS":
                //    string conta2 = "select count(*) 'No enviado' from email where estado='N' and MAIL_USR_SEND = '" + cmbUsuario.Text + "' ";
                //    contarEnvio(conta2);
                //    QueryEnvio = "select * from email where MAIL_USR_SEND = '" + cmbUsuario.Text.Trim() + "' and estado = 'N' ";
                //    break;
                //case "ISIS_P":
                //    string conta3 = "select count(*) 'No enviado' from EmailPersonalizado where MAIL_USR_SEND = '" + cmbUsuario.Text.Trim() + "' and estado = 'N' ";
                //    contarEnvio(conta3);
                //    QueryEnvio = "select * from EmailPersonalizado where MAIL_USR_SEND = '" + cmbUsuario.Text.Trim() + "' and estado = 'N' ";

                //    break;
                //case "DOUGLAS_P":
                //    string conta4 = "select count(*) 'No enviado' from EmailPersonalizado where MAIL_USR_SEND = '" + cmbUsuario.Text.Trim() + "' and estado = 'N' ";
                //    contarEnvio(conta4);
                //    QueryEnvio = "select * from EmailPersonalizado where MAIL_USR_SEND = '" + cmbUsuario.Text.Trim() + "' and estado = 'N' ";
                //    break;
                //case "JOANNA_P":
                //    string conta5 = "select count(*) 'No enviado' from EmailPersonalizado where MAIL_USR_SEND = '" + cmbUsuario.Text.Trim() + "' and estado = 'N' ";
                //    contarEnvio(conta5);
                //    QueryEnvio = "select * from EmailPersonalizado where MAIL_USR_SEND = '" + cmbUsuario.Text.Trim() + "' and estado = 'N' ";
                //    break;
                default:
                    break;
            }
        }
        private void contarEnvio(string recibeQuery)
        {
            
            
            lblEnviar.Text = "";
            //SqlCommand comando = new SqlCommand();
            //SqlDataReader dr;
            //comando.Connection = cn;
            //comando.CommandText = recibeQuery;
            //comando.CommandType = CommandType.Text;
            //cn.Open();

            //dr = comando.ExecuteReader();
            en = new Ut_Enviar();
            SqlDataReader dr = en.CargaEnviar(recibeQuery);

            int countEnviar = 0;
            if (dr.Read() == true)
            {
                countEnviar = Convert.ToInt32(dr["No enviado"].ToString());
            }
            lblEnviar.Text = countEnviar.ToString();

            bar.Minimum = 0;
            bar.Maximum = countEnviar;
            bar.Step = 1;
            
        }

        private void frmMailing_Load(object sender, EventArgs e)
        {
            cmbCuentaRemitente.Items.Add("SUNWORK");
            cmbCuentaRemitente.Items.Add("GOOGLE");
            cmbUsuario.Items.Add("ISIS");
        }
        

    }
}
