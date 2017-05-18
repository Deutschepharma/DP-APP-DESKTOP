using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Data.OleDb;
using System.Windows.Forms;
using Utilities;
using Entity;
using Business;
using System.Data.SqlClient;

namespace DP_APP_DESKTOP.view.Sistemas
{
    public partial class frmImportarDatos : Form
    {
        private void CargaBox(ComboBox cb, int flag, int cmbFlag)
        {
            Ut_Cargas box = new Ut_Cargas();
            DataTable dt = box.CargarComboBox(flag, cmbFlag);
            cb.DataSource = dt;
            cb.DisplayMember = "Nombre";
            cb.ValueMember = "Nombre";
        }

        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        DataTable dt = new DataTable();
        public frmImportarDatos()
        {
            InitializeComponent();
            CargaBox(cbTablas, 12, 0);

        }
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop).ToString();
            openFileDialog1.ShowDialog();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string filePath = openFileDialog1.FileName;
            string extension = Path.GetExtension(filePath);
            string conStr, sheetName;

            conStr = string.Empty;
            switch (extension)
            {
                case ".xls": 
                    conStr = string.Format(Excel03ConString, filePath, "YES");
                    break;
                case ".xlsx": 
                    conStr = string.Format(Excel07ConString, filePath, "YES");
                    break;
            }
            using (OleDbConnection con = new OleDbConnection(conStr))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = con;
                    con.Open();
                    DataTable dtExcelSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                    con.Close();
                }
            }
            using (OleDbConnection con = new OleDbConnection(conStr))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    using (OleDbDataAdapter oda = new OleDbDataAdapter())
                    {
                        
                        cmd.CommandText = "SELECT * From [" + sheetName + "]";
                        cmd.Connection = con;
                        con.Open();
                        oda.SelectCommand = cmd;
                        oda.Fill(dt);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }


        private void btnCargar_Click(object sender, EventArgs e)
        {
            Ut_Cargas u = new Ut_Cargas();
            u.Inserta(dataGridView1, cbTablas.SelectedValue.ToString());
            MessageBox.Show("Data Registrada");
            while (dataGridView1.RowCount >= 1)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
        }
    }
}
