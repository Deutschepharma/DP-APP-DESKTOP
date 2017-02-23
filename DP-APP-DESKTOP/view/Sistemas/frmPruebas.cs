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
    public partial class frmPruebas : Form
    {
        List<En_CargaMatVta> inventario = new List<En_CargaMatVta>();
        public frmPruebas()
        {
            InitializeComponent();
        }

        private void BtnLeerDatos_Click(object sender, EventArgs e)
        {
            if (txtAbrir.Text!="")
            {
                //string rutaExcel = Application.StartupPath + "\\Excel\\Importar.xlsx";
                string rutaExcel = txtAbrir.Text;
                //se crea libro a partir de la ruta
                var book = new ExcelQueryFactory(rutaExcel);
                //consulta linq
                var res = (from row in book.Worksheet("data")
                            let item = new En_CargaMatVta
                            {
                                bodega = row[0].Cast<string>(),
                                codigo = row[1].Cast<string>(),
                                descripcion = row[2].Cast<string>(),
                                lote = row[3].Cast<string>(),
                                vencimiento = row[4].Cast<string>(),
                                unidades = row[5].Cast<string>()
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
                    if (i.lote != null)
                    {
                        if (i.lote != "" && i.lote != "0")
                        {
                            if (i.descripcion != "DESCRIPCION")
                            {
                                if (i.bodega != "BODEGA")
                                {
                                    if (!i.lote.StartsWith("Lote"))
                                    {
                                        if (!i.lote.StartsWith("Página actual"))
                                        {
                                            En_CargaMatVta c = new En_CargaMatVta();
                                            c.bodega = i.bodega;
                                            c.codigo = i.codigo;
                                            c.descripcion = i.descripcion;
                                            c.lote = i.lote;
                                            c.vencimiento = i.vencimiento;
                                            c.unidades = i.unidades;
                                            inventario.Add(c);
                                        }

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
            if (inventario.Count < 0)
            {
                barStatus.Minimum = 0;
                barStatus.Maximum = inventario.Count;
                barStatus.Step = 1;
                Bu_Inventario_Diario b = new Bu_Inventario_Diario();
                foreach (En_CargaMatVta c in inventario)
                {
                    b.RegistraInventario(c);
                    barStatus.PerformStep();
                }
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
