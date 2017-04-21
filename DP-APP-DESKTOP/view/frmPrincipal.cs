
using System;
using System.Windows.Forms;
using DP_APP_DESKTOP.view;
using DP_APP_DESKTOP.view.Marketing;
using DP_APP_DESKTOP.view.Sistemas;
using DP_APP_DESKTOP.view.Sistemas.Impresora;
using DP_APP_DESKTOP.view.Utilidades;
using Business;
using Entity;
using System.Data;
using System.Collections.Generic;

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
            //Bu_Usuarios u = new Bu_Usuarios();
            //u.UsuarioCambiaEstado(frmLogin.id, 4);
            Application.Exit();
        }
        
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CargaEstadosMenu(frmLogin.id);
            lblUsuario.Text = frmLogin.user;
        }
        private IEnumerable<ToolStripMenuItem> GetItems(ToolStripMenuItem item)
        {
            foreach (ToolStripMenuItem dropDownItem in item.DropDownItems)
            {
                if (dropDownItem.HasDropDownItems)
                {
                    foreach (ToolStripMenuItem subItem in GetItems(dropDownItem))
                        yield return subItem;
                }
                yield return dropDownItem;
            }
        }
       

        private void CargaEstadosMenu(int id)
        {
            List<ToolStripMenuItem> allItems = new List<ToolStripMenuItem>();
            Bu_Menus mnu = new Bu_Menus();
            DataTable dt = mnu.Menu_Usuario(frmLogin.id);

            foreach (ToolStripMenuItem toolItem in msPrincipal.Items)
            {
                allItems.AddRange(GetItems(toolItem));
            }
            foreach (ToolStripMenuItem i in allItems)
            {
                foreach (DataRow d in dt.Rows)
                {
                    if (i.Name.ToString() == d["MNU_STRIG"].ToString())
                    {
                        ((ToolStripMenuItem)i).Enabled = bool.Parse(d["ESTADO"].ToString());
                    }
                }
            }
            
        }




        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Bu_Usuarios u = new Bu_Usuarios();
            //u.UsuarioCambiaEstado(frmLogin.id, 4);
            Application.Exit();
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
        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportesCuaderno f = new frmReportesCuaderno();
            cheCarForm(f, this);
        }
        //Dirección Técnica
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
        private void desbloqueaUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDesbloqueaUsuarios f = new frmDesbloqueaUsuarios();
            cheCarForm(f, this);
        }
        private void asignaMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsignaMenu form = new frmAsignaMenu();
            cheCarForm(form, this);
        }
        private void registraUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistraUsuario form = new frmRegistraUsuario();
            cheCarForm(form, this);
        }
        private void registraMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistraNuevoMenu f = new frmRegistraNuevoMenu();
            cheCarForm(f, this);
        }
        private void importaDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImportarDatos f = new frmImportarDatos();
            cheCarForm(f, this);
        }
        //Sistemas //Impresoras
        private void registroDeImpresoraToolStripMenuItem_Click(object sender, EventArgs e)
            {
                frmImpresoras f = new frmImpresoras();
                cheCarForm(f, this);
            }
            private void insumosDeImpresorasToolStripMenuItem_Click(object sender, EventArgs e)
            {
                frmImpresoraConsumo f = new frmImpresoraConsumo();
                cheCarForm(f, this);
            }

            private void registroConsumoToolStripMenuItem_Click(object sender, EventArgs e)
            {
                frmImpresoraConsumo f = new frmImpresoraConsumo();
                cheCarForm(f, this);
            }
        //Utilidades
        private void cambiarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambiaClave f = new frmCambiaClave();
            cheCarForm(f, this);
        }

        
    }
}
