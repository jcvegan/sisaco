using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones:BOBase
	{
		private String _codigoRegistroEmpaqueDespejeLineaEquiposInstalaciones;
		private String _codigoRegistroEmpaqueDespejeLinea;
		private String _equiposInstalacionesLimpios;
		private String _equiposInstalacionesIdentificados;
		private String _equiposInstalacionesBalanzasCalibradasVerificadas;
		private String _equiposInstalacionesHumedadRelativa;
		private String _equiposInstalacionesDiferencialPresion;
		private String _equiposInstalacionesTemperatura;
		
		public String Codigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones
		{
			get
			{
				return _codigoRegistroEmpaqueDespejeLineaEquiposInstalaciones;
			}
			set
			{
				_codigoRegistroEmpaqueDespejeLineaEquiposInstalaciones =value;
			}
		}
		public String Codigo_Registro_Empaque_Despeje_Linea
		{
			get
			{
				return _codigoRegistroEmpaqueDespejeLinea;
			}
			set
			{
				_codigoRegistroEmpaqueDespejeLinea =value;
			}
		}
		public String Equipos_Instalaciones_Limpios
		{
			get
			{
				return _equiposInstalacionesLimpios;
			}
			set
			{
				_equiposInstalacionesLimpios =value;
			}
		}
		public String Equipos_Instalaciones_Identificados
		{
			get
			{
				return _equiposInstalacionesIdentificados;
			}
			set
			{
				_equiposInstalacionesIdentificados =value;
			}
		}
		public String Equipos_Instalaciones_Balanzas_Calibradas_Verificadas
		{
			get
			{
				return _equiposInstalacionesBalanzasCalibradasVerificadas;
			}
			set
			{
				_equiposInstalacionesBalanzasCalibradasVerificadas =value;
			}
		}
		public String Equipos_Instalaciones_Humedad_Relativa
		{
			get
			{
				return _equiposInstalacionesHumedadRelativa;
			}
			set
			{
				_equiposInstalacionesHumedadRelativa =value;
			}
		}
		public String Equipos_Instalaciones_Diferencial_Presion
		{
			get
			{
				return _equiposInstalacionesDiferencialPresion;
			}
			set
			{
				_equiposInstalacionesDiferencialPresion =value;
			}
		}
		public String Equipos_Instalaciones_Temperatura
		{
			get
			{
				return _equiposInstalacionesTemperatura;
			}
			set
			{
				_equiposInstalacionesTemperatura =value;
			}
		}
		
		#region CONSTRUCTOR
		public BOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones()
		{
		}
		#endregion
		
	}
}
