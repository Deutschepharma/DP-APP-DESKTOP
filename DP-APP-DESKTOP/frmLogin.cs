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
using Business;
namespace DP_APP_DESKTOP
{
    public partial class frmLogin : Form
    {
        public int contadorIntentos = 1; 
        public static string id, user;
        public List<En_Usuarios> usuarios = new List<En_Usuarios>();

        public frmLogin()
        {
            InitializeComponent();
            CargaUsuarios();

        }

        private void CargaUsuarios()
        {
            Bu_Usuarios bu = new Bu_Usuarios();
            //DataTable dt = bu.CargaUsuarios();

            foreach (DataRow dt in bu.CargaUsuarios().Rows)
            {
                En_Usuarios us = new En_Usuarios();
                us.us = dt["us"].ToString();
                us.pw = dt["pw"].ToString();
                us.nombre = dt["nombre"].ToString();
                us.tipo_us = int.Parse(dt["tipo_usuario_id"].ToString());
                us.estado_usuario_id = char.Parse(dt["estado_usuario_id"].ToString());
                usuarios.Add(us);
            }


        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            BuscarRegistros(txtUs.Text.Trim().ToUpper(), txtPw.Text.Trim().ToUpper());

        }

        private void BuscarRegistros(string us, string pw)
        {
            var query = from user in usuarios
                        where user.us == us //&& user.pw== pw
                        select user;
            foreach (var i in query)
            {
                if (i.pw == pw)
                {
                    switch (i.estado_usuario_id)
                    {
                        case '1':
                            MessageBox.Show("Usuario se Encuentra Logeado Favor Validar");
                            limpiar();
                            break;
                        case '2':
                            MessageBox.Show("Usuario se Encuentra Bloqueado Informar a Sistemas");
                            limpiar();
                            break;
                        case '3':
                            MessageBox.Show("Usuario se Encuentra Desvinculado de la Empresa");
                            limpiar();
                            break;
                        default:
                            frmPrincipal frm = new frmPrincipal();
                            id = i.tipo_us.ToString();
                            user = i.nombre;
                            frm.Show();
                            this.Hide();
                            us = "";
                            pw = "";
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Clave Incorrecta \n Intentos " + contadorIntentos.ToString() + " de 5");
                    contadorIntentos++;
                    txtPw.Text = "";
                    txtUs.Focus();
                }
            }
          
            
        }

        private void txtPw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToInt32(Keys.Enter))
            {
                BuscarRegistros(txtUs.Text.Trim().ToUpper(), txtPw.Text.Trim().ToUpper());
            }
        }

        private void limpiar()
        {
            txtUs.Text = "";
            txtPw.Text = "";
            txtUs.Focus();
        }
    }
}
