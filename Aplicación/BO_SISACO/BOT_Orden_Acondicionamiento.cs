using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Orden_Acondicionamiento:BOBase
	{
		private String _codigoOrdenAcondicionamiento;
		private String _codigoProducto;
		private String _codigoAdicional;
		private String _codigoDevolucion;
		private String _codigoRegistroCodificacion;
		private String _codigoRegistroEmpaque;
		private String _codigoRegistroEntrega;
		private String _codigoControlInspectivoLineaEmpaque;
		private String _codigoRendimientoEmpaque;
		private String _codigoRendimientoReporteFinal;
		private String _observaciones;
		private DateTime _vigencia;
		
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
		public String Codigo_Producto
		{
			get
			{
				return _codigoProducto;
			}
			set
			{
				_codigoProducto =value;
			}
		}
		public String Codigo_Adicional
		{
			get
			{
				return _codigoAdicional;
			}
			set
			{
				_codigoAdicional =value;
			}
		}
		public String Codigo_Devolucion
		{
			get
			{
				return _codigoDevolucion;
			}
			set
			{
				_codigoDevolucion =value;
			}
		}
		public String Codigo_Registro_Codificacion
		{
			get
			{
				return _codigoRegistroCodificacion;
			}
			set
			{
				_codigoRegistroCodificacion =value;
			}
		}
		public String Codigo_Registro_Empaque
		{
			get
			{
				return _codigoRegistroEmpaque;
			}
			set
			{
				_codigoRegistroEmpaque =value;
			}
		}
		public String Codigo_Registro_Entrega
		{
			get
			{
				return _codigoRegistroEntrega;
			}
			set
			{
				_codigoRegistroEntrega =value;
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
		public String Codigo_Rendimiento_Empaque
		{
			get
			{
				return _codigoRendimientoEmpaque;
			}
			set
			{
				_codigoRendimientoEmpaque =value;
			}
		}
		public String Codigo_Rendimiento_Reporte_Final
		{
			get
			{
				return _codigoRendimientoReporteFinal;
			}
			set
			{
				_codigoRendimientoReporteFinal =value;
			}
		}
		public String Observaciones
		{
			get
			{
				return _observaciones;
			}
			set
			{
				_observaciones =value;
			}
		}
		public DateTime Vigencia
		{
			get
			{
				return _vigencia;
			}
			set
			{
				_vigencia =value;
			}
		}
		
		#region CONSTRUCTOR
		public BOT_Orden_Acondicionamiento()
		{
		}
		#endregion
		
	}
}
