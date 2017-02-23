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
    public partial class frmCreaInstitucion : Form
    {
        public bool respuesta = false;
        public frmCreaInstitucion()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Bu_CuadernoOralne c = new Bu_CuadernoOralne();
            string nombre = txtIntitucion.Text.Trim().ToUpper();
            string direccion = txtDireccion.Text.Trim().ToUpper();
            string fono = txtFono.Text.Trim().ToUpper();

            if (txtIntitucion.Text.Trim()!="")
            {
                if (c.CuadernoRegistraInstitucion(nombre,direccion,fono)==1)
                {
                    MessageBox.Show("Registro Completo");
                    respuesta = true;
                    Dispose();
                }
                else
                {
                    MessageBox.Show("Registro Existe Valide!!!");
                    txtIntitucion.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe Ingresar un nombre de Institución");
            }
        }
    }
}
