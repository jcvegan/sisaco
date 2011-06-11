using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Registro_Codificacion_Despeje_Linea_Area:BOBase
	{
		private String _codigoRegistroCodificacionDespejeLineaArea;
		private String _codigoRegistroCodificacionDespejeLinea;
		private String _areaLimpia;
		private String _areaOrdenada;
		private String _areaLibreProductoAnterior;
		private String _areaIdentificada;
		private String _areaMaterialesLimpiosSecos;
		private String _areaCorrectaIluminacionVentilacion;
		
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
		public String Area_Limpia
		{
			get
			{
				return _areaLimpia;
			}
			set
			{
				_areaLimpia =value;
			}
		}
		public String Area_Ordenada
		{
			get
			{
				return _areaOrdenada;
			}
			set
			{
				_areaOrdenada =value;
			}
		}
		public String Area_Libre_Producto_Anterior
		{
			get
			{
				return _areaLibreProductoAnterior;
			}
			set
			{
				_areaLibreProductoAnterior =value;
			}
		}
		public String Area_Identificada
		{
			get
			{
				return _areaIdentificada;
			}
			set
			{
				_areaIdentificada =value;
			}
		}
		public String Area_Materiales_Limpios_Secos
		{
			get
			{
				return _areaMaterialesLimpiosSecos;
			}
			set
			{
				_areaMaterialesLimpiosSecos =value;
			}
		}
		public String Area_Correcta_Iluminacion_Ventilacion
		{
			get
			{
				return _areaCorrectaIluminacionVentilacion;
			}
			set
			{
				_areaCorrectaIluminacionVentilacion =value;
			}
		}
		
		#region CONSTRUCTOR
		public BOT_Registro_Codificacion_Despeje_Linea_Area()
		{
		}
		#endregion
		
	}
}
