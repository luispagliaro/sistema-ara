using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaARA.Presentación
{
    public class Categorias
    {
        #region Métodos

        /// <summary>
        /// Agrega una categoria a la base de datos
        /// </summary>
        /// <param name="categoria">Un objeto Categoria de clase Entidades</param>
        /// <returns>Un entero correspondiente al ID de la nueva Categoria agregada</returns>
        public int Add(Entidades.Categoria categoria)
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
                        oCmd.CommandText = "INSERT INTO Categorias (descripcion) VALUES (@descripcion) SELECT @@identity";

                        //Asignamos los parámetros
                        oCmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = categoria.descripcion;

                        //Ejecutamos el comando y retornamos el id generado
                        return Convert.ToInt32(oCmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al guardar la categoria.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Actualiza una categoria de la base de datos
        /// </summary>
        /// <param name="categoria"></param>
        public void Update(Entidades.Categoria categoria)
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
                        oCmd.CommandText = "UPDATE Categorias SET descripcion = @descripcion WHERE idCategoria = @idCategoria";

                        //Asignamos los parámetros
                        oCmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = categoria.descripcion;
                        oCmd.Parameters.Add("@idCategoria", SqlDbType.Int).Value = categoria.idCategoria;

                        //Ejecutamos el comando 
                        oCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al actualizar datos de la categoria.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Elimina una categoria de la base de datos
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
                        oCmd.CommandText = "DELETE FROM Categorias WHERE idCategoria = @idCategoria";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@idCategoria", SqlDbType.Int).Value = id;

                        //Ejecutamos el comando 
                        oCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar categoria.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Obtiene una categoria en base a un id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Entidades.Categorias GetOne(int id)
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
                        oCmd.CommandText = "SELECT * FROM Categorias WHERE idCategoria = @idCategoria";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@idCategoria", SqlDbType.Int).Value = id;

                        //Aunque debemos buscar solo un elemento, siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Categorias oCategorias = new Entidades.Categorias();

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
                                    Entidades.Categoria oCategoria = new Entidades.Categoria();

                                    oCategoria.idCategoria = Convert.ToInt32(oReader["idCategoria"]);
                                    oCategoria.descripcion = Convert.ToString(oReader["descripcion"]);

                                    //Agregamos el objeto a la coleccion de resultados
                                    oCategorias.Add(oCategoria);

                                    oCategoria = null;
                                }

                                //Retornamos los valores encontrados
                                return oCategorias;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oCategorias = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener datos de la categoria.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Obtiene una categoria en base a un descripcion
        /// </summary>
        /// <param name="descripcion"></param>
        /// <returns></returns>
        public Entidades.Categorias GetOne(string descripcion)
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
                        oCmd.CommandText = "SELECT * FROM Categorias WHERE descripcion = @descripcion";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = descripcion;

                        //Aunque debemos buscar solo un elemento, siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Categorias oCategorias = new Entidades.Categorias();

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
                                    Entidades.Categoria oCategoria = new Entidades.Categoria();

                                    oCategoria.idCategoria = Convert.ToInt32(oReader["idCategoria"]);
                                    oCategoria.descripcion = Convert.ToString(oReader["descripcion"]);

                                    //Agregamos el objeto a la coleccion de resultados
                                    oCategorias.Add(oCategoria);

                                    oCategoria = null;
                                }

                                //Retornamos los valores encontrados
                                return oCategorias;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oCategorias = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener datos de la categoria.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Retorna todas las categorias de la base de datos
        /// </summary>
        /// <returns></returns>
        public Entidades.Categorias GetAll()
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
                        oCmd.CommandText = "SELECT * FROM Categorias";

                        //Siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Categorias oCategorias = new Entidades.Categorias();

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
                                    Entidades.Categoria oCategoria = new Entidades.Categoria();

                                    oCategoria.idCategoria = Convert.ToInt32(oReader["idCategoria"]);
                                    oCategoria.descripcion = Convert.ToString(oReader["descripcion"]);

                                    //Agregamos el objeto a la coleccion de resultados
                                    oCategorias.Add(oCategoria);

                                    oCategoria = null;
                                }

                                //Retornamos los valores encontrados
                                return oCategorias;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oCategorias = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener los datos de las categorias.", Ex);
                throw ExcepcionManejada;
            }
        }

        #endregion
    }
}
