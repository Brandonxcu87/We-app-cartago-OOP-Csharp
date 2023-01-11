using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WeAppCartago
{
    class ClaseAsistenciaHelper
    {

        #region Variables golbales
        Datos cnGeneral = null;
        ClaseAsistencia objUsuario = null;
        DataTable tblDatos = null;
        #endregion

        public ClaseAsistenciaHelper(ClaseAsistencia parObjUsuario)
        {
            objUsuario = parObjUsuario;
        }

        public ClaseAsistenciaHelper()
        {

        }

        public DataTable ListarAsistencia()
        {
            tblDatos = new DataTable();
            try
            {
                cnGeneral = new Datos();

                tblDatos = cnGeneral.RetornaTabla("ListarAsistencia");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tblDatos;
        }
        public DataTable Buscarcliente()
        {
            tblDatos = new DataTable();
            try
            {
                cnGeneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@Cedula";
                parParameter[0].SqlDbType = SqlDbType.VarChar;
                parParameter[0].SqlValue = objUsuario.Cedula;

                tblDatos = cnGeneral.RetornaTabla(parParameter, "PA_asistencia2");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tblDatos;
        }

            #region GuardarCliente
            public void GuardarCliente()
            {
                try
                {
                    cnGeneral = new Datos();
                    SqlParameter[] parParameter = new SqlParameter[4];

                    parParameter[0] = new SqlParameter();
                    parParameter[0].ParameterName = "@Cedula";
                    parParameter[0].SqlDbType = SqlDbType.VarChar;
                    parParameter[0].SqlValue = objUsuario.Cedula;

                    parParameter[1] = new SqlParameter();
                    parParameter[1].ParameterName = "@Temperatura";
                    parParameter[1].SqlDbType = SqlDbType.VarChar;
                    parParameter[1].SqlValue = objUsuario.Temperatura;

                    parParameter[2] = new SqlParameter();
                    parParameter[2].ParameterName = "@hora";
                    parParameter[2].SqlDbType = SqlDbType.VarChar;
                    parParameter[2].SqlValue = objUsuario.hora;

                    parParameter[3] = new SqlParameter();
                    parParameter[3].ParameterName = "@opcion";
                    parParameter[3].SqlDbType = SqlDbType.VarChar;
                    parParameter[3].SqlValue = objUsuario.opcion;




                    cnGeneral.EjecutarSP(parParameter, "PA_AsistenciaInsertar");
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion

        
    }
}
