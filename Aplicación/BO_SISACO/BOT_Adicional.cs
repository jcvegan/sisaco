using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Adicional:BOBase
	{
		private String _codigoAdicional;
		private String _codigoOrdenAcondicionado;
		private String _insumo;
		private String _numeroAnalisis;
		private String _cantidad;
		private DateTime _fecha;
		
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
		public String Codigo_Orden_Acondicionado
		{
			get
			{
				return _codigoOrdenAcondicionado;
			}
			set
			{
				_codigoOrdenAcondicionado =value;
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
		public BOT_Adicional()
		{
            Fecha = DateTime.Now;
		}
		#endregion
		
	}
}
