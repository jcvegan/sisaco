using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using BO_SISACO;

namespace BDA_SISACO
{	
	public partial class BDAT_Entrega_Producto_Empacar:BDABase
	{
		public Boolean fnInsT_Entrega_Producto_Empacar(BOT_Entrega_Producto_Empacar poBOT_Entrega_Producto_Empacar)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[6];
			par[0] = new SqlParameter("@Codigo_Entrega_Producto_Empacar",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Entrega_Producto_Empacar.Codigo_Entrega_Producto_Empacar);
			par[1] = new SqlParameter("@Codigo_Registro_Entrega",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Entrega_Producto_Empacar.Codigo_Registro_Entrega);
			par[2] = new SqlParameter("@Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[2],poBOT_Entrega_Producto_Empacar.Fecha);
			par[3] = new SqlParameter("@Promedio",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[3],poBOT_Entrega_Producto_Empacar.Promedio);
			par[4] = new SqlParameter("@Peso_Total",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[4],poBOT_Entrega_Producto_Empacar.Peso_Total);
			par[5] = new SqlParameter("@Unidades",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[5],poBOT_Entrega_Producto_Empacar.Unidades);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsT_Entrega_Producto_Empacar", par);
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
		public Boolean fnUpdT_Entrega_Producto_Empacar(BOT_Entrega_Producto_Empacar poBOT_Entrega_Producto_Empacar)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[6];
			par[0] = new SqlParameter("@Codigo_Entrega_Producto_Empacar",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Entrega_Producto_Empacar.Codigo_Entrega_Producto_Empacar);
			par[1] = new SqlParameter("@Codigo_Registro_Entrega",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Entrega_Producto_Empacar.Codigo_Registro_Entrega);
			par[2] = new SqlParameter("@Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[2],poBOT_Entrega_Producto_Empacar.Fecha);
			par[3] = new SqlParameter("@Promedio",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[3],poBOT_Entrega_Producto_Empacar.Promedio);
			par[4] = new SqlParameter("@Peso_Total",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[4],poBOT_Entrega_Producto_Empacar.Peso_Total);
			par[5] = new SqlParameter("@Unidades",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[5],poBOT_Entrega_Producto_Empacar.Unidades);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_UpdT_Entrega_Producto_Empacar", par);
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

		public Boolean fnInsUpdT_Entrega_Producto_Empacar(BOT_Entrega_Producto_Empacar poBOT_Entrega_Producto_Empacar)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[6];
			par[0] = new SqlParameter("@Codigo_Entrega_Producto_Empacar",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Entrega_Producto_Empacar.Codigo_Entrega_Producto_Empacar);
			par[1] = new SqlParameter("@Codigo_Registro_Entrega",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Entrega_Producto_Empacar.Codigo_Registro_Entrega);
			par[2] = new SqlParameter("@Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[2],poBOT_Entrega_Producto_Empacar.Fecha);
			par[3] = new SqlParameter("@Promedio",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[3],poBOT_Entrega_Producto_Empacar.Promedio);
			par[4] = new SqlParameter("@Peso_Total",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[4],poBOT_Entrega_Producto_Empacar.Peso_Total);
			par[5] = new SqlParameter("@Unidades",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[5],poBOT_Entrega_Producto_Empacar.Unidades);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsUpdT_Entrega_Producto_Empacar", par);
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
		public Boolean fnDelT_Entrega_Producto_Empacar(String psCodigo_Entrega_Producto_Empacar)
		{
			Boolean lbResultado=true;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			SqlParameter[] par = new SqlParameter[1];
			//cambiar aca:
			par[0] = new SqlParameter("@Codigo_Entrega_Producto_Empacar",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Entrega_Producto_Empacar;
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_DelT_Entrega_Producto_Empacar", par);
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

		public List<BOT_Entrega_Producto_Empacar> fnSelT_Entrega_Producto_EmpacarAll()
		{
			List<BOT_Entrega_Producto_Empacar> loList = new List<BOT_Entrega_Producto_Empacar>();
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Entrega_Producto_EmpacarsAll");
				while (loDr.Read())
                {
					BOT_Entrega_Producto_Empacar loBOT_Entrega_Producto_Empacar=new BOT_Entrega_Producto_Empacar();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Entrega_Producto_Empacar"));
					loBOT_Entrega_Producto_Empacar.Codigo_Entrega_Producto_Empacar = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Entrega"));
					loBOT_Entrega_Producto_Empacar.Codigo_Registro_Entrega = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Fecha"));
					loBOT_Entrega_Producto_Empacar.Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Promedio"));
					loBOT_Entrega_Producto_Empacar.Promedio = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
					value = loDr.GetValue(loDr.GetOrdinal("Peso_Total"));
					loBOT_Entrega_Producto_Empacar.Peso_Total = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
					value = loDr.GetValue(loDr.GetOrdinal("Unidades"));
					loBOT_Entrega_Producto_Empacar.Unidades = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
                    loList.Add(loBOT_Entrega_Producto_Empacar);
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

		public BOT_Entrega_Producto_Empacar fnSelT_Entrega_Producto_Empacar(String psCodigo_Entrega_Producto_Empacar)
		{
			BOT_Entrega_Producto_Empacar loBOT_Entrega_Producto_Empacar = new BOT_Entrega_Producto_Empacar();
			//parametros
			
			SqlParameter[] par = new SqlParameter[1];
			par[0] = new SqlParameter("@Codigo_Entrega_Producto_Empacar",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Entrega_Producto_Empacar;
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Entrega_Producto_Empacar", par);
				while(loDr.Read()){//----------------------------------------------------- AQUI
					if (loDr != null)
					{
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Entrega_Producto_Empacar"));
					loBOT_Entrega_Producto_Empacar.Codigo_Entrega_Producto_Empacar = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Entrega"));
					loBOT_Entrega_Producto_Empacar.Codigo_Registro_Entrega = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Fecha"));
					loBOT_Entrega_Producto_Empacar.Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Promedio"));
					loBOT_Entrega_Producto_Empacar.Promedio = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
					value = loDr.GetValue(loDr.GetOrdinal("Peso_Total"));
					loBOT_Entrega_Producto_Empacar.Peso_Total = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
					value = loDr.GetValue(loDr.GetOrdinal("Unidades"));
					loBOT_Entrega_Producto_Empacar.Unidades = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
						
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
			return loBOT_Entrega_Producto_Empacar;
		}
		public List<BOT_Entrega_Producto_Empacar> fnSelT_Entrega_Producto_EmpacarDin(string psWhere,string psOrder)
		{
			List<BOT_Entrega_Producto_Empacar> loList = new List<BOT_Entrega_Producto_Empacar>();
			SqlParameter[] par = new SqlParameter[2];
			par[0] = new SqlParameter("@WhereCondition",System.Data.SqlDbType.VarChar,500);
			par[0].Value= psWhere;
			par[1] = new SqlParameter("@OrderByExpression",System.Data.SqlDbType.VarChar,250);
			par[1].Value= psOrder;
			object value;//------------------------- 1
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Entrega_Producto_EmpacarsDin",par);
				while (loDr.Read())
                {
					BOT_Entrega_Producto_Empacar loBOT_Entrega_Producto_Empacar=new BOT_Entrega_Producto_Empacar();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Entrega_Producto_Empacar"));
					loBOT_Entrega_Producto_Empacar.Codigo_Entrega_Producto_Empacar = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Registro_Entrega"));
					loBOT_Entrega_Producto_Empacar.Codigo_Registro_Entrega = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Fecha"));
					loBOT_Entrega_Producto_Empacar.Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
					value = loDr.GetValue(loDr.GetOrdinal("Promedio"));
					loBOT_Entrega_Producto_Empacar.Promedio = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
					value = loDr.GetValue(loDr.GetOrdinal("Peso_Total"));
					loBOT_Entrega_Producto_Empacar.Peso_Total = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
					value = loDr.GetValue(loDr.GetOrdinal("Unidades"));
					loBOT_Entrega_Producto_Empacar.Unidades = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
                    loList.Add(loBOT_Entrega_Producto_Empacar);
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
		public Int32[] fnSelT_Entrega_Producto_EmpacarMinMax()
        {
            Int32[] laMinMax=new Int32[2];
            try
			{
                SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Entrega_Producto_EmpacarMinMax");
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

