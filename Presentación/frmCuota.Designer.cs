namespace Presentación
{
    partial class frmCuota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuota));
            this.gpbDatosCuota = new System.Windows.Forms.GroupBox();
            this.tbxAño = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxImporte = new System.Windows.Forms.TextBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblDireccionRequerido = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.lblCamposObligatorios = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ckbCrearTodoAño = new System.Windows.Forms.CheckBox();
            this.gpbDatosCuota.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDatosCuota
            // 
            this.gpbDatosCuota.Controls.Add(this.tbxAño);
            this.gpbDatosCuota.Controls.Add(this.label2);
            this.gpbDatosCuota.Controls.Add(this.label1);
            this.gpbDatosCuota.Controls.Add(this.tbxImporte);
            this.gpbDatosCuota.Controls.Add(this.lblImporte);
            this.gpbDatosCuota.Controls.Add(this.lblAño);
            this.gpbDatosCuota.Controls.Add(this.lblDireccionRequerido);
            this.gpbDatosCuota.Controls.Add(this.lblMes);
            this.gpbDatosCuota.Controls.Add(this.cmbMes);
            this.gpbDatosCuota.Location = new System.Drawing.Point(13, 13);
            this.gpbDatosCuota.Name = "gpbDatosCuota";
            this.gpbDatosCuota.Size = new System.Drawing.Size(268, 122);
            this.gpbDatosCuota.TabIndex = 0;
            this.gpbDatosCuota.TabStop = false;
            this.gpbDatosCuota.Text = "Datos de la cuota";
            // 
            // tbxAño
            // 
            this.tbxAño.Enabled = false;
            this.tbxAño.Location = new System.Drawing.Point(145, 58);
            this.tbxAño.Name = "tbxAño";
            this.tbxAño.Size = new System.Drawing.Size(100, 20);
            this.tbxAño.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(251, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(251, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "*";
            // 
            // tbxImporte
            // 
            this.tbxImporte.Location = new System.Drawing.Point(145, 88);
            this.tbxImporte.MaxLength = 50;
            this.tbxImporte.Name = "tbxImporte";
            this.tbxImporte.Size = new System.Drawing.Size(100, 20);
            this.tbxImporte.TabIndex = 3;
            this.tbxImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IngresoSoloNumeros);
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(9, 91);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(45, 13);
            this.lblImporte.TabIndex = 5;
            this.lblImporte.Text = "Importe:";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(9, 61);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(29, 13);
            this.lblAño.TabIndex = 4;
            this.lblAño.Text = "Año:";
            // 
            // lblDireccionRequerido
            // 
            this.lblDireccionRequerido.AutoSize = true;
            this.lblDireccionRequerido.ForeColor = System.Drawing.Color.Red;
            this.lblDireccionRequerido.Location = new System.Drawing.Point(251, 31);
            this.lblDireccionRequerido.Name = "lblDireccionRequerido";
            this.lblDireccionRequerido.Size = new System.Drawing.Size(11, 13);
            this.lblDireccionRequerido.TabIndex = 11;
            this.lblDireccionRequerido.Text = "*";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(9, 31);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(30, 13);
            this.lblMes.TabIndex = 3;
            this.lblMes.Text = "Mes:";
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmbMes.Location = new System.Drawing.Point(145, 28);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(100, 21);
            this.cmbMes.TabIndex = 1;
            // 
            // lblCamposObligatorios
            // 
            this.lblCamposObligatorios.AutoSize = true;
            this.lblCamposObligatorios.ForeColor = System.Drawing.Color.Red;
            this.lblCamposObligatorios.Location = new System.Drawing.Point(10, 174);
            this.lblCamposObligatorios.Name = "lblCamposObligatorios";
            this.lblCamposObligatorios.Size = new System.Drawing.Size(108, 13);
            this.lblCamposObligatorios.TabIndex = 0;
            this.lblCamposObligatorios.Text = "* Campos obligatorios";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(125, 169);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(206, 169);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ckbCrearTodoAño
            // 
            this.ckbCrearTodoAño.AutoSize = true;
            this.ckbCrearTodoAño.Location = new System.Drawing.Point(14, 142);
            this.ckbCrearTodoAño.Name = "ckbCrearTodoAño";
            this.ckbCrearTodoAño.Size = new System.Drawing.Size(131, 17);
            this.ckbCrearTodoAño.TabIndex = 4;
            this.ckbCrearTodoAño.Text = "Crear para todo el año";
            this.ckbCrearTodoAño.UseVisualStyleBackColor = true;
            this.ckbCrearTodoAño.CheckedChanged += new System.EventHandler(this.ckbCrearTodoAño_CheckedChanged);
            // 
            // frmCuota
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(293, 204);
            this.Controls.Add(this.ckbCrearTodoAño);
            this.Controls.Add(this.lblCamposObligatorios);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gpbDatosCuota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCuota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de cuota";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCuota_FormClosing);
            this.Load += new System.EventHandler(this.frmCuota_Load);
            this.gpbDatosCuota.ResumeLayout(false);
            this.gpbDatosCuota.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDatosCuota;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.TextBox tbxImporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDireccionRequerido;
        private System.Windows.Forms.Label lblCamposObligatorios;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox tbxAño;
        private System.Windows.Forms.CheckBox ckbCrearTodoAño;
        private System.Windows.Forms.ComboBox cmbMes;
    }
}