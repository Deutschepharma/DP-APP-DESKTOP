using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqToExcel;
using Entity;
using Business;
using System.IO;


namespace DP_APP_DESKTOP
{
    public partial class frmCargaMatEnv : Form
    {
        List<CargaInventario> inventario = new List<CargaInventario>();
        public frmCargaMatEnv()
        {
            InitializeComponent();
        }

        private void BtnLeerDatos_Click(object sender, EventArgs e)
        {
            if (txtAbrir.Text!="")
            {
                string rutaExcel = txtAbrir.Text;
                var book = new ExcelQueryFactory(rutaExcel);
                var res = (from row in book.Worksheet("Mat_Env")
                            let item = new CargaInventario
                            {
                                codigo = row[0].Cast<string>(),
                                descripcion = row[1].Cast<string>(),
                                bodega = row[2].Cast<string>(),
                                unidades = row[3].Cast<string>()
                            }
                            select item).ToList();
                book.Dispose();
                barStatus.Minimum = 0;
                barStatus.Maximum = res.Count;
                barStatus.Step = 1;
                dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dg.RowsDefaultCellStyle.BackColor = Color.Bisque;
                dg.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
                dg.DefaultCellStyle.Font = new Font("Calibri", 10);
                foreach (var i in res)
                {
                    barStatus.PerformStep();
                    if (i.codigo != null)
                    {
                        if (i.codigo != "")
                        {
                            if (!i.descripcion.StartsWith("DESCRIPCION"))
                            {
                                if (!i.bodega.StartsWith("BODEGA"))
                                {
                                    if (!i.codigo.StartsWith("Tota"))
                                    {
                                        CargaInventario c = new CargaInventario();
                                        c.bodega = i.bodega;
                                        c.codigo = i.codigo;
                                        c.descripcion = i.descripcion;
                                        //c.lote = i.lote;
                                        //c.vencimiento = i.vencimiento;
                                        c.unidades = i.unidades;
                                        inventario.Add(c);
                                    }
                                }
                            }
                        }
                    }
                }
                dg.DataSource = inventario;
            }
            else
            {
                MessageBox.Show("No has seleccionado el Archivo Excel");
            }
            
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (inventario.Count > 0)
            {
                Bu_Inventario_Diario b = new Bu_Inventario_Diario();
                foreach (CargaInventario c in inventario)
                {
                    b.RegistraMatEnv(c);
                }
                MessageBox.Show("Registro Completo");
            }
            else
            {
                MessageBox.Show("no hay registros de inventario imposible guardar");
            }
            
            
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            //openFileDialog1.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            openFileDialog1.Filter = "xlsx files (*.xlsx)|*.xlsx";
            //openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            txtAbrir.Text = openFileDialog1.FileName.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }


    }
}
