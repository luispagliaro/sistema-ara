using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaARA.Negocio
{
    public class Torneos
    {
        #region Metodos

        /// <summary>
        /// Agrega un Torneo a la base de datos
        /// </summary>
        /// <param name="torneo"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public int Add(Entidades.Torneo torneo)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Torneos oDatos;
            try
            {
                //Crea una instancia de la clase Torneo de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Torneos();

                return oDatos.Add(torneo);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Actualiza un Torneo de la base de datos
        /// </summary>
        /// <param name="torneo"></param>
        /// <remarks></remarks>
        public void Update(Entidades.Torneo torneo)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Torneos oDatos;
            try
            {
                //Crea una instancia de la clase Torneo de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Torneos();

                oDatos.Update(torneo);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Elimina una torneo de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <remarks></remarks>
        public void Delete(int id)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Torneos oDatos;
            try
            {
                //Crea una instancia de la clase Torneo de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Torneos();

                oDatos.Delete(id);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Obtiene una Torneo en base a un id
        /// </summary>
        /// <param name="nombre"></param>
        /// <remarks></remarks>
        public Entidades.Torneos GetOne(int id)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Torneos oDatos;
            try
            {
                //Crea una instancia de la clase Torneo de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Torneos();

                return oDatos.GetOne(id);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Obtiene una Torneo en base a un nombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <remarks></remarks>
        public Entidades.Torneos GetOne(string nombre)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Torneos oDatos;
            try
            {
                //Crea una instancia de la clase Torneo de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Torneos();

                return oDatos.GetOne(nombre);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Retorna todos los Torneos de un año de la base de datos
        /// </summary>
        /// <remarks></remarks>
        public Entidades.Torneos GetTorneosAño(string año)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Torneos oDatos;
            try
            {
                //Crea una instancia de la clase Torneo de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Torneos();

                return oDatos.GetTorneosAño(año);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// retorna todos los Torneos de la base de datos
        /// </summary>
        /// <remarks></remarks>
        public Entidades.Torneos GetAll()
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Torneos oDatos;
            try
            {
                //Crea una instancia de la clase Torneo de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Torneos();

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
