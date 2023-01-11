using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace WeAppCartago
{
    class ClaseFichasMedicasHelper
    {
        #region Variables golbales
        Datos cnGeneral = null;
        FichasMedicas objUsuario = null;
        DataTable tblDatos = null;
        #endregion

        public ClaseFichasMedicasHelper(FichasMedicas parObjUsuario)
        {
            objUsuario = parObjUsuario;
        }

        public ClaseFichasMedicasHelper()
        {

        }

        public DataTable ListarClientes()
        {
            tblDatos = new DataTable();
            try
            {
                cnGeneral = new Datos();

                tblDatos = cnGeneral.RetornaTabla("ListarFichas");

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

                tblDatos = cnGeneral.RetornaTabla(parParameter, "PA_Fichas");
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
                SqlParameter[] parParameter = new SqlParameter[6];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@Cedula";
                parParameter[0].SqlDbType = SqlDbType.VarChar;
                parParameter[0].SqlValue = objUsuario.Cedula;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@GrupoSangre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].SqlValue = objUsuario.GrupoSangre;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@Cirujias";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].SqlValue = objUsuario.Cirujias;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@Padecimientos";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].SqlValue = objUsuario.Padecimientos;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@ProblemasPosturales";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].SqlValue = objUsuario.ProblemasPosturales;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@habitos";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].SqlValue = objUsuario.habitos;

                cnGeneral.EjecutarSP(parParameter, "PA_FichasMedicasInsertar2");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        public void ModificarCliente()
        {
            try
            {
                cnGeneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[6];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@Cedula";
                parParameter[0].SqlDbType = SqlDbType.VarChar;
                parParameter[0].SqlValue = objUsuario.Cedula;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@GrupoSangre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].SqlValue = objUsuario.GrupoSangre;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@Cirujias";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].SqlValue = objUsuario.Cirujias;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@Padecimientos";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].SqlValue = objUsuario.Padecimientos;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@ProblemasPosturales";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].SqlValue = objUsuario.ProblemasPosturales;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@habitos";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].SqlValue = objUsuario.habitos;

                cnGeneral.EjecutarSP(parParameter, "PA_FichasModificar2");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    

    }
}
