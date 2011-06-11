using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Control_Inspectivo_Linea_Empaque_Caja:BOBase
	{
		private String _codigoControlInspectivoLineaEmpaqueCaja;
		private String _codigoControlInspectivoLineaEmpaque;
		private String _nombre;
		private String _impresion;
		private String _loteExpiracion;
		private String _presemtacion;
		private String _cantidad;
		
		public String Codigo_Control_Inspectivo_Linea_Empaque_Caja
		{
			get
			{
				return _codigoControlInspectivoLineaEmpaqueCaja;
			}
			set
			{
				_codigoControlInspectivoLineaEmpaqueCaja =value;
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
		public String Presemtacion
		{
			get
			{
				return _presemtacion;
			}
			set
			{
				_presemtacion =value;
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
		public BOT_Control_Inspectivo_Linea_Empaque_Caja()
		{
		}
		#endregion
		
	}
}
