using Business;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP_APP_DESKTOP.view.Sistemas
{
    public partial class frmRegistraUsuario : Form
    {
        public List<En_Usuarios> usuarios = new List<En_Usuarios>();
        public frmRegistraUsuario()
        {
            InitializeComponent();
        }
        private void CargaBox(ComboBox cb, int flag, int cmbFlag)
        {
            Bu_Usuarios box = new Bu_Usuarios();
            DataTable dt = box.CargarComboBox(flag, cmbFlag);
            cb.DataSource = dt;
            cb.DisplayMember = "Nombre";
            cb.ValueMember = "Codigo";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Bu_Usuarios bu = new Bu_Usuarios();
            En_Usuarios u = new En_Usuarios();
            u.nombre = txtNombre.Text.Trim().ToUpper();
            u.apellido = txtApellido.Text.Trim().ToUpper();
            u.us = txtUs.Text.Trim().ToUpper();
            u.tipo_us = int.Parse(cmbTipoUser.SelectedValue.ToString());
            int k = bu.UsuarioRegistraNuevo(u);
            if (k > 1)
            {
                //int id = bu.UsuarioRegistraNuevo(u);

                Bu_Menus me = new Bu_Menus();
                DataTable dt = me.Lista_Todos_Menus();
                foreach (DataRow i in dt.Rows)
                {
                    int mnu = int.Parse(i["ID"].ToString());
                    
                    bu.UsuarioRegistraListadoMenus(mnu,k);
                }
                Dispose();
            }
            else
            {
                MessageBox.Show("Usuario Existe Valide");
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtUs.Text = "";
                cmbTipoUser.SelectedIndex = 0;
                txtNombre.Focus();
            }
            
        }

        private void frmRegistraUsuario_Load(object sender, EventArgs e)
        {
            CargaBox(cmbTipoUser, 9, 0);
        }
        //private void CargaUsuarios()
        //{
        //    Bu_Usuarios bu = new Bu_Usuarios();

        //    foreach (DataRow dt in bu.CargaUsuarios().Rows)
        //    {
        //        En_Usuarios us = new En_Usuarios();
        //        us.id = int.Parse(dt["id"].ToString());
        //        us.us = dt["us"].ToString();
        //        us.pw = dt["pw"].ToString();
        //        us.nombre = dt["nombre"].ToString();
        //        us.tipo_us = int.Parse(dt["tipo_usuario_id"].ToString());
        //        us.estado_usuario_id = char.Parse(dt["estado_usuario_id"].ToString());
        //        usuarios.Add(us);
        //    }
        //}
        //private bool BuscarRegistros(string us)
        //{
        //    bool ok = false;
        //    var query = from user in usuarios
        //                where user.us == us
        //                select user;
        //    foreach (var i in query)
        //    {
        //        if (i.us == txtUs.Text.Trim().ToUpper())
        //        {
        //            MessageBox.Show("Usuario Existe Valide");
        //        }
        //        else
        //        {
        //            ok = true;
        //        }

        //    }
        //    return ok;

        //}


    }
}
