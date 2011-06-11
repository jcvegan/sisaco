using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using BO_SISACO;

namespace BDA_SISACO
{	
	public partial class BDAT_Rendimiento_Reporte_Final:BDABase
	{
		public Boolean fnInsT_Rendimiento_Reporte_Final(BOT_Rendimiento_Reporte_Final poBOT_Rendimiento_Reporte_Final)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[9];
			par[0] = new SqlParameter("@Codigo_Rendimiento_Reporte_Final",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Rendimiento_Reporte_Final.Codigo_Rendimiento_Reporte_Final);
			par[1] = new SqlParameter("@Codgo_Orden_Acondicionamiento",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Rendimiento_Reporte_Final.Codgo_Orden_Acondicionamiento);
			par[2] = new SqlParameter("@Fecha_Inicio",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[2],poBOT_Rendimiento_Reporte_Final.Fecha_Inicio);
			par[3] = new SqlParameter("@Fecha_Termino",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[3],poBOT_Rendimiento_Reporte_Final.Fecha_Termino);
			par[4] = new SqlParameter("@Cantidad_Teorica",System.Data.SqlDbType.Int);
			ValidateAndInsertValue(par[4],poBOT_Rendimiento_Reporte_Final.Cantidad_Teorica);
			par[5] = new SqlParameter("@Cantidad_Obtenida",System.Data.SqlDbType.Int);
			ValidateAndInsertValue(par[5],poBOT_Rendimiento_Reporte_Final.Cantidad_Obtenida);
			par[6] = new SqlParameter("@Merma",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[6],poBOT_Rendimiento_Reporte_Final.Merma);
			par[7] = new SqlParameter("@Rendimiento_Final",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[7],poBOT_Rendimiento_Reporte_Final.Rendimiento_Final);
			par[8] = new SqlParameter("@Observaciones",System.Data.SqlDbType.VarChar,200);
			ValidateAndInsertValue(par[8],poBOT_Rendimiento_Reporte_Final.Observaciones);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsT_Rendimiento_Reporte_Final", par);
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
		public Boolean fnUpdT_Rendimiento_Reporte_Final(BOT_Rendimiento_Reporte_Final poBOT_Rendimiento_Reporte_Final)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[9];
			par[0] = new SqlParameter("@Codigo_Rendimiento_Reporte_Final",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Rendimiento_Reporte_Final.Codigo_Rendimiento_Reporte_Final);
			par[1] = new SqlParameter("@Codgo_Orden_Acondicionamiento",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Rendimiento_Reporte_Final.Codgo_Orden_Acondicionamiento);
			par[2] = new SqlParameter("@Fecha_Inicio",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[2],poBOT_Rendimiento_Reporte_Final.Fecha_Inicio);
			par[3] = new SqlParameter("@Fecha_Termino",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[3],poBOT_Rendimiento_Reporte_Final.Fecha_Termino);
			par[4] = new SqlParameter("@Cantidad_Teorica",System.Data.SqlDbType.Int);
			ValidateAndInsertValue(par[4],poBOT_Rendimiento_Reporte_Final.Cantidad_Teorica);
			par[5] = new SqlParameter("@Cantidad_Obtenida",System.Data.SqlDbType.Int);
			ValidateAndInsertValue(par[5],poBOT_Rendimiento_Reporte_Final.Cantidad_Obtenida);
			par[6] = new SqlParameter("@Merma",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[6],poBOT_Rendimiento_Reporte_Final.Merma);
			par[7] = new SqlParameter("@Rendimiento_Final",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[7],poBOT_Rendimiento_Reporte_Final.Rendimiento_Final);
			par[8] = new SqlParameter("@Observaciones",System.Data.SqlDbType.VarChar,200);
			ValidateAndInsertValue(par[8],poBOT_Rendimiento_Reporte_Final.Observaciones);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_UpdT_Rendimiento_Reporte_Final", par);
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

