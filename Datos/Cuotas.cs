using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaARA.Presentación
{
    public class Cuotas
    {
        #region Métodos

        /// <summary>
        /// Agrega una cuota a la base de datos
        /// </summary>
        /// <param name="cuota">Un objeto Cuota de clase Entidades</param>
        public void Add(Entidades.Cuota cuota)
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

                    //Creamos un comando para realizar el alta de la cuota en la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "INSERT INTO Cuotas (fecha, importe) VALUES (@fecha, @importe)";

                        //Asignamos los parámetros
                        oCmd.Parameters.Add("@fecha", SqlDbType.Date).Value = cuota.fecha;
                        oCmd.Parameters.Add("@importe", SqlDbType.VarChar, 50).Value = cuota.importe;

                        //Ejecutamos el comando
                        oCmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al guardar la cuota.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Actualiza una cuota de la base de datos
        /// </summary>
        /// <param name="cuota"></param>
        public void Update(Entidades.Cuota cuota)
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

                    //Creamos un comando para realizar la modificación de la cuota en la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "UPDATE Cuotas SET importe = @importe WHERE fecha = @fecha";

                        //Asignamos los parámetros
                        oCmd.Parameters.Add("@fecha", SqlDbType.Date).Value = cuota.fecha;
                        oCmd.Parameters.Add("@importe", SqlDbType.VarChar, 50).Value = cuota.importe;

                        //Ejecutamos el comando 
                        oCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al actualizar datos de la cuota.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Elimina una cuota de la base de datos
        /// </summary>
        /// <param name="fecha"></param>
        public void Delete(DateTime fecha)
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

                    //Creamos un comando para realizar la baja de la cuota en la base de datos
                    SqlCommand oCmd = new SqlCommand();
                    using (oCmd)
                    {
                        //Asignamos la conexion de trabajo
                        oCmd.Connection = oCnn;

                        //Indicamos la sentencia SQL
                        oCmd.CommandText = "DELETE FROM Cuotas WHERE fecha = @fecha";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha;

                        //Ejecutamos el comando 
                        oCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar cuota. Compruebe que no esté asociada a ningún pago.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Obtiene una cuota en base a una fecha
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Entidades.Cuotas GetOne(DateTime fecha)
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
                        oCmd.CommandText = "SELECT * FROM Cuotas WHERE fecha = @fecha";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha;

                        //Aunque debemos buscar solo un elemento, siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Cuotas oCuotas = new Entidades.Cuotas();

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
                                    Entidades.Cuota oCuota = new Entidades.Cuota();

                                    oCuota.fecha = Convert.ToDateTime(oReader["fecha"]);
                                    oCuota.importe = Convert.ToString(oReader["importe"]);

                                    //Agregamos el objeto a la coleccion de resultados
                                    oCuotas.Add(oCuota);

                                    oCuota = null;
                                }

                                //Retornamos los valores encontrados
                                return oCuotas;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oCuotas = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener datos de la cuota.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Retorna todas las cuotas de la base de datos
        /// </summary>
        /// <returns></returns>
        public Entidades.Cuotas GetAll()
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
                        oCmd.CommandText = "SELECT * FROM Cuotas";

                        //Siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Cuotas oCuotas = new Entidades.Cuotas();

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
                                    Entidades.Cuota oCuota = new Entidades.Cuota();

                                    oCuota.fecha = Convert.ToDateTime(oReader["fecha"]);
                                    oCuota.importe = Convert.ToString(oReader["importe"]);

                                    //Agregamos el objeto a la coleccion de resultados
                                    oCuotas.Add(oCuota);

                                    oCuota = null;
                                }

                                //Retornamos los valores encontrados
                                return oCuotas;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oCuotas = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener los datos de las cuotas.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Retorna todas las cuotas de la base de datos en base a un año
        /// </summary>
        /// <returns></returns>
        public Entidades.Cuotas GetCuotasAño(string año)
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
                        oCmd.CommandText = "SELECT * FROM Cuotas WHERE YEAR(fecha) = @año";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@año", SqlDbType.VarChar).Value = año;

                        //Siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Cuotas oCuotas = new Entidades.Cuotas();

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
                                    Entidades.Cuota oCuota = new Entidades.Cuota();

                                    oCuota.fecha = Convert.ToDateTime(oReader["fecha"]);
                                    oCuota.importe = Convert.ToString(oReader["importe"]);

                                    //Agregamos el objeto a la coleccion de resultados
                                    oCuotas.Add(oCuota);

                                    oCuota = null;
                                }

                                //Retornamos los valores encontrados
                                return oCuotas;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oCuotas = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener los datos de las cuotas.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Retorna todos las Cuotas de la base de datos a pagar por una institución
        /// </summary>
        /// <param name="idInstitucion"></param>
        /// <returns></returns>
        public Entidades.Cuotas GetCuotasAPagar(int idInstitucion)
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
                        oCmd.CommandText = "SELECT Cuotas.fecha, Cuotas.importe FROM Cuotas INNER JOIN Instituciones ON Instituciones.idInstitucion = @idInstitucion WHERE Cuotas.fecha NOT IN (SELECT fecha FROM Pagos WHERE idInstitucion = @idInstitucion) AND Instituciones.fechaAlta <= Cuotas.fecha";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@idInstitucion", SqlDbType.Int).Value = idInstitucion;

                        //Siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Cuotas oCuotas = new Entidades.Cuotas();

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
                                    Entidades.Cuota oCuota = new Entidades.Cuota();

                                    oCuota.fecha = Convert.ToDateTime(oReader["fecha"]);
                                    oCuota.importe = Convert.ToString(oReader["importe"]);

                                    //Agregamos el objeto a la coleccion de resultados
                                    oCuotas.Add(oCuota);

                                    oCuota = null;
                                }

                                //Retornamos los valores encontrados
                                return oCuotas;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oCuotas = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener los datos de las cuotas.", Ex);
                throw ExcepcionManejada;
            }
        }

        /// <summary>
        /// Retorna todos las Cuotas de la base de datos pagadas por una institución
        /// </summary>
        /// <param name="idInstitucion"></param>
        /// <returns></returns>
        public Entidades.Cuotas GetCuotasPagadas(int idInstitucion)
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
                        oCmd.CommandText = "SELECT Cuotas.fecha, Cuotas.importe, Pagos.fechaPago FROM Cuotas LEFT JOIN Pagos ON Cuotas.fecha = Pagos.fecha INNER JOIN Instituciones ON Instituciones.idInstitucion = @idInstitucion WHERE (Instituciones.idInstitucion = @idInstitucion AND fechaPago IS NOT NULL AND Instituciones.fechaAlta <= Cuotas.fecha)";

                        //Le asignamos el parámetro
                        oCmd.Parameters.Add("@idInstitucion", SqlDbType.Int).Value = idInstitucion;

                        //Siempre devolvemos una colección. Es más fácil de manipular y controlar 
                        Entidades.Cuotas oCuotas = new Entidades.Cuotas();

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
                                    Entidades.Cuota oCuota = new Entidades.Cuota();

                                    oCuota.fecha = Convert.ToDateTime(oReader["fecha"]);
                                    oCuota.importe = Convert.ToString(oReader["importe"]);

                                    //Agregamos el objeto a la coleccion de resultados
                                    oCuotas.Add(oCuota);

                                    oCuota = null;
                                }

                                //Retornamos los valores encontrados
                                return oCuotas;
                            }
                        }
                        finally
                        {
                            //El Finally nos da siempre la oportunidad de liberar la memoria utilizada por los objetos 
                            oCuotas = null;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al obtener los datos de las cuotas.", Ex);
                throw ExcepcionManejada;
            }
        }

        #endregion
    }
}
