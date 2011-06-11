using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using BO_SISACO;

namespace BDA_SISACO
{	
	public partial class BDAT_Registro_Entrega:BDABase
	{
		public Boolean fnInsT_Registro_Entrega(BOT_Registro_Entrega poBOT_Registro_Entrega)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[6];
			par[0] = new SqlParameter("@Codigo_Registro_Entrega",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Registro_Entrega.Codigo_Registro_Entrega);
			par[1] = new SqlParameter("@Codigo_Orden_Acondicionamiento",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Registro_Entrega.Codigo_Orden_Acondicionamiento);
			par[2] = new SqlParameter("@Codigo_Entrega_Producto_Empacar",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[2],poBOT_Registro_Entrega.Codigo_Entrega_Producto_Empacar);
			par[3] = new SqlParameter("@Codigo_Entrega_Producto_Terminado_Almacen",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[3],poBOT_Registro_Entrega.Codigo_Entrega_Producto_Terminado_Almacen);
			par[4] = new SqlParameter("@Rendimiento",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[4],poBOT_Registro_Entrega.Rendimiento);
			par[5] = new SqlParameter("@Observaciones",System.Data.SqlDbType.VarChar,200);
			ValidateAndInsertValue(par[5],poBOT_Registro_Entrega.Observaciones);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsT_Registro_Entrega", par);
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
		public Boolean fnUpdT_Registro_Entrega(BOT_Registro_Entrega poBOT_Registro_Entrega)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[6];
			par[0] = new SqlParameter("@Codigo_Registro_Entrega",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Registro_Entrega.Codigo_Registro_Entrega);
			par[1] = new SqlParameter("@Codigo_Orden_Acondicionamiento",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Registro_Entrega.Codigo_Orden_Acondicionamiento);
			par[2] = new SqlParameter("@Codigo_Entrega_Producto_Empacar",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[2],poBOT_Registro_Entrega.Codigo_Entrega_Producto_Empacar);
			par[3] = new SqlParameter("@Codigo_Entrega_Producto_Terminado_Almacen",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[3],poBOT_Registro_Entrega.Codigo_Entrega_Producto_Terminado_Almacen);
			par[4] = new SqlParameter("@Rendimiento",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[4],poBOT_Registro_Entrega.Rendimiento);
			par[5] = new SqlParameter("@Observaciones",System.Data.SqlDbType.VarChar,200);
			ValidateAndInsertValue(par[5],poBOT_Registro_Entrega.Observaciones);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_UpdT_Registro_Entrega", par);
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

