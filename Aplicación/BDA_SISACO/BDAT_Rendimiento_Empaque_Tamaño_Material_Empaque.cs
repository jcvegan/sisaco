using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using BO_SISACO;

namespace BDA_SISACO
{	
	public partial class BDAT_Rendimiento_Empaque_Tamaño_Material_Empaque:BDABase
	{
		public Boolean fnInsT_Rendimiento_Empaque_Tamaño_Material_Empaque(BOT_Rendimiento_Empaque_Tamaño_Material_Empaque poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[10];
			par[0] = new SqlParameter("@Codigo_Rendimiento_Empaque_Tamaño_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Codigo_Rendimiento_Empaque_Tamaño_Empaque);
			par[1] = new SqlParameter("@Codigo_Rendimiento_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Codigo_Rendimiento_Empaque);
			par[2] = new SqlParameter("@Codigo_Material_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[2],poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Codigo_Material_Empaque);
			par[3] = new SqlParameter("@Nombre_Material_Empaque",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[3],poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Nombre_Material_Empaque);
			par[4] = new SqlParameter("@Cantidad_Entregada",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[4],poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Cantidad_Entregada);
			par[5] = new SqlParameter("@Cantidad_Devuelto",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[5],poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Cantidad_Devuelto);
			par[6] = new SqlParameter("@Cantidad_Empleado",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[6],poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Cantidad_Empleado);
			par[7] = new SqlParameter("@Cantidad_Merma",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[7],poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Cantidad_Merma);
			par[8] = new SqlParameter("@Rendimiento",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[8],poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Rendimiento);
			par[9] = new SqlParameter("@Conciliacion",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[9],poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Conciliacion);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsT_Rendimiento_Empaque_Tamaño_Material_Empaque", par);
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
		public Boolean fnUpdT_Rendimiento_Empaque_Tamaño_Material_Empaque(BOT_Rendimiento_Empaque_Tamaño_Material_Empaque poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[10];
			par[0] = new SqlParameter("@Codigo_Rendimiento_Empaque_Tamaño_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Codigo_Rendimiento_Empaque_Tamaño_Empaque);
			par[1] = new SqlParameter("@Codigo_Rendimiento_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Codigo_Rendimiento_Empaque);
			par[2] = new SqlParameter("@Codigo_Material_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[2],poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Codigo_Material_Empaque);
			par[3] = new SqlParameter("@Nombre_Material_Empaque",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[3],poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Nombre_Material_Empaque);
			par[4] = new SqlParameter("@Cantidad_Entregada",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[4],poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Cantidad_Entregada);
			par[5] = new SqlParameter("@Cantidad_Devuelto",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[5],poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Cantidad_Devuelto);
			par[6] = new SqlParameter("@Cantidad_Empleado",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[6],poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Cantidad_Empleado);
			par[7] = new SqlParameter("@Cantidad_Merma",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[7],poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Cantidad_Merma);
			par[8] = new SqlParameter("@Rendimiento",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[8],poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Rendimiento);
			par[9] = new SqlParameter("@Conciliacion",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[9],poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Conciliacion);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_UpdT_Rendimiento_Empaque_Tamaño_Material_Empaque", par);
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

		public Boolean fnInsUpdT_Rendimiento_Empaque_Tamaño_Material_Empaque(BOT_Rendimiento_Empaque_Tamaño_Material_Empaque poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[10];
			par[0] = new SqlParameter("@Codigo_Rendimiento_Empaque_Tamaño_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Codigo_Rendimiento_Empaque_Tamaño_Empaque);
			par[1] = new SqlParameter("@Codigo_Rendimiento_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Codigo_Rendimiento_Empaque);
			par[2] = new SqlParameter("@Codigo_Material_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[2],poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Codigo_Material_Empaque);
			par[3] = new SqlParameter("@Nombre_Material_Empaque",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[3],poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Nombre_Material_Empaque);
			par[4] = new SqlParameter("@Cantidad_Entregada",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[4],poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Cantidad_Entregada);
			par[5] = new SqlParameter("@Cantidad_Devuelto",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[5],poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Cantidad_Devuelto);
			par[6] = new SqlParameter("@Cantidad_Empleado",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[6],poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Cantidad_Empleado);
			par[7] = new SqlParameter("@Cantidad_Merma",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[7],poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Cantidad_Merma);
			par[8] = new SqlParameter("@Rendimiento",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[8],poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Rendimiento);
			par[9] = new SqlParameter("@Conciliacion",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[9],poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Conciliacion);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsUpdT_Rendimiento_Empaque_Tamaño_Material_Empaque", par);
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
		public Boolean fnDelT_Rendimiento_Empaque_Tamaño_Material_Empaque(String psCodigo_Rendimiento_Empaque_Tamaño_Empaque)
		{
			Boolean lbResultado=true;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			SqlParameter[] par = new SqlParameter[1];
			//cambiar aca:
			par[0] = new SqlParameter("@Codigo_Rendimiento_Empaque_Tamaño_Empaque",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Rendimiento_Empaque_Tamaño_Empaque;
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_DelT_Rendimiento_Empaque_Tamaño_Material_Empaque", par);
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

		public List<BOT_Rendimiento_Empaque_Tamaño_Material_Empaque> fnSelT_Rendimiento_Empaque_Tamaño_Material_EmpaqueAll()
		{
			List<BOT_Rendimiento_Empaque_Tamaño_Material_Empaque> loList = new List<BOT_Rendimiento_Empaque_Tamaño_Material_Empaque>();
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Rendimiento_Empaque_Tamaño_Material_EmpaquesAll");
				while (loDr.Read())
                {
					BOT_Rendimiento_Empaque_Tamaño_Material_Empaque loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque=new BOT_Rendimiento_Empaque_Tamaño_Material_Empaque();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Rendimiento_Empaque_Tamaño_Empaque"));
					loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Codigo_Rendimiento_Empaque_Tamaño_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Rendimiento_Empaque"));
					loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Codigo_Rendimiento_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Material_Empaque"));
					loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Codigo_Material_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Nombre_Material_Empaque"));
					loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Nombre_Material_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad_Entregada"));
					loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Cantidad_Entregada = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad_Devuelto"));
					loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Cantidad_Devuelto = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad_Empleado"));
					loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Cantidad_Empleado = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad_Merma"));
					loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Cantidad_Merma = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
					value = loDr.GetValue(loDr.GetOrdinal("Rendimiento"));
					loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Rendimiento = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
					value = loDr.GetValue(loDr.GetOrdinal("Conciliacion"));
					loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Conciliacion = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
                    loList.Add(loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque);
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

		public BOT_Rendimiento_Empaque_Tamaño_Material_Empaque fnSelT_Rendimiento_Empaque_Tamaño_Material_Empaque(String psCodigo_Rendimiento_Empaque_Tamaño_Empaque)
		{
			BOT_Rendimiento_Empaque_Tamaño_Material_Empaque loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque = new BOT_Rendimiento_Empaque_Tamaño_Material_Empaque();
			//parametros
			
			SqlParameter[] par = new SqlParameter[1];
			par[0] = new SqlParameter("@Codigo_Rendimiento_Empaque_Tamaño_Empaque",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Rendimiento_Empaque_Tamaño_Empaque;
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Rendimiento_Empaque_Tamaño_Material_Empaque", par);
				while(loDr.Read()){//----------------------------------------------------- AQUI
					if (loDr != null)
					{
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Rendimiento_Empaque_Tamaño_Empaque"));
					loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Codigo_Rendimiento_Empaque_Tamaño_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Rendimiento_Empaque"));
					loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Codigo_Rendimiento_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Material_Empaque"));
					loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Codigo_Material_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Nombre_Material_Empaque"));
					loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Nombre_Material_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad_Entregada"));
					loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Cantidad_Entregada = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad_Devuelto"));
					loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Cantidad_Devuelto = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad_Empleado"));
					loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Cantidad_Empleado = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad_Merma"));
					loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Cantidad_Merma = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
					value = loDr.GetValue(loDr.GetOrdinal("Rendimiento"));
					loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Rendimiento = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
					value = loDr.GetValue(loDr.GetOrdinal("Conciliacion"));
					loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Conciliacion = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
						
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
			return loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque;
		}
		public List<BOT_Rendimiento_Empaque_Tamaño_Material_Empaque> fnSelT_Rendimiento_Empaque_Tamaño_Material_EmpaqueDin(string psWhere,string psOrder)
		{
			List<BOT_Rendimiento_Empaque_Tamaño_Material_Empaque> loList = new List<BOT_Rendimiento_Empaque_Tamaño_Material_Empaque>();
			SqlParameter[] par = new SqlParameter[2];
			par[0] = new SqlParameter("@WhereCondition",System.Data.SqlDbType.VarChar,500);
			par[0].Value= psWhere;
			par[1] = new SqlParameter("@OrderByExpression",System.Data.SqlDbType.VarChar,250);
			par[1].Value= psOrder;
			object value;//------------------------- 1
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Rendimiento_Empaque_Tamaño_Material_EmpaquesDin",par);
				while (loDr.Read())
                {
					BOT_Rendimiento_Empaque_Tamaño_Material_Empaque loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque=new BOT_Rendimiento_Empaque_Tamaño_Material_Empaque();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Rendimiento_Empaque_Tamaño_Empaque"));
					loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Codigo_Rendimiento_Empaque_Tamaño_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Rendimiento_Empaque"));
					loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Codigo_Rendimiento_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Material_Empaque"));
					loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Codigo_Material_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Nombre_Material_Empaque"));
					loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Nombre_Material_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad_Entregada"));
					loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Cantidad_Entregada = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad_Devuelto"));
					loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Cantidad_Devuelto = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad_Empleado"));
					loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Cantidad_Empleado = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad_Merma"));
					loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Cantidad_Merma = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
					value = loDr.GetValue(loDr.GetOrdinal("Rendimiento"));
					loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Rendimiento = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
					value = loDr.GetValue(loDr.GetOrdinal("Conciliacion"));
					loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque.Conciliacion = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
                    loList.Add(loBOT_Rendimiento_Empaque_Tamaño_Material_Empaque);
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
		public Int32[] fnSelT_Rendimiento_Empaque_Tamaño_Material_EmpaqueMinMax()
        {
            Int32[] laMinMax=new Int32[2];
            try
			{
                SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Rendimiento_Empaque_Tamaño_Material_EmpaqueMinMax");
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

