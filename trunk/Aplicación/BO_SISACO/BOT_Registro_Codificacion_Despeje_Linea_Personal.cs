using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Registro_Codificacion_Despeje_Linea_Personal:BOBase
	{
		private String _codigoRegistroCodificacionDespejeLineaPersonal;
		private String _codigoRegistroCodificacionDespejeLinea;
		private String _personalUniformeCompleto;
		private String _personalDispositivosSeguridad;
		private String _personalHigiene;
		
		public String Codigo_Registro_Codificacion_Despeje_Linea_Personal
		{
			get
			{
				return _codigoRegistroCodificacionDespejeLineaPersonal;
			}
			set
			{
				_codigoRegistroCodificacionDespejeLineaPersonal =value;
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
		public String Personal_Uniforme_Completo
		{
			get
			{
				return _personalUniformeCompleto;
			}
			set
			{
				_personalUniformeCompleto =value;
			}
		}
		public String Personal_Dispositivos_Seguridad
		{
			get
			{
				return _personalDispositivosSeguridad;
			}
			set
			{
				_personalDispositivosSeguridad =value;
			}
		}
		public String Personal_Higiene
		{
			get
			{
				return _personalHigiene;
			}
			set
			{
				_personalHigiene =value;
			}
		}
		
		#region CONSTRUCTOR
		public BOT_Registro_Codificacion_Despeje_Linea_Personal()
		{
		}
		#endregion
		
	}
}
