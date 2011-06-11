using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using BO_SISACO;

namespace BDA_SISACO
{	
	public partial class BDAT_Registro_Codificacion_Despeje_Linea_Documentacion:BDABase
	{
		public Boolean fnInsT_Registro_Codificacion_Despeje_Linea_Documentacion(BOT_Registro_Codificacion_Despeje_Linea_Documentacion poBOT_Registro_Codificacion_Despeje_Linea_Documentacion)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[4];
			par[0] = new SqlParameter("@Codigo_Registro_Codificacion_Despeje_Linea_Documentacion",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Registro_Codificacion_Despeje_Linea_Documentacion.Codigo_Registro_Codificacion_Despeje_Linea_Documentacion);
			par[1] = new SqlParameter("@Codigo_Registro_Codificacion_Despeje_Linea",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Registro_Codificacion_Despeje_Linea_Documentacion.Codigo_Registro_Codificacion_Despeje_Linea);
			par[2] = new SqlParameter("@Documentacion_Registro_Manufactura",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[2],poBOT_Registro_Codificacion_Despeje_Linea_Documentacion.Documentacion_Registro_Manufactura);
			par[3] = new SqlParameter("@Documentacion_Etiquetas",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[3],poBOT_Registro_Codificacion_Despeje_Linea_Documentacion.Documentacion_Etiquetas);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsT_Registro_Codificacion_Despeje_Linea_Documentacion", par);
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
		public Boolean fnUpdT_Registro_Codificacion_Despeje_Linea_Documentacion(BOT_Registro_Codificacion_Despeje_Linea_Documentacion poBOT_Registro_Codificacion_Despeje_Linea_Documentacion)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[4];
			par[0] = new SqlParameter("@Codigo_Registro_Codificacion_Despeje_Linea_Documentacion",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Registro_Codificacion_Despeje_Linea_Documentacion.Codigo_Registro_Codificacion_Despeje_Linea_Documentacion);
			par[1] = new SqlParameter("@Codigo_Registro_Codificacion_Despeje_Linea",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Registro_Codificacion_Despeje_Linea_Documentacion.Codigo_Registro_Codificacion_Despeje_Linea);
			par[2] = new SqlParameter("@Documentacion_Registro_Manufactura",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[2],poBOT_Registro_Codificacion_Despeje_Linea_Documentacion.Documentacion_Registro_Manufactura);
			par[3] = new SqlParameter("@Documentacion_Etiquetas",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[3],poBOT_Registro_Codificacion_Despeje_Linea_Documentacion.Documentacion_Etiquetas);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_UpdT_Registro_Codificacion_Despeje_Linea_Documentacion", par);
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

		public Boolean fnInsUpdT_Registro_Codificacion_Despeje_Linea_Documentacion(BOT_Registro_Codificacion_Despeje_Linea_Documentacion poBOT_Registro_Codificacion_Despeje_Linea_Documentacion,out string codigo_registro_codificacion_despeje_linea_documentacion)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[4];
			par[0] = new SqlParameter("@Codigo_Registro_Codificacion_Despeje_Linea_Documentacion",System.Data.SqlDbType.VarChar,10);
            par[0].Direction = ParameterDirection.Output;
			ValidateAndInsertValue(par[0],poBOT_Registro_Codificacion_Despeje_Linea_Documentacion.Codigo_Registro_Codificacion_Despeje_Linea_Documentacion);
			par[1] = new SqlParameter("@Codigo_Registro_Codificacion_Despeje_Linea",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Registro_Codificacion_Despeje_Linea_Documentacion.Codigo_Registro_Codificacion_Despeje_Linea);
			par[2] = new SqlParameter("@Documentacion_Registro_Manufactura",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[2],poBOT_Registro_Codificacion_Despeje_Linea_Documentacion.Documentacion_Registro_Manufactura);
			par[3] = new SqlParameter("@Documentacion_Etiquetas",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[3],poBOT_Registro_Codificacion_Despeje_Linea_Documentacion.Documentacion_Etiquetas);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsUpdT_Registro_Codificacion_Despeje_Linea_Documentacion", par);
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
                codigo_registro_codificacion_despeje_linea_documentacion = par[0].Value.ToString();
			}

