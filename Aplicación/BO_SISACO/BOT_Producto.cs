using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Producto:BOBase
	{
		private String _codigoProducto;
		private String _nombreProducto;
		private String _formaFarmaceutica;
		private String _proceso;
		private String _presentacion;
		
		public String Codigo_Producto
		{
			get
			{
				return _codigoProducto;
			}
			set
			{
				_codigoProducto =value;
			}
		}
		public String Nombre_Producto
		{
			get
			{
				return _nombreProducto;
			}
			set
			{
				_nombreProducto =value;
			}
		}
		public String Forma_Farmaceutica
		{
			get
			{
				return _formaFarmaceutica;
			}
			set
			{
				_formaFarmaceutica =value;
			}
		}
		public String Proceso
		{
			get
			{
				return _proceso;
			}
			set
			{
				_proceso =value;
			}
		}
		public String Presentacion
		{
			get
			{
				return _presentacion;
			}
			set
			{
				_presentacion =value;
			}
		}
		
		#region CONSTRUCTOR
		public BOT_Producto()
		{
		}
		#endregion
		
	}
}
