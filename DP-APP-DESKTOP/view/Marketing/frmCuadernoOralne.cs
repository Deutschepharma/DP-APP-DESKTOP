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
using Utilities;

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
            DataTable dt = box.CargaCombos(flag, cmbFlag);
            cb.DataSource = dt;
            cb.DisplayMember = "Nombre";
            cb.ValueMember = "Codigo";
        }

        //private void CargaAutoCompletar(ComboBox cb, int flag, int cmbFlag)
        //{
        //    Bu_CuadernoOralne box = new Bu_CuadernoOralne();
        //    DataTable dt = box.CargaCombos(flag, cmbFlag);
        //    cb.DataSource = dt;
        //    cb.DisplayMember = "nombre";
        //    cb.ValueMember = "id";
        //    cb.AutoCompleteCustomSource = Autocomplete(dt);
        //    cb.AutoCompleteMode = AutoCompleteMode.Suggest;
        //    cb.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //}
        //public static AutoCompleteStringCollection Autocomplete(DataTable data)
        //{
        //    DataTable dt = data;
        //    AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        coleccion.Add(Convert.ToString(row["nombre"]));
        //    }
        //    return coleccion;
        //}

        private void frmCuadernoOralne_Load(object sender, EventArgs e)
        {
            CargaBox(cmbProductos, 2, 0);
            CargaBox(cmbMedico, 5, 0);
            CargaBox(cmbFarmacia, 4, 0);
            CargaBox(cmbInstitucion, 6, 0);
            //CargaAutoCompletar(cmbFarmacia, 4, 0);
            ////CargaAutoCompletar(cmbMedico, 5, 0);
            //CargaAutoCompletar(cmbInstitucion, 6, 0);
            CargaNroCuaderno();
            txtNombres.Focus();
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

            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (checkSI.Checked)
            {
                En_CuadernoOralne c = new En_CuadernoOralne();
                Bu_CuadernoOralne co = new Bu_CuadernoOralne();
                Ut_GeneraPDF pdf = new Ut_GeneraPDF();
                //Bu_GeneraPDF pdf = new Bu_GeneraPDF();

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
                    c.Opcion = 1;
                    c.NRO_CUADERNO = lblNroCuaderno.Text;
                    c.CLIENTE_AUTORIZA_CONTACTO = 'S';
                    c.CLIENTE_NOMBRE = txtNombres.Text.ToUpper();
                    c.CLIENTE_PATERNO = txtPaterno.Text.ToUpper();
                    c.CLIENTE_MATERNO = txtMaterno.Text.ToUpper();
                    DateTime nacimiento = dtpNacimiento.Value.Date;
                    c.CLIENTE_NACIMIENTO = nacimiento;
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
                    DateTime fecha_compra = dtpFechaCompra.Value.Date;
                    c.RECETA_FECHA_COMPRA = fecha_compra;
                    c.RECETA_FUNCIONARIO = txtFuncionario.Text.ToUpper();
                    c.RECETA_OBSERVACION = txtObservaciones.Text.ToUpper();
                    c.PRESCRIPTOR_MEDICO = int.Parse(cmbMedico.SelectedValue.ToString());
                    c.PRESCRIPTOR_CENTRO_MEDICO = int.Parse(cmbInstitucion.SelectedValue.ToString());
                    c.PRESCRIPTOR_FARMACIA = int.Parse(cmbFarmacia.SelectedValue.ToString());
                    c.PRESCRIPTOR_MEDICO_DESCRIPCION = cmbMedico.Text.ToString();
                    c.PRESCRIPTOR_CENTRO_MEDICO_DESCRIPCION = cmbInstitucion.Text.ToString();
                    c.PRESCRIPTOR_FARMACIA_DESCRIPCION = cmbFarmacia.Text.ToString();
                    c.CUADERNO_USUARIO_ID = frmLogin.id;
                    co.RegistraCuaderno(c);
                    En_ListasDatos l = new En_ListasDatos();
                    l.co.Add(c);

                    foreach (DataGridViewRow r in dgvProductos.Rows)
                    {
                        En_CuadernoOralneProducto p = new En_CuadernoOralneProducto();
                        p.PRODUCTO_MAESTRO_CODIGO = Convert.ToInt32(r.Cells["CODIGO"].Value);
                        p.NOMBRE = r.Cells["NOMBRE"].Value.ToString();
                        p.LOTE = r.Cells["LOTE"].Value.ToString();
                        p.Nro_Cuaderno = int.Parse(lblNroCuaderno.Text);
                        p.Cantidad = int.Parse(r.Cells["CANTIDAD"].Value.ToString());
                        co.RegistraCuadernoProducto(p);
                        l.cop.Add(p);
                    }
                    pdf.GeneraCuaderno(l);
                    limpiarFormulario();
                }
            }
            else if (checkNO.Checked)
            {
                En_CuadernoOralne c = new En_CuadernoOralne();
                Bu_CuadernoOralne co = new Bu_CuadernoOralne();
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
                    c.Opcion = 1;
                    c.NRO_CUADERNO = lblNroCuaderno.Text;
                    c.CLIENTE_AUTORIZA_CONTACTO = 'N';
                    c.CLIENTE_NOMBRE = txtNombres.Text.ToUpper();
                    c.CLIENTE_PATERNO = txtPaterno.Text.ToUpper();
                    c.CLIENTE_MATERNO = txtMaterno.Text.ToUpper();
                    DateTime nacimiento = dtpNacimiento.Value.Date;
                    c.CLIENTE_NACIMIENTO = nacimiento;
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

                    DateTime fecha_compra = dtpFechaCompra.Value.Date;
                    c.RECETA_FECHA_COMPRA = fecha_compra;
                    c.RECETA_FUNCIONARIO = txtFuncionario.Text.ToUpper();
                    c.RECETA_OBSERVACION = txtObservaciones.Text.ToUpper();

                    c.PRESCRIPTOR_MEDICO = int.Parse(cmbMedico.SelectedValue.ToString());
                    c.PRESCRIPTOR_CENTRO_MEDICO = int.Parse(cmbInstitucion.SelectedValue.ToString());
                    c.PRESCRIPTOR_FARMACIA = int.Parse(cmbFarmacia.SelectedValue.ToString());
                    c.CUADERNO_USUARIO_ID = frmLogin.id;
                    co.RegistraCuaderno(c);

                    foreach (DataGridViewRow r in dgvProductos.Rows)
                    {
                        En_CuadernoOralneProducto p = new En_CuadernoOralneProducto();
                        p.PRODUCTO_MAESTRO_CODIGO = Convert.ToInt32(r.Cells["CODIGO"].Value);
                        p.LOTE = r.Cells["LOTE"].Value.ToString();
                        p.Nro_Cuaderno = int.Parse(lblNroCuaderno.Text);
                        co.RegistraCuadernoProducto(p);
                    }
                }
                limpiarFormulario();
            }
            else 
            {
                MessageBox.Show("Debes Seleccionar una Opcion de Autoriza contacto");
                checkSI.Focus();
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
            cmbFarmacia.Text = "";
            cmbInstitucion.Text = "";
            cmbMedico.Text = "";
            txtNroBoleta.Text = "";
            cmbProductos.SelectedIndex = 0;
            txtLoteVenc.Text = "";
            txtCantidad.Text = "";
            txtObservaciones.Text = "";
            txtFuncionario.Text = "";
            dgvProductos.Rows.Clear();
            if (checkNO.Checked || checkSI.Checked)
            {
                checkSI.Checked = false;
                checkNO.Checked = false;
            }
            txtNombres.Focus();
            Dispose();
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

        private void btnCrearMedico_Click(object sender, EventArgs e)
        {
            Utilitarios.frmCreaMedico f = new Utilitarios.frmCreaMedico();
            f.ShowDialog(this);
            if (f.respuesta)
            {
                CargaBox(cmbMedico, 5, 0);
            }

        }

        private void btnCrearInstitucion_Click(object sender, EventArgs e)
        {
            Marketing.frmCreaInstitucion f = new Marketing.frmCreaInstitucion();
            f.ShowDialog(this);
            if (f.respuesta)
            {
                CargaBox(cmbInstitucion, 6, 0);
            }
        }

        private void btnCrearFarmacia_Click(object sender, EventArgs e)
        {
            Marketing.frmCreaFarmacia f = new Marketing.frmCreaFarmacia();
            f.ShowDialog(this);
            if (f.respuesta)
            {
                CargaBox(cmbFarmacia, 4, 0);
            }
        }
    }
}
