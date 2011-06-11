using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Rendimiento_Reporte_Final:BOBase
	{
		private String _codigoRendimientoReporteFinal;
		private String _codgoOrdenAcondicionamiento;
		private DateTime _fechaInicio;
		private DateTime _fechaTermino;
		private Int32 _cantidadTeorica;
		private Int32 _cantidadObtenida;
		private Decimal _merma;
		private Decimal _rendimientoFinal;
		private String _observaciones;
		
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
		public String Codgo_Orden_Acondicionamiento
		{
			get
			{
				return _codgoOrdenAcondicionamiento;
			}
			set
			{
				_codgoOrdenAcondicionamiento =value;
			}
		}
		public DateTime Fecha_Inicio
		{
			get
			{
				return _fechaInicio;
			}
			set
			{
				_fechaInicio =value;
			}
		}
		public DateTime Fecha_Termino
		{
			get
			{
				return _fechaTermino;
			}
			set
			{
				_fechaTermino =value;
			}
		}
		public Int32 Cantidad_Teorica
		{
			get
			{
				return _cantidadTeorica;
			}
			set
			{
				_cantidadTeorica =value;
			}
		}
		public Int32 Cantidad_Obtenida
		{
			get
			{
				return _cantidadObtenida;
			}
			set
			{
				_cantidadObtenida =value;
			}
		}
		public Decimal Merma
		{
			get
			{
				return _merma;
			}
			set
			{
				_merma =value;
			}
		}
		public Decimal Rendimiento_Final
		{
			get
			{
				return _rendimientoFinal;
			}
			set
			{
				_rendimientoFinal =value;
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
		
		#region CONSTRUCTOR
		public BOT_Rendimiento_Reporte_Final()
		{
		}
		#endregion
		
	}
}
