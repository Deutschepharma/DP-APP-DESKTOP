namespace DP_APP_DESKTOP.view
{
    partial class frmMuestras
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
            this.cmbAño = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPruebas = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FEBRERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARZO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ABRIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAYO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JUNIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JULIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AGOSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEPTIEMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OCTUBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOVIEMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DICIEMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAño
            // 
            this.cmbAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAño.FormattingEnabled = true;
            this.cmbAño.Location = new System.Drawing.Point(12, 29);
            this.cmbAño.Name = "cmbAño";
            this.cmbAño.Size = new System.Drawing.Size(121, 21);
            this.cmbAño.TabIndex = 0;
            this.cmbAño.SelectedIndexChanged += new System.EventHandler(this.cmbAño_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione Año de Trabajo";
            // 
            // btnPruebas
            // 
            this.btnPruebas.Location = new System.Drawing.Point(921, 12);
            this.btnPruebas.Name = "btnPruebas";
            this.btnPruebas.Size = new System.Drawing.Size(75, 23);
            this.btnPruebas.TabIndex = 2;
            this.btnPruebas.Text = "Pruebas";
            this.btnPruebas.UseVisualStyleBackColor = true;
            this.btnPruebas.Click += new System.EventHandler(this.btnPruebas_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CODIGO,
            this.ENERO,
            this.FEBRERO,
            this.MARZO,
            this.ABRIL,
            this.MAYO,
            this.JUNIO,
            this.JULIO,
            this.AGOSTO,
            this.SEPTIEMBRE,
            this.OCTUBRE,
            this.NOVIEMBRE,
            this.DICIEMBRE});
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1240, 484);
            this.dataGridView1.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 60;
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.Width = 80;
            // 
            // ENERO
            // 
            this.ENERO.HeaderText = "ENERO";
            this.ENERO.Name = "ENERO";
            this.ENERO.Width = 80;
            // 
            // FEBRERO
            // 
            this.FEBRERO.HeaderText = "FEBRERO";
            this.FEBRERO.Name = "FEBRERO";
            this.FEBRERO.Width = 80;
            // 
            // MARZO
            // 
            this.MARZO.HeaderText = "MARZO";
            this.MARZO.Name = "MARZO";
            this.MARZO.Width = 80;
            // 
            // ABRIL
            // 
            this.ABRIL.HeaderText = "ABRIL";
            this.ABRIL.Name = "ABRIL";
            this.ABRIL.Width = 80;
            // 
            // MAYO
            // 
            this.MAYO.HeaderText = "MAYO";
            this.MAYO.Name = "MAYO";
            this.MAYO.Width = 80;
            // 
            // JUNIO
            // 
            this.JUNIO.HeaderText = "JUNIO";
            this.JUNIO.Name = "JUNIO";
            this.JUNIO.Width = 80;
            // 
            // JULIO
            // 
            this.JULIO.HeaderText = "JULIO";
            this.JULIO.Name = "JULIO";
            this.JULIO.Width = 80;
            // 
            // AGOSTO
            // 
            this.AGOSTO.HeaderText = "AGOSTO";
            this.AGOSTO.Name = "AGOSTO";
            this.AGOSTO.Width = 80;
            // 
            // SEPTIEMBRE
            // 
            this.SEPTIEMBRE.HeaderText = "SEPTIEMBRE";
            this.SEPTIEMBRE.Name = "SEPTIEMBRE";
            this.SEPTIEMBRE.Width = 80;
            // 
            // OCTUBRE
            // 
            this.OCTUBRE.HeaderText = "OCTUBRE";
            this.OCTUBRE.Name = "OCTUBRE";
            this.OCTUBRE.Width = 80;
            // 
            // NOVIEMBRE
            // 
            this.NOVIEMBRE.HeaderText = "NOVIEMBRE";
            this.NOVIEMBRE.Name = "NOVIEMBRE";
            this.NOVIEMBRE.Width = 80;
            // 
            // DICIEMBRE
            // 
            this.DICIEMBRE.HeaderText = "DICIEMBRE";
            this.DICIEMBRE.Name = "DICIEMBRE";
            this.DICIEMBRE.Width = 80;
            // 
            // frmMuestras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPruebas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAño);
            this.Name = "frmMuestras";
            this.Text = "frmMuestras";
            this.Load += new System.EventHandler(this.frmMuestras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPruebas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENERO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FEBRERO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARZO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ABRIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAYO;
        private System.Windows.Forms.DataGridViewTextBoxColumn JUNIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn JULIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn AGOSTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEPTIEMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn OCTUBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOVIEMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DICIEMBRE;
    }
}