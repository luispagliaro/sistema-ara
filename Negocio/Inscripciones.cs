using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaARA.Negocio
{
    public class Inscripciones
    {
        #region Metodos

        /// <summary>
        /// Agrega una Inscripcion a la base de datos
        /// </summary>
        /// <param name="inscripcion"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public void Add(Entidades.Inscripcion inscripcion)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Inscripciones oDatos;
            try
            {
                //Crea una instancia de la clase Inscripcion de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Inscripciones();

                oDatos.Add(inscripcion);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Actualiza una Inscripcion de la base de datos
        /// </summary>
        /// <param name="inscripcion"></param>
        /// <remarks></remarks>
        public void Update(Entidades.Inscripcion inscripcion)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Inscripciones oDatos;
            try
            {
                //Crea una instancia de la clase Inscripcion de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Inscripciones();

                oDatos.Update(inscripcion);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Elimina una inscripción de la base de datos
        /// </summary>
        /// <param name="idJugador, idTorneo"></param>
        /// <remarks></remarks>
        public void Delete(int idJugador, int idTorneo)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Inscripciones oDatos;
            try
            {
                //Crea una instancia de la clase Inscripcion de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Inscripciones();

                oDatos.Delete(idJugador, idTorneo);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Obtiene una Inscripcion en base a un idJugador, idTorneo
        /// </summary>
        /// <param name="idJugador, idTorneo"></param>
        /// <remarks></remarks>
        public Entidades.Inscripciones GetOne(int idJugador, int idTorneo)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Inscripciones oDatos;
            try
            {
                //Crea una instancia de la clase Inscripcion de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Inscripciones();

                return oDatos.GetOne(idJugador, idTorneo);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Retorna todos las Inscripciones de la base de datos en base a un jugador
        /// </summary>
        /// <remarks></remarks>
        public Entidades.Inscripciones GetAllInscripciones(int idJugador)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Inscripciones oDatos;
            try
            {
                //Crea una instancia de la clase Inscripcion de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Inscripciones();

                return oDatos.GetAllInscripciones(idJugador);
            }
            finally
            {
                oDatos = null;
            }
        
        }

        /// <summary>
        /// Retorna todos las Inscripciones de la base de datos en base a un torneo
        /// </summary>
        /// <remarks></remarks>
        public Entidades.Inscripciones GetAll(int idTorneo)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Inscripciones oDatos;
            try
            {
                //Crea una instancia de la clase Inscripcion de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Inscripciones();

                return oDatos.GetAll(idTorneo);
            }
            finally
            {
                oDatos = null;
            }
        }

        #endregion
    }
}
