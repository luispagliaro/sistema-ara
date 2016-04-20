using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaARA.Negocio
{
    public class Pagos
    {
        #region Metodos

        /// <summary>
        /// Agrega un pago a la base de datos
        /// </summary>
        /// <param name="pago"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public int Add(Entidades.Pago pago)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Pagos oDatos;
            try
            {
                //Crea una instancia de la clase Pago de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Pagos();

                return oDatos.Add(pago);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Actualiza un pago de la base de datos
        /// </summary>
        /// <param name="pago"></param>
        /// <remarks></remarks>
        public void Update(Entidades.Pago pago)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Pagos oDatos;
            try
            {
                //Crea una instancia de la clase Institucion de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Pagos();

                oDatos.Update(pago);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Elimina los pagos de una institucion de la base de datos
        /// </summary>
        /// <param name="idInstitucion, fecha"></param>
        /// <remarks></remarks>
        public void Delete(int idInstitucion, DateTime fecha)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Pagos oDatos;
            try
            {
                //Crea una instancia de la clase Pago de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Pagos();

                oDatos.Delete(idInstitucion, fecha);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Obtiene un pago de institución en base a un idInstitucion
        /// </summary>
        /// <param name="id"></param>
        /// <remarks></remarks>
        public Entidades.Pagos GetOne(int idInstitucion, DateTime fecha)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Pagos oDatos;
            try
            {
                //Crea una instancia de la clase Institucion de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Pagos();

                return oDatos.GetOne(idInstitucion, fecha);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// Obtiene un pago de institución en base a una fecha
        /// </summary>
        /// <param name="id"></param>
        /// <remarks></remarks>
        public Entidades.Pagos GetOne(DateTime fecha)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Pagos oDatos;
            try
            {
                //Crea una instancia de la clase Institucion de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Pagos();

                return oDatos.GetOne(fecha);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Retorna todos los pagos de una institucion de la base de datos
        /// </summary>
        /// <remarks></remarks>
        public Entidades.Pagos GetAll(int idInstitucion)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Pagos oDatos;
            try
            {
                //Crea una instancia de la clase Pago de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Pagos();

                return oDatos.GetAll(idInstitucion);
            }
            finally
            {
                oDatos = null;
            }
        }

        #endregion
    }
}
