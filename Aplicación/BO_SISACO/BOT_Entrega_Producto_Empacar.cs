using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Entrega_Producto_Empacar:BOBase
	{
		private String _codigoEntregaProductoEmpacar;
		private String _codigoRegistroEntrega;
		private DateTime _fecha;
		private Decimal _promedio;
		private Decimal _pesoTotal;
		private Decimal _unidades;
		
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
		public Decimal Promedio
		{
			get
			{
				return _promedio;
			}
			set
			{
				_promedio =value;
			}
		}
		public Decimal Peso_Total
		{
			get
			{
				return _pesoTotal;
			}
			set
			{
				_pesoTotal =value;
			}
		}
		public Decimal Unidades
		{
			get
			{
				return _unidades;
			}
			set
			{
				_unidades =value;
			}
		}
		
		#region CONSTRUCTOR
		public BOT_Entrega_Producto_Empacar()
		{
		}
		#endregion
		
	}
}
