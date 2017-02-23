namespace DP_APP_DESKTOP.view.Utilidades
{
    partial class frmCambiaClave
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
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtClaveRep = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCambia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(85, 30);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(140, 20);
            this.txtClave.TabIndex = 1;
            // 
            // txtClaveRep
            // 
            this.txtClaveRep.Location = new System.Drawing.Point(85, 56);
            this.txtClaveRep.Name = "txtClaveRep";
            this.txtClaveRep.PasswordChar = '*';
            this.txtClaveRep.Size = new System.Drawing.Size(140, 20);
            this.txtClaveRep.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Repita Clave";
            // 
            // btnCambia
            // 
            this.btnCambia.Location = new System.Drawing.Point(150, 84);
            this.btnCambia.Name = "btnCambia";
            this.btnCambia.Size = new System.Drawing.Size(75, 23);
            this.btnCambia.TabIndex = 4;
            this.btnCambia.Text = "Cambiar";
            this.btnCambia.UseVisualStyleBackColor = true;
            this.btnCambia.Click += new System.EventHandler(this.btnCambia_Click);
            // 
            // frmCambiaClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 119);
            this.Controls.Add(this.btnCambia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClaveRep);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label1);
            this.Name = "frmCambiaClave";
            this.Text = "frmCambiaClave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtClaveRep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCambia;
    }
}