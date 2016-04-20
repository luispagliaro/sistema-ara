using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaARA.Entidades
{
    public class Torneo
    {
        #region Propiedades

        private int _idTorneo, _idArbitro, _idTipo;
        private string _lugar, _direccion, _nombre;
        private float _costoEstandar;
        private DateTime _fechaHora;

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
        
        public int idArbitro
        {
            get
            {
                return _idArbitro;
            }
            set
            {
                _idArbitro = value;
            }
        }

        public string nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }

        public string lugar
        {
            get
            {
                return _lugar;
            }
            set
            {
                _lugar = value;
            }
        }

        public string direccion
        {
            get
            {
                return _direccion;
            }
            set
            {
                _direccion = value;
            }
        }

        public int idTipo
        {
            get
            {
                return _idTipo;
            }
            set
            {
                _idTipo = value;
            }
        }

        public float costoEstandar
        {
            get
            {
                return _costoEstandar;
            }
            set
            {
                _costoEstandar = value;
            }
        }

        public DateTime fechaHora
        {
            get
            {
                return _fechaHora;
            }
            set
            {
                _fechaHora = value;
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

        public Torneo()
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
            _idArbitro = 0;
            _lugar = "";
            _direccion = "";
            _idTipo = 0;
            _costoEstandar = 0;
            _fechaHora = DateTime.Today;
       }

        #endregion
    }
}
