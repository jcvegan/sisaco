using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using BO_SISACO;

namespace BDA_SISACO
{	
	public partial class BDAT_Registro_Codificacion_Despeje_Linea_Area:BDABase
	{
		public Boolean fnInsT_Registro_Codificacion_Despeje_Linea_Area(BOT_Registro_Codificacion_Despeje_Linea_Area poBOT_Registro_Codificacion_Despeje_Linea_Area)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[8];
			par[0] = new SqlParameter("@Codigo_Registro_Codificacion_Despeje_Linea_Area",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Registro_Codificacion_Despeje_Linea_Area.Codigo_Registro_Codificacion_Despeje_Linea_Area);
			par[1] = new SqlParameter("@Codigo_Registro_Codificacion_Despeje_Linea",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Registro_Codificacion_Despeje_Linea_Area.Codigo_Registro_Codificacion_Despeje_Linea);
			par[2] = new SqlParameter("@Area_Limpia",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[2],poBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Limpia);
			par[3] = new SqlParameter("@Area_Ordenada",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[3],poBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Ordenada);
			par[4] = new SqlParameter("@Area_Libre_Producto_Anterior",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[4],poBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Libre_Producto_Anterior);
			par[5] = new SqlParameter("@Area_Identificada",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[5],poBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Identificada);
			par[6] = new SqlParameter("@Area_Materiales_Limpios_Secos",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[6],poBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Materiales_Limpios_Secos);
			par[7] = new SqlParameter("@Area_Correcta_Iluminacion_Ventilacion",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[7],poBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Correcta_Iluminacion_Ventilacion);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsT_Registro_Codificacion_Despeje_Linea_Area", par);
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
		public Boolean fnUpdT_Registro_Codificacion_Despeje_Linea_Area(BOT_Registro_Codificacion_Despeje_Linea_Area poBOT_Registro_Codificacion_Despeje_Linea_Area)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[8];
			par[0] = new SqlParameter("@Codigo_Registro_Codificacion_Despeje_Linea_Area",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Registro_Codificacion_Despeje_Linea_Area.Codigo_Registro_Codificacion_Despeje_Linea_Area);
			par[1] = new SqlParameter("@Codigo_Registro_Codificacion_Despeje_Linea",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Registro_Codificacion_Despeje_Linea_Area.Codigo_Registro_Codificacion_Despeje_Linea);
			par[2] = new SqlParameter("@Area_Limpia",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[2],poBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Limpia);
			par[3] = new SqlParameter("@Area_Ordenada",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[3],poBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Ordenada);
			par[4] = new SqlParameter("@Area_Libre_Producto_Anterior",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[4],poBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Libre_Producto_Anterior);
			par[5] = new SqlParameter("@Area_Identificada",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[5],poBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Identificada);
			par[6] = new SqlParameter("@Area_Materiales_Limpios_Secos",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[6],poBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Materiales_Limpios_Secos);
			par[7] = new SqlParameter("@Area_Correcta_Iluminacion_Ventilacion",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[7],poBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Correcta_Iluminacion_Ventilacion);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_UpdT_Registro_Codificacion_Despeje_Linea_Area", par);
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

		public Boolean fnInsUpdT_Registro_Codificacion_Despeje_Linea_Area(BOT_Registro_Codificacion_Despeje_Linea_Area poBOT_Registro_Codificacion_Despeje_Linea_Area,out string codigo_registro_codificacion_despeje_linea_area)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[8];
			par[0] = new SqlParameter("@Codigo_Registro_Codificacion_Despeje_Linea_Area",System.Data.SqlDbType.VarChar,10);
            par[0].Direction = ParameterDirection.Output;
			ValidateAndInsertValue(par[0],poBOT_Registro_Codificacion_Despeje_Linea_Area.Codigo_Registro_Codificacion_Despeje_Linea_Area);
			par[1] = new SqlParameter("@Codigo_Registro_Codificacion_Despeje_Linea",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Registro_Codificacion_Despeje_Linea_Area.Codigo_Registro_Codificacion_Despeje_Linea);
			par[2] = new SqlParameter("@Area_Limpia",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[2],poBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Limpia);
			par[3] = new SqlParameter("@Area_Ordenada",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[3],poBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Ordenada);
			par[4] = new SqlParameter("@Area_Libre_Producto_Anterior",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[4],poBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Libre_Producto_Anterior);
			par[5] = new SqlParameter("@Area_Identificada",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[5],poBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Identificada);
			par[6] = new SqlParameter("@Area_Materiales_Limpios_Secos",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[6],poBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Materiales_Limpios_Secos);
			par[7] = new SqlParameter("@Area_Correcta_Iluminacion_Ventilacion",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[7],poBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Correcta_Iluminacion_Ventilacion);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsUpdT_Registro_Codificacion_Despeje_Linea_Area", par);
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
                codigo_registro_codificacion_despeje_linea_area = par[0].Value.ToString();
			}

