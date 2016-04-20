namespace Presentación
{
    partial class frmPagoCuota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagoCuota));
            this.gpbDatosPagoCuota = new System.Windows.Forms.GroupBox();
            this.txbCuota = new System.Windows.Forms.TextBox();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.txbImporte = new System.Windows.Forms.TextBox();
            this.lblFechaPago = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblFechaCuota = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpbDatosPagoCuota.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDatosPagoCuota
            // 
            this.gpbDatosPagoCuota.Controls.Add(this.txbCuota);
            this.gpbDatosPagoCuota.Controls.Add(this.dtpFechaPago);
            this.gpbDatosPagoCuota.Controls.Add(this.txbImporte);
            this.gpbDatosPagoCuota.Controls.Add(this.lblFechaPago);
            this.gpbDatosPagoCuota.Controls.Add(this.lblImporte);
            this.gpbDatosPagoCuota.Controls.Add(this.lblFechaCuota);
            this.gpbDatosPagoCuota.Location = new System.Drawing.Point(13, 13);
            this.gpbDatosPagoCuota.Name = "gpbDatosPagoCuota";
            this.gpbDatosPagoCuota.Size = new System.Drawing.Size(249, 122);
            this.gpbDatosPagoCuota.TabIndex = 0;
            this.gpbDatosPagoCuota.TabStop = false;
            this.gpbDatosPagoCuota.Text = "Datos del pago de cuota";
            // 
            // txbCuota
            // 
            this.txbCuota.Enabled = false;
            this.txbCuota.Location = new System.Drawing.Point(133, 28);
            this.txbCuota.Name = "txbCuota";
            this.txbCuota.Size = new System.Drawing.Size(100, 20);
            this.txbCuota.TabIndex = 1;
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaPago.Location = new System.Drawing.Point(133, 88);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaPago.TabIndex = 3;
            this.dtpFechaPago.Value = new System.DateTime(2014, 3, 19, 0, 0, 0, 0);
            // 
            // txbImporte
            // 
            this.txbImporte.Enabled = false;
            this.txbImporte.Location = new System.Drawing.Point(133, 58);
            this.txbImporte.Name = "txbImporte";
            this.txbImporte.Size = new System.Drawing.Size(100, 20);
            this.txbImporte.TabIndex = 2;
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Location = new System.Drawing.Point(9, 91);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(82, 13);
            this.lblFechaPago.TabIndex = 0;
            this.lblFechaPago.Text = "Fecha de pago:";
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(9, 61);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(45, 13);
            this.lblImporte.TabIndex = 0;
            this.lblImporte.Text = "Importe:";
            // 
            // lblFechaCuota
            // 
            this.lblFechaCuota.AutoSize = true;
            this.lblFechaCuota.Location = new System.Drawing.Point(9, 31);
            this.lblFechaCuota.Name = "lblFechaCuota";
            this.lblFechaCuota.Size = new System.Drawing.Size(38, 13);
            this.lblFechaCuota.TabIndex = 0;
            this.lblFechaCuota.Text = "Cuota:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(108, 141);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(189, 141);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmPagoCuota
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(276, 172);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gpbDatosPagoCuota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPagoCuota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago de cuota";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPagoCuota_FormClosing);
            this.Load += new System.EventHandler(this.frmPagoCuota_Load);
            this.gpbDatosPagoCuota.ResumeLayout(false);
            this.gpbDatosPagoCuota.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDatosPagoCuota;
        private System.Windows.Forms.Label lblFechaPago;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblFechaCuota;
        private System.Windows.Forms.TextBox txbImporte;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txbCuota;
    }
}