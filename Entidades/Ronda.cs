using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaARA.Entidades
{
    public class Ronda
    {
        #region Propiedades

        private int _idTorneo, _nroRonda;

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
        
        public int nroRonda
        {
            get
            {
                return _nroRonda;
            }
            set
            {
                _nroRonda = value;
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

        public Ronda()
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
            _nroRonda = 0;
       }

        #endregion
    }
}
