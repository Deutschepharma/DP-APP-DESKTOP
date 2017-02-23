
using System;
using System.Windows.Forms;
using DP_APP_DESKTOP.view;
using DP_APP_DESKTOP.view.Marketing;
using DP_APP_DESKTOP.view.Sistemas;
using DP_APP_DESKTOP.view.Utilidades;
using Business;



namespace DP_APP_DESKTOP
{
    public partial class frmPrincipal : Form
    {
        //private int childForNumbre = 0;
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
            Bu_Usuarios u = new Bu_Usuarios();
            u.UsuarioCambiaEstado(frmLogin.id, 4);
            Application.Exit();

            //DialogResult op;
            //op = MessageBox.Show("Realmente ¿desea salir de la aplicación?", "", MessageBoxButtons.YesNo);
            //if (op == DialogResult.Yes)
            //{
            //    Bu_Usuarios u = new Bu_Usuarios();
            //    u.UsuarioCambiaEstado(frmLogin.id, 4);
            //    Application.Exit();
                
            //}
            //else
            //{
            //    e.Cancel = true;
            //}
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            switch (frmLogin.tipo)
            {
                case "1": //Sistema Administrador General
                    proyeccionesToolStripMenuItem.Enabled = true;
                    utilitariosToolStripMenuItem.Enabled = true;
                    logisticaToolStripMenuItem.Enabled = true;
                    sistemasToolStripMenuItem.Enabled = true;
                    break;
                case "2": //Usuario Standar
                    utilitariosToolStripMenuItem.Enabled = true;
                    break;
                case "3": //Direccion Tecnica
                    proyeccionesToolStripMenuItem.Enabled = true;
                    break;
                case "4": //Logistica
                    logisticaToolStripMenuItem.Enabled = true;
                    break;
                case "5":

                    break;
                default:
                    break;
            }
            lblUsuario.Text = frmLogin.user;
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bu_Usuarios u = new Bu_Usuarios();
            u.UsuarioCambiaEstado(frmLogin.id, 4);
            Application.Exit();
            //DialogResult resultado;
            //resultado = MessageBox.Show("Realmente ¿desea salir de la aplicación?", "", MessageBoxButtons.YesNo);
            //if (resultado == DialogResult.Yes)
            //{
            //    Bu_Usuarios u = new Bu_Usuarios();
            //    u.UsuarioCambiaEstado(frmLogin.id, 4);
            //    Application.Exit();

            //    //System.Environment.Exit(1);
            //}
        }


        //Logistica
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
        //Marketing
        private void cuadernoOralneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuadernoOralne cuadernoOralne = new frmCuadernoOralne();
            cheCarForm(cuadernoOralne, this);
        }
        //Proyecciones
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
        //Sistemas
        private void pruebasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPruebas form = new frmPruebas();
            cheCarForm(form, this);
        }
        private void desbloqueaUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDesbloqueaUsuarios f = new frmDesbloqueaUsuarios();
            cheCarForm(f, this);
        }
        //Utilidades
        private void cambiarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambiaClave f = new frmCambiaClave();
            cheCarForm(f, this);
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
