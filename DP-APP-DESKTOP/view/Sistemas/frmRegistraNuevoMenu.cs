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
    public partial class frmRegistraNuevoMenu : Form
    {
        public frmRegistraNuevoMenu()
        {
            InitializeComponent();
        }

        private void frmRegistraNuevoMenu_Load(object sender, EventArgs e)
        {
            loadMenus();

        }

        private void loadMenus()
        {
            Bu_Menus b = new Bu_Menus();
            DataTable dt = b.Lista_Todos_Menus();
            lsMenus.SelectionMode = SelectionMode.MultiExtended;
            lsMenus.DataSource = b.Lista_Todos_Menus();
            lsMenus.DisplayMember = "DESCRIPCION";
            lsMenus.ValueMember = "ID";
        }

        private void btnGuardad_Click(object sender, EventArgs e)
        {
            Bu_Usuarios bu = new Bu_Usuarios();
            Bu_Menus mnu = new Bu_Menus();

            En_Menus m = new En_Menus();
            m.mnu_string = txtString.Text.Trim();
            m.descripcion = txtDescripcion.Text.Trim();
            int mnu_id = mnu.MenuRegistraNuevo(m);

            foreach (DataRow dt in bu.CargaUsuarios().Rows)
            {
                int id_user = int.Parse(dt["id"].ToString());
                bu.UsuarioRegistraListadoMenus(mnu_id, id_user);
            }
            txtDescripcion.Text = "";
            txtString.Text = "";
            txtString.Focus();
            loadMenus();
        }
    }
}
