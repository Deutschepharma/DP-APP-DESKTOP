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

namespace DP_APP_DESKTOP
{
    public partial class frmPruebas : Form
    {
        List<CargaInventario> inventario = new List<CargaInventario>();
        public frmPruebas()
        {
            InitializeComponent();
        }

        private void btnLeerDatos_Click(object sender, EventArgs e)
        {
            //se crea ruta

            string rutaExcel = Application.StartupPath + "\\Excel\\Importar.xlsx";
            //se crea libro a partir de la ruta
            var book = new ExcelQueryFactory(rutaExcel);
            //consulta linq
            var res = (from row in book.Worksheet("data")
                       let item = new CargaInventario
                       {
                           bodega = row[0].Cast<string>(),
                           codigo = Convert.ToInt32(row[1].Cast<string>()),
                           descripcion = row[2].Cast<string>(),
                           lote = row[3].Cast<string>(),
                           vencimiento = Convert.ToDateTime(row[4].Cast<string>()),
                           unidades = int.Parse(row[5].Cast<string>())
                       }
                       select item).ToList();
            book.Dispose();
            // mostrar datos en text box
            //txtDatosExcel.Text = "Datos de Archivo";
            barStatus.Minimum = 0;
            barStatus.Maximum = res.Count;
            barStatus.Step = 1;
            
            dataGridView1.AutoResizeColumns(
                   DataGridViewAutoSizeColumnsMode.ColumnHeader);

            dataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dataGridView1.DefaultCellStyle.Font = new Font("Calibri", 10);
            foreach (var i in res)
            {
                barStatus.PerformStep();
                if (i.lote!=null)
                {
                    if (i.lote!=""&&i.lote != "0")
                    {
                        if (i.descripcion != "DESCRIPCION")
                        {
                            if (i.lote!="Lote")
                            {
                                CargaInventario c = new CargaInventario();
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
            dataGridView1.DataSource=inventario;


        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Bu_Inventario_Diario b = new Bu_Inventario_Diario();
            foreach (CargaInventario c in inventario)
            {
                b.RegistraInventario(c);
            }
            dataGridView1.Rows.Clear();
        }
    }
}
