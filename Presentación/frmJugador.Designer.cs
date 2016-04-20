namespace Presentación
{
    partial class frmJugador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJugador));
            this.gpbDatosJugador = new System.Windows.Forms.GroupBox();
            this.txbLocalidad = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.txbNroDoc = new System.Windows.Forms.MaskedTextBox();
            this.btnAgregarInstitucion = new DevExpress.XtraEditors.SimpleButton();
            this.lblFechaNacRequerida = new System.Windows.Forms.Label();
            this.lblSexoRequerido = new System.Windows.Forms.Label();
            this.lblApellidoRequerido = new System.Windows.Forms.Label();
            this.lblNombreRequerido = new System.Windows.Forms.Label();
            this.cmbInstitucion = new System.Windows.Forms.ComboBox();
            this.txbIdFide = new System.Windows.Forms.TextBox();
            this.txbEloLocal = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbTelCelular = new System.Windows.Forms.TextBox();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.lblInstitucion = new System.Windows.Forms.Label();
            this.lblIdFide = new System.Windows.Forms.Label();
            this.lblEloLocal = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelCelular = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCamposObligatorios = new System.Windows.Forms.Label();
            this.gpbDatosJugador.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDatosJugador
            // 
            this.gpbDatosJugador.Controls.Add(this.txbLocalidad);
            this.gpbDatosJugador.Controls.Add(this.lblLocalidad);
            this.gpbDatosJugador.Controls.Add(this.txbNroDoc);
            this.gpbDatosJugador.Controls.Add(this.btnAgregarInstitucion);
            this.gpbDatosJugador.Controls.Add(this.lblFechaNacRequerida);
            this.gpbDatosJugador.Controls.Add(this.lblSexoRequerido);
            this.gpbDatosJugador.Controls.Add(this.lblApellidoRequerido);
            this.gpbDatosJugador.Controls.Add(this.lblNombreRequerido);
            this.gpbDatosJugador.Controls.Add(this.cmbInstitucion);
            this.gpbDatosJugador.Controls.Add(this.txbIdFide);
            this.gpbDatosJugador.Controls.Add(this.txbEloLocal);
            this.gpbDatosJugador.Controls.Add(this.dtpFechaNacimiento);
            this.gpbDatosJugador.Controls.Add(this.txbEmail);
            this.gpbDatosJugador.Controls.Add(this.txbTelCelular);
            this.gpbDatosJugador.Controls.Add(this.txbTelefono);
            this.gpbDatosJugador.Controls.Add(this.txbDireccion);
            this.gpbDatosJugador.Controls.Add(this.cmbSexo);
            this.gpbDatosJugador.Controls.Add(this.txbApellido);
            this.gpbDatosJugador.Controls.Add(this.txbNombre);
            this.gpbDatosJugador.Controls.Add(this.cmbTipoDoc);
            this.gpbDatosJugador.Controls.Add(this.lblInstitucion);
            this.gpbDatosJugador.Controls.Add(this.lblIdFide);
            this.gpbDatosJugador.Controls.Add(this.lblEloLocal);
            this.gpbDatosJugador.Controls.Add(this.lblFechaNacimiento);
            this.gpbDatosJugador.Controls.Add(this.lblEmail);
            this.gpbDatosJugador.Controls.Add(this.lblTelCelular);
            this.gpbDatosJugador.Controls.Add(this.lblTelefono);
            this.gpbDatosJugador.Controls.Add(this.lblDireccion);
            this.gpbDatosJugador.Controls.Add(this.lblSexo);
            this.gpbDatosJugador.Controls.Add(this.lblApellido);
            this.gpbDatosJugador.Controls.Add(this.lblNombre);
            this.gpbDatosJugador.Controls.Add(this.lblTipoDoc);
            this.gpbDatosJugador.Controls.Add(this.lblNroDoc);
            this.gpbDatosJugador.Location = new System.Drawing.Point(13, 13);
            this.gpbDatosJugador.Name = "gpbDatosJugador";
            this.gpbDatosJugador.Size = new System.Drawing.Size(349, 448);
            this.gpbDatosJugador.TabIndex = 0;
            this.gpbDatosJugador.TabStop = false;
            this.gpbDatosJugador.Text = "Datos del jugador";
            // 
            // txbLocalidad
            // 
            this.txbLocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txbLocalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbLocalidad.Location = new System.Drawing.Point(124, 208);
            this.txbLocalidad.MaxLength = 50;
            this.txbLocalidad.Name = "txbLocalidad";
            this.txbLocalidad.Size = new System.Drawing.Size(201, 20);
            this.txbLocalidad.TabIndex = 7;
            this.txbLocalidad.Enter += new System.EventHandler(this.txbLocalidad_Enter);
            this.txbLocalidad.Leave += new System.EventHandler(this.txbLocalidad_Leave);
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(9, 211);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(56, 13);
            this.lblLocalidad.TabIndex = 25;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // txbNroDoc
            // 
            this.txbNroDoc.Location = new System.Drawing.Point(124, 118);
            this.txbNroDoc.Mask = "99,999,999";
            this.txbNroDoc.Name = "txbNroDoc";
            this.txbNroDoc.Size = new System.Drawing.Size(141, 20);
            this.txbNroDoc.TabIndex = 4;
            // 
            // btnAgregarInstitucion
            // 
            this.btnAgregarInstitucion.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarInstitucion.Image")));
            this.btnAgregarInstitucion.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAgregarInstitucion.Location = new System.Drawing.Point(320, 418);
            this.btnAgregarInstitucion.Name = "btnAgregarInstitucion";
            this.btnAgregarInstitucion.Size = new System.Drawing.Size(21, 21);
            this.btnAgregarInstitucion.TabIndex = 15;
            this.btnAgregarInstitucion.Click += new System.EventHandler(this.btnAgregarInstitucion_Click);
            // 
            // lblFechaNacRequerida
            // 
            this.lblFechaNacRequerida.AutoSize = true;
            this.lblFechaNacRequerida.ForeColor = System.Drawing.Color.Red;
            this.lblFechaNacRequerida.Location = new System.Drawing.Point(271, 331);
            this.lblFechaNacRequerida.Name = "lblFechaNacRequerida";
            this.lblFechaNacRequerida.Size = new System.Drawing.Size(11, 13);
            this.lblFechaNacRequerida.TabIndex = 22;
            this.lblFechaNacRequerida.Text = "*";
            // 
            // lblSexoRequerido
            // 
            this.lblSexoRequerido.AutoSize = true;
            this.lblSexoRequerido.ForeColor = System.Drawing.Color.Red;
            this.lblSexoRequerido.Location = new System.Drawing.Point(271, 151);
            this.lblSexoRequerido.Name = "lblSexoRequerido";
            this.lblSexoRequerido.Size = new System.Drawing.Size(11, 13);
            this.lblSexoRequerido.TabIndex = 20;
            this.lblSexoRequerido.Text = "*";
            // 
            // lblApellidoRequerido
            // 
            this.lblApellidoRequerido.AutoSize = true;
            this.lblApellidoRequerido.ForeColor = System.Drawing.Color.Red;
            this.lblApellidoRequerido.Location = new System.Drawing.Point(271, 31);
            this.lblApellidoRequerido.Name = "lblApellidoRequerido";
            this.lblApellidoRequerido.Size = new System.Drawing.Size(11, 13);
            this.lblApellidoRequerido.TabIndex = 19;
            this.lblApellidoRequerido.Text = "*";
            // 
            // lblNombreRequerido
            // 
            this.lblNombreRequerido.AutoSize = true;
            this.lblNombreRequerido.ForeColor = System.Drawing.Color.Red;
            this.lblNombreRequerido.Location = new System.Drawing.Point(271, 61);
            this.lblNombreRequerido.Name = "lblNombreRequerido";
            this.lblNombreRequerido.Size = new System.Drawing.Size(11, 13);
            this.lblNombreRequerido.TabIndex = 18;
            this.lblNombreRequerido.Text = "*";
            // 
            // cmbInstitucion
            // 
            this.cmbInstitucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstitucion.FormattingEnabled = true;
            this.cmbInstitucion.Location = new System.Drawing.Point(124, 418);
            this.cmbInstitucion.Name = "cmbInstitucion";
            this.cmbInstitucion.Size = new System.Drawing.Size(190, 21);
            this.cmbInstitucion.Sorted = true;
            this.cmbInstitucion.TabIndex = 14;
            // 
            // txbIdFide
            // 
            this.txbIdFide.Location = new System.Drawing.Point(124, 388);
            this.txbIdFide.MaxLength = 50;
            this.txbIdFide.Name = "txbIdFide";
            this.txbIdFide.Size = new System.Drawing.Size(141, 20);
            this.txbIdFide.TabIndex = 13;
            this.txbIdFide.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IngresoSoloNumeros);
            // 
            // txbEloLocal
            // 
            this.txbEloLocal.Location = new System.Drawing.Point(124, 358);
            this.txbEloLocal.MaxLength = 50;
            this.txbEloLocal.Name = "txbEloLocal";
            this.txbEloLocal.Size = new System.Drawing.Size(141, 20);
            this.txbEloLocal.TabIndex = 12;
            this.txbEloLocal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IngresoSoloNumeros);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(124, 328);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(141, 20);
            this.dtpFechaNacimiento.TabIndex = 11;
            this.dtpFechaNacimiento.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(124, 298);
            this.txbEmail.MaxLength = 50;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(141, 20);
            this.txbEmail.TabIndex = 10;
            // 
            // txbTelCelular
            // 
            this.txbTelCelular.Location = new System.Drawing.Point(124, 268);
            this.txbTelCelular.MaxLength = 50;
            this.txbTelCelular.Name = "txbTelCelular";
            this.txbTelCelular.Size = new System.Drawing.Size(141, 20);
            this.txbTelCelular.TabIndex = 9;
            this.txbTelCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumerosGuionParentesis);
            // 
            // txbTelefono
            // 
            this.txbTelefono.Location = new System.Drawing.Point(124, 238);
            this.txbTelefono.MaxLength = 50;
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(141, 20);
            this.txbTelefono.TabIndex = 8;
            this.txbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumerosGuionParentesis);
            // 
            // txbDireccion
            // 
            this.txbDireccion.Location = new System.Drawing.Point(124, 178);
            this.txbDireccion.MaxLength = 50;
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(141, 20);
            this.txbDireccion.TabIndex = 6;
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.cmbSexo.Location = new System.Drawing.Point(124, 148);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(141, 21);
            this.cmbSexo.TabIndex = 5;
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(124, 28);
            this.txbApellido.MaxLength = 50;
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(141, 20);
            this.txbApellido.TabIndex = 1;
            this.txbApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IngresoSoloLetras);
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(124, 58);
            this.txbNombre.MaxLength = 50;
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(141, 20);
            this.txbNombre.TabIndex = 2;
            this.txbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IngresoSoloLetras);
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Items.AddRange(new object[] {
            "",
            "D.N.I.",
            "Pasaporte"});
            this.cmbTipoDoc.Location = new System.Drawing.Point(124, 88);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(141, 21);
            this.cmbTipoDoc.TabIndex = 3;
            // 
            // lblInstitucion
            // 
            this.lblInstitucion.AutoSize = true;
            this.lblInstitucion.Location = new System.Drawing.Point(9, 421);
            this.lblInstitucion.Name = "lblInstitucion";
            this.lblInstitucion.Size = new System.Drawing.Size(58, 13);
            this.lblInstitucion.TabIndex = 0;
            this.lblInstitucion.Text = "Institución:";
            // 
            // lblIdFide
            // 
            this.lblIdFide.AutoSize = true;
            this.lblIdFide.Location = new System.Drawing.Point(9, 391);
            this.lblIdFide.Name = "lblIdFide";
            this.lblIdFide.Size = new System.Drawing.Size(48, 13);
            this.lblIdFide.TabIndex = 0;
            this.lblIdFide.Text = "ID FIDE:";
            // 
            // lblEloLocal
            // 
            this.lblEloLocal.AutoSize = true;
            this.lblEloLocal.Location = new System.Drawing.Point(9, 361);
            this.lblEloLocal.Name = "lblEloLocal";
            this.lblEloLocal.Size = new System.Drawing.Size(50, 13);
            this.lblEloLocal.TabIndex = 0;
            this.lblEloLocal.Text = "Elo local:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(9, 331);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(109, 13);
            this.lblFechaNacimiento.TabIndex = 0;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(9, 301);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // lblTelCelular
            // 
            this.lblTelCelular.AutoSize = true;
            this.lblTelCelular.Location = new System.Drawing.Point(9, 271);
            this.lblTelCelular.Name = "lblTelCelular";
            this.lblTelCelular.Size = new System.Drawing.Size(86, 13);
            this.lblTelCelular.TabIndex = 0;
            this.lblTelCelular.Text = "Teléfono celular:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(9, 241);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 0;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(9, 181);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 0;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(9, 151);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 0;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(9, 31);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(9, 61);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(9, 91);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(87, 13);
            this.lblTipoDoc.TabIndex = 0;
            this.lblTipoDoc.Text = "Tipo documento:";
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Location = new System.Drawing.Point(9, 121);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(78, 13);
            this.lblNroDoc.TabIndex = 0;
            this.lblNroDoc.Text = "Nº documento:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(203, 471);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(287, 471);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCamposObligatorios
            // 
            this.lblCamposObligatorios.AutoSize = true;
            this.lblCamposObligatorios.ForeColor = System.Drawing.Color.Red;
            this.lblCamposObligatorios.Location = new System.Drawing.Point(12, 476);
            this.lblCamposObligatorios.Name = "lblCamposObligatorios";
            this.lblCamposObligatorios.Size = new System.Drawing.Size(108, 13);
            this.lblCamposObligatorios.TabIndex = 0;
            this.lblCamposObligatorios.Text = "* Campos obligatorios";
            // 
            // frmJugador
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(373, 502);
            this.Controls.Add(this.lblCamposObligatorios);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gpbDatosJugador);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmJugador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del Jugador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmJugador_FormClosing);
            this.Load += new System.EventHandler(this.frmJugador_Load);
            this.gpbDatosJugador.ResumeLayout(false);
            this.gpbDatosJugador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDatosJugador;
        private System.Windows.Forms.Label lblInstitucion;
        private System.Windows.Forms.Label lblIdFide;
        private System.Windows.Forms.Label lblEloLocal;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelCelular;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cmbInstitucion;
        private System.Windows.Forms.TextBox txbIdFide;
        private System.Windows.Forms.TextBox txbEloLocal;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbTelCelular;
        private System.Windows.Forms.TextBox txbTelefono;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.Label lblCamposObligatorios;
        private System.Windows.Forms.Label lblApellidoRequerido;
        private System.Windows.Forms.Label lblNombreRequerido;
        private System.Windows.Forms.Label lblSexoRequerido;
        private System.Windows.Forms.Label lblFechaNacRequerida;
        private DevExpress.XtraEditors.SimpleButton btnAgregarInstitucion;
        private System.Windows.Forms.MaskedTextBox txbNroDoc;
        private System.Windows.Forms.TextBox txbLocalidad;
        private System.Windows.Forms.Label lblLocalidad;

    }
}