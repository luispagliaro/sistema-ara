using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaARA.Entidades
{
    public class Arbitro
    {
        #region Propiedades

        private int _idArbitro, _idCategoria, _baja;
        private string _nroDoc, _tipoDoc, _nombre, _apellido, _telCelular, _email, _telefono, _direccion, _localidad;
        private DateTime _fechaNacimiento;

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

        public int idCategoria
        {
            get
            {
                return _idCategoria;
            }
            set
            {
                _idCategoria = value;
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

        public Arbitro()
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
            _nroDoc = "";
            _tipoDoc = "";
            _idArbitro = 0;
            _nombre = "";
            _apellido = "";
            _direccion = "";
            _localidad = "";
            _email = "";
            _telCelular = "";
            _telefono = "";
            _fechaNacimiento = DateTime.Today;
            _idCategoria = 0;
            _baja = 0;
        }

        #endregion
    }
}
