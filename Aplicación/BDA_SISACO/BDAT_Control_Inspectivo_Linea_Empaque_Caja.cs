using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using BO_SISACO;

namespace BDA_SISACO
{	
	public partial class BDAT_Control_Inspectivo_Linea_Empaque_Caja:BDABase
	{
		public Boolean fnInsT_Control_Inspectivo_Linea_Empaque_Caja(BOT_Control_Inspectivo_Linea_Empaque_Caja poBOT_Control_Inspectivo_Linea_Empaque_Caja)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[7];
			par[0] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque_Caja",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Control_Inspectivo_Linea_Empaque_Caja.Codigo_Control_Inspectivo_Linea_Empaque_Caja);
			par[1] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Control_Inspectivo_Linea_Empaque_Caja.Codigo_Control_Inspectivo_Linea_Empaque);
			par[2] = new SqlParameter("@Nombre",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[2],poBOT_Control_Inspectivo_Linea_Empaque_Caja.Nombre);
			par[3] = new SqlParameter("@Impresion",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[3],poBOT_Control_Inspectivo_Linea_Empaque_Caja.Impresion);
			par[4] = new SqlParameter("@Lote_Expiracion",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[4],poBOT_Control_Inspectivo_Linea_Empaque_Caja.Lote_Expiracion);
			par[5] = new SqlParameter("@Presemtacion",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[5],poBOT_Control_Inspectivo_Linea_Empaque_Caja.Presemtacion);
			par[6] = new SqlParameter("@Cantidad",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[6],poBOT_Control_Inspectivo_Linea_Empaque_Caja.Cantidad);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsT_Control_Inspectivo_Linea_Empaque_Caja", par);
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
		public Boolean fnUpdT_Control_Inspectivo_Linea_Empaque_Caja(BOT_Control_Inspectivo_Linea_Empaque_Caja poBOT_Control_Inspectivo_Linea_Empaque_Caja)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[7];
			par[0] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque_Caja",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Control_Inspectivo_Linea_Empaque_Caja.Codigo_Control_Inspectivo_Linea_Empaque_Caja);
			par[1] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Control_Inspectivo_Linea_Empaque_Caja.Codigo_Control_Inspectivo_Linea_Empaque);
			par[2] = new SqlParameter("@Nombre",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[2],poBOT_Control_Inspectivo_Linea_Empaque_Caja.Nombre);
			par[3] = new SqlParameter("@Impresion",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[3],poBOT_Control_Inspectivo_Linea_Empaque_Caja.Impresion);
			par[4] = new SqlParameter("@Lote_Expiracion",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[4],poBOT_Control_Inspectivo_Linea_Empaque_Caja.Lote_Expiracion);
			par[5] = new SqlParameter("@Presemtacion",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[5],poBOT_Control_Inspectivo_Linea_Empaque_Caja.Presemtacion);
			par[6] = new SqlParameter("@Cantidad",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[6],poBOT_Control_Inspectivo_Linea_Empaque_Caja.Cantidad);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_UpdT_Control_Inspectivo_Linea_Empaque_Caja", par);
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

		public Boolean fnInsUpdT_Control_Inspectivo_Linea_Empaque_Caja(BOT_Control_Inspectivo_Linea_Empaque_Caja poBOT_Control_Inspectivo_Linea_Empaque_Caja)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[7];
			par[0] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque_Caja",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Control_Inspectivo_Linea_Empaque_Caja.Codigo_Control_Inspectivo_Linea_Empaque_Caja);
			par[1] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Control_Inspectivo_Linea_Empaque_Caja.Codigo_Control_Inspectivo_Linea_Empaque);
			par[2] = new SqlParameter("@Nombre",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[2],poBOT_Control_Inspectivo_Linea_Empaque_Caja.Nombre);
			par[3] = new SqlParameter("@Impresion",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[3],poBOT_Control_Inspectivo_Linea_Empaque_Caja.Impresion);
			par[4] = new SqlParameter("@Lote_Expiracion",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[4],poBOT_Control_Inspectivo_Linea_Empaque_Caja.Lote_Expiracion);
			par[5] = new SqlParameter("@Presemtacion",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[5],poBOT_Control_Inspectivo_Linea_Empaque_Caja.Presemtacion);
			par[6] = new SqlParameter("@Cantidad",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[6],poBOT_Control_Inspectivo_Linea_Empaque_Caja.Cantidad);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsUpdT_Control_Inspectivo_Linea_Empaque_Caja", par);
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
		public Boolean fnDelT_Control_Inspectivo_Linea_Empaque_Caja(String psCodigo_Control_Inspectivo_Linea_Empaque_Caja)
		{
			Boolean lbResultado=true;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			SqlParameter[] par = new SqlParameter[1];
			//cambiar aca:
			par[0] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque_Caja",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Control_Inspectivo_Linea_Empaque_Caja;
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_DelT_Control_Inspectivo_Linea_Empaque_Caja", par);
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

		public List<BOT_Control_Inspectivo_Linea_Empaque_Caja> fnSelT_Control_Inspectivo_Linea_Empaque_CajaAll()
		{
			List<BOT_Control_Inspectivo_Linea_Empaque_Caja> loList = new List<BOT_Control_Inspectivo_Linea_Empaque_Caja>();
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Control_Inspectivo_Linea_Empaque_CajasAll");
				while (loDr.Read())
                {
					BOT_Control_Inspectivo_Linea_Empaque_Caja loBOT_Control_Inspectivo_Linea_Empaque_Caja=new BOT_Control_Inspectivo_Linea_Empaque_Caja();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Inspectivo_Linea_Empaque_Caja"));
					loBOT_Control_Inspectivo_Linea_Empaque_Caja.Codigo_Control_Inspectivo_Linea_Empaque_Caja = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Inspectivo_Linea_Empaque"));
					loBOT_Control_Inspectivo_Linea_Empaque_Caja.Codigo_Control_Inspectivo_Linea_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Nombre"));
					loBOT_Control_Inspectivo_Linea_Empaque_Caja.Nombre = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Impresion"));
					loBOT_Control_Inspectivo_Linea_Empaque_Caja.Impresion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Lote_Expiracion"));
					loBOT_Control_Inspectivo_Linea_Empaque_Caja.Lote_Expiracion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Presemtacion"));
					loBOT_Control_Inspectivo_Linea_Empaque_Caja.Presemtacion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad"));
					loBOT_Control_Inspectivo_Linea_Empaque_Caja.Cantidad = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Control_Inspectivo_Linea_Empaque_Caja);
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

		public BOT_Control_Inspectivo_Linea_Empaque_Caja fnSelT_Control_Inspectivo_Linea_Empaque_Caja(String psCodigo_Control_Inspectivo_Linea_Empaque_Caja)
		{
			BOT_Control_Inspectivo_Linea_Empaque_Caja loBOT_Control_Inspectivo_Linea_Empaque_Caja = new BOT_Control_Inspectivo_Linea_Empaque_Caja();
			//parametros
			
			SqlParameter[] par = new SqlParameter[1];
			par[0] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque_Caja",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Control_Inspectivo_Linea_Empaque_Caja;
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Control_Inspectivo_Linea_Empaque_Caja", par);
				while(loDr.Read()){//----------------------------------------------------- AQUI
					if (loDr != null)
					{
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Inspectivo_Linea_Empaque_Caja"));
					loBOT_Control_Inspectivo_Linea_Empaque_Caja.Codigo_Control_Inspectivo_Linea_Empaque_Caja = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Inspectivo_Linea_Empaque"));
					loBOT_Control_Inspectivo_Linea_Empaque_Caja.Codigo_Control_Inspectivo_Linea_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Nombre"));
					loBOT_Control_Inspectivo_Linea_Empaque_Caja.Nombre = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Impresion"));
					loBOT_Control_Inspectivo_Linea_Empaque_Caja.Impresion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Lote_Expiracion"));
					loBOT_Control_Inspectivo_Linea_Empaque_Caja.Lote_Expiracion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Presemtacion"));
					loBOT_Control_Inspectivo_Linea_Empaque_Caja.Presemtacion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad"));
					loBOT_Control_Inspectivo_Linea_Empaque_Caja.Cantidad = value != System.DBNull.Value ? (String)value : default(String);
						
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
			return loBOT_Control_Inspectivo_Linea_Empaque_Caja;
		}
		public List<BOT_Control_Inspectivo_Linea_Empaque_Caja> fnSelT_Control_Inspectivo_Linea_Empaque_CajaDin(string psWhere,string psOrder)
		{
			List<BOT_Control_Inspectivo_Linea_Empaque_Caja> loList = new List<BOT_Control_Inspectivo_Linea_Empaque_Caja>();
			SqlParameter[] par = new SqlParameter[2];
			par[0] = new SqlParameter("@WhereCondition",System.Data.SqlDbType.VarChar,500);
			par[0].Value= psWhere;
			par[1] = new SqlParameter("@OrderByExpression",System.Data.SqlDbType.VarChar,250);
			par[1].Value= psOrder;
			object value;//------------------------- 1
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Control_Inspectivo_Linea_Empaque_CajasDin",par);
				while (loDr.Read())
                {
					BOT_Control_Inspectivo_Linea_Empaque_Caja loBOT_Control_Inspectivo_Linea_Empaque_Caja=new BOT_Control_Inspectivo_Linea_Empaque_Caja();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Inspectivo_Linea_Empaque_Caja"));
					loBOT_Control_Inspectivo_Linea_Empaque_Caja.Codigo_Control_Inspectivo_Linea_Empaque_Caja = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Inspectivo_Linea_Empaque"));
					loBOT_Control_Inspectivo_Linea_Empaque_Caja.Codigo_Control_Inspectivo_Linea_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Nombre"));
					loBOT_Control_Inspectivo_Linea_Empaque_Caja.Nombre = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Impresion"));
					loBOT_Control_Inspectivo_Linea_Empaque_Caja.Impresion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Lote_Expiracion"));
					loBOT_Control_Inspectivo_Linea_Empaque_Caja.Lote_Expiracion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Presemtacion"));
					loBOT_Control_Inspectivo_Linea_Empaque_Caja.Presemtacion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad"));
					loBOT_Control_Inspectivo_Linea_Empaque_Caja.Cantidad = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Control_Inspectivo_Linea_Empaque_Caja);
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
		public Int32[] fnSelT_Control_Inspectivo_Linea_Empaque_CajaMinMax()
        {
            Int32[] laMinMax=new Int32[2];
            try
			{
                SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Control_Inspectivo_Linea_Empaque_CajaMinMax");
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

