using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP_APP_DESKTOP
{
    public partial class frmLogin : Form
    {
        public static string id, user;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            id = "1";
            user = "Abdon";
            frm.Show();
            this.Hide();
            
           
        }
    }
}
