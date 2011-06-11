using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using BO_SISACO;

namespace BDA_SISACO
{	
	public partial class BDAT_Material_Empaque:BDABase
	{
		public Boolean fnInsT_Material_Empaque(BOT_Material_Empaque poBOT_Material_Empaque)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[3];
			par[0] = new SqlParameter("@Codigo_Material_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Material_Empaque.Codigo_Material_Empaque);
			par[1] = new SqlParameter("@Nombre_Material_Empaque",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[1],poBOT_Material_Empaque.Nombre_Material_Empaque);
			par[2] = new SqlParameter("@Unidad_Medida",System.Data.SqlDbType.VarChar,5);
			ValidateAndInsertValue(par[2],poBOT_Material_Empaque.Unidad_Medida);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsT_Material_Empaque", par);
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
		public Boolean fnUpdT_Material_Empaque(BOT_Material_Empaque poBOT_Material_Empaque)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[3];
			par[0] = new SqlParameter("@Codigo_Material_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Material_Empaque.Codigo_Material_Empaque);
			par[1] = new SqlParameter("@Nombre_Material_Empaque",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[1],poBOT_Material_Empaque.Nombre_Material_Empaque);
			par[2] = new SqlParameter("@Unidad_Medida",System.Data.SqlDbType.VarChar,5);
			ValidateAndInsertValue(par[2],poBOT_Material_Empaque.Unidad_Medida);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_UpdT_Material_Empaque", par);
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

		public Boolean fnInsUpdT_Material_Empaque(BOT_Material_Empaque poBOT_Material_Empaque)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[3];
			par[0] = new SqlParameter("@Codigo_Material_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Material_Empaque.Codigo_Material_Empaque);
			par[1] = new SqlParameter("@Nombre_Material_Empaque",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[1],poBOT_Material_Empaque.Nombre_Material_Empaque);
			par[2] = new SqlParameter("@Unidad_Medida",System.Data.SqlDbType.VarChar,5);
			ValidateAndInsertValue(par[2],poBOT_Material_Empaque.Unidad_Medida);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsUpdT_Material_Empaque", par);
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
		public Boolean fnDelT_Material_Empaque(String psCodigo_Material_Empaque)
		{
			Boolean lbResultado=true;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			SqlParameter[] par = new SqlParameter[1];
			//cambiar aca:
			par[0] = new SqlParameter("@Codigo_Material_Empaque",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Material_Empaque;
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_DelT_Material_Empaque", par);
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

		public List<BOT_Material_Empaque> fnSelT_Material_EmpaqueAll()
		{
			List<BOT_Material_Empaque> loList = new List<BOT_Material_Empaque>();
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Material_EmpaquesAll");
				while (loDr.Read())
                {
					BOT_Material_Empaque loBOT_Material_Empaque=new BOT_Material_Empaque();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Material_Empaque"));
					loBOT_Material_Empaque.Codigo_Material_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Nombre_Material_Empaque"));
					loBOT_Material_Empaque.Nombre_Material_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Unidad_Medida"));
					loBOT_Material_Empaque.Unidad_Medida = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Material_Empaque);
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

		public BOT_Material_Empaque fnSelT_Material_Empaque(String psCodigo_Material_Empaque)
		{
			BOT_Material_Empaque loBOT_Material_Empaque = new BOT_Material_Empaque();
			//parametros
			
			SqlParameter[] par = new SqlParameter[1];
			par[0] = new SqlParameter("@Codigo_Material_Empaque",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Material_Empaque;
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Material_Empaque", par);
				while(loDr.Read()){//----------------------------------------------------- AQUI
					if (loDr != null)
					{
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Material_Empaque"));
					loBOT_Material_Empaque.Codigo_Material_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Nombre_Material_Empaque"));
					loBOT_Material_Empaque.Nombre_Material_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Unidad_Medida"));
					loBOT_Material_Empaque.Unidad_Medida = value != System.DBNull.Value ? (String)value : default(String);
						
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
			return loBOT_Material_Empaque;
		}
		public List<BOT_Material_Empaque> fnSelT_Material_EmpaqueDin(string psWhere,string psOrder)
		{
			List<BOT_Material_Empaque> loList = new List<BOT_Material_Empaque>();
			SqlParameter[] par = new SqlParameter[2];
			par[0] = new SqlParameter("@WhereCondition",System.Data.SqlDbType.VarChar,500);
			par[0].Value= psWhere;
			par[1] = new SqlParameter("@OrderByExpression",System.Data.SqlDbType.VarChar,250);
			par[1].Value= psOrder;
			object value;//------------------------- 1
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Material_EmpaquesDin",par);
				while (loDr.Read())
                {
					BOT_Material_Empaque loBOT_Material_Empaque=new BOT_Material_Empaque();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Material_Empaque"));
					loBOT_Material_Empaque.Codigo_Material_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Nombre_Material_Empaque"));
					loBOT_Material_Empaque.Nombre_Material_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Unidad_Medida"));
					loBOT_Material_Empaque.Unidad_Medida = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Material_Empaque);
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
		public Int32[] fnSelT_Material_EmpaqueMinMax()
        {
            Int32[] laMinMax=new Int32[2];
            try
			{
                SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Material_EmpaqueMinMax");
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

        public string fnSelT_Material_EmpaqueCodigo()
        {
            SqlTransaction loTx;
            SqlConnection loCn = new SqlConnection();
            loCn.ConnectionString = ClassCadena.fnConexion();
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@Codigo_Material_Empaque", SqlDbType.VarChar, 10);
            par[0].Direction = ParameterDirection.Output;

            loCn.Open();
            loTx = loCn.BeginTransaction();
            SqlCommand oSqlCommmand;
            try
            {
                oSqlCommmand = new SqlCommand("usp_SelT_Material_Empaque_Codigo", loCn,loTx);
                oSqlCommmand.CommandType = CommandType.StoredProcedure;
                oSqlCommmand.Parameters.Add(par[0]);
                //object[] result = SqlHelper.ExecuteNonQueryReturnValue(ClassCadena.fnConexion(), "usp_SelT_Material_Empaque_Codigo", par);
                //loTx.Commit();
                oSqlCommmand.ExecuteNonQuery();
                string returnValue = oSqlCommmand.Parameters["@Codigo_Material_Empaque"].Value.ToString();
                return returnValue;
            }
            catch
            {
                return string.Empty;
            }
            finally
            {
                loCn.Close();
                loCn.Dispose();
            }
        }
	}
}

