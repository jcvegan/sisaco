using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using BO_SISACO;

namespace BDA_SISACO
{	
	public partial class BDAT_Producto:BDABase
	{
		public Boolean fnInsT_Producto(BOT_Producto poBOT_Producto)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[5];
			par[0] = new SqlParameter("@Codigo_Producto",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Producto.Codigo_Producto);
			par[1] = new SqlParameter("@Nombre_Producto",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[1],poBOT_Producto.Nombre_Producto);
			par[2] = new SqlParameter("@Forma_Farmaceutica",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[2],poBOT_Producto.Forma_Farmaceutica);
			par[3] = new SqlParameter("@Proceso",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[3],poBOT_Producto.Proceso);
			par[4] = new SqlParameter("@Presentacion",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[4],poBOT_Producto.Presentacion);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsT_Producto", par);
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
		public Boolean fnUpdT_Producto(BOT_Producto poBOT_Producto)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[5];
			par[0] = new SqlParameter("@Codigo_Producto",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Producto.Codigo_Producto);
			par[1] = new SqlParameter("@Nombre_Producto",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[1],poBOT_Producto.Nombre_Producto);
			par[2] = new SqlParameter("@Forma_Farmaceutica",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[2],poBOT_Producto.Forma_Farmaceutica);
			par[3] = new SqlParameter("@Proceso",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[3],poBOT_Producto.Proceso);
			par[4] = new SqlParameter("@Presentacion",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[4],poBOT_Producto.Presentacion);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_UpdT_Producto", par);
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

