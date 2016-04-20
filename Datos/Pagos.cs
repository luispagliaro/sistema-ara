using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaARA.Presentación
{
    public class Pagos
    {
        #region Métodos

        /// <summary>
        /// Agrega un pago a la base de datos
        /// </summary>
        /// <param name="pago">Un objeto Pago de clase Entidades</param>
        /// <returns>Un entero correspondiente al ID del nuevo Pago agregado</returns>
        public int Add(Entidades.Pago pago)
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
                        oCmd.CommandText = "INSERT INTO Pagos (idInstitucion, fecha, fechaPago) VALUES (@idInstitucion, @fecha, @fechaPago)";

                        //Asignamos los parámetros
                        oCmd.Parameters.Add("@idInstitucion", SqlDbType.Int).Value = pago.idInstitucion;
                        oCmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = pago.fecha;
                        oCmd.Parameters.Add("@fechaPago", SqlDbType.DateTime).Value = pago.fechaPago;
                        

                        //Ejecutamos el comando y retornamos el id generado
                        return Convert.ToInt32(oCmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al guardar pago.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Actualiza un pago de la base de datos
        /// </summary>
        /// <param name="pago"></param>
        public void Update(Entidades.Pago pago)
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
                        oCmd.CommandText = "UPDATE Pagos SET fechaPago = @fechaPago WHERE idInstitucion = @idInstitucion AND fecha=@fecha";

                        //Asignamos los parámetros
                        oCmd.Parameters.Add("@idInstitucion", SqlDbType.Int).Value = pago.idInstitucion;
                        oCmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = pago.fecha;
                        oCmd.Parameters.Add("@fechaPago", SqlDbType.DateTime).Value = pago.fechaPago;

                        //Ejecutamos el comando 
                        oCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al actualizar datos del pago.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Elimina una institución de la base de datos
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int idInstitucion, DateTime fecha)
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
                        oCmd.CommandText = "DELETE FROM Pagos WHERE idInstitucion = @idInstitucion AND fecha=@fecha";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@idInstitucion", SqlDbType.Int).Value = idInstitucion;
                        oCmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = fecha;
                        //Ejecutamos el comando 
                        oCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar pago.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Obtiene un pago en base una idInstitucion y fecha
        /// </summary>
        /// <param name="idInstitucion y fecha"></param>
        /// <returns></returns>
        public Entidades.Pagos GetOne(int idInstitucion, DateTime fecha)
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

                    //Creamos un comando para obtener un pago de la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "SELECT * FROM Pagos WHERE idInstitucion = @idInstitucion AND fecha = @fecha";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@idInstitucion", SqlDbType.Int).Value = idInstitucion;
                        oCmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = fecha;
                       

                        //Aunque debemos buscar solo un elemento, siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Pagos oPagos = new Entidades.Pagos();

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
                                    Entidades.Pago oPago = new Entidades.Pago();

                                    oPago.idInstitucion = Convert.ToInt32(oReader["idInstitucion"]);
                                    oPago.fecha = Convert.ToDateTime(oReader["fecha"]);
                                    oPago.fechaPago = Convert.ToDateTime(oReader["fechaPago"]);
                                   

                                    //Agregamos el objeto a la coleccion de resultados
                                    oPagos.Add(oPago);

                                    oPago = null;
                                }

                                //Retornamos los valores encontrados
                                return oPagos;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oPagos = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener datos del pago.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Obtiene un pago en base una fecha
        /// </summary>
        /// <param name="idInstitucion y fecha"></param>
        /// <returns></returns>
        public Entidades.Pagos GetOne(DateTime fecha)
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

                    //Creamos un comando para obtener un pago de la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "SELECT * FROM Pagos WHERE fecha = @fecha";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = fecha;

                        //Aunque debemos buscar solo un elemento, siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Pagos oPagos = new Entidades.Pagos();

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
                                    Entidades.Pago oPago = new Entidades.Pago();

                                    oPago.idInstitucion = Convert.ToInt32(oReader["idInstitucion"]);
                                    oPago.fecha = Convert.ToDateTime(oReader["fecha"]);
                                    oPago.fechaPago = Convert.ToDateTime(oReader["fechaPago"]);


                                    //Agregamos el objeto a la coleccion de resultados
                                    oPagos.Add(oPago);

                                    oPago = null;
                                }

                                //Retornamos los valores encontrados
                                return oPagos;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oPagos = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener datos del pago.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Retorna todos los pagos de la base de datos basados en una idInstitucion
        /// </summary>
        /// <returns></returns>
        public Entidades.Pagos GetAll(int idInstitucion)
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
                        oCmd.CommandText = "SELECT * FROM Pagos WHERE idInstitucion=@idInstitucion";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@idInstitucion", SqlDbType.Int).Value = idInstitucion;

                        //Siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Pagos oPagos = new Entidades.Pagos();

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
                                    Entidades.Pago oPago = new Entidades.Pago();

                                    oPago.idInstitucion = Convert.ToInt32(oReader["idInstitucion"]);
                                    oPago.fecha = Convert.ToDateTime(oReader["fecha"]);
                                    oPago.fechaPago = Convert.ToDateTime(oReader["fechaPago"]);

                                    //Agregamos el objeto a la coleccion de resultados
                                    oPagos.Add(oPago);

                                    oPago = null;
                                }

                                //Retornamos los valores encontrados
                                return oPagos;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oPagos = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener los datos del pagos.", Ex);
                throw ExcepcionManejada;
            }
        }

        #endregion
    }
}