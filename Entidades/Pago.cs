using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaARA.Entidades
{
    public class Pago
    {
        #region Propiedades

        private DateTime _fechaPago, _fecha;
        private int _idInstitucion;

        public DateTime fechaPago
        {
            get
            {
                return _fechaPago;
            }
            set
            {
                _fechaPago = value;
            }
        }

        public DateTime fecha
        {
            get
            {
                return _fecha;
            }
            set
            {
                _fecha = value;
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

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor: Inicializa la entidad al instanciarse con valores por defecto.
        /// </summary>
        /// <remarks>
        /// Reutiliza un método público para realizar la tarea
        /// </remarks>

        public Pago()
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
            _fecha = DateTime.Today;
            _fechaPago = DateTime.Today;
            _idInstitucion = 0;
        }

        #endregion
    }
}
