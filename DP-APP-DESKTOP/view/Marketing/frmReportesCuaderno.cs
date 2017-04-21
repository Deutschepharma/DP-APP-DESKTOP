using System;
using System.Windows.Forms;
using Business;
using System.Drawing;
using Utilities;
using System.Data;
using System.Diagnostics;
//


namespace DP_APP_DESKTOP.view.Marketing
{
    public partial class frmReportesCuaderno : Form
    {
        Bu_CuadernoOralne bu;
        Ut_GeneraExcel ge;

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
        

        private void frmReportesCuaderno_Load(object sender, EventArgs e)
        {
            CargaBox(cmbMedico, 10, 0);
            CargaBox(cmbProducto, 11, 0);
        }

        private void dgCuadernos_CellClick(object sender, DataGridViewCellEventArgs e)
        {//muestra informacion al hacer clic en el gridview
            int index = int.Parse(dgCuadernos.Rows[e.RowIndex].Cells[0].Value.ToString());
            bu = new Bu_CuadernoOralne();
            EstilosDG_Productos();
            dgProductosCuadernos.DataSource = bu.ListarProductos_NroCuaderno(index);
        }

        

        private void btnMostrar_Click_1(object sender, EventArgs e)
        {//muestra por rangos de fecha de registros 
            bu = new Bu_CuadernoOralne();
            string desde;
            string hasta;
            desde = txtDesde.Value.Date.ToString("yyyy-MM-dd");
            hasta = txtHasta.Value.Date.ToString("yyyy-MM-dd");
            EstilosDG_Cuadernos();
            dgCuadernos.DataSource = bu.ListarCuaderno_Fecha(desde, hasta);
            if (dgCuadernos.Rows.Count > 0)
            {
                btnExportarFecha.Enabled = true;
            }
        }

        

        private void btnMostrarLista_Click(object sender, EventArgs e)
        {//muestra desde el combobox
            bu = new Bu_CuadernoOralne();
            EstilosDG_Cuadernos();
            dgCuadernos.DataSource = bu.ListarCuadernos_Medico(int.Parse(cmbMedico.SelectedValue.ToString()));
            if (dgCuadernos.Rows.Count > 0)
            {
                btnExportarTodo.Enabled = true;
            }
        }
        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {//muestra los productos segun el producto seleccionado o todos
            bu = new Bu_CuadernoOralne();
            EstilosDG_Cuadernos();
            dgCuadernos.DataSource = bu.ListarCuadernos_Productos(int.Parse(cmbProducto.SelectedValue.ToString()));
            if (dgCuadernos.Rows.Count > 0)
            {
                btnExportarProductos.Enabled = true;
            }
        }

        //exportar la base a un excel
        private void btnExportar_Click(object sender, EventArgs e)
        {
            ge = new Ut_GeneraExcel();
            ge.ruta= System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop).ToString();
            ge.ExcelExport(bu.ExportarData_Medico(int.Parse(cmbMedico.SelectedValue.ToString())));
            OpenMicrosoftExcel(ge.ruta+ @"\\ReporteCuaderno.xlsx");

        }
        private void btnExportarFecha_Click(object sender, EventArgs e)
        {
            string desde;
            string hasta;
            desde = txtDesde.Value.Date.ToString("yyyy-MM-dd");
            hasta = txtHasta.Value.Date.ToString("yyyy-MM-dd");
            ge = new Ut_GeneraExcel();
            ge.ruta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop).ToString();
            ge.ExcelExport_Fecha(bu.ExportarData_Fecha(desde,hasta));
            OpenMicrosoftExcel(ge.ruta + @"\\ReporteCuaderno_Fechas.xlsx");
        }
        private void btnExportarProductos_Click(object sender, EventArgs e)
        {
            ge = new Ut_GeneraExcel();
            ge.ruta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop).ToString();
            ge.ExcelExport_Productos(bu.ListarCuadernos_Productos(int.Parse(cmbProducto.SelectedValue.ToString())));
            OpenMicrosoftExcel(ge.ruta + @"\\ReporteCuaderno_Productos.xlsx");
        }




        static void OpenMicrosoftExcel(string f)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "EXCEL.EXE";
            startInfo.Arguments = f;
            Process.Start(startInfo);
        }
        //Estilos de los dataGridview
        private void EstilosDG_Cuadernos()
        {
            dgCuadernos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgCuadernos.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dgCuadernos.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dgCuadernos.DefaultCellStyle.Font = new Font("Calibri", 10);
        }
        private void EstilosDG_Productos()
        {
            dgProductosCuadernos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgProductosCuadernos.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dgProductosCuadernos.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dgProductosCuadernos.DefaultCellStyle.Font = new Font("Calibri", 10);
        }

    }
}
