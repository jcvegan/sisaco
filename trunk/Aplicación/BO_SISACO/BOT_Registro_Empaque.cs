using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Registro_Empaque:BOBase
	{
		private String _codigoRegistroEmpaque;
		private String _codigoOrdenAcondicionamiento;
		private String _codigoRegistroEmpaqueDespejeLinea;
		private String _codigoRegistroEmpaqueProcedimiento;
		private String _observaciones;
		
		public String Codigo_Registro_Empaque
		{
			get
			{
				return _codigoRegistroEmpaque;
			}
			set
			{
				_codigoRegistroEmpaque =value;
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
		public String Codigo_Registro_Empaque_Procedimiento
		{
			get
			{
				return _codigoRegistroEmpaqueProcedimiento;
			}
			set
			{
				_codigoRegistroEmpaqueProcedimiento =value;
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
		public BOT_Registro_Empaque()
		{
		}
		#endregion
		
	}
}
