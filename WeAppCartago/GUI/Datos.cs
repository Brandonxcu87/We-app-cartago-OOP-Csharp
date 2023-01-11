using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WeAppCartago
{
    class Datos
    {
        #region Declaración de Varables
        SqlConnection cnnConexion = null;
        SqlCommand cmdComando = null;
        SqlDataAdapter daAdaptador = null;

        string strCadenaConexion = string.Empty;
        DataTable Dtt = null;
        #endregion

        #region Constructor

        public Datos()
        {
            strCadenaConexion = @"Data Source=DESKTOP-FCB0RC6;Initial Catalog=WeServerCartago;Integrated Security=True";
        }
        #endregion
        #region Metodos a Ejecutar

        #region EjecutarSP
        public void EjecutarSP(SqlParameter[] parParametros, string parSPName)
        {

            try
            {
                //Instanciamos el objeto conexion con la cadena de conexion.
                cnnConexion = new SqlConnection(strCadenaConexion);
                //Instanciar un objeto Comando, que nos sirve para enviar los TSQL(Querys) y la conexion a utilizar
                cmdComando = new SqlCommand();
                cmdComando.Connection = cnnConexion;
                //Abrimos la conexion a BD
                cnnConexion.Open();
                //Asignar el tipo de Comando SQL a ejecutar.
                cmdComando.CommandType = CommandType.StoredProcedure;
                //Agregamos el nombre del StoreProcedure.
                cmdComando.CommandText = parSPName;
                //Agregar lo parametros a ejecutar
                cmdComando.Parameters.AddRange(parParametros);
                //Ejecutar en el servidor el TSQL
                cmdComando.ExecuteNonQuery();

            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cnnConexion.Dispose();
                cmdComando.Dispose();
            }

        }
        #endregion


        public DataTable RetornaTabla(SqlParameter[] parParametros, string parSPName)
        {
            Dtt = null;
            try
            {
                Dtt = new DataTable();
                //Instanciamos el objeto conexion con la cadena de conexion.
                cnnConexion = new SqlConnection(strCadenaConexion);
                //Instanciar un objeto Comando, que nos sirve para enviar los TSQL(Querys) y la conexion a utilizar
                cmdComando = new SqlCommand();
                cmdComando.Connection = cnnConexion;
                //Abrimos la conexion a BD
                cnnConexion.Open();
                //Asignar el tipo de Comando SQL a ejecutar.
                cmdComando.CommandType = CommandType.StoredProcedure;
                //Agregamos el nombre del StoreProcedure.
                cmdComando.CommandText = parSPName;
                //Agregar lo parametros a ejecutar
                cmdComando.Parameters.AddRange(parParametros);
                daAdaptador = new SqlDataAdapter(cmdComando);
                //Utilizando el Adaptador, llene la tabla DTT con los datos.
                daAdaptador.Fill(Dtt);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cnnConexion.Dispose();
                cmdComando.Dispose();

            }
            return Dtt;
        }
        public DataTable RetornaTabla(string parSPName)
        {
            Dtt = null;
            try
            {
                Dtt = new DataTable();
                //Instanciamos el objeto conexion con la cadena de conexion.
                cnnConexion = new SqlConnection(strCadenaConexion);
                //Instanciar un objeto Comando, que nos sirve para enviar los TSQL(Querys) y la conexion a utilizar
                cmdComando = new SqlCommand();
                cmdComando.Connection = cnnConexion;
                //Abrimos la conexion a BD
                cnnConexion.Open();
                //Asignar el tipo de Comando SQL a ejecutar.
                cmdComando.CommandType = CommandType.StoredProcedure;
                //Agregamos el nombre del StoreProcedure.
                cmdComando.CommandText = parSPName;
                //Agregar lo parametros a ejecutar
                daAdaptador = new SqlDataAdapter(cmdComando);
                //Utilizando el Adaptador, llene la tabla DTT con los datos.
                daAdaptador.Fill(Dtt);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cnnConexion.Dispose();
                cmdComando.Dispose();
                daAdaptador.Dispose();
            }
            return Dtt;
        }
        #endregion
    }
}
