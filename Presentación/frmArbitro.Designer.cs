namespace Presentación
{
    partial class frmArbitro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArbitro));
            this.lblCamposObligatorios = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpbDatosArbitro = new System.Windows.Forms.GroupBox();
            this.txbLocalidad = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.txbNroDoc = new System.Windows.Forms.MaskedTextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblInstitucionRequerida = new System.Windows.Forms.Label();
            this.lblCategoriaRequerida = new System.Windows.Forms.Label();
            this.lblApellidoRequerido = new System.Windows.Forms.Label();
            this.lblNombreRequerido = new System.Windows.Forms.Label();
            this.lblTipoDocRequerido = new System.Windows.Forms.Label();
            this.lblNroDocRequerido = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbTelCelular = new System.Windows.Forms.TextBox();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.lblInstitucion = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelCelular = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gpbDatosArbitro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCamposObligatorios
            // 
            this.lblCamposObligatorios.AutoSize = true;
            this.lblCamposObligatorios.ForeColor = System.Drawing.Color.Red;
            this.lblCamposObligatorios.Location = new System.Drawing.Point(11, 385);
            this.lblCamposObligatorios.Name = "lblCamposObligatorios";
            this.lblCamposObligatorios.Size = new System.Drawing.Size(108, 13);
            this.lblCamposObligatorios.TabIndex = 0;
            this.lblCamposObligatorios.Text = "* Campos obligatorios";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(226, 380);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gpbDatosArbitro
            // 
            this.gpbDatosArbitro.Controls.Add(this.txbLocalidad);
            this.gpbDatosArbitro.Controls.Add(this.lblLocalidad);
            this.gpbDatosArbitro.Controls.Add(this.txbNroDoc);
            this.gpbDatosArbitro.Controls.Add(this.cmbCategoria);
            this.gpbDatosArbitro.Controls.Add(this.lblInstitucionRequerida);
            this.gpbDatosArbitro.Controls.Add(this.lblCategoriaRequerida);
            this.gpbDatosArbitro.Controls.Add(this.lblApellidoRequerido);
            this.gpbDatosArbitro.Controls.Add(this.lblNombreRequerido);
            this.gpbDatosArbitro.Controls.Add(this.lblTipoDocRequerido);
            this.gpbDatosArbitro.Controls.Add(this.lblNroDocRequerido);
            this.gpbDatosArbitro.Controls.Add(this.dtpFechaNacimiento);
            this.gpbDatosArbitro.Controls.Add(this.txbEmail);
            this.gpbDatosArbitro.Controls.Add(this.txbTelCelular);
            this.gpbDatosArbitro.Controls.Add(this.txbTelefono);
            this.gpbDatosArbitro.Controls.Add(this.txbDireccion);
            this.gpbDatosArbitro.Controls.Add(this.txbApellido);
            this.gpbDatosArbitro.Controls.Add(this.txbNombre);
            this.gpbDatosArbitro.Controls.Add(this.cmbTipoDoc);
            this.gpbDatosArbitro.Controls.Add(this.lblInstitucion);
            this.gpbDatosArbitro.Controls.Add(this.lblFechaNacimiento);
            this.gpbDatosArbitro.Controls.Add(this.lblEmail);
            this.gpbDatosArbitro.Controls.Add(this.lblTelCelular);
            this.gpbDatosArbitro.Controls.Add(this.lblTelefono);
            this.gpbDatosArbitro.Controls.Add(this.lblDireccion);
            this.gpbDatosArbitro.Controls.Add(this.lblApellido);
            this.gpbDatosArbitro.Controls.Add(this.lblNombre);
            this.gpbDatosArbitro.Controls.Add(this.lblTipoDoc);
            this.gpbDatosArbitro.Controls.Add(this.lblNroDoc);
            this.gpbDatosArbitro.Location = new System.Drawing.Point(12, 12);
            this.gpbDatosArbitro.Name = "gpbDatosArbitro";
            this.gpbDatosArbitro.Size = new System.Drawing.Size(290, 362);
            this.gpbDatosArbitro.TabIndex = 0;
            this.gpbDatosArbitro.TabStop = false;
            this.gpbDatosArbitro.Text = "Datos del árbitro";
            // 
            // txbLocalidad
            // 
            this.txbLocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txbLocalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbLocalidad.Location = new System.Drawing.Point(124, 178);
            this.txbLocalidad.MaxLength = 50;
            this.txbLocalidad.Name = "txbLocalidad";
            this.txbLocalidad.Size = new System.Drawing.Size(141, 20);
            this.txbLocalidad.TabIndex = 6;
            this.txbLocalidad.Enter += new System.EventHandler(this.txbLocalidad_Enter);
            this.txbLocalidad.Leave += new System.EventHandler(this.txbLocalidad_Leave);
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(9, 181);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(56, 13);
            this.lblLocalidad.TabIndex = 27;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // txbNroDoc
            // 
            this.txbNroDoc.Location = new System.Drawing.Point(124, 28);
            this.txbNroDoc.Mask = "99,999,999";
            this.txbNroDoc.Name = "txbNroDoc";
            this.txbNroDoc.Size = new System.Drawing.Size(141, 20);
            this.txbNroDoc.TabIndex = 1;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(124, 328);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(141, 21);
            this.cmbCategoria.TabIndex = 11;
            // 
            // lblInstitucionRequerida
            // 
            this.lblInstitucionRequerida.AutoSize = true;
            this.lblInstitucionRequerida.ForeColor = System.Drawing.Color.Red;
            this.lblInstitucionRequerida.Location = new System.Drawing.Point(271, 301);
            this.lblInstitucionRequerida.Name = "lblInstitucionRequerida";
            this.lblInstitucionRequerida.Size = new System.Drawing.Size(11, 13);
            this.lblInstitucionRequerida.TabIndex = 0;
            this.lblInstitucionRequerida.Text = "*";
            // 
            // lblCategoriaRequerida
            // 
            this.lblCategoriaRequerida.AutoSize = true;
            this.lblCategoriaRequerida.ForeColor = System.Drawing.Color.Red;
            this.lblCategoriaRequerida.Location = new System.Drawing.Point(271, 331);
            this.lblCategoriaRequerida.Name = "lblCategoriaRequerida";
            this.lblCategoriaRequerida.Size = new System.Drawing.Size(11, 13);
            this.lblCategoriaRequerida.TabIndex = 22;
            this.lblCategoriaRequerida.Text = "*";
            // 
            // lblApellidoRequerido
            // 
            this.lblApellidoRequerido.AutoSize = true;
            this.lblApellidoRequerido.ForeColor = System.Drawing.Color.Red;
            this.lblApellidoRequerido.Location = new System.Drawing.Point(271, 91);
            this.lblApellidoRequerido.Name = "lblApellidoRequerido";
            this.lblApellidoRequerido.Size = new System.Drawing.Size(11, 13);
            this.lblApellidoRequerido.TabIndex = 19;
            this.lblApellidoRequerido.Text = "*";
            // 
            // lblNombreRequerido
            // 
            this.lblNombreRequerido.AutoSize = true;
            this.lblNombreRequerido.ForeColor = System.Drawing.Color.Red;
            this.lblNombreRequerido.Location = new System.Drawing.Point(271, 121);
            this.lblNombreRequerido.Name = "lblNombreRequerido";
            this.lblNombreRequerido.Size = new System.Drawing.Size(11, 13);
            this.lblNombreRequerido.TabIndex = 18;
            this.lblNombreRequerido.Text = "*";
            // 
            // lblTipoDocRequerido
            // 
            this.lblTipoDocRequerido.AutoSize = true;
            this.lblTipoDocRequerido.ForeColor = System.Drawing.Color.Red;
            this.lblTipoDocRequerido.Location = new System.Drawing.Point(271, 61);
            this.lblTipoDocRequerido.Name = "lblTipoDocRequerido";
            this.lblTipoDocRequerido.Size = new System.Drawing.Size(11, 13);
            this.lblTipoDocRequerido.TabIndex = 17;
            this.lblTipoDocRequerido.Text = "*";
            // 
            // lblNroDocRequerido
            // 
            this.lblNroDocRequerido.AutoSize = true;
            this.lblNroDocRequerido.ForeColor = System.Drawing.Color.Red;
            this.lblNroDocRequerido.Location = new System.Drawing.Point(271, 31);
            this.lblNroDocRequerido.Name = "lblNroDocRequerido";
            this.lblNroDocRequerido.Size = new System.Drawing.Size(11, 13);
            this.lblNroDocRequerido.TabIndex = 16;
            this.lblNroDocRequerido.Text = "*";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(124, 298);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(141, 20);
            this.dtpFechaNacimiento.TabIndex = 10;
            this.dtpFechaNacimiento.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(124, 268);
            this.txbEmail.MaxLength = 50;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(141, 20);
            this.txbEmail.TabIndex = 9;
            // 
            // txbTelCelular
            // 
            this.txbTelCelular.Location = new System.Drawing.Point(124, 238);
            this.txbTelCelular.MaxLength = 50;
            this.txbTelCelular.Name = "txbTelCelular";
            this.txbTelCelular.Size = new System.Drawing.Size(141, 20);
            this.txbTelCelular.TabIndex = 8;
            this.txbTelCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumerosGuionParentesis);
            // 
            // txbTelefono
            // 
            this.txbTelefono.Location = new System.Drawing.Point(124, 208);
            this.txbTelefono.MaxLength = 50;
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(141, 20);
            this.txbTelefono.TabIndex = 7;
            this.txbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumerosGuionParentesis);
            // 
            // txbDireccion
            // 
            this.txbDireccion.Location = new System.Drawing.Point(124, 148);
            this.txbDireccion.MaxLength = 50;
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(141, 20);
            this.txbDireccion.TabIndex = 5;
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(124, 88);
            this.txbApellido.MaxLength = 50;
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(141, 20);
            this.txbApellido.TabIndex = 3;
            this.txbApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IngresoSoloLetras);
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(124, 118);
            this.txbNombre.MaxLength = 50;
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(141, 20);
            this.txbNombre.TabIndex = 4;
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
            this.cmbTipoDoc.Location = new System.Drawing.Point(124, 58);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(141, 21);
            this.cmbTipoDoc.TabIndex = 2;
            // 
            // lblInstitucion
            // 
            this.lblInstitucion.AutoSize = true;
            this.lblInstitucion.Location = new System.Drawing.Point(9, 331);
            this.lblInstitucion.Name = "lblInstitucion";
            this.lblInstitucion.Size = new System.Drawing.Size(57, 13);
            this.lblInstitucion.TabIndex = 0;
            this.lblInstitucion.Text = "Categoría:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(9, 301);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(109, 13);
            this.lblFechaNacimiento.TabIndex = 0;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(10, 271);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // lblTelCelular
            // 
            this.lblTelCelular.AutoSize = true;
            this.lblTelCelular.Location = new System.Drawing.Point(10, 241);
            this.lblTelCelular.Name = "lblTelCelular";
            this.lblTelCelular.Size = new System.Drawing.Size(86, 13);
            this.lblTelCelular.TabIndex = 0;
            this.lblTelCelular.Text = "Teléfono celular:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(9, 211);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 0;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(9, 151);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 0;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(9, 91);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(9, 121);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(9, 61);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(87, 13);
            this.lblTipoDoc.TabIndex = 0;
            this.lblTipoDoc.Text = "Tipo documento:";
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Location = new System.Drawing.Point(9, 31);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(78, 13);
            this.lblNroDoc.TabIndex = 0;
            this.lblNroDoc.Text = "Nº documento:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(145, 380);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmArbitro
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(315, 410);
            this.Controls.Add(this.lblCamposObligatorios);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gpbDatosArbitro);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmArbitro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del árbitro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmArbitro_FormClosing);
            this.Load += new System.EventHandler(this.frmArbitro_Load);
            this.gpbDatosArbitro.ResumeLayout(false);
            this.gpbDatosArbitro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCamposObligatorios;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gpbDatosArbitro;
        private System.Windows.Forms.Label lblInstitucionRequerida;
        private System.Windows.Forms.Label lblCategoriaRequerida;
        private System.Windows.Forms.Label lblApellidoRequerido;
        private System.Windows.Forms.Label lblNombreRequerido;
        private System.Windows.Forms.Label lblTipoDocRequerido;
        private System.Windows.Forms.Label lblNroDocRequerido;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbTelCelular;
        private System.Windows.Forms.TextBox txbTelefono;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.Label lblInstitucion;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelCelular;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.MaskedTextBox txbNroDoc;
        private System.Windows.Forms.TextBox txbLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
    }
}