using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using BO_SISACO;

namespace BDA_SISACO
{	
	public partial class BDAT_Registro_Codificacion:BDABase
	{
		public Boolean fnInsT_Registro_Codificacion(BOT_Registro_Codificacion poBOT_Registro_Codificacion,out string codigoRegistroCodificacion)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[5];
			par[0] = new SqlParameter("@Codigo_Registro_Codificacion",System.Data.SqlDbType.VarChar,10);
            par[0].Direction=ParameterDirection.Output;
			ValidateAndInsertValue(par[0],poBOT_Registro_Codificacion.Codigo_Registro_Codificacion);
			par[1] = new SqlParameter("@Codigo_Orden_Acondicionamiento",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Registro_Codificacion.Codigo_Orden_Acondicionamiento);
			par[2] = new SqlParameter("@Codigo_Registro_Codificacion_Despeje_Linea",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[2],poBOT_Registro_Codificacion.Codigo_Registro_Codificacion_Despeje_Linea);
			par[3] = new SqlParameter("@Codigo_Registro_Codificacion_Codificacion_Cajas",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[3],poBOT_Registro_Codificacion.Codigo_Registro_Codificacion_Codificacion_Cajas);
			par[4] = new SqlParameter("@Observaciones",System.Data.SqlDbType.VarChar,200);
			ValidateAndInsertValue(par[4],poBOT_Registro_Codificacion.Observaciones);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsT_Registro_Codificacion", par);
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
                codigoRegistroCodificacion = par[0].Value.ToString();
			}

