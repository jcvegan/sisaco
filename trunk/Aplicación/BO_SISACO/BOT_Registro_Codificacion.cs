using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Registro_Codificacion:BOBase
	{
		private String _codigoRegistroCodificacion;
		private String _codigoOrdenAcondicionamiento;
		private String _codigoRegistroCodificacionDespejeLinea;
		private String _codigoRegistroCodificacionCodificacionCajas;
		private String _observaciones;
		
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
		public String Codigo_Registro_Codificacion_Despeje_Linea
		{
			get
			{
				return _codigoRegistroCodificacionDespejeLinea;
			}
			set
			{
				_codigoRegistroCodificacionDespejeLinea =value;
			}
		}
		public String Codigo_Registro_Codificacion_Codificacion_Cajas
		{
			get
			{
				return _codigoRegistroCodificacionCodificacionCajas;
			}
			set
			{
				_codigoRegistroCodificacionCodificacionCajas =value;
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
		public BOT_Registro_Codificacion()
		{
		}
		#endregion
		
	}
}
