using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Registro_Codificacion_Despeje_Linea_Materiales_Insumos:BOBase
	{
		private String _codigoRegistroCodificacionDespejeLineaMaterialesInsumos;
		private String _codigoRegistroCodificacionDespejeLinea;
		private String _materialesInsumosIdentificados;
		private String _materialesInsumosVerificados;
		private String _materialesInsumosSobreParihuelas;
		
		public String Codigo_Registro_Codificacion_Despeje_Linea_Materiales_Insumos
		{
			get
			{
				return _codigoRegistroCodificacionDespejeLineaMaterialesInsumos;
			}
			set
			{
				_codigoRegistroCodificacionDespejeLineaMaterialesInsumos =value;
			}
		}
		public String Codigo_Registro_Codificacion_Despeje_Linea
		{
			get
			{
				return _codigoRegistroCodificacionDespejeLinea;
			}
			set
			{
				_codigoRegistroCodificacionDespejeLinea =value;
			}
		}
		public String Materiales_Insumos_Identificados
		{
			get
			{
				return _materialesInsumosIdentificados;
			}
			set
			{
				_materialesInsumosIdentificados =value;
			}
		}
		public String Materiales_Insumos_Verificados
		{
			get
			{
				return _materialesInsumosVerificados;
			}
			set
			{
				_materialesInsumosVerificados =value;
			}
		}
		public String Materiales_Insumos_Sobre_Parihuelas
		{
			get
			{
				return _materialesInsumosSobreParihuelas;
			}
			set
			{
				_materialesInsumosSobreParihuelas =value;
			}
		}
		
		#region CONSTRUCTOR
		public BOT_Registro_Codificacion_Despeje_Linea_Materiales_Insumos()
		{
		}
		#endregion
		
	}
}
