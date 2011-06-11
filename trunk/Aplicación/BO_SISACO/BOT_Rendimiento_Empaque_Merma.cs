using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Rendimiento_Empaque_Merma:BOBase
	{
		private String _codigoRendimientoEmpaqueMerma;
		private String _codigoRendimientoEmpaque;
		private String _motivoMerma;
		private String _cantidadMerma;
		
		public String Codigo_Rendimiento_Empaque_Merma
		{
			get
			{
				return _codigoRendimientoEmpaqueMerma;
			}
			set
			{
				_codigoRendimientoEmpaqueMerma =value;
			}
		}
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
		public String Motivo_Merma
		{
			get
			{
				return _motivoMerma;
			}
			set
			{
				_motivoMerma =value;
			}
		}
		public String Cantidad_Merma
		{
			get
			{
				return _cantidadMerma;
			}
			set
			{
				_cantidadMerma =value;
			}
		}
		
		#region CONSTRUCTOR
		public BOT_Rendimiento_Empaque_Merma()
		{
		}
		#endregion
		
	}
}
