using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaARA.Negocio
{
    public class Jugadores
    {
        #region Metodos

        /// <summary>
        /// Agrega un Jugador a la base de datos
        /// </summary>
        /// <param name="jugador"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public int Add(Entidades.Jugador jugador)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Jugadores oDatos;
            try
            {
                //Crea una instancia de la clase Jugador de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Jugadores();

                return oDatos.Add(jugador);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Actualiza un Jugador de la base de datos
        /// </summary>
        /// <param name="jugador"></param>
        /// <remarks></remarks>
        public void Update(Entidades.Jugador jugador)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Jugadores oDatos;
            try
            {
                //Crea una instancia de la clase Jugador de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Jugadores();

                oDatos.Update(jugador);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Elimina una jugador de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <remarks></remarks>
        public void Delete(int id)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Jugadores oDatos;
            try
            {
                //Crea una instancia de la clase Jugador de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Jugadores();

                oDatos.Delete(id);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Obtiene una Jugador en base a un id
        /// </summary>
        /// <param name="apNom"></param>
        /// <remarks></remarks>
        public Entidades.Jugadores GetOne(int id)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Jugadores oDatos;
            try
            {
                //Crea una instancia de la clase Jugador de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Jugadores();

                return oDatos.GetOne(id);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Obtiene una Jugador en base a un nombre y apellido
        /// </summary>
        /// <param name="apNom"></param>
        /// <remarks></remarks>
        public Entidades.Jugadores GetOne(string apNom)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Jugadores oDatos;
            try
            {
                //Crea una instancia de la clase Jugador de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Jugadores();

                return oDatos.GetOne(apNom);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Obtiene una Jugador en base a un nombre y apellido
        /// </summary>
        /// <param name="nroDoc"></param>
        /// <remarks></remarks>
        public Entidades.Jugadores GetOneNroDoc(string nroDoc)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Jugadores oDatos;
            try
            {
                //Crea una instancia de la clase Jugador de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Jugadores();

                return oDatos.GetOneNroDoc(nroDoc);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// retorna todos los Jugadores de la base de datos
        /// </summary>
        /// <remarks></remarks>
        public Entidades.Jugadores GetAll()
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Jugadores oDatos;
            try
            {
                //Crea una instancia de la clase Jugador de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Jugadores();

                return oDatos.GetAll();
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Retorna todos los Jugadores de una institución de la base de datos
        /// </summary>
        /// <remarks></remarks>
        public Entidades.Jugadores GetAll(int idInstitucion)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Jugadores oDatos;
            try
            {
                //Crea una instancia de la clase Jugador de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Jugadores();

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
