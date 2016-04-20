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
    public partial class frmPagoCuota : Form
    {
        #region Propiedades

        private bool mCancelado = true;
        private int mIdInstitucion = 0;
        private DateTime mFechaCuota = Convert.ToDateTime("01/01/1999");
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
        ///  Indica el ID de la institución
        /// </summary>
        public int IdInstitucion
        {
            get
            {
                return mIdInstitucion;
            }
            set
            {
                mIdInstitucion = value;
            }
        }

        /// <summary>
        ///  Indica la cuota a modificar
        /// </summary>
        public DateTime FechaCuota
        {
            get
            {
                return mFechaCuota;
            }
            set
            {
                mFechaCuota = value;
            }
        }

        #endregion

        #region Constructores

        public frmPagoCuota()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        private void frmPagoCuota_Load(object sender, EventArgs e)
        {
            IniciarFormulario();
        }

        private void frmPagoCuota_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
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

        private void cmbCuotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            SistemaARA.Entidades.Cuotas oCuotas;
            SistemaARA.Negocio.Cuotas oCuotasNegocio = new SistemaARA.Negocio.Cuotas();

            try
            {
                oCuotas = oCuotasNegocio.GetOne(Convert.ToDateTime(txbCuota.Text));

                txbImporte.Text = oCuotas[0].importe;
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

        #endregion

        #region Metodos

        // Inicializa el formulario
        private void IniciarFormulario()
        {
            // Obtener cuotas desde la base de datos.
            // Siempre retorna una coleccion de objetos.
            SistemaARA.Entidades.Cuotas oCuotas;
            SistemaARA.Negocio.Cuotas oCuotasNegocio = new SistemaARA.Negocio.Cuotas();

            SistemaARA.Entidades.Pagos oPagos;
            SistemaARA.Negocio.Pagos oPagosNegocio = new SistemaARA.Negocio.Pagos();

            // Verifica la operacion en curso
            if (Operacion == General.TipoOperacion.Edicion)
            {
                this.Text = "Pago cuota - Edición";

                try
                {
                    oPagos = oPagosNegocio.GetOne(IdInstitucion, FechaCuota);

                    if (oPagos.Count > 0)
                    {
                        txbCuota.Text = oPagos[0].fecha.ToString("MM") + "/" + oPagos[0].fecha.Year.ToString();

                        oCuotas = oCuotasNegocio.GetOne(oPagos[0].fecha);

                        txbImporte.Text = oCuotas[0].importe.ToString();

                        dtpFechaPago.Value = oPagos[0].fechaPago;
                    }
                    else
                    {
                        MessageBox.Show("El pago de cuota solicitado no existe. Verifique que no haya sido eliminado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        gpbDatosPagoCuota.Enabled = false;
                        btnAceptar.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    // Muestro cualquier error que ocurra
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Libero memoria de objetos
                    oCuotas = null;
                    oCuotasNegocio = null;
                }
            }
            else
            {
                this.Text = "Pago cuota - Alta";

                dtpFechaPago.Text = DateTime.Today.ToString();

                try
                {
                    oCuotas = oCuotasNegocio.GetOne(FechaCuota);

                    SistemaARA.Entidades.Cuota oCuota = oCuotas[0];

                    txbCuota.Text = oCuota.fecha.ToString("MM") + "/" + oCuota.fecha.Year.ToString();

                    txbImporte.Text = oCuota.importe.ToString();
                }
                catch (Exception ex)
                {
                    // Muestro cualquier error que ocurra
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Libero memoria de objetos
                    oCuotas = null;
                    oCuotasNegocio = null;
                }
            }
        }

        // Valida los datos antes de realizar cualquier operación
        private void Validar()
        {
            if (!dtpFechaPago.Checked)
            {
                dtpFechaPago.Focus();
                throw new ArgumentException("Debe ingresar la fecha de pago de la cuota.");
            }
        }

        // Confirmar la operación en curso
        private void AceptarOperacion()
        {
            SistemaARA.Negocio.Pagos oPagosNegocio = new SistemaARA.Negocio.Pagos();
            SistemaARA.Entidades.Pago oPago = new SistemaARA.Entidades.Pago();

            try
            {
                //Valido los datos del formulario
                Validar();

                oPago.idInstitucion = mIdInstitucion;
                oPago.fecha = Convert.ToDateTime(txbCuota.Text);
                oPago.fechaPago = Convert.ToDateTime(dtpFechaPago.Text);

                if (Operacion == General.TipoOperacion.Alta)
                {
                    oPagosNegocio.Add(oPago);
                    MessageBox.Show("Pago de cuota registrado exitosamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    oPagosNegocio.Update(oPago);
                    MessageBox.Show("Pago de cuota actualizado exitosamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                oPago = null;
                oPagosNegocio = null;
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
