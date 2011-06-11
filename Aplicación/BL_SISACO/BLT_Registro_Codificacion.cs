using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BO_SISACO;
using BDA_SISACO;

namespace BL_SISACO
{
	public partial class BLT_Registro_Codificacion:BLBase
	{
		public Boolean fnInsT_Registro_Codificacion(BOT_Registro_Codificacion poBOT_Registro_Codificacion,out string codigo_Registro_Codificacion)
		{
			BDAT_Registro_Codificacion loBDAT_Registro_Codificacion=new BDAT_Registro_Codificacion();
			return loBDAT_Registro_Codificacion.fnInsT_Registro_Codificacion(poBOT_Registro_Codificacion,out codigo_Registro_Codificacion);
		}
		public Boolean fnUpdT_Registro_Codificacion(BOT_Registro_Codificacion poBOT_Registro_Codificacion)
		{
			BDAT_Registro_Codificacion loBDAT_Registro_Codificacion=new BDAT_Registro_Codificacion();
			return loBDAT_Registro_Codificacion.fnUpdT_Registro_Codificacion(poBOT_Registro_Codificacion);
		}

		public Boolean fnInsUpdT_Registro_Codificacion(BOT_Registro_Codificacion poBOT_Registro_Codificacion)
		{
			BDAT_Registro_Codificacion loBDAT_Registro_Codificacion=new BDAT_Registro_Codificacion();
			return loBDAT_Registro_Codificacion.fnInsUpdT_Registro_Codificacion(poBOT_Registro_Codificacion);
		}
		public Boolean fnDelT_Registro_Codificacion(String psCodigo_Registro_Codificacion)
		{
			BDAT_Registro_Codificacion loBDAT_Registro_Codificacion=new BDAT_Registro_Codificacion();
			
			return loBDAT_Registro_Codificacion.fnDelT_Registro_Codificacion(psCodigo_Registro_Codificacion);
		}

		public List<BOT_Registro_Codificacion> fnSelT_Registro_CodificacionAll()
		{
			BDAT_Registro_Codificacion loBDAT_Registro_Codificacion=new BDAT_Registro_Codificacion();
			return loBDAT_Registro_Codificacion.fnSelT_Registro_CodificacionAll();
		}

		public BOT_Registro_Codificacion fnSelT_Registro_Codificacion(String psCodigo_Registro_Codificacion)
		{
			BDAT_Registro_Codificacion loBDAT_Registro_Codificacion=new BDAT_Registro_Codificacion();
			return loBDAT_Registro_Codificacion.fnSelT_Registro_Codificacion(psCodigo_Registro_Codificacion);
		}
		public List<BOT_Registro_Codificacion> fnSelT_Registro_CodificacionDin(string psWhere,string psOrder)
		{
			BDAT_Registro_Codificacion loBDAT_Registro_Codificacion=new BDAT_Registro_Codificacion();
			return loBDAT_Registro_Codificacion.fnSelT_Registro_CodificacionDin(psWhere,psOrder);

		}
		public Int32[] fnSelT_Registro_CodificacionMinMax()
        {
            BDAT_Registro_Codificacion loBDAT_Registro_Codificacion = new BDAT_Registro_Codificacion();
            return loBDAT_Registro_Codificacion.fnSelT_Registro_CodificacionMinMax();
        }


	}
}
