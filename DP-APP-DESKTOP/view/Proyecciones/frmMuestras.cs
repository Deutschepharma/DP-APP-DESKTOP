using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace DP_APP_DESKTOP.view
{
    public partial class frmMuestras : Form
    {
        public frmMuestras()
        {
            InitializeComponent();
        }
        private void CargaBox(ComboBox cb, int flag, int cmbFlag)
        {
            Bu_Muestras box = new Bu_Muestras();
            DataTable ds = box.CargaCombos(flag, cmbFlag);
            cb.DataSource = ds;
            cb.DisplayMember = "Nombre";
            cb.ValueMember = "Codigo";
        }
        private void frmMuestras_Load(object sender, EventArgs e)
        {
            CargaBox(cmbAño, 1, 0);
        }

        private void btnPruebas_Click(object sender, EventArgs e)
        {
    

        }

        private void cmbAño_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
