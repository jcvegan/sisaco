using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos:BOBase
	{
		private String _codigoRegistroEmpaqueDespejeLineaMaterialesInsumos;
		private String _codigoRegistroEmpaqueDespejeLinea;
		private String _materialesInsumosIdentificados;
		private String _materialesInsumosVerificados;
		private String _materialesInsumosSobreParihuelas;
		
		public String Codigo_Registro_Empaque_Despeje_Linea_Materiales_Insumos
		{
			get
			{
				return _codigoRegistroEmpaqueDespejeLineaMaterialesInsumos;
			}
			set
			{
				_codigoRegistroEmpaqueDespejeLineaMaterialesInsumos =value;
			}
		}
		public String Codigo_Registro_Empaque_Despeje_Linea
		{
			get
			{
				return _codigoRegistroEmpaqueDespejeLinea;
			}
			set
			{
				_codigoRegistroEmpaqueDespejeLinea =value;
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
		public BOT_Registro_Empaque_Despeje_Linea_Materiales_Insumos()
		{
		}
		#endregion
		
	}
}