			return lbResultado;
		}
		public Boolean fnDelT_Registro_Codificacion_Despeje_Linea_Area(String psCodigo_Registro_Codificacion_Despeje_Linea_Area)
		{
			Boolean lbResultado=true;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			SqlParameter[] par = new SqlParameter[1];
			//cambiar aca:
			par[0] = new SqlParameter("@Codigo_Registro_Codificacion_Despeje_Linea_Area",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Registro_Codificacion_Despeje_Linea_Area;
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_DelT_Registro_Codificacion_Despeje_Linea_Area", par);
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

		public List<BOT_Registro_Codificacion_Despeje_Linea_Area> fnSelT_Registro_Codificacion_Despeje_Linea_AreaAll()
		{
			List<BOT_Registro_Codificacion_Despeje_Linea_Area> loList = new List<BOT_Registro_Codificacion_Despeje_Linea_Area>();
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Codificacion_Despeje_Linea_AreasAll");
				while (loDr.Read())
                {
					BOT_Registro_Codificacion_Despeje_Linea_Area loBOT_Registro_Codificacion_Despeje_Linea_Area=new BOT_Registro_Codificacion_Despeje_Linea_Area();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Codificacion_Despeje_Linea_Area"));
					loBOT_Registro_Codificacion_Despeje_Linea_Area.Codigo_Registro_Codificacion_Despeje_Linea_Area = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Codificacion_Despeje_Linea"));
					loBOT_Registro_Codificacion_Despeje_Linea_Area.Codigo_Registro_Codificacion_Despeje_Linea = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Area_Limpia"));
					loBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Limpia = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Area_Ordenada"));
					loBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Ordenada = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Area_Libre_Producto_Anterior"));
					loBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Libre_Producto_Anterior = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Area_Identificada"));
					loBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Identificada = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Area_Materiales_Limpios_Secos"));
					loBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Materiales_Limpios_Secos = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Area_Correcta_Iluminacion_Ventilacion"));
					loBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Correcta_Iluminacion_Ventilacion = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Registro_Codificacion_Despeje_Linea_Area);
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

		public BOT_Registro_Codificacion_Despeje_Linea_Area fnSelT_Registro_Codificacion_Despeje_Linea_Area(String psCodigo_Registro_Codificacion_Despeje_Linea_Area)
		{
			BOT_Registro_Codificacion_Despeje_Linea_Area loBOT_Registro_Codificacion_Despeje_Linea_Area = new BOT_Registro_Codificacion_Despeje_Linea_Area();
			//parametros
			
			SqlParameter[] par = new SqlParameter[1];
			par[0] = new SqlParameter("@Codigo_Registro_Codificacion_Despeje_Linea_Area",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Registro_Codificacion_Despeje_Linea_Area;
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Codificacion_Despeje_Linea_Area", par);
				while(loDr.Read()){//----------------------------------------------------- AQUI
					if (loDr != null)
					{
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Codificacion_Despeje_Linea_Area"));
					loBOT_Registro_Codificacion_Despeje_Linea_Area.Codigo_Registro_Codificacion_Despeje_Linea_Area = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Codificacion_Despeje_Linea"));
					loBOT_Registro_Codificacion_Despeje_Linea_Area.Codigo_Registro_Codificacion_Despeje_Linea = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Area_Limpia"));
					loBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Limpia = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Area_Ordenada"));
					loBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Ordenada = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Area_Libre_Producto_Anterior"));
					loBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Libre_Producto_Anterior = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Area_Identificada"));
					loBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Identificada = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Area_Materiales_Limpios_Secos"));
					loBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Materiales_Limpios_Secos = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Area_Correcta_Iluminacion_Ventilacion"));
					loBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Correcta_Iluminacion_Ventilacion = value != System.DBNull.Value ? (String)value : default(String);
						
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
			return loBOT_Registro_Codificacion_Despeje_Linea_Area;
		}
		public List<BOT_Registro_Codificacion_Despeje_Linea_Area> fnSelT_Registro_Codificacion_Despeje_Linea_AreaDin(string psWhere,string psOrder)
		{
			List<BOT_Registro_Codificacion_Despeje_Linea_Area> loList = new List<BOT_Registro_Codificacion_Despeje_Linea_Area>();
			SqlParameter[] par = new SqlParameter[2];
			par[0] = new SqlParameter("@WhereCondition",System.Data.SqlDbType.VarChar,500);
			par[0].Value= psWhere;
			par[1] = new SqlParameter("@OrderByExpression",System.Data.SqlDbType.VarChar,250);
			par[1].Value= psOrder;
			object value;//------------------------- 1
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Codificacion_Despeje_Linea_AreasDin",par);
				while (loDr.Read())
                {
					BOT_Registro_Codificacion_Despeje_Linea_Area loBOT_Registro_Codificacion_Despeje_Linea_Area=new BOT_Registro_Codificacion_Despeje_Linea_Area();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Codificacion_Despeje_Linea_Area"));
					loBOT_Registro_Codificacion_Despeje_Linea_Area.Codigo_Registro_Codificacion_Despeje_Linea_Area = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Codificacion_Despeje_Linea"));
					loBOT_Registro_Codificacion_Despeje_Linea_Area.Codigo_Registro_Codificacion_Despeje_Linea = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Area_Limpia"));
					loBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Limpia = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Area_Ordenada"));
					loBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Ordenada = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Area_Libre_Producto_Anterior"));
					loBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Libre_Producto_Anterior = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Area_Identificada"));
					loBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Identificada = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Area_Materiales_Limpios_Secos"));
					loBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Materiales_Limpios_Secos = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Area_Correcta_Iluminacion_Ventilacion"));
					loBOT_Registro_Codificacion_Despeje_Linea_Area.Area_Correcta_Iluminacion_Ventilacion = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Registro_Codificacion_Despeje_Linea_Area);
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
		public Int32[] fnSelT_Registro_Codificacion_Despeje_Linea_AreaMinMax()
        {
            Int32[] laMinMax=new Int32[2];
            try
			{
                SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Registro_Codificacion_Despeje_Linea_AreaMinMax");
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

