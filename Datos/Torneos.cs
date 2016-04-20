using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaARA.Presentación
{
    public class Torneos
    {
        #region Métodos

        /// <summary>
        /// Agrega un torneo a la base de datos
        /// </summary>
        /// <param name="torneo">Un objeto Torneo de clase Entidades</param>
        /// <returns>Un entero correspondiente al ID del nuevo Torneo agregado</returns>
        public int Add(Entidades.Torneo torneo)
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

                    //Creamos un comando para realizar el alta del jugador en la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "INSERT INTO Torneos (nombre, fechaHora, lugar, direccion, idTipo, idArbitro, costoEstandar) VALUES (@nombre, @fechaHora, @lugar, @direccion, @idTipo, @idArbitro, @costoEstandar) SELECT @@identity";

                        //Asignamos los parámetros
                        oCmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = torneo.nombre;
                        oCmd.Parameters.Add("@fechaHora", SqlDbType.DateTime).Value = torneo.fechaHora;
                        oCmd.Parameters.Add("@lugar", SqlDbType.VarChar, 50).Value = torneo.lugar;
                        oCmd.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = torneo.direccion;
                        oCmd.Parameters.Add("@idTipo", SqlDbType.Int).Value = torneo.idTipo;
                        oCmd.Parameters.Add("@idArbitro", SqlDbType.Int).Value = torneo.idArbitro;
                        oCmd.Parameters.Add("@costoEstandar", SqlDbType.Float).Value = torneo.costoEstandar;

                        //Ejecutamos el comando y retornamos el id generado
                        return Convert.ToInt32(oCmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al guardar torneo.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Actualiza un torneo de la base de datos
        /// </summary>
        /// <param name="torneo"></param>
        public void Update(Entidades.Torneo torneo)
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

                    //Creamos un comando para realizar la modificación del jugador en la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "UPDATE Torneos SET nombre = @nombre, fechaHora = @fechaHora, lugar = @lugar, direccion = @direccion, idTipo = @idTipo, idArbitro = @idArbitro, costoEstandar = @costoEstandar WHERE idTorneo = @idTorneo";

                        //Asignamos los parámetros
                        oCmd.Parameters.Add("@idTorneo", SqlDbType.Int).Value = torneo.idTorneo;
                        oCmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = torneo.nombre;
                        oCmd.Parameters.Add("@fechaHora", SqlDbType.DateTime).Value = torneo.fechaHora;
                        oCmd.Parameters.Add("@lugar", SqlDbType.VarChar, 50).Value = torneo.lugar;
                        oCmd.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = torneo.direccion;
                        oCmd.Parameters.Add("@idTipo", SqlDbType.Int).Value = torneo.idTipo;
                        oCmd.Parameters.Add("@idArbitro", SqlDbType.Int).Value = torneo.idArbitro;
                        oCmd.Parameters.Add("@costoEstandar", SqlDbType.Float).Value = torneo.costoEstandar;

                        //Ejecutamos el comando 
                        oCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al actualizar datos del torneo.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Elimina un torneo de la base de datos
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
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

                    //Creamos un comando para realizar la baja del jugador en la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "DELETE FROM Torneos WHERE idTorneo = @idTorneo";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@idTorneo", SqlDbType.Int).Value = id;

                        //Ejecutamos el comando 
                        oCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar torneo.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Obtiene un torneo en base a un id
        /// </summary>
        /// <param name="nom"></param>
        /// <returns></returns>
        public Entidades.Torneos GetOne(int id)
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

                    //Creamos un comando para ontener un torneo de la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "SELECT * FROM Torneos WHERE idTorneo = @idTorneo";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@idTorneo", SqlDbType.Int).Value = id;

                        //Aunque debemos buscar solo un elemento, siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Torneos oTorneos = new Entidades.Torneos();

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
                                    Entidades.Torneo oTorneo = new Entidades.Torneo();

                                    oTorneo.idTorneo = Convert.ToInt32(oReader["idTorneo"]);
                                    oTorneo.fechaHora = Convert.ToDateTime(oReader["fechaHora"]);
                                    oTorneo.nombre = Convert.ToString(oReader["nombre"]);
                                    oTorneo.lugar = Convert.ToString(oReader["lugar"]);
                                    oTorneo.direccion = Convert.ToString(oReader["direccion"]);
                                    oTorneo.idTipo = Convert.ToInt32(oReader["idTipo"]);
                                    oTorneo.idArbitro = Convert.ToInt32(oReader["idArbitro"]);
                                    oTorneo.costoEstandar = Convert.ToInt64(oReader["costoEstandar"]);

                                    //Agregamos el objeto a la coleccion de resultados
                                    oTorneos.Add(oTorneo);

                                    oTorneo = null;
                                }

                                //Retornamos los valores encontrados
                                return oTorneos;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oTorneos = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener datos del torneo.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Obtiene un torneo en base a un nombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public Entidades.Torneos GetOne(string nombre)
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

                    //Creamos un comando para ontener un torneo de la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "SELECT * FROM Jugadores nombre =  @nombre";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;

                        //Aunque debemos buscar solo un elemento, siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Torneos oTorneos = new Entidades.Torneos();

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
                                    Entidades.Torneo oTorneo = new Entidades.Torneo();

                                    oTorneo.idTorneo = Convert.ToInt32(oReader["idTorneo"]);
                                    oTorneo.fechaHora = Convert.ToDateTime(oReader["fechaHora"]);
                                    oTorneo.nombre = Convert.ToString(oReader["nombre"]);
                                    oTorneo.lugar = Convert.ToString(oReader["lugar"]);
                                    oTorneo.direccion = Convert.ToString(oReader["direccion"]);
                                    oTorneo.idTipo = Convert.ToInt32(oReader["idTipo"]);
                                    oTorneo.idArbitro = Convert.ToInt32(oReader["idArbitro"]);
                                    oTorneo.costoEstandar = Convert.ToInt64(oReader["costoEstandar"]);

                                    //Agregamos el objeto a la coleccion de resultados
                                    oTorneos.Add(oTorneo);

                                    oTorneo = null;
                                }

                                //Retornamos los valores encontrados
                                return oTorneos;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oTorneos = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener datos del torneo.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Retorna todos los torneos de un año de la base de datos
        /// </summary>
        /// <returns></returns>
        public Entidades.Torneos GetTorneosAño(string año)
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

                    //Creamos un comando para obtener todos los jugadores de la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "SELECT * FROM Torneos WHERE YEAR(fechaHora) = @año";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@año", SqlDbType.VarChar).Value = año;

                        //Siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Torneos oTorneos = new Entidades.Torneos();

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
                                    Entidades.Torneo oTorneo = new Entidades.Torneo();

                                    oTorneo.idTorneo = Convert.ToInt32(oReader["idTorneo"]);
                                    oTorneo.fechaHora = Convert.ToDateTime(oReader["fechaHora"]);
                                    oTorneo.nombre = Convert.ToString(oReader["nombre"]);
                                    oTorneo.lugar = Convert.ToString(oReader["lugar"]);
                                    oTorneo.direccion = Convert.ToString(oReader["direccion"]);
                                    oTorneo.idTipo = Convert.ToInt32(oReader["idTipo"]);
                                    oTorneo.idArbitro = Convert.ToInt32(oReader["idArbitro"]);
                                    oTorneo.costoEstandar = Convert.ToInt64(oReader["costoEstandar"]);

                                    //Agregamos el objeto a la coleccion de resultados
                                    oTorneos.Add(oTorneo);

                                    oTorneo = null;
                                }

                                //Retornamos los valores encontrados
                                return oTorneos;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oTorneos = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener los datos de los torneos.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Retorna todos los jugadores de la base de datos
        /// </summary>
        /// <returns></returns>
        public Entidades.Torneos GetAll()
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

                    //Creamos un comando para obtener todos los jugadores de la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "SELECT * FROM Torneos";

                        //Siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Torneos oTorneos = new Entidades.Torneos();

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
                                    Entidades.Torneo oTorneo = new Entidades.Torneo();

                                    oTorneo.idTorneo = Convert.ToInt32(oReader["idTorneo"]);
                                    oTorneo.fechaHora = Convert.ToDateTime(oReader["fechaHora"]);
                                    oTorneo.nombre = Convert.ToString(oReader["nombre"]);
                                    oTorneo.lugar = Convert.ToString(oReader["lugar"]);
                                    oTorneo.direccion = Convert.ToString(oReader["direccion"]);
                                    oTorneo.idTipo = Convert.ToInt32(oReader["idTipo"]);
                                    oTorneo.idArbitro = Convert.ToInt32(oReader["idArbitro"]);
                                    oTorneo.costoEstandar = Convert.ToInt64(oReader["costoEstandar"]);

                                    //Agregamos el objeto a la coleccion de resultados
                                    oTorneos.Add(oTorneo);

                                    oTorneo = null;
                                }

                                //Retornamos los valores encontrados
                                return oTorneos;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oTorneos = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener los datos de los torneos.", Ex);
                throw ExcepcionManejada;
            }
        }

        #endregion
    }
}
