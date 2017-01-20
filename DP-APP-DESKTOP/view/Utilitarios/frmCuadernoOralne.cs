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
                txtLoteVenc.Text = "";
                txtCantidad.Text = "";
                cmbProductos.SelectedIndex = 0;
                //dgvProductos.Rows.Clear();

            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            CuadernoOralne c = new CuadernoOralne();
            Bu_CuadernoOralne co = new Bu_CuadernoOralne();
            Bu_GeneraPDF pdf = new Bu_GeneraPDF();

            if (txtNombres.Text == "")
            {
                MessageBox.Show("NOMBRE ES REQUERIDO");
                txtNombres.Focus();
            }
            else if (txtPaterno.Text == "")
            {
                MessageBox.Show("APELLIDO PATERNO ES REQUERIDO");
                txtPaterno.Focus();
            }
            else if (txtMaterno.Text == "")
            {
                MessageBox.Show("APELLIDO MATERNO ES REQUERIDO");
                txtMaterno.Focus();
            }
            else if (dgvProductos.Rows.Count == 0)
            {
                MessageBox.Show("DEBES REGISTRAR PRODUCTOS");
            }
            else
            {
            DialogResult resultado;
            resultado = MessageBox.Show("Desea Grabar y Generar PDF\n de lo Contrario Presione NO para solo Guardar", "", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                c.NRO_CUADERNO = lblNroCuaderno.Text;
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
                if (txtNroBoleta.Text != "")
                {
                    c.RECETA_NRO_BOLETA = int.Parse(txtNroBoleta.Text);
                }
                else
                {
                    c.RECETA_NRO_BOLETA = 0;
                }

                c.RECETA_FECHA_COMPRA = Convert.ToDateTime(dtpFechaCompra.Text);
                c.RECETA_FUNCIONARIO = txtFarmacia.Text.ToUpper();
                c.RECETA_OBSERVACION = txtObservaciones.Text.ToUpper();
                c.PRESCRIPTOR_MEDICO = txtMedico.Text.ToUpper();
                c.PRESCRIPTOR_CENTRO_MEDICO = txtCentroMedico.Text.ToUpper();
                c.PRESCRIPTOR_FARMACIA = txtFarmacia.Text.ToUpper();
                    //co.RegistraCuaderno(c);
                    ListasDatos l = new ListasDatos();
                    l.co.Add(c);
                    //pdf.GeneraCuaderno(l);


                foreach (DataGridViewRow r in dgvProductos.Rows)
                {
                    CuadernoOralneProducto p = new CuadernoOralneProducto();
                    p.PRODUCTO_MAESTRO_CODIGO = Convert.ToInt32(r.Cells["CODIGO"].Value);
                    p.NOMBRE= r.Cells["NOMBRE"].Value.ToString();
                    p.LOTE = r.Cells["LOTE"].Value.ToString();
                    p.Nro_Cuaderno = int.Parse(lblNroCuaderno.Text);

                    p.Cantidad = int.Parse(r.Cells["CANTIDAD"].Value.ToString());
                    //co.RegistraCuadernoProducto(p);
                    l.cop.Add(p);
                }
                    pdf.GeneraCuaderno(l);
                    limpiarFormulario();

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
                if (txtNroBoleta.Text != "")
                {
                    c.RECETA_NRO_BOLETA = int.Parse(txtNroBoleta.Text);
                }
                else
                {
                    c.RECETA_NRO_BOLETA = 0;
                }

                c.RECETA_FECHA_COMPRA = Convert.ToDateTime(dtpFechaCompra.Text);
                c.RECETA_FUNCIONARIO = txtFarmacia.Text.ToUpper();
                c.RECETA_OBSERVACION = txtObservaciones.Text.ToUpper();
                c.PRESCRIPTOR_MEDICO = txtMedico.Text.ToUpper();
                c.PRESCRIPTOR_CENTRO_MEDICO = txtCentroMedico.Text.ToUpper();

                co.RegistraCuaderno(c);

                foreach (DataGridViewRow r in dgvProductos.Rows)
                {
                    CuadernoOralneProducto p = new CuadernoOralneProducto();
                    p.PRODUCTO_MAESTRO_CODIGO = Convert.ToInt32(r.Cells["CODIGO"].Value);
                    p.LOTE = r.Cells["LOTE"].Value.ToString();
                    p.Nro_Cuaderno = int.Parse(lblNroCuaderno.Text);
                    co.RegistraCuadernoProducto(p);
                }
                limpiarFormulario();
            }
        }
                    

            
            
            
        }


        private void limpiarFormulario()
        {
            txtNombres.Text = "";
            txtPaterno.Text = "";
            txtMaterno.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            txtFono.Text = "";
            txtMedico.Text = "";
            txtCentroMedico.Text = "";
            txtFarmacia.Text = "";
            txtNroBoleta.Text = "";
            cmbProductos.SelectedIndex = 0;
            txtLoteVenc.Text = "";
            txtCantidad.Text = "";
            txtObservaciones.Text = "";
            dgvProductos.Rows.Clear();
            if (checkNO.Checked || checkSI.Checked)
            {
                checkSI.Checked = false;
                checkNO.Checked = false;
            }
            txtNombres.Focus();
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

        private void btnEliminaGrid_Click(object sender, EventArgs e)
        {
            dgvProductos.Rows.RemoveAt(dgvProductos.CurrentRow.Index);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtNroBoleta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
