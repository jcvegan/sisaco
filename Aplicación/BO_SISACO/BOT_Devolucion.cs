using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Devolucion:BOBase
	{
		private String _codigoDevolucion;
		private String _codigoOrdenAcondicionamiento;
        private String _codigo_Producto;
		private String _numeroAnalisis;
		private String _cantidad;
		private DateTime _fecha;
        private BOT_Producto _producto;
		
		public String Codigo_Devolucion
		{
			get
			{
				return _codigoDevolucion;
			}
			set
			{
				_codigoDevolucion =value;
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
        public String Codigo_Producto {
            get {
                return _codigo_Producto;
            }
            set {
                _codigo_Producto = value;
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
		public String Cantidad
		{
			get
			{
				return _cantidad;
			}
			set
			{
				_cantidad =value;
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
        public BOT_Producto Producto {
            get {
                return _producto;
            }
            set {
                _producto = value;
            }
        }
        public String Nombre_Producto {
            get {
                return _producto.Nombre_Producto;
            }
        }
		
		#region CONSTRUCTOR
		public BOT_Devolucion()
		{
		}
		#endregion
		
	}
}
