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
    public partial class frmCategoria : Form
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

        public frmCategoria()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            IniciarFormulario();
        }

        private void frmCategoria_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
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
                this.Text = "Categoria - Edición";
                // Debo obtener la categoría  para editar
                SistemaARA.Entidades.Categorias oCategorias;
                SistemaARA.Negocio.Categorias oCategoriasNegocio = new SistemaARA.Negocio.Categorias();
                try
                {
                    // Solicito a negocio toda la informacion de la categoría a editar
                    oCategorias = oCategoriasNegocio.GetOne(IdCategoria);

                    // Verifico que haya obtenido datos
                    if (oCategorias.Count > 0)
                    {
                        // Siempre es el primer valor de la coleccion
                        // Visualizo los datos en los controles
                        SistemaARA.Entidades.Categoria oCategoria = oCategorias[0];

                        txbDescripcion.Text = oCategoria.descripcion;
                    }
                    else
                    {
                        // Sino puedo encontrar la categoria, puede haberse eliminado por otro usuario
                        // Informo de la situación e invalido el formulario para cualquier operación
                        MessageBox.Show("La categoría solicitada no existe. Verifique que no haya sido eliminada.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        gpbDatosCategoria.Enabled = false;
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
                    oCategorias = null;
                    oCategoriasNegocio = null;
                }
            }
            else
            {
                this.Text = "Categoría - Alta";
            }
        }

        // Valida los datos antes de realizar cualquier operación
        private void Validar()
        {
            if (txbDescripcion.Text.Trim() == "")
            {
                txbDescripcion.Focus();
                throw new ArgumentException("Debe ingresar el nombre de la categoría.");
            }
        }

        // Confirmar la operación en curso
        private void AceptarOperacion()
        {
            SistemaARA.Negocio.Categorias oCategoriasNegocio = new SistemaARA.Negocio.Categorias();
            SistemaARA.Entidades.Categoria oCategoria = new SistemaARA.Entidades.Categoria();
            SistemaARA.Entidades.Categorias oCategorias;

            try
            {
                //Valido los datos del formulario
                Validar();

                // Si todo está bien creo un objeto categoría con la nueva informacion
                oCategoria.descripcion = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(txbDescripcion.Text.Trim());

                // Verifico operación
                if (Operacion == General.TipoOperacion.Alta)
                {
                    // Solicito a negocio todos los arbitros para validar que no exista uno registrado con el documento ingresado
                    oCategorias = oCategoriasNegocio.GetAll();

                    foreach (SistemaARA.Entidades.Categoria Categoria in oCategorias)
                    {
                        if (Categoria.descripcion.Equals(txbDescripcion.Text))
                        {
                            txbDescripcion.Focus();
                            throw new ArgumentException("Ya existe una categoría con esa descripción.");
                        }
                    }

                    // Agrego nueva categoría
                    oCategoriasNegocio.Add(oCategoria);
                    MessageBox.Show("Categoría agregada exitosamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Actualizo categoría existente
                    oCategoria.idCategoria = IdCategoria;
                    oCategoriasNegocio.Update(oCategoria);
                    MessageBox.Show("Categoría actualizada exitosamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                oCategoria = null;
                oCategorias = null;
                oCategoriasNegocio = null;
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