		public Boolean fnInsUpdT_Registro_Entrega(BOT_Registro_Entrega poBOT_Registro_Entrega)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[6];
			par[0] = new SqlParameter("@Codigo_Registro_Entrega",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Registro_Entrega.Codigo_Registro_Entrega);
			par[1] = new SqlParameter("@Codigo_Orden_Acondicionamiento",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Registro_Entrega.Codigo_Orden_Acondicionamiento);
			par[2] = new SqlParameter("@Codigo_Entrega_Producto_Empacar",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[2],poBOT_Registro_Entrega.Codigo_Entrega_Producto_Empacar);
			par[3] = new SqlParameter("@Codigo_Entrega_Producto_Terminado_Almacen",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[3],poBOT_Registro_Entrega.Codigo_Entrega_Producto_Terminado_Almacen);
			par[4] = new SqlParameter("@Rendimiento",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[4],poBOT_Registro_Entrega.Rendimiento);
			par[5] = new SqlParameter("@Observaciones",System.Data.SqlDbType.VarChar,200);
			ValidateAndInsertValue(par[5],poBOT_Registro_Entrega.Observaciones);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsUpdT_Registro_Entrega", par);
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
		public Boolean fnDelT_Registro_Entrega(String psCodigo_Registro_Entrega)
		{
			Boolean lbResultado=true;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			SqlParameter[] par = new SqlParameter[1];
			//cambiar aca:
			par[0] = new SqlParameter("@Codigo_Registro_Entrega",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Registro_Entrega;
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_DelT_Registro_Entrega", par);
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

		public List<BOT_Registro_Entrega> fnSelT_Registro_EntregaAll()
		{
			List<BOT_Registro_Entrega> loList = new List<BOT_Registro_Entrega>();
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_EntregasAll");
				while (loDr.Read())
                {
					BOT_Registro_Entrega loBOT_Registro_Entrega=new BOT_Registro_Entrega();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Entrega"));
					loBOT_Registro_Entrega.Codigo_Registro_Entrega = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Orden_Acondicionamiento"));
					loBOT_Registro_Entrega.Codigo_Orden_Acondicionamiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Entrega_Producto_Empacar"));
					loBOT_Registro_Entrega.Codigo_Entrega_Producto_Empacar = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Entrega_Producto_Terminado_Almacen"));
					loBOT_Registro_Entrega.Codigo_Entrega_Producto_Terminado_Almacen = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Rendimiento"));
					loBOT_Registro_Entrega.Rendimiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Observaciones"));
					loBOT_Registro_Entrega.Observaciones = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Registro_Entrega);
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

		public BOT_Registro_Entrega fnSelT_Registro_Entrega(String psCodigo_Registro_Entrega)
		{
			BOT_Registro_Entrega loBOT_Registro_Entrega = new BOT_Registro_Entrega();
			//parametros
			
			SqlParameter[] par = new SqlParameter[1];
			par[0] = new SqlParameter("@Codigo_Registro_Entrega",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Registro_Entrega;
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Entrega", par);
				while(loDr.Read()){//----------------------------------------------------- AQUI
					if (loDr != null)
					{
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Entrega"));
					loBOT_Registro_Entrega.Codigo_Registro_Entrega = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Orden_Acondicionamiento"));
					loBOT_Registro_Entrega.Codigo_Orden_Acondicionamiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Entrega_Producto_Empacar"));
					loBOT_Registro_Entrega.Codigo_Entrega_Producto_Empacar = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Entrega_Producto_Terminado_Almacen"));
					loBOT_Registro_Entrega.Codigo_Entrega_Producto_Terminado_Almacen = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Rendimiento"));
					loBOT_Registro_Entrega.Rendimiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Observaciones"));
					loBOT_Registro_Entrega.Observaciones = value != System.DBNull.Value ? (String)value : default(String);
						
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
			return loBOT_Registro_Entrega;
		}
		public List<BOT_Registro_Entrega> fnSelT_Registro_EntregaDin(string psWhere,string psOrder)
		{
			List<BOT_Registro_Entrega> loList = new List<BOT_Registro_Entrega>();
			SqlParameter[] par = new SqlParameter[2];
			par[0] = new SqlParameter("@WhereCondition",System.Data.SqlDbType.VarChar,500);
			par[0].Value= psWhere;
			par[1] = new SqlParameter("@OrderByExpression",System.Data.SqlDbType.VarChar,250);
			par[1].Value= psOrder;
			object value;//------------------------- 1
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_EntregasDin",par);
				while (loDr.Read())
                {
					BOT_Registro_Entrega loBOT_Registro_Entrega=new BOT_Registro_Entrega();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Entrega"));
					loBOT_Registro_Entrega.Codigo_Registro_Entrega = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Orden_Acondicionamiento"));
					loBOT_Registro_Entrega.Codigo_Orden_Acondicionamiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Entrega_Producto_Empacar"));
					loBOT_Registro_Entrega.Codigo_Entrega_Producto_Empacar = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Entrega_Producto_Terminado_Almacen"));
					loBOT_Registro_Entrega.Codigo_Entrega_Producto_Terminado_Almacen = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Rendimiento"));
					loBOT_Registro_Entrega.Rendimiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Observaciones"));
					loBOT_Registro_Entrega.Observaciones = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Registro_Entrega);
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
		public Int32[] fnSelT_Registro_EntregaMinMax()
        {
            Int32[] laMinMax=new Int32[2];
            try
			{
                SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_EntregaMinMax");
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

