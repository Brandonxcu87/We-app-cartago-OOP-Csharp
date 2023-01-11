using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WeAppCartago
{
    class ClasePesajesHelper
    {

        #region Variables golbales
        Datos cnGeneral = null;
        ClasePesajes objUsuario = null;
        DataTable tblDatos = null;
        #endregion

        public ClasePesajesHelper(ClasePesajes parObjUsuario)
        {
            objUsuario = parObjUsuario;
        }

        public ClasePesajesHelper()
        {

        }
        #region GuardarCliente


        public DataTable ListarClientes()
        {
            tblDatos = new DataTable();
            try
            {
                cnGeneral = new Datos();

                tblDatos = cnGeneral.RetornaTabla("Listar_Pesaje");

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

                tblDatos = cnGeneral.RetornaTabla(parParameter, "PA_Pesaje");
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
                SqlParameter[] parParameter = new SqlParameter[7];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@Cedula";
                parParameter[0].SqlDbType = SqlDbType.VarChar;
                parParameter[0].SqlValue = objUsuario.Cedula;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@peso";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].SqlValue = objUsuario.peso;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@altura";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].SqlValue = objUsuario.altura;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@piernas";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].SqlValue = objUsuario.piernas;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@abdomen";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].SqlValue = objUsuario.abdomen;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@cintura";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].SqlValue = objUsuario.cintura;


                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@brazos";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].SqlValue = objUsuario.brazos;

          

                cnGeneral.EjecutarSP(parParameter, "PA_PesajesInsertar");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

    }
}
