using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Rendimiento_Empaque_Tamaño_Material_Empaque:BOBase
	{
		private String _codigoRendimientoEmpaqueTamañoEmpaque;
		private String _codigoRendimientoEmpaque;
		private String _codigoMaterialEmpaque;
		private String _nombreMaterialEmpaque;
		private Decimal _cantidadEntregada;
		private Decimal _cantidadDevuelto;
		private Decimal _cantidadEmpleado;
		private Decimal _cantidadMerma;
		private Decimal _rendimiento;
		private Decimal _conciliacion;
		
		public String Codigo_Rendimiento_Empaque_Tamaño_Empaque
		{
			get
			{
				return _codigoRendimientoEmpaqueTamañoEmpaque;
			}
			set
			{
				_codigoRendimientoEmpaqueTamañoEmpaque =value;
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
		public String Codigo_Material_Empaque
		{
			get
			{
				return _codigoMaterialEmpaque;
			}
			set
			{
				_codigoMaterialEmpaque =value;
			}
		}
		public String Nombre_Material_Empaque
		{
			get
			{
				return _nombreMaterialEmpaque;
			}
			set
			{
				_nombreMaterialEmpaque =value;
			}
		}
		public Decimal Cantidad_Entregada
		{
			get
			{
				return _cantidadEntregada;
			}
			set
			{
				_cantidadEntregada =value;
			}
		}
		public Decimal Cantidad_Devuelto
		{
			get
			{
				return _cantidadDevuelto;
			}
			set
			{
				_cantidadDevuelto =value;
			}
		}
		public Decimal Cantidad_Empleado
		{
			get
			{
				return _cantidadEmpleado;
			}
			set
			{
				_cantidadEmpleado =value;
			}
		}
		public Decimal Cantidad_Merma
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
		public Decimal Rendimiento
		{
			get
			{
				return _rendimiento;
			}
			set
			{
				_rendimiento =value;
			}
		}
		public Decimal Conciliacion
		{
			get
			{
				return _conciliacion;
			}
			set
			{
				_conciliacion =value;
			}
		}
		
		#region CONSTRUCTOR
		public BOT_Rendimiento_Empaque_Tamaño_Material_Empaque()
		{
		}
		#endregion
		
	}
}
