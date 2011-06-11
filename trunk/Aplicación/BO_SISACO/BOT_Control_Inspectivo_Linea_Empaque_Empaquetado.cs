using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Control_Inspectivo_Linea_Empaque_Empaquetado:BOBase
	{
		private String _codigoControlInspectivoLineaEmpaqueEmpaquetado;
		private String _codigoControlInspectivoLineaEmpaque;
		private String _nombre;
		private String _impresion;
		private String _loteExpiracion;
		
		public String Codigo_Control_Inspectivo_Linea_Empaque_Empaquetado
		{
			get
			{
				return _codigoControlInspectivoLineaEmpaqueEmpaquetado;
			}
			set
			{
				_codigoControlInspectivoLineaEmpaqueEmpaquetado =value;
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
		public String Nombre
		{
			get
			{
				return _nombre;
			}
			set
			{
				_nombre =value;
			}
		}
		public String Impresion
		{
			get
			{
				return _impresion;
			}
			set
			{
				_impresion =value;
			}
		}
		public String Lote_Expiracion
		{
			get
			{
				return _loteExpiracion;
			}
			set
			{
				_loteExpiracion =value;
			}
		}
		
		#region CONSTRUCTOR
		public BOT_Control_Inspectivo_Linea_Empaque_Empaquetado()
		{
		}
		#endregion
		
	}
}
