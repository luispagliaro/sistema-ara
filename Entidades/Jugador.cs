using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaARA.Entidades
{
    public class Jugador
    {
        #region Propiedades

        private int _idJugador, _idInstitucion, _baja;
        private string _nroDoc, _tipoDoc, _nombre, _apellido, _direccion, _localidad,_telefono, _telCelular, _email, _eloLocal, _idFide, _sexo;
        private DateTime _fechaNacimiento;

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

        public int idInstitucion
        {
            get
            {
                return _idInstitucion;
            }
            set
            {
                _idInstitucion = value;
            }
        }

        public int baja
        {
            get
            {
                return _baja;
            }
            set
            {
                _baja = value;
            }
        }

        public string nroDoc
        {
            get
            {
                return _nroDoc;
            }
            set
            {
                _nroDoc = value;
            }
        }

        public string tipoDoc
        {
            get
            {
                return _tipoDoc;
            }
            set
            {
                _tipoDoc = value;
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

        public string apellido
        {
            get
            {
                return _apellido;
            }
            set
            {
                _apellido = value;
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

        public string localidad
        {
            get
            {
                return _localidad;
            }
            set
            {
                _localidad = value;
            }
        }

        public string telefono
        {
            get
            {
                return _telefono;
            }
            set
            {
                _telefono = value;
            }
        }

        public string telCelular
        {
            get
            {
                return _telCelular;
            }
            set
            {
                _telCelular = value;
            }
        }

        public string email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

        public string eloLocal
        {
            get
            {
                return _eloLocal;
            }
            set
            {
                _eloLocal = value;
            }
        }

        public string idFide
        {
            get
            {
                return _idFide;
            }
            set
            {
                _idFide = value;
            }
        }

        public string sexo
        {
            get
            {
                return _sexo;
            }
            set
            {
                _sexo = value;
            }
        }

        public DateTime fechaNacimiento
        {
            get
            {
                return _fechaNacimiento;
            }
            set
            {
                _fechaNacimiento = value;
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

        public Jugador()
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
            _idJugador = 0;
            _idInstitucion = 0;
            _nroDoc = "";
            _tipoDoc = "";
            _nombre = "";
            _apellido = "";
            _direccion = "";
            _localidad = "";
            _telefono = "";
            _telCelular = "";
            _email = "";
            _eloLocal = "";
            _idFide = "";
            _sexo = "";
            _fechaNacimiento = DateTime.Now;
            _baja = 0;
        }

        #endregion
    }
}
