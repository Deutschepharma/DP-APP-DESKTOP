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
    public partial class frmCuadernoEspecialidad : Form
    {
        public bool respuesta = false;
        public frmCuadernoEspecialidad()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (txtCodigo.Text.Trim()!=""&& txtDescripcion.Text.Trim() != "")
            {
                Bu_CuadernoOralne c = new Bu_CuadernoOralne();
                if (c.CuadernoRegistraEspecialidad(txtCodigo.Text,txtDescripcion.Text)==1)
                {
                    MessageBox.Show("Registro Completo");
                    respuesta = true;
                    Dispose();
                }
                else
                {
                    MessageBox.Show("Especialidad a Registrar ya Existe\nPor Favor Valide!!!");
                }

            }
            else
            {
                MessageBox.Show("Debe Crear Codigo y Descripon antes de Registrar");
            }
        }
    }
}
