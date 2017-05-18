namespace DP_APP_DESKTOP.view.Utilidades
{
    partial class frmMailing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMailing));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCuentaRemitente = new System.Windows.Forms.ComboBox();
            this.lblEnviar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.bar = new System.Windows.Forms.ProgressBar();
            this.btnAbrirArchivo = new System.Windows.Forms.Button();
            this.txtCuerpo = new System.Windows.Forms.TextBox();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbUsuario);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbCuentaRemitente);
            this.groupBox1.Controls.Add(this.lblEnviar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Seleccionar Base";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(103, 46);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(233, 21);
            this.cmbUsuario.TabIndex = 15;
            this.cmbUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbUsuario_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cuenta Remitente";
            // 
            // cmbCuentaRemitente
            // 
            this.cmbCuentaRemitente.FormattingEnabled = true;
            this.cmbCuentaRemitente.Location = new System.Drawing.Point(103, 19);
            this.cmbCuentaRemitente.Name = "cmbCuentaRemitente";
            this.cmbCuentaRemitente.Size = new System.Drawing.Size(233, 21);
            this.cmbCuentaRemitente.TabIndex = 13;
            this.cmbCuentaRemitente.SelectedIndexChanged += new System.EventHandler(this.cmbCuentaRemitente_SelectedIndexChanged);
            // 
            // lblEnviar
            // 
            this.lblEnviar.AutoSize = true;
            this.lblEnviar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnviar.Location = new System.Drawing.Point(514, 40);
            this.lblEnviar.Name = "lblEnviar";
            this.lblEnviar.Size = new System.Drawing.Size(70, 15);
            this.lblEnviar.TabIndex = 0;
            this.lblEnviar.Text = "lblEnviar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(514, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad por Enviar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEnviar);
            this.groupBox2.Controls.Add(this.bar);
            this.groupBox2.Controls.Add(this.btnAbrirArchivo);
            this.groupBox2.Controls.Add(this.txtCuerpo);
            this.groupBox2.Controls.Add(this.txtArchivo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtAsunto);
            this.groupBox2.Location = new System.Drawing.Point(13, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 335);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(579, 295);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // bar
            // 
            this.bar.Location = new System.Drawing.Point(10, 295);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(557, 23);
            this.bar.TabIndex = 4;
            // 
            // btnAbrirArchivo
            // 
            this.btnAbrirArchivo.Location = new System.Drawing.Point(9, 78);
            this.btnAbrirArchivo.Name = "btnAbrirArchivo";
            this.btnAbrirArchivo.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirArchivo.TabIndex = 3;
            this.btnAbrirArchivo.Text = "Abrir Archivo";
            this.btnAbrirArchivo.UseVisualStyleBackColor = true;
            this.btnAbrirArchivo.Click += new System.EventHandler(this.btnAbrirArchivo_Click);
            // 
            // txtCuerpo
            // 
            this.txtCuerpo.Location = new System.Drawing.Point(9, 120);
            this.txtCuerpo.Multiline = true;
            this.txtCuerpo.Name = "txtCuerpo";
            this.txtCuerpo.Size = new System.Drawing.Size(645, 169);
            this.txtCuerpo.TabIndex = 7;
            // 
            // txtArchivo
            // 
            this.txtArchivo.Enabled = false;
            this.txtArchivo.Location = new System.Drawing.Point(90, 80);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(564, 20);
            this.txtArchivo.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cuerpo de Mensaje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Asunto";
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(9, 32);
            this.txtAsunto.Multiline = true;
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(645, 40);
            this.txtAsunto.TabIndex = 3;
            // 
            // frmMailing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMailing";
            this.Text = "Mail Masivos";
            this.Load += new System.EventHandler(this.frmMailing_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCuentaRemitente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Button btnAbrirArchivo;
        private System.Windows.Forms.TextBox txtCuerpo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEnviar;
        private System.Windows.Forms.ProgressBar bar;
        private System.Windows.Forms.Button btnEnviar;
    }
}