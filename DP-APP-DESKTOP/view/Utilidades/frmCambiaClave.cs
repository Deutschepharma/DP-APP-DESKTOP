using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP_APP_DESKTOP.view.Utilidades
{
    public partial class frmCambiaClave : Form
    {
        public frmCambiaClave()
        {
            InitializeComponent();
        }

        private void btnCambia_Click(object sender, EventArgs e)
        {
            if (txtClave.Text.Trim().ToUpper() == txtClaveRep.Text.Trim().ToUpper())
            {
                Bu_Usuarios u = new Bu_Usuarios();
                u.UsuarioCambiaClave(frmLogin.id, txtClave.Text.ToUpper());
                Dispose();
            }
            else
            {
                MessageBox.Show("Ambas claves deben ser iguales."); 
            }
        }
    }
}
