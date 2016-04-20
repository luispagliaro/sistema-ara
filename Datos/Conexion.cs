using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaARA.Presentación
{
    class Conexion
    {
        #region Miembros

        //Clave por defecto a utlizar para la cadena de conexión
        const string consKeyDefaultCnnString = "DefaultCnnString";

        #endregion

        #region Metodos

        /// <summary>
        /// Crea una conexión en base a la cadena de conexión almacenada en el archivo de configuración
        /// </summary>
        /// <returns>Retorna un objeto conexión establecido</returns>
        /// <remarks>Utiliza un valor constante de clave definido en la clase</remarks>
        public static SqlConnection CrearConexion()
        {
            SqlConnection oCnn;
            string connectionString = "";

            try
            {
                //Obtenemos el ConnectionString desde el archivo de configuración
                connectionString = Presentación.ConfigManager.RecuperarValue(consKeyDefaultCnnString);

                //Creamos una conexión
                oCnn = new SqlConnection();

                //Asignamos el connectionString que se recupero del archivo de configuración
                oCnn.ConnectionString = connectionString;

                //Retornamos el objeto conexión creado
                return oCnn;
            }
            finally
            {
                //Eliminamos las referencias a objetos que no utilicemos
                oCnn = null;
            }
        }

        #endregion
    }
}
