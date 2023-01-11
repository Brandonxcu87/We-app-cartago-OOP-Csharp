using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WeAppCartago
{
    class ClaseEmergenciaHelper
    {

        #region Variables golbales
        Datos cnGeneral = null;
        ClaseEmergencia objUsuario = null;
        DataTable tblDatos = null;
        #endregion

        public ClaseEmergenciaHelper(ClaseEmergencia parObjUsuario)
        {
            objUsuario = parObjUsuario;
        }

        public ClaseEmergenciaHelper()
        {

        }
       

        public DataTable ListarClientes()
        {
            tblDatos = new DataTable();
            try
            {
                cnGeneral = new Datos();

                tblDatos = cnGeneral.RetornaTabla("Listar_Emergencia");

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

                tblDatos = cnGeneral.RetornaTabla(parParameter, "PA_Emergencia");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tblDatos;
        }

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
                parParameter[1].ParameterName = "@Nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].SqlValue = objUsuario.Nombre;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@Parentesco";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].SqlValue = objUsuario.Parentesco;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@telefono";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].SqlValue = objUsuario.telefono;


    

                cnGeneral.EjecutarSP(parParameter, "PA_EmergenciaInsertar");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
     

        public void ModificarCliente()
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
                parParameter[1].ParameterName = "@Nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].SqlValue = objUsuario.Nombre;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@Parentesco";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].SqlValue = objUsuario.Parentesco;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@telefono";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].SqlValue = objUsuario.telefono;




                cnGeneral.EjecutarSP(parParameter, "PA_EmergenciaModificar2");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
