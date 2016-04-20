using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaARA.Negocio
{
    public class Tipos
    {
        #region Metodos

        /// <summary>
        /// Agrega una categoria a la base de datos
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public int Add(Entidades.Tipo oTipo)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Tipos oDatos;
            try
            {
                //Crea una instancia de la clase Categoria de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Tipos();

                return oDatos.Add(oTipo);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Actualiza una Categoria de la base de datos
        /// </summary>
        /// <param name="categoria"></param>
        /// <remarks></remarks>
        public void Update(Entidades.Tipo oTipo)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Tipos oDatos;
            try
            {
                //Crea una instancia de la clase Categoria de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Tipos();

                oDatos.Update(oTipo);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Elimina una categoria de la base de datos
        /// </summary>
        /// <param name="Id"></param>
        /// <remarks></remarks>
        public void Delete(int id)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Tipos oDatos;
            try
            {
                //Crea una instancia de la clase Categoria de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Tipos();

                oDatos.Delete(id);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Obtiene un categoria en base a un Id
        /// </summary>
        /// <param name="id"></param>
        /// <remarks></remarks>
        public Entidades.Tipos GetOne(int id)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Tipos oDatos;
            try
            {
                //Crea una instancia de la clase Categoria de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Tipos();

                return oDatos.GetOne(id);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// Obtiene un categoria en base a una descripción
        /// </summary>
        /// <param name="descripcion"></param>
        /// <remarks></remarks>
        public Entidades.Tipos GetOne(string descripcion)
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Tipos oDatos;
            try
            {
                //Crea una instancia de la clase Categoria de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Tipos();

                return oDatos.GetOne(descripcion);
            }
            finally
            {
                oDatos = null;
            }
        }

        /// <summary>
        /// retorna todos las Categorias de la base de datos
        /// </summary>
        /// <remarks></remarks>
        public Entidades.Tipos GetAll()
        {
            //Utiliza la capa de datos para la operación
            //Si hay alguna validación extra a realizar este es el momento de hacerla
            Presentación.Tipos oDatos;
            try
            {
                //Crea una instancia de la clase Categoria de la capa de datos para realizar la operación y delegar la tarea
                oDatos = new Presentación.Tipos();

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
