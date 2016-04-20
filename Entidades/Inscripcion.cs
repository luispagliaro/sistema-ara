using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaARA.Entidades
{
    public class Inscripcion
    {
        #region Propiedades

        private int _idTorneo, _idJugador;
        private float _costoInscripcion;

        public int idTorneo
        {
            get
            {
                return _idTorneo;
            }
            set
            {
                _idTorneo = value;
            }
        }

        public int idJugador
        {
            get
            {
                return _idJugador;
            }
            set
            {
                _idJugador = value;
            }
        }
        public float costoInscripcion
        {
            get
            {
                return _costoInscripcion;
            }
            set
            {
                _costoInscripcion = value;
            }
        }

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor: Inicializa la entidad al instanciarse con valores por defecto.
        /// </summary>
        /// <remarks>
        /// Reutiliza un método público para realizar la tarea
        /// </remarks>

        public Inscripcion()
        {
            this.Reset();
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Inicializa la entidad a los valores por defecto.
        /// </summary>
        public void Reset()
        {
            _idTorneo = 0;
            _idJugador = 0;
            _costoInscripcion = 0;
        }

        #endregion
    }
}
