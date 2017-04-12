namespace DP_APP_DESKTOP
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.proyeccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muestrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadernoOralneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logisticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaDeMaterialEnvasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recursosHumanosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desbloqueaUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registraUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registraMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impresorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeImpresoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insumosDeImpresorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroConsumoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarClaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.msPrincipal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUsuario.Location = new System.Drawing.Point(35, 6);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUsuario.Size = new System.Drawing.Size(61, 15);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "lblUsuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "User";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // msPrincipal
            // 
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proyeccionesToolStripMenuItem,
            this.utilitariosToolStripMenuItem,
            this.logisticaToolStripMenuItem,
            this.recursosHumanosToolStripMenuItem,
            this.sistemasToolStripMenuItem,
            this.utilidadesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(1008, 24);
            this.msPrincipal.TabIndex = 8;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // proyeccionesToolStripMenuItem
            // 
            this.proyeccionesToolStripMenuItem.Checked = true;
            this.proyeccionesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.proyeccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.muestrasToolStripMenuItem});
            this.proyeccionesToolStripMenuItem.Name = "proyeccionesToolStripMenuItem";
            this.proyeccionesToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.proyeccionesToolStripMenuItem.Text = "Dirección Técnica";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // muestrasToolStripMenuItem
            // 
            this.muestrasToolStripMenuItem.Name = "muestrasToolStripMenuItem";
            this.muestrasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.muestrasToolStripMenuItem.Text = "Muestras";
            this.muestrasToolStripMenuItem.Click += new System.EventHandler(this.muestrasToolStripMenuItem_Click);
            // 
            // utilitariosToolStripMenuItem
            // 
            this.utilitariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuadernoOralneToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.utilitariosToolStripMenuItem.Name = "utilitariosToolStripMenuItem";
            this.utilitariosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.utilitariosToolStripMenuItem.Text = "Marketing";
            // 
            // cuadernoOralneToolStripMenuItem
            // 
            this.cuadernoOralneToolStripMenuItem.Name = "cuadernoOralneToolStripMenuItem";
            this.cuadernoOralneToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.cuadernoOralneToolStripMenuItem.Text = "Beneficio 1+1";
            this.cuadernoOralneToolStripMenuItem.Click += new System.EventHandler(this.cuadernoOralneToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.reportesToolStripMenuItem.Text = "Reportes Beneficio 1+1";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // logisticaToolStripMenuItem
            // 
            this.logisticaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargaDeInventarioToolStripMenuItem,
            this.cargaDeMaterialEnvasesToolStripMenuItem});
            this.logisticaToolStripMenuItem.Name = "logisticaToolStripMenuItem";
            this.logisticaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.logisticaToolStripMenuItem.Text = "Logistica";
            // 
            // cargaDeInventarioToolStripMenuItem
            // 
            this.cargaDeInventarioToolStripMenuItem.Name = "cargaDeInventarioToolStripMenuItem";
            this.cargaDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.cargaDeInventarioToolStripMenuItem.Text = "Carga de Material Venta";
            this.cargaDeInventarioToolStripMenuItem.Click += new System.EventHandler(this.cargaDeInventarioToolStripMenuItem_Click);
            // 
            // cargaDeMaterialEnvasesToolStripMenuItem
            // 
            this.cargaDeMaterialEnvasesToolStripMenuItem.Name = "cargaDeMaterialEnvasesToolStripMenuItem";
            this.cargaDeMaterialEnvasesToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.cargaDeMaterialEnvasesToolStripMenuItem.Text = "Carga de Material Envases";
            this.cargaDeMaterialEnvasesToolStripMenuItem.Click += new System.EventHandler(this.cargaDeMaterialEnvasesToolStripMenuItem_Click);
            // 
            // recursosHumanosToolStripMenuItem
            // 
            this.recursosHumanosToolStripMenuItem.Name = "recursosHumanosToolStripMenuItem";
            this.recursosHumanosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.recursosHumanosToolStripMenuItem.Text = "RRHH";
            // 
            // sistemasToolStripMenuItem
            // 
            this.sistemasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desbloqueaUsuariosToolStripMenuItem,
            this.registraUsuarioToolStripMenuItem,
            this.asignaMenuToolStripMenuItem,
            this.registraMenuToolStripMenuItem,
            this.impresorasToolStripMenuItem});
            this.sistemasToolStripMenuItem.Name = "sistemasToolStripMenuItem";
            this.sistemasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.sistemasToolStripMenuItem.Text = "Sistemas";
            // 
            // desbloqueaUsuariosToolStripMenuItem
            // 
            this.desbloqueaUsuariosToolStripMenuItem.Name = "desbloqueaUsuariosToolStripMenuItem";
            this.desbloqueaUsuariosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.desbloqueaUsuariosToolStripMenuItem.Text = "Desbloquea Usuarios";
            this.desbloqueaUsuariosToolStripMenuItem.Click += new System.EventHandler(this.desbloqueaUsuariosToolStripMenuItem_Click);
            // 
            // asignaMenuToolStripMenuItem
            // 
            this.asignaMenuToolStripMenuItem.Name = "asignaMenuToolStripMenuItem";
            this.asignaMenuToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.asignaMenuToolStripMenuItem.Text = "Asigna Menú";
            this.asignaMenuToolStripMenuItem.Click += new System.EventHandler(this.asignaMenuToolStripMenuItem_Click);
            // 
            // registraUsuarioToolStripMenuItem
            // 
            this.registraUsuarioToolStripMenuItem.Name = "registraUsuarioToolStripMenuItem";
            this.registraUsuarioToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.registraUsuarioToolStripMenuItem.Text = "Registra Usuario";
            this.registraUsuarioToolStripMenuItem.Click += new System.EventHandler(this.registraUsuarioToolStripMenuItem_Click);
            // 
            // registraMenuToolStripMenuItem
            // 
            this.registraMenuToolStripMenuItem.Name = "registraMenuToolStripMenuItem";
            this.registraMenuToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.registraMenuToolStripMenuItem.Text = "Registra Menú";
            this.registraMenuToolStripMenuItem.Click += new System.EventHandler(this.registraMenuToolStripMenuItem_Click);
            // 
            // impresorasToolStripMenuItem
            // 
            this.impresorasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeImpresoraToolStripMenuItem,
            this.insumosDeImpresorasToolStripMenuItem,
            this.registroConsumoToolStripMenuItem});
            this.impresorasToolStripMenuItem.Name = "impresorasToolStripMenuItem";
            this.impresorasToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.impresorasToolStripMenuItem.Text = "Impresoras";
            // 
            // registroDeImpresoraToolStripMenuItem
            // 
            this.registroDeImpresoraToolStripMenuItem.Name = "registroDeImpresoraToolStripMenuItem";
            this.registroDeImpresoraToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.registroDeImpresoraToolStripMenuItem.Text = "Registro Impresora";
            this.registroDeImpresoraToolStripMenuItem.Click += new System.EventHandler(this.registroDeImpresoraToolStripMenuItem_Click);
            // 
            // insumosDeImpresorasToolStripMenuItem
            // 
            this.insumosDeImpresorasToolStripMenuItem.Name = "insumosDeImpresorasToolStripMenuItem";
            this.insumosDeImpresorasToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.insumosDeImpresorasToolStripMenuItem.Text = "Registro Insumos";
            this.insumosDeImpresorasToolStripMenuItem.Click += new System.EventHandler(this.insumosDeImpresorasToolStripMenuItem_Click);
            // 
            // registroConsumoToolStripMenuItem
            // 
            this.registroConsumoToolStripMenuItem.Name = "registroConsumoToolStripMenuItem";
            this.registroConsumoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.registroConsumoToolStripMenuItem.Text = "Registro Consumo";
            this.registroConsumoToolStripMenuItem.Click += new System.EventHandler(this.registroConsumoToolStripMenuItem_Click);
            // 
            // utilidadesToolStripMenuItem
            // 
            this.utilidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarClaveToolStripMenuItem});
            this.utilidadesToolStripMenuItem.Name = "utilidadesToolStripMenuItem";
            this.utilidadesToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.utilidadesToolStripMenuItem.Text = "Utilidades";
            // 
            // cambiarClaveToolStripMenuItem
            // 
            this.cambiarClaveToolStripMenuItem.Name = "cambiarClaveToolStripMenuItem";
            this.cambiarClaveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cambiarClaveToolStripMenuItem.Text = "Cambiar Clave";
            this.cambiarClaveToolStripMenuItem.Click += new System.EventHandler(this.cambiarClaveToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblID.Location = new System.Drawing.Point(966, 34);
            this.lblID.Name = "lblID";
            this.lblID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblID.Size = new System.Drawing.Size(30, 15);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "lblId";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblID.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblUsuario);
            this.groupBox1.Location = new System.Drawing.Point(1024, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(198, 24);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.msPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msPrincipal;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DeutschePharma S.A";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem proyeccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muestrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem utilitariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadernoOralneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logisticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaDeMaterialEnvasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarClaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desbloqueaUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recursosHumanosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignaMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registraUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registraMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impresorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeImpresoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insumosDeImpresorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroConsumoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
    }
}

