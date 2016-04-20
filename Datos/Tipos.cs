using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaARA.Presentación
{
    public class Tipos
    {
        #region Métodos

        /// <summary>
        /// Agrega una categoria de torneo a la base de datos
        /// </summary>
        /// <param name="oTipo">Un objeto Categoria de clase Entidades</param>
        /// <returns>Un entero correspondiente al ID de la nueva Categoria agregada</returns>
        public int Add(Entidades.Tipo oTipo)
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

                    //Creamos un comando para realizar el alta de la categoria en la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "INSERT INTO Tipos (descripcion) VALUES (@descripcion) SELECT @@identity";

                        //Asignamos los parámetros
                        oCmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = oTipo.descripcion;

                        //Ejecutamos el comando y retornamos el id generado
                        return Convert.ToInt32(oCmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al guardar el tipo de torneo.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Actualiza una categoria de torneo de la base de datos
        /// </summary>
        /// <param name="categoria"></param>
        public void Update(Entidades.Tipo oTipo)
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

                    //Creamos un comando para realizar la modificación de la categoria en la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "UPDATE Tipos SET descripcion = @descripcion WHERE idTipo = @idTipo";

                        //Asignamos los parámetros
                        oCmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = oTipo.descripcion;
                        oCmd.Parameters.Add("@idTipo", SqlDbType.Int).Value = oTipo.idTipo;

                        //Ejecutamos el comando 
                        oCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al actualizar datos del tipo de torneo.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Elimina una categoria de torneo de la base de datos
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

                    //Creamos un comando para realizar la baja de la categoria en la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "DELETE FROM Tipos WHERE idTipo = @idTipo";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@idTipo", SqlDbType.Int).Value = id;

                        //Ejecutamos el comando 
                        oCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar el tipo de torneo. Compruebe que no esté asociado a ningún torneo.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Obtiene una categoria en base a un id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Entidades.Tipos GetOne(int id)
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

                    //Creamos un comando para ontener una categoria de la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "SELECT * FROM Tipos WHERE idTipo = @idTipo";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@idTipo", SqlDbType.Int).Value = id;

                        //Aunque debemos buscar solo un elemento, siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Tipos oCategoriasTorneos = new Entidades.Tipos();

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
                                    Entidades.Tipo oCategoriaTorneo = new Entidades.Tipo();

                                    oCategoriaTorneo.idTipo = Convert.ToInt32(oReader["idTipo"]);
                                    oCategoriaTorneo.descripcion = Convert.ToString(oReader["descripcion"]);

                                    //Agregamos el objeto a la coleccion de resultados
                                    oCategoriasTorneos.Add(oCategoriaTorneo);

                                    oCategoriaTorneo = null;
                                }

                                //Retornamos los valores encontrados
                                return oCategoriasTorneos;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oCategoriasTorneos = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener datos del tipo de torneo.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Obtiene una categoria en base a un descripcion
        /// </summary>
        /// <param name="descripcion"></param>
        /// <returns></returns>
        public Entidades.Tipos GetOne(string descripcion)
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

                    //Creamos un comando para ontener una categoria de la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "SELECT * FROM Tipos WHERE descripcion = @descripcion";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = descripcion;

                        //Aunque debemos buscar solo un elemento, siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Tipos oCategoriasTorneos = new Entidades.Tipos();

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
                                    Entidades.Tipo oCategoriaTorneo = new Entidades.Tipo();

                                    oCategoriaTorneo.idTipo = Convert.ToInt32(oReader["idTipo"]);
                                    oCategoriaTorneo.descripcion = Convert.ToString(oReader["descripcion"]);

                                    //Agregamos el objeto a la coleccion de resultados
                                    oCategoriasTorneos.Add(oCategoriaTorneo);

                                    oCategoriaTorneo = null;
                                }

                                //Retornamos los valores encontrados
                                return oCategoriasTorneos;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oCategoriasTorneos = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener datos del tipo de torneo.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Retorna todas las categorias de la base de datos
        /// </summary>
        /// <returns></returns>
        public Entidades.Tipos GetAll()
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

                    //Creamos un comando para obtener todas las categorias de la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "SELECT * FROM Tipos";

                        //Siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Tipos oCategoriasTorneos = new Entidades.Tipos();

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
                                    Entidades.Tipo oCategoriaTorneo = new Entidades.Tipo();

                                    oCategoriaTorneo.idTipo = Convert.ToInt32(oReader["idTipo"]);
                                    oCategoriaTorneo.descripcion = Convert.ToString(oReader["descripcion"]);

                                    //Agregamos el objeto a la coleccion de resultados
                                    oCategoriasTorneos.Add(oCategoriaTorneo);

                                    oCategoriaTorneo = null;
                                }

                                //Retornamos los valores encontrados
                                return oCategoriasTorneos;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oCategoriasTorneos = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener los datos de los tipos de torneo.", Ex);
                throw ExcepcionManejada;
            }
        }

        #endregion
    }
}
