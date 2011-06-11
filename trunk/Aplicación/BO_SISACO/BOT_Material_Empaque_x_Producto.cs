using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Material_Empaque_x_Producto:BOBase
	{
		private String _codigoMaterialEmpaquexProducto;
		private String _codigoProducto;
		private String _loteFabricacion;
		private Int32 _TamañoLote;
		private String _codigoMaterialEmpaque;
		private Decimal _cantidadPedida;
		
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
		public String Lote_Fabricacion
		{
			get
			{
				return _loteFabricacion;
			}
			set
			{
				_loteFabricacion =value;
			}
		}
		public Int32 Tamaño_Lote
		{
			get
			{
				return _TamañoLote;
			}
			set
			{
				_TamañoLote =value;
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
		public Decimal Cantidad_Pedida
		{
			get
			{
				return _cantidadPedida;
			}
			set
			{
				_cantidadPedida = Math.Round(value,3);
			}
		}


        //CAMPOS ADICIONALES
        private String _nombreMaterialEmpaque;
        private String _unidadMedida;
        public String Nombre_Material_Empaque
        {
            get
            {
                return _nombreMaterialEmpaque;
            }
            set
            {
                _nombreMaterialEmpaque = value;
            }
        }
        public String Unidad_Medida
        {
            get
            {
                return _unidadMedida;
            }
            set
            {
                _unidadMedida = value;
            }
        }

        private Decimal _cantidadEntregada;
        private String _numeroAnalisis;
        public Decimal Cantidad_Entregada
        {
            get
            {
                return _cantidadEntregada;
            }
            set
            {
                //Cantidad entregada no puede ser mayor a la cantidad pedida.
                //if (value <= Cantidad_Pedida)
                bool convert = decimal.TryParse(value.ToString(), out this._cantidadEntregada);
                if (convert) {
                    _cantidadEntregada = Math.Round(value, 3);
                }
                    //_cantidadEntregada = value;
                
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
                _numeroAnalisis = value;
            }
        }
		
		#region CONSTRUCTOR
		public BOT_Material_Empaque_x_Producto()
		{
		}
		#endregion
		
	}
}
