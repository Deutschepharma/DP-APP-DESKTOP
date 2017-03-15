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

namespace DP_APP_DESKTOP.view.Sistemas
{
    public partial class frmAsignaMenu : Form
    {
        Bu_Menus b;
        public frmAsignaMenu()
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
        private void cmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbUsuarios.SelectedIndex == 0)
                {
                    listarMenuSi(0, true);
                    listarMenuNo(0, false);
                }
                else
                {
                    listarMenuSi(int.Parse(cmbUsuarios.SelectedIndex.ToString()), true);
                    listarMenuNo(int.Parse(cmbUsuarios.SelectedIndex.ToString()), false);
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void listarMenuSi(int v1, bool v2)
        {
            b = new Bu_Menus();
            lsSi.SelectionMode = SelectionMode.MultiExtended;
            lsSi.DataSource = b.Menu_Asignados(v1, v2);
            lsSi.DisplayMember = "DESCRIPCION";
            lsSi.ValueMember = "ID";
        }

        private void listarMenuNo(int v1, bool v2)
        {
            b = new Bu_Menus();
            lsNo.SelectionMode = SelectionMode.MultiExtended;
            lsNo.DataSource = b.Menu_Asignados(v1, v2);
            lsNo.DisplayMember = "DESCRIPCION";
            lsNo.ValueMember = "ID";
        }

        private void frmAsignaMenu_Load(object sender, EventArgs e)
        {
            CargaBox(cmbUsuarios, 8, 0);
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            b = new Bu_Menus();
            foreach (DataRowView l in lsNo.SelectedItems)
            {
                b.Asigna_Menu(int.Parse(cmbUsuarios.SelectedIndex.ToString()), int.Parse(l[0].ToString()), true);
            }
            listarMenuSi(int.Parse(cmbUsuarios.SelectedIndex.ToString()), true);
            listarMenuNo(int.Parse(cmbUsuarios.SelectedIndex.ToString()), false);
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            b = new Bu_Menus();
            foreach (DataRowView l in lsSi.SelectedItems)
            {
                b.Asigna_Menu(int.Parse(cmbUsuarios.SelectedIndex.ToString()), int.Parse(l[0].ToString()), false);
            }
            listarMenuSi(int.Parse(cmbUsuarios.SelectedIndex.ToString()), true);
            listarMenuNo(int.Parse(cmbUsuarios.SelectedIndex.ToString()), false);
        }
    }
}
