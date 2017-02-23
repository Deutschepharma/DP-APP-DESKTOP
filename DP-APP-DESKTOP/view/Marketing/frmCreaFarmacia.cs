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
            Bu_CuadernoOralne c = new Bu_CuadernoOralne();
            if (txtFarmacia.Text.Trim()!="")
            {
                if (c.CuadernoRegistraFarmacia(txtFarmacia.Text.Trim().ToUpper())==1)
                {
                    MessageBox.Show("Registro Completo");
                    respuesta = true;
                    Dispose();
                }
                else
                {
                    MessageBox.Show("Registro Existe !!!");
                }
                
            }
            else
            {
                MessageBox.Show("Debes Ingresar un nombre de farmacia");
            }
        }
    }
}
