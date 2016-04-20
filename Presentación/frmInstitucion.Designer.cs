namespace Presentación
{
    partial class frmInstitucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstitucion));
            this.gpbDatosInstitucion = new System.Windows.Forms.GroupBox();
            this.lblRazonSocialRequerida = new System.Windows.Forms.Label();
            this.txbLocalidades = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.txbTelCelular = new System.Windows.Forms.TextBox();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.txbCuit = new System.Windows.Forms.MaskedTextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbNombreContacto = new System.Windows.Forms.TextBox();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.txbRazonSocial = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelCelular = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombreContacto = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblCamposObligatorios = new System.Windows.Forms.Label();
            this.gpbDatosInstitucion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDatosInstitucion
            // 
            this.gpbDatosInstitucion.Controls.Add(this.lblRazonSocialRequerida);
            this.gpbDatosInstitucion.Controls.Add(this.txbLocalidades);
            this.gpbDatosInstitucion.Controls.Add(this.lblLocalidad);
            this.gpbDatosInstitucion.Controls.Add(this.txbTelCelular);
            this.gpbDatosInstitucion.Controls.Add(this.txbTelefono);
            this.gpbDatosInstitucion.Controls.Add(this.txbCuit);
            this.gpbDatosInstitucion.Controls.Add(this.txbEmail);
            this.gpbDatosInstitucion.Controls.Add(this.txbNombreContacto);
            this.gpbDatosInstitucion.Controls.Add(this.txbDireccion);
            this.gpbDatosInstitucion.Controls.Add(this.txbRazonSocial);
            this.gpbDatosInstitucion.Controls.Add(this.lblEmail);
            this.gpbDatosInstitucion.Controls.Add(this.lblTelCelular);
            this.gpbDatosInstitucion.Controls.Add(this.lblTelefono);
            this.gpbDatosInstitucion.Controls.Add(this.lblNombreContacto);
            this.gpbDatosInstitucion.Controls.Add(this.lblDireccion);
            this.gpbDatosInstitucion.Controls.Add(this.lblRazonSocial);
            this.gpbDatosInstitucion.Controls.Add(this.lblCuit);
            this.gpbDatosInstitucion.Location = new System.Drawing.Point(13, 13);
            this.gpbDatosInstitucion.Name = "gpbDatosInstitucion";
            this.gpbDatosInstitucion.Size = new System.Drawing.Size(347, 271);
            this.gpbDatosInstitucion.TabIndex = 0;
            this.gpbDatosInstitucion.TabStop = false;
            this.gpbDatosInstitucion.Text = "Datos de la institución";
            // 
            // lblRazonSocialRequerida
            // 
            this.lblRazonSocialRequerida.AutoSize = true;
            this.lblRazonSocialRequerida.ForeColor = System.Drawing.Color.Red;
            this.lblRazonSocialRequerida.Location = new System.Drawing.Point(331, 61);
            this.lblRazonSocialRequerida.Name = "lblRazonSocialRequerida";
            this.lblRazonSocialRequerida.Size = new System.Drawing.Size(11, 13);
            this.lblRazonSocialRequerida.TabIndex = 0;
            this.lblRazonSocialRequerida.Text = "*";
            // 
            // txbLocalidades
            // 
            this.txbLocalidades.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txbLocalidades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbLocalidades.Location = new System.Drawing.Point(124, 118);
            this.txbLocalidades.MaxLength = 50;
            this.txbLocalidades.Name = "txbLocalidades";
            this.txbLocalidades.Size = new System.Drawing.Size(201, 20);
            this.txbLocalidades.TabIndex = 4;
            this.txbLocalidades.Enter += new System.EventHandler(this.txbLocalidades_Enter);
            this.txbLocalidades.Leave += new System.EventHandler(this.txbLocalidades_Leave);
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(9, 121);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(56, 13);
            this.lblLocalidad.TabIndex = 0;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // txbTelCelular
            // 
            this.txbTelCelular.Location = new System.Drawing.Point(124, 208);
            this.txbTelCelular.MaxLength = 50;
            this.txbTelCelular.Name = "txbTelCelular";
            this.txbTelCelular.Size = new System.Drawing.Size(135, 20);
            this.txbTelCelular.TabIndex = 7;
            this.txbTelCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumerosGuionParentesis);
            // 
            // txbTelefono
            // 
            this.txbTelefono.Location = new System.Drawing.Point(124, 178);
            this.txbTelefono.MaxLength = 50;
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(135, 20);
            this.txbTelefono.TabIndex = 6;
            this.txbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumerosGuionParentesis);
            // 
            // txbCuit
            // 
            this.txbCuit.Location = new System.Drawing.Point(124, 28);
            this.txbCuit.Mask = "99-99999999-9";
            this.txbCuit.Name = "txbCuit";
            this.txbCuit.Size = new System.Drawing.Size(135, 20);
            this.txbCuit.TabIndex = 1;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(124, 238);
            this.txbEmail.MaxLength = 50;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(163, 20);
            this.txbEmail.TabIndex = 8;
            // 
            // txbNombreContacto
            // 
            this.txbNombreContacto.Location = new System.Drawing.Point(124, 148);
            this.txbNombreContacto.MaxLength = 50;
            this.txbNombreContacto.Name = "txbNombreContacto";
            this.txbNombreContacto.Size = new System.Drawing.Size(163, 20);
            this.txbNombreContacto.TabIndex = 5;
            this.txbNombreContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IngresoSoloLetras);
            // 
            // txbDireccion
            // 
            this.txbDireccion.Location = new System.Drawing.Point(124, 88);
            this.txbDireccion.MaxLength = 50;
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(163, 20);
            this.txbDireccion.TabIndex = 3;
            // 
            // txbRazonSocial
            // 
            this.txbRazonSocial.Location = new System.Drawing.Point(124, 58);
            this.txbRazonSocial.MaxLength = 100;
            this.txbRazonSocial.Name = "txbRazonSocial";
            this.txbRazonSocial.Size = new System.Drawing.Size(201, 20);
            this.txbRazonSocial.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(9, 241);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // lblTelCelular
            // 
            this.lblTelCelular.AutoSize = true;
            this.lblTelCelular.Location = new System.Drawing.Point(9, 211);
            this.lblTelCelular.Name = "lblTelCelular";
            this.lblTelCelular.Size = new System.Drawing.Size(86, 13);
            this.lblTelCelular.TabIndex = 0;
            this.lblTelCelular.Text = "Teléfono celular:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(9, 181);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 0;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblNombreContacto
            // 
            this.lblNombreContacto.AutoSize = true;
            this.lblNombreContacto.Location = new System.Drawing.Point(9, 151);
            this.lblNombreContacto.Name = "lblNombreContacto";
            this.lblNombreContacto.Size = new System.Drawing.Size(109, 13);
            this.lblNombreContacto.TabIndex = 0;
            this.lblNombreContacto.Text = "Nombre del contacto:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(9, 91);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 0;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(9, 61);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(71, 13);
            this.lblRazonSocial.TabIndex = 0;
            this.lblRazonSocial.Text = "Razón social:";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(9, 31);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(35, 13);
            this.lblCuit.TabIndex = 0;
            this.lblCuit.Text = "CUIT:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(285, 290);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(204, 290);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblCamposObligatorios
            // 
            this.lblCamposObligatorios.AutoSize = true;
            this.lblCamposObligatorios.ForeColor = System.Drawing.Color.Red;
            this.lblCamposObligatorios.Location = new System.Drawing.Point(12, 295);
            this.lblCamposObligatorios.Name = "lblCamposObligatorios";
            this.lblCamposObligatorios.Size = new System.Drawing.Size(108, 13);
            this.lblCamposObligatorios.TabIndex = 0;
            this.lblCamposObligatorios.Text = "* Campos obligatorios";
            // 
            // frmInstitucion
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(374, 320);
            this.Controls.Add(this.lblCamposObligatorios);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gpbDatosInstitucion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInstitucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de la Institucion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInstitucion_FormClosing);
            this.Load += new System.EventHandler(this.frmInstitucion_Load);
            this.gpbDatosInstitucion.ResumeLayout(false);
            this.gpbDatosInstitucion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDatosInstitucion;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbNombreContacto;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.TextBox txbRazonSocial;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelCelular;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombreContacto;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.MaskedTextBox txbCuit;
        private System.Windows.Forms.TextBox txbTelCelular;
        private System.Windows.Forms.TextBox txbTelefono;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox txbLocalidades;
        private System.Windows.Forms.Label lblRazonSocialRequerida;
        private System.Windows.Forms.Label lblCamposObligatorios;
    }
}