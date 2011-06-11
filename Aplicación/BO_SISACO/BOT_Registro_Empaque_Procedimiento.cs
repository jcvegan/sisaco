using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Registro_Empaque_Procedimiento:BOBase
	{
		private String _codigoRegistroEmpaqueProcedimiento;
		private String _codigoRegistroEmpaque;
		private DateTime _procedimiento1Fecha;
		private DateTime _procedimiento2Fecha;
		private DateTime _procedimiento3Fecha;
		private DateTime _procedimiento4Fecha;
		private DateTime _procedimiento5Fecha;
		private String _numeroLote;
		private DateTime _fechaVencimiento;
		private Int32 _cantidadCajas;
		
		public String Codigo_Registro_Empaque_Procedimiento
		{
			get
			{
				return _codigoRegistroEmpaqueProcedimiento;
			}
			set
			{
				_codigoRegistroEmpaqueProcedimiento =value;
			}
		}
		public String Codigo_Registro_Empaque
		{
			get
			{
				return _codigoRegistroEmpaque;
			}
			set
			{
				_codigoRegistroEmpaque =value;
			}
		}
		public DateTime Procedimiento_1_Fecha
		{
			get
			{
				return _procedimiento1Fecha;
			}
			set
			{
				_procedimiento1Fecha =value;
			}
		}
		public DateTime Procedimiento_2_Fecha
		{
			get
			{
				return _procedimiento2Fecha;
			}
			set
			{
				_procedimiento2Fecha =value;
			}
		}
		public DateTime Procedimiento_3_Fecha
		{
			get
			{
				return _procedimiento3Fecha;
			}
			set
			{
				_procedimiento3Fecha =value;
			}
		}
		public DateTime Procedimiento_4_Fecha
		{
			get
			{
				return _procedimiento4Fecha;
			}
			set
			{
				_procedimiento4Fecha =value;
			}
		}
		public DateTime Procedimiento_5_Fecha
		{
			get
			{
				return _procedimiento5Fecha;
			}
			set
			{
				_procedimiento5Fecha =value;
			}
		}
		public String Numero_Lote
		{
			get
			{
				return _numeroLote;
			}
			set
			{
				_numeroLote =value;
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
		public Int32 Cantidad_Cajas
		{
			get
			{
				return _cantidadCajas;
			}
			set
			{
				_cantidadCajas =value;
			}
		}
		
		#region CONSTRUCTOR
		public BOT_Registro_Empaque_Procedimiento()
		{
		}
		#endregion
		
	}
}
