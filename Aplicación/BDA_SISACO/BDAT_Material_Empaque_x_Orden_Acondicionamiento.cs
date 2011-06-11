using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using BO_SISACO;

namespace BDA_SISACO
{	
	public partial class BDAT_Material_Empaque_x_Orden_Acondicionamiento:BDABase
	{
		public Boolean fnInsT_Material_Empaque_x_Orden_Acondicionamiento(BOT_Material_Empaque_x_Orden_Acondicionamiento poBOT_Material_Empaque_x_Orden_Acondicionamiento)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[5];
            par[0] = new SqlParameter("@Codigo_Material_Empaque_x_Orden_Acondicionamiento", System.Data.SqlDbType.VarChar, 10);
            ValidateAndInsertValue(par[0],poBOT_Material_Empaque_x_Orden_Acondicionamiento.Codigo_Material_Empaque_x_Orden_Acondiconamiento);
            par[0].Direction = ParameterDirection.Output;
			par[1] = new SqlParameter("@Codigo_Orden_Acondicionamiento",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Material_Empaque_x_Orden_Acondicionamiento.Codigo_Orden_Acondicionamiento);
			par[2] = new SqlParameter("@Codigo_Material_Empaque_x_Producto",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[2],poBOT_Material_Empaque_x_Orden_Acondicionamiento.Codigo_Material_Empaque_x_Producto);
			par[3] = new SqlParameter("@Cantidad_Entregada",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[3],poBOT_Material_Empaque_x_Orden_Acondicionamiento.Cantidad_Entregada);
			par[4] = new SqlParameter("@Numero_Analisis",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[4],poBOT_Material_Empaque_x_Orden_Acondicionamiento.Numero_Analisis);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsT_Material_Empaque_x_Orden_Acondicionamiento", par);
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
		public Boolean fnUpdT_Material_Empaque_x_Orden_Acondicionamiento(BOT_Material_Empaque_x_Orden_Acondicionamiento poBOT_Material_Empaque_x_Orden_Acondicionamiento)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[5];
			par[0] = new SqlParameter("@Codigo_Material_Empaque_x_Orden_Acondiconamiento",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Material_Empaque_x_Orden_Acondicionamiento.Codigo_Material_Empaque_x_Orden_Acondiconamiento);
			par[1] = new SqlParameter("@Codigo_Orden_Acondicionamiento",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Material_Empaque_x_Orden_Acondicionamiento.Codigo_Orden_Acondicionamiento);
			par[2] = new SqlParameter("@Codigo_Material_Empaque_x_Producto",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[2],poBOT_Material_Empaque_x_Orden_Acondicionamiento.Codigo_Material_Empaque_x_Producto);
			par[3] = new SqlParameter("@Cantidad_Entregada",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[3],poBOT_Material_Empaque_x_Orden_Acondicionamiento.Cantidad_Entregada);
			par[4] = new SqlParameter("@Numero_Analisis",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[4],poBOT_Material_Empaque_x_Orden_Acondicionamiento.Numero_Analisis);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_UpdT_Material_Empaque_x_Orden_Acondicionamiento", par);
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

