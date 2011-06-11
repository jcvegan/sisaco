using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Registro_Codificacion_Despeje_Linea_Documentacion:BOBase
	{
		private String _codigoRegistroCodificacionDespejeLineaDocumentacion;
		private String _codigoRegistroCodificacionDespejeLinea;
		private String _documentacionRegistroManufactura;
		private String _documentacionEtiquetas;
		
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
		public String Documentacion_Registro_Manufactura
		{
			get
			{
				return _documentacionRegistroManufactura;
			}
			set
			{
				_documentacionRegistroManufactura =value;
			}
		}
		public String Documentacion_Etiquetas
		{
			get
			{
				return _documentacionEtiquetas;
			}
			set
			{
				_documentacionEtiquetas =value;
			}
		}
		
		#region CONSTRUCTOR
		public BOT_Registro_Codificacion_Despeje_Linea_Documentacion()
		{
		}
		#endregion
		
	}
}
