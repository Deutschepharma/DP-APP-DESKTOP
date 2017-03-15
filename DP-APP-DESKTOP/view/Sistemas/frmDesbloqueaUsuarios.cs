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
    public partial class frmDesbloqueaUsuarios : Form
    {
        Bu_Usuarios u;
        public frmDesbloqueaUsuarios()
        {
            InitializeComponent();
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            u = new Bu_Usuarios();
            u.UsuarioDesbloquea(dgEstados.CurrentRow.Index);
        }

        private void frmDesbloqueaUsuarios_Load(object sender, EventArgs e)
        {
            u = new Bu_Usuarios();
            dgEstados.DataSource = u.CargaUsuariosEstados();
        }
    }
}
