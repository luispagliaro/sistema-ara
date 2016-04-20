using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación
{
    public partial class frmTorneo : Form
    {
        #region Propiedades

        private bool mCancelado = true;
        private int mIdTorneo = 0;
        private General.TipoOperacion mOperacion = General.TipoOperacion.Alta;

        /// <summary>
        /// Indica la operacion a realizar
        /// </summary>
        public General.TipoOperacion Operacion
        {
            get
            {
                return mOperacion;
            }
            set
            {
                mOperacion = value;
            }
        }

        /// <summary>
        ///  Indica si la operación fue cancelada
        /// </summary>
        public bool Cancelado
        {
            get
            {
                return mCancelado;
            }
            set
            {
                mCancelado = value;
            }
        }

        /// <summary>
        ///  Indica el ID del torneo a editar
        /// </summary>
        public int IdTorneo
        {
            get
            {
                return mIdTorneo;
            }
            set
            {
                mIdTorneo = value;
            }
        }

        #endregion

        #region Constructores

        public frmTorneo()
        {
            InitializeComponent();
            ObtenerArbitros();
            ObtenerTipos();
        }

        #endregion

        #region Eventos

        private void frmTorneo_Load(object sender, EventArgs e)
        {
            IniciarFormulario();
        }

        private void frmTorneo_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            // Si el usuario cierra el formulario sin utilizar los comandos provistos por el formulario se asume que cancela la operacion
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Cancelado = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Confirma la operacion actual
            AceptarOperacion();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Cancela la operacion actual
            CancelarOperacion();
        }

        private void NumerosComa(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
                {
                    e.Handled = false;
                }
                else if (e.KeyChar.Equals(','))
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan 
                    e.Handled = true;
                }
        }

        #endregion

        #region Metodos

        // Inicializa el formulario
        private void IniciarFormulario()
        {
            dtpFecha.Value = DateTime.Today;

            // Verifica la operacion en curso
            if (Operacion == General.TipoOperacion.Edicion)
            {
                this.Text = "Torneo - Edición";
                // Debo obtener el torneo para editar
                SistemaARA.Entidades.Torneos oTorneos;
                SistemaARA.Negocio.Torneos oTorneosNegocio = new SistemaARA.Negocio.Torneos();
                try
                {
                    // Solicito a negocio toda la informacion del torneo a editar
                    oTorneos = oTorneosNegocio.GetOne(IdTorneo);

                    // Verifico que haya obtenido datos
                    if (oTorneos.Count > 0)
                    {
                        // Siempre es el primer valor de la coleccion
                        // Visualizo los datos en los controles
                        SistemaARA.Entidades.Torneo oTorneo = oTorneos[0];

                        txbNombre.Text = oTorneo.nombre;
                        txbLugar.Text = oTorneo.lugar;
                        txbDireccion.Text = oTorneo.direccion;
                        dtpFecha.Text = oTorneo.fechaHora.ToString();

                        SistemaARA.Entidades.Tipos oTipos;
                        SistemaARA.Negocio.Tipos oTiposNegocio = new SistemaARA.Negocio.Tipos();

                        oTipos = oTiposNegocio.GetOne(oTorneo.idTipo);
                        SistemaARA.Entidades.Tipo oTipo = oTipos[0];

                        cmbTipo.Text = oTipo.descripcion;

                        txbCostoInscripcion.Text = oTorneo.costoEstandar.ToString();

                        SistemaARA.Entidades.Arbitros oArbitros;
                        SistemaARA.Negocio.Arbitros oArbitrosNegocio = new SistemaARA.Negocio.Arbitros();

                        oArbitros = oArbitrosNegocio.GetOne(oTorneo.idArbitro);

                        if (oArbitros.Count > 0)
                        {
                            SistemaARA.Entidades.Arbitro oArbitro = oArbitros[0];

                            cmbArbitro.Text = oArbitro.nroDoc + " - " + oArbitro.apellido + ", " + oArbitro.nombre;
                        }
                        else
                        {
                            cmbArbitro.Text = "";
                        }
                    }
                    else
                    {
                        // Sino puedo encontrar el jugador, puede haberse eliminado por otro usuario
                        // Informo de la situación e invalido el formulario para cualquier operación
                        MessageBox.Show("El torneo solicitado no existe. Verifique que no haya sido eliminado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        gpbDatosTorneo.Enabled = false;
                        btnAceptar.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    // Muestra el error ocurrido
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Liberamos memoria
                    oTorneos = null;
                    oTorneosNegocio = null;
                }
            }
            else
            {
                this.Text = "Torneo - Alta";
            }
        }

        public void ObtenerArbitros()
        {
            SistemaARA.Entidades.Arbitros oArbitros;
            SistemaARA.Negocio.Arbitros oArbitrosNegocio = new SistemaARA.Negocio.Arbitros();

            try
            {
                oArbitros = oArbitrosNegocio.GetAll();

                foreach (SistemaARA.Entidades.Arbitro oArbitro in oArbitros)
                {
                    cmbArbitro.Items.Add(oArbitro.nroDoc + " - " + oArbitro.apellido + ", " + oArbitro.nombre);
                }
            }
            catch (Exception ex)
            {
                // Muestra el error ocurrido
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ObtenerTipos()
        {
            SistemaARA.Entidades.Tipos oTipos;
            SistemaARA.Negocio.Tipos oTiposNegocio = new SistemaARA.Negocio.Tipos();

            try
            {
                oTipos = oTiposNegocio.GetAll();

                foreach (SistemaARA.Entidades.Tipo oTipo in oTipos)
                {
                    cmbTipo.Items.Add(oTipo.descripcion);
                }
            }
            catch (Exception ex)
            {
                // Muestra el error ocurrido
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Valida los datos antes de realizar cualquier operación
        private void Validar()
        {
            if (txbNombre.Text.Trim() == "")
            {
                txbNombre.Focus();
                throw new ArgumentException("Debe ingresar el nombre del torneo.");
            }

            if (txbLugar.Text.Trim() == "")
            {
                txbLugar.Focus();
                throw new ArgumentException("Debe ingresar el nombre del lugar donde se llevará a cabo el torneo.");
            }

            if (txbDireccion.Text.Trim() == "")
            {
                txbLugar.Focus();
                throw new ArgumentException("Debe ingresar la dirección del lugar donde se llevará a cabo el torneo.");
            }

            if (!dtpFecha.Checked)
            {
                dtpFecha.Focus();
                throw new ArgumentException("Debe ingresar la fecha del torneo.");
            }

            if (DateTime.Compare(dtpFecha.Value, DateTime.Today) <= 0)
            {
                dtpFecha.Focus();
                throw new ArgumentException("La fecha del torneo no puede ser anterior o igual a la actual.");
            }

            if (cmbTipo.SelectedItem == null)
            {
                cmbTipo.Focus();
                throw new ArgumentException("Debe seleccionar el tipo de torneo.");
            }

            if (cmbArbitro.SelectedItem == null)
            {
                cmbArbitro.Focus();
                throw new ArgumentException("Debe seleccionar un árbitro para el torneo.");
            }

            if (txbCostoInscripcion.Text.Equals(""))
            {
                txbCostoInscripcion.Focus();
                throw new ArgumentException("Debe ingresar el costo de inscripción del torneo.");
            }
        }

        // Confirmar la operación en curso
        private void AceptarOperacion()
        {
            SistemaARA.Negocio.Torneos oTorneosNegocio = new SistemaARA.Negocio.Torneos();
            SistemaARA.Entidades.Torneo oTorneo = new SistemaARA.Entidades.Torneo();

            try
            {
                //Valido los datos del formulario
                Validar();

                // Si todo está bien creo un objeto contacto con la nueva informacion
                oTorneo.nombre = txbNombre.Text.Trim();
                oTorneo.lugar = txbLugar.Text;
                oTorneo.direccion = txbDireccion.Text.Trim();
                oTorneo.fechaHora = dtpFecha.Value;

                SistemaARA.Entidades.Tipos oTipos;
                SistemaARA.Negocio.Tipos oTiposNegocio = new SistemaARA.Negocio.Tipos();

                oTipos = oTiposNegocio.GetOne(cmbTipo.Text);
                SistemaARA.Entidades.Tipo oTipo = oTipos[0];

                oTorneo.idTipo = oTipo.idTipo;
                oTorneo.costoEstandar = float.Parse(txbCostoInscripcion.Text.Trim());

                SistemaARA.Entidades.Arbitros oArbitros;
                SistemaARA.Negocio.Arbitros oArbitrosNegocio = new SistemaARA.Negocio.Arbitros();

                oArbitros = oArbitrosNegocio.GetOneNroDoc(cmbArbitro.Text.Substring(0, 10));
                SistemaARA.Entidades.Arbitro oArbitro = oArbitros[0];

                oTorneo.idArbitro = oArbitro.idArbitro;

                // Verifico operación
                if (Operacion == General.TipoOperacion.Alta)
                {
                    // Agrego nuevo torneo
                    oTorneosNegocio.Add(oTorneo);
                    MessageBox.Show("Torneo agregado exitosamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Actualizo jugador existente
                    oTorneo.idTorneo = IdTorneo;
                    oTorneosNegocio.Update(oTorneo);
                    MessageBox.Show("Torneo actualizado exitosamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Indico que todo salio bien y cierro el formulario
                Cancelado = false;
                this.Hide();
            }
            catch (Exception ex)
            {
                // Muestro cualquier error de la aplicacion o por validación
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                // Libera objetos
                oTorneo = null;
                oTorneosNegocio = null;
            }
        }

        // Cancela la operacion
        private void CancelarOperacion()
        {
            // Cancelo la operación y retorno al formulario llamador
            Cancelado = true;
            this.Hide();
        }

        #endregion
    }
}
