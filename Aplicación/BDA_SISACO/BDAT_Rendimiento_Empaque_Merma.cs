using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using BO_SISACO;

namespace BDA_SISACO
{	
	public partial class BDAT_Rendimiento_Empaque_Merma:BDABase
	{
		public Boolean fnInsT_Rendimiento_Empaque_Merma(BOT_Rendimiento_Empaque_Merma poBOT_Rendimiento_Empaque_Merma)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[4];
			par[0] = new SqlParameter("@Codigo_Rendimiento_Empaque_Merma",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Rendimiento_Empaque_Merma.Codigo_Rendimiento_Empaque_Merma);
			par[1] = new SqlParameter("@Codigo_Rendimiento_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Rendimiento_Empaque_Merma.Codigo_Rendimiento_Empaque);
			par[2] = new SqlParameter("@Motivo_Merma",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[2],poBOT_Rendimiento_Empaque_Merma.Motivo_Merma);
			par[3] = new SqlParameter("@Cantidad_Merma",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[3],poBOT_Rendimiento_Empaque_Merma.Cantidad_Merma);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsT_Rendimiento_Empaque_Merma", par);
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
		public Boolean fnUpdT_Rendimiento_Empaque_Merma(BOT_Rendimiento_Empaque_Merma poBOT_Rendimiento_Empaque_Merma)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[4];
			par[0] = new SqlParameter("@Codigo_Rendimiento_Empaque_Merma",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Rendimiento_Empaque_Merma.Codigo_Rendimiento_Empaque_Merma);
			par[1] = new SqlParameter("@Codigo_Rendimiento_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Rendimiento_Empaque_Merma.Codigo_Rendimiento_Empaque);
			par[2] = new SqlParameter("@Motivo_Merma",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[2],poBOT_Rendimiento_Empaque_Merma.Motivo_Merma);
			par[3] = new SqlParameter("@Cantidad_Merma",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[3],poBOT_Rendimiento_Empaque_Merma.Cantidad_Merma);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_UpdT_Rendimiento_Empaque_Merma", par);
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

		public Boolean fnInsUpdT_Rendimiento_Empaque_Merma(BOT_Rendimiento_Empaque_Merma poBOT_Rendimiento_Empaque_Merma)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[4];
			par[0] = new SqlParameter("@Codigo_Rendimiento_Empaque_Merma",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Rendimiento_Empaque_Merma.Codigo_Rendimiento_Empaque_Merma);
			par[1] = new SqlParameter("@Codigo_Rendimiento_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Rendimiento_Empaque_Merma.Codigo_Rendimiento_Empaque);
			par[2] = new SqlParameter("@Motivo_Merma",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[2],poBOT_Rendimiento_Empaque_Merma.Motivo_Merma);
			par[3] = new SqlParameter("@Cantidad_Merma",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[3],poBOT_Rendimiento_Empaque_Merma.Cantidad_Merma);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsUpdT_Rendimiento_Empaque_Merma", par);
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
		public Boolean fnDelT_Rendimiento_Empaque_Merma(String psCodigo_Rendimiento_Empaque_Merma)
		{
			Boolean lbResultado=true;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			SqlParameter[] par = new SqlParameter[1];
			//cambiar aca:
			par[0] = new SqlParameter("@Codigo_Rendimiento_Empaque_Merma",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Rendimiento_Empaque_Merma;
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_DelT_Rendimiento_Empaque_Merma", par);
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

		public List<BOT_Rendimiento_Empaque_Merma> fnSelT_Rendimiento_Empaque_MermaAll()
		{
			List<BOT_Rendimiento_Empaque_Merma> loList = new List<BOT_Rendimiento_Empaque_Merma>();
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Rendimiento_Empaque_MermasAll");
				while (loDr.Read())
                {
					BOT_Rendimiento_Empaque_Merma loBOT_Rendimiento_Empaque_Merma=new BOT_Rendimiento_Empaque_Merma();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Rendimiento_Empaque_Merma"));
					loBOT_Rendimiento_Empaque_Merma.Codigo_Rendimiento_Empaque_Merma = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Rendimiento_Empaque"));
					loBOT_Rendimiento_Empaque_Merma.Codigo_Rendimiento_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Motivo_Merma"));
					loBOT_Rendimiento_Empaque_Merma.Motivo_Merma = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad_Merma"));
					loBOT_Rendimiento_Empaque_Merma.Cantidad_Merma = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Rendimiento_Empaque_Merma);
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

		public BOT_Rendimiento_Empaque_Merma fnSelT_Rendimiento_Empaque_Merma(String psCodigo_Rendimiento_Empaque_Merma)
		{
			BOT_Rendimiento_Empaque_Merma loBOT_Rendimiento_Empaque_Merma = new BOT_Rendimiento_Empaque_Merma();
			//parametros
			
			SqlParameter[] par = new SqlParameter[1];
			par[0] = new SqlParameter("@Codigo_Rendimiento_Empaque_Merma",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Rendimiento_Empaque_Merma;
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Rendimiento_Empaque_Merma", par);
				while(loDr.Read()){//----------------------------------------------------- AQUI
					if (loDr != null)
					{
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Rendimiento_Empaque_Merma"));
					loBOT_Rendimiento_Empaque_Merma.Codigo_Rendimiento_Empaque_Merma = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Rendimiento_Empaque"));
					loBOT_Rendimiento_Empaque_Merma.Codigo_Rendimiento_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Motivo_Merma"));
					loBOT_Rendimiento_Empaque_Merma.Motivo_Merma = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad_Merma"));
					loBOT_Rendimiento_Empaque_Merma.Cantidad_Merma = value != System.DBNull.Value ? (String)value : default(String);
						
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
			return loBOT_Rendimiento_Empaque_Merma;
		}
		public List<BOT_Rendimiento_Empaque_Merma> fnSelT_Rendimiento_Empaque_MermaDin(string psWhere,string psOrder)
		{
			List<BOT_Rendimiento_Empaque_Merma> loList = new List<BOT_Rendimiento_Empaque_Merma>();
			SqlParameter[] par = new SqlParameter[2];
			par[0] = new SqlParameter("@WhereCondition",System.Data.SqlDbType.VarChar,500);
			par[0].Value= psWhere;
			par[1] = new SqlParameter("@OrderByExpression",System.Data.SqlDbType.VarChar,250);
			par[1].Value= psOrder;
			object value;//------------------------- 1
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Rendimiento_Empaque_MermasDin",par);
				while (loDr.Read())
                {
					BOT_Rendimiento_Empaque_Merma loBOT_Rendimiento_Empaque_Merma=new BOT_Rendimiento_Empaque_Merma();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Rendimiento_Empaque_Merma"));
					loBOT_Rendimiento_Empaque_Merma.Codigo_Rendimiento_Empaque_Merma = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Rendimiento_Empaque"));
					loBOT_Rendimiento_Empaque_Merma.Codigo_Rendimiento_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Motivo_Merma"));
					loBOT_Rendimiento_Empaque_Merma.Motivo_Merma = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad_Merma"));
					loBOT_Rendimiento_Empaque_Merma.Cantidad_Merma = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Rendimiento_Empaque_Merma);
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
		public Int32[] fnSelT_Rendimiento_Empaque_MermaMinMax()
        {
            Int32[] laMinMax=new Int32[2];
            try
			{
                SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Rendimiento_Empaque_MermaMinMax");
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

