using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using BO_SISACO;

namespace BDA_SISACO
{	
	public partial class BDAT_Orden_Acondicionamiento:BDABase
	{
		public Boolean fnInsT_Orden_Acondicionamiento(BOT_Orden_Acondicionamiento poBOT_Orden_Acondicionamiento)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[12];
			par[0] = new SqlParameter("@Codigo_Orden_Acondicionamiento",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Orden_Acondicionamiento.Codigo_Orden_Acondicionamiento);
			par[1] = new SqlParameter("@Codigo_Producto",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Orden_Acondicionamiento.Codigo_Producto);
			par[2] = new SqlParameter("@Codigo_Adicional",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[2],poBOT_Orden_Acondicionamiento.Codigo_Adicional);
			par[3] = new SqlParameter("@Codigo_Devolucion",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[3],poBOT_Orden_Acondicionamiento.Codigo_Devolucion);
			par[4] = new SqlParameter("@Codigo_Registro_Codificacion",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[4],poBOT_Orden_Acondicionamiento.Codigo_Registro_Codificacion);
			par[5] = new SqlParameter("@Codigo_Registro_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[5],poBOT_Orden_Acondicionamiento.Codigo_Registro_Empaque);
			par[6] = new SqlParameter("@Codigo_Registro_Entrega",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[6],poBOT_Orden_Acondicionamiento.Codigo_Registro_Entrega);
			par[7] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[7],poBOT_Orden_Acondicionamiento.Codigo_Control_Inspectivo_Linea_Empaque);
			par[8] = new SqlParameter("@Codigo_Rendimiento_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[8],poBOT_Orden_Acondicionamiento.Codigo_Rendimiento_Empaque);
			par[9] = new SqlParameter("@Codigo_Rendimiento_Reporte_Final",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[9],poBOT_Orden_Acondicionamiento.Codigo_Rendimiento_Reporte_Final);
			par[10] = new SqlParameter("@Observaciones",System.Data.SqlDbType.VarChar,200);
			ValidateAndInsertValue(par[10],poBOT_Orden_Acondicionamiento.Observaciones);
			par[11] = new SqlParameter("@Vigencia",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[11],poBOT_Orden_Acondicionamiento.Vigencia);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsT_Orden_Acondicionamiento", par);
				loTx.Commit();
				
				//
				//
				
			}
			catch (Exception e)
			{
				lbResultado=false;
				loTx.Rollback();
				//throw e;
			}
			finally
			{
				loCn.Close();
				loCn.Dispose();
			}

			return lbResultado;
		}
		public Boolean fnUpdT_Orden_Acondicionamiento(BOT_Orden_Acondicionamiento poBOT_Orden_Acondicionamiento)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[12];
			par[0] = new SqlParameter("@Codigo_Orden_Acondicionamiento",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Orden_Acondicionamiento.Codigo_Orden_Acondicionamiento);
			par[1] = new SqlParameter("@Codigo_Producto",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Orden_Acondicionamiento.Codigo_Producto);
			par[2] = new SqlParameter("@Codigo_Adicional",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[2],poBOT_Orden_Acondicionamiento.Codigo_Adicional);
			par[3] = new SqlParameter("@Codigo_Devolucion",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[3],poBOT_Orden_Acondicionamiento.Codigo_Devolucion);
			par[4] = new SqlParameter("@Codigo_Registro_Codificacion",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[4],poBOT_Orden_Acondicionamiento.Codigo_Registro_Codificacion);
			par[5] = new SqlParameter("@Codigo_Registro_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[5],poBOT_Orden_Acondicionamiento.Codigo_Registro_Empaque);
			par[6] = new SqlParameter("@Codigo_Registro_Entrega",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[6],poBOT_Orden_Acondicionamiento.Codigo_Registro_Entrega);
			par[7] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[7],poBOT_Orden_Acondicionamiento.Codigo_Control_Inspectivo_Linea_Empaque);
			par[8] = new SqlParameter("@Codigo_Rendimiento_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[8],poBOT_Orden_Acondicionamiento.Codigo_Rendimiento_Empaque);
			par[9] = new SqlParameter("@Codigo_Rendimiento_Reporte_Final",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[9],poBOT_Orden_Acondicionamiento.Codigo_Rendimiento_Reporte_Final);
			par[10] = new SqlParameter("@Observaciones",System.Data.SqlDbType.VarChar,200);
			ValidateAndInsertValue(par[10],poBOT_Orden_Acondicionamiento.Observaciones);
			par[11] = new SqlParameter("@Vigencia",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[11],poBOT_Orden_Acondicionamiento.Vigencia);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_UpdT_Orden_Acondicionamiento", par);
				loTx.Commit();
			}
			catch (Exception e)
			{
				lbResultado=false;
				loTx.Rollback();
				//throw e;
			}
			finally
			{
				loCn.Close();
				loCn.Dispose();
			}

