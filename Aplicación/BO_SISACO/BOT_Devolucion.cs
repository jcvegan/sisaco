using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Devolucion:BOBase
	{
		private String _codigoDevolucion;
		private String _codigoOrdenAcondicionamiento;
		private String _insumo;
		private String _numeroAnalisis;
		private String _cantidad;
		private DateTime _fecha;
		
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
		public String Insumo
		{
			get
			{
				return _insumo;
			}
			set
			{
				_insumo =value;
			}
		}
		public String Numero_Analisis
		{
			get
			{
				return _numeroAnalisis;
			}
			set
			{
				_numeroAnalisis =value;
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
		public BOT_Devolucion()
		{
		}
		#endregion
		
	}
}
