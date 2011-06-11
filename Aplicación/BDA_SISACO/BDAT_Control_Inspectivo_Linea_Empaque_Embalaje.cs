using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using BO_SISACO;

namespace BDA_SISACO
{	
	public partial class BDAT_Control_Inspectivo_Linea_Empaque_Embalaje:BDABase
	{
		public Boolean fnInsT_Control_Inspectivo_Linea_Empaque_Embalaje(BOT_Control_Inspectivo_Linea_Empaque_Embalaje poBOT_Control_Inspectivo_Linea_Empaque_Embalaje)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[4];
			par[0] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque_Embalaje",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Control_Inspectivo_Linea_Empaque_Embalaje.Codigo_Control_Inspectivo_Linea_Empaque_Embalaje);
			par[1] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Control_Inspectivo_Linea_Empaque_Embalaje.Codigo_Control_Inspectivo_Linea_Empaque);
			par[2] = new SqlParameter("@Identificado",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[2],poBOT_Control_Inspectivo_Linea_Empaque_Embalaje.Identificado);
			par[3] = new SqlParameter("@Cantidad",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[3],poBOT_Control_Inspectivo_Linea_Empaque_Embalaje.Cantidad);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsT_Control_Inspectivo_Linea_Empaque_Embalaje", par);
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
		public Boolean fnUpdT_Control_Inspectivo_Linea_Empaque_Embalaje(BOT_Control_Inspectivo_Linea_Empaque_Embalaje poBOT_Control_Inspectivo_Linea_Empaque_Embalaje)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[4];
			par[0] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque_Embalaje",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Control_Inspectivo_Linea_Empaque_Embalaje.Codigo_Control_Inspectivo_Linea_Empaque_Embalaje);
			par[1] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Control_Inspectivo_Linea_Empaque_Embalaje.Codigo_Control_Inspectivo_Linea_Empaque);
			par[2] = new SqlParameter("@Identificado",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[2],poBOT_Control_Inspectivo_Linea_Empaque_Embalaje.Identificado);
			par[3] = new SqlParameter("@Cantidad",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[3],poBOT_Control_Inspectivo_Linea_Empaque_Embalaje.Cantidad);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_UpdT_Control_Inspectivo_Linea_Empaque_Embalaje", par);
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

		public Boolean fnInsUpdT_Control_Inspectivo_Linea_Empaque_Embalaje(BOT_Control_Inspectivo_Linea_Empaque_Embalaje poBOT_Control_Inspectivo_Linea_Empaque_Embalaje)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[4];
			par[0] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque_Embalaje",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Control_Inspectivo_Linea_Empaque_Embalaje.Codigo_Control_Inspectivo_Linea_Empaque_Embalaje);
			par[1] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Control_Inspectivo_Linea_Empaque_Embalaje.Codigo_Control_Inspectivo_Linea_Empaque);
			par[2] = new SqlParameter("@Identificado",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[2],poBOT_Control_Inspectivo_Linea_Empaque_Embalaje.Identificado);
			par[3] = new SqlParameter("@Cantidad",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[3],poBOT_Control_Inspectivo_Linea_Empaque_Embalaje.Cantidad);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsUpdT_Control_Inspectivo_Linea_Empaque_Embalaje", par);
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
		public Boolean fnDelT_Control_Inspectivo_Linea_Empaque_Embalaje(String psCodigo_Control_Inspectivo_Linea_Empaque_Embalaje)
		{
			Boolean lbResultado=true;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			SqlParameter[] par = new SqlParameter[1];
			//cambiar aca:
			par[0] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque_Embalaje",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Control_Inspectivo_Linea_Empaque_Embalaje;
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_DelT_Control_Inspectivo_Linea_Empaque_Embalaje", par);
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

		public List<BOT_Control_Inspectivo_Linea_Empaque_Embalaje> fnSelT_Control_Inspectivo_Linea_Empaque_EmbalajeAll()
		{
			List<BOT_Control_Inspectivo_Linea_Empaque_Embalaje> loList = new List<BOT_Control_Inspectivo_Linea_Empaque_Embalaje>();
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Control_Inspectivo_Linea_Empaque_EmbalajesAll");
				while (loDr.Read())
                {
					BOT_Control_Inspectivo_Linea_Empaque_Embalaje loBOT_Control_Inspectivo_Linea_Empaque_Embalaje=new BOT_Control_Inspectivo_Linea_Empaque_Embalaje();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Inspectivo_Linea_Empaque_Embalaje"));
					loBOT_Control_Inspectivo_Linea_Empaque_Embalaje.Codigo_Control_Inspectivo_Linea_Empaque_Embalaje = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Inspectivo_Linea_Empaque"));
					loBOT_Control_Inspectivo_Linea_Empaque_Embalaje.Codigo_Control_Inspectivo_Linea_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Identificado"));
					loBOT_Control_Inspectivo_Linea_Empaque_Embalaje.Identificado = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad"));
					loBOT_Control_Inspectivo_Linea_Empaque_Embalaje.Cantidad = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Control_Inspectivo_Linea_Empaque_Embalaje);
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

		public BOT_Control_Inspectivo_Linea_Empaque_Embalaje fnSelT_Control_Inspectivo_Linea_Empaque_Embalaje(String psCodigo_Control_Inspectivo_Linea_Empaque_Embalaje)
		{
			BOT_Control_Inspectivo_Linea_Empaque_Embalaje loBOT_Control_Inspectivo_Linea_Empaque_Embalaje = new BOT_Control_Inspectivo_Linea_Empaque_Embalaje();
			//parametros
			
			SqlParameter[] par = new SqlParameter[1];
			par[0] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque_Embalaje",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Control_Inspectivo_Linea_Empaque_Embalaje;
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Control_Inspectivo_Linea_Empaque_Embalaje", par);
				while(loDr.Read()){//----------------------------------------------------- AQUI
					if (loDr != null)
					{
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Inspectivo_Linea_Empaque_Embalaje"));
					loBOT_Control_Inspectivo_Linea_Empaque_Embalaje.Codigo_Control_Inspectivo_Linea_Empaque_Embalaje = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Inspectivo_Linea_Empaque"));
					loBOT_Control_Inspectivo_Linea_Empaque_Embalaje.Codigo_Control_Inspectivo_Linea_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Identificado"));
					loBOT_Control_Inspectivo_Linea_Empaque_Embalaje.Identificado = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad"));
					loBOT_Control_Inspectivo_Linea_Empaque_Embalaje.Cantidad = value != System.DBNull.Value ? (String)value : default(String);
						
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
			return loBOT_Control_Inspectivo_Linea_Empaque_Embalaje;
		}
		public List<BOT_Control_Inspectivo_Linea_Empaque_Embalaje> fnSelT_Control_Inspectivo_Linea_Empaque_EmbalajeDin(string psWhere,string psOrder)
		{
			List<BOT_Control_Inspectivo_Linea_Empaque_Embalaje> loList = new List<BOT_Control_Inspectivo_Linea_Empaque_Embalaje>();
			SqlParameter[] par = new SqlParameter[2];
			par[0] = new SqlParameter("@WhereCondition",System.Data.SqlDbType.VarChar,500);
			par[0].Value= psWhere;
			par[1] = new SqlParameter("@OrderByExpression",System.Data.SqlDbType.VarChar,250);
			par[1].Value= psOrder;
			object value;//------------------------- 1
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Control_Inspectivo_Linea_Empaque_EmbalajesDin",par);
				while (loDr.Read())
                {
					BOT_Control_Inspectivo_Linea_Empaque_Embalaje loBOT_Control_Inspectivo_Linea_Empaque_Embalaje=new BOT_Control_Inspectivo_Linea_Empaque_Embalaje();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Inspectivo_Linea_Empaque_Embalaje"));
					loBOT_Control_Inspectivo_Linea_Empaque_Embalaje.Codigo_Control_Inspectivo_Linea_Empaque_Embalaje = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Inspectivo_Linea_Empaque"));
					loBOT_Control_Inspectivo_Linea_Empaque_Embalaje.Codigo_Control_Inspectivo_Linea_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Identificado"));
					loBOT_Control_Inspectivo_Linea_Empaque_Embalaje.Identificado = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad"));
					loBOT_Control_Inspectivo_Linea_Empaque_Embalaje.Cantidad = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Control_Inspectivo_Linea_Empaque_Embalaje);
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
		public Int32[] fnSelT_Control_Inspectivo_Linea_Empaque_EmbalajeMinMax()
        {
            Int32[] laMinMax=new Int32[2];
            try
			{
                SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Control_Inspectivo_Linea_Empaque_EmbalajeMinMax");
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

