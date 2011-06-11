using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Material_Empaque:BOBase
	{
		private String _codigoMaterialEmpaque;
		private String _nombreMaterialEmpaque;
		private String _unidadMedida;
        private Decimal _cantidadPedida;
        private String _codigoMaterialEmpaquexProducto;
       		
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
		public String Unidad_Medida
		{
			get
			{
				return _unidadMedida;
			}
			set
			{
				_unidadMedida =value;
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
                _cantidadPedida = value; 
            }
        }

        public String CodigoMaterialEmpaquexProducto
        {
            get 
            {
                return _codigoMaterialEmpaquexProducto; 
            }
            set
            {
                _codigoMaterialEmpaquexProducto = value; 
            }
        }
		
		#region CONSTRUCTOR
		public BOT_Material_Empaque()
		{
		}
		#endregion
		
	}
}
