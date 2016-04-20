using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaARA.Negocio
{
    public class Arbitros
    {
        #region Metodos

        /// <summary>
        /// Agrega un árbitro a la base de datos
        /// </summary>
        /// <param name="arbitro"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public int Add(Entidades.Arbitro arbitro)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Arbitros oDatos;
            try
            {
                //Crea una instancia de la clase Árbitro de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Arbitros();

                return oDatos.Add(arbitro);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Actualiza una institución de la base de datos
        /// </summary>
        /// <param name="arbitro"></param>
        /// <remarks></remarks>
        public void Update(Entidades.Arbitro arbitro)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Arbitros oDatos;
            try
            {
                //Crea una instancia de la clase Arbitro de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Arbitros();

                oDatos.Update(arbitro);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Elimina una árbitro de la base de datos
        /// </summary>
        /// <param name="Id"></param>
        /// <remarks></remarks>
        public void Delete(int id)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Arbitros oDatos;
            try
            {
                //Crea una instancia de la clase Arbitro de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Arbitros();

                oDatos.Delete(id);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Obtiene un árbitro en base a un Id
        /// </summary>
        /// <param name="id"></param>
        /// <remarks></remarks>
        public Entidades.Arbitros GetOne(int id)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Arbitros oDatos;
            try
            {
                //Crea una instancia de la clase Arbitro de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Arbitros();

                return oDatos.GetOne(id);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Obtiene un árbitro en base a un nombre y apellido
        /// </summary>
        /// <param name="id"></param>
        /// <remarks></remarks>
        public Entidades.Arbitros GetOne(string apNom)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Arbitros oDatos;
            try
            {
                //Crea una instancia de la clase Arbitro de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Arbitros();

                return oDatos.GetOne(apNom);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Obtiene un árbitro en base a un número de documento
        /// </summary>
        /// <param name="nroDoc"></param>
        /// <remarks></remarks>
        public Entidades.Arbitros GetOneNroDoc(string nroDoc)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Arbitros oDatos;
            try
            {
                //Crea una instancia de la clase Arbitro de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Arbitros();

                return oDatos.GetOneNroDoc(nroDoc);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Retorna todos los árbitros de la base de datos
        /// </summary>
        /// <remarks></remarks>
        public Entidades.Arbitros GetAll()
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Arbitros oDatos;
            try
            {
                //Crea una instancia de la clase Arbitro de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Arbitros();

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