		public Boolean fnInsUpdT_Material_Empaque_x_Orden_Acondicionamiento(BOT_Material_Empaque_x_Orden_Acondicionamiento poBOT_Material_Empaque_x_Orden_Acondicionamiento)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[5];
			par[0] = new SqlParameter("@Codigo_Material_Empaque_x_Orden_Acondicionamiento",System.Data.SqlDbType.NVarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Material_Empaque_x_Orden_Acondicionamiento.Codigo_Material_Empaque_x_Orden_Acondiconamiento);
			par[1] = new SqlParameter("@Codigo_Orden_Acondicionamiento",System.Data.SqlDbType.NVarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Material_Empaque_x_Orden_Acondicionamiento.Codigo_Orden_Acondicionamiento);
			par[2] = new SqlParameter("@Codigo_Material_Empaque_x_Producto",System.Data.SqlDbType.NVarChar,10);
			ValidateAndInsertValue(par[2],poBOT_Material_Empaque_x_Orden_Acondicionamiento.Codigo_Material_Empaque_x_Producto);
			par[3] = new SqlParameter("@Cantidad_Entregada",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[3],poBOT_Material_Empaque_x_Orden_Acondicionamiento.Cantidad_Entregada);
			par[4] = new SqlParameter("@Numero_Analisis",System.Data.SqlDbType.NVarChar,10);
			ValidateAndInsertValue(par[4],poBOT_Material_Empaque_x_Orden_Acondicionamiento.Numero_Analisis);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsUpdT_Material_Empaque_x_Orden_Acondicionamiento", par);
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
		public Boolean fnDelT_Material_Empaque_x_Orden_Acondicionamiento(String psCodigo_Material_Empaque_x_Orden_Acondiconamiento)
		{
			Boolean lbResultado=true;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			SqlParameter[] par = new SqlParameter[1];
			//cambiar aca:
			par[0] = new SqlParameter("@Codigo_Material_Empaque_x_Orden_Acondiconamiento",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Material_Empaque_x_Orden_Acondiconamiento;
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_DelT_Material_Empaque_x_Orden_Acondicionamiento", par);
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

		public List<BOT_Material_Empaque_x_Orden_Acondicionamiento> fnSelT_Material_Empaque_x_Orden_AcondicionamientoAll()
		{
			List<BOT_Material_Empaque_x_Orden_Acondicionamiento> loList = new List<BOT_Material_Empaque_x_Orden_Acondicionamiento>();
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Material_Empaque_x_Orden_AcondicionamientosAll");
				while (loDr.Read())
                {
					BOT_Material_Empaque_x_Orden_Acondicionamiento loBOT_Material_Empaque_x_Orden_Acondicionamiento=new BOT_Material_Empaque_x_Orden_Acondicionamiento();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Material_Empaque_x_Orden_Acondiconamiento"));
					loBOT_Material_Empaque_x_Orden_Acondicionamiento.Codigo_Material_Empaque_x_Orden_Acondiconamiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Orden_Acondicionamiento"));
					loBOT_Material_Empaque_x_Orden_Acondicionamiento.Codigo_Orden_Acondicionamiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Material_Empaque_x_Producto"));
					loBOT_Material_Empaque_x_Orden_Acondicionamiento.Codigo_Material_Empaque_x_Producto = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad_Entregada"));
					loBOT_Material_Empaque_x_Orden_Acondicionamiento.Cantidad_Entregada = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
					value = loDr.GetValue(loDr.GetOrdinal("Numero_Analisis"));
					loBOT_Material_Empaque_x_Orden_Acondicionamiento.Numero_Analisis = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Material_Empaque_x_Orden_Acondicionamiento);
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

		public BOT_Material_Empaque_x_Orden_Acondicionamiento fnSelT_Material_Empaque_x_Orden_Acondicionamiento(String psCodigo_Material_Empaque_x_Orden_Acondiconamiento)
		{
			BOT_Material_Empaque_x_Orden_Acondicionamiento loBOT_Material_Empaque_x_Orden_Acondicionamiento = new BOT_Material_Empaque_x_Orden_Acondicionamiento();
			//parametros
			
			SqlParameter[] par = new SqlParameter[1];
			par[0] = new SqlParameter("@Codigo_Material_Empaque_x_Orden_Acondiconamiento",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Material_Empaque_x_Orden_Acondiconamiento;
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Material_Empaque_x_Orden_Acondicionamiento", par);
				while(loDr.Read()){//----------------------------------------------------- AQUI
					if (loDr != null)
					{
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Material_Empaque_x_Orden_Acondiconamiento"));
					loBOT_Material_Empaque_x_Orden_Acondicionamiento.Codigo_Material_Empaque_x_Orden_Acondiconamiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Orden_Acondicionamiento"));
					loBOT_Material_Empaque_x_Orden_Acondicionamiento.Codigo_Orden_Acondicionamiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Material_Empaque_x_Producto"));
					loBOT_Material_Empaque_x_Orden_Acondicionamiento.Codigo_Material_Empaque_x_Producto = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad_Entregada"));
					loBOT_Material_Empaque_x_Orden_Acondicionamiento.Cantidad_Entregada = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
					value = loDr.GetValue(loDr.GetOrdinal("Numero_Analisis"));
					loBOT_Material_Empaque_x_Orden_Acondicionamiento.Numero_Analisis = value != System.DBNull.Value ? (String)value : default(String);
						
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
			return loBOT_Material_Empaque_x_Orden_Acondicionamiento;
		}
		public List<BOT_Material_Empaque_x_Orden_Acondicionamiento> fnSelT_Material_Empaque_x_Orden_AcondicionamientoDin(string psWhere,string psOrder)
		{
			List<BOT_Material_Empaque_x_Orden_Acondicionamiento> loList = new List<BOT_Material_Empaque_x_Orden_Acondicionamiento>();
			SqlParameter[] par = new SqlParameter[2];
			par[0] = new SqlParameter("@WhereCondition",System.Data.SqlDbType.VarChar,500);
			par[0].Value= psWhere;
			par[1] = new SqlParameter("@OrderByExpression",System.Data.SqlDbType.VarChar,250);
			par[1].Value= psOrder;
			object value;//------------------------- 1
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Material_Empaque_x_Orden_AcondicionamientosDin",par);
				while (loDr.Read())
                {
					BOT_Material_Empaque_x_Orden_Acondicionamiento loBOT_Material_Empaque_x_Orden_Acondicionamiento=new BOT_Material_Empaque_x_Orden_Acondicionamiento();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Material_Empaque_x_Orden_Acondiconamiento"));
					loBOT_Material_Empaque_x_Orden_Acondicionamiento.Codigo_Material_Empaque_x_Orden_Acondiconamiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Orden_Acondicionamiento"));
					loBOT_Material_Empaque_x_Orden_Acondicionamiento.Codigo_Orden_Acondicionamiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Material_Empaque_x_Producto"));
					loBOT_Material_Empaque_x_Orden_Acondicionamiento.Codigo_Material_Empaque_x_Producto = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad_Entregada"));
					loBOT_Material_Empaque_x_Orden_Acondicionamiento.Cantidad_Entregada = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
					value = loDr.GetValue(loDr.GetOrdinal("Numero_Analisis"));
					loBOT_Material_Empaque_x_Orden_Acondicionamiento.Numero_Analisis = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Material_Empaque_x_Orden_Acondicionamiento);
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
		public Int32[] fnSelT_Material_Empaque_x_Orden_AcondicionamientoMinMax()
        {
            Int32[] laMinMax=new Int32[2];
            try
			{
                SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Material_Empaque_x_Orden_AcondicionamientoMinMax");
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