			return lbResultado;
		}
		public Boolean fnUpdT_Registro_Codificacion(BOT_Registro_Codificacion poBOT_Registro_Codificacion)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[5];
			par[0] = new SqlParameter("@Codigo_Registro_Codificacion",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Registro_Codificacion.Codigo_Registro_Codificacion);
			par[1] = new SqlParameter("@Codigo_Orden_Acondicionamiento",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Registro_Codificacion.Codigo_Orden_Acondicionamiento);
			par[2] = new SqlParameter("@Codigo_Registro_Codificacion_Despeje_Linea",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[2],poBOT_Registro_Codificacion.Codigo_Registro_Codificacion_Despeje_Linea);
			par[3] = new SqlParameter("@Codigo_Registro_Codificacion_Codificacion_Cajas",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[3],poBOT_Registro_Codificacion.Codigo_Registro_Codificacion_Codificacion_Cajas);
			par[4] = new SqlParameter("@Observaciones",System.Data.SqlDbType.VarChar,200);
			ValidateAndInsertValue(par[4],poBOT_Registro_Codificacion.Observaciones);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_UpdT_Registro_Codificacion", par);
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

		public Boolean fnInsUpdT_Registro_Codificacion(BOT_Registro_Codificacion poBOT_Registro_Codificacion)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[5];
			par[0] = new SqlParameter("@Codigo_Registro_Codificacion",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Registro_Codificacion.Codigo_Registro_Codificacion);
			par[1] = new SqlParameter("@Codigo_Orden_Acondicionamiento",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Registro_Codificacion.Codigo_Orden_Acondicionamiento);
			par[2] = new SqlParameter("@Codigo_Registro_Codificacion_Despeje_Linea",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[2],poBOT_Registro_Codificacion.Codigo_Registro_Codificacion_Despeje_Linea);
			par[3] = new SqlParameter("@Codigo_Registro_Codificacion_Codificacion_Cajas",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[3],poBOT_Registro_Codificacion.Codigo_Registro_Codificacion_Codificacion_Cajas);
			par[4] = new SqlParameter("@Observaciones",System.Data.SqlDbType.VarChar,200);
			ValidateAndInsertValue(par[4],poBOT_Registro_Codificacion.Observaciones);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsUpdT_Registro_Codificacion", par);
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
		public Boolean fnDelT_Registro_Codificacion(String psCodigo_Registro_Codificacion)
		{
			Boolean lbResultado=true;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			SqlParameter[] par = new SqlParameter[1];
			//cambiar aca:
			par[0] = new SqlParameter("@Codigo_Registro_Codificacion",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Registro_Codificacion;
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_DelT_Registro_Codificacion", par);
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

		public List<BOT_Registro_Codificacion> fnSelT_Registro_CodificacionAll()
		{
			List<BOT_Registro_Codificacion> loList = new List<BOT_Registro_Codificacion>();
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_CodificacionsAll");
				while (loDr.Read())
                {
					BOT_Registro_Codificacion loBOT_Registro_Codificacion=new BOT_Registro_Codificacion();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Codificacion"));
					loBOT_Registro_Codificacion.Codigo_Registro_Codificacion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Orden_Acondicionamiento"));
					loBOT_Registro_Codificacion.Codigo_Orden_Acondicionamiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Codificacion_Despeje_Linea"));
					loBOT_Registro_Codificacion.Codigo_Registro_Codificacion_Despeje_Linea = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Codificacion_Codificacion_Cajas"));
					loBOT_Registro_Codificacion.Codigo_Registro_Codificacion_Codificacion_Cajas = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Observaciones"));
					loBOT_Registro_Codificacion.Observaciones = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Registro_Codificacion);
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

		public BOT_Registro_Codificacion fnSelT_Registro_Codificacion(String psCodigo_Registro_Codificacion)
		{
			BOT_Registro_Codificacion loBOT_Registro_Codificacion = new BOT_Registro_Codificacion();
			//parametros
			
			SqlParameter[] par = new SqlParameter[1];
			par[0] = new SqlParameter("@Codigo_Registro_Codificacion",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Registro_Codificacion;
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Codificacion", par);
				while(loDr.Read()){//----------------------------------------------------- AQUI
					if (loDr != null)
					{
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Codificacion"));
					loBOT_Registro_Codificacion.Codigo_Registro_Codificacion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Orden_Acondicionamiento"));
					loBOT_Registro_Codificacion.Codigo_Orden_Acondicionamiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Codificacion_Despeje_Linea"));
					loBOT_Registro_Codificacion.Codigo_Registro_Codificacion_Despeje_Linea = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Codificacion_Codificacion_Cajas"));
					loBOT_Registro_Codificacion.Codigo_Registro_Codificacion_Codificacion_Cajas = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Observaciones"));
					loBOT_Registro_Codificacion.Observaciones = value != System.DBNull.Value ? (String)value : default(String);
						
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
			return loBOT_Registro_Codificacion;
		}
		public List<BOT_Registro_Codificacion> fnSelT_Registro_CodificacionDin(string psWhere,string psOrder)
		{
			List<BOT_Registro_Codificacion> loList = new List<BOT_Registro_Codificacion>();
			SqlParameter[] par = new SqlParameter[2];
			par[0] = new SqlParameter("@WhereCondition",System.Data.SqlDbType.VarChar,500);
			par[0].Value= psWhere;
			par[1] = new SqlParameter("@OrderByExpression",System.Data.SqlDbType.VarChar,250);
			par[1].Value= psOrder;
			object value;//------------------------- 1
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_CodificacionsDin",par);
				while (loDr.Read())
                {
					BOT_Registro_Codificacion loBOT_Registro_Codificacion=new BOT_Registro_Codificacion();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Codificacion"));
					loBOT_Registro_Codificacion.Codigo_Registro_Codificacion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Orden_Acondicionamiento"));
					loBOT_Registro_Codificacion.Codigo_Orden_Acondicionamiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Codificacion_Despeje_Linea"));
					loBOT_Registro_Codificacion.Codigo_Registro_Codificacion_Despeje_Linea = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Codificacion_Codificacion_Cajas"));
					loBOT_Registro_Codificacion.Codigo_Registro_Codificacion_Codificacion_Cajas = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Observaciones"));
					loBOT_Registro_Codificacion.Observaciones = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Registro_Codificacion);
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
		public Int32[] fnSelT_Registro_CodificacionMinMax()
        {
            Int32[] laMinMax=new Int32[2];
            try
			{
                SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_CodificacionMinMax");
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
	}
}

