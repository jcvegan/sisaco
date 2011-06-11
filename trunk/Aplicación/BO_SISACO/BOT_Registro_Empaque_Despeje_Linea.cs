using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Registro_Empaque_Despeje_Linea:BOBase
	{
		private String _codigoRegistroEmpaqueDespejeLinea;
		private String _codigoEmpaque;
		private String _codigoRegistroEmpaqueDespejeLineaArea;
		private String _codigoRegistroEmpaqueDespejeLineaEquiposInstalaciones;
		private String _codigoRegistroEmpaqueDespejeLineaDocumentacion;
		private String _codigoRegistroEmpaqueDespejeLineaMaterialesInsumos;
		private String _codigoRegistroEmpaqueDespejeLineaPersonal;
		private DateTime _fecha;
		private String _hora;
		
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
		public String Codigo_Empaque
		{
			get
			{
				return _codigoEmpaque;
			}
			set
			{
				_codigoEmpaque =value;
			}
		}
		public String Codigo_Registro_Empaque_Despeje_Linea_Area
		{
			get
			{
				return _codigoRegistroEmpaqueDespejeLineaArea;
			}
			set
			{
				_codigoRegistroEmpaqueDespejeLineaArea =value;
			}
		}
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
		public String Codigo_Registro_Empaque_Despeje_Linea_Documentacion
		{
			get
			{
				return _codigoRegistroEmpaqueDespejeLineaDocumentacion;
			}
			set
			{
				_codigoRegistroEmpaqueDespejeLineaDocumentacion =value;
			}
		}
		public String Codigo_Registro_Empaque_Despeje_Linea_Materiales_Insumos
		{
			get
			{
				return _codigoRegistroEmpaqueDespejeLineaMaterialesInsumos;
			}
			set
			{
				_codigoRegistroEmpaqueDespejeLineaMaterialesInsumos =value;
			}
		}
		public String Codigo_Registro_Empaque_Despeje_Linea_Personal
		{
			get
			{
				return _codigoRegistroEmpaqueDespejeLineaPersonal;
			}
			set
			{
				_codigoRegistroEmpaqueDespejeLineaPersonal =value;
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
		public BOT_Registro_Empaque_Despeje_Linea()
		{
		}
		#endregion
		
	}
}
