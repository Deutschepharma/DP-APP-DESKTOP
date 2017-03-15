namespace DP_APP_DESKTOP.view.Sistemas
{
    partial class frmDesbloqueaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDesbloqueaUsuarios));
            this.dgEstados = new System.Windows.Forms.DataGridView();
            this.btnDesbloquear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEstados
            // 
            this.dgEstados.AllowUserToAddRows = false;
            this.dgEstados.AllowUserToDeleteRows = false;
            this.dgEstados.AllowUserToOrderColumns = true;
            this.dgEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEstados.Location = new System.Drawing.Point(12, 12);
            this.dgEstados.Name = "dgEstados";
            this.dgEstados.ReadOnly = true;
            this.dgEstados.Size = new System.Drawing.Size(488, 150);
            this.dgEstados.TabIndex = 0;
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.Location = new System.Drawing.Point(425, 197);
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Size = new System.Drawing.Size(75, 23);
            this.btnDesbloquear.TabIndex = 1;
            this.btnDesbloquear.Text = "Besbloquear";
            this.btnDesbloquear.UseVisualStyleBackColor = true;
            this.btnDesbloquear.Click += new System.EventHandler(this.btnDesbloquear_Click);
            // 
            // frmDesbloqueaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 232);
            this.Controls.Add(this.btnDesbloquear);
            this.Controls.Add(this.dgEstados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDesbloqueaUsuarios";
            this.Text = "Desbloqueo de Usuarios";
            this.Load += new System.EventHandler(this.frmDesbloqueaUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEstados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEstados;
        private System.Windows.Forms.Button btnDesbloquear;
    }
}