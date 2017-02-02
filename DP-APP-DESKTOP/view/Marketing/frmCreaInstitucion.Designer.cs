namespace DP_APP_DESKTOP.view.Marketing
{
    partial class frmCreaInstitucion
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
            this.txtFono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtIntitucion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFono
            // 
            this.txtFono.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFono.Location = new System.Drawing.Point(127, 70);
            this.txtFono.Name = "txtFono";
            this.txtFono.Size = new System.Drawing.Size(324, 23);
            this.txtFono.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 15);
            this.label7.TabIndex = 36;
            this.label7.Text = "Telefono Institución";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(127, 41);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(324, 23);
            this.txtDireccion.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "Dirección Institución";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(376, 114);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 27;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtIntitucion
            // 
            this.txtIntitucion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntitucion.Location = new System.Drawing.Point(127, 12);
            this.txtIntitucion.Name = "txtIntitucion";
            this.txtIntitucion.Size = new System.Drawing.Size(324, 23);
            this.txtIntitucion.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nombre Institución";
            // 
            // frmCreaInstitucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 149);
            this.Controls.Add(this.txtFono);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtIntitucion);
            this.Controls.Add(this.label2);
            this.Name = "frmCreaInstitucion";
            this.Text = "Crea Nueva Institucion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtIntitucion;
        private System.Windows.Forms.Label label2;
    }
}