using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Registro_Entrega:BOBase
	{
		private String _codigoRegistroEntrega;
		private String _codigoOrdenAcondicionamiento;
		private String _codigoEntregaProductoEmpacar;
		private String _codigoEntregaProductoTerminadoAlmacen;
		private String _rendimiento;
		private String _observaciones;
		
		public String Codigo_Registro_Entrega
		{
			get
			{
				return _codigoRegistroEntrega;
			}
			set
			{
				_codigoRegistroEntrega =value;
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
		public String Codigo_Entrega_Producto_Empacar
		{
			get
			{
				return _codigoEntregaProductoEmpacar;
			}
			set
			{
				_codigoEntregaProductoEmpacar =value;
			}
		}
		public String Codigo_Entrega_Producto_Terminado_Almacen
		{
			get
			{
				return _codigoEntregaProductoTerminadoAlmacen;
			}
			set
			{
				_codigoEntregaProductoTerminadoAlmacen =value;
			}
		}
		public String Rendimiento
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
		public BOT_Registro_Entrega()
		{
		}
		#endregion
		
	}
}