		public Boolean fnInsUpdT_Producto(BOT_Producto poBOT_Producto)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[5];
			par[0] = new SqlParameter("@Codigo_Producto",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Producto.Codigo_Producto);
			par[1] = new SqlParameter("@Nombre_Producto",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[1],poBOT_Producto.Nombre_Producto);
			par[2] = new SqlParameter("@Forma_Farmaceutica",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[2],poBOT_Producto.Forma_Farmaceutica);
			par[3] = new SqlParameter("@Proceso",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[3],poBOT_Producto.Proceso);
			par[4] = new SqlParameter("@Presentacion",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[4],poBOT_Producto.Presentacion);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsUpdT_Producto", par);
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
		public Boolean fnDelT_Producto(String psCodigo_Producto)
		{
			Boolean lbResultado=true;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			SqlParameter[] par = new SqlParameter[1];
			//cambiar aca:
			par[0] = new SqlParameter("@Codigo_Producto",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Producto;
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_DelT_Producto", par);
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

		public List<BOT_Producto> fnSelT_ProductoAll()
		{
			List<BOT_Producto> loList = new List<BOT_Producto>();
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_ProductosAll");
				while (loDr.Read())
                {
					BOT_Producto loBOT_Producto=new BOT_Producto();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Producto"));
					loBOT_Producto.Codigo_Producto = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Nombre_Producto"));
					loBOT_Producto.Nombre_Producto = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Forma_Farmaceutica"));
					loBOT_Producto.Forma_Farmaceutica = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Proceso"));
					loBOT_Producto.Proceso = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Presentacion"));
					loBOT_Producto.Presentacion = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Producto);
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

		public BOT_Producto fnSelT_Producto(String psCodigo_Producto)
		{
			BOT_Producto loBOT_Producto = new BOT_Producto();
			//parametros
			
			SqlParameter[] par = new SqlParameter[1];
			par[0] = new SqlParameter("@Codigo_Producto",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Producto;
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Producto", par);
				while(loDr.Read()){//----------------------------------------------------- AQUI
					if (loDr != null)
					{
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Producto"));
					loBOT_Producto.Codigo_Producto = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Nombre_Producto"));
					loBOT_Producto.Nombre_Producto = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Forma_Farmaceutica"));
					loBOT_Producto.Forma_Farmaceutica = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Proceso"));
					loBOT_Producto.Proceso = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Presentacion"));
					loBOT_Producto.Presentacion = value != System.DBNull.Value ? (String)value : default(String);
						
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
			return loBOT_Producto;
		}
		public List<BOT_Producto> fnSelT_ProductoDin(string psWhere,string psOrder)
		{
			List<BOT_Producto> loList = new List<BOT_Producto>();
			SqlParameter[] par = new SqlParameter[2];
			par[0] = new SqlParameter("@WhereCondition",System.Data.SqlDbType.VarChar,500);
			par[0].Value= psWhere;
			par[1] = new SqlParameter("@OrderByExpression",System.Data.SqlDbType.VarChar,250);
			par[1].Value= psOrder;
			object value;//------------------------- 1
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_ProductosDin",par);
				while (loDr.Read())
                {
					BOT_Producto loBOT_Producto=new BOT_Producto();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Producto"));
					loBOT_Producto.Codigo_Producto = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Nombre_Producto"));
					loBOT_Producto.Nombre_Producto = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Forma_Farmaceutica"));
					loBOT_Producto.Forma_Farmaceutica = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Proceso"));
					loBOT_Producto.Proceso = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Presentacion"));
					loBOT_Producto.Presentacion = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Producto);
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
		public Int32[] fnSelT_ProductoMinMax()
        {
            Int32[] laMinMax=new Int32[2];
            try
			{
                SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_ProductoMinMax");
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

        public String fnSelT_ProductoCodigo() {
            SqlTransaction loTx;
            SqlConnection loCn = new SqlConnection();
            loCn.ConnectionString = ClassCadena.fnConexion();
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@Codigo_Producto", SqlDbType.VarChar, 10);
            par[0].Direction = ParameterDirection.Output;

            loCn.Open();
            loTx = loCn.BeginTransaction();
            SqlCommand oSqlCommmand;
            try {
                oSqlCommmand = new SqlCommand("usp_SelT_Producto_Codigo", loCn, loTx);
                oSqlCommmand.CommandType = CommandType.StoredProcedure;
                oSqlCommmand.Parameters.Add(par[0]);
                //object[] result = SqlHelper.ExecuteNonQueryReturnValue(ClassCadena.fnConexion(), "usp_SelT_Material_Empaque_Codigo", par);
                //loTx.Commit();
                oSqlCommmand.ExecuteNonQuery();
                string returnValue = oSqlCommmand.Parameters["@Codigo_Producto"].Value.ToString();
                return returnValue;
            }
            catch {
                return string.Empty;
            }
            finally {
                loCn.Close();
                loCn.Dispose();
            }
        }

        public bool fnEsReferenciadoT_Producto(BOT_Producto producto) {
            SqlTransaction loTx;
            SqlConnection loCn = new SqlConnection();
            loCn.ConnectionString = ClassCadena.fnConexion();
            SqlParameter[] par = new SqlParameter[2];
            par[0] = new SqlParameter("@Codigo_Producto", SqlDbType.VarChar, 10);
            par[0].Value = producto.Codigo_Producto;
            par[1] = new SqlParameter("@Existe_Rerefencia", SqlDbType.Bit);
            par[1].Direction = ParameterDirection.Output;

            loCn.Open();
            loTx = loCn.BeginTransaction();
            SqlCommand oSqlCommmand;
            try {
                oSqlCommmand = new SqlCommand("uspT_ProductoEsReferenciado", loCn, loTx);
                oSqlCommmand.CommandType = CommandType.StoredProcedure;
                oSqlCommmand.Parameters.Add(par[0]);
                oSqlCommmand.Parameters.Add(par[1]);
                oSqlCommmand.ExecuteNonQuery();
                return Convert.ToBoolean(par[1].Value.ToString());
            }
            catch {
                return false;
            }
            finally {
                loCn.Close();    
            }
        }

        public List<BOT_Producto> fnSelT_Producto_conMaterialEmpaque() {
            List<BOT_Producto> loList = new List<BOT_Producto>();
            object value;//------------------------- 1
            try {
                SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Producto_con_MaterialEmpaque_All");
                while (loDr.Read()) {
                    BOT_Producto loBOT_Producto = new BOT_Producto();
                    value = loDr.GetValue(loDr.GetOrdinal("Codigo_Producto"));
                    loBOT_Producto.Codigo_Producto = value != System.DBNull.Value ? (String)value : default(String);
                    value = loDr.GetValue(loDr.GetOrdinal("Nombre_Producto"));
                    loBOT_Producto.Nombre_Producto = value != System.DBNull.Value ? (String)value : default(String);
                    value = loDr.GetValue(loDr.GetOrdinal("Forma_Farmaceutica"));
                    loBOT_Producto.Forma_Farmaceutica = value != System.DBNull.Value ? (String)value : default(String);
                    value = loDr.GetValue(loDr.GetOrdinal("Proceso"));
                    loBOT_Producto.Proceso = value != System.DBNull.Value ? (String)value : default(String);
                    value = loDr.GetValue(loDr.GetOrdinal("Presentacion"));
                    loBOT_Producto.Presentacion = value != System.DBNull.Value ? (String)value : default(String);
                    loList.Add(loBOT_Producto);
                }
                loDr.Close();
            }
            catch (Exception e) {
                throw e;
            }
            finally {

            }
            return loList;

        }

	}

}

