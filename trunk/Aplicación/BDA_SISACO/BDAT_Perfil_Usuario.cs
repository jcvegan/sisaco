using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using BO_SISACO;

namespace BDA_SISACO
{	
	public partial class BDAT_Perfil_Usuario:BDABase
	{
		public Boolean fnInsT_Perfil_Usuario(BOT_Perfil_Usuario poBOT_Perfil_Usuario)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[2];
			par[0] = new SqlParameter("@Codigo_Perfil_Usuario",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Perfil_Usuario.Codigo_Perfil_Usuario);
			par[1] = new SqlParameter("@Perfil_Usuario",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[1],poBOT_Perfil_Usuario.Perfil_Usuario);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsT_Perfil_Usuario", par);
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
		public Boolean fnUpdT_Perfil_Usuario(BOT_Perfil_Usuario poBOT_Perfil_Usuario)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[2];
			par[0] = new SqlParameter("@Codigo_Perfil_Usuario",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Perfil_Usuario.Codigo_Perfil_Usuario);
			par[1] = new SqlParameter("@Perfil_Usuario",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[1],poBOT_Perfil_Usuario.Perfil_Usuario);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_UpdT_Perfil_Usuario", par);
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

		public Boolean fnInsUpdT_Perfil_Usuario(BOT_Perfil_Usuario poBOT_Perfil_Usuario)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[2];
			par[0] = new SqlParameter("@Codigo_Perfil_Usuario",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Perfil_Usuario.Codigo_Perfil_Usuario);
			par[1] = new SqlParameter("@Perfil_Usuario",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[1],poBOT_Perfil_Usuario.Perfil_Usuario);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsUpdT_Perfil_Usuario", par);
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
		public Boolean fnDelT_Perfil_Usuario(String psCodigo_Perfil_Usuario)
		{
			Boolean lbResultado=true;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			SqlParameter[] par = new SqlParameter[1];
			//cambiar aca:
			par[0] = new SqlParameter("@Codigo_Perfil_Usuario",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Perfil_Usuario;
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_DelT_Perfil_Usuario", par);
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

		public List<BOT_Perfil_Usuario> fnSelT_Perfil_UsuarioAll()
		{
			List<BOT_Perfil_Usuario> loList = new List<BOT_Perfil_Usuario>();
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Perfil_UsuariosAll");
				while (loDr.Read())
                {
					BOT_Perfil_Usuario loBOT_Perfil_Usuario=new BOT_Perfil_Usuario();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Perfil_Usuario"));
					loBOT_Perfil_Usuario.Codigo_Perfil_Usuario = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Perfil_Usuario"));
					loBOT_Perfil_Usuario.Perfil_Usuario = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Perfil_Usuario);
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

		public BOT_Perfil_Usuario fnSelT_Perfil_Usuario(String psCodigo_Perfil_Usuario)
		{
			BOT_Perfil_Usuario loBOT_Perfil_Usuario = new BOT_Perfil_Usuario();
			//parametros
			
			SqlParameter[] par = new SqlParameter[1];
			par[0] = new SqlParameter("@Codigo_Perfil_Usuario",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Perfil_Usuario;
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Perfil_Usuario", par);
				while(loDr.Read()){//----------------------------------------------------- AQUI
					if (loDr != null)
					{
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Perfil_Usuario"));
					loBOT_Perfil_Usuario.Codigo_Perfil_Usuario = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Perfil_Usuario"));
					loBOT_Perfil_Usuario.Perfil_Usuario = value != System.DBNull.Value ? (String)value : default(String);
						
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
			return loBOT_Perfil_Usuario;
		}
		public List<BOT_Perfil_Usuario> fnSelT_Perfil_UsuarioDin(string psWhere,string psOrder)
		{
			List<BOT_Perfil_Usuario> loList = new List<BOT_Perfil_Usuario>();
			SqlParameter[] par = new SqlParameter[2];
			par[0] = new SqlParameter("@WhereCondition",System.Data.SqlDbType.VarChar,500);
			par[0].Value= psWhere;
			par[1] = new SqlParameter("@OrderByExpression",System.Data.SqlDbType.VarChar,250);
			par[1].Value= psOrder;
			object value;//------------------------- 1
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Perfil_UsuariosDin",par);
				while (loDr.Read())
                {
					BOT_Perfil_Usuario loBOT_Perfil_Usuario=new BOT_Perfil_Usuario();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Perfil_Usuario"));
					loBOT_Perfil_Usuario.Codigo_Perfil_Usuario = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Perfil_Usuario"));
					loBOT_Perfil_Usuario.Perfil_Usuario = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Perfil_Usuario);
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
		public Int32[] fnSelT_Perfil_UsuarioMinMax()
        {
            Int32[] laMinMax=new Int32[2];
            try
			{
                SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Perfil_UsuarioMinMax");
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

