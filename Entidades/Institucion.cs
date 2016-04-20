using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaARA.Entidades
{
    public class Institucion
    {
        #region Propiedades

        private int _idInstitucion, _baja;
        private string _cuit, _razonSocial, _direccion, _telefono, _telCelular, _email, _nombreContacto, _localidad;
        private DateTime _fechaAlta;

        public string cuit
        {
            get
            {
                return _cuit;
            }
            set
            {
                _cuit = value;
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

        public string razonSocial
        {
            get
            {
                return _razonSocial;
            }
            set
            {
                _razonSocial = value;
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

        public string nombreContacto
        {
            get
            {
                return _nombreContacto;
            }
            set
            {
                _nombreContacto = value;
            }
        }

        public DateTime fechaAlta
        {
            get
            {
                return _fechaAlta;
            }
            set
            {
                _fechaAlta = value;
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

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor: Inicializa la entidad al instanciarse con valores por defecto.
        /// </summary>
        /// <remarks>
        /// Reutiliza un método público para realizar la tarea
        /// </remarks>

        public Institucion()
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
            _cuit = "";
            _idInstitucion = 0;
            _razonSocial = "";
            _direccion = "";
            _email = "";
            _telefono = "";
            _telCelular = "";
            _nombreContacto = "";
            _fechaAlta = DateTime.Today;
            _localidad = "";
            _baja = 0;
        }

        #endregion
    }
}
