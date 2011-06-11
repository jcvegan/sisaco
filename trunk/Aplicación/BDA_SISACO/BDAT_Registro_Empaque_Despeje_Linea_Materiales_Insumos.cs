using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using BO_SISACO;

namespace BDA_SISACO
{	
	public partial class BDAT_Registro_Empaque_Despeje_Linea_Materiales_Insumos:BDABase
	{
		public Boolean fnInsT_Registro_Empaque_Despeje_Linea_Materiales_Insumos(BOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos poBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[5];
			par[0] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea_Materiales_Insumos",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos.Codigo_Registro_Empaque_Despeje_Linea_Materiales_Insumos);
			par[1] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos.Codigo_Registro_Empaque_Despeje_Linea);
			par[2] = new SqlParameter("@Materiales_Insumos_Identificados",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[2],poBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos.Materiales_Insumos_Identificados);
			par[3] = new SqlParameter("@Materiales_Insumos_Verificados",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[3],poBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos.Materiales_Insumos_Verificados);
			par[4] = new SqlParameter("@Materiales_Insumos_Sobre_Parihuelas",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[4],poBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos.Materiales_Insumos_Sobre_Parihuelas);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsT_Registro_Empaque_Despeje_Linea_Materiales_Insumos", par);
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
		public Boolean fnUpdT_Registro_Empaque_Despeje_Linea_Materiales_Insumos(BOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos poBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[5];
			par[0] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea_Materiales_Insumos",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos.Codigo_Registro_Empaque_Despeje_Linea_Materiales_Insumos);
			par[1] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos.Codigo_Registro_Empaque_Despeje_Linea);
			par[2] = new SqlParameter("@Materiales_Insumos_Identificados",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[2],poBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos.Materiales_Insumos_Identificados);
			par[3] = new SqlParameter("@Materiales_Insumos_Verificados",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[3],poBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos.Materiales_Insumos_Verificados);
			par[4] = new SqlParameter("@Materiales_Insumos_Sobre_Parihuelas",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[4],poBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos.Materiales_Insumos_Sobre_Parihuelas);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_UpdT_Registro_Empaque_Despeje_Linea_Materiales_Insumos", par);
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

		public Boolean fnInsUpdT_Registro_Empaque_Despeje_Linea_Materiales_Insumos(BOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos poBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[5];
			par[0] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea_Materiales_Insumos",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos.Codigo_Registro_Empaque_Despeje_Linea_Materiales_Insumos);
			par[1] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos.Codigo_Registro_Empaque_Despeje_Linea);
			par[2] = new SqlParameter("@Materiales_Insumos_Identificados",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[2],poBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos.Materiales_Insumos_Identificados);
			par[3] = new SqlParameter("@Materiales_Insumos_Verificados",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[3],poBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos.Materiales_Insumos_Verificados);
			par[4] = new SqlParameter("@Materiales_Insumos_Sobre_Parihuelas",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[4],poBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos.Materiales_Insumos_Sobre_Parihuelas);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsUpdT_Registro_Empaque_Despeje_Linea_Materiales_Insumos", par);
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
		public Boolean fnDelT_Registro_Empaque_Despeje_Linea_Materiales_Insumos(String psCodigo_Registro_Empaque_Despeje_Linea_Materiales_Insumos)
		{
			Boolean lbResultado=true;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			SqlParameter[] par = new SqlParameter[1];
			//cambiar aca:
			par[0] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea_Materiales_Insumos",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Registro_Empaque_Despeje_Linea_Materiales_Insumos;
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_DelT_Registro_Empaque_Despeje_Linea_Materiales_Insumos", par);
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

		public List<BOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos> fnSelT_Registro_Empaque_Despeje_Linea_Materiales_InsumosAll()
		{
			List<BOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos> loList = new List<BOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos>();
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Empaque_Despeje_Linea_Materiales_InsumossAll");
				while (loDr.Read())
                {
					BOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos loBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos=new BOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea_Materiales_Insumos"));
					loBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos.Codigo_Registro_Empaque_Despeje_Linea_Materiales_Insumos = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea"));
					loBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos.Codigo_Registro_Empaque_Despeje_Linea = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Materiales_Insumos_Identificados"));
					loBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos.Materiales_Insumos_Identificados = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Materiales_Insumos_Verificados"));
					loBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos.Materiales_Insumos_Verificados = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Materiales_Insumos_Sobre_Parihuelas"));
					loBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos.Materiales_Insumos_Sobre_Parihuelas = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos);
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

		public BOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos fnSelT_Registro_Empaque_Despeje_Linea_Materiales_Insumos(String psCodigo_Registro_Empaque_Despeje_Linea_Materiales_Insumos)
		{
			BOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos loBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos = new BOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos();
			//parametros
			
			SqlParameter[] par = new SqlParameter[1];
			par[0] = new SqlParameter("@Codigo_Registro_Empaque_Despeje_Linea_Materiales_Insumos",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Registro_Empaque_Despeje_Linea_Materiales_Insumos;
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Empaque_Despeje_Linea_Materiales_Insumos", par);
				while(loDr.Read()){//----------------------------------------------------- AQUI
					if (loDr != null)
					{
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea_Materiales_Insumos"));
					loBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos.Codigo_Registro_Empaque_Despeje_Linea_Materiales_Insumos = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea"));
					loBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos.Codigo_Registro_Empaque_Despeje_Linea = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Materiales_Insumos_Identificados"));
					loBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos.Materiales_Insumos_Identificados = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Materiales_Insumos_Verificados"));
					loBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos.Materiales_Insumos_Verificados = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Materiales_Insumos_Sobre_Parihuelas"));
					loBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos.Materiales_Insumos_Sobre_Parihuelas = value != System.DBNull.Value ? (String)value : default(String);
						
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
			return loBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos;
		}
		public List<BOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos> fnSelT_Registro_Empaque_Despeje_Linea_Materiales_InsumosDin(string psWhere,string psOrder)
		{
			List<BOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos> loList = new List<BOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos>();
			SqlParameter[] par = new SqlParameter[2];
			par[0] = new SqlParameter("@WhereCondition",System.Data.SqlDbType.VarChar,500);
			par[0].Value= psWhere;
			par[1] = new SqlParameter("@OrderByExpression",System.Data.SqlDbType.VarChar,250);
			par[1].Value= psOrder;
			object value;//------------------------- 1
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Empaque_Despeje_Linea_Materiales_InsumossDin",par);
				while (loDr.Read())
                {
					BOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos loBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos=new BOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea_Materiales_Insumos"));
					loBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos.Codigo_Registro_Empaque_Despeje_Linea_Materiales_Insumos = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Despeje_Linea"));
					loBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos.Codigo_Registro_Empaque_Despeje_Linea = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Materiales_Insumos_Identificados"));
					loBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos.Materiales_Insumos_Identificados = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Materiales_Insumos_Verificados"));
					loBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos.Materiales_Insumos_Verificados = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Materiales_Insumos_Sobre_Parihuelas"));
					loBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos.Materiales_Insumos_Sobre_Parihuelas = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos);
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
		public Int32[] fnSelT_Registro_Empaque_Despeje_Linea_Materiales_InsumosMinMax()
        {
            Int32[] laMinMax=new Int32[2];
            try
			{
                SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Empaque_Despeje_Linea_Materiales_InsumosMinMax");
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

