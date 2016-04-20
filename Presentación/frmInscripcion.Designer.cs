namespace Presentación
{
    partial class frmInscripcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInscripcion));
            this.lblTorneo = new System.Windows.Forms.Label();
            this.gpbDatosInscripcion = new System.Windows.Forms.GroupBox();
            this.btnAgregarJugador = new DevExpress.XtraEditors.SimpleButton();
            this.lblCostoRequerido = new System.Windows.Forms.Label();
            this.lblNomApRequerido = new System.Windows.Forms.Label();
            this.lblNroDocRequerido = new System.Windows.Forms.Label();
            this.txbNroDocJugador = new System.Windows.Forms.TextBox();
            this.lblNroDocJugador = new System.Windows.Forms.Label();
            this.txbCostoInscripcion = new System.Windows.Forms.TextBox();
            this.txbNomApJugador = new System.Windows.Forms.TextBox();
            this.txbTorneo = new System.Windows.Forms.TextBox();
            this.lblCostoInscripcion = new System.Windows.Forms.Label();
            this.lblNombreJugador = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblCamposObligatorios = new System.Windows.Forms.Label();
            this.gpbDatosInscripcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTorneo
            // 
            this.lblTorneo.AutoSize = true;
            this.lblTorneo.Location = new System.Drawing.Point(9, 31);
            this.lblTorneo.Name = "lblTorneo";
            this.lblTorneo.Size = new System.Drawing.Size(44, 13);
            this.lblTorneo.TabIndex = 0;
            this.lblTorneo.Text = "Torneo:";
            // 
            // gpbDatosInscripcion
            // 
            this.gpbDatosInscripcion.Controls.Add(this.btnAgregarJugador);
            this.gpbDatosInscripcion.Controls.Add(this.lblCostoRequerido);
            this.gpbDatosInscripcion.Controls.Add(this.lblNomApRequerido);
            this.gpbDatosInscripcion.Controls.Add(this.lblNroDocRequerido);
            this.gpbDatosInscripcion.Controls.Add(this.txbNroDocJugador);
            this.gpbDatosInscripcion.Controls.Add(this.lblNroDocJugador);
            this.gpbDatosInscripcion.Controls.Add(this.txbCostoInscripcion);
            this.gpbDatosInscripcion.Controls.Add(this.txbNomApJugador);
            this.gpbDatosInscripcion.Controls.Add(this.txbTorneo);
            this.gpbDatosInscripcion.Controls.Add(this.lblCostoInscripcion);
            this.gpbDatosInscripcion.Controls.Add(this.lblNombreJugador);
            this.gpbDatosInscripcion.Controls.Add(this.lblTorneo);
            this.gpbDatosInscripcion.Location = new System.Drawing.Point(13, 12);
            this.gpbDatosInscripcion.Name = "gpbDatosInscripcion";
            this.gpbDatosInscripcion.Size = new System.Drawing.Size(353, 151);
            this.gpbDatosInscripcion.TabIndex = 0;
            this.gpbDatosInscripcion.TabStop = false;
            this.gpbDatosInscripcion.Text = "Datos de la inscripción";
            // 
            // btnAgregarJugador
            // 
            this.btnAgregarJugador.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarJugador.Image")));
            this.btnAgregarJugador.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAgregarJugador.Location = new System.Drawing.Point(317, 58);
            this.btnAgregarJugador.Name = "btnAgregarJugador";
            this.btnAgregarJugador.Size = new System.Drawing.Size(21, 21);
            this.btnAgregarJugador.TabIndex = 3;
            this.btnAgregarJugador.Click += new System.EventHandler(this.btnAgregarJugador_Click);
            // 
            // lblCostoRequerido
            // 
            this.lblCostoRequerido.AutoSize = true;
            this.lblCostoRequerido.ForeColor = System.Drawing.Color.Red;
            this.lblCostoRequerido.Location = new System.Drawing.Point(300, 121);
            this.lblCostoRequerido.Name = "lblCostoRequerido";
            this.lblCostoRequerido.Size = new System.Drawing.Size(11, 13);
            this.lblCostoRequerido.TabIndex = 20;
            this.lblCostoRequerido.Text = "*";
            // 
            // lblNomApRequerido
            // 
            this.lblNomApRequerido.AutoSize = true;
            this.lblNomApRequerido.ForeColor = System.Drawing.Color.Red;
            this.lblNomApRequerido.Location = new System.Drawing.Point(300, 61);
            this.lblNomApRequerido.Name = "lblNomApRequerido";
            this.lblNomApRequerido.Size = new System.Drawing.Size(11, 13);
            this.lblNomApRequerido.TabIndex = 19;
            this.lblNomApRequerido.Text = "*";
            // 
            // lblNroDocRequerido
            // 
            this.lblNroDocRequerido.AutoSize = true;
            this.lblNroDocRequerido.ForeColor = System.Drawing.Color.Red;
            this.lblNroDocRequerido.Location = new System.Drawing.Point(300, 91);
            this.lblNroDocRequerido.Name = "lblNroDocRequerido";
            this.lblNroDocRequerido.Size = new System.Drawing.Size(11, 13);
            this.lblNroDocRequerido.TabIndex = 18;
            this.lblNroDocRequerido.Text = "*";
            // 
            // txbNroDocJugador
            // 
            this.txbNroDocJugador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txbNroDocJugador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbNroDocJugador.Location = new System.Drawing.Point(160, 88);
            this.txbNroDocJugador.Name = "txbNroDocJugador";
            this.txbNroDocJugador.Size = new System.Drawing.Size(134, 20);
            this.txbNroDocJugador.TabIndex = 4;
            this.txbNroDocJugador.Enter += new System.EventHandler(this.txbNroDocJugador_Enter);
            this.txbNroDocJugador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IngresoSoloNumeros);
            this.txbNroDocJugador.Leave += new System.EventHandler(this.txbNroDocJugador_Leave);
            this.txbNroDocJugador.Validated += new System.EventHandler(this.txbNroDocJugador_TextChanged);
            // 
            // lblNroDocJugador
            // 
            this.lblNroDocJugador.AutoSize = true;
            this.lblNroDocJugador.Location = new System.Drawing.Point(9, 91);
            this.lblNroDocJugador.Name = "lblNroDocJugador";
            this.lblNroDocJugador.Size = new System.Drawing.Size(133, 13);
            this.lblNroDocJugador.TabIndex = 4;
            this.lblNroDocJugador.Text = "Nº documento del jugador:";
            // 
            // txbCostoInscripcion
            // 
            this.txbCostoInscripcion.Location = new System.Drawing.Point(160, 118);
            this.txbCostoInscripcion.Name = "txbCostoInscripcion";
            this.txbCostoInscripcion.Size = new System.Drawing.Size(134, 20);
            this.txbCostoInscripcion.TabIndex = 5;
            this.txbCostoInscripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumerosComa);
            // 
            // txbNomApJugador
            // 
            this.txbNomApJugador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txbNomApJugador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbNomApJugador.Location = new System.Drawing.Point(160, 58);
            this.txbNomApJugador.Name = "txbNomApJugador";
            this.txbNomApJugador.Size = new System.Drawing.Size(134, 20);
            this.txbNomApJugador.TabIndex = 2;
            this.txbNomApJugador.Enter += new System.EventHandler(this.txbNomApJugador_Enter);
            this.txbNomApJugador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IngresoSoloLetras);
            this.txbNomApJugador.Leave += new System.EventHandler(this.txbNomApJugador_Leave);
            this.txbNomApJugador.Validated += new System.EventHandler(this.txbNomApJugador_TextChanged);
            // 
            // txbTorneo
            // 
            this.txbTorneo.Enabled = false;
            this.txbTorneo.Location = new System.Drawing.Point(160, 28);
            this.txbTorneo.Name = "txbTorneo";
            this.txbTorneo.Size = new System.Drawing.Size(134, 20);
            this.txbTorneo.TabIndex = 1;
            // 
            // lblCostoInscripcion
            // 
            this.lblCostoInscripcion.AutoSize = true;
            this.lblCostoInscripcion.Location = new System.Drawing.Point(9, 121);
            this.lblCostoInscripcion.Name = "lblCostoInscripcion";
            this.lblCostoInscripcion.Size = new System.Drawing.Size(90, 13);
            this.lblCostoInscripcion.TabIndex = 0;
            this.lblCostoInscripcion.Text = "Costo inscripción:";
            // 
            // lblNombreJugador
            // 
            this.lblNombreJugador.AutoSize = true;
            this.lblNombreJugador.Location = new System.Drawing.Point(9, 61);
            this.lblNombreJugador.Name = "lblNombreJugador";
            this.lblNombreJugador.Size = new System.Drawing.Size(148, 13);
            this.lblNombreJugador.TabIndex = 0;
            this.lblNombreJugador.Text = "Apellido y nombre del jugador:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(291, 169);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(210, 169);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblCamposObligatorios
            // 
            this.lblCamposObligatorios.AutoSize = true;
            this.lblCamposObligatorios.ForeColor = System.Drawing.Color.Red;
            this.lblCamposObligatorios.Location = new System.Drawing.Point(12, 174);
            this.lblCamposObligatorios.Name = "lblCamposObligatorios";
            this.lblCamposObligatorios.Size = new System.Drawing.Size(108, 13);
            this.lblCamposObligatorios.TabIndex = 0;
            this.lblCamposObligatorios.Text = "* Campos obligatorios";
            // 
            // frmInscripcion
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(378, 200);
            this.Controls.Add(this.lblCamposObligatorios);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gpbDatosInscripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de inscripción";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInscripcion_FormClosing);
            this.Load += new System.EventHandler(this.frmInscripcion_Load);
            this.gpbDatosInscripcion.ResumeLayout(false);
            this.gpbDatosInscripcion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTorneo;
        private System.Windows.Forms.GroupBox gpbDatosInscripcion;
        private System.Windows.Forms.Label lblCostoInscripcion;
        private System.Windows.Forms.Label lblNombreJugador;
        private System.Windows.Forms.TextBox txbCostoInscripcion;
        private System.Windows.Forms.TextBox txbNomApJugador;
        private System.Windows.Forms.TextBox txbTorneo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txbNroDocJugador;
        private System.Windows.Forms.Label lblNroDocJugador;
        private System.Windows.Forms.Label lblCamposObligatorios;
        private System.Windows.Forms.Label lblNomApRequerido;
        private System.Windows.Forms.Label lblNroDocRequerido;
        private System.Windows.Forms.Label lblCostoRequerido;
        private DevExpress.XtraEditors.SimpleButton btnAgregarJugador;
    }
}