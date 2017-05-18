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

namespace DP_APP_DESKTOP.view.Marketing
{
    public partial class frmModificaCuaderno : Form
    {
        Bu_CuadernoOralne cu = null;
        Bu_CuadernoOralne co = null;
        public frmModificaCuaderno()
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
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNroCuaderno.Text.Trim()!="")
            {
                BuscarData(int.Parse(txtNroCuaderno.Text));
            }
            else
            {
                MessageBox.Show("Debe ingresar un numero de Cuaderno");
                txtNroCuaderno.Focus();
            }
        }
        private void txtNroCuaderno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
        private void BuscarData(int nroCuaderno)
        {
            cu = new Bu_CuadernoOralne();
            DataTable dtCuaderno = new DataTable();
            DataTable dtProductos = new DataTable();
            dtCuaderno = cu.Marketing_Buscar_NroCuaderno(nroCuaderno);
            dtProductos = cu.Marketing_Buscar_Productos_NroCuaderno(nroCuaderno);

            if (dtCuaderno.Rows.Count > 0)
            {
                foreach (DataRow r in dtCuaderno.Rows)
                {
                    txtNombres.Text = r["NOMBRE"].ToString();
                    txtPaterno.Text = r["PATERNO"].ToString();
                    txtMaterno.Text = r["MATERNO"].ToString();
                    txtDireccion.Text = r["DIRECCION"].ToString();
                    txtEmail.Text = r["EMAIL"].ToString();
                    txtFono.Text = r["FONO"].ToString();
                    dtpNacimiento.Text = r["NACIMIENTO"].ToString();
                    dtpFechaCompra.Text = r["COMPRA"].ToString();
                    txtObservaciones.Text = r["OBSERVACIONES"].ToString();
                }
                foreach (DataRow r in dtProductos.Rows)
                {
                    En_CuadernoOralneProducto p = new En_CuadernoOralneProducto();
                    co = new Bu_CuadernoOralne();
                    dgvProductos.Rows.Add(r["NRO_CUADERNO"].ToString(), r["CODIGO"].ToString(), r["NOMBRE"].ToString(), r["CANTIDAD"].ToString(), r["LOTE"].ToString());
                    p.PRODUCTO_MAESTRO_CODIGO = int.Parse(r["CODIGO"].ToString());
                    p.Nro_Cuaderno = int.Parse(r["NRO_CUADERNO"].ToString());
                    p.LOTE = "";
                    p.Cantidad = 0;
                    p.flag = 2;
                    co.Marketing_Registra_Cuaderno_Producto(p);
                }
                ActivarCampos();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            co = new Bu_CuadernoOralne();
            En_CuadernoOralne c = new En_CuadernoOralne();
            c.NRO_CUADERNO = txtNroCuaderno.Text;
            c.CLIENTE_NOMBRE = txtNombres.Text.ToUpper();
            c.CLIENTE_PATERNO = txtPaterno.Text.ToUpper();
            c.CLIENTE_MATERNO = txtMaterno.Text.ToUpper();
            DateTime nacimiento = dtpNacimiento.Value.Date;
            c.CLIENTE_NACIMIENTO = nacimiento;
            c.CLIENTE_DIRECCION = txtDireccion.Text.ToUpper();
            c.CLIENTE_EMAIL = txtEmail.Text.ToUpper();
            c.CLIENTE_FONO = txtFono.Text.ToUpper();
            DateTime fecha_compra = dtpFechaCompra.Value.Date;
            c.RECETA_FECHA_COMPRA = fecha_compra;
            c.RECETA_OBSERVACION = txtObservaciones.Text.ToUpper();
            co.Marketing_Registra_Cuaderno(c);
            //grabar los productos
            foreach (DataGridViewRow r in dgvProductos.Rows)
            {
                co = new Bu_CuadernoOralne();
                En_CuadernoOralneProducto p = new En_CuadernoOralneProducto();
                p.PRODUCTO_MAESTRO_CODIGO = Convert.ToInt32(r.Cells["CODIGO"].Value);
                p.Nro_Cuaderno = int.Parse(r.Cells["NRO_CUADERNO"].Value.ToString());
                p.NOMBRE = r.Cells["NOMBRE"].Value.ToString();
                p.LOTE = r.Cells["LOTE"].Value.ToString();
                p.Cantidad = int.Parse(r.Cells["CANTIDAD"].Value.ToString());
                p.flag = 1;
                co.Marketing_Registra_Cuaderno_Producto(p);
            }
            LimpiarCampos();
        }
        private void btnAgregaProducto_Click(object sender, EventArgs e)
        {
            dgvProductos.Rows.Add(txtNroCuaderno.Text, cmbProductos.SelectedValue.ToString(), cmbProductos.Text, txtCantidad.Text, txtLoteVenc.Text);
            txtLoteVenc.Text = "";
            txtCantidad.Text = "";
            cmbProductos.SelectedIndex = 0;
        }
        private void btnQuitaProducto_Click(object sender, EventArgs e)
        {
            dgvProductos.Rows.RemoveAt(dgvProductos.CurrentRow.Index);
        }
        private void frmModificaCuaderno_Load(object sender, EventArgs e)
        {
            BloquearCampos();
        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
        private void LimpiarCampos()
        {
            txtNombres.Text = "";
            txtPaterno.Text = "";
            txtMaterno.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            txtFono.Text = "";
            dtpNacimiento.Text = "";
            dtpFechaCompra.Text = "";
            cmbProductos.SelectedIndex = 0;
            txtLoteVenc.Text = "";
            txtCantidad.Text = "";
            txtObservaciones.Text = "";
            dgvProductos.Rows.Clear();
            txtNroCuaderno.Focus();
            BloquearCampos();
        }
        private void ActivarCampos()
        {
            txtNombres.Enabled = true;
            txtPaterno.Enabled = true;
            txtMaterno.Enabled = true;
            txtDireccion.Enabled = true;
            txtEmail.Enabled = true;
            txtFono.Enabled = true;
            dtpNacimiento.Enabled = true;
            dtpFechaCompra.Enabled = true;
            cmbProductos.Enabled = true;
            txtLoteVenc.Enabled = true;
            txtCantidad.Enabled = true;
            btnAgregaProducto.Enabled = true;
            btnQuitaProducto.Enabled = true;
            btnActualizar.Enabled = true;
            txtObservaciones.Enabled = true;
            dgvProductos.Enabled = true;
        }
        private void BloquearCampos()
        {
            txtNombres.Enabled = false;
            txtPaterno.Enabled = false;
            txtMaterno.Enabled = false;
            txtDireccion.Enabled = false;
            txtEmail.Enabled = false;
            txtFono.Enabled = false;
            dtpNacimiento.Enabled = false;
            dtpFechaCompra.Enabled = false;
            cmbProductos.Enabled = false;
            txtLoteVenc.Enabled = false;
            txtCantidad.Enabled = false;
            btnAgregaProducto.Enabled = false;
            btnQuitaProducto.Enabled = false;
            btnActualizar.Enabled = false;
            txtObservaciones.Enabled = false;
            dgvProductos.Enabled = false;
            CargaBox(cmbProductos, 2, 0);
        }


    }
}
