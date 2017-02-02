namespace DP_APP_DESKTOP.view.Utilitarios
{
    partial class frmCreaMedico
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtDv = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtPaterno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaterno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.btnNuevaEspecialidad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // txtRut
            // 
            this.txtRut.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRut.Location = new System.Drawing.Point(136, 13);
            this.txtRut.MaxLength = 8;
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(196, 23);
            this.txtRut.TabIndex = 2;
            this.txtRut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRut_KeyPress);
            // 
            // txtDv
            // 
            this.txtDv.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDv.Location = new System.Drawing.Point(355, 13);
            this.txtDv.MaxLength = 1;
            this.txtDv.Name = "txtDv";
            this.txtDv.Size = new System.Drawing.Size(31, 23);
            this.txtDv.TabIndex = 3;
            this.txtDv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDv_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(136, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 23);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Especialidad";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(261, 231);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtPaterno
            // 
            this.txtPaterno.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaterno.Location = new System.Drawing.Point(136, 65);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(250, 23);
            this.txtPaterno.TabIndex = 10;
            this.txtPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaterno_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Apellido Paterno";
            // 
            // txtMaterno
            // 
            this.txtMaterno.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterno.Location = new System.Drawing.Point(136, 91);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(250, 23);
            this.txtMaterno.TabIndex = 12;
            this.txtMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaterno_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Apellido Materno";
            // 
            // dtNacimiento
            // 
            this.dtNacimiento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNacimiento.Location = new System.Drawing.Point(136, 144);
            this.dtNacimiento.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtNacimiento.Name = "dtNacimiento";
            this.dtNacimiento.Size = new System.Drawing.Size(250, 23);
            this.dtNacimiento.TabIndex = 13;
            this.dtNacimiento.Value = new System.DateTime(2017, 2, 2, 10, 36, 3, 0);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(136, 170);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 23);
            this.txtEmail.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "E-Mail";
            // 
            // txtFono
            // 
            this.txtFono.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFono.Location = new System.Drawing.Point(136, 196);
            this.txtFono.MaxLength = 15;
            this.txtFono.Name = "txtFono";
            this.txtFono.Size = new System.Drawing.Size(250, 23);
            this.txtFono.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Telefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Fecha Nacimiento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(338, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "-";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(136, 117);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(250, 21);
            this.cmbEspecialidad.TabIndex = 20;
            // 
            // btnNuevaEspecialidad
            // 
            this.btnNuevaEspecialidad.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaEspecialidad.Location = new System.Drawing.Point(392, 116);
            this.btnNuevaEspecialidad.Name = "btnNuevaEspecialidad";
            this.btnNuevaEspecialidad.Size = new System.Drawing.Size(25, 23);
            this.btnNuevaEspecialidad.TabIndex = 21;
            this.btnNuevaEspecialidad.Text = "+";
            this.btnNuevaEspecialidad.UseVisualStyleBackColor = true;
            this.btnNuevaEspecialidad.Click += new System.EventHandler(this.btnNuevaEspecialidad_Click);
            // 
            // frmCreaMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 266);
            this.Controls.Add(this.btnNuevaEspecialidad);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFono);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtNacimiento);
            this.Controls.Add(this.txtMaterno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPaterno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDv);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCreaMedico";
            this.Text = "Registro Nuevo Medico";
            this.Load += new System.EventHandler(this.frmCreaMedico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.TextBox txtDv;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtPaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaterno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtNacimiento;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Button btnNuevaEspecialidad;
    }
}