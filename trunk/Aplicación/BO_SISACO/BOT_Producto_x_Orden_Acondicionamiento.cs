using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Producto_x_Orden_Acondicionamiento:BOBase
	{
		private String _codigoProductoxOrdenAcondicionamiento;
		private String _codigoOrdenAcondicionamiento;
		private String _codigoMaterialEmpaquexProducto;
		private String _linea;
		private DateTime _fechaVencimiento;
		
		public String Codigo_Producto_x_Orden_Acondicionamiento
		{
			get
			{
				return _codigoProductoxOrdenAcondicionamiento;
			}
			set
			{
				_codigoProductoxOrdenAcondicionamiento =value;
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
		public String Codigo_Material_Empaque_x_Producto
		{
			get
			{
				return _codigoMaterialEmpaquexProducto;
			}
			set
			{
				_codigoMaterialEmpaquexProducto =value;
			}
		}
		public String Linea
		{
			get
			{
				return _linea;
			}
			set
			{
				_linea =value;
			}
		}
		public DateTime Fecha_Vencimiento
		{
			get
			{
				return _fechaVencimiento;
			}
			set
			{
				_fechaVencimiento =value;
			}
		}
		
		#region CONSTRUCTOR
		public BOT_Producto_x_Orden_Acondicionamiento()
		{
		}
		#endregion
		
	}
}
