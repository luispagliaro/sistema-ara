using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaARA.Negocio
{
    public class Cuotas
    {
        #region Metodos

        /// <summary>
        /// Agrega una categoria a la base de datos
        /// </summary>
        /// <param name="cuota"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public void Add(Entidades.Cuota cuota)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Cuotas oDatos;
            try
            {
                //Crea una instancia de la clase Cuota de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Cuotas();

                oDatos.Add(cuota);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Actualiza una Cuota de la base de datos
        /// </summary>
        /// <param name="cuota"></param>
        /// <remarks></remarks>
        public void Update(Entidades.Cuota cuota)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Cuotas oDatos;
            try
            {
                //Crea una instancia de la clase Cuota de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Cuotas();

                oDatos.Update(cuota);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Elimina una cuota de la base de datos
        /// </summary>
        /// <param name="fecha"></param>
        /// <remarks></remarks>
        public void Delete(DateTime fecha)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Cuotas oDatos;
            try
            {
                //Crea una instancia de la clase Cuota de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Cuotas();

                oDatos.Delete(fecha);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Obtiene un cuota en base a una fecha
        /// </summary>
        /// <param name="fecha"></param>
        /// <remarks></remarks>
        public Entidades.Cuotas GetOne(DateTime fecha)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Cuotas oDatos;
            try
            {
                //Crea una instancia de la clase Cuota de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Cuotas();

                return oDatos.GetOne(fecha);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Obtiene todas las cuotas en base a un año
        /// </summary>
        /// <param name="año"></param>
        /// <remarks></remarks>
        public Entidades.Cuotas GetCuotasAño(string año)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Cuotas oDatos;
            try
            {
                //Crea una instancia de la clase Cuota de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Cuotas();

                return oDatos.GetCuotasAño(año);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Retorna todos las Cuotas de la base de datos a pagar por una institución
        /// </summary>
        /// <param name="idInstitucion"></param>
        /// <remarks></remarks>
        public Entidades.Cuotas GetCuotasAPagar(int idInstitucion)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Cuotas oDatos;
            try
            {
                //Crea una instancia de la clase Cuota de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Cuotas();

                return oDatos.GetCuotasAPagar(idInstitucion);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Retorna todos las Cuotas de la base de datos pagadas por una institución
        /// </summary>
        /// <param name="idInstitucion"></param>
        /// <remarks></remarks>
        public Entidades.Cuotas GetCuotasPagadas(int idInstitucion)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Cuotas oDatos;
            try
            {
                //Crea una instancia de la clase Cuota de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Cuotas();

                return oDatos.GetCuotasAPagar(idInstitucion);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// retorna todos las Cuotas de la base de datos
        /// </summary>
        /// <remarks></remarks>
        public Entidades.Cuotas GetAll()
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Cuotas oDatos;
            try
            {
                //Crea una instancia de la clase Cuota de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Cuotas();

                return oDatos.GetAll();
            }
            finally
            {
                oDatos = null;
            }
        }

        #endregion
    }
}
