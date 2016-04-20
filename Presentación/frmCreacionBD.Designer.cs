namespace Presentación
{
    partial class frmCreacionBD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreacionBD));
            this.lblInfo = new System.Windows.Forms.Label();
            this.pgbCreacionBD = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(13, 13);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(316, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Creando base de datos. Este proceso puede tardar unos minutos.";
            // 
            // pgbCreacionBD
            // 
            this.pgbCreacionBD.Location = new System.Drawing.Point(16, 48);
            this.pgbCreacionBD.Name = "pgbCreacionBD";
            this.pgbCreacionBD.Size = new System.Drawing.Size(313, 23);
            this.pgbCreacionBD.Step = 20;
            this.pgbCreacionBD.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pgbCreacionBD.TabIndex = 1;
            // 
            // frmCreacionBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 92);
            this.Controls.Add(this.pgbCreacionBD);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCreacionBD";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creación de base de datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ProgressBar pgbCreacionBD;
    }
}