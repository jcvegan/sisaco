using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Registro_Codificacion_Codificacion_Cajas:BOBase
	{
		private String _codigoRegistroCodificacionCodificacionCajas;
		private String _codigoRegistroCodificacion;
		private DateTime _procedimiento1Fecha;
		private DateTime _procedimiento2Fecha;
		private DateTime _procedimiento3Fecha;
		private DateTime _procedimiento4Fecha;
		private DateTime _procedimiento5Fecha;
		private DateTime _procedimiento6Fecha;
		private String _totalMaterialCodificado;
		
		public String Codigo_Registro_Codificacion_Codificacion_Cajas
		{
			get
			{
				return _codigoRegistroCodificacionCodificacionCajas;
			}
			set
			{
				_codigoRegistroCodificacionCodificacionCajas =value;
			}
		}
		public String Codigo_Registro_Codificacion
		{
			get
			{
				return _codigoRegistroCodificacion;
			}
			set
			{
				_codigoRegistroCodificacion =value;
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
		public DateTime Procedimiento_6_Fecha
		{
			get
			{
				return _procedimiento6Fecha;
			}
			set
			{
				_procedimiento6Fecha =value;
			}
		}
		public String Total_Material_Codificado
		{
			get
			{
				return _totalMaterialCodificado;
			}
			set
			{
				_totalMaterialCodificado =value;
			}
		}
		
		#region CONSTRUCTOR
		public BOT_Registro_Codificacion_Codificacion_Cajas()
		{
		}
		#endregion
		
	}
}
