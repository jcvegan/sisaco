using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using BO_SISACO;

namespace BDA_SISACO
{	
	public partial class BDAT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones:BDABase
	{
		public Boolean fnInsT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones(BOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones poBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[8];
			par[0] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Codigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones);
			par[1] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Codigo_Registro_Empaque_Despeje_Linea);
			par[2] = new SqlParameter("@Equipos_Instalaciones_Limpios",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[2],poBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Limpios);
			par[3] = new SqlParameter("@Equipos_Instalaciones_Identificados",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[3],poBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Identificados);
			par[4] = new SqlParameter("@Equipos_Instalaciones_Balanzas_Calibradas_Verificadas",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[4],poBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Balanzas_Calibradas_Verificadas);
			par[5] = new SqlParameter("@Equipos_Instalaciones_Humedad_Relativa",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[5],poBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Humedad_Relativa);
			par[6] = new SqlParameter("@Equipos_Instalaciones_Diferencial_Presion",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[6],poBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Diferencial_Presion);
			par[7] = new SqlParameter("@Equipos_Instalaciones_Temperatura",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[7],poBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Temperatura);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones", par);
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
		public Boolean fnUpdT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones(BOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones poBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[8];
			par[0] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Codigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones);
			par[1] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Codigo_Registro_Empaque_Despeje_Linea);
			par[2] = new SqlParameter("@Equipos_Instalaciones_Limpios",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[2],poBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Limpios);
			par[3] = new SqlParameter("@Equipos_Instalaciones_Identificados",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[3],poBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Identificados);
			par[4] = new SqlParameter("@Equipos_Instalaciones_Balanzas_Calibradas_Verificadas",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[4],poBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Balanzas_Calibradas_Verificadas);
			par[5] = new SqlParameter("@Equipos_Instalaciones_Humedad_Relativa",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[5],poBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Humedad_Relativa);
			par[6] = new SqlParameter("@Equipos_Instalaciones_Diferencial_Presion",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[6],poBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Diferencial_Presion);
			par[7] = new SqlParameter("@Equipos_Instalaciones_Temperatura",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[7],poBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Temperatura);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_UpdT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones", par);
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

		public Boolean fnInsUpdT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones(BOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones poBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[8];
			par[0] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Codigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones);
			par[1] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Codigo_Registro_Empaque_Despeje_Linea);
			par[2] = new SqlParameter("@Equipos_Instalaciones_Limpios",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[2],poBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Limpios);
			par[3] = new SqlParameter("@Equipos_Instalaciones_Identificados",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[3],poBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Identificados);
			par[4] = new SqlParameter("@Equipos_Instalaciones_Balanzas_Calibradas_Verificadas",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[4],poBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Balanzas_Calibradas_Verificadas);
			par[5] = new SqlParameter("@Equipos_Instalaciones_Humedad_Relativa",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[5],poBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Humedad_Relativa);
			par[6] = new SqlParameter("@Equipos_Instalaciones_Diferencial_Presion",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[6],poBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Diferencial_Presion);
			par[7] = new SqlParameter("@Equipos_Instalaciones_Temperatura",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[7],poBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Temperatura);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsUpdT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones", par);
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
		public Boolean fnDelT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones(String psCodigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones)
		{
			Boolean lbResultado=true;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			SqlParameter[] par = new SqlParameter[1];
			//cambiar aca:
			par[0] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones;
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_DelT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones", par);
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

		public List<BOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones> fnSelT_Registro_Empaque_Despeje_Linea_Equipos_InstalacionesAll()
		{
			List<BOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones> loList = new List<BOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones>();
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Empaque_Despeje_Linea_Equipos_InstalacionessAll");
				while (loDr.Read())
                {
					BOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones loBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones=new BOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones"));
					loBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Codigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea"));
					loBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Codigo_Registro_Empaque_Despeje_Linea = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Equipos_Instalaciones_Limpios"));
					loBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Limpios = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Equipos_Instalaciones_Identificados"));
					loBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Identificados = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Equipos_Instalaciones_Balanzas_Calibradas_Verificadas"));
					loBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Balanzas_Calibradas_Verificadas = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Equipos_Instalaciones_Humedad_Relativa"));
					loBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Humedad_Relativa = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Equipos_Instalaciones_Diferencial_Presion"));
					loBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Diferencial_Presion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Equipos_Instalaciones_Temperatura"));
					loBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Temperatura = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones);
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

		public BOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones fnSelT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones(String psCodigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones)
		{
			BOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones loBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones = new BOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones();
			//parametros
			
			SqlParameter[] par = new SqlParameter[1];
			par[0] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones;
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones", par);
				while(loDr.Read()){//----------------------------------------------------- AQUI
					if (loDr != null)
					{
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones"));
					loBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Codigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea"));
					loBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Codigo_Registro_Empaque_Despeje_Linea = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Equipos_Instalaciones_Limpios"));
					loBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Limpios = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Equipos_Instalaciones_Identificados"));
					loBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Identificados = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Equipos_Instalaciones_Balanzas_Calibradas_Verificadas"));
					loBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Balanzas_Calibradas_Verificadas = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Equipos_Instalaciones_Humedad_Relativa"));
					loBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Humedad_Relativa = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Equipos_Instalaciones_Diferencial_Presion"));
					loBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Diferencial_Presion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Equipos_Instalaciones_Temperatura"));
					loBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Temperatura = value != System.DBNull.Value ? (String)value : default(String);
						
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
			return loBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones;
		}
		public List<BOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones> fnSelT_Registro_Empaque_Despeje_Linea_Equipos_InstalacionesDin(string psWhere,string psOrder)
		{
			List<BOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones> loList = new List<BOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones>();
			SqlParameter[] par = new SqlParameter[2];
			par[0] = new SqlParameter("@WhereCondition",System.Data.SqlDbType.VarChar,500);
			par[0].Value= psWhere;
			par[1] = new SqlParameter("@OrderByExpression",System.Data.SqlDbType.VarChar,250);
			par[1].Value= psOrder;
			object value;//------------------------- 1
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Empaque_Despeje_Linea_Equipos_InstalacionessDin",par);
				while (loDr.Read())
                {
					BOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones loBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones=new BOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones"));
					loBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Codigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea"));
					loBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Codigo_Registro_Empaque_Despeje_Linea = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Equipos_Instalaciones_Limpios"));
					loBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Limpios = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Equipos_Instalaciones_Identificados"));
					loBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Identificados = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Equipos_Instalaciones_Balanzas_Calibradas_Verificadas"));
					loBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Balanzas_Calibradas_Verificadas = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Equipos_Instalaciones_Humedad_Relativa"));
					loBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Humedad_Relativa = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Equipos_Instalaciones_Diferencial_Presion"));
					loBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Diferencial_Presion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Equipos_Instalaciones_Temperatura"));
					loBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Temperatura = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones);
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
		public Int32[] fnSelT_Registro_Empaque_Despeje_Linea_Equipos_InstalacionesMinMax()
        {
            Int32[] laMinMax=new Int32[2];
            try
			{
                SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Empaque_Despeje_Linea_Equipos_InstalacionesMinMax");
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

