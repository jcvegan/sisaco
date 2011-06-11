using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Material_Empaque_x_Orden_Acondicionamiento:BOBase
	{
		private String _codigoMaterialEmpaquexOrdenAcondiconamiento;
		private String _codigoOrdenAcondicionamiento;
		private String _codigoMaterialEmpaquexProducto;
		private Decimal _cantidadEntregada;
		private String _numeroAnalisis;
		
		public String Codigo_Material_Empaque_x_Orden_Acondiconamiento
		{
			get
			{
				return _codigoMaterialEmpaquexOrdenAcondiconamiento;
			}
			set
			{
				_codigoMaterialEmpaquexOrdenAcondiconamiento =value;
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
		public Decimal Cantidad_Entregada
		{
			get
			{
				return _cantidadEntregada;
			}
			set
			{
                bool convert = decimal.TryParse(value.ToString(), out this._cantidadEntregada);
                if (convert) {
                    _cantidadEntregada = value;
                }
			}
		}
		public String Numero_Analisis
		{
			get
			{
				return _numeroAnalisis;
			}
			set
			{
				_numeroAnalisis =value;
			}
		}
		
		#region CONSTRUCTOR
		public BOT_Material_Empaque_x_Orden_Acondicionamiento()
		{
		}
		#endregion
		
	}
}
