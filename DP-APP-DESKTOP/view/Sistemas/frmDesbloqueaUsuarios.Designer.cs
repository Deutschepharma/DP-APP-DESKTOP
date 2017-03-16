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
            this.btnDesbloquear = new System.Windows.Forms.Button();
            this.lsUsuarios = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.Location = new System.Drawing.Point(264, 12);
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Size = new System.Drawing.Size(75, 23);
            this.btnDesbloquear.TabIndex = 1;
            this.btnDesbloquear.Text = "Besbloquear";
            this.btnDesbloquear.UseVisualStyleBackColor = true;
            this.btnDesbloquear.Click += new System.EventHandler(this.btnDesbloquear_Click);
            // 
            // lsUsuarios
            // 
            this.lsUsuarios.FormattingEnabled = true;
            this.lsUsuarios.Location = new System.Drawing.Point(12, 12);
            this.lsUsuarios.Name = "lsUsuarios";
            this.lsUsuarios.Size = new System.Drawing.Size(246, 212);
            this.lsUsuarios.TabIndex = 2;
            // 
            // frmDesbloqueaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 232);
            this.Controls.Add(this.lsUsuarios);
            this.Controls.Add(this.btnDesbloquear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDesbloqueaUsuarios";
            this.Text = "Desbloqueo de Usuarios";
            this.Load += new System.EventHandler(this.frmDesbloqueaUsuarios_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDesbloquear;
        private System.Windows.Forms.ListBox lsUsuarios;
    }
}