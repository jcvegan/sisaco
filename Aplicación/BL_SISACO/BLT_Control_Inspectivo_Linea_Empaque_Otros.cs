using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BO_SISACO;
using BDA_SISACO;

namespace BL_SISACO
{
	public partial class BLT_Control_Inspectivo_Linea_Empaque_Otros:BLBase
	{
		public Boolean fnInsT_Control_Inspectivo_Linea_Empaque_Otros(BOT_Control_Inspectivo_Linea_Empaque_Otros poBOT_Control_Inspectivo_Linea_Empaque_Otros)
		{
			BDAT_Control_Inspectivo_Linea_Empaque_Otros loBDAT_Control_Inspectivo_Linea_Empaque_Otros=new BDAT_Control_Inspectivo_Linea_Empaque_Otros();
			return loBDAT_Control_Inspectivo_Linea_Empaque_Otros.fnInsT_Control_Inspectivo_Linea_Empaque_Otros(poBOT_Control_Inspectivo_Linea_Empaque_Otros);
		}
		public Boolean fnUpdT_Control_Inspectivo_Linea_Empaque_Otros(BOT_Control_Inspectivo_Linea_Empaque_Otros poBOT_Control_Inspectivo_Linea_Empaque_Otros)
		{
			BDAT_Control_Inspectivo_Linea_Empaque_Otros loBDAT_Control_Inspectivo_Linea_Empaque_Otros=new BDAT_Control_Inspectivo_Linea_Empaque_Otros();
			return loBDAT_Control_Inspectivo_Linea_Empaque_Otros.fnUpdT_Control_Inspectivo_Linea_Empaque_Otros(poBOT_Control_Inspectivo_Linea_Empaque_Otros);
		}

		public Boolean fnInsUpdT_Control_Inspectivo_Linea_Empaque_Otros(BOT_Control_Inspectivo_Linea_Empaque_Otros poBOT_Control_Inspectivo_Linea_Empaque_Otros)
		{
			BDAT_Control_Inspectivo_Linea_Empaque_Otros loBDAT_Control_Inspectivo_Linea_Empaque_Otros=new BDAT_Control_Inspectivo_Linea_Empaque_Otros();
			return loBDAT_Control_Inspectivo_Linea_Empaque_Otros.fnInsUpdT_Control_Inspectivo_Linea_Empaque_Otros(poBOT_Control_Inspectivo_Linea_Empaque_Otros);
		}
		public Boolean fnDelT_Control_Inspectivo_Linea_Empaque_Otros(String psCodigo_Control_Inspectivo_Linea_Empaque_Otros)
		{
			BDAT_Control_Inspectivo_Linea_Empaque_Otros loBDAT_Control_Inspectivo_Linea_Empaque_Otros=new BDAT_Control_Inspectivo_Linea_Empaque_Otros();
			
			return loBDAT_Control_Inspectivo_Linea_Empaque_Otros.fnDelT_Control_Inspectivo_Linea_Empaque_Otros(psCodigo_Control_Inspectivo_Linea_Empaque_Otros);
		}

		public List<BOT_Control_Inspectivo_Linea_Empaque_Otros> fnSelT_Control_Inspectivo_Linea_Empaque_OtrosAll()
		{
			BDAT_Control_Inspectivo_Linea_Empaque_Otros loBDAT_Control_Inspectivo_Linea_Empaque_Otros=new BDAT_Control_Inspectivo_Linea_Empaque_Otros();
			return loBDAT_Control_Inspectivo_Linea_Empaque_Otros.fnSelT_Control_Inspectivo_Linea_Empaque_OtrosAll();
		}

		public BOT_Control_Inspectivo_Linea_Empaque_Otros fnSelT_Control_Inspectivo_Linea_Empaque_Otros(String psCodigo_Control_Inspectivo_Linea_Empaque_Otros)
		{
			BDAT_Control_Inspectivo_Linea_Empaque_Otros loBDAT_Control_Inspectivo_Linea_Empaque_Otros=new BDAT_Control_Inspectivo_Linea_Empaque_Otros();
			return loBDAT_Control_Inspectivo_Linea_Empaque_Otros.fnSelT_Control_Inspectivo_Linea_Empaque_Otros(psCodigo_Control_Inspectivo_Linea_Empaque_Otros);
		}
		public List<BOT_Control_Inspectivo_Linea_Empaque_Otros> fnSelT_Control_Inspectivo_Linea_Empaque_OtrosDin(string psWhere,string psOrder)
		{
			BDAT_Control_Inspectivo_Linea_Empaque_Otros loBDAT_Control_Inspectivo_Linea_Empaque_Otros=new BDAT_Control_Inspectivo_Linea_Empaque_Otros();
			return loBDAT_Control_Inspectivo_Linea_Empaque_Otros.fnSelT_Control_Inspectivo_Linea_Empaque_OtrosDin(psWhere,psOrder);

		}
		public Int32[] fnSelT_Control_Inspectivo_Linea_Empaque_OtrosMinMax()
        {
            BDAT_Control_Inspectivo_Linea_Empaque_Otros loBDAT_Control_Inspectivo_Linea_Empaque_Otros = new BDAT_Control_Inspectivo_Linea_Empaque_Otros();
            return loBDAT_Control_Inspectivo_Linea_Empaque_Otros.fnSelT_Control_Inspectivo_Linea_Empaque_OtrosMinMax();
        }


	}
}
