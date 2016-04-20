using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Presentación
{
    public partial class frmInscripcion : Form
    {
        #region Propiedades

        private bool mCancelado = true;
        private int mIdTorneo = 0;
        private int mIdJugador = 0;
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

        /// <summary>
        ///  Indica el jugador del torneo a editar
        /// </summary>
        public int IdJugador
        {
            get
            {
                return mIdJugador;
            }
            set
            {
                mIdJugador = value;
            }
        }

        #endregion

        #region Constructores

        public frmInscripcion()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            IniciarFormulario();
            ObtenerJugadoresNombre();
            ObtenerJugadoresNroDoc();
        }

        private void txbNomApJugador_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void txbNomApJugador_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = this.btnAceptar;
        }

        private void txbNroDocJugador_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void txbNroDocJugador_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = this.btnAceptar;
        }

        private void frmInscripcion_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
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

        private void IngresoSoloNumeros(object sender, KeyPressEventArgs e)
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
                else if (e.KeyChar.Equals('.'))
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan 
                    e.Handled = true;
                }
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

        private void IngresoSoloLetras(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.Equals(','))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txbNomApJugador_TextChanged(object sender, EventArgs e)
        {
            SistemaARA.Negocio.Jugadores oJugadoresNegocio = new SistemaARA.Negocio.Jugadores();
            SistemaARA.Entidades.Jugadores oJugadores = new SistemaARA.Entidades.Jugadores();

            oJugadores = oJugadoresNegocio.GetOne(txbNomApJugador.Text);

            if (oJugadores.Count > 0)
            {
                if (oJugadores[0].nroDoc.ToString() == ".   .")
                {
                    txbNroDocJugador.Text = "S/D";
                }
                else
                {
                    txbNroDocJugador.Text = oJugadores[0].nroDoc.ToString();
                }
            }
            else
            {
                txbNroDocJugador.Text = "";
            }
        }

        private void txbNroDocJugador_TextChanged(object sender, EventArgs e)
        {
            SistemaARA.Negocio.Jugadores oJugadoresNegocio = new SistemaARA.Negocio.Jugadores();
            SistemaARA.Entidades.Jugadores oJugadores = new SistemaARA.Entidades.Jugadores();

            oJugadores = oJugadoresNegocio.GetOneNroDoc(txbNroDocJugador.Text);

            if (oJugadores.Count > 0)
            {
                txbNomApJugador.Text = oJugadores[0].apellido + ", " + oJugadores[0].nombre;
            }
            else
            {
                txbNomApJugador.Text = "";
            }
        }

        #endregion

        #region Metodos

        private void ObtenerJugadoresNombre()
        {
            var source = new AutoCompleteStringCollection();

            SistemaARA.Negocio.Jugadores oJugadoresNegocio = new SistemaARA.Negocio.Jugadores();
            SistemaARA.Entidades.Jugadores oJugadores = new SistemaARA.Entidades.Jugadores();

            oJugadores = oJugadoresNegocio.GetAll();

            foreach (SistemaARA.Entidades.Jugador oJugador in oJugadores)
            {
                source.Add(oJugador.apellido + ", " + oJugador.nombre);
            }

            txbNomApJugador.AutoCompleteCustomSource = source;
        }

        private void ObtenerJugadoresNroDoc()
        {
            var source = new AutoCompleteStringCollection();

            SistemaARA.Negocio.Jugadores oJugadoresNegocio = new SistemaARA.Negocio.Jugadores();
            SistemaARA.Entidades.Jugadores oJugadores = new SistemaARA.Entidades.Jugadores();

            oJugadores = oJugadoresNegocio.GetAll();

            foreach (SistemaARA.Entidades.Jugador oJugador in oJugadores)
            {
                source.Add(oJugador.nroDoc);
            }

            txbNroDocJugador.AutoCompleteCustomSource = source;
        }

        // Inicializa el formulario
        private void IniciarFormulario()
        {
            SistemaARA.Negocio.Torneos oTorneosNegocio = new SistemaARA.Negocio.Torneos();
            SistemaARA.Entidades.Torneos oTorneos = new SistemaARA.Entidades.Torneos();
            oTorneos = oTorneosNegocio.GetOne(IdTorneo);

            txbTorneo.Text = oTorneos[0].nombre;
            txbCostoInscripcion.Text = oTorneos[0].costoEstandar.ToString();

            // Verifica la operacion en curso
            if (Operacion == General.TipoOperacion.Edicion)
            {
                if (oTorneos[0].fechaHora < DateTime.Today)
                {
                    MessageBox.Show("El torneo ya fue realizado. No se pueden modificar los datos de la inscripción.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    CancelarOperacion();
                    this.Close();
                }
                else
                {
                    lblNomApRequerido.Visible = false;
                    lblNroDocRequerido.Visible = false;

                    this.Text = "Inscripcion - Edición";
                    // Debo obtener la inscripcion para editar
                    SistemaARA.Entidades.Inscripciones oInscripciones;
                    SistemaARA.Negocio.Inscripciones oInscripcionesNegocio = new SistemaARA.Negocio.Inscripciones();

                    txbNomApJugador.Enabled = false;
                    txbNroDocJugador.Enabled = false;

                    try
                    {
                        // Solicito a negocio toda la informacion de la inscripcion a editar
                        oInscripciones = oInscripcionesNegocio.GetOne(IdJugador, IdTorneo);

                        // Verifico que haya obtenido datos
                        if (oInscripciones.Count > 0)
                        {
                            // Siempre es el primer valor de la coleccion
                            // Visualizo los datos en los controles
                            SistemaARA.Entidades.Inscripcion oInscripcion = oInscripciones[0];

                            SistemaARA.Entidades.Jugadores oJugadores;
                            SistemaARA.Negocio.Jugadores oJugadoresNegocio = new SistemaARA.Negocio.Jugadores();

                            oJugadores = oJugadoresNegocio.GetOne(IdJugador);

                            txbNomApJugador.Text = oJugadores[0].apellido + ", " + oJugadores[0].nombre;

                            if (oJugadores[0].nroDoc.ToString() == ".   .")
                            {
                                txbNroDocJugador.Text = "S/D";
                            }
                            else
                            {
                                txbNroDocJugador.Text = oJugadores[0].nroDoc.ToString();
                            }
                        }
                        else
                        {
                            // Sino puedo encontrar el jugador, puede haberse eliminado por otro usuario
                            // Informo de la situación e invalido el formulario para cualquier operación
                            MessageBox.Show("La inscripción solicitada no existe. Verifique que no haya sido eliminada.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            gpbDatosInscripcion.Enabled = false;
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
                        oInscripciones = null;
                        oInscripcionesNegocio = null;
                    }
                }
            }
            else
            {
                if (oTorneos[0].fechaHora < DateTime.Today)
                {
                    MessageBox.Show("El torneo ya fue realizado. No se puede registrar una inscripción.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    CancelarOperacion();
                    this.Close();
                }
                else
                {
                    this.Text = "Inscripcion - Alta";

                    txbNomApJugador.Text = "";
                    txbNroDocJugador.Text = "";
                }
            }
        }

        // Valida los datos antes de realizar cualquier operación
        private void Validar()
        {
            if (txbTorneo.Text.Trim() == "")
            {
                txbTorneo.Focus();
                throw new ArgumentException("Debe ingresar el nombre del torneo.");
            }

            if (txbNomApJugador.Text.Trim() == "")
            {
                txbNomApJugador.Focus();
                throw new ArgumentException("Debe ingresar el apellido y nombre del jugador.");
            }

            if (txbNroDocJugador.Text.Trim() == "")
            {
                txbNroDocJugador.Focus();
                throw new ArgumentException("Debe ingresar el número de documento del jugador.");
            }

            if (txbCostoInscripcion.Text.Trim() == "")
            {
                txbCostoInscripcion.Focus();
                throw new ArgumentException("Debe ingresar el costo de inscripción del torneo.");
            }
        }

        // Confirmar la operación en curso
        private void AceptarOperacion()
        {
            SistemaARA.Negocio.Inscripciones oInscripcionesNegocio = new SistemaARA.Negocio.Inscripciones();
            SistemaARA.Entidades.Inscripcion oInscripcion = new SistemaARA.Entidades.Inscripcion();
            SistemaARA.Entidades.Inscripciones oInscripciones;

            try
            {
                //Valido los datos del formulario
                Validar();

                // Si todo está bien creo un objeto contacto con la nueva informacion
                oInscripcion.idTorneo = IdTorneo;

                SistemaARA.Entidades.Jugadores oJugadores;
                SistemaARA.Negocio.Jugadores oJugadoresNegocio = new SistemaARA.Negocio.Jugadores();

                oInscripcion.costoInscripcion = Convert.ToInt64(txbCostoInscripcion.Text);

                if (txbNroDocJugador.Text == "S/D")
                {
                    oJugadores = oJugadoresNegocio.GetOne(txbNomApJugador.Text);
                }
                else
                {
                    oJugadores = oJugadoresNegocio.GetOneNroDoc(txbNroDocJugador.Text);
                }

                if (oJugadores.Count > 0)
                {
                    oInscripcion.idJugador = oJugadores[0].idJugador;

                    // Verifico operación
                    if (Operacion == General.TipoOperacion.Alta)
                    {
                        // Solicito a negocio todos los jugadores para validar que no exista uno registrado con el documento ingresado
                        oInscripciones = oInscripcionesNegocio.GetAll(IdTorneo);

                        foreach (SistemaARA.Entidades.Inscripcion Inscripcion in oInscripciones)
                        {
                            if (Inscripcion.idJugador.Equals(oJugadores[0].idJugador))
                            {
                                txbNomApJugador.Focus();
                                throw new ArgumentException("El jugador ingresado ya se encuentra inscripto.");
                            }
                        }

                        // Agrego nuevo jugador
                        oInscripcionesNegocio.Add(oInscripcion);
                        IniciarFormulario();

                        MessageBox.Show("Inscripción registrada exitosamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Cancelado = false;
                    }
                    else
                    {
                        // Actualizo jugador existente
                        oInscripcion.idTorneo = IdTorneo;
                        oInscripcion.idJugador = IdJugador;
                        oInscripcionesNegocio.Update(oInscripcion);
                        MessageBox.Show("Inscripción actualizada exitosamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Cancelado = false;
                        this.Hide();
                    }
                }
                else
                {
                    throw new ArgumentException("El jugador ingresado no se encuentra registrado.");
                }
            }
            catch (Exception ex)
            {
                // Muestro cualquier error de la aplicacion o por validación
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Libera objetos
                oInscripciones = null;
                oInscripciones = null;
                oInscripcionesNegocio = null;
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

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            // Creo nueva instancia de formulario "Jugador" para dar de alta un jugador
            frmJugador ofrmJugador;
            ofrmJugador = new frmJugador();

            // Indico la operacion a realizar
            ofrmJugador.Operacion = General.TipoOperacion.Alta;

            // Muestro el formulario de manera modal
            ofrmJugador.ShowDialog();

            // Verifico el resultado de la operacion
            bool resultadoOk = !ofrmJugador.Cancelado;

            // Cierro formulario
            ofrmJugador.Close();

            // Elimino instancia del formulario
            ofrmJugador = null;

            ObtenerJugadoresNombre();
            ObtenerJugadoresNroDoc();
        }
    }
}