			return lbResultado;
		}

        public Boolean fnInsUpdT_Orden_Acondicionamiento(BOT_Orden_Acondicionamiento poBOT_Orden_Acondicionamiento, out string Codigo_Orden_Acondicionamiento)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[12];
			par[0] = new SqlParameter("@Codigo_Orden_Acondicionamiento",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Orden_Acondicionamiento.Codigo_Orden_Acondicionamiento);
            par[0].Direction = ParameterDirection.Output;
			par[1] = new SqlParameter("@Codigo_Producto",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Orden_Acondicionamiento.Codigo_Producto);
			par[2] = new SqlParameter("@Codigo_Adicional",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[2],poBOT_Orden_Acondicionamiento.Codigo_Adicional);
			par[3] = new SqlParameter("@Codigo_Devolucion",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[3],poBOT_Orden_Acondicionamiento.Codigo_Devolucion);
			par[4] = new SqlParameter("@Codigo_Registro_Codificacion",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[4],poBOT_Orden_Acondicionamiento.Codigo_Registro_Codificacion);
			par[5] = new SqlParameter("@Codigo_Registro_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[5],poBOT_Orden_Acondicionamiento.Codigo_Registro_Empaque);
			par[6] = new SqlParameter("@Codigo_Registro_Entrega",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[6],poBOT_Orden_Acondicionamiento.Codigo_Registro_Entrega);
			par[7] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[7],poBOT_Orden_Acondicionamiento.Codigo_Control_Inspectivo_Linea_Empaque);
			par[8] = new SqlParameter("@Codigo_Rendimiento_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[8],poBOT_Orden_Acondicionamiento.Codigo_Rendimiento_Empaque);
			par[9] = new SqlParameter("@Codigo_Rendimiento_Reporte_Final",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[9],poBOT_Orden_Acondicionamiento.Codigo_Rendimiento_Reporte_Final);
			par[10] = new SqlParameter("@Observaciones",System.Data.SqlDbType.VarChar,200);
			ValidateAndInsertValue(par[10],poBOT_Orden_Acondicionamiento.Observaciones);
			par[11] = new SqlParameter("@Vigencia",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[11],poBOT_Orden_Acondicionamiento.Vigencia);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsUpdT_Orden_Acondicionamiento", par);
				loTx.Commit();
                
			}
			catch (Exception e)
			{
				lbResultado=false;
				loTx.Rollback();
				//throw e;
			}
			finally
			{
                Codigo_Orden_Acondicionamiento = par[0].Value.ToString();
				loCn.Close();
				loCn.Dispose();
			}

			return lbResultado;
		}
		public Boolean fnDelT_Orden_Acondicionamiento(String psCodigo_Orden_Acondicionamiento)
		{
			Boolean lbResultado=true;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			SqlParameter[] par = new SqlParameter[1];
			//cambiar aca:
			par[0] = new SqlParameter("@Codigo_Orden_Acondicionamiento",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Orden_Acondicionamiento;
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_DelT_Orden_Acondicionamiento", par);
				loTx.Commit();
			}
			catch (Exception e)
			{
				lbResultado=false;
				loTx.Rollback();
				throw e;
			}
			finally
			{
				loCn.Close();
				loCn.Dispose();
			}

			return lbResultado;
		}

		public List<BOT_Orden_Acondicionamiento> fnSelT_Orden_AcondicionamientoAll()
		{
			List<BOT_Orden_Acondicionamiento> loList = new List<BOT_Orden_Acondicionamiento>();
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Orden_AcondicionamientosAll");
				while (loDr.Read())
                {
					BOT_Orden_Acondicionamiento loBOT_Orden_Acondicionamiento=new BOT_Orden_Acondicionamiento();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Orden_Acondicionamiento"));
					loBOT_Orden_Acondicionamiento.Codigo_Orden_Acondicionamiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Producto"));
					loBOT_Orden_Acondicionamiento.Codigo_Producto = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Adicional"));
					loBOT_Orden_Acondicionamiento.Codigo_Adicional = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Devolucion"));
					loBOT_Orden_Acondicionamiento.Codigo_Devolucion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Codificacion"));
					loBOT_Orden_Acondicionamiento.Codigo_Registro_Codificacion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque"));
					loBOT_Orden_Acondicionamiento.Codigo_Registro_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Entrega"));
					loBOT_Orden_Acondicionamiento.Codigo_Registro_Entrega = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Inspectivo_Linea_Empaque"));
					loBOT_Orden_Acondicionamiento.Codigo_Control_Inspectivo_Linea_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Rendimiento_Empaque"));
					loBOT_Orden_Acondicionamiento.Codigo_Rendimiento_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Rendimiento_Reporte_Final"));
					loBOT_Orden_Acondicionamiento.Codigo_Rendimiento_Reporte_Final = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Observaciones"));
					loBOT_Orden_Acondicionamiento.Observaciones = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Vigencia"));
					loBOT_Orden_Acondicionamiento.Vigencia = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
                    loList.Add(loBOT_Orden_Acondicionamiento);
                }
				loDr.Close();
			}
			catch (Exception e)
			{
				throw e;
			}
			finally
			{
				
			}
			return loList;
		}

		public BOT_Orden_Acondicionamiento fnSelT_Orden_Acondicionamiento(String psCodigo_Orden_Acondicionamiento)
		{
			BOT_Orden_Acondicionamiento loBOT_Orden_Acondicionamiento = new BOT_Orden_Acondicionamiento();
			//parametros
			
			SqlParameter[] par = new SqlParameter[1];
			par[0] = new SqlParameter("@Codigo_Orden_Acondicionamiento",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Orden_Acondicionamiento;
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Orden_Acondicionamiento", par);
				while(loDr.Read()){//----------------------------------------------------- AQUI
					if (loDr != null)
					{
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Orden_Acondicionamiento"));
					loBOT_Orden_Acondicionamiento.Codigo_Orden_Acondicionamiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Producto"));
					loBOT_Orden_Acondicionamiento.Codigo_Producto = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Adicional"));
					loBOT_Orden_Acondicionamiento.Codigo_Adicional = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Devolucion"));
					loBOT_Orden_Acondicionamiento.Codigo_Devolucion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Codificacion"));
					loBOT_Orden_Acondicionamiento.Codigo_Registro_Codificacion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque"));
					loBOT_Orden_Acondicionamiento.Codigo_Registro_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Entrega"));
					loBOT_Orden_Acondicionamiento.Codigo_Registro_Entrega = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Inspectivo_Linea_Empaque"));
					loBOT_Orden_Acondicionamiento.Codigo_Control_Inspectivo_Linea_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Rendimiento_Empaque"));
					loBOT_Orden_Acondicionamiento.Codigo_Rendimiento_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Rendimiento_Reporte_Final"));
					loBOT_Orden_Acondicionamiento.Codigo_Rendimiento_Reporte_Final = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Observaciones"));
					loBOT_Orden_Acondicionamiento.Observaciones = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Vigencia"));
					loBOT_Orden_Acondicionamiento.Vigencia = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
						
					}
				}
				loDr.Close();
			}
			catch (Exception e)
			{
				throw e;
			}
			finally
			{
				
			}
			return loBOT_Orden_Acondicionamiento;
		}
		public List<BOT_Orden_Acondicionamiento> fnSelT_Orden_AcondicionamientoDin(string psWhere,string psOrder)
		{
			List<BOT_Orden_Acondicionamiento> loList = new List<BOT_Orden_Acondicionamiento>();
			SqlParameter[] par = new SqlParameter[2];
			par[0] = new SqlParameter("@WhereCondition",System.Data.SqlDbType.VarChar,500);
			par[0].Value= psWhere;
			par[1] = new SqlParameter("@OrderByExpression",System.Data.SqlDbType.VarChar,250);
			par[1].Value= psOrder;
			object value;//------------------------- 1
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Orden_AcondicionamientosDin",par);
				while (loDr.Read())
                {
					BOT_Orden_Acondicionamiento loBOT_Orden_Acondicionamiento=new BOT_Orden_Acondicionamiento();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Orden_Acondicionamiento"));
					loBOT_Orden_Acondicionamiento.Codigo_Orden_Acondicionamiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Producto"));
					loBOT_Orden_Acondicionamiento.Codigo_Producto = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Adicional"));
					loBOT_Orden_Acondicionamiento.Codigo_Adicional = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Devolucion"));
					loBOT_Orden_Acondicionamiento.Codigo_Devolucion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Codificacion"));
					loBOT_Orden_Acondicionamiento.Codigo_Registro_Codificacion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque"));
					loBOT_Orden_Acondicionamiento.Codigo_Registro_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Entrega"));
					loBOT_Orden_Acondicionamiento.Codigo_Registro_Entrega = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Inspectivo_Linea_Empaque"));
					loBOT_Orden_Acondicionamiento.Codigo_Control_Inspectivo_Linea_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Rendimiento_Empaque"));
					loBOT_Orden_Acondicionamiento.Codigo_Rendimiento_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Rendimiento_Reporte_Final"));
					loBOT_Orden_Acondicionamiento.Codigo_Rendimiento_Reporte_Final = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Observaciones"));
					loBOT_Orden_Acondicionamiento.Observaciones = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Vigencia"));
					loBOT_Orden_Acondicionamiento.Vigencia = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
                    loList.Add(loBOT_Orden_Acondicionamiento);
                }
				loDr.Close();
			}
			catch (Exception e)
			{
				throw e;
			}
			finally
			{
				
			}
			return loList;
		}
		public Int32[] fnSelT_Orden_AcondicionamientoMinMax()
        {
            Int32[] laMinMax=new Int32[2];
            try
			{
                SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Orden_AcondicionamientoMinMax");
                loDr.Read();
                laMinMax[0] = (Int32)loDr.GetValue(loDr.GetOrdinal("Minimo"));
                laMinMax[1] = (Int32)loDr.GetValue(loDr.GetOrdinal("Maximo"));
            }
            catch (Exception e)
			{
				throw e;
			}
			finally
			{
				
			}
            return laMinMax;
        }

        public String fnSelT_OrdenAcondicionamientoCodigo() {
            SqlTransaction loTx;
            SqlConnection loCn = new SqlConnection();
            loCn.ConnectionString = ClassCadena.fnConexion();
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@Codigo_Orden_Acondicionamiento", SqlDbType.VarChar, 10);
            par[0].Direction = ParameterDirection.Output;

            loCn.Open();
            loTx = loCn.BeginTransaction();
            SqlCommand oSqlCommmand;
            try {
                oSqlCommmand = new SqlCommand("usp_SelT_Orden_Acondicionamiento_Codigo", loCn, loTx);
                oSqlCommmand.CommandType = CommandType.StoredProcedure;
                oSqlCommmand.Parameters.Add(par[0]);
                //object[] result = SqlHelper.ExecuteNonQueryReturnValue(ClassCadena.fnConexion(), "usp_SelT_Material_Empaque_Codigo", par);
                //loTx.Commit();
                oSqlCommmand.ExecuteNonQuery();
                string returnValue = oSqlCommmand.Parameters["@Codigo_Orden_Acondicionamiento"].Value.ToString();
                return returnValue;
            }
            catch {
                return string.Empty;
            }
            finally {
                loCn.Close();
                loCn.Dispose();
            }
        }
	}
}

