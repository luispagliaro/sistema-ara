namespace Presentación
{
    partial class frmTorneo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTorneo));
            this.gpbDatosTorneo = new System.Windows.Forms.GroupBox();
            this.lblCostoInscrRequerido = new System.Windows.Forms.Label();
            this.txbCostoInscripcion = new System.Windows.Forms.TextBox();
            this.lblCostoInscripcion = new System.Windows.Forms.Label();
            this.lblDireccionRequerida = new System.Windows.Forms.Label();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblArbitroRequerido = new System.Windows.Forms.Label();
            this.lblTipoRequerido = new System.Windows.Forms.Label();
            this.lblFechaRequerida = new System.Windows.Forms.Label();
            this.lblLugarRequerido = new System.Windows.Forms.Label();
            this.lblNombreRequerido = new System.Windows.Forms.Label();
            this.cmbArbitro = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txbLugar = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lblArbitro = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCamposObligatorios = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gpbDatosTorneo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDatosTorneo
            // 
            this.gpbDatosTorneo.Controls.Add(this.lblCostoInscrRequerido);
            this.gpbDatosTorneo.Controls.Add(this.txbCostoInscripcion);
            this.gpbDatosTorneo.Controls.Add(this.lblCostoInscripcion);
            this.gpbDatosTorneo.Controls.Add(this.lblDireccionRequerida);
            this.gpbDatosTorneo.Controls.Add(this.txbDireccion);
            this.gpbDatosTorneo.Controls.Add(this.lblDireccion);
            this.gpbDatosTorneo.Controls.Add(this.lblArbitroRequerido);
            this.gpbDatosTorneo.Controls.Add(this.lblTipoRequerido);
            this.gpbDatosTorneo.Controls.Add(this.lblFechaRequerida);
            this.gpbDatosTorneo.Controls.Add(this.lblLugarRequerido);
            this.gpbDatosTorneo.Controls.Add(this.lblNombreRequerido);
            this.gpbDatosTorneo.Controls.Add(this.cmbArbitro);
            this.gpbDatosTorneo.Controls.Add(this.cmbTipo);
            this.gpbDatosTorneo.Controls.Add(this.dtpFecha);
            this.gpbDatosTorneo.Controls.Add(this.txbLugar);
            this.gpbDatosTorneo.Controls.Add(this.txbNombre);
            this.gpbDatosTorneo.Controls.Add(this.lblArbitro);
            this.gpbDatosTorneo.Controls.Add(this.lblTipo);
            this.gpbDatosTorneo.Controls.Add(this.lblFecha);
            this.gpbDatosTorneo.Controls.Add(this.lblLugar);
            this.gpbDatosTorneo.Controls.Add(this.lblNombre);
            this.gpbDatosTorneo.Location = new System.Drawing.Point(13, 13);
            this.gpbDatosTorneo.Name = "gpbDatosTorneo";
            this.gpbDatosTorneo.Size = new System.Drawing.Size(370, 241);
            this.gpbDatosTorneo.TabIndex = 0;
            this.gpbDatosTorneo.TabStop = false;
            this.gpbDatosTorneo.Text = "Datos del torneo";
            // 
            // lblCostoInscrRequerido
            // 
            this.lblCostoInscrRequerido.AutoSize = true;
            this.lblCostoInscrRequerido.ForeColor = System.Drawing.Color.Red;
            this.lblCostoInscrRequerido.Location = new System.Drawing.Point(242, 211);
            this.lblCostoInscrRequerido.Name = "lblCostoInscrRequerido";
            this.lblCostoInscrRequerido.Size = new System.Drawing.Size(11, 13);
            this.lblCostoInscrRequerido.TabIndex = 0;
            this.lblCostoInscrRequerido.Text = "*";
            // 
            // txbCostoInscripcion
            // 
            this.txbCostoInscripcion.Location = new System.Drawing.Point(105, 208);
            this.txbCostoInscripcion.Name = "txbCostoInscripcion";
            this.txbCostoInscripcion.Size = new System.Drawing.Size(131, 20);
            this.txbCostoInscripcion.TabIndex = 7;
            this.txbCostoInscripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumerosComa);
            // 
            // lblCostoInscripcion
            // 
            this.lblCostoInscripcion.AutoSize = true;
            this.lblCostoInscripcion.Location = new System.Drawing.Point(9, 211);
            this.lblCostoInscripcion.Name = "lblCostoInscripcion";
            this.lblCostoInscripcion.Size = new System.Drawing.Size(90, 13);
            this.lblCostoInscripcion.TabIndex = 0;
            this.lblCostoInscripcion.Text = "Costo inscripción:";
            // 
            // lblDireccionRequerida
            // 
            this.lblDireccionRequerida.AutoSize = true;
            this.lblDireccionRequerida.ForeColor = System.Drawing.Color.Red;
            this.lblDireccionRequerida.Location = new System.Drawing.Point(242, 91);
            this.lblDireccionRequerida.Name = "lblDireccionRequerida";
            this.lblDireccionRequerida.Size = new System.Drawing.Size(11, 13);
            this.lblDireccionRequerida.TabIndex = 0;
            this.lblDireccionRequerida.Text = "*";
            // 
            // txbDireccion
            // 
            this.txbDireccion.Location = new System.Drawing.Point(77, 88);
            this.txbDireccion.MaxLength = 50;
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(159, 20);
            this.txbDireccion.TabIndex = 3;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(9, 91);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 8;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblArbitroRequerido
            // 
            this.lblArbitroRequerido.AutoSize = true;
            this.lblArbitroRequerido.ForeColor = System.Drawing.Color.Red;
            this.lblArbitroRequerido.Location = new System.Drawing.Point(349, 181);
            this.lblArbitroRequerido.Name = "lblArbitroRequerido";
            this.lblArbitroRequerido.Size = new System.Drawing.Size(11, 13);
            this.lblArbitroRequerido.TabIndex = 0;
            this.lblArbitroRequerido.Text = "*";
            // 
            // lblTipoRequerido
            // 
            this.lblTipoRequerido.AutoSize = true;
            this.lblTipoRequerido.ForeColor = System.Drawing.Color.Red;
            this.lblTipoRequerido.Location = new System.Drawing.Point(242, 151);
            this.lblTipoRequerido.Name = "lblTipoRequerido";
            this.lblTipoRequerido.Size = new System.Drawing.Size(11, 13);
            this.lblTipoRequerido.TabIndex = 0;
            this.lblTipoRequerido.Text = "*";
            // 
            // lblFechaRequerida
            // 
            this.lblFechaRequerida.AutoSize = true;
            this.lblFechaRequerida.ForeColor = System.Drawing.Color.Red;
            this.lblFechaRequerida.Location = new System.Drawing.Point(349, 121);
            this.lblFechaRequerida.Name = "lblFechaRequerida";
            this.lblFechaRequerida.Size = new System.Drawing.Size(11, 13);
            this.lblFechaRequerida.TabIndex = 0;
            this.lblFechaRequerida.Text = "*";
            // 
            // lblLugarRequerido
            // 
            this.lblLugarRequerido.AutoSize = true;
            this.lblLugarRequerido.ForeColor = System.Drawing.Color.Red;
            this.lblLugarRequerido.Location = new System.Drawing.Point(349, 61);
            this.lblLugarRequerido.Name = "lblLugarRequerido";
            this.lblLugarRequerido.Size = new System.Drawing.Size(11, 13);
            this.lblLugarRequerido.TabIndex = 0;
            this.lblLugarRequerido.Text = "*";
            // 
            // lblNombreRequerido
            // 
            this.lblNombreRequerido.AutoSize = true;
            this.lblNombreRequerido.ForeColor = System.Drawing.Color.Red;
            this.lblNombreRequerido.Location = new System.Drawing.Point(349, 31);
            this.lblNombreRequerido.Name = "lblNombreRequerido";
            this.lblNombreRequerido.Size = new System.Drawing.Size(11, 13);
            this.lblNombreRequerido.TabIndex = 0;
            this.lblNombreRequerido.Text = "*";
            // 
            // cmbArbitro
            // 
            this.cmbArbitro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArbitro.FormattingEnabled = true;
            this.cmbArbitro.Location = new System.Drawing.Point(77, 178);
            this.cmbArbitro.Name = "cmbArbitro";
            this.cmbArbitro.Size = new System.Drawing.Size(266, 21);
            this.cmbArbitro.TabIndex = 6;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(77, 148);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(159, 21);
            this.cmbTipo.TabIndex = 5;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dddd dd \'de\' MMMM \'de\' yyyy \'a las\' HH:mm";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(77, 118);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(266, 20);
            this.dtpFecha.TabIndex = 4;
            this.dtpFecha.Value = new System.DateTime(2014, 3, 19, 0, 0, 0, 0);
            // 
            // txbLugar
            // 
            this.txbLugar.Location = new System.Drawing.Point(77, 58);
            this.txbLugar.MaxLength = 50;
            this.txbLugar.Name = "txbLugar";
            this.txbLugar.Size = new System.Drawing.Size(266, 20);
            this.txbLugar.TabIndex = 2;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(77, 28);
            this.txbNombre.MaxLength = 50;
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(266, 20);
            this.txbNombre.TabIndex = 1;
            // 
            // lblArbitro
            // 
            this.lblArbitro.AutoSize = true;
            this.lblArbitro.Location = new System.Drawing.Point(9, 181);
            this.lblArbitro.Name = "lblArbitro";
            this.lblArbitro.Size = new System.Drawing.Size(40, 13);
            this.lblArbitro.TabIndex = 0;
            this.lblArbitro.Text = "Árbitro:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(9, 151);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(9, 121);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(9, 61);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(37, 13);
            this.lblLugar.TabIndex = 0;
            this.lblLugar.Text = "Lugar:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(9, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCamposObligatorios
            // 
            this.lblCamposObligatorios.AutoSize = true;
            this.lblCamposObligatorios.ForeColor = System.Drawing.Color.Red;
            this.lblCamposObligatorios.Location = new System.Drawing.Point(12, 265);
            this.lblCamposObligatorios.Name = "lblCamposObligatorios";
            this.lblCamposObligatorios.Size = new System.Drawing.Size(108, 13);
            this.lblCamposObligatorios.TabIndex = 0;
            this.lblCamposObligatorios.Text = "* Campos obligatorios";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(308, 260);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(227, 260);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmTorneo
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(397, 291);
            this.Controls.Add(this.lblCamposObligatorios);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gpbDatosTorneo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTorneo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del torneo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTorneo_FormClosing);
            this.Load += new System.EventHandler(this.frmTorneo_Load);
            this.gpbDatosTorneo.ResumeLayout(false);
            this.gpbDatosTorneo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDatosTorneo;
        private System.Windows.Forms.Label lblArbitro;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txbLugar;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.ComboBox cmbArbitro;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblCamposObligatorios;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblArbitroRequerido;
        private System.Windows.Forms.Label lblTipoRequerido;
        private System.Windows.Forms.Label lblFechaRequerida;
        private System.Windows.Forms.Label lblLugarRequerido;
        private System.Windows.Forms.Label lblNombreRequerido;
        private System.Windows.Forms.Label lblDireccionRequerida;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txbCostoInscripcion;
        private System.Windows.Forms.Label lblCostoInscripcion;
        private System.Windows.Forms.Label lblCostoInscrRequerido;
    }
}