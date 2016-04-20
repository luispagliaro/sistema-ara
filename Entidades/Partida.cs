using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaARA.Entidades
{
    public class Partida
    {
        #region Propiedades

        private int _idJugador1, _idJugador2, _idTorneo, _idRonda;
        private float _cambioEloLocalJug1, _cambioEloLocalJug2;
        private string _resultadoJug1, _resultadoJug2, _movimientos;

        public int idJugador1
        {
            get
            {
                return _idJugador1;
            }
            set
            {
                _idJugador1 = value;
            }
        }

        public int idJugador2
        {
            get
            {
                return _idJugador2;
            }
            set
            {
                _idJugador2 = value;
            }
        }
        
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
        
        public int idRonda
        {
            get
            {
                return _idRonda;
            }
            set
            {
                _idRonda = value;
            }
        }

        public string resultadoJug1
        {
            get
            {
                return _resultadoJug1;
            }
            set
            {
                _resultadoJug1 = value;
            }
        }

        public string resultadoJug2
        {
            get
            {
                return _resultadoJug2;
            }
            set
            {
                _resultadoJug2 = value;
            }
        }
        
        public float cambioEloLocalJug1
        {
            get
            {
                return _cambioEloLocalJug1;
            }
            set
            {
                _cambioEloLocalJug1 = value;
            }
        }

        public float cambioEloLocalJug2
        {
            get
            {
                return _cambioEloLocalJug2;
            }
            set
            {
                _cambioEloLocalJug2 = value;
            }
        }
        
        public string movimientos
        {
            get
            {
                return _movimientos;
            }
            set
            {
                _movimientos = value;
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

        public Partida()
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
            _idJugador1 = 0;
            _idJugador2 = 0;
            _idTorneo = 0;
            _idRonda = 0;
            _cambioEloLocalJug1 = 0;
            _cambioEloLocalJug2 = 0;
            _resultadoJug1 = "";
            _resultadoJug2 = "";
            _movimientos = "";
        }

        #endregion
    }
}
