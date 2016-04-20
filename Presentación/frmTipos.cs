using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación
{
    public partial class frmCategorias : Form
    {
        #region Propiedades

        private bool mCancelado = true;
        private int mIdCategoria = 0;
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
        ///  Indica el ID de la categoria a editar
        /// </summary>
        public int IdCategoria
        {
            get
            {
                return mIdCategoria;
            }
            set
            {
                mIdCategoria = value;
            }
        }

        #endregion

        #region Constructores

        public frmCategorias()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        private void frmTipo_Load(object sender, EventArgs e)
        {
            IniciarFormulario();
        }

        private void frmTipo_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
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

        #endregion

        #region Metodos

        // Inicializa el formulario
        private void IniciarFormulario()
        {
            // Verifica la operacion en curso
            if (Operacion == General.TipoOperacion.Edicion)
            {
                this.Text = "Tipo - Edición";
                // Debo obtener la categoría  para editar
                SistemaARA.Entidades.Tipos oTipos;
                SistemaARA.Negocio.Tipos oTiposNegocio = new SistemaARA.Negocio.Tipos();
                try
                {
                    // Solicito a negocio toda la informacion de la categoría a editar
                    oTipos = oTiposNegocio.GetOne(IdTipo);

                    // Verifico que haya obtenido datos
                    if (oTipos.Count > 0)
                    {
                        // Siempre es el primer valor de la coleccion
                        // Visualizo los datos en los controles
                        SistemaARA.Entidades.Tipo oTipo = oTipos[0];

                        txbDescripcion.Text = oTipo.descripcion;
                    }
                    else
                    {
                        // Sino puedo encontrar el tipo, puede haberse eliminado por otro usuario
                        // Informo de la situación e invalido el formulario para cualquier operación
                        MessageBox.Show("El tipo solicitado no existe. Verifique que no haya sido eliminado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        gpbDatosTipo.Enabled = false;
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
                    oTipos = null;
                    oTiposNegocio = null;
                }
            }
            else
            {
                this.Text = "Tipo - Alta";
            }
        }

        // Valida los datos antes de realizar cualquier operación
        private void Validar()
        {
            if (txbDescripcion.Text.Trim() == "")
            {
                txbDescripcion.Focus();
                throw new ArgumentException("Debe ingresar el nombre del tipo.");
            }
        }

        // Confirmar la operación en curso
        private void AceptarOperacion()
        {
            SistemaARA.Negocio.Tipos oTiposNegocio = new SistemaARA.Negocio.Tipos();
            SistemaARA.Entidades.Tipo oTipo = new SistemaARA.Entidades.Tipo();
            SistemaARA.Entidades.Tipos oTipos;

            try
            {
                //Valido los datos del formulario
                Validar();

                // Si todo está bien creo un objeto tipo con la nueva informacion
                oTipo.descripcion = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(txbDescripcion.Text.Trim());

                // Verifico operación
                if (Operacion == General.TipoOperacion.Alta)
                {
                    // Solicito a negocio todos los arbitros para validar que no exista uno registrado con el documento ingresado
                    oTipos = oTiposNegocio.GetAll();

                    foreach (SistemaARA.Entidades.Tipo Tipo in oTipos)
                    {
                        if (Tipo.descripcion.Equals(txbDescripcion.Text))
                        {
                            txbDescripcion.Focus();
                            throw new ArgumentException("Ya existe una categoría con esa descripción.");
                        }
                    }

                    // Agrego nueva categoría
                    oTiposNegocio.Add(oTipo);
                    MessageBox.Show("Tipo agregado exitosamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Actualizo el tipo existente
                    oTipo.idTipo = IdTipo;
                    oTiposNegocio.Update(oTipo);
                    MessageBox.Show("Tipo actualizado exitosamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                oTipo = null;
                oTipos = null;
                oTiposNegocio = null;
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
