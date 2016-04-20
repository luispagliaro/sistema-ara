using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaARA.Entidades
{
    public class Tipo
    {
        #region Propiedades

        private int _idTipo;
        private string _descripcion;

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

        public string descripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                _descripcion = value;
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

        public Tipo()
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
            _idTipo = 0;
            _descripcion = "";
        }

        #endregion
    }
}
