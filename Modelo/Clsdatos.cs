using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Modelo
{
    public class Clsdatos
    {
        #region Declaracion de variables

        SqlConnection cnnConexion = null;
        SqlCommand cmdComando = null;
        SqlDataAdapter daAdaptador = null;
        DataTable Dtt = null;
        string strCadenaConexion = string.Empty;
        #endregion

        #region Constructor
        public Clsdatos()
        {
            strCadenaConexion = @"Data Source=SALA403-16\SQLEXPRESS;Initial Catalog=Empresa;Integrated Security=True";
        }
        #endregion

        #region Metodos a ejecutar

        public void EjecutarSP(SqlParameter[] parParametros, string parSPName)
        {
            try
            {
                cnnConexion = new SqlConnection(strCadenaConexion);

                cmdComando = new SqlCommand();

                cmdComando.Connection = cnnConexion;

                cnnConexion.Open();

                cmdComando.CommandType = CommandType.StoredProcedure;

                cmdComando.CommandText = parSPName;

                cmdComando.Parameters.AddRange(parParametros);

                cmdComando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                cnnConexion.Dispose();
                cmdComando.Dispose();

                throw new Exception(ex.Message);
            }
            finally
            {
                cnnConexion.Dispose();
                cmdComando.Dispose();
            }
        }

            public DataTable RetornaTabla(SqlParameter[] parParametros, string parTSQL)
            {
                Dtt = null;
                try
                {
                    Dtt = new DataTable();

                    cnnConexion = new SqlConnection(strCadenaConexion);
                    cmdComando = new SqlCommand();
                    cmdComando.Connection = cnnConexion;
                    cmdComando.CommandType = CommandType.StoredProcedure;
                    cmdComando.CommandText = parTSQL;
                    cmdComando.Parameters.AddRange(parParametros);
                    daAdaptador = new SqlDataAdapter(cmdComando);
                    daAdaptador.Fill(Dtt);
                }
                catch (Exception ex)
                {
                    cnnConexion.Dispose();
                    cmdComando.Dispose();
                    daAdaptador.Dispose();
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

