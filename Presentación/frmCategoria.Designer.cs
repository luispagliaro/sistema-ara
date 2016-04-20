namespace Presentación
{
    partial class frmCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoria));
            this.lblCamposObligatorios = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpbDatosCategoria = new System.Windows.Forms.GroupBox();
            this.lblDescripcionRequerida = new System.Windows.Forms.Label();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gpbDatosCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCamposObligatorios
            // 
            this.lblCamposObligatorios.AutoSize = true;
            this.lblCamposObligatorios.ForeColor = System.Drawing.Color.Red;
            this.lblCamposObligatorios.Location = new System.Drawing.Point(12, 85);
            this.lblCamposObligatorios.Name = "lblCamposObligatorios";
            this.lblCamposObligatorios.Size = new System.Drawing.Size(108, 13);
            this.lblCamposObligatorios.TabIndex = 0;
            this.lblCamposObligatorios.Text = "* Campos obligatorios";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(227, 80);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gpbDatosCategoria
            // 
            this.gpbDatosCategoria.Controls.Add(this.lblDescripcionRequerida);
            this.gpbDatosCategoria.Controls.Add(this.txbDescripcion);
            this.gpbDatosCategoria.Controls.Add(this.lblCategoria);
            this.gpbDatosCategoria.Location = new System.Drawing.Point(12, 12);
            this.gpbDatosCategoria.Name = "gpbDatosCategoria";
            this.gpbDatosCategoria.Size = new System.Drawing.Size(290, 62);
            this.gpbDatosCategoria.TabIndex = 0;
            this.gpbDatosCategoria.TabStop = false;
            this.gpbDatosCategoria.Text = "Datos de la categoría";
            // 
            // lblDescripcionRequerida
            // 
            this.lblDescripcionRequerida.AutoSize = true;
            this.lblDescripcionRequerida.ForeColor = System.Drawing.Color.Red;
            this.lblDescripcionRequerida.Location = new System.Drawing.Point(271, 31);
            this.lblDescripcionRequerida.Name = "lblDescripcionRequerida";
            this.lblDescripcionRequerida.Size = new System.Drawing.Size(11, 13);
            this.lblDescripcionRequerida.TabIndex = 16;
            this.lblDescripcionRequerida.Text = "*";
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Location = new System.Drawing.Point(111, 28);
            this.txbDescripcion.MaxLength = 50;
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(154, 20);
            this.txbDescripcion.TabIndex = 1;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(9, 31);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(96, 13);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Nombre categoría:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(146, 80);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmCategoria
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(314, 110);
            this.Controls.Add(this.lblCamposObligatorios);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gpbDatosCategoria);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de categoría";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCategoria_FormClosing);
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            this.gpbDatosCategoria.ResumeLayout(false);
            this.gpbDatosCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCamposObligatorios;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gpbDatosCategoria;
        private System.Windows.Forms.Label lblDescripcionRequerida;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnAceptar;
    }
}