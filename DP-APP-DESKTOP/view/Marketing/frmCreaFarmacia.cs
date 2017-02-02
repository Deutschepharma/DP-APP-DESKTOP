using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP_APP_DESKTOP.view.Marketing
{
    public partial class frmCreaFarmacia : Form
    {
        public bool respuesta = false;
        public frmCreaFarmacia()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtFarmacia.Text.Trim()!="")
            {

            }
            else
            {
                MessageBox.Show("Debes Ingresar un nombre de farmacia");
            }
        }
    }
}
