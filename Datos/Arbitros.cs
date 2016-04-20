using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaARA.Presentación
{
    public class Arbitros
    {
        #region Métodos

        /// <summary>
        /// Agrega un árbitro a la base de datos
        /// </summary>
        /// <param name="arbitro">Un objeto Arbitro de clase Entidades</param>
        /// <returns>Un entero correspondiente al ID del nuevo Arbitro agregado</returns>
        public int Add(Entidades.Arbitro arbitro)
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

                    //Creamos un comando para realizar el alta del árbitro en la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "INSERT INTO Arbitros (nroDoc, tipoDoc, nombre, apellido, direccion, localidad, telefono, telCelular, email, fechaNacimiento, idCategoria, baja) VALUES (@nroDoc, @tipoDoc, @nombre, @apellido, @direccion, @localidad, @telefono, @telCelular, @email, @fechaNacimiento, @idCategoria, @baja) SELECT @@identity";

                        //Asignamos los parámetros
                        oCmd.Parameters.Add("@nroDoc", SqlDbType.VarChar, 50).Value = arbitro.nroDoc;
                        oCmd.Parameters.Add("@tipoDoc", SqlDbType.VarChar, 50).Value = arbitro.tipoDoc;
                        oCmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = arbitro.nombre;
                        oCmd.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = arbitro.apellido;
                        oCmd.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = arbitro.direccion;
                        oCmd.Parameters.Add("@localidad", SqlDbType.VarChar, 50).Value = arbitro.localidad;
                        oCmd.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = arbitro.telefono;
                        oCmd.Parameters.Add("@telCelular", SqlDbType.VarChar, 50).Value = arbitro.telCelular;
                        oCmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = arbitro.email;
                        oCmd.Parameters.Add("@fechaNacimiento", SqlDbType.Date, 50).Value = arbitro.fechaNacimiento;
                        oCmd.Parameters.Add("@idCategoria", SqlDbType.Int).Value = arbitro.idCategoria;
                        oCmd.Parameters.Add("@baja", SqlDbType.Int).Value = 0;

                        //Ejecutamos el comando y retornamos el id generado
                        return Convert.ToInt32(oCmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al guardar árbitro.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Actualiza un árbitro de la base de datos
        /// </summary>
        /// <param name="arbitro"></param>
        public void Update(Entidades.Arbitro arbitro)
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

                    //Creamos un comando para realizar la modificación del árbitro en la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "UPDATE Arbitros SET nroDoc = @nroDoc, tipoDoc = @tipoDoc, nombre = @nombre, apellido = @apellido, direccion = @direccion, localidad = @localidad, telefono = @telefono, telCelular = @telCelular, email = @email, fechaNacimiento = @fechaNacimiento, idCategoria = @idCategoria, baja = @baja WHERE idArbitro = @idArbitro";

                        //Asignamos los parámetros
                        oCmd.Parameters.Add("@idArbitro", SqlDbType.Int).Value = arbitro.idArbitro;
                        oCmd.Parameters.Add("@nroDoc", SqlDbType.VarChar, 50).Value = arbitro.nroDoc;
                        oCmd.Parameters.Add("@tipoDoc", SqlDbType.VarChar, 50).Value = arbitro.tipoDoc;
                        oCmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = arbitro.nombre;
                        oCmd.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = arbitro.apellido;
                        oCmd.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = arbitro.direccion;
                        oCmd.Parameters.Add("@localidad", SqlDbType.VarChar, 50).Value = arbitro.localidad;
                        oCmd.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = arbitro.telefono;
                        oCmd.Parameters.Add("@telCelular", SqlDbType.VarChar, 50).Value = arbitro.telCelular;
                        oCmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = arbitro.email;
                        oCmd.Parameters.Add("@fechaNacimiento", SqlDbType.Date, 50).Value = arbitro.fechaNacimiento;
                        oCmd.Parameters.Add("@idCategoria", SqlDbType.Int).Value = arbitro.idCategoria;
                        oCmd.Parameters.Add("@baja", SqlDbType.Bit).Value = arbitro.baja;

                        //Ejecutamos el comando 
                        oCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al actualizar datos del árbitro.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Elimina un árbitro de la base de datos
        /// </summary>
        /// <param name="idArbitro"></param>
        public void Delete(int idArbitro)
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

                    //Creamos un comando para realizar la baja del árbitro en la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        //oCmd.CommandText = "DELETE FROM Arbitros WHERE idArbitro = @idArbitro";
                        oCmd.CommandText = "UPDATE Arbitros SET baja = 1 WHERE idArbitro = @idArbitro";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@idArbitro", SqlDbType.Int).Value = idArbitro;

                        //Ejecutamos el comando 
                        oCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar árbitro.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Obtiene un árbitro en base a un tipoDoc y nroDoc
        /// </summary>
        /// <param name="idArbitro"></param>
        /// <returns></returns>
        public Entidades.Arbitros GetOne(int idArbitro)
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

                    //Creamos un comando para ontener un árbitro de la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "SELECT * FROM Arbitros WHERE idArbitro = @idArbitro";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@idArbitro", SqlDbType.Int).Value = idArbitro;

                        //Aunque debemos buscar solo un elemento, siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Arbitros oArbitros = new Entidades.Arbitros();

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
                                    Entidades.Arbitro oArbitro = new Entidades.Arbitro();

                                    oArbitro.idArbitro = Convert.ToInt32(oReader["idArbitro"]);
                                    oArbitro.idCategoria = Convert.ToInt32(oReader["idCategoria"]);
                                    oArbitro.apellido = Convert.ToString(oReader["apellido"]);
                                    oArbitro.nombre = Convert.ToString(oReader["nombre"]);
                                    oArbitro.direccion = Convert.ToString(oReader["direccion"]);
                                    oArbitro.localidad = Convert.ToString(oReader["localidad"]);
                                    oArbitro.telefono = Convert.ToString(oReader["telefono"]);
                                    oArbitro.telCelular = Convert.ToString(oReader["telCelular"]);
                                    oArbitro.email = Convert.ToString(oReader["email"]);
                                    oArbitro.nroDoc = Convert.ToString(oReader["nroDoc"]);
                                    oArbitro.tipoDoc = Convert.ToString(oReader["tipoDoc"]);
                                    oArbitro.fechaNacimiento = Convert.ToDateTime(oReader["fechaNacimiento"]);
                                    oArbitro.baja = Convert.ToInt32(oReader["baja"]);

                                    //Agregamos el objeto a la coleccion de resultados
                                    oArbitros.Add(oArbitro);

                                    oArbitro = null;
                                }

                                //Retornamos los valores encontrados
                                return oArbitros;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oArbitros = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener datos del árbitro.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Obtiene un árbitro en base a un nombre y apellido
        /// </summary>
        /// <param name="apNom"></param>
        /// <returns></returns>
        public Entidades.Arbitros GetOne(string apNom)
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

                    //Creamos un comando para ontener un árbitro de la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "SELECT * FROM Arbitros WHERE CONCAT(apellido, ', ', nombre) =  @apNom";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@apNom", SqlDbType.VarChar).Value = apNom;

                        //Aunque debemos buscar solo un elemento, siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Arbitros oArbitros = new Entidades.Arbitros();

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
                                    Entidades.Arbitro oArbitro = new Entidades.Arbitro();

                                    oArbitro.idArbitro = Convert.ToInt32(oReader["idArbitro"]);
                                    oArbitro.idCategoria = Convert.ToInt32(oReader["idCategoria"]);
                                    oArbitro.apellido = Convert.ToString(oReader["apellido"]);
                                    oArbitro.nombre = Convert.ToString(oReader["nombre"]);
                                    oArbitro.direccion = Convert.ToString(oReader["direccion"]);
                                    oArbitro.localidad = Convert.ToString(oReader["localidad"]);
                                    oArbitro.telefono = Convert.ToString(oReader["telefono"]);
                                    oArbitro.telCelular = Convert.ToString(oReader["telCelular"]);
                                    oArbitro.email = Convert.ToString(oReader["email"]);
                                    oArbitro.nroDoc = Convert.ToString(oReader["nroDoc"]);
                                    oArbitro.tipoDoc = Convert.ToString(oReader["tipoDoc"]);
                                    oArbitro.fechaNacimiento = Convert.ToDateTime(oReader["fechaNacimiento"]);
                                    oArbitro.baja = Convert.ToInt32(oReader["baja"]);

                                    //Agregamos el objeto a la coleccion de resultados
                                    oArbitros.Add(oArbitro);

                                    oArbitro = null;
                                }

                                //Retornamos los valores encontrados
                                return oArbitros;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oArbitros = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener datos del árbitro.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Obtiene un árbitro en base a un número de documento
        /// </summary>
        /// <param name="nroDoc"></param>
        /// <returns></returns>
        public Entidades.Arbitros GetOneNroDoc(string nroDoc)
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

                    //Creamos un comando para ontener un árbitro de la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "SELECT * FROM Arbitros WHERE nroDoc =  @nroDoc";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@nroDoc", SqlDbType.VarChar).Value = nroDoc;

                        //Aunque debemos buscar solo un elemento, siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Arbitros oArbitros = new Entidades.Arbitros();

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
                                    Entidades.Arbitro oArbitro = new Entidades.Arbitro();

                                    oArbitro.idArbitro = Convert.ToInt32(oReader["idArbitro"]);
                                    oArbitro.idCategoria = Convert.ToInt32(oReader["idCategoria"]);
                                    oArbitro.apellido = Convert.ToString(oReader["apellido"]);
                                    oArbitro.nombre = Convert.ToString(oReader["nombre"]);
                                    oArbitro.direccion = Convert.ToString(oReader["direccion"]);
                                    oArbitro.localidad = Convert.ToString(oReader["localidad"]);
                                    oArbitro.telefono = Convert.ToString(oReader["telefono"]);
                                    oArbitro.telCelular = Convert.ToString(oReader["telCelular"]);
                                    oArbitro.email = Convert.ToString(oReader["email"]);
                                    oArbitro.nroDoc = Convert.ToString(oReader["nroDoc"]);
                                    oArbitro.tipoDoc = Convert.ToString(oReader["tipoDoc"]);
                                    oArbitro.fechaNacimiento = Convert.ToDateTime(oReader["fechaNacimiento"]);
                                    oArbitro.baja = Convert.ToInt32(oReader["baja"]);

                                    //Agregamos el objeto a la coleccion de resultados
                                    oArbitros.Add(oArbitro);

                                    oArbitro = null;
                                }

                                //Retornamos los valores encontrados
                                return oArbitros;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oArbitros = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener datos del árbitro.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Retorna todos los árbitros de la base de datos
        /// </summary>
        /// <returns></returns>
        public Entidades.Arbitros GetAll()
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

                    //Creamos un comando para obtener todos los árbitros de la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "SELECT * FROM Arbitros WHERE baja = 0";

                        //Siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Arbitros oArbitros = new Entidades.Arbitros();

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
                                    Entidades.Arbitro oArbitro = new Entidades.Arbitro();

                                    oArbitro.idArbitro = Convert.ToInt32(oReader["idArbitro"]);
                                    oArbitro.idCategoria = Convert.ToInt32(oReader["idCategoria"]);
                                    oArbitro.apellido = Convert.ToString(oReader["apellido"]);
                                    oArbitro.nombre = Convert.ToString(oReader["nombre"]);
                                    oArbitro.direccion = Convert.ToString(oReader["direccion"]);
                                    oArbitro.localidad = Convert.ToString(oReader["localidad"]);
                                    oArbitro.telefono = Convert.ToString(oReader["telefono"]);
                                    oArbitro.telCelular = Convert.ToString(oReader["telCelular"]);
                                    oArbitro.email = Convert.ToString(oReader["email"]);
                                    oArbitro.nroDoc = Convert.ToString(oReader["nroDoc"]);
                                    oArbitro.tipoDoc = Convert.ToString(oReader["tipoDoc"]);
                                    oArbitro.fechaNacimiento = Convert.ToDateTime(oReader["fechaNacimiento"]);
                                    oArbitro.baja = Convert.ToInt32(oReader["baja"]);

                                    //Agregamos el objeto a la coleccion de resultados
                                    oArbitros.Add(oArbitro);

                                    oArbitro = null;
                                }

                                //Retornamos los valores encontrados
                                return oArbitros;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oArbitros = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener los datos de los árbitros.", Ex);
                throw ExcepcionManejada;
            }
        }

        #endregion
    }
}
