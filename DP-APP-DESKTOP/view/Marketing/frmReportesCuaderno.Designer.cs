namespace DP_APP_DESKTOP.view.Marketing
{
    partial class frmReportesCuaderno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportesCuaderno));
            this.txtDesde = new System.Windows.Forms.DateTimePicker();
            this.txtHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgCuadernos = new System.Windows.Forms.DataGridView();
            this.dgProductosCuadernos = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.btnMostrarLista = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMostrarProductos = new System.Windows.Forms.Button();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.btnExportarFecha = new System.Windows.Forms.Button();
            this.btnExportarTodo = new System.Windows.Forms.Button();
            this.btnExportarProductos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgCuadernos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductosCuadernos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDesde
            // 
            this.txtDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDesde.Location = new System.Drawing.Point(9, 32);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDesde.Size = new System.Drawing.Size(140, 20);
            this.txtDesde.TabIndex = 4;
            this.txtDesde.Value = new System.DateTime(2017, 4, 12, 15, 12, 37, 0);
            // 
            // txtHasta
            // 
            this.txtHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtHasta.Location = new System.Drawing.Point(9, 71);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(140, 20);
            this.txtHasta.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hasta";
            // 
            // dgCuadernos
            // 
            this.dgCuadernos.AllowUserToAddRows = false;
            this.dgCuadernos.AllowUserToDeleteRows = false;
            this.dgCuadernos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCuadernos.Location = new System.Drawing.Point(11, 133);
            this.dgCuadernos.Name = "dgCuadernos";
            this.dgCuadernos.ReadOnly = true;
            this.dgCuadernos.Size = new System.Drawing.Size(910, 225);
            this.dgCuadernos.TabIndex = 9;
            this.dgCuadernos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCuadernos_CellClick);
            // 
            // dgProductosCuadernos
            // 
            this.dgProductosCuadernos.AllowUserToAddRows = false;
            this.dgProductosCuadernos.AllowUserToDeleteRows = false;
            this.dgProductosCuadernos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductosCuadernos.Location = new System.Drawing.Point(12, 365);
            this.dgProductosCuadernos.Name = "dgProductosCuadernos";
            this.dgProductosCuadernos.ReadOnly = true;
            this.dgProductosCuadernos.Size = new System.Drawing.Size(909, 137);
            this.dgProductosCuadernos.TabIndex = 10;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(155, 31);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(85, 23);
            this.btnMostrar.TabIndex = 12;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click_1);
            // 
            // cmbMedico
            // 
            this.cmbMedico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMedico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(340, 35);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(298, 21);
            this.cmbMedico.TabIndex = 22;
            // 
            // btnMostrarLista
            // 
            this.btnMostrarLista.Location = new System.Drawing.Point(644, 35);
            this.btnMostrarLista.Name = "btnMostrarLista";
            this.btnMostrarLista.Size = new System.Drawing.Size(85, 23);
            this.btnMostrarLista.TabIndex = 23;
            this.btnMostrarLista.Text = "Mostrar";
            this.btnMostrarLista.UseVisualStyleBackColor = true;
            this.btnMostrarLista.Click += new System.EventHandler(this.btnMostrarLista_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Seleccione Medico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Seleccione Producto";
            // 
            // btnMostrarProductos
            // 
            this.btnMostrarProductos.Location = new System.Drawing.Point(644, 82);
            this.btnMostrarProductos.Name = "btnMostrarProductos";
            this.btnMostrarProductos.Size = new System.Drawing.Size(85, 23);
            this.btnMostrarProductos.TabIndex = 27;
            this.btnMostrarProductos.Text = "Mostrar";
            this.btnMostrarProductos.UseVisualStyleBackColor = true;
            this.btnMostrarProductos.Click += new System.EventHandler(this.btnMostrarProductos_Click);
            // 
            // cmbProducto
            // 
            this.cmbProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(340, 82);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(298, 21);
            this.cmbProducto.TabIndex = 26;
            // 
            // btnExportarFecha
            // 
            this.btnExportarFecha.Enabled = false;
            this.btnExportarFecha.Image = global::DP_APP_DESKTOP.Properties.Resources.Excel;
            this.btnExportarFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarFecha.Location = new System.Drawing.Point(155, 68);
            this.btnExportarFecha.Name = "btnExportarFecha";
            this.btnExportarFecha.Size = new System.Drawing.Size(85, 23);
            this.btnExportarFecha.TabIndex = 11;
            this.btnExportarFecha.Text = "Exportar";
            this.btnExportarFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportarFecha.UseVisualStyleBackColor = true;
            this.btnExportarFecha.Click += new System.EventHandler(this.btnExportarFecha_Click);
            // 
            // btnExportarTodo
            // 
            this.btnExportarTodo.Enabled = false;
            this.btnExportarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarTodo.Image")));
            this.btnExportarTodo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarTodo.Location = new System.Drawing.Point(735, 35);
            this.btnExportarTodo.Name = "btnExportarTodo";
            this.btnExportarTodo.Size = new System.Drawing.Size(85, 23);
            this.btnExportarTodo.TabIndex = 8;
            this.btnExportarTodo.Text = "Exportar";
            this.btnExportarTodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportarTodo.UseVisualStyleBackColor = true;
            this.btnExportarTodo.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnExportarProductos
            // 
            this.btnExportarProductos.Enabled = false;
            this.btnExportarProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarProductos.Image")));
            this.btnExportarProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarProductos.Location = new System.Drawing.Point(735, 82);
            this.btnExportarProductos.Name = "btnExportarProductos";
            this.btnExportarProductos.Size = new System.Drawing.Size(85, 23);
            this.btnExportarProductos.TabIndex = 25;
            this.btnExportarProductos.Text = "Exportar";
            this.btnExportarProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportarProductos.UseVisualStyleBackColor = true;
            this.btnExportarProductos.Click += new System.EventHandler(this.btnExportarProductos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDesde);
            this.groupBox1.Controls.Add(this.btnMostrarProductos);
            this.groupBox1.Controls.Add(this.txtHasta);
            this.groupBox1.Controls.Add(this.cmbProducto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnExportarProductos);
            this.groupBox1.Controls.Add(this.btnExportarTodo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnExportarFecha);
            this.groupBox1.Controls.Add(this.btnMostrarLista);
            this.groupBox1.Controls.Add(this.btnMostrar);
            this.groupBox1.Controls.Add(this.cmbMedico);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 115);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione una opción";
            // 
            // frmReportesCuaderno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgProductosCuadernos);
            this.Controls.Add(this.dgCuadernos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportesCuaderno";
            this.Text = "Reportes Sistema Cuadernos";
            this.Load += new System.EventHandler(this.frmReportesCuaderno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCuadernos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductosCuadernos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker txtDesde;
        private System.Windows.Forms.DateTimePicker txtHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgCuadernos;
        private System.Windows.Forms.DataGridView dgProductosCuadernos;
        private System.Windows.Forms.Button btnExportarFecha;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.Button btnMostrarLista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMostrarProductos;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Button btnExportarTodo;
        private System.Windows.Forms.Button btnExportarProductos;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}