using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Control_Inspectivo_Linea_Empaque:BOBase
	{
		private String _codigoControlInspectivoLineaEmpaque;
		private String _codigoOrdenAcondicionamiento;
		private String _areaLimpiaOrdenada;
		private String _vestimentaAdecuada;
		private String _documentacion;
		private String _codigoControlInsepectivoLineaEmpaqueTipoEmpaquetado;
		private String _codigoControlInspectivoLineaEmpaqueCaja;
		private String _codigoControlInspectivoLineaEmpaqueEmbalaje;
		private String _codigoControlInspectivoLineaEmpaqueOtros;
		private String _racionAdecuada;
		private String _otrosProductos;
		private String _hora;
		private DateTime _fecha;
		
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
		public String Codigo_Orden_Acondicionamiento
		{
			get
			{
				return _codigoOrdenAcondicionamiento;
			}
			set
			{
				_codigoOrdenAcondicionamiento =value;
			}
		}
		public String Area_Limpia_Ordenada
		{
			get
			{
				return _areaLimpiaOrdenada;
			}
			set
			{
				_areaLimpiaOrdenada =value;
			}
		}
		public String Vestimenta_Adecuada
		{
			get
			{
				return _vestimentaAdecuada;
			}
			set
			{
				_vestimentaAdecuada =value;
			}
		}
		public String Documentacion
		{
			get
			{
				return _documentacion;
			}
			set
			{
				_documentacion =value;
			}
		}
		public String Codigo_Control_Insepectivo_Linea_Empaque_Tipo_Empaquetado
		{
			get
			{
				return _codigoControlInsepectivoLineaEmpaqueTipoEmpaquetado;
			}
			set
			{
				_codigoControlInsepectivoLineaEmpaqueTipoEmpaquetado =value;
			}
		}
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
		public String Racion_Adecuada
		{
			get
			{
				return _racionAdecuada;
			}
			set
			{
				_racionAdecuada =value;
			}
		}
		public String Otros_Productos
		{
			get
			{
				return _otrosProductos;
			}
			set
			{
				_otrosProductos =value;
			}
		}
		public String Hora
		{
			get
			{
				return _hora;
			}
			set
			{
				_hora =value;
			}
		}
		public DateTime Fecha
		{
			get
			{
				return _fecha;
			}
			set
			{
				_fecha =value;
			}
		}
		
		#region CONSTRUCTOR
		public BOT_Control_Inspectivo_Linea_Empaque()
		{
		}
		#endregion
		
	}
}
