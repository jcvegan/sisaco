using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using BO_SISACO;

namespace BDA_SISACO
{	
	public partial class BDAT_Entrega_Producto_Terminado_Almacen:BDABase
	{
		public Boolean fnInsT_Entrega_Producto_Terminado_Almacen(BOT_Entrega_Producto_Terminado_Almacen poBOT_Entrega_Producto_Terminado_Almacen)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[6];
			par[0] = new SqlParameter("@Codigo_Entrega_Producto_Terminado_Almacen",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Entrega_Producto_Terminado_Almacen.Codigo_Entrega_Producto_Terminado_Almacen);
			par[1] = new SqlParameter("@Codigo_Registro_Entrega",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Entrega_Producto_Terminado_Almacen.Codigo_Registro_Entrega);
			par[2] = new SqlParameter("@Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[2],poBOT_Entrega_Producto_Terminado_Almacen.Fecha);
			par[3] = new SqlParameter("@Numero_Guia",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[3],poBOT_Entrega_Producto_Terminado_Almacen.Numero_Guia);
			par[4] = new SqlParameter("@Unidades_Acumuladas",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[4],poBOT_Entrega_Producto_Terminado_Almacen.Unidades_Acumuladas);
			par[5] = new SqlParameter("@Total",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[5],poBOT_Entrega_Producto_Terminado_Almacen.Total);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsT_Entrega_Producto_Terminado_Almacen", par);
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
		public Boolean fnUpdT_Entrega_Producto_Terminado_Almacen(BOT_Entrega_Producto_Terminado_Almacen poBOT_Entrega_Producto_Terminado_Almacen)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[6];
			par[0] = new SqlParameter("@Codigo_Entrega_Producto_Terminado_Almacen",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Entrega_Producto_Terminado_Almacen.Codigo_Entrega_Producto_Terminado_Almacen);
			par[1] = new SqlParameter("@Codigo_Registro_Entrega",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Entrega_Producto_Terminado_Almacen.Codigo_Registro_Entrega);
			par[2] = new SqlParameter("@Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[2],poBOT_Entrega_Producto_Terminado_Almacen.Fecha);
			par[3] = new SqlParameter("@Numero_Guia",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[3],poBOT_Entrega_Producto_Terminado_Almacen.Numero_Guia);
			par[4] = new SqlParameter("@Unidades_Acumuladas",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[4],poBOT_Entrega_Producto_Terminado_Almacen.Unidades_Acumuladas);
			par[5] = new SqlParameter("@Total",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[5],poBOT_Entrega_Producto_Terminado_Almacen.Total);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_UpdT_Entrega_Producto_Terminado_Almacen", par);
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

		public Boolean fnInsUpdT_Entrega_Producto_Terminado_Almacen(BOT_Entrega_Producto_Terminado_Almacen poBOT_Entrega_Producto_Terminado_Almacen)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[6];
			par[0] = new SqlParameter("@Codigo_Entrega_Producto_Terminado_Almacen",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Entrega_Producto_Terminado_Almacen.Codigo_Entrega_Producto_Terminado_Almacen);
			par[1] = new SqlParameter("@Codigo_Registro_Entrega",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Entrega_Producto_Terminado_Almacen.Codigo_Registro_Entrega);
			par[2] = new SqlParameter("@Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[2],poBOT_Entrega_Producto_Terminado_Almacen.Fecha);
			par[3] = new SqlParameter("@Numero_Guia",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[3],poBOT_Entrega_Producto_Terminado_Almacen.Numero_Guia);
			par[4] = new SqlParameter("@Unidades_Acumuladas",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[4],poBOT_Entrega_Producto_Terminado_Almacen.Unidades_Acumuladas);
			par[5] = new SqlParameter("@Total",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[5],poBOT_Entrega_Producto_Terminado_Almacen.Total);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsUpdT_Entrega_Producto_Terminado_Almacen", par);
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
		public Boolean fnDelT_Entrega_Producto_Terminado_Almacen(String psCodigo_Entrega_Producto_Terminado_Almacen)
		{
			Boolean lbResultado=true;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			SqlParameter[] par = new SqlParameter[1];
			//cambiar aca:
			par[0] = new SqlParameter("@Codigo_Entrega_Producto_Terminado_Almacen",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Entrega_Producto_Terminado_Almacen;
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_DelT_Entrega_Producto_Terminado_Almacen", par);
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

		public List<BOT_Entrega_Producto_Terminado_Almacen> fnSelT_Entrega_Producto_Terminado_AlmacenAll()
		{
			List<BOT_Entrega_Producto_Terminado_Almacen> loList = new List<BOT_Entrega_Producto_Terminado_Almacen>();
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Entrega_Producto_Terminado_AlmacensAll");
				while (loDr.Read())
                {
					BOT_Entrega_Producto_Terminado_Almacen loBOT_Entrega_Producto_Terminado_Almacen=new BOT_Entrega_Producto_Terminado_Almacen();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Entrega_Producto_Terminado_Almacen"));
					loBOT_Entrega_Producto_Terminado_Almacen.Codigo_Entrega_Producto_Terminado_Almacen = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Entrega"));
					loBOT_Entrega_Producto_Terminado_Almacen.Codigo_Registro_Entrega = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Fecha"));
					loBOT_Entrega_Producto_Terminado_Almacen.Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Numero_Guia"));
					loBOT_Entrega_Producto_Terminado_Almacen.Numero_Guia = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Unidades_Acumuladas"));
					loBOT_Entrega_Producto_Terminado_Almacen.Unidades_Acumuladas = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Total"));
					loBOT_Entrega_Producto_Terminado_Almacen.Total = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Entrega_Producto_Terminado_Almacen);
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

		public BOT_Entrega_Producto_Terminado_Almacen fnSelT_Entrega_Producto_Terminado_Almacen(String psCodigo_Entrega_Producto_Terminado_Almacen)
		{
			BOT_Entrega_Producto_Terminado_Almacen loBOT_Entrega_Producto_Terminado_Almacen = new BOT_Entrega_Producto_Terminado_Almacen();
			//parametros
			
			SqlParameter[] par = new SqlParameter[1];
			par[0] = new SqlParameter("@Codigo_Entrega_Producto_Terminado_Almacen",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Entrega_Producto_Terminado_Almacen;
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Entrega_Producto_Terminado_Almacen", par);
				while(loDr.Read()){//----------------------------------------------------- AQUI
					if (loDr != null)
					{
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Entrega_Producto_Terminado_Almacen"));
					loBOT_Entrega_Producto_Terminado_Almacen.Codigo_Entrega_Producto_Terminado_Almacen = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Entrega"));
					loBOT_Entrega_Producto_Terminado_Almacen.Codigo_Registro_Entrega = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Fecha"));
					loBOT_Entrega_Producto_Terminado_Almacen.Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Numero_Guia"));
					loBOT_Entrega_Producto_Terminado_Almacen.Numero_Guia = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Unidades_Acumuladas"));
					loBOT_Entrega_Producto_Terminado_Almacen.Unidades_Acumuladas = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Total"));
					loBOT_Entrega_Producto_Terminado_Almacen.Total = value != System.DBNull.Value ? (String)value : default(String);
						
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
			return loBOT_Entrega_Producto_Terminado_Almacen;
		}
		public List<BOT_Entrega_Producto_Terminado_Almacen> fnSelT_Entrega_Producto_Terminado_AlmacenDin(string psWhere,string psOrder)
		{
			List<BOT_Entrega_Producto_Terminado_Almacen> loList = new List<BOT_Entrega_Producto_Terminado_Almacen>();
			SqlParameter[] par = new SqlParameter[2];
			par[0] = new SqlParameter("@WhereCondition",System.Data.SqlDbType.VarChar,500);
			par[0].Value= psWhere;
			par[1] = new SqlParameter("@OrderByExpression",System.Data.SqlDbType.VarChar,250);
			par[1].Value= psOrder;
			object value;//------------------------- 1
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Entrega_Producto_Terminado_AlmacensDin",par);
				while (loDr.Read())
                {
					BOT_Entrega_Producto_Terminado_Almacen loBOT_Entrega_Producto_Terminado_Almacen=new BOT_Entrega_Producto_Terminado_Almacen();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Entrega_Producto_Terminado_Almacen"));
					loBOT_Entrega_Producto_Terminado_Almacen.Codigo_Entrega_Producto_Terminado_Almacen = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Entrega"));
					loBOT_Entrega_Producto_Terminado_Almacen.Codigo_Registro_Entrega = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Fecha"));
					loBOT_Entrega_Producto_Terminado_Almacen.Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Numero_Guia"));
					loBOT_Entrega_Producto_Terminado_Almacen.Numero_Guia = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Unidades_Acumuladas"));
					loBOT_Entrega_Producto_Terminado_Almacen.Unidades_Acumuladas = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Total"));
					loBOT_Entrega_Producto_Terminado_Almacen.Total = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Entrega_Producto_Terminado_Almacen);
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
		public Int32[] fnSelT_Entrega_Producto_Terminado_AlmacenMinMax()
        {
            Int32[] laMinMax=new Int32[2];
            try
			{
                SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Entrega_Producto_Terminado_AlmacenMinMax");
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

