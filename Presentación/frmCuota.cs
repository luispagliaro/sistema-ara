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
    public partial class frmCuota : Form
    {
        #region Propiedades

        private bool mCancelado = true;
        private DateTime mFecha = DateTime.Today;
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
        ///  Indica la fecha de la cuota
        /// </summary>
        public DateTime Fecha
        {
            get
            {
                return mFecha;
            }
            set
            {
                mFecha = value;
            }
        }

        #endregion

        #region Constructores

        public frmCuota()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        private void frmCuota_Load(object sender, EventArgs e)
        {
            IniciarFormulario();
        }

        private void frmCuota_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
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

        private void ckbCrearTodoAño_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCrearTodoAño.Checked)
            {
                cmbMes.Text = "";
                cmbMes.Enabled = false;
            }
            else
            {
                cmbMes.Text = "";
                cmbMes.Enabled = true;
            }
        }

        #endregion

        #region Metodos

        // Inicializa el formulario
        private void IniciarFormulario()
        {
            tbxAño.Text = DateTime.Today.Year.ToString();

            // Verifica la operacion en curso
            if (Operacion == General.TipoOperacion.Edicion)
            {
                this.Text = "Cuota - Edición";
                ckbCrearTodoAño.Enabled = false;
                cmbMes.Enabled = false;

                // Debo obtener la cuota para editar
                SistemaARA.Entidades.Cuotas oCuotas;
                SistemaARA.Negocio.Cuotas oCuotasNegocio = new SistemaARA.Negocio.Cuotas();
                try
                {
                    // Solicito a negocio toda la informacion de la institución a editar
                    oCuotas = oCuotasNegocio.GetOne(Fecha);

                    // Verifico que haya obtenido datos
                    if (oCuotas.Count > 0)
                    {
                        // Siempre es el primer valor de la coleccion
                        // Visualizo los datos en los controles
                        SistemaARA.Entidades.Cuota oCuota = oCuotas[0];

                        tbxAño.Text = oCuota.fecha.Year.ToString();
                        cmbMes.Text = oCuota.fecha.ToString("MMMM");
                        tbxImporte.Text = oCuota.importe;
                    }
                    else
                    {
                        // Sino puedo encontrar la institución, puede haberse eliminado por otro usuario
                        // Informo de la situación e invalido el formulario para cualquier operación
                        MessageBox.Show("La cuota solicitada no existe. Verifique que no haya sido eliminada.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        gpbDatosCuota.Enabled = false;
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
                    oCuotas = null;
                    oCuotasNegocio = null;
                }
            }
            else
            {
                this.Text = "Cuota - Alta";
            }
        }

        // Valida los datos antes de realizar cualquier operación
        private void Validar()
        {
            if (cmbMes.SelectedItem == null && !ckbCrearTodoAño.Checked)
            {
                cmbMes.Focus();
                throw new ArgumentException("Debe seleccionar el mes de la cuota.");
            }

            if (tbxAño.Text.Trim() == "")
            {
                tbxAño.Focus();
                throw new ArgumentException("Debe ingresar ingresar el año de la cuota.");
            }

            if (tbxImporte.Text.Trim() == "")
            {
                tbxImporte.Focus();
                throw new ArgumentException("Debe ingresar el importe de la cuota.");
            }

            /*
            DateTime fec = Convert.ToDateTime("01/" + (cmbMes.SelectedIndex + 1).ToString() + "/" + DateTime.Today.Year.ToString());

            if (fec.Month < DateTime.Today.Month)
            {
                cmbMes.Focus();
                tbxAño.Focus();
                throw new ArgumentException("No puede ingresar una cuota de un mes anterior al actual.");
            }*/
        }

        // Confirmar la operación en curso
        private void AceptarOperacion()
        {
            SistemaARA.Negocio.Cuotas oCuotasNegocio = new SistemaARA.Negocio.Cuotas();
            SistemaARA.Entidades.Cuota oCuota = new SistemaARA.Entidades.Cuota();
            SistemaARA.Entidades.Cuotas oCuotas;

            try
            {
                //Valido los datos del formulario
                Validar();

                if (ckbCrearTodoAño.Checked == false)
                {
                    // Si todo está bien creo un objeto contacto con la nueva informacion
                    DateTime fec = Convert.ToDateTime("01/" + (cmbMes.SelectedIndex + 1).ToString() + "/" + tbxAño.Text);

                    oCuota.fecha = fec;
                    oCuota.importe = tbxImporte.Text.Trim();

                    // Verifico operación
                    if (Operacion == General.TipoOperacion.Alta)
                    {
                        // Solicito a negocio todas las cuotas para validar que no exista una registrada con la fecha ingresada
                        oCuotas = oCuotasNegocio.GetAll();

                        foreach (SistemaARA.Entidades.Cuota Cuota in oCuotas)
                        {
                            if (Cuota.fecha.Month.ToString().Equals((cmbMes.SelectedIndex + 1).ToString()) && Cuota.fecha.Year.ToString().Equals(tbxAño.Text))
                            {
                                cmbMes.Focus();
                                throw new ArgumentException("Ya existe una cuota para el mes y años ingresados.");
                            }
                        }

                        // Agrego nueva cuota
                        oCuotasNegocio.Add(oCuota);
                        MessageBox.Show("Cuota agregada exitosamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Actualizo institución existente
                        oCuotasNegocio.Update(oCuota);
                        MessageBox.Show("Cuota actualizada exitosamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // Si todo está bien creo un objeto contacto con la nueva informacion
                    for (int i = 1; i <= 12; i++)
                    {
                        DateTime fec = Convert.ToDateTime("01/" + i.ToString() + "/" + DateTime.Today.Year.ToString());

                        oCuota.fecha = fec;
                        oCuota.importe = tbxImporte.Text.Trim();

                        // Solicito a negocio todas las cuotas para validar que no exista una registrada con la fecha ingresada
                        oCuotas = oCuotasNegocio.GetAll();

                        foreach (SistemaARA.Entidades.Cuota Cuota in oCuotas)
                        {
                            if (Cuota.fecha.Month.ToString().Equals(i.ToString()) && Cuota.fecha.Year.ToString().Equals(tbxAño.Text))
                            {
                                cmbMes.Focus();
                                throw new ArgumentException("Ya existe una cuota para el mes de " + oCuota.fecha.ToString("MMMM") + " ingresada.");
                            }
                        }

                        // Agrego nueva cuota
                        oCuotasNegocio.Add(oCuota);
                    }

                    MessageBox.Show("Cuotas agregadas exitosamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                oCuota = null;
                oCuotas = null;
                oCuotasNegocio = null;
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