			return lbResultado;
		}
		public Boolean fnDelT_Registro_Codificacion_Despeje_Linea_Documentacion(String psCodigo_Registro_Codificacion_Despeje_Linea_Documentacion)
		{
			Boolean lbResultado=true;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			SqlParameter[] par = new SqlParameter[1];
			//cambiar aca:
			par[0] = new SqlParameter("@Codigo_Registro_Codificacion_Despeje_Linea_Documentacion",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Registro_Codificacion_Despeje_Linea_Documentacion;
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_DelT_Registro_Codificacion_Despeje_Linea_Documentacion", par);
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

		public List<BOT_Registro_Codificacion_Despeje_Linea_Documentacion> fnSelT_Registro_Codificacion_Despeje_Linea_DocumentacionAll()
		{
			List<BOT_Registro_Codificacion_Despeje_Linea_Documentacion> loList = new List<BOT_Registro_Codificacion_Despeje_Linea_Documentacion>();
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Codificacion_Despeje_Linea_DocumentacionsAll");
				while (loDr.Read())
                {
					BOT_Registro_Codificacion_Despeje_Linea_Documentacion loBOT_Registro_Codificacion_Despeje_Linea_Documentacion=new BOT_Registro_Codificacion_Despeje_Linea_Documentacion();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Codificacion_Despeje_Linea_Documentacion"));
					loBOT_Registro_Codificacion_Despeje_Linea_Documentacion.Codigo_Registro_Codificacion_Despeje_Linea_Documentacion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Codificacion_Despeje_Linea"));
					loBOT_Registro_Codificacion_Despeje_Linea_Documentacion.Codigo_Registro_Codificacion_Despeje_Linea = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Documentacion_Registro_Manufactura"));
					loBOT_Registro_Codificacion_Despeje_Linea_Documentacion.Documentacion_Registro_Manufactura = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Documentacion_Etiquetas"));
					loBOT_Registro_Codificacion_Despeje_Linea_Documentacion.Documentacion_Etiquetas = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Registro_Codificacion_Despeje_Linea_Documentacion);
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

		public BOT_Registro_Codificacion_Despeje_Linea_Documentacion fnSelT_Registro_Codificacion_Despeje_Linea_Documentacion(String psCodigo_Registro_Codificacion_Despeje_Linea_Documentacion)
		{
			BOT_Registro_Codificacion_Despeje_Linea_Documentacion loBOT_Registro_Codificacion_Despeje_Linea_Documentacion = new BOT_Registro_Codificacion_Despeje_Linea_Documentacion();
			//parametros
			
			SqlParameter[] par = new SqlParameter[1];
			par[0] = new SqlParameter("@Codigo_Registro_Codificacion_Despeje_Linea_Documentacion",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Registro_Codificacion_Despeje_Linea_Documentacion;
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Codificacion_Despeje_Linea_Documentacion", par);
				while(loDr.Read()){//----------------------------------------------------- AQUI
					if (loDr != null)
					{
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Codificacion_Despeje_Linea_Documentacion"));
					loBOT_Registro_Codificacion_Despeje_Linea_Documentacion.Codigo_Registro_Codificacion_Despeje_Linea_Documentacion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Codificacion_Despeje_Linea"));
					loBOT_Registro_Codificacion_Despeje_Linea_Documentacion.Codigo_Registro_Codificacion_Despeje_Linea = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Documentacion_Registro_Manufactura"));
					loBOT_Registro_Codificacion_Despeje_Linea_Documentacion.Documentacion_Registro_Manufactura = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Documentacion_Etiquetas"));
					loBOT_Registro_Codificacion_Despeje_Linea_Documentacion.Documentacion_Etiquetas = value != System.DBNull.Value ? (String)value : default(String);
						
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
			return loBOT_Registro_Codificacion_Despeje_Linea_Documentacion;
		}
		public List<BOT_Registro_Codificacion_Despeje_Linea_Documentacion> fnSelT_Registro_Codificacion_Despeje_Linea_DocumentacionDin(string psWhere,string psOrder)
		{
			List<BOT_Registro_Codificacion_Despeje_Linea_Documentacion> loList = new List<BOT_Registro_Codificacion_Despeje_Linea_Documentacion>();
			SqlParameter[] par = new SqlParameter[2];
			par[0] = new SqlParameter("@WhereCondition",System.Data.SqlDbType.VarChar,500);
			par[0].Value= psWhere;
			par[1] = new SqlParameter("@OrderByExpression",System.Data.SqlDbType.VarChar,250);
			par[1].Value= psOrder;
			object value;//------------------------- 1
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Codificacion_Despeje_Linea_DocumentacionsDin",par);
				while (loDr.Read())
                {
					BOT_Registro_Codificacion_Despeje_Linea_Documentacion loBOT_Registro_Codificacion_Despeje_Linea_Documentacion=new BOT_Registro_Codificacion_Despeje_Linea_Documentacion();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Codificacion_Despeje_Linea_Documentacion"));
					loBOT_Registro_Codificacion_Despeje_Linea_Documentacion.Codigo_Registro_Codificacion_Despeje_Linea_Documentacion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Codificacion_Despeje_Linea"));
					loBOT_Registro_Codificacion_Despeje_Linea_Documentacion.Codigo_Registro_Codificacion_Despeje_Linea = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Documentacion_Registro_Manufactura"));
					loBOT_Registro_Codificacion_Despeje_Linea_Documentacion.Documentacion_Registro_Manufactura = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Documentacion_Etiquetas"));
					loBOT_Registro_Codificacion_Despeje_Linea_Documentacion.Documentacion_Etiquetas = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Registro_Codificacion_Despeje_Linea_Documentacion);
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
		public Int32[] fnSelT_Registro_Codificacion_Despeje_Linea_DocumentacionMinMax()
        {
            Int32[] laMinMax=new Int32[2];
            try
			{
                SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Codificacion_Despeje_Linea_DocumentacionMinMax");
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

