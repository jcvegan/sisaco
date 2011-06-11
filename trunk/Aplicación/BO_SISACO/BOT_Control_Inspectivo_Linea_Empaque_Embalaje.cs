using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Control_Inspectivo_Linea_Empaque_Embalaje:BOBase
	{
		private String _codigoControlInspectivoLineaEmpaqueEmbalaje;
		private String _codigoControlInspectivoLineaEmpaque;
		private String _identificado;
		private String _cantidad;
		
		public String Codigo_Control_Inspectivo_Linea_Empaque_Embalaje
		{
			get
			{
				return _codigoControlInspectivoLineaEmpaqueEmbalaje;
			}
			set
			{
				_codigoControlInspectivoLineaEmpaqueEmbalaje =value;
			}
		}
		public String Codigo_Control_Inspectivo_Linea_Empaque
		{
			get
			{
				return _codigoControlInspectivoLineaEmpaque;
			}
			set
			{
				_codigoControlInspectivoLineaEmpaque =value;
			}
		}
		public String Identificado
		{
			get
			{
				return _identificado;
			}
			set
			{
				_identificado =value;
			}
		}
		public String Cantidad
		{
			get
			{
				return _cantidad;
			}
			set
			{
				_cantidad =value;
			}
		}
		
		#region CONSTRUCTOR
		public BOT_Control_Inspectivo_Linea_Empaque_Embalaje()
		{
		}
		#endregion
		
	}
}
