using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Rendimiento_Empaque:BOBase
	{
		private String _codigoRendimientoEmpaque;
		private String _codigoOrdenAcondicionamiento;
		private String _codigoRendimientoEmpaqueTama�oMaterialEmpaque;
		private String _codigoMerma;
		
		public String Codigo_Rendimiento_Empaque
		{
			get
			{
				return _codigoRendimientoEmpaque;
			}
			set
			{
				_codigoRendimientoEmpaque =value;
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
		public String Codigo_Rendimiento_Empaque_Tama�o_Material_Empaque
		{
			get
			{
				return _codigoRendimientoEmpaqueTama�oMaterialEmpaque;
			}
			set
			{
				_codigoRendimientoEmpaqueTama�oMaterialEmpaque =value;
			}
		}
		public String Codigo_Merma
		{
			get
			{
				return _codigoMerma;
			}
			set
			{
				_codigoMerma =value;
			}
		}
		
		#region CONSTRUCTOR
		public BOT_Rendimiento_Empaque()
		{
		}
		#endregion
		
	}
}
