namespace DP_APP_DESKTOP.view.Sistemas
{
    partial class frmRegistraNuevoMenu
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
            this.txtString = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnGuardad = new System.Windows.Forms.Button();
            this.lsMenus = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor String";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(72, 6);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(355, 20);
            this.txtString.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(72, 34);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(355, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // btnGuardad
            // 
            this.btnGuardad.Location = new System.Drawing.Point(352, 60);
            this.btnGuardad.Name = "btnGuardad";
            this.btnGuardad.Size = new System.Drawing.Size(75, 23);
            this.btnGuardad.TabIndex = 4;
            this.btnGuardad.Text = "Guardar";
            this.btnGuardad.UseVisualStyleBackColor = true;
            this.btnGuardad.Click += new System.EventHandler(this.btnGuardad_Click);
            // 
            // lsMenus
            // 
            this.lsMenus.FormattingEnabled = true;
            this.lsMenus.Location = new System.Drawing.Point(15, 87);
            this.lsMenus.Name = "lsMenus";
            this.lsMenus.Size = new System.Drawing.Size(412, 251);
            this.lsMenus.TabIndex = 5;
            // 
            // frmRegistraNuevoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 358);
            this.Controls.Add(this.lsMenus);
            this.Controls.Add(this.btnGuardad);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRegistraNuevoMenu";
            this.Text = "frmRegistraNuevoMenu";
            this.Load += new System.EventHandler(this.frmRegistraNuevoMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnGuardad;
        private System.Windows.Forms.ListBox lsMenus;
    }
}