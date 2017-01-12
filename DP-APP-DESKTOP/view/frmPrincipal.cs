
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;



namespace DP_APP_DESKTOP
{
    public partial class frmPrincipal : Form
    {
        
        public frmPrincipal()
        {
            InitializeComponent();
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
            view.frmVentas form = new view.frmVentas();
            form.MdiParent = this;
            form.Show();
        }

        private void muestrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view.frmMuestras form = new view.frmMuestras();
            form.MdiParent = this;
            form.Show();
        }

        private void cuadernoOralneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view.frmCuadernoOralne form = new view.frmCuadernoOralne();
            form.MdiParent = this;
            form.Show();
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
