using System;
using System.Windows.Forms;
using Entity;
using Business;
using System.Data;
using System.Drawing;

namespace DP_APP_DESKTOP.view.Marketing
{
    public partial class frmReportesCuaderno : Form
    {
        Bu_CuadernoOralne bu;
        private void CargaBox(ComboBox cb, int flag, int cmbFlag)
        {
            Bu_CuadernoOralne box = new Bu_CuadernoOralne();
            DataTable dt = box.CargaCombos(flag, cmbFlag);
            cb.DataSource = dt;
            cb.DisplayMember = "Nombre";
            cb.ValueMember = "Codigo";
        }
        public frmReportesCuaderno()
        {
            InitializeComponent();
        }
        //lista toda la informacion de la base
        private void btnListar_Click(object sender, EventArgs e)
        {
            bu = new Bu_CuadernoOralne();
            dgCuadernos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgCuadernos.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dgCuadernos.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dgCuadernos.DefaultCellStyle.Font = new Font("Calibri", 10);
            dgCuadernos.DataSource = bu.ListarCuadernos();

        }
        
        //muestra por rangos de fecha de registros 
        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            bu = new Bu_CuadernoOralne();
            string desde;
            string hasta;
            desde = txtDesde.Value.Date.ToString("yyyy-MM-dd");
            hasta = txtHasta.Value.Date.ToString("yyyy-MM-dd");

            dgCuadernos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgCuadernos.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dgCuadernos.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dgCuadernos.DefaultCellStyle.Font = new Font("Calibri", 10);
            dgCuadernos.DataSource = bu.ListarCuaderno_Fecha(desde, hasta);
        }

        private void frmReportesCuaderno_Load(object sender, EventArgs e)
        {
            CargaBox(cmbMedico, 10, 0);
        }

        private void dgCuadernos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = int.Parse(dgCuadernos.Rows[e.RowIndex].Cells[0].Value.ToString());

            bu = new Bu_CuadernoOralne();

            dgProductosCuadernos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgProductosCuadernos.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dgProductosCuadernos.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dgProductosCuadernos.DefaultCellStyle.Font = new Font("Calibri", 10);
            dgProductosCuadernos.DataSource = bu.ListarProductos_NroCuaderno(index);
        }

        private void btnMostrarLista_Click(object sender, EventArgs e)
        {
            bu = new Bu_CuadernoOralne();

            dgCuadernos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgCuadernos.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dgCuadernos.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dgCuadernos.DefaultCellStyle.Font = new Font("Calibri", 10);
            dgCuadernos.DataSource = bu.ListarCuadernos_Medico(int.Parse(cmbMedico.SelectedValue.ToString()));
        }

        //exportar la base a un excel
        private void btnExportar_Click(object sender, EventArgs e)
        {
            bu = new Bu_CuadernoOralne();

            dgCuadernos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgCuadernos.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dgCuadernos.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dgCuadernos.DefaultCellStyle.Font = new Font("Calibri", 10);
            dgCuadernos.DataSource = bu.ExportarData_Medico(int.Parse(cmbMedico.SelectedValue.ToString()));
        }
        private void btnExportarFecha_Click(object sender, EventArgs e)
        {

        }
    }
}
