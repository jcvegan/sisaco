using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using BO_SISACO;

namespace BDA_SISACO
{	
	public partial class BDAT_Registro_Empaque_Despeje_Linea_Personal:BDABase
	{
		public Boolean fnInsT_Registro_Empaque_Despeje_Linea_Personal(BOT_Registro_Empaque_Despeje_Linea_Personal poBOT_Registro_Empaque_Despeje_Linea_Personal)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[5];
			par[0] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea_Personal",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Registro_Empaque_Despeje_Linea_Personal.Codigo_Registro_Empaque_Despeje_Linea_Personal);
			par[1] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Registro_Empaque_Despeje_Linea_Personal.Codigo_Registro_Empaque_Despeje_Linea);
			par[2] = new SqlParameter("@Personal_Uniforme_Completo",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[2],poBOT_Registro_Empaque_Despeje_Linea_Personal.Personal_Uniforme_Completo);
			par[3] = new SqlParameter("@Personal_Dispositivos_Seguridad",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[3],poBOT_Registro_Empaque_Despeje_Linea_Personal.Personal_Dispositivos_Seguridad);
			par[4] = new SqlParameter("@Personal_Higiene",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[4],poBOT_Registro_Empaque_Despeje_Linea_Personal.Personal_Higiene);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsT_Registro_Empaque_Despeje_Linea_Personal", par);
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
		public Boolean fnUpdT_Registro_Empaque_Despeje_Linea_Personal(BOT_Registro_Empaque_Despeje_Linea_Personal poBOT_Registro_Empaque_Despeje_Linea_Personal)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[5];
			par[0] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea_Personal",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Registro_Empaque_Despeje_Linea_Personal.Codigo_Registro_Empaque_Despeje_Linea_Personal);
			par[1] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Registro_Empaque_Despeje_Linea_Personal.Codigo_Registro_Empaque_Despeje_Linea);
			par[2] = new SqlParameter("@Personal_Uniforme_Completo",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[2],poBOT_Registro_Empaque_Despeje_Linea_Personal.Personal_Uniforme_Completo);
			par[3] = new SqlParameter("@Personal_Dispositivos_Seguridad",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[3],poBOT_Registro_Empaque_Despeje_Linea_Personal.Personal_Dispositivos_Seguridad);
			par[4] = new SqlParameter("@Personal_Higiene",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[4],poBOT_Registro_Empaque_Despeje_Linea_Personal.Personal_Higiene);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_UpdT_Registro_Empaque_Despeje_Linea_Personal", par);
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

		public Boolean fnInsUpdT_Registro_Empaque_Despeje_Linea_Personal(BOT_Registro_Empaque_Despeje_Linea_Personal poBOT_Registro_Empaque_Despeje_Linea_Personal)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[5];
			par[0] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea_Personal",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Registro_Empaque_Despeje_Linea_Personal.Codigo_Registro_Empaque_Despeje_Linea_Personal);
			par[1] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Registro_Empaque_Despeje_Linea_Personal.Codigo_Registro_Empaque_Despeje_Linea);
			par[2] = new SqlParameter("@Personal_Uniforme_Completo",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[2],poBOT_Registro_Empaque_Despeje_Linea_Personal.Personal_Uniforme_Completo);
			par[3] = new SqlParameter("@Personal_Dispositivos_Seguridad",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[3],poBOT_Registro_Empaque_Despeje_Linea_Personal.Personal_Dispositivos_Seguridad);
			par[4] = new SqlParameter("@Personal_Higiene",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[4],poBOT_Registro_Empaque_Despeje_Linea_Personal.Personal_Higiene);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsUpdT_Registro_Empaque_Despeje_Linea_Personal", par);
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
		public Boolean fnDelT_Registro_Empaque_Despeje_Linea_Personal(String psCodigo_Registro_Empaque_Despeje_Linea_Personal)
		{
			Boolean lbResultado=true;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			SqlParameter[] par = new SqlParameter[1];
			//cambiar aca:
			par[0] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea_Personal",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Registro_Empaque_Despeje_Linea_Personal;
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_DelT_Registro_Empaque_Despeje_Linea_Personal", par);
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

		public List<BOT_Registro_Empaque_Despeje_Linea_Personal> fnSelT_Registro_Empaque_Despeje_Linea_PersonalAll()
		{
			List<BOT_Registro_Empaque_Despeje_Linea_Personal> loList = new List<BOT_Registro_Empaque_Despeje_Linea_Personal>();
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Empaque_Despeje_Linea_PersonalsAll");
				while (loDr.Read())
                {
					BOT_Registro_Empaque_Despeje_Linea_Personal loBOT_Registro_Empaque_Despeje_Linea_Personal=new BOT_Registro_Empaque_Despeje_Linea_Personal();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea_Personal"));
					loBOT_Registro_Empaque_Despeje_Linea_Personal.Codigo_Registro_Empaque_Despeje_Linea_Personal = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea"));
					loBOT_Registro_Empaque_Despeje_Linea_Personal.Codigo_Registro_Empaque_Despeje_Linea = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Personal_Uniforme_Completo"));
					loBOT_Registro_Empaque_Despeje_Linea_Personal.Personal_Uniforme_Completo = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Personal_Dispositivos_Seguridad"));
					loBOT_Registro_Empaque_Despeje_Linea_Personal.Personal_Dispositivos_Seguridad = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Personal_Higiene"));
					loBOT_Registro_Empaque_Despeje_Linea_Personal.Personal_Higiene = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Registro_Empaque_Despeje_Linea_Personal);
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

		public BOT_Registro_Empaque_Despeje_Linea_Personal fnSelT_Registro_Empaque_Despeje_Linea_Personal(String psCodigo_Registro_Empaque_Despeje_Linea_Personal)
		{
			BOT_Registro_Empaque_Despeje_Linea_Personal loBOT_Registro_Empaque_Despeje_Linea_Personal = new BOT_Registro_Empaque_Despeje_Linea_Personal();
			//parametros
			
			SqlParameter[] par = new SqlParameter[1];
			par[0] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea_Personal",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Registro_Empaque_Despeje_Linea_Personal;
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Empaque_Despeje_Linea_Personal", par);
				while(loDr.Read()){//----------------------------------------------------- AQUI
					if (loDr != null)
					{
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea_Personal"));
					loBOT_Registro_Empaque_Despeje_Linea_Personal.Codigo_Registro_Empaque_Despeje_Linea_Personal = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea"));
					loBOT_Registro_Empaque_Despeje_Linea_Personal.Codigo_Registro_Empaque_Despeje_Linea = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Personal_Uniforme_Completo"));
					loBOT_Registro_Empaque_Despeje_Linea_Personal.Personal_Uniforme_Completo = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Personal_Dispositivos_Seguridad"));
					loBOT_Registro_Empaque_Despeje_Linea_Personal.Personal_Dispositivos_Seguridad = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Personal_Higiene"));
					loBOT_Registro_Empaque_Despeje_Linea_Personal.Personal_Higiene = value != System.DBNull.Value ? (String)value : default(String);
						
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
			return loBOT_Registro_Empaque_Despeje_Linea_Personal;
		}
		public List<BOT_Registro_Empaque_Despeje_Linea_Personal> fnSelT_Registro_Empaque_Despeje_Linea_PersonalDin(string psWhere,string psOrder)
		{
			List<BOT_Registro_Empaque_Despeje_Linea_Personal> loList = new List<BOT_Registro_Empaque_Despeje_Linea_Personal>();
			SqlParameter[] par = new SqlParameter[2];
			par[0] = new SqlParameter("@WhereCondition",System.Data.SqlDbType.VarChar,500);
			par[0].Value= psWhere;
			par[1] = new SqlParameter("@OrderByExpression",System.Data.SqlDbType.VarChar,250);
			par[1].Value= psOrder;
			object value;//------------------------- 1
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Empaque_Despeje_Linea_PersonalsDin",par);
				while (loDr.Read())
                {
					BOT_Registro_Empaque_Despeje_Linea_Personal loBOT_Registro_Empaque_Despeje_Linea_Personal=new BOT_Registro_Empaque_Despeje_Linea_Personal();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea_Personal"));
					loBOT_Registro_Empaque_Despeje_Linea_Personal.Codigo_Registro_Empaque_Despeje_Linea_Personal = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea"));
					loBOT_Registro_Empaque_Despeje_Linea_Personal.Codigo_Registro_Empaque_Despeje_Linea = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Personal_Uniforme_Completo"));
					loBOT_Registro_Empaque_Despeje_Linea_Personal.Personal_Uniforme_Completo = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Personal_Dispositivos_Seguridad"));
					loBOT_Registro_Empaque_Despeje_Linea_Personal.Personal_Dispositivos_Seguridad = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Personal_Higiene"));
					loBOT_Registro_Empaque_Despeje_Linea_Personal.Personal_Higiene = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Registro_Empaque_Despeje_Linea_Personal);
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
		public Int32[] fnSelT_Registro_Empaque_Despeje_Linea_PersonalMinMax()
        {
            Int32[] laMinMax=new Int32[2];
            try
			{
                SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Empaque_Despeje_Linea_PersonalMinMax");
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

