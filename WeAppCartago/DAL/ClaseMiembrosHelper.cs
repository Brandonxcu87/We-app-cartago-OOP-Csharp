using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WeAppCartago
{
    class ClaseMiembrosHelper
    {

        #region Variables golbales
        Datos cnGeneral = null;
        ClaseMiembros objUsuario = null;
        DataTable tblDatos = null;
        #endregion

        public ClaseMiembrosHelper(ClaseMiembros parObjUsuario)
        {
            objUsuario = parObjUsuario;
        }

        public ClaseMiembrosHelper()
        {

        }
        #region GuardarCliente

        public DataTable ListarClientes()
        {
            tblDatos = new DataTable();
            try
            {
                cnGeneral = new Datos();

                tblDatos = cnGeneral.RetornaTabla("ListarMiembros");

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

                tblDatos = cnGeneral.RetornaTabla(parParameter, "PA_Clientes");
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
                SqlParameter[] parParameter = new SqlParameter[8];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@Cedula";
                parParameter[0].SqlDbType = SqlDbType.VarChar;
                parParameter[0].SqlValue = objUsuario.Cedula;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@Nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].SqlValue = objUsuario.Nombre;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@AP1";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].SqlValue = objUsuario.AP1;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@AP2";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].SqlValue = objUsuario.AP2;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@edad";
                parParameter[4].SqlDbType = SqlDbType.Int;
                parParameter[4].SqlValue = objUsuario.edad;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@telefono";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].SqlValue = objUsuario.telefono;
     

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@ProximoPago";
                parParameter[6].SqlDbType = SqlDbType.Date;
                parParameter[6].SqlValue = objUsuario.ProximoPago;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@membresia";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].SqlValue = objUsuario.membresia;

                cnGeneral.EjecutarSP(parParameter, "PA_PersonasInsertar");
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
                SqlParameter[] parParameter = new SqlParameter[8];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@Cedula";
                parParameter[0].SqlDbType = SqlDbType.VarChar;
                parParameter[0].SqlValue = objUsuario.Cedula;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@Nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].SqlValue = objUsuario.Nombre;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@AP1";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].SqlValue = objUsuario.AP1;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@AP2";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].SqlValue = objUsuario.AP2;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@edad";
                parParameter[4].SqlDbType = SqlDbType.Int;
                parParameter[4].SqlValue = objUsuario.edad;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@telefono";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].SqlValue = objUsuario.telefono;


                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@ProximoPago";
                parParameter[6].SqlDbType = SqlDbType.Date;
                parParameter[6].SqlValue = objUsuario.ProximoPago;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@membresia";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].SqlValue = objUsuario.membresia;

                cnGeneral.EjecutarSP(parParameter, "PA_PersonasModificar2");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
