using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using BO_SISACO;

namespace BDA_SISACO
{	
	public partial class BDAT_Control_Inspectivo_Linea_Empaque_Otros:BDABase
	{
		public Boolean fnInsT_Control_Inspectivo_Linea_Empaque_Otros(BOT_Control_Inspectivo_Linea_Empaque_Otros poBOT_Control_Inspectivo_Linea_Empaque_Otros)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[3];
			par[0] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque_Otros",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Control_Inspectivo_Linea_Empaque_Otros.Codigo_Control_Inspectivo_Linea_Empaque_Otros);
			par[1] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Emapaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Control_Inspectivo_Linea_Empaque_Otros.Codigo_Control_Inspectivo_Linea_Emapaque);
			par[2] = new SqlParameter("@Inserto",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[2],poBOT_Control_Inspectivo_Linea_Empaque_Otros.Inserto);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsT_Control_Inspectivo_Linea_Empaque_Otros", par);
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
		public Boolean fnUpdT_Control_Inspectivo_Linea_Empaque_Otros(BOT_Control_Inspectivo_Linea_Empaque_Otros poBOT_Control_Inspectivo_Linea_Empaque_Otros)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[3];
			par[0] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque_Otros",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Control_Inspectivo_Linea_Empaque_Otros.Codigo_Control_Inspectivo_Linea_Empaque_Otros);
			par[1] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Emapaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Control_Inspectivo_Linea_Empaque_Otros.Codigo_Control_Inspectivo_Linea_Emapaque);
			par[2] = new SqlParameter("@Inserto",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[2],poBOT_Control_Inspectivo_Linea_Empaque_Otros.Inserto);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_UpdT_Control_Inspectivo_Linea_Empaque_Otros", par);
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

		public Boolean fnInsUpdT_Control_Inspectivo_Linea_Empaque_Otros(BOT_Control_Inspectivo_Linea_Empaque_Otros poBOT_Control_Inspectivo_Linea_Empaque_Otros)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[3];
			par[0] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque_Otros",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Control_Inspectivo_Linea_Empaque_Otros.Codigo_Control_Inspectivo_Linea_Empaque_Otros);
			par[1] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Emapaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Control_Inspectivo_Linea_Empaque_Otros.Codigo_Control_Inspectivo_Linea_Emapaque);
			par[2] = new SqlParameter("@Inserto",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[2],poBOT_Control_Inspectivo_Linea_Empaque_Otros.Inserto);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsUpdT_Control_Inspectivo_Linea_Empaque_Otros", par);
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
		public Boolean fnDelT_Control_Inspectivo_Linea_Empaque_Otros(String psCodigo_Control_Inspectivo_Linea_Empaque_Otros)
		{
			Boolean lbResultado=true;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			SqlParameter[] par = new SqlParameter[1];
			//cambiar aca:
			par[0] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque_Otros",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Control_Inspectivo_Linea_Empaque_Otros;
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_DelT_Control_Inspectivo_Linea_Empaque_Otros", par);
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

		public List<BOT_Control_Inspectivo_Linea_Empaque_Otros> fnSelT_Control_Inspectivo_Linea_Empaque_OtrosAll()
		{
			List<BOT_Control_Inspectivo_Linea_Empaque_Otros> loList = new List<BOT_Control_Inspectivo_Linea_Empaque_Otros>();
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Control_Inspectivo_Linea_Empaque_OtrossAll");
				while (loDr.Read())
                {
					BOT_Control_Inspectivo_Linea_Empaque_Otros loBOT_Control_Inspectivo_Linea_Empaque_Otros=new BOT_Control_Inspectivo_Linea_Empaque_Otros();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Inspectivo_Linea_Empaque_Otros"));
					loBOT_Control_Inspectivo_Linea_Empaque_Otros.Codigo_Control_Inspectivo_Linea_Empaque_Otros = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Inspectivo_Linea_Emapaque"));
					loBOT_Control_Inspectivo_Linea_Empaque_Otros.Codigo_Control_Inspectivo_Linea_Emapaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Inserto"));
					loBOT_Control_Inspectivo_Linea_Empaque_Otros.Inserto = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Control_Inspectivo_Linea_Empaque_Otros);
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

		public BOT_Control_Inspectivo_Linea_Empaque_Otros fnSelT_Control_Inspectivo_Linea_Empaque_Otros(String psCodigo_Control_Inspectivo_Linea_Empaque_Otros)
		{
			BOT_Control_Inspectivo_Linea_Empaque_Otros loBOT_Control_Inspectivo_Linea_Empaque_Otros = new BOT_Control_Inspectivo_Linea_Empaque_Otros();
			//parametros
			
			SqlParameter[] par = new SqlParameter[1];
			par[0] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque_Otros",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Control_Inspectivo_Linea_Empaque_Otros;
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Control_Inspectivo_Linea_Empaque_Otros", par);
				while(loDr.Read()){//----------------------------------------------------- AQUI
					if (loDr != null)
					{
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Inspectivo_Linea_Empaque_Otros"));
					loBOT_Control_Inspectivo_Linea_Empaque_Otros.Codigo_Control_Inspectivo_Linea_Empaque_Otros = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Inspectivo_Linea_Emapaque"));
					loBOT_Control_Inspectivo_Linea_Empaque_Otros.Codigo_Control_Inspectivo_Linea_Emapaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Inserto"));
					loBOT_Control_Inspectivo_Linea_Empaque_Otros.Inserto = value != System.DBNull.Value ? (String)value : default(String);
						
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
			return loBOT_Control_Inspectivo_Linea_Empaque_Otros;
		}
		public List<BOT_Control_Inspectivo_Linea_Empaque_Otros> fnSelT_Control_Inspectivo_Linea_Empaque_OtrosDin(string psWhere,string psOrder)
		{
			List<BOT_Control_Inspectivo_Linea_Empaque_Otros> loList = new List<BOT_Control_Inspectivo_Linea_Empaque_Otros>();
			SqlParameter[] par = new SqlParameter[2];
			par[0] = new SqlParameter("@WhereCondition",System.Data.SqlDbType.VarChar,500);
			par[0].Value= psWhere;
			par[1] = new SqlParameter("@OrderByExpression",System.Data.SqlDbType.VarChar,250);
			par[1].Value= psOrder;
			object value;//------------------------- 1
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Control_Inspectivo_Linea_Empaque_OtrossDin",par);
				while (loDr.Read())
                {
					BOT_Control_Inspectivo_Linea_Empaque_Otros loBOT_Control_Inspectivo_Linea_Empaque_Otros=new BOT_Control_Inspectivo_Linea_Empaque_Otros();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Inspectivo_Linea_Empaque_Otros"));
					loBOT_Control_Inspectivo_Linea_Empaque_Otros.Codigo_Control_Inspectivo_Linea_Empaque_Otros = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Inspectivo_Linea_Emapaque"));
					loBOT_Control_Inspectivo_Linea_Empaque_Otros.Codigo_Control_Inspectivo_Linea_Emapaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Inserto"));
					loBOT_Control_Inspectivo_Linea_Empaque_Otros.Inserto = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Control_Inspectivo_Linea_Empaque_Otros);
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
		public Int32[] fnSelT_Control_Inspectivo_Linea_Empaque_OtrosMinMax()
        {
            Int32[] laMinMax=new Int32[2];
            try
			{
                SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Control_Inspectivo_Linea_Empaque_OtrosMinMax");
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