		public Boolean fnInsUpdT_Rendimiento_Reporte_Final(BOT_Rendimiento_Reporte_Final poBOT_Rendimiento_Reporte_Final)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[9];
			par[0] = new SqlParameter("@Codigo_Rendimiento_Reporte_Final",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Rendimiento_Reporte_Final.Codigo_Rendimiento_Reporte_Final);
			par[1] = new SqlParameter("@Codgo_Orden_Acondicionamiento",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Rendimiento_Reporte_Final.Codgo_Orden_Acondicionamiento);
			par[2] = new SqlParameter("@Fecha_Inicio",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[2],poBOT_Rendimiento_Reporte_Final.Fecha_Inicio);
			par[3] = new SqlParameter("@Fecha_Termino",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[3],poBOT_Rendimiento_Reporte_Final.Fecha_Termino);
			par[4] = new SqlParameter("@Cantidad_Teorica",System.Data.SqlDbType.Int);
			ValidateAndInsertValue(par[4],poBOT_Rendimiento_Reporte_Final.Cantidad_Teorica);
			par[5] = new SqlParameter("@Cantidad_Obtenida",System.Data.SqlDbType.Int);
			ValidateAndInsertValue(par[5],poBOT_Rendimiento_Reporte_Final.Cantidad_Obtenida);
			par[6] = new SqlParameter("@Merma",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[6],poBOT_Rendimiento_Reporte_Final.Merma);
			par[7] = new SqlParameter("@Rendimiento_Final",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[7],poBOT_Rendimiento_Reporte_Final.Rendimiento_Final);
			par[8] = new SqlParameter("@Observaciones",System.Data.SqlDbType.VarChar,200);
			ValidateAndInsertValue(par[8],poBOT_Rendimiento_Reporte_Final.Observaciones);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsUpdT_Rendimiento_Reporte_Final", par);
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
		public Boolean fnDelT_Rendimiento_Reporte_Final(String psCodigo_Rendimiento_Reporte_Final)
		{
			Boolean lbResultado=true;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			SqlParameter[] par = new SqlParameter[1];
			//cambiar aca:
			par[0] = new SqlParameter("@Codigo_Rendimiento_Reporte_Final",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Rendimiento_Reporte_Final;
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_DelT_Rendimiento_Reporte_Final", par);
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

		public List<BOT_Rendimiento_Reporte_Final> fnSelT_Rendimiento_Reporte_FinalAll()
		{
			List<BOT_Rendimiento_Reporte_Final> loList = new List<BOT_Rendimiento_Reporte_Final>();
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Rendimiento_Reporte_FinalsAll");
				while (loDr.Read())
                {
					BOT_Rendimiento_Reporte_Final loBOT_Rendimiento_Reporte_Final=new BOT_Rendimiento_Reporte_Final();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Rendimiento_Reporte_Final"));
					loBOT_Rendimiento_Reporte_Final.Codigo_Rendimiento_Reporte_Final = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codgo_Orden_Acondicionamiento"));
					loBOT_Rendimiento_Reporte_Final.Codgo_Orden_Acondicionamiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Fecha_Inicio"));
					loBOT_Rendimiento_Reporte_Final.Fecha_Inicio = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Fecha_Termino"));
					loBOT_Rendimiento_Reporte_Final.Fecha_Termino = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad_Teorica"));
					loBOT_Rendimiento_Reporte_Final.Cantidad_Teorica = value != System.DBNull.Value ? (Int32)value : default(Int32);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad_Obtenida"));
					loBOT_Rendimiento_Reporte_Final.Cantidad_Obtenida = value != System.DBNull.Value ? (Int32)value : default(Int32);
					value = loDr.GetValue(loDr.GetOrdinal("Merma"));
					loBOT_Rendimiento_Reporte_Final.Merma = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
					value = loDr.GetValue(loDr.GetOrdinal("Rendimiento_Final"));
					loBOT_Rendimiento_Reporte_Final.Rendimiento_Final = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
					value = loDr.GetValue(loDr.GetOrdinal("Observaciones"));
					loBOT_Rendimiento_Reporte_Final.Observaciones = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Rendimiento_Reporte_Final);
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

		public BOT_Rendimiento_Reporte_Final fnSelT_Rendimiento_Reporte_Final(String psCodigo_Rendimiento_Reporte_Final)
		{
			BOT_Rendimiento_Reporte_Final loBOT_Rendimiento_Reporte_Final = new BOT_Rendimiento_Reporte_Final();
			//parametros
			
			SqlParameter[] par = new SqlParameter[1];
			par[0] = new SqlParameter("@Codigo_Rendimiento_Reporte_Final",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Rendimiento_Reporte_Final;
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Rendimiento_Reporte_Final", par);
				while(loDr.Read()){//----------------------------------------------------- AQUI
					if (loDr != null)
					{
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Rendimiento_Reporte_Final"));
					loBOT_Rendimiento_Reporte_Final.Codigo_Rendimiento_Reporte_Final = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codgo_Orden_Acondicionamiento"));
					loBOT_Rendimiento_Reporte_Final.Codgo_Orden_Acondicionamiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Fecha_Inicio"));
					loBOT_Rendimiento_Reporte_Final.Fecha_Inicio = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Fecha_Termino"));
					loBOT_Rendimiento_Reporte_Final.Fecha_Termino = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad_Teorica"));
					loBOT_Rendimiento_Reporte_Final.Cantidad_Teorica = value != System.DBNull.Value ? (Int32)value : default(Int32);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad_Obtenida"));
					loBOT_Rendimiento_Reporte_Final.Cantidad_Obtenida = value != System.DBNull.Value ? (Int32)value : default(Int32);
					value = loDr.GetValue(loDr.GetOrdinal("Merma"));
					loBOT_Rendimiento_Reporte_Final.Merma = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
					value = loDr.GetValue(loDr.GetOrdinal("Rendimiento_Final"));
					loBOT_Rendimiento_Reporte_Final.Rendimiento_Final = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
					value = loDr.GetValue(loDr.GetOrdinal("Observaciones"));
					loBOT_Rendimiento_Reporte_Final.Observaciones = value != System.DBNull.Value ? (String)value : default(String);
						
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
			return loBOT_Rendimiento_Reporte_Final;
		}
		public List<BOT_Rendimiento_Reporte_Final> fnSelT_Rendimiento_Reporte_FinalDin(string psWhere,string psOrder)
		{
			List<BOT_Rendimiento_Reporte_Final> loList = new List<BOT_Rendimiento_Reporte_Final>();
			SqlParameter[] par = new SqlParameter[2];
			par[0] = new SqlParameter("@WhereCondition",System.Data.SqlDbType.VarChar,500);
			par[0].Value= psWhere;
			par[1] = new SqlParameter("@OrderByExpression",System.Data.SqlDbType.VarChar,250);
			par[1].Value= psOrder;
			object value;//------------------------- 1
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Rendimiento_Reporte_FinalsDin",par);
				while (loDr.Read())
                {
					BOT_Rendimiento_Reporte_Final loBOT_Rendimiento_Reporte_Final=new BOT_Rendimiento_Reporte_Final();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Rendimiento_Reporte_Final"));
					loBOT_Rendimiento_Reporte_Final.Codigo_Rendimiento_Reporte_Final = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codgo_Orden_Acondicionamiento"));
					loBOT_Rendimiento_Reporte_Final.Codgo_Orden_Acondicionamiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Fecha_Inicio"));
					loBOT_Rendimiento_Reporte_Final.Fecha_Inicio = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Fecha_Termino"));
					loBOT_Rendimiento_Reporte_Final.Fecha_Termino = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad_Teorica"));
					loBOT_Rendimiento_Reporte_Final.Cantidad_Teorica = value != System.DBNull.Value ? (Int32)value : default(Int32);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad_Obtenida"));
					loBOT_Rendimiento_Reporte_Final.Cantidad_Obtenida = value != System.DBNull.Value ? (Int32)value : default(Int32);
					value = loDr.GetValue(loDr.GetOrdinal("Merma"));
					loBOT_Rendimiento_Reporte_Final.Merma = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
					value = loDr.GetValue(loDr.GetOrdinal("Rendimiento_Final"));
					loBOT_Rendimiento_Reporte_Final.Rendimiento_Final = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
					value = loDr.GetValue(loDr.GetOrdinal("Observaciones"));
					loBOT_Rendimiento_Reporte_Final.Observaciones = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Rendimiento_Reporte_Final);
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
		public Int32[] fnSelT_Rendimiento_Reporte_FinalMinMax()
        {
            Int32[] laMinMax=new Int32[2];
            try
			{
                SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Rendimiento_Reporte_FinalMinMax");
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

