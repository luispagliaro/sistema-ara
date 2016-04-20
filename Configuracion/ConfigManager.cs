using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SistemaARA.Presentación
{
    public class ConfigManager
    {
        #region Metodos

        /// <summary>
        /// Obtiene la seccion de configuracion del archivo 
        /// </summary>
        /// <returns>Una configuracion (objeto)</returns>
        private static Configuration RecuperarConfiguracion()
        {
            string path; // Path del archivo de configuracion
            Configuration config;  // Objeto configuracion
            
            // Windows
            path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, AppDomain.CurrentDomain.FriendlyName);
            // Abre configuracion windows
            config = System.Configuration.ConfigurationManager.OpenExeConfiguration(path);

            return config;
        }

        /// <summary>
        /// Lee un valor de la configuracion
        /// </summary>
        /// <param name="Key">Una clave (string)</param>
        /// <returns>Un valor (string)</returns>
        public static string RecuperarValue(string key)
        {
            Configuration config; // Objeto configuracion
            string value;

            try
            {
                // Obtiene configuracion 
                config = RecuperarConfiguracion();

                try
                {
                    // Obtiene valor
                    value = config.AppSettings.Settings[key].Value;
                }
                catch (Exception ex)
                {
                    // Si no existe crea una exception (KeyNotFoundException)
                    throw new Exception(String.Format("Error: la clave '{0}' no existe en el archivo de configuración.", key), ex);
                }
                return value;
            }
            finally
            {
                config = null;
            }
        }

        #endregion
    }
}
