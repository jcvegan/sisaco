using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using BO_SISACO;

namespace BDA_SISACO
{	
	public partial class BDAT_Devolucion:BDABase
	{
		public Boolean fnInsT_Devolucion(BOT_Devolucion poBOT_Devolucion)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[6];
			par[0] = new SqlParameter("@Codigo_Devolucion",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Devolucion.Codigo_Devolucion);
			par[1] = new SqlParameter("@Codigo_Orden_Acondicionamiento",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Devolucion.Codigo_Orden_Acondicionamiento);
			par[2] = new SqlParameter("@Insumo",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[2],poBOT_Devolucion.Insumo);
			par[3] = new SqlParameter("@Numero_Analisis",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[3],poBOT_Devolucion.Numero_Analisis);
			par[4] = new SqlParameter("@Cantidad",System.Data.SqlDbType.VarChar,20);
			ValidateAndInsertValue(par[4],poBOT_Devolucion.Cantidad);
			par[5] = new SqlParameter("@Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[5],poBOT_Devolucion.Fecha);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsT_Devolucion", par);
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
		public Boolean fnUpdT_Devolucion(BOT_Devolucion poBOT_Devolucion)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[6];
			par[0] = new SqlParameter("@Codigo_Devolucion",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Devolucion.Codigo_Devolucion);
			par[1] = new SqlParameter("@Codigo_Orden_Acondicionamiento",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Devolucion.Codigo_Orden_Acondicionamiento);
			par[2] = new SqlParameter("@Insumo",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[2],poBOT_Devolucion.Insumo);
			par[3] = new SqlParameter("@Numero_Analisis",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[3],poBOT_Devolucion.Numero_Analisis);
			par[4] = new SqlParameter("@Cantidad",System.Data.SqlDbType.VarChar,20);
			ValidateAndInsertValue(par[4],poBOT_Devolucion.Cantidad);
			par[5] = new SqlParameter("@Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[5],poBOT_Devolucion.Fecha);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_UpdT_Devolucion", par);
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

		public Boolean fnInsUpdT_Devolucion(BOT_Devolucion poBOT_Devolucion)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[6];
			par[0] = new SqlParameter("@Codigo_Devolucion",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Devolucion.Codigo_Devolucion);
			par[1] = new SqlParameter("@Codigo_Orden_Acondicionamiento",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Devolucion.Codigo_Orden_Acondicionamiento);
			par[2] = new SqlParameter("@Insumo",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[2],poBOT_Devolucion.Insumo);
			par[3] = new SqlParameter("@Numero_Analisis",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[3],poBOT_Devolucion.Numero_Analisis);
			par[4] = new SqlParameter("@Cantidad",System.Data.SqlDbType.VarChar,20);
			ValidateAndInsertValue(par[4],poBOT_Devolucion.Cantidad);
			par[5] = new SqlParameter("@Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[5],poBOT_Devolucion.Fecha);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsUpdT_Devolucion", par);
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
		public Boolean fnDelT_Devolucion(String psCodigo_Devolucion)
		{
			Boolean lbResultado=true;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			SqlParameter[] par = new SqlParameter[1];
			//cambiar aca:
			par[0] = new SqlParameter("@Codigo_Devolucion",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Devolucion;
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_DelT_Devolucion", par);
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

		public List<BOT_Devolucion> fnSelT_DevolucionAll()
		{
			List<BOT_Devolucion> loList = new List<BOT_Devolucion>();
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_DevolucionsAll");
				while (loDr.Read())
                {
					BOT_Devolucion loBOT_Devolucion=new BOT_Devolucion();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Devolucion"));
					loBOT_Devolucion.Codigo_Devolucion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Orden_Acondicionamiento"));
					loBOT_Devolucion.Codigo_Orden_Acondicionamiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Insumo"));
					loBOT_Devolucion.Insumo = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Numero_Analisis"));
					loBOT_Devolucion.Numero_Analisis = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad"));
					loBOT_Devolucion.Cantidad = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Fecha"));
					loBOT_Devolucion.Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
                    loList.Add(loBOT_Devolucion);
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

		public BOT_Devolucion fnSelT_Devolucion(String psCodigo_Devolucion)
		{
			BOT_Devolucion loBOT_Devolucion = new BOT_Devolucion();
			//parametros
			
			SqlParameter[] par = new SqlParameter[1];
			par[0] = new SqlParameter("@Codigo_Devolucion",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Devolucion;
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Devolucion", par);
				while(loDr.Read()){//----------------------------------------------------- AQUI
					if (loDr != null)
					{
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Devolucion"));
					loBOT_Devolucion.Codigo_Devolucion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Orden_Acondicionamiento"));
					loBOT_Devolucion.Codigo_Orden_Acondicionamiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Insumo"));
					loBOT_Devolucion.Insumo = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Numero_Analisis"));
					loBOT_Devolucion.Numero_Analisis = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad"));
					loBOT_Devolucion.Cantidad = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Fecha"));
					loBOT_Devolucion.Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
						
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
			return loBOT_Devolucion;
		}
		public List<BOT_Devolucion> fnSelT_DevolucionDin(string psWhere,string psOrder)
		{
			List<BOT_Devolucion> loList = new List<BOT_Devolucion>();
			SqlParameter[] par = new SqlParameter[2];
			par[0] = new SqlParameter("@WhereCondition",System.Data.SqlDbType.VarChar,500);
			par[0].Value= psWhere;
			par[1] = new SqlParameter("@OrderByExpression",System.Data.SqlDbType.VarChar,250);
			par[1].Value= psOrder;
			object value;//------------------------- 1
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_DevolucionsDin",par);
				while (loDr.Read())
                {
					BOT_Devolucion loBOT_Devolucion=new BOT_Devolucion();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Devolucion"));
					loBOT_Devolucion.Codigo_Devolucion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Orden_Acondicionamiento"));
					loBOT_Devolucion.Codigo_Orden_Acondicionamiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Insumo"));
					loBOT_Devolucion.Insumo = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Numero_Analisis"));
					loBOT_Devolucion.Numero_Analisis = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad"));
					loBOT_Devolucion.Cantidad = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Fecha"));
					loBOT_Devolucion.Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
                    loList.Add(loBOT_Devolucion);
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
		public Int32[] fnSelT_DevolucionMinMax()
        {
            Int32[] laMinMax=new Int32[2];
            try
			{
                SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_DevolucionMinMax");
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

