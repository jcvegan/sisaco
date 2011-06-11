using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using BO_SISACO;

namespace BDA_SISACO
{	
	public partial class BDAT_Usuario:BDABase
	{
		public Boolean fnInsT_Usuario(BOT_Usuario poBOT_Usuario)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[6];
			par[0] = new SqlParameter("@Codigo_Usuario",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Usuario.Codigo_Usuario);
			par[1] = new SqlParameter("@Nombre_Usuario",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[1],poBOT_Usuario.Nombre_Usuario);
			par[2] = new SqlParameter("@Codigo_Perfil_Usuario",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[2],poBOT_Usuario.Codigo_Perfil_Usuario);
			par[3] = new SqlParameter("@Contraseña",System.Data.SqlDbType.VarChar,255);
			ValidateAndInsertValue(par[3],poBOT_Usuario.Contraseña);
			par[4] = new SqlParameter("@Nombres",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[4],poBOT_Usuario.Nombres);
			par[5] = new SqlParameter("@Apellidos",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[5],poBOT_Usuario.Apellidos);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsT_Usuario", par);
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
		public Boolean fnUpdT_Usuario(BOT_Usuario poBOT_Usuario)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[6];
			par[0] = new SqlParameter("@Codigo_Usuario",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Usuario.Codigo_Usuario);
			par[1] = new SqlParameter("@Nombre_Usuario",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[1],poBOT_Usuario.Nombre_Usuario);
			par[2] = new SqlParameter("@Codigo_Perfil_Usuario",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[2],poBOT_Usuario.Codigo_Perfil_Usuario);
			par[3] = new SqlParameter("@Contraseña",System.Data.SqlDbType.VarChar,255);
			ValidateAndInsertValue(par[3],poBOT_Usuario.Contraseña);
			par[4] = new SqlParameter("@Nombres",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[4],poBOT_Usuario.Nombres);
			par[5] = new SqlParameter("@Apellidos",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[5],poBOT_Usuario.Apellidos);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_UpdT_Usuario", par);
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

