using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using BO_SISACO;

namespace BDA_SISACO
{	
	public partial class BDAT_Adicional:BDABase
	{
		public Boolean fnInsT_Adicional(BOT_Adicional poBOT_Adicional, out string cod_Adicional)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[6];
			par[0] = new SqlParameter("@Codigo_Adicional",System.Data.SqlDbType.VarChar,10);
            par[0].Direction = ParameterDirection.Output;
			ValidateAndInsertValue(par[0],poBOT_Adicional.Codigo_Adicional);
			par[1] = new SqlParameter("@Codigo_Orden_Acondicionado",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Adicional.Codigo_Orden_Acondicionado);
			par[2] = new SqlParameter("@Insumo",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[2],poBOT_Adicional.Insumo);
			par[3] = new SqlParameter("@Numero_Analisis",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[3],poBOT_Adicional.Numero_Analisis);
			par[4] = new SqlParameter("@Cantidad",System.Data.SqlDbType.VarChar,20);
			ValidateAndInsertValue(par[4],poBOT_Adicional.Cantidad);
			par[5] = new SqlParameter("@Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[5],poBOT_Adicional.Fecha);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsT_Adicional", par);
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
            cod_Adicional = par[0].Value.ToString();
			return lbResultado;
		}
		public Boolean fnUpdT_Adicional(BOT_Adicional poBOT_Adicional)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[6];
			par[0] = new SqlParameter("@Codigo_Adicional",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Adicional.Codigo_Adicional);
			par[1] = new SqlParameter("@Codigo_Orden_Acondicionado",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Adicional.Codigo_Orden_Acondicionado);
			par[2] = new SqlParameter("@Insumo",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[2],poBOT_Adicional.Insumo);
			par[3] = new SqlParameter("@Numero_Analisis",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[3],poBOT_Adicional.Numero_Analisis);
			par[4] = new SqlParameter("@Cantidad",System.Data.SqlDbType.VarChar,20);
			ValidateAndInsertValue(par[4],poBOT_Adicional.Cantidad);
			par[5] = new SqlParameter("@Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[5],poBOT_Adicional.Fecha);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_UpdT_Adicional", par);
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

		public Boolean fnInsUpdT_Adicional(BOT_Adicional poBOT_Adicional)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[6];
			par[0] = new SqlParameter("@Codigo_Adicional",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Adicional.Codigo_Adicional);
			par[1] = new SqlParameter("@Codigo_Orden_Acondicionado",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Adicional.Codigo_Orden_Acondicionado);
			par[2] = new SqlParameter("@Insumo",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[2],poBOT_Adicional.Insumo);
			par[3] = new SqlParameter("@Numero_Analisis",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[3],poBOT_Adicional.Numero_Analisis);
			par[4] = new SqlParameter("@Cantidad",System.Data.SqlDbType.VarChar,20);
			ValidateAndInsertValue(par[4],poBOT_Adicional.Cantidad);
			par[5] = new SqlParameter("@Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[5],poBOT_Adicional.Fecha);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsUpdT_Adicional", par);
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
		public Boolean fnDelT_Adicional(String psCodigo_Adicional)
		{
			Boolean lbResultado=true;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			SqlParameter[] par = new SqlParameter[1];
			//cambiar aca:
			par[0] = new SqlParameter("@Codigo_Adicional",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Adicional;
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_DelT_Adicional", par);
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

		public List<BOT_Adicional> fnSelT_AdicionalAll()
		{
			List<BOT_Adicional> loList = new List<BOT_Adicional>();
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_AdicionalsAll");
				while (loDr.Read())
                {
					BOT_Adicional loBOT_Adicional=new BOT_Adicional();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Adicional"));
					loBOT_Adicional.Codigo_Adicional = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Orden_Acondicionado"));
					loBOT_Adicional.Codigo_Orden_Acondicionado = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Insumo"));
					loBOT_Adicional.Insumo = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Numero_Analisis"));
					loBOT_Adicional.Numero_Analisis = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad"));
					loBOT_Adicional.Cantidad = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Fecha"));
					loBOT_Adicional.Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
                    loList.Add(loBOT_Adicional);
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

		public BOT_Adicional fnSelT_Adicional(String psCodigo_Adicional)
		{
			BOT_Adicional loBOT_Adicional = new BOT_Adicional();
			//parametros
			
			SqlParameter[] par = new SqlParameter[1];
			par[0] = new SqlParameter("@Codigo_Adicional",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Adicional;
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Adicional", par);
				while(loDr.Read()){//----------------------------------------------------- AQUI
					if (loDr != null)
					{
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Adicional"));
					loBOT_Adicional.Codigo_Adicional = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Orden_Acondicionado"));
					loBOT_Adicional.Codigo_Orden_Acondicionado = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Insumo"));
					loBOT_Adicional.Insumo = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Numero_Analisis"));
					loBOT_Adicional.Numero_Analisis = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad"));
					loBOT_Adicional.Cantidad = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Fecha"));
					loBOT_Adicional.Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
						
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
			return loBOT_Adicional;
		}
		public List<BOT_Adicional> fnSelT_AdicionalDin(string psWhere,string psOrder)
		{
			List<BOT_Adicional> loList = new List<BOT_Adicional>();
			SqlParameter[] par = new SqlParameter[2];
			par[0] = new SqlParameter("@WhereCondition",System.Data.SqlDbType.VarChar,500);
			par[0].Value= psWhere;
			par[1] = new SqlParameter("@OrderByExpression",System.Data.SqlDbType.VarChar,250);
			par[1].Value= psOrder;
			object value;//------------------------- 1
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_AdicionalsDin",par);
				while (loDr.Read())
                {
					BOT_Adicional loBOT_Adicional=new BOT_Adicional();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Adicional"));
					loBOT_Adicional.Codigo_Adicional = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Orden_Acondicionado"));
					loBOT_Adicional.Codigo_Orden_Acondicionado = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Insumo"));
					loBOT_Adicional.Insumo = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Numero_Analisis"));
					loBOT_Adicional.Numero_Analisis = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad"));
					loBOT_Adicional.Cantidad = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Fecha"));
					loBOT_Adicional.Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
                    loList.Add(loBOT_Adicional);
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
		public Int32[] fnSelT_AdicionalMinMax()
        {
            Int32[] laMinMax=new Int32[2];
            try
			{
                SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_AdicionalMinMax");
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

