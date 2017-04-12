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
            this.btnListar = new System.Windows.Forms.Button();
            this.txtDesde = new System.Windows.Forms.DateTimePicker();
            this.txtHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExportarTodo = new System.Windows.Forms.Button();
            this.dgCuadernos = new System.Windows.Forms.DataGridView();
            this.dgProductosCuadernos = new System.Windows.Forms.DataGridView();
            this.btnExportarFecha = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.btnMostrarLista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCuadernos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductosCuadernos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(787, 74);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar Todo";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtDesde
            // 
            this.txtDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDesde.Location = new System.Drawing.Point(12, 28);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDesde.Size = new System.Drawing.Size(140, 20);
            this.txtDesde.TabIndex = 4;
            this.txtDesde.Value = new System.DateTime(2017, 4, 12, 15, 12, 37, 0);
            // 
            // txtHasta
            // 
            this.txtHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtHasta.Location = new System.Drawing.Point(170, 28);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(140, 20);
            this.txtHasta.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hasta";
            // 
            // btnExportarTodo
            // 
            this.btnExportarTodo.Location = new System.Drawing.Point(394, 53);
            this.btnExportarTodo.Name = "btnExportarTodo";
            this.btnExportarTodo.Size = new System.Drawing.Size(130, 23);
            this.btnExportarTodo.TabIndex = 8;
            this.btnExportarTodo.Text = "Exportar";
            this.btnExportarTodo.UseVisualStyleBackColor = true;
            this.btnExportarTodo.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // dgCuadernos
            // 
            this.dgCuadernos.AllowUserToAddRows = false;
            this.dgCuadernos.AllowUserToDeleteRows = false;
            this.dgCuadernos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCuadernos.Location = new System.Drawing.Point(12, 103);
            this.dgCuadernos.Name = "dgCuadernos";
            this.dgCuadernos.ReadOnly = true;
            this.dgCuadernos.Size = new System.Drawing.Size(850, 248);
            this.dgCuadernos.TabIndex = 9;
            this.dgCuadernos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCuadernos_CellClick);
            // 
            // dgProductosCuadernos
            // 
            this.dgProductosCuadernos.AllowUserToAddRows = false;
            this.dgProductosCuadernos.AllowUserToDeleteRows = false;
            this.dgProductosCuadernos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductosCuadernos.Location = new System.Drawing.Point(13, 358);
            this.dgProductosCuadernos.Name = "dgProductosCuadernos";
            this.dgProductosCuadernos.ReadOnly = true;
            this.dgProductosCuadernos.Size = new System.Drawing.Size(850, 137);
            this.dgProductosCuadernos.TabIndex = 10;
            // 
            // btnExportarFecha
            // 
            this.btnExportarFecha.Location = new System.Drawing.Point(394, 25);
            this.btnExportarFecha.Name = "btnExportarFecha";
            this.btnExportarFecha.Size = new System.Drawing.Size(130, 23);
            this.btnExportarFecha.TabIndex = 11;
            this.btnExportarFecha.Text = "Exportar Rango Fecha";
            this.btnExportarFecha.UseVisualStyleBackColor = true;
            this.btnExportarFecha.Click += new System.EventHandler(this.btnExportarFecha_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(316, 25);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(72, 23);
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
            this.cmbMedico.Location = new System.Drawing.Point(12, 54);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(298, 21);
            this.cmbMedico.TabIndex = 22;
            // 
            // btnMostrarLista
            // 
            this.btnMostrarLista.Location = new System.Drawing.Point(316, 53);
            this.btnMostrarLista.Name = "btnMostrarLista";
            this.btnMostrarLista.Size = new System.Drawing.Size(72, 23);
            this.btnMostrarLista.TabIndex = 23;
            this.btnMostrarLista.Text = "Mostrar";
            this.btnMostrarLista.UseVisualStyleBackColor = true;
            this.btnMostrarLista.Click += new System.EventHandler(this.btnMostrarLista_Click);
            // 
            // frmReportesCuaderno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 507);
            this.Controls.Add(this.btnMostrarLista);
            this.Controls.Add(this.cmbMedico);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnExportarFecha);
            this.Controls.Add(this.dgProductosCuadernos);
            this.Controls.Add(this.dgCuadernos);
            this.Controls.Add(this.btnExportarTodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.btnListar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportesCuaderno";
            this.Text = "Reportes Sistema Cuadernos";
            this.Load += new System.EventHandler(this.frmReportesCuaderno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCuadernos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductosCuadernos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DateTimePicker txtDesde;
        private System.Windows.Forms.DateTimePicker txtHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExportarTodo;
        private System.Windows.Forms.DataGridView dgCuadernos;
        private System.Windows.Forms.DataGridView dgProductosCuadernos;
        private System.Windows.Forms.Button btnExportarFecha;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.Button btnMostrarLista;
    }
}