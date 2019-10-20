using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Modelo;

namespace Controlador
{
    public class ClsEmpleadoMgr
    {
        Clsdatos cnGeneral = null;
        ClsEmpleado objEmpleado = null;
        DataTable tblDatos = null;
        
        public ClsEmpleadoMgr(ClsEmpleado parObjEmpleado)
        {
            objEmpleado = parObjEmpleado;
        }

        public DataTable Listar()
        {
            tblDatos = new DataTable();

            try
            {
                cnGeneral = new Clsdatos();

                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objEmpleado.opc;

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPEmpleado");

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tblDatos;
        }
        public void Guardar()
        {
            try
            {
                cnGeneral = new Clsdatos();

                SqlParameter[] parParameter = new SqlParameter[6];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objEmpleado.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@Cedula";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = objEmpleado.Cedula;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@Nombre";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = objEmpleado.Nombre;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@Apellido";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = objEmpleado.Apellido;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@FNacimiento";
                parParameter[4].SqlDbType = SqlDbType.DateTime;
                parParameter[4].SqlValue = objEmpleado.FNacimiento;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@Cargo";
                parParameter[5].SqlDbType = SqlDbType.TinyInt;
                parParameter[5].SqlValue = objEmpleado.Cargo;

                cnGeneral.EjecutarSP(parParameter, "SPEmpleado");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void EliminarDatos()
        {
            try
            {
                cnGeneral = new Clsdatos();
                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue=objEmpleado.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@Cedula";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = objEmpleado.Cedula;

                cnGeneral.EjecutarSP(parParameter, "SPEmpleado");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
