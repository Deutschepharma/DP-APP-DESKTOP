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
using Entity;

namespace DP_APP_DESKTOP.view
{
    public partial class frmCuadernoOralne : Form
    {
        public frmCuadernoOralne()
        {
            InitializeComponent();
        }
        private void CargaBox(ComboBox cb, int flag, int cmbFlag)
        {
            Bu_CuadernoOralne box = new Bu_CuadernoOralne();
            DataTable ds = box.CargaCombos(flag, cmbFlag);
            cb.DataSource = ds;
            cb.DisplayMember = "Nombre";
            cb.ValueMember = "Codigo";
        }
        private void btnAgrega_Click(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("SELECCIONE PRODUCTO");
            }
            else if (txtCantidad.Text.Trim() == "")
            {
                MessageBox.Show("DEBE INGRESAR CANTIDAD");
                txtCantidad.Focus();
            }
            else if (txtCantidad.Text.Trim() == "0")
            {
                MessageBox.Show("CANTIDAD NO PUEDE SER IGUAL A 0");
                txtCantidad.Focus();
            }
            else
            {
                dgvProductos.Rows.Add(cmbProductos.SelectedValue.ToString(), cmbProductos.Text, txtCantidad.Text, txtLoteVenc.Text);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            CuadernoOralne c = new CuadernoOralne();
            Bu_CuadernoOralne co = new Bu_CuadernoOralne();

            if (txtNombres.Text == "")
            {
                MessageBox.Show("NOMBRE ES REQUERIDO");
            }
            else if (txtPaterno.Text == "")
            {
                MessageBox.Show("APELLIDO PATERNO ES REQUERIDO");
            }
            else if(txtMaterno.Text == "")
            {
                MessageBox.Show("APELLIDO MATERNO ES REQUERIDO");
            }
            else
            {
                if (checkSI.Checked)
                {
                    c.CLIENTE_AUTORIZA_CONTACTO = 'S';
                }
                if (checkNO.Checked)
                {
                    c.CLIENTE_AUTORIZA_CONTACTO = 'N';
                }
                
                c.CLIENTE_NOMBRE = txtNombres.Text.ToUpper();
                c.CLIENTE_PATERNO = txtPaterno.Text.ToUpper();
                c.CLIENTE_MATERNO = txtMaterno.Text.ToUpper();
                c.CLIENTE_NACIMIENTO = Convert.ToDateTime(dtpNacimiento.Text);
                c.CLIENTE_DIRECCION = txtDireccion.Text.ToUpper();
                c.CLIENTE_EMAIL = txtEmail.Text.ToUpper();
                c.CLIENTE_FONO = txtFono.Text.ToUpper();
                c.RECETA_NRO_BOLETA = Convert.ToInt32(txtNroBoleta.Text.ToUpper());
                c.RECETA_FECHA_COMPRA = Convert.ToDateTime(dtpFechaCompra.Text);
                c.RECETA_FUNCIONARIO = txtFuncionario.Text.ToUpper();
                c.RECETA_OBSERVACION = txtObservaciones.Text.ToUpper();
                c.PRESCRIPTOR_MEDICO = txtMedico.Text.ToUpper();
                c.PRESCRIPTOR_CENTRO_MEDICO = txtCentroMedico.Text.ToUpper();
            }
                
            
        }

        private void frmCuadernoOralne_Load(object sender, EventArgs e)
        {
            CargaBox(cmbProductos, 2, 0);
            CargaNroCuaderno();
        }

        private void CargaNroCuaderno()
        {
            Bu_CuadernoOralne co = new Bu_CuadernoOralne();
            lblNroCuaderno.Text = co.ObtieneNroCuaderno().ToString();
        }

        private void checkSI_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSI.Checked)
            {
                checkNO.Checked = false;
            }
        }

        private void checkNO_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNO.Checked)
            {
                checkSI.Checked = false;
            }
        }
    }
}
