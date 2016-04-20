using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaARA.Presentación
{
    public class CrearBD
    {
        public static void CrearBaseDatos()
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Microsoft\\Microsoft SQL Server Local DB\\Instances\\v11.0\\";

            SqlConnection oCnn = new SqlConnection();
            oCnn.ConnectionString = @"Data Source=(LocalDB)\v11.0;Database=master;Integrated Security=True;";

            try
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C sqllocaldb start v11.0 & sqllocaldb delete v11.0 & sqllocaldb create v11.0";
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();

                string origen = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).ToString() + "\\Asociación Rosarina de Ajedrez\\Sistema de Gestión ARA\\Database\\";

                File.Copy(origen + "SistemaARA.mdf", ruta + "SistemaARA.mdf", false);
                File.Copy(origen + "SistemaARA_log.ldf", ruta + "SistemaARA_log.ldf", false);

                using (oCnn)
                {
                    oCnn.Open();

                    System.Data.SqlClient.SqlCommand oCommand = new System.Data.SqlClient.SqlCommand("if db_id('SistemaARA') is null CREATE DATABASE SistemaARA ON ( FILENAME = '" + @"" + ruta + "SistemaARA.mdf" + "' ), ( FILENAME = '" + @"" + ruta + "SistemaARA_log.ldf" + "' ) FOR ATTACH", oCnn);

                    oCommand.ExecuteScalar();
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al cargar la base de datos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                oCnn.Close();
            }
        }
    }
}
