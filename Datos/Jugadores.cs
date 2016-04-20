using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaARA.Presentación
{
    public class Jugadores
    {
        #region Métodos

        /// <summary>
        /// Agrega un jugador a la base de datos
        /// </summary>
        /// <param name="jugador">Un objeto Jugador de clase Entidades</param>
        /// <returns>Un entero correspondiente al ID del nuevo Jugador agregado</returns>
        public int Add(Entidades.Jugador jugador)
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
                        oCmd.CommandText = "INSERT INTO Jugadores (nroDoc, tipoDoc, nombre, apellido, sexo, direccion, localidad, telefono, telCelular, email, fechaNacimiento, eloLocal, idFide, idInstitucion, baja) VALUES (@nroDoc, @tipoDoc, @nombre, @apellido, @sexo, @direccion, @localidad, @telefono, @telCelular, @email, @fechaNacimiento, @eloLocal, @idFide, @idInstitucion, @baja) SELECT @@identity";

                        //Asignamos los parámetros
                        oCmd.Parameters.Add("@nroDoc", SqlDbType.VarChar, 50).Value = jugador.nroDoc;
                        oCmd.Parameters.Add("@tipoDoc", SqlDbType.VarChar, 50).Value = jugador.tipoDoc;
                        oCmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = jugador.nombre;
                        oCmd.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = jugador.apellido;
                        oCmd.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = jugador.direccion;
                        oCmd.Parameters.Add("@localidad", SqlDbType.VarChar, 50).Value = jugador.localidad;
                        oCmd.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = jugador.telefono;
                        oCmd.Parameters.Add("@telCelular", SqlDbType.VarChar, 50).Value = jugador.telCelular;
                        oCmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = jugador.email;
                        oCmd.Parameters.Add("@fechaNacimiento", SqlDbType.Date, 50).Value = jugador.fechaNacimiento;
                        oCmd.Parameters.Add("@eloLocal", SqlDbType.VarChar, 50).Value = jugador.eloLocal;
                        oCmd.Parameters.Add("@idFide", SqlDbType.VarChar, 50).Value = jugador.idFide;
                        oCmd.Parameters.Add("@sexo", SqlDbType.VarChar, 50).Value = jugador.sexo;
                        oCmd.Parameters.Add("@idInstitucion", SqlDbType.Int).Value = jugador.idInstitucion;
                        oCmd.Parameters.Add("@baja", SqlDbType.Bit).Value = 0;

                        //Ejecutamos el comando y retornamos el id generado
                        return Convert.ToInt32(oCmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al guardar jugador.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Actualiza un jugador de la base de datos
        /// </summary>
        /// <param name="jugador"></param>
        public void Update(Entidades.Jugador jugador)
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
                        oCmd.CommandText = "UPDATE Jugadores SET nroDoc = @nroDoc, tipoDoc = @tipoDoc, nombre = @nombre, apellido = @apellido, sexo = @sexo, direccion = @direccion, localidad = @localidad, telefono = @telefono, telCelular = @telCelular, email = @email, fechaNacimiento = @fechaNacimiento, eloLocal = @eloLocal, idFide = @idFide, idInstitucion = @idInstitucion, baja = @baja WHERE idJugador = @idJugador";

                        //Asignamos los parámetros
                        oCmd.Parameters.Add("@idJugador", SqlDbType.Int).Value = jugador.idJugador;
                        oCmd.Parameters.Add("@nroDoc", SqlDbType.VarChar, 50).Value = jugador.nroDoc;
                        oCmd.Parameters.Add("@tipoDoc", SqlDbType.VarChar, 50).Value = jugador.tipoDoc;
                        oCmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = jugador.nombre;
                        oCmd.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = jugador.apellido;
                        oCmd.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = jugador.direccion;
                        oCmd.Parameters.Add("@localidad", SqlDbType.VarChar, 50).Value = jugador.localidad;
                        oCmd.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = jugador.telefono;
                        oCmd.Parameters.Add("@telCelular", SqlDbType.VarChar, 50).Value = jugador.telCelular;
                        oCmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = jugador.email;
                        oCmd.Parameters.Add("@fechaNacimiento", SqlDbType.Date, 50).Value = jugador.fechaNacimiento;
                        oCmd.Parameters.Add("@eloLocal", SqlDbType.VarChar, 50).Value = jugador.eloLocal;
                        oCmd.Parameters.Add("@idFide", SqlDbType.VarChar, 50).Value = jugador.idFide;
                        oCmd.Parameters.Add("@sexo", SqlDbType.VarChar, 50).Value = jugador.sexo;
                        oCmd.Parameters.Add("@idInstitucion", SqlDbType.Int).Value = jugador.idInstitucion;
                        oCmd.Parameters.Add("@baja", SqlDbType.Bit).Value = jugador.baja;

                        //Ejecutamos el comando 
                        oCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al actualizar datos del jugador.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Elimina un jugador de la base de datos
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
                        //oCmd.CommandText = "DELETE FROM Jugadores WHERE idJugador = @idJugador";
                        oCmd.CommandText = "UPDATE Jugadores SET baja = 1 WHERE idJugador = @idJugador";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@idJugador", SqlDbType.Int).Value = id;

                        //Ejecutamos el comando 
                        oCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar jugador.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Obtiene un jugador en base a un id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Entidades.Jugadores GetOne(int id)
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

                    //Creamos un comando para ontener un jugador de la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "SELECT * FROM Jugadores WHERE idJugador = @idJugador";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@idJugador", SqlDbType.Int).Value = id;

                        //Aunque debemos buscar solo un elemento, siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Jugadores oJugadores = new Entidades.Jugadores();

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
                                    Entidades.Jugador oJugador = new Entidades.Jugador();

                                    oJugador.idJugador = Convert.ToInt32(oReader["idJugador"]);
                                    oJugador.idInstitucion = Convert.ToInt32(oReader["idInstitucion"]);
                                    oJugador.apellido = Convert.ToString(oReader["apellido"]);
                                    oJugador.nombre = Convert.ToString(oReader["nombre"]);
                                    oJugador.direccion = Convert.ToString(oReader["direccion"]);
                                    oJugador.localidad = Convert.ToString(oReader["localidad"]);
                                    oJugador.telefono = Convert.ToString(oReader["telefono"]);
                                    oJugador.telCelular = Convert.ToString(oReader["telCelular"]);
                                    oJugador.email = Convert.ToString(oReader["email"]);
                                    oJugador.nroDoc = Convert.ToString(oReader["nroDoc"]);
                                    oJugador.tipoDoc = Convert.ToString(oReader["tipoDoc"]);
                                    oJugador.fechaNacimiento = Convert.ToDateTime(oReader["fechaNacimiento"]);
                                    oJugador.idFide = Convert.ToString(oReader["idFide"]);
                                    oJugador.eloLocal = Convert.ToString(oReader["eloLocal"]);
                                    oJugador.sexo = Convert.ToString(oReader["sexo"]);
                                    oJugador.baja = Convert.ToInt32(oReader["baja"]);

                                    //Agregamos el objeto a la coleccion de resultados
                                    oJugadores.Add(oJugador);

                                    oJugador = null;
                                }

                                //Retornamos los valores encontrados
                                return oJugadores;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oJugadores = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener datos del jugador.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Obtiene un jugador en base a un número de documento
        /// </summary>
        /// <param name="nroDoc"></param>
        /// <returns></returns>
        public Entidades.Jugadores GetOneNroDoc(string nroDoc)
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

                    //Creamos un comando para ontener un jugador de la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "SELECT * FROM Jugadores WHERE nroDoc = @nroDoc";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@nroDoc", SqlDbType.VarChar).Value = nroDoc;

                        //Aunque debemos buscar solo un elemento, siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Jugadores oJugadores = new Entidades.Jugadores();

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
                                    Entidades.Jugador oJugador = new Entidades.Jugador();

                                    oJugador.idJugador = Convert.ToInt32(oReader["idJugador"]);
                                    oJugador.idInstitucion = Convert.ToInt32(oReader["idInstitucion"]);
                                    oJugador.apellido = Convert.ToString(oReader["apellido"]);
                                    oJugador.nombre = Convert.ToString(oReader["nombre"]);
                                    oJugador.direccion = Convert.ToString(oReader["direccion"]);
                                    oJugador.localidad = Convert.ToString(oReader["localidad"]);
                                    oJugador.telefono = Convert.ToString(oReader["telefono"]);
                                    oJugador.telCelular = Convert.ToString(oReader["telCelular"]);
                                    oJugador.email = Convert.ToString(oReader["email"]);
                                    oJugador.nroDoc = Convert.ToString(oReader["nroDoc"]);
                                    oJugador.tipoDoc = Convert.ToString(oReader["tipoDoc"]);
                                    oJugador.fechaNacimiento = Convert.ToDateTime(oReader["fechaNacimiento"]);
                                    oJugador.idFide = Convert.ToString(oReader["idFide"]);
                                    oJugador.eloLocal = Convert.ToString(oReader["eloLocal"]);
                                    oJugador.sexo = Convert.ToString(oReader["sexo"]);
                                    oJugador.baja = Convert.ToInt32(oReader["baja"]);

                                    //Agregamos el objeto a la coleccion de resultados
                                    oJugadores.Add(oJugador);

                                    oJugador = null;
                                }

                                //Retornamos los valores encontrados
                                return oJugadores;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oJugadores = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener datos del jugador.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Obtiene un jugador en base a un nombre y apellido
        /// </summary>
        /// <param name="apNom"></param>
        /// <returns></returns>
        public Entidades.Jugadores GetOne(string apNom)
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

                    //Creamos un comando para ontener un jugador de la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "SELECT * FROM Jugadores WHERE CONCAT(apellido, ', ', nombre) =  @apNom";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@apNom", SqlDbType.VarChar).Value = apNom;

                        //Aunque debemos buscar solo un elemento, siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Jugadores oJugadores = new Entidades.Jugadores();

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
                                    Entidades.Jugador oJugador = new Entidades.Jugador();

                                    oJugador.idJugador = Convert.ToInt32(oReader["idJugador"]);
                                    oJugador.idInstitucion = Convert.ToInt32(oReader["idInstitucion"]);
                                    oJugador.apellido = Convert.ToString(oReader["apellido"]);
                                    oJugador.nombre = Convert.ToString(oReader["nombre"]);
                                    oJugador.direccion = Convert.ToString(oReader["direccion"]);
                                    oJugador.localidad = Convert.ToString(oReader["localidad"]);
                                    oJugador.telefono = Convert.ToString(oReader["telefono"]);
                                    oJugador.telCelular = Convert.ToString(oReader["telCelular"]);
                                    oJugador.email = Convert.ToString(oReader["email"]);
                                    oJugador.nroDoc = Convert.ToString(oReader["nroDoc"]);
                                    oJugador.tipoDoc = Convert.ToString(oReader["tipoDoc"]);
                                    oJugador.fechaNacimiento = Convert.ToDateTime(oReader["fechaNacimiento"]);
                                    oJugador.idFide = Convert.ToString(oReader["idFide"]);
                                    oJugador.eloLocal = Convert.ToString(oReader["eloLocal"]);
                                    oJugador.sexo = Convert.ToString(oReader["sexo"]);
                                    oJugador.baja = Convert.ToInt32(oReader["baja"]);

                                    //Agregamos el objeto a la coleccion de resultados
                                    oJugadores.Add(oJugador);

                                    oJugador = null;
                                }

                                //Retornamos los valores encontrados
                                return oJugadores;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oJugadores = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener datos del jugador.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Retorna todos los jugadores de la base de datos
        /// </summary>
        /// <returns></returns>
        public Entidades.Jugadores GetAll()
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
                        oCmd.CommandText = "SELECT * FROM Jugadores WHERE baja = 0";

                        //Siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Jugadores oJugadores = new Entidades.Jugadores();

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
                                    Entidades.Jugador oJugador = new Entidades.Jugador();

                                    oJugador.idJugador = Convert.ToInt32(oReader["idJugador"]);
                                    oJugador.idInstitucion = Convert.ToInt32(oReader["idInstitucion"]);
                                    oJugador.apellido = Convert.ToString(oReader["apellido"]);
                                    oJugador.nombre = Convert.ToString(oReader["nombre"]);
                                    oJugador.direccion = Convert.ToString(oReader["direccion"]);
                                    oJugador.localidad = Convert.ToString(oReader["localidad"]);
                                    oJugador.telefono = Convert.ToString(oReader["telefono"]);
                                    oJugador.telCelular = Convert.ToString(oReader["telCelular"]);
                                    oJugador.email = Convert.ToString(oReader["email"]);
                                    oJugador.nroDoc = Convert.ToString(oReader["nroDoc"]);
                                    oJugador.tipoDoc = Convert.ToString(oReader["tipoDoc"]);
                                    oJugador.fechaNacimiento = Convert.ToDateTime(oReader["fechaNacimiento"]);
                                    oJugador.idFide = Convert.ToString(oReader["idFide"]);
                                    oJugador.eloLocal = Convert.ToString(oReader["eloLocal"]);
                                    oJugador.sexo = Convert.ToString(oReader["sexo"]);
                                    oJugador.baja = Convert.ToInt32(oReader["baja"]);

                                    //Agregamos el objeto a la coleccion de resultados
                                    oJugadores.Add(oJugador);

                                    oJugador = null;
                                }

                                //Retornamos los valores encontrados
                                return oJugadores;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oJugadores = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener los datos de los jugadores.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Retorna todos los jugadores de una institución de la base de datos
        /// </summary>
        /// <returns></returns>
        public Entidades.Jugadores GetAll(int id)
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
                        oCmd.CommandText = "SELECT * FROM Jugadores WHERE idInstitucion = @idInstitucion AND baja = 0";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@idInstitucion", SqlDbType.Int).Value = id;

                        //Siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Jugadores oJugadores = new Entidades.Jugadores();

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
                                    Entidades.Jugador oJugador = new Entidades.Jugador();

                                    oJugador.idJugador = Convert.ToInt32(oReader["idJugador"]);
                                    oJugador.idInstitucion = Convert.ToInt32(oReader["idInstitucion"]);
                                    oJugador.apellido = Convert.ToString(oReader["apellido"]);
                                    oJugador.nombre = Convert.ToString(oReader["nombre"]);
                                    oJugador.direccion = Convert.ToString(oReader["direccion"]);
                                    oJugador.localidad = Convert.ToString(oReader["localidad"]);
                                    oJugador.telefono = Convert.ToString(oReader["telefono"]);
                                    oJugador.telCelular = Convert.ToString(oReader["telCelular"]);
                                    oJugador.email = Convert.ToString(oReader["email"]);
                                    oJugador.nroDoc = Convert.ToString(oReader["nroDoc"]);
                                    oJugador.tipoDoc = Convert.ToString(oReader["tipoDoc"]);
                                    oJugador.fechaNacimiento = Convert.ToDateTime(oReader["fechaNacimiento"]);
                                    oJugador.idFide = Convert.ToString(oReader["idFide"]);
                                    oJugador.eloLocal = Convert.ToString(oReader["eloLocal"]);
                                    oJugador.sexo = Convert.ToString(oReader["sexo"]);
                                    oJugador.baja = Convert.ToInt32(oReader["baja"]);

                                    //Agregamos el objeto a la coleccion de resultados
                                    oJugadores.Add(oJugador);

                                    oJugador = null;
                                }

                                //Retornamos los valores encontrados
                                return oJugadores;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oJugadores = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener los datos de los jugadores.", Ex);
                throw ExcepcionManejada;
            }
        }

        #endregion
    }
}
