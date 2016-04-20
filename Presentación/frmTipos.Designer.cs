namespace Presentación
{
    partial class frmCategorias
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
            this.lblCamposObligatorios = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpbDatosTipo = new System.Windows.Forms.GroupBox();
            this.lblDescripcionRequerida = new System.Windows.Forms.Label();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gpbDatosTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCamposObligatorios
            // 
            this.lblCamposObligatorios.AutoSize = true;
            this.lblCamposObligatorios.ForeColor = System.Drawing.Color.Red;
            this.lblCamposObligatorios.Location = new System.Drawing.Point(12, 85);
            this.lblCamposObligatorios.Name = "lblCamposObligatorios";
            this.lblCamposObligatorios.Size = new System.Drawing.Size(108, 13);
            this.lblCamposObligatorios.TabIndex = 20;
            this.lblCamposObligatorios.Text = "* Campos obligatorios";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(227, 80);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gpbDatosTipo
            // 
            this.gpbDatosTipo.Controls.Add(this.lblDescripcionRequerida);
            this.gpbDatosTipo.Controls.Add(this.txbDescripcion);
            this.gpbDatosTipo.Controls.Add(this.lblTipo);
            this.gpbDatosTipo.Location = new System.Drawing.Point(12, 12);
            this.gpbDatosTipo.Name = "gpbDatosTipo";
            this.gpbDatosTipo.Size = new System.Drawing.Size(290, 62);
            this.gpbDatosTipo.TabIndex = 21;
            this.gpbDatosTipo.TabStop = false;
            this.gpbDatosTipo.Text = "Datos del tipo";
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
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(154, 20);
            this.txbDescripcion.TabIndex = 1;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(9, 31);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(67, 13);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Nombre tipo:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(146, 80);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 22;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmTipos
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(314, 110);
            this.Controls.Add(this.lblCamposObligatorios);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gpbDatosTipo);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de tipos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCategoria_FormClosing);
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            this.gpbDatosTipo.ResumeLayout(false);
            this.gpbDatosTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCamposObligatorios;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gpbDatosTipo;
        private System.Windows.Forms.Label lblDescripcionRequerida;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnAceptar;
    }
}