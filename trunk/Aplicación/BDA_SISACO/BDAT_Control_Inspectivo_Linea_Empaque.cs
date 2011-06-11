using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using BO_SISACO;

namespace BDA_SISACO
{	
	public partial class BDAT_Control_Inspectivo_Linea_Empaque:BDABase
	{
		public Boolean fnInsT_Control_Inspectivo_Linea_Empaque(BOT_Control_Inspectivo_Linea_Empaque poBOT_Control_Inspectivo_Linea_Empaque)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[13];
			par[0] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Control_Inspectivo_Linea_Empaque.Codigo_Control_Inspectivo_Linea_Empaque);
			par[1] = new SqlParameter("@Codigo_Orden_Acondicionamiento",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Control_Inspectivo_Linea_Empaque.Codigo_Orden_Acondicionamiento);
			par[2] = new SqlParameter("@Area_Limpia_Ordenada",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[2],poBOT_Control_Inspectivo_Linea_Empaque.Area_Limpia_Ordenada);
			par[3] = new SqlParameter("@Vestimenta_Adecuada",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[3],poBOT_Control_Inspectivo_Linea_Empaque.Vestimenta_Adecuada);
			par[4] = new SqlParameter("@Documentacion",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[4],poBOT_Control_Inspectivo_Linea_Empaque.Documentacion);
			par[5] = new SqlParameter("@Codigo_Control_Insepectivo_Linea_Empaque_Tipo_Empaquetado",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[5],poBOT_Control_Inspectivo_Linea_Empaque.Codigo_Control_Insepectivo_Linea_Empaque_Tipo_Empaquetado);
			par[6] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque_Caja",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[6],poBOT_Control_Inspectivo_Linea_Empaque.Codigo_Control_Inspectivo_Linea_Empaque_Caja);
			par[7] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque_Embalaje",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[7],poBOT_Control_Inspectivo_Linea_Empaque.Codigo_Control_Inspectivo_Linea_Empaque_Embalaje);
			par[8] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque_Otros",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[8],poBOT_Control_Inspectivo_Linea_Empaque.Codigo_Control_Inspectivo_Linea_Empaque_Otros);
			par[9] = new SqlParameter("@Racion_Adecuada",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[9],poBOT_Control_Inspectivo_Linea_Empaque.Racion_Adecuada);
			par[10] = new SqlParameter("@Otros_Productos",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[10],poBOT_Control_Inspectivo_Linea_Empaque.Otros_Productos);
			par[11] = new SqlParameter("@Hora",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[11],poBOT_Control_Inspectivo_Linea_Empaque.Hora);
			par[12] = new SqlParameter("@Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[12],poBOT_Control_Inspectivo_Linea_Empaque.Fecha);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsT_Control_Inspectivo_Linea_Empaque", par);
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
		public Boolean fnUpdT_Control_Inspectivo_Linea_Empaque(BOT_Control_Inspectivo_Linea_Empaque poBOT_Control_Inspectivo_Linea_Empaque)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[13];
			par[0] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Control_Inspectivo_Linea_Empaque.Codigo_Control_Inspectivo_Linea_Empaque);
			par[1] = new SqlParameter("@Codigo_Orden_Acondicionamiento",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Control_Inspectivo_Linea_Empaque.Codigo_Orden_Acondicionamiento);
			par[2] = new SqlParameter("@Area_Limpia_Ordenada",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[2],poBOT_Control_Inspectivo_Linea_Empaque.Area_Limpia_Ordenada);
			par[3] = new SqlParameter("@Vestimenta_Adecuada",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[3],poBOT_Control_Inspectivo_Linea_Empaque.Vestimenta_Adecuada);
			par[4] = new SqlParameter("@Documentacion",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[4],poBOT_Control_Inspectivo_Linea_Empaque.Documentacion);
			par[5] = new SqlParameter("@Codigo_Control_Insepectivo_Linea_Empaque_Tipo_Empaquetado",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[5],poBOT_Control_Inspectivo_Linea_Empaque.Codigo_Control_Insepectivo_Linea_Empaque_Tipo_Empaquetado);
			par[6] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque_Caja",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[6],poBOT_Control_Inspectivo_Linea_Empaque.Codigo_Control_Inspectivo_Linea_Empaque_Caja);
			par[7] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque_Embalaje",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[7],poBOT_Control_Inspectivo_Linea_Empaque.Codigo_Control_Inspectivo_Linea_Empaque_Embalaje);
			par[8] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque_Otros",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[8],poBOT_Control_Inspectivo_Linea_Empaque.Codigo_Control_Inspectivo_Linea_Empaque_Otros);
			par[9] = new SqlParameter("@Racion_Adecuada",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[9],poBOT_Control_Inspectivo_Linea_Empaque.Racion_Adecuada);
			par[10] = new SqlParameter("@Otros_Productos",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[10],poBOT_Control_Inspectivo_Linea_Empaque.Otros_Productos);
			par[11] = new SqlParameter("@Hora",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[11],poBOT_Control_Inspectivo_Linea_Empaque.Hora);
			par[12] = new SqlParameter("@Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[12],poBOT_Control_Inspectivo_Linea_Empaque.Fecha);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_UpdT_Control_Inspectivo_Linea_Empaque", par);
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

		public Boolean fnInsUpdT_Control_Inspectivo_Linea_Empaque(BOT_Control_Inspectivo_Linea_Empaque poBOT_Control_Inspectivo_Linea_Empaque)
		{
			Boolean lbResultado=true ;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			
			SqlParameter[] par = new SqlParameter[13];
			par[0] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[0],poBOT_Control_Inspectivo_Linea_Empaque.Codigo_Control_Inspectivo_Linea_Empaque);
			par[1] = new SqlParameter("@Codigo_Orden_Acondicionamiento",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[1],poBOT_Control_Inspectivo_Linea_Empaque.Codigo_Orden_Acondicionamiento);
			par[2] = new SqlParameter("@Area_Limpia_Ordenada",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[2],poBOT_Control_Inspectivo_Linea_Empaque.Area_Limpia_Ordenada);
			par[3] = new SqlParameter("@Vestimenta_Adecuada",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[3],poBOT_Control_Inspectivo_Linea_Empaque.Vestimenta_Adecuada);
			par[4] = new SqlParameter("@Documentacion",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[4],poBOT_Control_Inspectivo_Linea_Empaque.Documentacion);
			par[5] = new SqlParameter("@Codigo_Control_Insepectivo_Linea_Empaque_Tipo_Empaquetado",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[5],poBOT_Control_Inspectivo_Linea_Empaque.Codigo_Control_Insepectivo_Linea_Empaque_Tipo_Empaquetado);
			par[6] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque_Caja",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[6],poBOT_Control_Inspectivo_Linea_Empaque.Codigo_Control_Inspectivo_Linea_Empaque_Caja);
			par[7] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque_Embalaje",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[7],poBOT_Control_Inspectivo_Linea_Empaque.Codigo_Control_Inspectivo_Linea_Empaque_Embalaje);
			par[8] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque_Otros",System.Data.SqlDbType.VarChar,10);
			ValidateAndInsertValue(par[8],poBOT_Control_Inspectivo_Linea_Empaque.Codigo_Control_Inspectivo_Linea_Empaque_Otros);
			par[9] = new SqlParameter("@Racion_Adecuada",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[9],poBOT_Control_Inspectivo_Linea_Empaque.Racion_Adecuada);
			par[10] = new SqlParameter("@Otros_Productos",System.Data.SqlDbType.VarChar,1);
			ValidateAndInsertValue(par[10],poBOT_Control_Inspectivo_Linea_Empaque.Otros_Productos);
			par[11] = new SqlParameter("@Hora",System.Data.SqlDbType.VarChar,15);
			ValidateAndInsertValue(par[11],poBOT_Control_Inspectivo_Linea_Empaque.Hora);
			par[12] = new SqlParameter("@Fecha",System.Data.SqlDbType.DateTime);
			ValidateAndInsertValue(par[12],poBOT_Control_Inspectivo_Linea_Empaque.Fecha);
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_InsUpdT_Control_Inspectivo_Linea_Empaque", par);
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
		public Boolean fnDelT_Control_Inspectivo_Linea_Empaque(String psCodigo_Control_Inspectivo_Linea_Empaque)
		{
			Boolean lbResultado=true;
			//conexion
			SqlTransaction loTx ;
			SqlConnection loCn = new SqlConnection();
			loCn.ConnectionString = ClassCadena.fnConexion();	
			//parametros
			SqlParameter[] par = new SqlParameter[1];
			//cambiar aca:
			par[0] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Control_Inspectivo_Linea_Empaque;
			
			loCn.Open();
			loTx = loCn.BeginTransaction();
			try
			{
				SqlHelper.ExecuteNonQuery(loTx, CommandType.StoredProcedure, "usp_DelT_Control_Inspectivo_Linea_Empaque", par);
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

		public List<BOT_Control_Inspectivo_Linea_Empaque> fnSelT_Control_Inspectivo_Linea_EmpaqueAll()
		{
			List<BOT_Control_Inspectivo_Linea_Empaque> loList = new List<BOT_Control_Inspectivo_Linea_Empaque>();
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Control_Inspectivo_Linea_EmpaquesAll");
				while (loDr.Read())
                {
					BOT_Control_Inspectivo_Linea_Empaque loBOT_Control_Inspectivo_Linea_Empaque=new BOT_Control_Inspectivo_Linea_Empaque();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Inspectivo_Linea_Empaque"));
					loBOT_Control_Inspectivo_Linea_Empaque.Codigo_Control_Inspectivo_Linea_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Orden_Acondicionamiento"));
					loBOT_Control_Inspectivo_Linea_Empaque.Codigo_Orden_Acondicionamiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Area_Limpia_Ordenada"));
					loBOT_Control_Inspectivo_Linea_Empaque.Area_Limpia_Ordenada = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Vestimenta_Adecuada"));
					loBOT_Control_Inspectivo_Linea_Empaque.Vestimenta_Adecuada = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Documentacion"));
					loBOT_Control_Inspectivo_Linea_Empaque.Documentacion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Insepectivo_Linea_Empaque_Tipo_Empaquetado"));
					loBOT_Control_Inspectivo_Linea_Empaque.Codigo_Control_Insepectivo_Linea_Empaque_Tipo_Empaquetado = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Inspectivo_Linea_Empaque_Caja"));
					loBOT_Control_Inspectivo_Linea_Empaque.Codigo_Control_Inspectivo_Linea_Empaque_Caja = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Inspectivo_Linea_Empaque_Embalaje"));
					loBOT_Control_Inspectivo_Linea_Empaque.Codigo_Control_Inspectivo_Linea_Empaque_Embalaje = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Inspectivo_Linea_Empaque_Otros"));
					loBOT_Control_Inspectivo_Linea_Empaque.Codigo_Control_Inspectivo_Linea_Empaque_Otros = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Racion_Adecuada"));
					loBOT_Control_Inspectivo_Linea_Empaque.Racion_Adecuada = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Otros_Productos"));
					loBOT_Control_Inspectivo_Linea_Empaque.Otros_Productos = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Hora"));
					loBOT_Control_Inspectivo_Linea_Empaque.Hora = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Fecha"));
					loBOT_Control_Inspectivo_Linea_Empaque.Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
                    loList.Add(loBOT_Control_Inspectivo_Linea_Empaque);
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

		public BOT_Control_Inspectivo_Linea_Empaque fnSelT_Control_Inspectivo_Linea_Empaque(String psCodigo_Control_Inspectivo_Linea_Empaque)
		{
			BOT_Control_Inspectivo_Linea_Empaque loBOT_Control_Inspectivo_Linea_Empaque = new BOT_Control_Inspectivo_Linea_Empaque();
			//parametros
			
			SqlParameter[] par = new SqlParameter[1];
			par[0] = new SqlParameter("@Codigo_Control_Inspectivo_Linea_Empaque",System.Data.SqlDbType.VarChar,10);
			par[0].Value= psCodigo_Control_Inspectivo_Linea_Empaque;
			object value;
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Control_Inspectivo_Linea_Empaque", par);
				while(loDr.Read()){//----------------------------------------------------- AQUI
					if (loDr != null)
					{
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Inspectivo_Linea_Empaque"));
					loBOT_Control_Inspectivo_Linea_Empaque.Codigo_Control_Inspectivo_Linea_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Orden_Acondicionamiento"));
					loBOT_Control_Inspectivo_Linea_Empaque.Codigo_Orden_Acondicionamiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Area_Limpia_Ordenada"));
					loBOT_Control_Inspectivo_Linea_Empaque.Area_Limpia_Ordenada = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Vestimenta_Adecuada"));
					loBOT_Control_Inspectivo_Linea_Empaque.Vestimenta_Adecuada = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Documentacion"));
					loBOT_Control_Inspectivo_Linea_Empaque.Documentacion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Insepectivo_Linea_Empaque_Tipo_Empaquetado"));
					loBOT_Control_Inspectivo_Linea_Empaque.Codigo_Control_Insepectivo_Linea_Empaque_Tipo_Empaquetado = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Inspectivo_Linea_Empaque_Caja"));
					loBOT_Control_Inspectivo_Linea_Empaque.Codigo_Control_Inspectivo_Linea_Empaque_Caja = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Inspectivo_Linea_Empaque_Embalaje"));
					loBOT_Control_Inspectivo_Linea_Empaque.Codigo_Control_Inspectivo_Linea_Empaque_Embalaje = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Inspectivo_Linea_Empaque_Otros"));
					loBOT_Control_Inspectivo_Linea_Empaque.Codigo_Control_Inspectivo_Linea_Empaque_Otros = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Racion_Adecuada"));
					loBOT_Control_Inspectivo_Linea_Empaque.Racion_Adecuada = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Otros_Productos"));
					loBOT_Control_Inspectivo_Linea_Empaque.Otros_Productos = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Hora"));
					loBOT_Control_Inspectivo_Linea_Empaque.Hora = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Fecha"));
					loBOT_Control_Inspectivo_Linea_Empaque.Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
						
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
			return loBOT_Control_Inspectivo_Linea_Empaque;
		}
		public List<BOT_Control_Inspectivo_Linea_Empaque> fnSelT_Control_Inspectivo_Linea_EmpaqueDin(string psWhere,string psOrder)
		{
			List<BOT_Control_Inspectivo_Linea_Empaque> loList = new List<BOT_Control_Inspectivo_Linea_Empaque>();
			SqlParameter[] par = new SqlParameter[2];
			par[0] = new SqlParameter("@WhereCondition",System.Data.SqlDbType.VarChar,500);
			par[0].Value= psWhere;
			par[1] = new SqlParameter("@OrderByExpression",System.Data.SqlDbType.VarChar,250);
			par[1].Value= psOrder;
			object value;//------------------------- 1
			try
			{
				SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Control_Inspectivo_Linea_EmpaquesDin",par);
				while (loDr.Read())
                {
					BOT_Control_Inspectivo_Linea_Empaque loBOT_Control_Inspectivo_Linea_Empaque=new BOT_Control_Inspectivo_Linea_Empaque();
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Inspectivo_Linea_Empaque"));
					loBOT_Control_Inspectivo_Linea_Empaque.Codigo_Control_Inspectivo_Linea_Empaque = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Orden_Acondicionamiento"));
					loBOT_Control_Inspectivo_Linea_Empaque.Codigo_Orden_Acondicionamiento = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Area_Limpia_Ordenada"));
					loBOT_Control_Inspectivo_Linea_Empaque.Area_Limpia_Ordenada = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Vestimenta_Adecuada"));
					loBOT_Control_Inspectivo_Linea_Empaque.Vestimenta_Adecuada = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Documentacion"));
					loBOT_Control_Inspectivo_Linea_Empaque.Documentacion = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Insepectivo_Linea_Empaque_Tipo_Empaquetado"));
					loBOT_Control_Inspectivo_Linea_Empaque.Codigo_Control_Insepectivo_Linea_Empaque_Tipo_Empaquetado = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Inspectivo_Linea_Empaque_Caja"));
					loBOT_Control_Inspectivo_Linea_Empaque.Codigo_Control_Inspectivo_Linea_Empaque_Caja = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Inspectivo_Linea_Empaque_Embalaje"));
					loBOT_Control_Inspectivo_Linea_Empaque.Codigo_Control_Inspectivo_Linea_Empaque_Embalaje = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Codigo_Control_Inspectivo_Linea_Empaque_Otros"));
					loBOT_Control_Inspectivo_Linea_Empaque.Codigo_Control_Inspectivo_Linea_Empaque_Otros = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Racion_Adecuada"));
					loBOT_Control_Inspectivo_Linea_Empaque.Racion_Adecuada = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Otros_Productos"));
					loBOT_Control_Inspectivo_Linea_Empaque.Otros_Productos = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Hora"));
					loBOT_Control_Inspectivo_Linea_Empaque.Hora = value != System.DBNull.Value ? (String)value : default(String);
					value = loDr.GetValue(loDr.GetOrdinal("Fecha"));
					loBOT_Control_Inspectivo_Linea_Empaque.Fecha = value != System.DBNull.Value ? (DateTime)value : default(DateTime);
                    loList.Add(loBOT_Control_Inspectivo_Linea_Empaque);
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
		public Int32[] fnSelT_Control_Inspectivo_Linea_EmpaqueMinMax()
        {
            Int32[] laMinMax=new Int32[2];
            try
			{
                SqlDataReader loDr = SqlHelper.ExecuteReader(ClassCadena.fnConexion(), CommandType.StoredProcedure, "usp_SelT_Control_Inspectivo_Linea_EmpaqueMinMax");
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

