using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WeAppCartago
{
    class ClaseAdminsHelper
    {

        #region Variables golbales
        Datos cnGeneral = null;
        ClaseAdmins objUsuario = null;
        DataTable tblDatos = null;
        #endregion

        public ClaseAdminsHelper(ClaseAdmins parObjUsuario)
        {
            objUsuario = parObjUsuario;
        }

        public ClaseAdminsHelper()
        {

        }


        public DataTable ListarClientes()
        {
            tblDatos = new DataTable();
            try
            {
                cnGeneral = new Datos();

                tblDatos = cnGeneral.RetornaTabla("Listar_admins");

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

                tblDatos = cnGeneral.RetornaTabla(parParameter, "PA_admins");
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
                SqlParameter[] parParameter = new SqlParameter[3];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@Cedula";
                parParameter[0].SqlDbType = SqlDbType.VarChar;
                parParameter[0].SqlValue = objUsuario.Cedula;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@Usuario";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].SqlValue = objUsuario.Usuario;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@Contraseña";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].SqlValue = objUsuario.Contraseña;





                cnGeneral.EjecutarSP(parParameter, "PA_AdminsInsertar");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion


        public DataTable BuscarContraseña()
        {
            tblDatos = new DataTable();
            try
            {
                cnGeneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@Usuario";
                parParameter[0].SqlDbType = SqlDbType.VarChar;
                parParameter[0].SqlValue = objUsuario.Usuario;

                tblDatos = cnGeneral.RetornaTabla(parParameter, "Sp_BuscarUsuarioPorUser3");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tblDatos;
        }
        public void ModificarCliente()
        {
            try
            {
                cnGeneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[3];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@Cedula";
                parParameter[0].SqlDbType = SqlDbType.VarChar;
                parParameter[0].SqlValue = objUsuario.Cedula;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@Usuario";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].SqlValue = objUsuario.Usuario;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@Contraseña";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].SqlValue = objUsuario.Contraseña;





                cnGeneral.EjecutarSP(parParameter, "PA_AdminsModificar2");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
