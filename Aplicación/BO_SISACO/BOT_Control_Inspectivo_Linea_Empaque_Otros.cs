using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Control_Inspectivo_Linea_Empaque_Otros:BOBase
	{
		private String _codigoControlInspectivoLineaEmpaqueOtros;
		private String _codigoControlInspectivoLineaEmapaque;
		private String _inserto;
		
		public String Codigo_Control_Inspectivo_Linea_Empaque_Otros
		{
			get
			{
				return _codigoControlInspectivoLineaEmpaqueOtros;
			}
			set
			{
				_codigoControlInspectivoLineaEmpaqueOtros =value;
			}
		}
		public String Codigo_Control_Inspectivo_Linea_Emapaque
		{
			get
			{
				return _codigoControlInspectivoLineaEmapaque;
			}
			set
			{
				_codigoControlInspectivoLineaEmapaque =value;
			}
		}
		public String Inserto
		{
			get
			{
				return _inserto;
			}
			set
			{
				_inserto =value;
			}
		}
		
		#region CONSTRUCTOR
		public BOT_Control_Inspectivo_Linea_Empaque_Otros()
		{
		}
		#endregion
		
	}
}
