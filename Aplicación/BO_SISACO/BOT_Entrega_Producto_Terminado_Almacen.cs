using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Entrega_Producto_Terminado_Almacen:BOBase
	{
		private String _codigoEntregaProductoTerminadoAlmacen;
		private String _codigoRegistroEntrega;
		private DateTime _fecha;
		private String _numeroGuia;
		private String _unidadesAcumuladas;
		private String _total;
		
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
		public String Numero_Guia
		{
			get
			{
				return _numeroGuia;
			}
			set
			{
				_numeroGuia =value;
			}
		}
		public String Unidades_Acumuladas
		{
			get
			{
				return _unidadesAcumuladas;
			}
			set
			{
				_unidadesAcumuladas =value;
			}
		}
		public String Total
		{
			get
			{
				return _total;
			}
			set
			{
				_total =value;
			}
		}
		
		#region CONSTRUCTOR
		public BOT_Entrega_Producto_Terminado_Almacen()
		{
		}
		#endregion
		
	}
}
