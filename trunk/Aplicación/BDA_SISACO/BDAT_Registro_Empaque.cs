using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using BO_SISACO;

namespace BDA_SISACO
{	
	public partial class BDAT_Registro_Empaque:BDABase
	{
		public Boolean fnInsT_Registro_Empaque(BOT_Registro_Empaque poBOT_Registro_Empaque)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[5];
			par[0] = new SqlParameter("@Codigo_Registro_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Registro_Empaque.Codigo_Registro_Empaque);
			par[1] = new SqlParameter("@Codigo_Orden_Acondicionamiento",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Registro_Empaque.Codigo_Orden_Acondicionamiento);
			par[2] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[2],poBOT_Registro_Empaque.Codigo_Registro_Empaque_Despeje_Linea);
			par[3] = new SqlParameter("@Codigo_Registro_Empaque_Procedimiento",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[3],poBOT_Registro_Empaque.Codigo_Registro_Empaque_Procedimiento);
			par[4] = new SqlParameter("@Observaciones",System.Data.SqlDbType.VarChar,200);
			ValidateAndInsertValue(par[4],poBOT_Registro_Empaque.Observaciones);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsT_Registro_Empaque", par);
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
		public Boolean fnUpdT_Registro_Empaque(BOT_Registro_Empaque poBOT_Registro_Empaque)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[5];
			par[0] = new SqlParameter("@Codigo_Registro_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Registro_Empaque.Codigo_Registro_Empaque);
			par[1] = new SqlParameter("@Codigo_Orden_Acondicionamiento",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Registro_Empaque.Codigo_Orden_Acondicionamiento);
			par[2] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[2],poBOT_Registro_Empaque.Codigo_Registro_Empaque_Despeje_Linea);
			par[3] = new SqlParameter("@Codigo_Registro_Empaque_Procedimiento",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[3],poBOT_Registro_Empaque.Codigo_Registro_Empaque_Procedimiento);
			par[4] = new SqlParameter("@Observaciones",System.Data.SqlDbType.VarChar,200);
			ValidateAndInsertValue(par[4],poBOT_Registro_Empaque.Observaciones);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_UpdT_Registro_Empaque", par);
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

		public Boolean fnInsUpdT_Registro_Empaque(BOT_Registro_Empaque poBOT_Registro_Empaque)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[5];
			par[0] = new SqlParameter("@Codigo_Registro_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Registro_Empaque.Codigo_Registro_Empaque);
			par[1] = new SqlParameter("@Codigo_Orden_Acondicionamiento",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Registro_Empaque.Codigo_Orden_Acondicionamiento);
			par[2] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[2],poBOT_Registro_Empaque.Codigo_Registro_Empaque_Despeje_Linea);
			par[3] = new SqlParameter("@Codigo_Registro_Empaque_Procedimiento",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[3],poBOT_Registro_Empaque.Codigo_Registro_Empaque_Procedimiento);
			par[4] = new SqlParameter("@Observaciones",System.Data.SqlDbType.VarChar,200);
			ValidateAndInsertValue(par[4],poBOT_Registro_Empaque.Observaciones);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsUpdT_Registro_Empaque", par);
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
		public Boolean fnDelT_Registro_Empaque(String psCodigo_Registro_Empaque)
		{
			Boolean lbResultado=true;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			SqlParameter[] par = new SqlParameter[1];
			//cambiar aca:
			par[0] = new SqlParameter("@Codigo_Registro_Empaque",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Registro_Empaque;
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_DelT_Registro_Empaque", par);
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

		public List<BOT_Registro_Empaque> fnSelT_Registro_EmpaqueAll()
		{
			List<BOT_Registro_Empaque> loList = new List<BOT_Registro_Empaque>();
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_EmpaquesAll");
				while (loDr.Read())
                {
					BOT_Registro_Empaque loBOT_Registro_Empaque=new BOT_Registro_Empaque();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque"));
					loBOT_Registro_Empaque.Codigo_Registro_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Orden_Acondicionamiento"));
					loBOT_Registro_Empaque.Codigo_Orden_Acondicionamiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea"));
					loBOT_Registro_Empaque.Codigo_Registro_Empaque_Despeje_Linea = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Procedimiento"));
					loBOT_Registro_Empaque.Codigo_Registro_Empaque_Procedimiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Observaciones"));
					loBOT_Registro_Empaque.Observaciones = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Registro_Empaque);
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

		public BOT_Registro_Empaque fnSelT_Registro_Empaque(String psCodigo_Registro_Empaque)
		{
			BOT_Registro_Empaque loBOT_Registro_Empaque = new BOT_Registro_Empaque();
			//parametros
			
			SqlParameter[] par = new SqlParameter[1];
			par[0] = new SqlParameter("@Codigo_Registro_Empaque",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Registro_Empaque;
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Empaque", par);
				while(loDr.Read()){//----------------------------------------------------- AQUI
					if (loDr != null)
					{
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque"));
					loBOT_Registro_Empaque.Codigo_Registro_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Orden_Acondicionamiento"));
					loBOT_Registro_Empaque.Codigo_Orden_Acondicionamiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea"));
					loBOT_Registro_Empaque.Codigo_Registro_Empaque_Despeje_Linea = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Procedimiento"));
					loBOT_Registro_Empaque.Codigo_Registro_Empaque_Procedimiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Observaciones"));
					loBOT_Registro_Empaque.Observaciones = value != System.DBNull.Value ? (String)value : default(String);
						
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
			return loBOT_Registro_Empaque;
		}
		public List<BOT_Registro_Empaque> fnSelT_Registro_EmpaqueDin(string psWhere,string psOrder)
		{
			List<BOT_Registro_Empaque> loList = new List<BOT_Registro_Empaque>();
			SqlParameter[] par = new SqlParameter[2];
			par[0] = new SqlParameter("@WhereCondition",System.Data.SqlDbType.VarChar,500);
			par[0].Value= psWhere;
			par[1] = new SqlParameter("@OrderByExpression",System.Data.SqlDbType.VarChar,250);
			par[1].Value= psOrder;
			object value;//------------------------- 1
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_EmpaquesDin",par);
				while (loDr.Read())
                {
					BOT_Registro_Empaque loBOT_Registro_Empaque=new BOT_Registro_Empaque();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque"));
					loBOT_Registro_Empaque.Codigo_Registro_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Orden_Acondicionamiento"));
					loBOT_Registro_Empaque.Codigo_Orden_Acondicionamiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea"));
					loBOT_Registro_Empaque.Codigo_Registro_Empaque_Despeje_Linea = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Procedimiento"));
					loBOT_Registro_Empaque.Codigo_Registro_Empaque_Procedimiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Observaciones"));
					loBOT_Registro_Empaque.Observaciones = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Registro_Empaque);
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
		public Int32[] fnSelT_Registro_EmpaqueMinMax()
        {
            Int32[] laMinMax=new Int32[2];
            try
			{
                SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_EmpaqueMinMax");
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

