using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using BO_SISACO;

namespace BDA_SISACO
{	
	public partial class BDAT_Registro_Empaque_Procedimiento:BDABase
	{
		public Boolean fnInsT_Registro_Empaque_Procedimiento(BOT_Registro_Empaque_Procedimiento poBOT_Registro_Empaque_Procedimiento)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[10];
			par[0] = new SqlParameter("@Codigo_Registro_Empaque_Procedimiento",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Registro_Empaque_Procedimiento.Codigo_Registro_Empaque_Procedimiento);
			par[1] = new SqlParameter("@Codigo_Registro_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Registro_Empaque_Procedimiento.Codigo_Registro_Empaque);
			par[2] = new SqlParameter("@Procedimiento_1_Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[2],poBOT_Registro_Empaque_Procedimiento.Procedimiento_1_Fecha);
			par[3] = new SqlParameter("@Procedimiento_2_Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[3],poBOT_Registro_Empaque_Procedimiento.Procedimiento_2_Fecha);
			par[4] = new SqlParameter("@Procedimiento_3_Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[4],poBOT_Registro_Empaque_Procedimiento.Procedimiento_3_Fecha);
			par[5] = new SqlParameter("@Procedimiento_4_Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[5],poBOT_Registro_Empaque_Procedimiento.Procedimiento_4_Fecha);
			par[6] = new SqlParameter("@Procedimiento_5_Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[6],poBOT_Registro_Empaque_Procedimiento.Procedimiento_5_Fecha);
			par[7] = new SqlParameter("@Numero_Lote",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[7],poBOT_Registro_Empaque_Procedimiento.Numero_Lote);
			par[8] = new SqlParameter("@Fecha_Vencimiento",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[8],poBOT_Registro_Empaque_Procedimiento.Fecha_Vencimiento);
			par[9] = new SqlParameter("@Cantidad_Cajas",System.Data.SqlDbType.Int);
			ValidateAndInsertValue(par[9],poBOT_Registro_Empaque_Procedimiento.Cantidad_Cajas);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsT_Registro_Empaque_Procedimiento", par);
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
		public Boolean fnUpdT_Registro_Empaque_Procedimiento(BOT_Registro_Empaque_Procedimiento poBOT_Registro_Empaque_Procedimiento)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[10];
			par[0] = new SqlParameter("@Codigo_Registro_Empaque_Procedimiento",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Registro_Empaque_Procedimiento.Codigo_Registro_Empaque_Procedimiento);
			par[1] = new SqlParameter("@Codigo_Registro_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Registro_Empaque_Procedimiento.Codigo_Registro_Empaque);
			par[2] = new SqlParameter("@Procedimiento_1_Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[2],poBOT_Registro_Empaque_Procedimiento.Procedimiento_1_Fecha);
			par[3] = new SqlParameter("@Procedimiento_2_Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[3],poBOT_Registro_Empaque_Procedimiento.Procedimiento_2_Fecha);
			par[4] = new SqlParameter("@Procedimiento_3_Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[4],poBOT_Registro_Empaque_Procedimiento.Procedimiento_3_Fecha);
			par[5] = new SqlParameter("@Procedimiento_4_Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[5],poBOT_Registro_Empaque_Procedimiento.Procedimiento_4_Fecha);
			par[6] = new SqlParameter("@Procedimiento_5_Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[6],poBOT_Registro_Empaque_Procedimiento.Procedimiento_5_Fecha);
			par[7] = new SqlParameter("@Numero_Lote",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[7],poBOT_Registro_Empaque_Procedimiento.Numero_Lote);
			par[8] = new SqlParameter("@Fecha_Vencimiento",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[8],poBOT_Registro_Empaque_Procedimiento.Fecha_Vencimiento);
			par[9] = new SqlParameter("@Cantidad_Cajas",System.Data.SqlDbType.Int);
			ValidateAndInsertValue(par[9],poBOT_Registro_Empaque_Procedimiento.Cantidad_Cajas);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_UpdT_Registro_Empaque_Procedimiento", par);
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

		public Boolean fnInsUpdT_Registro_Empaque_Procedimiento(BOT_Registro_Empaque_Procedimiento poBOT_Registro_Empaque_Procedimiento)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[10];
			par[0] = new SqlParameter("@Codigo_Registro_Empaque_Procedimiento",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Registro_Empaque_Procedimiento.Codigo_Registro_Empaque_Procedimiento);
			par[1] = new SqlParameter("@Codigo_Registro_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Registro_Empaque_Procedimiento.Codigo_Registro_Empaque);
			par[2] = new SqlParameter("@Procedimiento_1_Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[2],poBOT_Registro_Empaque_Procedimiento.Procedimiento_1_Fecha);
			par[3] = new SqlParameter("@Procedimiento_2_Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[3],poBOT_Registro_Empaque_Procedimiento.Procedimiento_2_Fecha);
			par[4] = new SqlParameter("@Procedimiento_3_Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[4],poBOT_Registro_Empaque_Procedimiento.Procedimiento_3_Fecha);
			par[5] = new SqlParameter("@Procedimiento_4_Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[5],poBOT_Registro_Empaque_Procedimiento.Procedimiento_4_Fecha);
			par[6] = new SqlParameter("@Procedimiento_5_Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[6],poBOT_Registro_Empaque_Procedimiento.Procedimiento_5_Fecha);
			par[7] = new SqlParameter("@Numero_Lote",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[7],poBOT_Registro_Empaque_Procedimiento.Numero_Lote);
			par[8] = new SqlParameter("@Fecha_Vencimiento",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[8],poBOT_Registro_Empaque_Procedimiento.Fecha_Vencimiento);
			par[9] = new SqlParameter("@Cantidad_Cajas",System.Data.SqlDbType.Int);
			ValidateAndInsertValue(par[9],poBOT_Registro_Empaque_Procedimiento.Cantidad_Cajas);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsUpdT_Registro_Empaque_Procedimiento", par);
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
		public Boolean fnDelT_Registro_Empaque_Procedimiento(String psCodigo_Registro_Empaque_Procedimiento)
		{
			Boolean lbResultado=true;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			SqlParameter[] par = new SqlParameter[1];
			//cambiar aca:
			par[0] = new SqlParameter("@Codigo_Registro_Empaque_Procedimiento",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Registro_Empaque_Procedimiento;
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_DelT_Registro_Empaque_Procedimiento", par);
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

		public List<BOT_Registro_Empaque_Procedimiento> fnSelT_Registro_Empaque_ProcedimientoAll()
		{
			List<BOT_Registro_Empaque_Procedimiento> loList = new List<BOT_Registro_Empaque_Procedimiento>();
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Empaque_ProcedimientosAll");
				while (loDr.Read())
                {
					BOT_Registro_Empaque_Procedimiento loBOT_Registro_Empaque_Procedimiento=new BOT_Registro_Empaque_Procedimiento();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Procedimiento"));
					loBOT_Registro_Empaque_Procedimiento.Codigo_Registro_Empaque_Procedimiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque"));
					loBOT_Registro_Empaque_Procedimiento.Codigo_Registro_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Procedimiento_1_Fecha"));
					loBOT_Registro_Empaque_Procedimiento.Procedimiento_1_Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Procedimiento_2_Fecha"));
					loBOT_Registro_Empaque_Procedimiento.Procedimiento_2_Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Procedimiento_3_Fecha"));
					loBOT_Registro_Empaque_Procedimiento.Procedimiento_3_Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Procedimiento_4_Fecha"));
					loBOT_Registro_Empaque_Procedimiento.Procedimiento_4_Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Procedimiento_5_Fecha"));
					loBOT_Registro_Empaque_Procedimiento.Procedimiento_5_Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Numero_Lote"));
					loBOT_Registro_Empaque_Procedimiento.Numero_Lote = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Fecha_Vencimiento"));
					loBOT_Registro_Empaque_Procedimiento.Fecha_Vencimiento = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad_Cajas"));
					loBOT_Registro_Empaque_Procedimiento.Cantidad_Cajas = value != System.DBNull.Value ? (Int32)value : default(Int32);
                    loList.Add(loBOT_Registro_Empaque_Procedimiento);
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

		public BOT_Registro_Empaque_Procedimiento fnSelT_Registro_Empaque_Procedimiento(String psCodigo_Registro_Empaque_Procedimiento)
		{
			BOT_Registro_Empaque_Procedimiento loBOT_Registro_Empaque_Procedimiento = new BOT_Registro_Empaque_Procedimiento();
			//parametros
			
			SqlParameter[] par = new SqlParameter[1];
			par[0] = new SqlParameter("@Codigo_Registro_Empaque_Procedimiento",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Registro_Empaque_Procedimiento;
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Empaque_Procedimiento", par);
				while(loDr.Read()){//----------------------------------------------------- AQUI
					if (loDr != null)
					{
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Procedimiento"));
					loBOT_Registro_Empaque_Procedimiento.Codigo_Registro_Empaque_Procedimiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque"));
					loBOT_Registro_Empaque_Procedimiento.Codigo_Registro_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Procedimiento_1_Fecha"));
					loBOT_Registro_Empaque_Procedimiento.Procedimiento_1_Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Procedimiento_2_Fecha"));
					loBOT_Registro_Empaque_Procedimiento.Procedimiento_2_Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Procedimiento_3_Fecha"));
					loBOT_Registro_Empaque_Procedimiento.Procedimiento_3_Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Procedimiento_4_Fecha"));
					loBOT_Registro_Empaque_Procedimiento.Procedimiento_4_Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Procedimiento_5_Fecha"));
					loBOT_Registro_Empaque_Procedimiento.Procedimiento_5_Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Numero_Lote"));
					loBOT_Registro_Empaque_Procedimiento.Numero_Lote = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Fecha_Vencimiento"));
					loBOT_Registro_Empaque_Procedimiento.Fecha_Vencimiento = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad_Cajas"));
					loBOT_Registro_Empaque_Procedimiento.Cantidad_Cajas = value != System.DBNull.Value ? (Int32)value : default(Int32);
						
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
			return loBOT_Registro_Empaque_Procedimiento;
		}
		public List<BOT_Registro_Empaque_Procedimiento> fnSelT_Registro_Empaque_ProcedimientoDin(string psWhere,string psOrder)
		{
			List<BOT_Registro_Empaque_Procedimiento> loList = new List<BOT_Registro_Empaque_Procedimiento>();
			SqlParameter[] par = new SqlParameter[2];
			par[0] = new SqlParameter("@WhereCondition",System.Data.SqlDbType.VarChar,500);
			par[0].Value= psWhere;
			par[1] = new SqlParameter("@OrderByExpression",System.Data.SqlDbType.VarChar,250);
			par[1].Value= psOrder;
			object value;//------------------------- 1
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Empaque_ProcedimientosDin",par);
				while (loDr.Read())
                {
					BOT_Registro_Empaque_Procedimiento loBOT_Registro_Empaque_Procedimiento=new BOT_Registro_Empaque_Procedimiento();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque_Procedimiento"));
					loBOT_Registro_Empaque_Procedimiento.Codigo_Registro_Empaque_Procedimiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Empaque"));
					loBOT_Registro_Empaque_Procedimiento.Codigo_Registro_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Procedimiento_1_Fecha"));
					loBOT_Registro_Empaque_Procedimiento.Procedimiento_1_Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Procedimiento_2_Fecha"));
					loBOT_Registro_Empaque_Procedimiento.Procedimiento_2_Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Procedimiento_3_Fecha"));
					loBOT_Registro_Empaque_Procedimiento.Procedimiento_3_Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Procedimiento_4_Fecha"));
					loBOT_Registro_Empaque_Procedimiento.Procedimiento_4_Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Procedimiento_5_Fecha"));
					loBOT_Registro_Empaque_Procedimiento.Procedimiento_5_Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Numero_Lote"));
					loBOT_Registro_Empaque_Procedimiento.Numero_Lote = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Fecha_Vencimiento"));
					loBOT_Registro_Empaque_Procedimiento.Fecha_Vencimiento = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad_Cajas"));
					loBOT_Registro_Empaque_Procedimiento.Cantidad_Cajas = value != System.DBNull.Value ? (Int32)value : default(Int32);
                    loList.Add(loBOT_Registro_Empaque_Procedimiento);
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
		public Int32[] fnSelT_Registro_Empaque_ProcedimientoMinMax()
        {
            Int32[] laMinMax=new Int32[2];
            try
			{
                SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Empaque_ProcedimientoMinMax");
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

