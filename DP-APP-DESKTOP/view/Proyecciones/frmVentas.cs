using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Business;

namespace DP_APP_DESKTOP.view
{
    public partial class frmVentas : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        public frmVentas()
        {
            InitializeComponent();
        }
        private void CargaBox(ComboBox cb, int flag, int cmbFlag)
        {
            Bu_Ventas box = new Bu_Ventas();
            DataTable ds = box.CargaCombos(flag, cmbFlag);
            cb.DataSource = ds;
            cb.DisplayMember = "Nombre";
            cb.ValueMember = "Codigo";
        }
        private void btnCarga_Click(object sender, EventArgs e)
        {
            if (cmbAño.SelectedValue.ToString() != "0")
            {
                dataGridView1.DataSource = bindingSource1;
                GetData(cmbAño.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("No has seleccionado Año");
            }
        }

        private void btnActualiza_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                DialogResult resultado;
                resultado = MessageBox.Show("Estas seguro de Actualizar?", "", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    dataAdapter.Update((DataTable)bindingSource1.DataSource);
                    CargaBox(cmbAño, 3, 0);
                }
            }
            else
            {
                MessageBox.Show("No has registrado Informacion");
            }
        }
        private void GetData(string v)
        {
            try
            {
                
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-2F7H406;Initial Catalog=DP;Persist Security Info=True;User ID=sa;Password=Sa2016");
                dataAdapter = new SqlDataAdapter("select VENTA_ID 'ID', PRODUCTO_MAESTRO_CODIGO'CODIGO', VENTA_ENERO'ENERO', VENTA_FEBRERO'FEBRERO', venta_marzo'MARZO', VENTA_ABRIL'ABRIL', VENTA_MAYO'MAYO', VENTA_JUNIO'JUNIO', VENTA_JULIO'JULIO', VENTA_AGOSTO'AGOSTO',VENTA_SEPTIEMBRE'SEPTIMBRE', VENTA_OCTUBRE'OCTUBRE', VENTA_NOVIEMBRE'NOVIEMBRE', VENTA_DICIEMBRE'DICIEMBRE', VENTA_ANO'AÑO'" +
                    "from VENTAS Where VENTA_ANO = " + int.Parse(v), cn);

                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
                dataGridView1.AutoResizeColumns(
                   DataGridViewAutoSizeColumnsMode.ColumnHeader);

                dataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
                dataGridView1.DefaultCellStyle.Font = new Font("Calibri", 10);

            }
            catch (SqlException)
            {
                MessageBox.Show("Error de Carga");
            }
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            CargaBox(cmbAño, 3, 0);
        }
    }
}
