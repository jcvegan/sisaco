using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using BO_SISACO;

namespace BDA_SISACO
{	
	public partial class BDAT_Registro_Codificacion_Codificacion_Cajas:BDABase
	{
		public Boolean fnInsT_Registro_Codificacion_Codificacion_Cajas(BOT_Registro_Codificacion_Codificacion_Cajas poBOT_Registro_Codificacion_Codificacion_Cajas)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[9];
			par[0] = new SqlParameter("@Codigo_Registro_Codificacion_Codificacion_Cajas",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Registro_Codificacion_Codificacion_Cajas.Codigo_Registro_Codificacion_Codificacion_Cajas);
			par[1] = new SqlParameter("@Codigo_Registro_Codificacion",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Registro_Codificacion_Codificacion_Cajas.Codigo_Registro_Codificacion);
			par[2] = new SqlParameter("@Procedimiento_1_Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[2],poBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_1_Fecha);
			par[3] = new SqlParameter("@Procedimiento_2_Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[3],poBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_2_Fecha);
			par[4] = new SqlParameter("@Procedimiento_3_Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[4],poBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_3_Fecha);
			par[5] = new SqlParameter("@Procedimiento_4_Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[5],poBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_4_Fecha);
			par[6] = new SqlParameter("@Procedimiento_5_Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[6],poBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_5_Fecha);
			par[7] = new SqlParameter("@Procedimiento_6_Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[7],poBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_6_Fecha);
			par[8] = new SqlParameter("@Total_Material_Codificado",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[8],poBOT_Registro_Codificacion_Codificacion_Cajas.Total_Material_Codificado);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsT_Registro_Codificacion_Codificacion_Cajas", par);
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
		public Boolean fnUpdT_Registro_Codificacion_Codificacion_Cajas(BOT_Registro_Codificacion_Codificacion_Cajas poBOT_Registro_Codificacion_Codificacion_Cajas)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[9];
			par[0] = new SqlParameter("@Codigo_Registro_Codificacion_Codificacion_Cajas",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Registro_Codificacion_Codificacion_Cajas.Codigo_Registro_Codificacion_Codificacion_Cajas);
			par[1] = new SqlParameter("@Codigo_Registro_Codificacion",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Registro_Codificacion_Codificacion_Cajas.Codigo_Registro_Codificacion);
			par[2] = new SqlParameter("@Procedimiento_1_Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[2],poBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_1_Fecha);
			par[3] = new SqlParameter("@Procedimiento_2_Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[3],poBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_2_Fecha);
			par[4] = new SqlParameter("@Procedimiento_3_Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[4],poBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_3_Fecha);
			par[5] = new SqlParameter("@Procedimiento_4_Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[5],poBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_4_Fecha);
			par[6] = new SqlParameter("@Procedimiento_5_Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[6],poBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_5_Fecha);
			par[7] = new SqlParameter("@Procedimiento_6_Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[7],poBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_6_Fecha);
			par[8] = new SqlParameter("@Total_Material_Codificado",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[8],poBOT_Registro_Codificacion_Codificacion_Cajas.Total_Material_Codificado);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_UpdT_Registro_Codificacion_Codificacion_Cajas", par);
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

		public Boolean fnInsUpdT_Registro_Codificacion_Codificacion_Cajas(BOT_Registro_Codificacion_Codificacion_Cajas poBOT_Registro_Codificacion_Codificacion_Cajas)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[9];
			par[0] = new SqlParameter("@Codigo_Registro_Codificacion_Codificacion_Cajas",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Registro_Codificacion_Codificacion_Cajas.Codigo_Registro_Codificacion_Codificacion_Cajas);
			par[1] = new SqlParameter("@Codigo_Registro_Codificacion",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Registro_Codificacion_Codificacion_Cajas.Codigo_Registro_Codificacion);
			par[2] = new SqlParameter("@Procedimiento_1_Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[2],poBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_1_Fecha);
			par[3] = new SqlParameter("@Procedimiento_2_Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[3],poBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_2_Fecha);
			par[4] = new SqlParameter("@Procedimiento_3_Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[4],poBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_3_Fecha);
			par[5] = new SqlParameter("@Procedimiento_4_Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[5],poBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_4_Fecha);
			par[6] = new SqlParameter("@Procedimiento_5_Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[6],poBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_5_Fecha);
			par[7] = new SqlParameter("@Procedimiento_6_Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[7],poBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_6_Fecha);
			par[8] = new SqlParameter("@Total_Material_Codificado",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[8],poBOT_Registro_Codificacion_Codificacion_Cajas.Total_Material_Codificado);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsUpdT_Registro_Codificacion_Codificacion_Cajas", par);
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
		public Boolean fnDelT_Registro_Codificacion_Codificacion_Cajas(String psCodigo_Registro_Codificacion_Codificacion_Cajas)
		{
			Boolean lbResultado=true;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			SqlParameter[] par = new SqlParameter[1];
			//cambiar aca:
			par[0] = new SqlParameter("@Codigo_Registro_Codificacion_Codificacion_Cajas",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Registro_Codificacion_Codificacion_Cajas;
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_DelT_Registro_Codificacion_Codificacion_Cajas", par);
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

		public List<BOT_Registro_Codificacion_Codificacion_Cajas> fnSelT_Registro_Codificacion_Codificacion_CajasAll()
		{
			List<BOT_Registro_Codificacion_Codificacion_Cajas> loList = new List<BOT_Registro_Codificacion_Codificacion_Cajas>();
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Codificacion_Codificacion_CajassAll");
				while (loDr.Read())
                {
					BOT_Registro_Codificacion_Codificacion_Cajas loBOT_Registro_Codificacion_Codificacion_Cajas=new BOT_Registro_Codificacion_Codificacion_Cajas();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Codificacion_Codificacion_Cajas"));
					loBOT_Registro_Codificacion_Codificacion_Cajas.Codigo_Registro_Codificacion_Codificacion_Cajas = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Codificacion"));
					loBOT_Registro_Codificacion_Codificacion_Cajas.Codigo_Registro_Codificacion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Procedimiento_1_Fecha"));
					loBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_1_Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Procedimiento_2_Fecha"));
					loBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_2_Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Procedimiento_3_Fecha"));
					loBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_3_Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Procedimiento_4_Fecha"));
					loBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_4_Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Procedimiento_5_Fecha"));
					loBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_5_Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Procedimiento_6_Fecha"));
					loBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_6_Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Total_Material_Codificado"));
					loBOT_Registro_Codificacion_Codificacion_Cajas.Total_Material_Codificado = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Registro_Codificacion_Codificacion_Cajas);
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

		public BOT_Registro_Codificacion_Codificacion_Cajas fnSelT_Registro_Codificacion_Codificacion_Cajas(String psCodigo_Registro_Codificacion_Codificacion_Cajas)
		{
			BOT_Registro_Codificacion_Codificacion_Cajas loBOT_Registro_Codificacion_Codificacion_Cajas = new BOT_Registro_Codificacion_Codificacion_Cajas();
			//parametros
			
			SqlParameter[] par = new SqlParameter[1];
			par[0] = new SqlParameter("@Codigo_Registro_Codificacion_Codificacion_Cajas",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Registro_Codificacion_Codificacion_Cajas;
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Codificacion_Codificacion_Cajas", par);
				while(loDr.Read()){//----------------------------------------------------- AQUI
					if (loDr != null)
					{
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Codificacion_Codificacion_Cajas"));
					loBOT_Registro_Codificacion_Codificacion_Cajas.Codigo_Registro_Codificacion_Codificacion_Cajas = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Codificacion"));
					loBOT_Registro_Codificacion_Codificacion_Cajas.Codigo_Registro_Codificacion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Procedimiento_1_Fecha"));
					loBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_1_Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Procedimiento_2_Fecha"));
					loBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_2_Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Procedimiento_3_Fecha"));
					loBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_3_Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Procedimiento_4_Fecha"));
					loBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_4_Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Procedimiento_5_Fecha"));
					loBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_5_Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Procedimiento_6_Fecha"));
					loBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_6_Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Total_Material_Codificado"));
					loBOT_Registro_Codificacion_Codificacion_Cajas.Total_Material_Codificado = value != System.DBNull.Value ? (String)value : default(String);
						
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
			return loBOT_Registro_Codificacion_Codificacion_Cajas;
		}
		public List<BOT_Registro_Codificacion_Codificacion_Cajas> fnSelT_Registro_Codificacion_Codificacion_CajasDin(string psWhere,string psOrder)
		{
			List<BOT_Registro_Codificacion_Codificacion_Cajas> loList = new List<BOT_Registro_Codificacion_Codificacion_Cajas>();
			SqlParameter[] par = new SqlParameter[2];
			par[0] = new SqlParameter("@WhereCondition",System.Data.SqlDbType.VarChar,500);
			par[0].Value= psWhere;
			par[1] = new SqlParameter("@OrderByExpression",System.Data.SqlDbType.VarChar,250);
			par[1].Value= psOrder;
			object value;//------------------------- 1
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Codificacion_Codificacion_CajassDin",par);
				while (loDr.Read())
                {
					BOT_Registro_Codificacion_Codificacion_Cajas loBOT_Registro_Codificacion_Codificacion_Cajas=new BOT_Registro_Codificacion_Codificacion_Cajas();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Codificacion_Codificacion_Cajas"));
					loBOT_Registro_Codificacion_Codificacion_Cajas.Codigo_Registro_Codificacion_Codificacion_Cajas = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Codificacion"));
					loBOT_Registro_Codificacion_Codificacion_Cajas.Codigo_Registro_Codificacion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Procedimiento_1_Fecha"));
					loBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_1_Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Procedimiento_2_Fecha"));
					loBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_2_Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Procedimiento_3_Fecha"));
					loBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_3_Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Procedimiento_4_Fecha"));
					loBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_4_Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Procedimiento_5_Fecha"));
					loBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_5_Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Procedimiento_6_Fecha"));
					loBOT_Registro_Codificacion_Codificacion_Cajas.Procedimiento_6_Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Total_Material_Codificado"));
					loBOT_Registro_Codificacion_Codificacion_Cajas.Total_Material_Codificado = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Registro_Codificacion_Codificacion_Cajas);
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
		public Int32[] fnSelT_Registro_Codificacion_Codificacion_CajasMinMax()
        {
            Int32[] laMinMax=new Int32[2];
            try
			{
                SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Codificacion_Codificacion_CajasMinMax");
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

