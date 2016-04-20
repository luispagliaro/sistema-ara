using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ComprobarBD();
            Application.Run(new frmPrincipal());
        }

        private static void ComprobarBD()
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Microsoft\\Microsoft SQL Server Local DB\\Instances\\v11.0\\";

            if (!File.Exists(ruta + "SistemaARA.mdf"))
            {
                frmCreacionBD frmCreacionBD = new Presentación.frmCreacionBD();

                frmCreacionBD.Show();

                SistemaARA.Presentación.CrearBD.CrearBaseDatos();

                frmCreacionBD.Close();
            }
        }
    }
}
