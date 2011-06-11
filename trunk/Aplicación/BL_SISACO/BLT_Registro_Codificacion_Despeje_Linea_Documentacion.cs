using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BO_SISACO;
using BDA_SISACO;

namespace BL_SISACO
{
	public partial class BLT_Registro_Codificacion_Despeje_Linea_Documentacion:BLBase
	{
		public Boolean fnInsT_Registro_Codificacion_Despeje_Linea_Documentacion(BOT_Registro_Codificacion_Despeje_Linea_Documentacion poBOT_Registro_Codificacion_Despeje_Linea_Documentacion)
		{
			BDAT_Registro_Codificacion_Despeje_Linea_Documentacion loBDAT_Registro_Codificacion_Despeje_Linea_Documentacion=new BDAT_Registro_Codificacion_Despeje_Linea_Documentacion();
			return loBDAT_Registro_Codificacion_Despeje_Linea_Documentacion.fnInsT_Registro_Codificacion_Despeje_Linea_Documentacion(poBOT_Registro_Codificacion_Despeje_Linea_Documentacion);
		}
		public Boolean fnUpdT_Registro_Codificacion_Despeje_Linea_Documentacion(BOT_Registro_Codificacion_Despeje_Linea_Documentacion poBOT_Registro_Codificacion_Despeje_Linea_Documentacion)
		{
			BDAT_Registro_Codificacion_Despeje_Linea_Documentacion loBDAT_Registro_Codificacion_Despeje_Linea_Documentacion=new BDAT_Registro_Codificacion_Despeje_Linea_Documentacion();
			return loBDAT_Registro_Codificacion_Despeje_Linea_Documentacion.fnUpdT_Registro_Codificacion_Despeje_Linea_Documentacion(poBOT_Registro_Codificacion_Despeje_Linea_Documentacion);
		}

		public Boolean fnInsUpdT_Registro_Codificacion_Despeje_Linea_Documentacion(BOT_Registro_Codificacion_Despeje_Linea_Documentacion poBOT_Registro_Codificacion_Despeje_Linea_Documentacion,out string codigo_registro_codificacion_despeje_linea_documentacion)
		{
			BDAT_Registro_Codificacion_Despeje_Linea_Documentacion loBDAT_Registro_Codificacion_Despeje_Linea_Documentacion=new BDAT_Registro_Codificacion_Despeje_Linea_Documentacion();
			return loBDAT_Registro_Codificacion_Despeje_Linea_Documentacion.fnInsUpdT_Registro_Codificacion_Despeje_Linea_Documentacion(poBOT_Registro_Codificacion_Despeje_Linea_Documentacion,out codigo_registro_codificacion_despeje_linea_documentacion);
		}
		public Boolean fnDelT_Registro_Codificacion_Despeje_Linea_Documentacion(String psCodigo_Registro_Codificacion_Despeje_Linea_Documentacion)
		{
			BDAT_Registro_Codificacion_Despeje_Linea_Documentacion loBDAT_Registro_Codificacion_Despeje_Linea_Documentacion=new BDAT_Registro_Codificacion_Despeje_Linea_Documentacion();
			
			return loBDAT_Registro_Codificacion_Despeje_Linea_Documentacion.fnDelT_Registro_Codificacion_Despeje_Linea_Documentacion(psCodigo_Registro_Codificacion_Despeje_Linea_Documentacion);
		}

		public List<BOT_Registro_Codificacion_Despeje_Linea_Documentacion> fnSelT_Registro_Codificacion_Despeje_Linea_DocumentacionAll()
		{
			BDAT_Registro_Codificacion_Despeje_Linea_Documentacion loBDAT_Registro_Codificacion_Despeje_Linea_Documentacion=new BDAT_Registro_Codificacion_Despeje_Linea_Documentacion();
			return loBDAT_Registro_Codificacion_Despeje_Linea_Documentacion.fnSelT_Registro_Codificacion_Despeje_Linea_DocumentacionAll();
		}

		public BOT_Registro_Codificacion_Despeje_Linea_Documentacion fnSelT_Registro_Codificacion_Despeje_Linea_Documentacion(String psCodigo_Registro_Codificacion_Despeje_Linea_Documentacion)
		{
			BDAT_Registro_Codificacion_Despeje_Linea_Documentacion loBDAT_Registro_Codificacion_Despeje_Linea_Documentacion=new BDAT_Registro_Codificacion_Despeje_Linea_Documentacion();
			return loBDAT_Registro_Codificacion_Despeje_Linea_Documentacion.fnSelT_Registro_Codificacion_Despeje_Linea_Documentacion(psCodigo_Registro_Codificacion_Despeje_Linea_Documentacion);
		}
		public List<BOT_Registro_Codificacion_Despeje_Linea_Documentacion> fnSelT_Registro_Codificacion_Despeje_Linea_DocumentacionDin(string psWhere,string psOrder)
		{
			BDAT_Registro_Codificacion_Despeje_Linea_Documentacion loBDAT_Registro_Codificacion_Despeje_Linea_Documentacion=new BDAT_Registro_Codificacion_Despeje_Linea_Documentacion();
			return loBDAT_Registro_Codificacion_Despeje_Linea_Documentacion.fnSelT_Registro_Codificacion_Despeje_Linea_DocumentacionDin(psWhere,psOrder);

		}
		public Int32[] fnSelT_Registro_Codificacion_Despeje_Linea_DocumentacionMinMax()
        {
            BDAT_Registro_Codificacion_Despeje_Linea_Documentacion loBDAT_Registro_Codificacion_Despeje_Linea_Documentacion = new BDAT_Registro_Codificacion_Despeje_Linea_Documentacion();
            return loBDAT_Registro_Codificacion_Despeje_Linea_Documentacion.fnSelT_Registro_Codificacion_Despeje_Linea_DocumentacionMinMax();
        }


	}
}
