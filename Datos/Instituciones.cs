using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaARA.Presentación
{
    public class Instituciones
    {
        #region Métodos

        /// <summary>
        /// Agrega una institución a la base de datos
        /// </summary>
        /// <param name="institucion">Un objeto Institucion de clase Entidades</param>
        /// <returns>Un entero correspondiente al ID de la nueva Institucion agregada</returns>
        public int Add(Entidades.Institucion institucion)
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

                    //Creamos un comando para realizar el alta de la institución en la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "INSERT INTO Instituciones (cuit, razonSocial, direccion, telefono, telCelular, email, nombreContacto, fechaAlta, localidad, baja) VALUES (@cuit, @razonSocial, @direccion, @telefono, @telCelular, @email, @nombreContacto, @fechaAlta, @localidad, @baja) SELECT @@identity";

                        //Asignamos los parámetros
                        oCmd.Parameters.Add("@cuit", SqlDbType.VarChar, 50).Value = institucion.cuit;
                        oCmd.Parameters.Add("@razonSocial", SqlDbType.VarChar, 100).Value = institucion.razonSocial;
                        oCmd.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = institucion.direccion;
                        oCmd.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = institucion.telefono;
                        oCmd.Parameters.Add("@telCelular", SqlDbType.VarChar, 50).Value = institucion.telCelular;
                        oCmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = institucion.email;
                        oCmd.Parameters.Add("@nombreContacto", SqlDbType.VarChar, 50).Value = institucion.nombreContacto;
                        oCmd.Parameters.Add("@fechaAlta", SqlDbType.Date).Value = DateTime.Today;
                        oCmd.Parameters.Add("@localidad", SqlDbType.VarChar, 50).Value = institucion.localidad;
                        oCmd.Parameters.Add("@baja", SqlDbType.Bit).Value = 0;

                        //Ejecutamos el comando y retornamos el id generado
                        return Convert.ToInt32(oCmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al guardar institución.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Actualiza una institución de la base de datos
        /// </summary>
        /// <param name="institucion"></param>
        public void Update(Entidades.Institucion institucion)
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

                    //Creamos un comando para realizar la modificación de la institución en la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "UPDATE Instituciones SET cuit = @cuit, razonSocial = @razonSocial, direccion = @direccion, telefono = @telefono, telCelular = @telCelular, email = @email, nombreContacto = @nombreContacto, localidad = @localidad, baja = @baja WHERE idInstitucion = @idInstitucion";

                        //Asignamos los parámetros
                        oCmd.Parameters.Add("@idInstitucion", SqlDbType.Int).Value = institucion.idInstitucion;
                        oCmd.Parameters.Add("@cuit", SqlDbType.VarChar, 50).Value = institucion.cuit;
                        oCmd.Parameters.Add("@razonSocial", SqlDbType.VarChar, 100).Value = institucion.razonSocial;
                        oCmd.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = institucion.direccion;
                        oCmd.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = institucion.telefono;
                        oCmd.Parameters.Add("@telCelular", SqlDbType.VarChar, 50).Value = institucion.telCelular;
                        oCmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = institucion.email;
                        oCmd.Parameters.Add("@nombreContacto", SqlDbType.VarChar, 50).Value = institucion.nombreContacto;
                        oCmd.Parameters.Add("@localidad", SqlDbType.VarChar, 50).Value = institucion.localidad;
                        oCmd.Parameters.Add("@baja", SqlDbType.Bit).Value = institucion.baja;

                        //Ejecutamos el comando 
                        oCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al actualizar datos de la institución.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Elimina una institución de la base de datos
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

                    //Creamos un comando para realizar la baja de la institución en la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        //oCmd.CommandText = "DELETE FROM Instituciones WHERE idInstitucion = @idInstitucion";
                        oCmd.CommandText = "UPDATE Instituciones SET baja = 1 WHERE idInstitucion = @idInstitucion";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@idInstitucion", SqlDbType.Int).Value = id;

                        //Ejecutamos el comando 
                        oCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar institución.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Obtiene una institución en base a un id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Entidades.Instituciones GetOne(int id)
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

                    //Creamos un comando para ontener una institución de la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "SELECT * FROM Instituciones WHERE idInstitucion = @idInstitucion";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@idInstitucion", SqlDbType.Int).Value = id;

                        //Aunque debemos buscar solo un elemento, siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Instituciones oInstituciones = new Entidades.Instituciones();

                        //No retornamos DataSets, siempre utilizamos objetos para hacernos independientes de la estructura de las tablas en el resto de las capas.
                        //Para ellos leemos con el DataReader y creamos los objetos asociados que se esperan
                        try
                        {
                            //Ejecutamos el comando y retornamos los valores
                            SqlDataReader oReader = oCmd.ExecuteReader();
                            using (oReader)
                            {
                                while (oReader.Read())
                                {
                                    //Si existe algun valor, creamos el objeto y lo almacenamos en la colección
                                    Entidades.Institucion oInstitucion = new Entidades.Institucion();

                                    oInstitucion.idInstitucion = Convert.ToInt32(oReader["idInstitucion"]);
                                    oInstitucion.cuit = Convert.ToString(oReader["cuit"]);
                                    oInstitucion.razonSocial = Convert.ToString(oReader["razonSocial"]);
                                    oInstitucion.direccion = Convert.ToString(oReader["direccion"]);
                                    oInstitucion.telefono = Convert.ToString(oReader["telefono"]);
                                    oInstitucion.telCelular = Convert.ToString(oReader["telCelular"]);
                                    oInstitucion.email = Convert.ToString(oReader["email"]);
                                    oInstitucion.nombreContacto = Convert.ToString(oReader["nombreContacto"]);
                                    oInstitucion.localidad = Convert.ToString(oReader["localidad"]);
                                    oInstitucion.baja = Convert.ToInt32(oReader["baja"]);

                                    //Agregamos el objeto a la coleccion de resultados
                                    oInstituciones.Add(oInstitucion);

                                    oInstitucion = null;
                                }

                                //Retornamos los valores encontrados
                                return oInstituciones;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oInstituciones = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener datos de la institución.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Obtiene una institución en base a un cuit
        /// </summary>
        /// <param name="cuit"></param>
        /// <returns></returns>
        public Entidades.Instituciones GetOne(string cuit)
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

                    //Creamos un comando para ontener una institución de la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "SELECT * FROM Instituciones WHERE cuit = @cuit";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@cuit", SqlDbType.VarChar).Value = cuit;

                        //Aunque debemos buscar solo un elemento, siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Instituciones oInstituciones = new Entidades.Instituciones();

                        //No retornamos DataSets, siempre utilizamos objetos para hacernos independientes de la estructura de las tablas en el resto de las capas.
                        //Para ellos leemos con el DataReader y creamos los objetos asociados que se esperan
                        try
                        {
                            //Ejecutamos el comando y retornamos los valores
                            SqlDataReader oReader = oCmd.ExecuteReader();
                            using (oReader)
                            {
                                while (oReader.Read())
                                {
                                    //Si existe algun valor, creamos el objeto y lo almacenamos en la colección
                                    Entidades.Institucion oInstitucion = new Entidades.Institucion();

                                    oInstitucion.idInstitucion = Convert.ToInt32(oReader["idInstitucion"]);
                                    oInstitucion.cuit = Convert.ToString(oReader["cuit"]);
                                    oInstitucion.razonSocial = Convert.ToString(oReader["razonSocial"]);
                                    oInstitucion.direccion = Convert.ToString(oReader["direccion"]);
                                    oInstitucion.telefono = Convert.ToString(oReader["telefono"]);
                                    oInstitucion.telCelular = Convert.ToString(oReader["telCelular"]);
                                    oInstitucion.email = Convert.ToString(oReader["email"]);
                                    oInstitucion.nombreContacto = Convert.ToString(oReader["nombreContacto"]);
                                    oInstitucion.localidad = Convert.ToString(oReader["localidad"]);
                                    oInstitucion.baja = Convert.ToInt32(oReader["baja"]);

                                    //Agregamos el objeto a la coleccion de resultados
                                    oInstituciones.Add(oInstitucion);

                                    oInstitucion = null;
                                }

                                //Retornamos los valores encontrados
                                return oInstituciones;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oInstituciones = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener datos de la institución.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Obtiene una institución en base a una razón social
        /// </summary>
        /// <param name="razonSocial"></param>
        /// <returns></returns>
        public Entidades.Instituciones GetOneRS(string razonSocial)
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

                    //Creamos un comando para ontener una institución de la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "SELECT * FROM Instituciones WHERE razonSocial = @razonSocial";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@razonSocial", SqlDbType.VarChar).Value = razonSocial;

                        //Aunque debemos buscar solo un elemento, siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Instituciones oInstituciones = new Entidades.Instituciones();

                        //No retornamos DataSets, siempre utilizamos objetos para hacernos independientes de la estructura de las tablas en el resto de las capas.
                        //Para ellos leemos con el DataReader y creamos los objetos asociados que se esperan
                        try
                        {
                            //Ejecutamos el comando y retornamos los valores
                            SqlDataReader oReader = oCmd.ExecuteReader();
                            using (oReader)
                            {
                                while (oReader.Read())
                                {
                                    //Si existe algun valor, creamos el objeto y lo almacenamos en la colección
                                    Entidades.Institucion oInstitucion = new Entidades.Institucion();

                                    oInstitucion.idInstitucion = Convert.ToInt32(oReader["idInstitucion"]);
                                    oInstitucion.cuit = Convert.ToString(oReader["cuit"]);
                                    oInstitucion.razonSocial = Convert.ToString(oReader["razonSocial"]);
                                    oInstitucion.direccion = Convert.ToString(oReader["direccion"]);
                                    oInstitucion.telefono = Convert.ToString(oReader["telefono"]);
                                    oInstitucion.telCelular = Convert.ToString(oReader["telCelular"]);
                                    oInstitucion.email = Convert.ToString(oReader["email"]);
                                    oInstitucion.nombreContacto = Convert.ToString(oReader["nombreContacto"]);
                                    oInstitucion.localidad = Convert.ToString(oReader["localidad"]);
                                    oInstitucion.baja = Convert.ToInt32(oReader["baja"]);

                                    //Agregamos el objeto a la coleccion de resultados
                                    oInstituciones.Add(oInstitucion);

                                    oInstitucion = null;
                                }

                                //Retornamos los valores encontrados
                                return oInstituciones;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oInstituciones = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener datos de la institución.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Retorna todos las instituciones de la base de datos
        /// </summary>
        /// <returns></returns>
        public Entidades.Instituciones GetAllBusqueda(string razonSocial)
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

                    //Creamos un comando para obtener todas las instituciones de la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "SELECT * FROM Instituciones WHERE razonSocial LIKE concat('%', @razonSocial, '%') AND baja = 0;";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@razonSocial", SqlDbType.VarChar).Value = razonSocial;

                        //Siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Instituciones oInstituciones = new Entidades.Instituciones();

                        //No retornamos DataSets, siempre utilizamos objetos para hacernos independientes de la estructura de las tablas en el resto de las capas.
                        //Para ellos leemos con el DataReader y creamos los objetos asociados que se esperan
                        try
                        {
                            //Ejecutamos el comando y retornamos los valores
                            SqlDataReader oReader = oCmd.ExecuteReader();
                            using (oCnn)
                            {
                                while (oReader.Read())
                                {
                                    //Si existe algun valor, creamos el objeto y lo almacenamos en la colección
                                    Entidades.Institucion oInstitucion = new Entidades.Institucion();

                                    oInstitucion.idInstitucion = Convert.ToInt32(oReader["idInstitucion"]);
                                    oInstitucion.cuit = Convert.ToString(oReader["cuit"]);
                                    oInstitucion.razonSocial = Convert.ToString(oReader["razonSocial"]);
                                    oInstitucion.direccion = Convert.ToString(oReader["direccion"]);
                                    oInstitucion.telefono = Convert.ToString(oReader["telefono"]);
                                    oInstitucion.telCelular = Convert.ToString(oReader["telCelular"]);
                                    oInstitucion.email = Convert.ToString(oReader["email"]);
                                    oInstitucion.nombreContacto = Convert.ToString(oReader["nombreContacto"]);
                                    oInstitucion.localidad = Convert.ToString(oReader["localidad"]);
                                    oInstitucion.baja = Convert.ToInt32(oReader["baja"]);

                                    //Agregamos el objeto a la coleccion de resultados
                                    oInstituciones.Add(oInstitucion);

                                    oInstitucion = null;
                                }

                                //Retornamos los valores encontrados
                                return oInstituciones;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oInstituciones = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener los datos de las instituciones.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Retorna todos las instituciones de la base de datos
        /// </summary>
        /// <returns></returns>
        public Entidades.Instituciones GetAll()
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

                    //Creamos un comando para obtener todas las instituciones de la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "SELECT * FROM Instituciones WHERE baja = 0";

                        //Siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Instituciones oInstituciones = new Entidades.Instituciones();

                        //No retornamos DataSets, siempre utilizamos objetos para hacernos independientes de la estructura de las tablas en el resto de las capas.
                        //Para ellos leemos con el DataReader y creamos los objetos asociados que se esperan
                        try
                        {
                            //Ejecutamos el comando y retornamos los valores
                            SqlDataReader oReader = oCmd.ExecuteReader();
                            using (oCnn)
                            {
                                while (oReader.Read())
                                {
                                    //Si existe algun valor, creamos el objeto y lo almacenamos en la colección
                                    Entidades.Institucion oInstitucion = new Entidades.Institucion();

                                    oInstitucion.idInstitucion = Convert.ToInt32(oReader["idInstitucion"]);
                                    oInstitucion.cuit = Convert.ToString(oReader["cuit"]);
                                    oInstitucion.razonSocial = Convert.ToString(oReader["razonSocial"]);
                                    oInstitucion.direccion = Convert.ToString(oReader["direccion"]);
                                    oInstitucion.telefono = Convert.ToString(oReader["telefono"]);
                                    oInstitucion.telCelular = Convert.ToString(oReader["telCelular"]);
                                    oInstitucion.email = Convert.ToString(oReader["email"]);
                                    oInstitucion.nombreContacto = Convert.ToString(oReader["nombreContacto"]);
                                    oInstitucion.localidad = Convert.ToString(oReader["localidad"]);
                                    oInstitucion.baja = Convert.ToInt32(oReader["baja"]);

                                    //Agregamos el objeto a la coleccion de resultados
                                    oInstituciones.Add(oInstitucion);

                                    oInstitucion = null;
                                }

                                //Retornamos los valores encontrados
                                return oInstituciones;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oInstituciones = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener los datos de las instituciones.", Ex);
                throw ExcepcionManejada;
            }
        }

        #endregion
    }
}