using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaARA.Presentación
{
    public class Inscripciones
    {
        #region Métodos

        /// <summary>
        /// Agrega una inscripcion a la base de datos
        /// </summary>
        /// <param name="inscripcion">Un objeto Inscripcion de clase Entidades</param>
        public void Add(Entidades.Inscripcion inscripcion)
        {
            //Creamos la conexión a utilizar.
            //Utilizamos la sentencia Using para asegurarnos de cerrar la conexión y liberar el objeto al salir de esta sección de manera automática            
            SqlConnection oCnn = Presentación.Conexion.CrearConexion();

            try
            {
                using (oCnn)
                {
                    //Abrimos conexion
                    oCnn.Open();

                    //Creamos un comando para realizar el alta de la inscripción en la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "INSERT INTO Inscripciones (idTorneo, idJugador, costoInscripcion) VALUES (@idTorneo, @idJugador,@costoInscripcion)";

                        //Asignamos los parámetros
                        oCmd.Parameters.Add("@idTorneo", SqlDbType.Int).Value = inscripcion.idTorneo;
                        oCmd.Parameters.Add("@idJugador", SqlDbType.Int).Value = inscripcion.idJugador;
                        oCmd.Parameters.Add("@costoInscripcion", SqlDbType.Float).Value = inscripcion.costoInscripcion;

                        //Ejecutamos el comando
                        oCmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al guardar la inscripción.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Actualiza una inscripcion de la base de datos
        /// </summary>
        /// <param name="inscripcion"></param>
        public void Update(Entidades.Inscripcion inscripcion)
        {
            //Creamos la conexión a utilizar.
            //Utilizamos la sentencia Using para asegurarnos de cerrar la conexión y liberar el objeto al salir de esta sección de manera automática            
            SqlConnection oCnn = Presentación.Conexion.CrearConexion();

            try
            {
                using (oCnn)
                {
                    //Abrimos conexion
                    oCnn.Open();

                    //Creamos un comando para realizar la modificación de la inscripción en la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "UPDATE Inscripciones SET costoInscripcion = @costoInscripcion WHERE idJugador = @idJugador AND idTorneo = @idTorneo";

                        //Asignamos los parámetros
                        oCmd.Parameters.Add("@idTorneo", SqlDbType.Int).Value = inscripcion.idTorneo;
                        oCmd.Parameters.Add("@idJugador", SqlDbType.Int).Value = inscripcion.idJugador;
                        oCmd.Parameters.Add("@costoInscripcion", SqlDbType.Float).Value = inscripcion.costoInscripcion;

                        //Ejecutamos el comando 
                        oCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al actualizar datos de la inscripción.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Elimina una inscripción de la base de datos
        /// </summary>
        /// <param name="idJug"></param>
        /// <param name="idTorn"></param>
        public void Delete(int idJugador, int idTorneo)
        {
            //Creamos la conexión a utilizar.
            //Utilizamos la sentencia Using para asegurarnos de cerrar la conexión y liberar el objeto al salir de esta sección de manera automática            
            SqlConnection oCnn = Presentación.Conexion.CrearConexion();

            try
            {
                using (oCnn)
                {
                    //Abrimos conexion
                    oCnn.Open();

                    //Creamos un comando para realizar la baja de la inscripción en la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "DELETE FROM Inscripciones WHERE idTorneo = @idTorneo AND idJugador = @idJugador";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@idJugador", SqlDbType.Int).Value = idJugador;
                        oCmd.Parameters.Add("@idTorneo", SqlDbType.Int).Value = idTorneo;

                        //Ejecutamos el comando 
                        oCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar inscripción.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Obtiene una inscripción
        /// </summary>
        /// <param name="idJug"></param>
        /// <param name="idTorn"></param>
        /// <returns></returns>
        public Entidades.Inscripciones GetOne(int idJugador, int idTorneo)
        {
            //Creamos la conexión a utilizar.
            //Utilizamos la sentencia Using para asegurarnos de cerrar la conexióny liberar el objeto al salir de esta sección de manera automática            
            SqlConnection oCnn = Presentación.Conexion.CrearConexion();

            try
            {
                using (oCnn)
                {
                    //Abrimos conexion
                    oCnn.Open();

                    //Creamos un comando para ontener una inscripción de la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "SELECT * FROM Inscripciones WHERE idJugador = @idJugador AND idTorneo = @idTorneo";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@idJugador", SqlDbType.Int).Value = idJugador;
                        oCmd.Parameters.Add("@idTorneo", SqlDbType.Int).Value = idTorneo;

                        //Aunque debemos buscar solo un elemento, siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Inscripciones oInscripciones = new Entidades.Inscripciones();

                        //No retornamos DataSets, siempre utilizamos objetos para hacernos independientes de la estructura de las tablas en el resto de las capas.
                        //Para esto, leemos con el DataReader y creamos los objetos asociados que se esperan
                        try
                        {
                            //Ejecutamos el comando y retornamos los valores
                            SqlDataReader oReader = oCmd.ExecuteReader();
                            using (oReader)
                            {
                                while (oReader.Read())
                                {
                                    //Si existe algun valor, creamos el objeto y lo almacenamos en la colección
                                    Entidades.Inscripcion oInscripcion = new Entidades.Inscripcion();

                                    oInscripcion.idJugador = Convert.ToInt32(oReader["idJugador"]);
                                    oInscripcion.idTorneo = Convert.ToInt32(oReader["idTorneo"]);
                                    oInscripcion.costoInscripcion = Convert.ToInt64(oReader["costoInscripcion"]);

                                    //Agregamos el objeto a la coleccion de resultados
                                    oInscripciones.Add(oInscripcion);

                                    oInscripcion = null;
                                }

                                //Retornamos los valores encontrados
                                return oInscripciones;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oInscripciones = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener datos de la inscripción.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Retorna todas las inscripciones de un jugador de la base de datos
        /// </summary>
        /// <returns></returns>
        public Entidades.Inscripciones GetAllInscripciones(int idJugador)
        {
            //Creamos la conexión a utilizar.
            //Utilizamos la sentencia Using para asegurarnos de cerrar la conexión y liberar el objeto al salir de esta sección de manera automática            
            SqlConnection oCnn = Presentación.Conexion.CrearConexion();

            try
            {
                using (oCnn)
                {
                    //Abrimos conexion
                    oCnn.Open();

                    //Creamos un comando para obtener todas las inscripciones de un jugador de la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "SELECT * FROM Inscripciones WHERE idJugador = @idJugador";

                        oCmd.Parameters.Add("@idJugador", SqlDbType.Int).Value = idJugador;

                        //Siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Inscripciones oInscripciones = new Entidades.Inscripciones();

                        //No retornamos DataSets, siempre utilizamos objetos para hacernos independientes de la estructura de las tablas en el resto de las capas.
                        //Para esto, leemos con el DataReader y creamos los objetos asociados que se esperan
                        try
                        {
                            //Ejecutamos el comando y retornamos los valores
                            SqlDataReader oReader = oCmd.ExecuteReader();
                            using (oCnn)
                            {
                                while (oReader.Read())
                                {
                                    //Si existe algun valor, creamos el objeto y lo almacenamos en la colección
                                    Entidades.Inscripcion oInscripcion = new Entidades.Inscripcion();

                                    oInscripcion.idJugador = Convert.ToInt32(oReader["idJugador"]);
                                    oInscripcion.idTorneo = Convert.ToInt32(oReader["idTorneo"]);
                                    oInscripcion.costoInscripcion = Convert.ToInt64(oReader["costoInscripcion"]);

                                    //Agregamos el objeto a la coleccion de resultados
                                    oInscripciones.Add(oInscripcion);

                                    oInscripcion = null;
                                }

                                //Retornamos los valores encontrados
                                return oInscripciones;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oInscripciones = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener los datos de las inscripciones.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Retorna todas las inscripciones a un torneo de la base de datos
        /// </summary>
        /// <returns></returns>
        public Entidades.Inscripciones GetAll(int idTorneo)
        {
            //Creamos la conexión a utilizar.
            //Utilizamos la sentencia Using para asegurarnos de cerrar la conexión y liberar el objeto al salir de esta sección de manera automática            
            SqlConnection oCnn = Presentación.Conexion.CrearConexion();

            try
            {
                using (oCnn)
                {
                    //Abrimos conexion
                    oCnn.Open();

                    //Creamos un comando para obtener todas llas inscripciones a un torneo de la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "SELECT * FROM Inscripciones WHERE idTorneo = @idTorneo";

                        oCmd.Parameters.Add("@idTorneo", SqlDbType.Int).Value = idTorneo;

                        //Siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Inscripciones oInscripciones = new Entidades.Inscripciones();

                        //No retornamos DataSets, siempre utilizamos objetos para hacernos independientes de la estructura de las tablas en el resto de las capas.
                        //Para esto, leemos con el DataReader y creamos los objetos asociados que se esperan
                        try
                        {
                            //Ejecutamos el comando y retornamos los valores
                            SqlDataReader oReader = oCmd.ExecuteReader();
                            using (oCnn)
                            {
                                while (oReader.Read())
                                {
                                    //Si existe algun valor, creamos el objeto y lo almacenamos en la colección
                                    Entidades.Inscripcion oInscripcion = new Entidades.Inscripcion();

                                    oInscripcion.idJugador = Convert.ToInt32(oReader["idJugador"]);
                                    oInscripcion.idTorneo = Convert.ToInt32(oReader["idTorneo"]);
                                    oInscripcion.costoInscripcion = Convert.ToInt64(oReader["costoInscripcion"]);

                                    //Agregamos el objeto a la coleccion de resultados
                                    oInscripciones.Add(oInscripcion);

                                    oInscripcion = null;
                                }

                                //Retornamos los valores encontrados
                                return oInscripciones;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oInscripciones = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener los datos de las inscripciones.", Ex);
                throw ExcepcionManejada;
            }
        }

        #endregion
    }
}