		public Boolean fnInsUpdT_Usuario(BOT_Usuario poBOT_Usuario)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[6];
			par[0] = new SqlParameter("@Codigo_Usuario",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Usuario.Codigo_Usuario);
			par[1] = new SqlParameter("@Nombre_Usuario",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[1],poBOT_Usuario.Nombre_Usuario);
			par[2] = new SqlParameter("@Codigo_Perfil_Usuario",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[2],poBOT_Usuario.Codigo_Perfil_Usuario);
			par[3] = new SqlParameter("@Contraseña",System.Data.SqlDbType.VarChar,255);
			ValidateAndInsertValue(par[3],poBOT_Usuario.Contraseña);
			par[4] = new SqlParameter("@Nombres",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[4],poBOT_Usuario.Nombres);
			par[5] = new SqlParameter("@Apellidos",System.Data.SqlDbType.VarChar,50);
			ValidateAndInsertValue(par[5],poBOT_Usuario.Apellidos);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsUpdT_Usuario", par);
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
		public Boolean fnDelT_Usuario(String psCodigo_Usuario)
		{
			Boolean lbResultado=true;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			SqlParameter[] par = new SqlParameter[1];
			//cambiar aca:
			par[0] = new SqlParameter("@Codigo_Usuario",System.Data.SqlDbType.NVarChar,10);
			par[0].Value= psCodigo_Usuario;
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_DelT_Usuario", par);
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

		public List<BOT_Usuario> fnSelT_UsuarioAll()
		{
			List<BOT_Usuario> loList = new List<BOT_Usuario>();
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_UsuariosAll");
				while (loDr.Read())
                {
					BOT_Usuario loBOT_Usuario=new BOT_Usuario();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Usuario"));
					loBOT_Usuario.Codigo_Usuario = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Nombre_Usuario"));
					loBOT_Usuario.Nombre_Usuario = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Perfil_Usuario"));
					loBOT_Usuario.Codigo_Perfil_Usuario = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Contraseña"));
					loBOT_Usuario.Contraseña = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Nombres"));
					loBOT_Usuario.Nombres = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Apellidos"));
					loBOT_Usuario.Apellidos = value != System.DBNull.Value ? (String)value : default(String);
                    BDAT_Perfil_Usuario BdatPerfil = new BDAT_Perfil_Usuario();
                    loBOT_Usuario.DescripcionPerfil = BdatPerfil.fnSelT_Perfil_Usuario(loBOT_Usuario.Codigo_Perfil_Usuario);
                    loList.Add(loBOT_Usuario);
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

		public BOT_Usuario fnSelT_Usuario(String psCodigo_Usuario)
		{
			BOT_Usuario loBOT_Usuario = new BOT_Usuario();
			//parametros
			
			SqlParameter[] par = new SqlParameter[1];
			par[0] = new SqlParameter("@Codigo_Usuario",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Usuario;
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Usuario", par);
				while(loDr.Read()){//----------------------------------------------------- AQUI
					if (loDr != null)
					{
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Usuario"));
					loBOT_Usuario.Codigo_Usuario = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Nombre_Usuario"));
					loBOT_Usuario.Nombre_Usuario = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Perfil_Usuario"));
					loBOT_Usuario.Codigo_Perfil_Usuario = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Contraseña"));
					loBOT_Usuario.Contraseña = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Nombres"));
					loBOT_Usuario.Nombres = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Apellidos"));
					loBOT_Usuario.Apellidos = value != System.DBNull.Value ? (String)value : default(String);
                    BDAT_Perfil_Usuario BdatPerfil = new BDAT_Perfil_Usuario();
                    loBOT_Usuario.DescripcionPerfil = BdatPerfil.fnSelT_Perfil_Usuario(loBOT_Usuario.Codigo_Perfil_Usuario);
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
			return loBOT_Usuario;
		}
		public List<BOT_Usuario> fnSelT_UsuarioDin(string psWhere,string psOrder)
		{
			List<BOT_Usuario> loList = new List<BOT_Usuario>();
			SqlParameter[] par = new SqlParameter[2];
			par[0] = new SqlParameter("@WhereCondition",System.Data.SqlDbType.VarChar,500);
			par[0].Value= psWhere;
			par[1] = new SqlParameter("@OrderByExpression",System.Data.SqlDbType.VarChar,250);
			par[1].Value= psOrder;
			object value;//------------------------- 1
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_UsuariosDin",par);
				while (loDr.Read())
                {
					BOT_Usuario loBOT_Usuario=new BOT_Usuario();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Usuario"));
					loBOT_Usuario.Codigo_Usuario = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Nombre_Usuario"));
					loBOT_Usuario.Nombre_Usuario = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Perfil_Usuario"));
					loBOT_Usuario.Codigo_Perfil_Usuario = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Contraseña"));
					loBOT_Usuario.Contraseña = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Nombres"));
					loBOT_Usuario.Nombres = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Apellidos"));
					loBOT_Usuario.Apellidos = value != System.DBNull.Value ? (String)value : default(String);
                    BDAT_Perfil_Usuario BdatPerfil = new BDAT_Perfil_Usuario();
                    loBOT_Usuario.DescripcionPerfil = BdatPerfil.fnSelT_Perfil_Usuario(loBOT_Usuario.Codigo_Perfil_Usuario);
                    loList.Add(loBOT_Usuario);
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
		public Int32[] fnSelT_UsuarioMinMax()
        {
            Int32[] laMinMax=new Int32[2];
            try
			{
                SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_UsuarioMinMax");
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

        public String fnSelT_UsuarioCodigo() {
            SqlTransaction loTx;
            SqlConnection loCn = new SqlConnection();
            loCn.ConnectionString = ClassCadena.fnConexion();
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@Codigo_Usuario", SqlDbType.NVarChar, 10);
            par[0].Direction = ParameterDirection.Output;

            loCn.Open();
            loTx = loCn.BeginTransaction();
            SqlCommand oSqlCommmand;
            try {
                oSqlCommmand = new SqlCommand("usp_SelT_Usuario_Codigo", loCn, loTx);
                oSqlCommmand.CommandType = CommandType.StoredProcedure;
                oSqlCommmand.Parameters.Add(par[0]);
                //object[] result = SqlHelper.ExecuteNonQueryReturnValue(ClassCadena.fnConexion(), "usp_SelT_Material_Empaque_Codigo", par);
                //loTx.Commit();
                oSqlCommmand.ExecuteNonQuery();
                string returnValue = oSqlCommmand.Parameters["@Codigo_Usuario"].Value.ToString();
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

        public BOT_Usuario fnSelT_Usuario_by_Nombre(String nombre_Usuario) {
            BOT_Usuario loBOT_Usuario = new BOT_Usuario();
            //parametros

            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@Nombre_Usuario", System.Data.SqlDbType.VarChar, 10);
            par[0].Value = nombre_Usuario;
            object value;
            try {
                SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Usuario_Select_by_Nombre", par);
                while (loDr.Read()) {//----------------------------------------------------- AQUI
                    if (loDr != null) {
                        value = loDr.GetValue(loDr.GetOrdinal("Codigo_Usuario"));
                        loBOT_Usuario.Codigo_Usuario = value != System.DBNull.Value ? (String)value : default(String);
                        value = loDr.GetValue(loDr.GetOrdinal("Nombre_Usuario"));
                        loBOT_Usuario.Nombre_Usuario = value != System.DBNull.Value ? (String)value : default(String);
                        value = loDr.GetValue(loDr.GetOrdinal("Codigo_Perfil_Usuario"));
                        loBOT_Usuario.Codigo_Perfil_Usuario = value != System.DBNull.Value ? (String)value : default(String);
                        value = loDr.GetValue(loDr.GetOrdinal("Contraseña"));
                        loBOT_Usuario.Contraseña = value != System.DBNull.Value ? (String)value : default(String);
                        value = loDr.GetValue(loDr.GetOrdinal("Nombres"));
                        loBOT_Usuario.Nombres = value != System.DBNull.Value ? (String)value : default(String);
                        value = loDr.GetValue(loDr.GetOrdinal("Apellidos"));
                        loBOT_Usuario.Apellidos = value != System.DBNull.Value ? (String)value : default(String);
                        BDAT_Perfil_Usuario BdatPerfil = new BDAT_Perfil_Usuario();
                        loBOT_Usuario.DescripcionPerfil = BdatPerfil.fnSelT_Perfil_Usuario(loBOT_Usuario.Codigo_Perfil_Usuario);
                    }
                }
                loDr.Close();
            }
            catch (Exception e) {
                throw e;
            }
            finally {

            }
            return loBOT_Usuario;
        }
	}
}

