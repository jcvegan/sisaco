using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using BO_SISACO;

namespace BDA_SISACO
{	
	public partial class BDAT_Material_Empaque_x_Producto:BDABase
	{
		public Boolean fnInsT_Material_Empaque_x_Producto(BOT_Material_Empaque_x_Producto poBOT_Material_Empaque_x_Producto)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[6];
			par[0] = new SqlParameter("@Codigo_Material_Empaque_x_Producto",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Material_Empaque_x_Producto.Codigo_Material_Empaque_x_Producto);
			par[1] = new SqlParameter("@Codigo_Producto",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Material_Empaque_x_Producto.Codigo_Producto);
			par[2] = new SqlParameter("@Lote_Fabricacion",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[2],poBOT_Material_Empaque_x_Producto.Lote_Fabricacion);
			par[3] = new SqlParameter("@Tamaño_Lote",System.Data.SqlDbType.Int);
			ValidateAndInsertValue(par[3],poBOT_Material_Empaque_x_Producto.Tamaño_Lote);
			par[4] = new SqlParameter("@Codigo_Material_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[4],poBOT_Material_Empaque_x_Producto.Codigo_Material_Empaque);
			par[5] = new SqlParameter("@Cantidad_Pedida",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[5],poBOT_Material_Empaque_x_Producto.Cantidad_Pedida);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsT_Material_Empaque_x_Producto", par);
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
		public Boolean fnUpdT_Material_Empaque_x_Producto(BOT_Material_Empaque_x_Producto poBOT_Material_Empaque_x_Producto)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[5];
			par[0] = new SqlParameter("@Codigo_Material_Empaque_x_Producto",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Material_Empaque_x_Producto.Codigo_Material_Empaque_x_Producto);
			par[1] = new SqlParameter("@Codigo_Producto",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Material_Empaque_x_Producto.Codigo_Producto);
            //par[2] = new SqlParameter("@Lote_Fabricacion",System.Data.SqlDbType.VarChar,10);
            //ValidateAndInsertValue(par[2],poBOT_Material_Empaque_x_Producto.Lote_Fabricacion);
			par[2] = new SqlParameter("@Tamaño_Lote",System.Data.SqlDbType.Int);
			ValidateAndInsertValue(par[2],poBOT_Material_Empaque_x_Producto.Tamaño_Lote);
			par[3] = new SqlParameter("@Codigo_Material_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[3],poBOT_Material_Empaque_x_Producto.Codigo_Material_Empaque);
			par[4] = new SqlParameter("@Cantidad_Pedida",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[4],poBOT_Material_Empaque_x_Producto.Cantidad_Pedida);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_UpdT_Material_Empaque_x_Producto", par);
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
		public Boolean fnInsUpdT_Material_Empaque_x_Producto(BOT_Material_Empaque_x_Producto poBOT_Material_Empaque_x_Producto)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[7];
			par[0] = new SqlParameter("@Codigo_Material_Empaque_x_Producto",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Material_Empaque_x_Producto.Codigo_Material_Empaque_x_Producto);
			par[1] = new SqlParameter("@Codigo_Producto",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Material_Empaque_x_Producto.Codigo_Producto);
            //par[2] = new SqlParameter("@Lote_Fabricacion",System.Data.SqlDbType.VarChar,10);
            //ValidateAndInsertValue(par[2],poBOT_Material_Empaque_x_Producto.Lote_Fabricacion);
			par[2] = new SqlParameter("@Tamaño_Lote",System.Data.SqlDbType.Int);
			ValidateAndInsertValue(par[2],poBOT_Material_Empaque_x_Producto.Tamaño_Lote);
			par[3] = new SqlParameter("@Codigo_Material_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[3],poBOT_Material_Empaque_x_Producto.Codigo_Material_Empaque);
            par[4] = new SqlParameter("@Nombre_Material_Empaque", System.Data.SqlDbType.NVarChar, 50);
            ValidateAndInsertValue(par[4], poBOT_Material_Empaque_x_Producto.Nombre_Material_Empaque);
            par[5] = new SqlParameter("@Unidad_Medida", System.Data.SqlDbType.NVarChar, 5);
            ValidateAndInsertValue(par[5], poBOT_Material_Empaque_x_Producto.Unidad_Medida);
			par[6] = new SqlParameter("@Cantidad_Pedida",System.Data.SqlDbType.Decimal);
			ValidateAndInsertValue(par[6],poBOT_Material_Empaque_x_Producto.Cantidad_Pedida);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
                //if (poBOT_Material_Empaque_x_Producto.Cantidad_Pedida != 0)
                //{
                    SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsUpdT_Material_Empaque_x_Producto", par);
                    loTx.Commit();
                //}
                //else
                //{
                //    lbResultado = false;
                //    lbResultado = fnDelT_Material_Empaque_x_Producto(poBOT_Material_Empaque_x_Producto.Codigo_Material_Empaque_x_Producto);
                //}
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
		public Boolean fnDelT_Material_Empaque_x_Producto(String psCodigo_Material_Empaque_x_Producto)
		{
			Boolean lbResultado=true;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			SqlParameter[] par = new SqlParameter[1];
			//cambiar aca:
			par[0] = new SqlParameter("@Codigo_Material_Empaque_x_Producto",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Material_Empaque_x_Producto;
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_DelT_Material_Empaque_x_Producto", par);
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
		public List<BOT_Material_Empaque_x_Producto> fnSelT_Material_Empaque_x_ProductoAll()
		{
			List<BOT_Material_Empaque_x_Producto> loList = new List<BOT_Material_Empaque_x_Producto>();
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Material_Empaque_x_ProductosAll");
				while (loDr.Read())
                {
					BOT_Material_Empaque_x_Producto loBOT_Material_Empaque_x_Producto=new BOT_Material_Empaque_x_Producto();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Material_Empaque_x_Producto"));
					loBOT_Material_Empaque_x_Producto.Codigo_Material_Empaque_x_Producto = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Producto"));
					loBOT_Material_Empaque_x_Producto.Codigo_Producto = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Lote_Fabricacion"));
					loBOT_Material_Empaque_x_Producto.Lote_Fabricacion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Tamaño_Lote"));
					loBOT_Material_Empaque_x_Producto.Tamaño_Lote = value != System.DBNull.Value ? (Int32)value : default(Int32);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Material_Empaque"));
					loBOT_Material_Empaque_x_Producto.Codigo_Material_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad_Pedida"));
					loBOT_Material_Empaque_x_Producto.Cantidad_Pedida = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
                    loList.Add(loBOT_Material_Empaque_x_Producto);
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
		public BOT_Material_Empaque_x_Producto fnSelT_Material_Empaque_x_Producto(String psCodigo_Material_Empaque_x_Producto)
		{
			BOT_Material_Empaque_x_Producto loBOT_Material_Empaque_x_Producto = new BOT_Material_Empaque_x_Producto();
			//parametros
			
			SqlParameter[] par = new SqlParameter[1];
			par[0] = new SqlParameter("@Codigo_Material_Empaque_x_Producto",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Material_Empaque_x_Producto;
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Material_Empaque_x_Producto", par);
				while(loDr.Read()){//----------------------------------------------------- AQUI
					if (loDr != null)
					{
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Material_Empaque_x_Producto"));
					loBOT_Material_Empaque_x_Producto.Codigo_Material_Empaque_x_Producto = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Producto"));
					loBOT_Material_Empaque_x_Producto.Codigo_Producto = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Lote_Fabricacion"));
					loBOT_Material_Empaque_x_Producto.Lote_Fabricacion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Tamaño_Lote"));
					loBOT_Material_Empaque_x_Producto.Tamaño_Lote = value != System.DBNull.Value ? (Int32)value : default(Int32);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Material_Empaque"));
					loBOT_Material_Empaque_x_Producto.Codigo_Material_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad_Pedida"));
					loBOT_Material_Empaque_x_Producto.Cantidad_Pedida = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
						
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
			return loBOT_Material_Empaque_x_Producto;
		}
		public List<BOT_Material_Empaque_x_Producto> fnSelT_Material_Empaque_x_ProductoDin(string psWhere,string psOrder)
		{
			List<BOT_Material_Empaque_x_Producto> loList = new List<BOT_Material_Empaque_x_Producto>();
			SqlParameter[] par = new SqlParameter[2];
			par[0] = new SqlParameter("@WhereCondition",System.Data.SqlDbType.VarChar,500);
			par[0].Value= psWhere;
			par[1] = new SqlParameter("@OrderByExpression",System.Data.SqlDbType.VarChar,250);
			par[1].Value= psOrder;
			object value;//------------------------- 1
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Material_Empaque_x_ProductosDin",par);
				while (loDr.Read())
                {
					BOT_Material_Empaque_x_Producto loBOT_Material_Empaque_x_Producto=new BOT_Material_Empaque_x_Producto();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Material_Empaque_x_Producto"));
					loBOT_Material_Empaque_x_Producto.Codigo_Material_Empaque_x_Producto = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Producto"));
					loBOT_Material_Empaque_x_Producto.Codigo_Producto = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Tamaño_Lote"));
					loBOT_Material_Empaque_x_Producto.Tamaño_Lote = value != System.DBNull.Value ? (Int32)value : default(Int32);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Material_Empaque"));
					loBOT_Material_Empaque_x_Producto.Codigo_Material_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Cantidad_Pedida"));
					loBOT_Material_Empaque_x_Producto.Cantidad_Pedida = value != System.DBNull.Value ? (Decimal)value : default(Decimal);
                    loList.Add(loBOT_Material_Empaque_x_Producto);
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
		public Int32[] fnSelT_Material_Empaque_x_ProductoMinMax()
        {
            Int32[] laMinMax=new Int32[2];
            try
			{
                SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Material_Empaque_x_ProductoMinMax");
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
        public Boolean fnExsT_Material_Empaque_x_Producto(string cod_Producto, string cod_Material_Empaque,int tamaño_lote)
        {
            Boolean _existe = true;
            SqlTransaction loTx;
            SqlConnection loCn = new SqlConnection();
            loCn.ConnectionString = ClassCadena.fnConexion();
            
            SqlParameter[] par = new SqlParameter[4];
            par[0] = new SqlParameter("@Codigo_Producto", SqlDbType.NVarChar, 10);
            par[0].Value = cod_Producto;
            par[1] = new SqlParameter("@Codigo_Material_Empaque", SqlDbType.NVarChar, 10);
            par[1].Value = cod_Material_Empaque;
            par[2] = new SqlParameter("@Tamaño_Lote", SqlDbType.Int);
            par[2].Value = tamaño_lote;
            par[3] = new SqlParameter("@Existe", SqlDbType.Bit);
            par[3].Direction = ParameterDirection.Output;

            loCn.Open();
            loTx = loCn.BeginTransaction();
            SqlCommand oSqlCommand;

            try {
                oSqlCommand = new SqlCommand("usp_ExsT_Material_Empaque_x_Producto", loCn, loTx);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(par[0]);
                oSqlCommand.Parameters.Add(par[1]);
                oSqlCommand.Parameters.Add(par[2]);
                oSqlCommand.Parameters.Add(par[3]);
                oSqlCommand.ExecuteNonQuery();
                _existe = Convert.ToBoolean(oSqlCommand.Parameters["@Existe"].Value.ToString());
            }
            catch {
                return false;
            }
            finally {
                loCn.Close();
                loCn.Dispose();
            }
            return _existe;
        }
        public Boolean fnExsT_Material_Empaque_x_tamaño_Lote(string Cod_Producto, int Tamaño_lote) {
            Boolean _existe = true;
            SqlTransaction loTx;
            SqlConnection loCn = new SqlConnection();
            loCn.ConnectionString = ClassCadena.fnConexion();

            SqlParameter[] par = new SqlParameter[3];
            par[0] = new SqlParameter("@Codigo_Producto", SqlDbType.NVarChar, 10);
            par[0].Value = Cod_Producto;
            par[1] = new SqlParameter("@Tamaño_Lote", SqlDbType.Int);
            par[1].Value = Tamaño_lote;
            par[2] = new SqlParameter("@Existe", SqlDbType.Bit);
            par[2].Direction = ParameterDirection.Output;

            loCn.Open();
            loTx = loCn.BeginTransaction();
            SqlCommand oSqlCommand;

            try {
                oSqlCommand = new SqlCommand("usp_ExsT_MaterialEmpaque_x_Producto_tamañoLote", loCn, loTx);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(par[0]);
                oSqlCommand.Parameters.Add(par[1]);
                oSqlCommand.Parameters.Add(par[2]);
                oSqlCommand.ExecuteNonQuery();
                _existe = Convert.ToBoolean(oSqlCommand.Parameters["@Existe"].Value.ToString());
            }
            catch {
                return false;
            }
            finally {
                loCn.Close();
                loCn.Dispose();
            }
            return _existe;
        }
        public Boolean fnExsT_Material_Empaque_x_Material_Empaque_Producto(string Cod_Material_Empaque) {
            Boolean _existe = true;
            SqlTransaction loTx;
            SqlConnection loCn = new SqlConnection();
            loCn.ConnectionString = ClassCadena.fnConexion();

            SqlParameter[] par = new SqlParameter[2];
            par[0] = new SqlParameter("@Codigo_Material_Empaque", SqlDbType.NVarChar, 10);
            par[0].Value = Cod_Material_Empaque;
            par[1] = new SqlParameter("@Existe", SqlDbType.Bit);
            par[1].Direction = ParameterDirection.Output;

            loCn.Open();
            loTx = loCn.BeginTransaction();
            SqlCommand oSqlCommand;

            try {
                oSqlCommand = new SqlCommand("usp_ExsT_Materal_Empaque_x_Producto_Material_Empaque", loCn, loTx);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add(par[0]);
                oSqlCommand.Parameters.Add(par[1]);
                oSqlCommand.ExecuteNonQuery();
                _existe = Convert.ToBoolean(oSqlCommand.Parameters["@Existe"].Value.ToString());
            }
            catch {
                return false;
            }
            finally {
                loCn.Close();
                loCn.Dispose();
            }
            return _existe;
        }
        public List<string> fnSelT_Material_Empaque_x_Producto_Tamaño_Lote(string Cod_Producto) {
            List<string> loList = null;
            SqlParameter[] par = new SqlParameter[1];
            try {
                par[0] = new SqlParameter("@Codigo_Producto", SqlDbType.NVarChar, 10);
                par[0].Value = Cod_Producto;
                loList = new List<string>();
                SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Material_Empaque_x_Producto_Tamaño_Lote", par);
                while (loDr.Read()) {
                    loList.Add(loDr.GetValue(loDr.GetOrdinal("Tamaño_Lote")).ToString());
                }
                loDr.Close();
            }
            catch (Exception e){
                throw e;
            }
            finally {

            }
            return loList;
        }
	}
}

