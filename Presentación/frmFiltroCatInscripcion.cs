using Presentación.Informes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación
{
    public partial class frmFiltroCatInscripcion : Form
    {
        #region Propiedades

        private bool mCancelado = true;
        private int mIdTorneo = 0;
        private string mNomTorneo = "";

        /// <summary>
        ///  Indica el ID del torneo
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
        ///  Indica el nombre del torneo
        /// </summary>
        public string NomTorneo
        {
            get
            {
                return mNomTorneo;
            }
            set
            {
                mNomTorneo = value;
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

        #endregion

        #region Constructores

        public frmFiltroCatInscripcion()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

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

        #region Métodos

        // Valida los datos antes de realizar cualquier operación
        private void Validar()
        {
            if (DateTime.Compare(dtpFechaInicio.Value, dtpFechaFin.Value) >= 0)
            {
                dtpFechaInicio.Focus();
                throw new ArgumentException("El año de inicio del rango debe ser menor al de fin.");
            }
        }

        private void AceptarOperacion()
        {
            try
            {
                Validar();

                string fecha = DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();

                string folderPath = string.Empty;

                using (FolderBrowserDialog fdb = new FolderBrowserDialog())
                {
                    fdb.Description = "Seleccione la carpeta donde guardará el archivo.";

                    if (fdb.ShowDialog() == DialogResult.OK)
                    {
                        folderPath = fdb.SelectedPath;
                    }
                }

                string ruta = folderPath;

                if (folderPath != "")
                {

                    infInscriptosTorneo informe = new infInscriptosTorneo();

                    informe.idTorneo.Value = IdTorneo;
                    informe.fechaInicio.Value = dtpFechaInicio.Value.Date;
                    informe.fechaFin.Value = dtpFechaFin.Value.Date;

                    informe.ExportOptions.Text.Separator = "|";

                    ruta = ruta + "\\Sistema ARA - Inscripciones a torneo " + NomTorneo + " (" + dtpFechaInicio.Value.Year + "-" + dtpFechaFin.Value.Year + ").txt";

                    informe.ExportToText(ruta);

                    StartProcess(ruta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelarOperacion()
        {
            Cancelado = true;
            this.Hide();
        }

        public void StartProcess(string path)
        {
            Process process = new Process();
            try
            {
                process.StartInfo.FileName = path;
                process.Start();
                process.WaitForInputIdle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
