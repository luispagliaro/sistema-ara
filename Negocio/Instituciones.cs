using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaARA.Negocio
{
    public class Instituciones
    {
        #region Metodos

        /// <summary>
        /// Agrega una institución a la base de datos
        /// </summary>
        /// <param name="institucion"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public int Add(Entidades.Institucion institucion)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Instituciones oDatos;
            try
            {
                //Crea una instancia de la clase Institucion de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Instituciones();

                return oDatos.Add(institucion);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Actualiza una institución de la base de datos
        /// </summary>
        /// <param name="institucion"></param>
        /// <remarks></remarks>
        public void Update(Entidades.Institucion institucion)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Instituciones oDatos;
            try
            {
                //Crea una instancia de la clase Institucion de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Instituciones();

                oDatos.Update(institucion);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Elimina una institución de la base de datos
        /// </summary>
        /// <param name="Id"></param>
        /// <remarks></remarks>
        public void Delete(int id)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Instituciones oDatos;
            try
            {
                //Crea una instancia de la clase Institucion de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Instituciones();

                oDatos.Delete(id);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Obtiene una institución en base a un Id
        /// </summary>
        /// <param name="id"></param>
        /// <remarks></remarks>
        public Entidades.Instituciones GetOne(int id)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Instituciones oDatos;
            try
            {
                //Crea una instancia de la clase Institucion de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Instituciones();

                return oDatos.GetOne(id);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Obtiene una institución en base a un cuit
        /// </summary>
        /// <param name="cuit"></param>
        /// <remarks></remarks>
        public Entidades.Instituciones GetOne(string cuit)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Instituciones oDatos;
            try
            {
                //Crea una instancia de la clase Institucion de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Instituciones();

                return oDatos.GetOne(cuit);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Obtiene un institución en base a una razón social
        /// </summary>
        /// <param name="cuit"></param>
        /// <remarks></remarks>
        public Entidades.Instituciones GetOneRS(string razonSocial)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Instituciones oDatos;
            try
            {
                //Crea una instancia de la clase Institucion de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Instituciones();

                return oDatos.GetOneRS(razonSocial);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Retorna todos las instituciones de la base de datos que coincidan con los caracteres ingresados en la búsqueda
        /// </summary>
        /// <remarks></remarks>
        public Entidades.Instituciones GetAllBusqueda(string razonSocial)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Instituciones oDatos;
            try
            {
                //Crea una instancia de la clase Institucion de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Instituciones();

                return oDatos.GetAllBusqueda(razonSocial);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Retorna todos las instituciones de la base de datos
        /// </summary>
        /// <remarks></remarks>
        public Entidades.Instituciones GetAll()
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Instituciones oDatos;
            try
            {
                //Crea una instancia de la clase Institucion de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Instituciones();

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
