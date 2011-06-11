using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Registro_Codificacion_Despeje_Linea:BOBase
	{
		private String _codigoRegistroCodificacionDespejeLinea;
		private String _codigoRegistroCodificacion;
		private String _codigoRegistroCodificacionDespejeLineaArea;
		private String _codigoRegistroCodificacionDespejeLineaEquiposInstalaciones;
		private String _codigoRegistroCodificacionDespejeLineaDocumentacion;
		private String _codigoRegistroCodificacionDespejeLineaMaterialesInsumos;
		private String _codigoRegistroCodificacionDespejeLineaPersonal;
		private DateTime _fecha;
		private String _hora;
		
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
		public String Codigo_Registro_Codificacion_Despeje_Linea_Area
		{
			get
			{
				return _codigoRegistroCodificacionDespejeLineaArea;
			}
			set
			{
				_codigoRegistroCodificacionDespejeLineaArea =value;
			}
		}
		public String Codigo_Registro_Codificacion_Despeje_Linea_Equipos_Instalaciones
		{
			get
			{
				return _codigoRegistroCodificacionDespejeLineaEquiposInstalaciones;
			}
			set
			{
				_codigoRegistroCodificacionDespejeLineaEquiposInstalaciones =value;
			}
		}
		public String Codigo_Registro_Codificacion_Despeje_Linea_Documentacion
		{
			get
			{
				return _codigoRegistroCodificacionDespejeLineaDocumentacion;
			}
			set
			{
				_codigoRegistroCodificacionDespejeLineaDocumentacion =value;
			}
		}
		public String Codigo_Registro_Codificacion_Despeje_Linea_Materiales_Insumos
		{
			get
			{
				return _codigoRegistroCodificacionDespejeLineaMaterialesInsumos;
			}
			set
			{
				_codigoRegistroCodificacionDespejeLineaMaterialesInsumos =value;
			}
		}
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
		
		#region CONSTRUCTOR
		public BOT_Registro_Codificacion_Despeje_Linea()
		{
		}
		#endregion
		
	}
}
