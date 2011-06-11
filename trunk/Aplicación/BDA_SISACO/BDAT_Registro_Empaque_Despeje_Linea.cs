using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using BO_SISACO;

namespace BDA_SISACO
{	
	public partial class BDAT_Registro_Empaque_Despeje_Linea:BDABase
	{
		public Boolean fnInsT_Registro_Empaque_Despeje_Linea(BOT_Registro_Empaque_Despeje_Linea poBOT_Registro_Empaque_Despeje_Linea)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[9];
			par[0] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea);
			par[1] = new SqlParameter("@Codigo_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Registro_Empaque_Despeje_Linea.Codigo_Empaque);
			par[2] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea_Area",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[2],poBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea_Area);
			par[3] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[3],poBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones);
			par[4] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea_Documentacion",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[4],poBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea_Documentacion);
			par[5] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea_Materiales_Insumos",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[5],poBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea_Materiales_Insumos);
			par[6] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea_Personal",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[6],poBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea_Personal);
			par[7] = new SqlParameter("@Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[7],poBOT_Registro_Empaque_Despeje_Linea.Fecha);
			par[8] = new SqlParameter("@Hora",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[8],poBOT_Registro_Empaque_Despeje_Linea.Hora);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsT_Registro_Empaque_Despeje_Linea", par);
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
		public Boolean fnUpdT_Registro_Empaque_Despeje_Linea(BOT_Registro_Empaque_Despeje_Linea poBOT_Registro_Empaque_Despeje_Linea)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[9];
			par[0] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea);
			par[1] = new SqlParameter("@Codigo_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Registro_Empaque_Despeje_Linea.Codigo_Empaque);
			par[2] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea_Area",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[2],poBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea_Area);
			par[3] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[3],poBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones);
			par[4] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea_Documentacion",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[4],poBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea_Documentacion);
			par[5] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea_Materiales_Insumos",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[5],poBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea_Materiales_Insumos);
			par[6] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea_Personal",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[6],poBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea_Personal);
			par[7] = new SqlParameter("@Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[7],poBOT_Registro_Empaque_Despeje_Linea.Fecha);
			par[8] = new SqlParameter("@Hora",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[8],poBOT_Registro_Empaque_Despeje_Linea.Hora);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_UpdT_Registro_Empaque_Despeje_Linea", par);
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

		public Boolean fnInsUpdT_Registro_Empaque_Despeje_Linea(BOT_Registro_Empaque_Despeje_Linea poBOT_Registro_Empaque_Despeje_Linea)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[9];
			par[0] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea);
			par[1] = new SqlParameter("@Codigo_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Registro_Empaque_Despeje_Linea.Codigo_Empaque);
			par[2] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea_Area",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[2],poBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea_Area);
			par[3] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[3],poBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones);
			par[4] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea_Documentacion",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[4],poBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea_Documentacion);
			par[5] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea_Materiales_Insumos",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[5],poBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea_Materiales_Insumos);
			par[6] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea_Personal",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[6],poBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea_Personal);
			par[7] = new SqlParameter("@Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[7],poBOT_Registro_Empaque_Despeje_Linea.Fecha);
			par[8] = new SqlParameter("@Hora",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[8],poBOT_Registro_Empaque_Despeje_Linea.Hora);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsUpdT_Registro_Empaque_Despeje_Linea", par);
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
		public Boolean fnDelT_Registro_Empaque_Despeje_Linea(String psCodigo_Registro_Empaque_Despeje_Linea)
		{
			Boolean lbResultado=true;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			SqlParameter[] par = new SqlParameter[1];
			//cambiar aca:
			par[0] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Registro_Empaque_Despeje_Linea;
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_DelT_Registro_Empaque_Despeje_Linea", par);
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

		public List<BOT_Registro_Empaque_Despeje_Linea> fnSelT_Registro_Empaque_Despeje_LineaAll()
		{
			List<BOT_Registro_Empaque_Despeje_Linea> loList = new List<BOT_Registro_Empaque_Despeje_Linea>();
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Empaque_Despeje_LineasAll");
				while (loDr.Read())
                {
					BOT_Registro_Empaque_Despeje_Linea loBOT_Registro_Empaque_Despeje_Linea=new BOT_Registro_Empaque_Despeje_Linea();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea"));
					loBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Empaque"));
					loBOT_Registro_Empaque_Despeje_Linea.Codigo_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea_Area"));
					loBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea_Area = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones"));
					loBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea_Documentacion"));
					loBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea_Documentacion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea_Materiales_Insumos"));
					loBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea_Materiales_Insumos = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea_Personal"));
					loBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea_Personal = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Fecha"));
					loBOT_Registro_Empaque_Despeje_Linea.Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Hora"));
					loBOT_Registro_Empaque_Despeje_Linea.Hora = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Registro_Empaque_Despeje_Linea);
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

		public BOT_Registro_Empaque_Despeje_Linea fnSelT_Registro_Empaque_Despeje_Linea(String psCodigo_Registro_Empaque_Despeje_Linea)
		{
			BOT_Registro_Empaque_Despeje_Linea loBOT_Registro_Empaque_Despeje_Linea = new BOT_Registro_Empaque_Despeje_Linea();
			//parametros
			
			SqlParameter[] par = new SqlParameter[1];
			par[0] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Registro_Empaque_Despeje_Linea;
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Empaque_Despeje_Linea", par);
				while(loDr.Read()){//----------------------------------------------------- AQUI
					if (loDr != null)
					{
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea"));
					loBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Empaque"));
					loBOT_Registro_Empaque_Despeje_Linea.Codigo_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea_Area"));
					loBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea_Area = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones"));
					loBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea_Documentacion"));
					loBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea_Documentacion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea_Materiales_Insumos"));
					loBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea_Materiales_Insumos = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea_Personal"));
					loBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea_Personal = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Fecha"));
					loBOT_Registro_Empaque_Despeje_Linea.Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Hora"));
					loBOT_Registro_Empaque_Despeje_Linea.Hora = value != System.DBNull.Value ? (String)value : default(String);
						
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
			return loBOT_Registro_Empaque_Despeje_Linea;
		}
		public List<BOT_Registro_Empaque_Despeje_Linea> fnSelT_Registro_Empaque_Despeje_LineaDin(string psWhere,string psOrder)
		{
			List<BOT_Registro_Empaque_Despeje_Linea> loList = new List<BOT_Registro_Empaque_Despeje_Linea>();
			SqlParameter[] par = new SqlParameter[2];
			par[0] = new SqlParameter("@WhereCondition",System.Data.SqlDbType.VarChar,500);
			par[0].Value= psWhere;
			par[1] = new SqlParameter("@OrderByExpression",System.Data.SqlDbType.VarChar,250);
			par[1].Value= psOrder;
			object value;//------------------------- 1
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Empaque_Despeje_LineasDin",par);
				while (loDr.Read())
                {
					BOT_Registro_Empaque_Despeje_Linea loBOT_Registro_Empaque_Despeje_Linea=new BOT_Registro_Empaque_Despeje_Linea();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea"));
					loBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Empaque"));
					loBOT_Registro_Empaque_Despeje_Linea.Codigo_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea_Area"));
					loBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea_Area = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones"));
					loBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea_Documentacion"));
					loBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea_Documentacion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea_Materiales_Insumos"));
					loBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea_Materiales_Insumos = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea_Personal"));
					loBOT_Registro_Empaque_Despeje_Linea.Codigo_Registro_Empaque_Despeje_Linea_Personal = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Fecha"));
					loBOT_Registro_Empaque_Despeje_Linea.Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Hora"));
					loBOT_Registro_Empaque_Despeje_Linea.Hora = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Registro_Empaque_Despeje_Linea);
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
		public Int32[] fnSelT_Registro_Empaque_Despeje_LineaMinMax()
        {
            Int32[] laMinMax=new Int32[2];
            try
			{
                SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Empaque_Despeje_LineaMinMax");
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

