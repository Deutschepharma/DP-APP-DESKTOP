
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DP_APP_DESKTOP.view;
using System.Data.SqlClient;



namespace DP_APP_DESKTOP
{
    public partial class frmPrincipal : Form
    {
        private int childForNumbre = 0;
        public frmPrincipal()
        {
            InitializeComponent();
        }
        Form llamado = new Form();
        public void cheCarForm(Form hijo, Form padre)
        {
            bool cargado = false;
            foreach (Form llamado in padre.MdiChildren)
            {
                if (llamado.Text==hijo.Text)
                {
                    cargado = true;
                    break;
                }
            }
            if (!cargado)
            {
                hijo.MdiParent = padre;
                hijo.Show();
            }
        }
        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult op;
            op = MessageBox.Show("Realmente ¿desea salir de la aplicación?", "", MessageBoxButtons.YesNo);
            if (op == DialogResult.Yes)
            {
                //SqlCommand update = new SqlCommand("update USUARIOS set conectado = '0' where usuario ='" + lblUsuario.Text + "'", cn);
                //cn.Open();
                //update.ExecuteNonQuery();
                System.Environment.Exit(1);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblID.Text = frmLogin.id;
            lblUsuario.Text = frmLogin.user;
        }
        

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = MessageBox.Show("Realmente ¿desea salir de la aplicación?", "", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                //SqlCommand update = new SqlCommand("update USUARIOS set conectado = '0' where usuario ='" + lblUsuario.Text + "'", cn);
                //cn.Open();
                //update.ExecuteNonQuery();
                System.Environment.Exit(1);
            }
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentas venta = new frmVentas();
            cheCarForm(venta, this);
        }

        private void muestrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMuestras muestras = new frmMuestras();
            cheCarForm(muestras, this);
        }

        private void cuadernoOralneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuadernoOralne cuadernoOralne = new frmCuadernoOralne();
            cheCarForm(cuadernoOralne, this);
        }

        private void pruebasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPruebas form = new frmPruebas();
            cheCarForm(form, this);
        }

        private void cargaDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargaMatVenta matVta = new frmCargaMatVenta();
            cheCarForm(matVta, this);
        }

        private void cargaDeMaterialEnvasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargaMatEnv matEnv = new frmCargaMatEnv();
            cheCarForm(matEnv, this);
        }




        //public void CargarMenu(Int32 IdMaster, ToolStripMenuItem mnuPadre, MenuStrip Menu)
        //{
        //    DataTable datos = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter("select * from menu", cn);
        //    cn.Open();
        //    da.Fill(datos);
        //    cn.Close();
        //    DataView dv = new DataView(datos);
        //    dv.RowFilter = datos.Columns["IdMaster"].ColumnName + "=" + IdMaster;
        //    foreach (DataRowView f in dv)
        //    {
        //        ToolStripMenuItem mnuHijo = new ToolStripMenuItem();
        //        mnuHijo.Text = f["Descripcion"].ToString();
        //        mnuHijo.Name = f["Id"].ToString();
        //        if (mnuPadre == null)
        //        {
        //            Menu.Items.Add(mnuHijo);
        //        }
        //        else
        //        {
        //            mnuPadre.DropDownItems.Add(mnuHijo);
        //        }
        //        CargarMenu(int.Parse(f["Id"].ToString()), mnuHijo, Menu);
        //    }
        //}






    }
}
