using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using BO_SISACO;

namespace BDA_SISACO
{	
	public partial class BDAT_Rendimiento_Empaque:BDABase
	{
		public Boolean fnInsT_Rendimiento_Empaque(BOT_Rendimiento_Empaque poBOT_Rendimiento_Empaque)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[4];
			par[0] = new SqlParameter("@Codigo_Rendimiento_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Rendimiento_Empaque.Codigo_Rendimiento_Empaque);
			par[1] = new SqlParameter("@Codigo_Orden_Acondicionamiento",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Rendimiento_Empaque.Codigo_Orden_Acondicionamiento);
			par[2] = new SqlParameter("@Codigo_Rendimiento_Empaque_Tamaño_Material_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[2],poBOT_Rendimiento_Empaque.Codigo_Rendimiento_Empaque_Tamaño_Material_Empaque);
			par[3] = new SqlParameter("@Codigo_Merma",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[3],poBOT_Rendimiento_Empaque.Codigo_Merma);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsT_Rendimiento_Empaque", par);
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
		public Boolean fnUpdT_Rendimiento_Empaque(BOT_Rendimiento_Empaque poBOT_Rendimiento_Empaque)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[4];
			par[0] = new SqlParameter("@Codigo_Rendimiento_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Rendimiento_Empaque.Codigo_Rendimiento_Empaque);
			par[1] = new SqlParameter("@Codigo_Orden_Acondicionamiento",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Rendimiento_Empaque.Codigo_Orden_Acondicionamiento);
			par[2] = new SqlParameter("@Codigo_Rendimiento_Empaque_Tamaño_Material_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[2],poBOT_Rendimiento_Empaque.Codigo_Rendimiento_Empaque_Tamaño_Material_Empaque);
			par[3] = new SqlParameter("@Codigo_Merma",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[3],poBOT_Rendimiento_Empaque.Codigo_Merma);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_UpdT_Rendimiento_Empaque", par);
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

		public Boolean fnInsUpdT_Rendimiento_Empaque(BOT_Rendimiento_Empaque poBOT_Rendimiento_Empaque)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[4];
			par[0] = new SqlParameter("@Codigo_Rendimiento_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Rendimiento_Empaque.Codigo_Rendimiento_Empaque);
			par[1] = new SqlParameter("@Codigo_Orden_Acondicionamiento",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Rendimiento_Empaque.Codigo_Orden_Acondicionamiento);
			par[2] = new SqlParameter("@Codigo_Rendimiento_Empaque_Tamaño_Material_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[2],poBOT_Rendimiento_Empaque.Codigo_Rendimiento_Empaque_Tamaño_Material_Empaque);
			par[3] = new SqlParameter("@Codigo_Merma",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[3],poBOT_Rendimiento_Empaque.Codigo_Merma);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsUpdT_Rendimiento_Empaque", par);
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
		public Boolean fnDelT_Rendimiento_Empaque(String psCodigo_Rendimiento_Empaque)
		{
			Boolean lbResultado=true;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			SqlParameter[] par = new SqlParameter[1];
			//cambiar aca:
			par[0] = new SqlParameter("@Codigo_Rendimiento_Empaque",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Rendimiento_Empaque;
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_DelT_Rendimiento_Empaque", par);
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

		public List<BOT_Rendimiento_Empaque> fnSelT_Rendimiento_EmpaqueAll()
		{
			List<BOT_Rendimiento_Empaque> loList = new List<BOT_Rendimiento_Empaque>();
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Rendimiento_EmpaquesAll");
				while (loDr.Read())
                {
					BOT_Rendimiento_Empaque loBOT_Rendimiento_Empaque=new BOT_Rendimiento_Empaque();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Rendimiento_Empaque"));
					loBOT_Rendimiento_Empaque.Codigo_Rendimiento_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Orden_Acondicionamiento"));
					loBOT_Rendimiento_Empaque.Codigo_Orden_Acondicionamiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Rendimiento_Empaque_Tamaño_Material_Empaque"));
					loBOT_Rendimiento_Empaque.Codigo_Rendimiento_Empaque_Tamaño_Material_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Merma"));
					loBOT_Rendimiento_Empaque.Codigo_Merma = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Rendimiento_Empaque);
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

		public BOT_Rendimiento_Empaque fnSelT_Rendimiento_Empaque(String psCodigo_Rendimiento_Empaque)
		{
			BOT_Rendimiento_Empaque loBOT_Rendimiento_Empaque = new BOT_Rendimiento_Empaque();
			//parametros
			
			SqlParameter[] par = new SqlParameter[1];
			par[0] = new SqlParameter("@Codigo_Rendimiento_Empaque",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Rendimiento_Empaque;
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Rendimiento_Empaque", par);
				while(loDr.Read()){//----------------------------------------------------- AQUI
					if (loDr != null)
					{
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Rendimiento_Empaque"));
					loBOT_Rendimiento_Empaque.Codigo_Rendimiento_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Orden_Acondicionamiento"));
					loBOT_Rendimiento_Empaque.Codigo_Orden_Acondicionamiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Rendimiento_Empaque_Tamaño_Material_Empaque"));
					loBOT_Rendimiento_Empaque.Codigo_Rendimiento_Empaque_Tamaño_Material_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Merma"));
					loBOT_Rendimiento_Empaque.Codigo_Merma = value != System.DBNull.Value ? (String)value : default(String);
						
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
			return loBOT_Rendimiento_Empaque;
		}
		public List<BOT_Rendimiento_Empaque> fnSelT_Rendimiento_EmpaqueDin(string psWhere,string psOrder)
		{
			List<BOT_Rendimiento_Empaque> loList = new List<BOT_Rendimiento_Empaque>();
			SqlParameter[] par = new SqlParameter[2];
			par[0] = new SqlParameter("@WhereCondition",System.Data.SqlDbType.VarChar,500);
			par[0].Value= psWhere;
			par[1] = new SqlParameter("@OrderByExpression",System.Data.SqlDbType.VarChar,250);
			par[1].Value= psOrder;
			object value;//------------------------- 1
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Rendimiento_EmpaquesDin",par);
				while (loDr.Read())
                {
					BOT_Rendimiento_Empaque loBOT_Rendimiento_Empaque=new BOT_Rendimiento_Empaque();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Rendimiento_Empaque"));
					loBOT_Rendimiento_Empaque.Codigo_Rendimiento_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Orden_Acondicionamiento"));
					loBOT_Rendimiento_Empaque.Codigo_Orden_Acondicionamiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Rendimiento_Empaque_Tamaño_Material_Empaque"));
					loBOT_Rendimiento_Empaque.Codigo_Rendimiento_Empaque_Tamaño_Material_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Merma"));
					loBOT_Rendimiento_Empaque.Codigo_Merma = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Rendimiento_Empaque);
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
		public Int32[] fnSelT_Rendimiento_EmpaqueMinMax()
        {
            Int32[] laMinMax=new Int32[2];
            try
			{
                SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Rendimiento_EmpaqueMinMax");
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

