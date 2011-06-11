using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BO_SISACO;
using BDA_SISACO;

namespace BL_SISACO
{
	public partial class BLT_Control_Inspectivo_Linea_Empaque:BLBase
	{
		public Boolean fnInsT_Control_Inspectivo_Linea_Empaque(BOT_Control_Inspectivo_Linea_Empaque poBOT_Control_Inspectivo_Linea_Empaque)
		{
			BDAT_Control_Inspectivo_Linea_Empaque loBDAT_Control_Inspectivo_Linea_Empaque=new BDAT_Control_Inspectivo_Linea_Empaque();
			return loBDAT_Control_Inspectivo_Linea_Empaque.fnInsT_Control_Inspectivo_Linea_Empaque(poBOT_Control_Inspectivo_Linea_Empaque);
		}
		public Boolean fnUpdT_Control_Inspectivo_Linea_Empaque(BOT_Control_Inspectivo_Linea_Empaque poBOT_Control_Inspectivo_Linea_Empaque)
		{
			BDAT_Control_Inspectivo_Linea_Empaque loBDAT_Control_Inspectivo_Linea_Empaque=new BDAT_Control_Inspectivo_Linea_Empaque();
			return loBDAT_Control_Inspectivo_Linea_Empaque.fnUpdT_Control_Inspectivo_Linea_Empaque(poBOT_Control_Inspectivo_Linea_Empaque);
		}

		public Boolean fnInsUpdT_Control_Inspectivo_Linea_Empaque(BOT_Control_Inspectivo_Linea_Empaque poBOT_Control_Inspectivo_Linea_Empaque)
		{
			BDAT_Control_Inspectivo_Linea_Empaque loBDAT_Control_Inspectivo_Linea_Empaque=new BDAT_Control_Inspectivo_Linea_Empaque();
			return loBDAT_Control_Inspectivo_Linea_Empaque.fnInsUpdT_Control_Inspectivo_Linea_Empaque(poBOT_Control_Inspectivo_Linea_Empaque);
		}
		public Boolean fnDelT_Control_Inspectivo_Linea_Empaque(String psCodigo_Control_Inspectivo_Linea_Empaque)
		{
			BDAT_Control_Inspectivo_Linea_Empaque loBDAT_Control_Inspectivo_Linea_Empaque=new BDAT_Control_Inspectivo_Linea_Empaque();
			
			return loBDAT_Control_Inspectivo_Linea_Empaque.fnDelT_Control_Inspectivo_Linea_Empaque(psCodigo_Control_Inspectivo_Linea_Empaque);
		}

		public List<BOT_Control_Inspectivo_Linea_Empaque> fnSelT_Control_Inspectivo_Linea_EmpaqueAll()
		{
			BDAT_Control_Inspectivo_Linea_Empaque loBDAT_Control_Inspectivo_Linea_Empaque=new BDAT_Control_Inspectivo_Linea_Empaque();
			return loBDAT_Control_Inspectivo_Linea_Empaque.fnSelT_Control_Inspectivo_Linea_EmpaqueAll();
		}

		public BOT_Control_Inspectivo_Linea_Empaque fnSelT_Control_Inspectivo_Linea_Empaque(String psCodigo_Control_Inspectivo_Linea_Empaque)
		{
			BDAT_Control_Inspectivo_Linea_Empaque loBDAT_Control_Inspectivo_Linea_Empaque=new BDAT_Control_Inspectivo_Linea_Empaque();
			return loBDAT_Control_Inspectivo_Linea_Empaque.fnSelT_Control_Inspectivo_Linea_Empaque(psCodigo_Control_Inspectivo_Linea_Empaque);
		}
		public List<BOT_Control_Inspectivo_Linea_Empaque> fnSelT_Control_Inspectivo_Linea_EmpaqueDin(string psWhere,string psOrder)
		{
			BDAT_Control_Inspectivo_Linea_Empaque loBDAT_Control_Inspectivo_Linea_Empaque=new BDAT_Control_Inspectivo_Linea_Empaque();
			return loBDAT_Control_Inspectivo_Linea_Empaque.fnSelT_Control_Inspectivo_Linea_EmpaqueDin(psWhere,psOrder);

		}
		public Int32[] fnSelT_Control_Inspectivo_Linea_EmpaqueMinMax()
        {
            BDAT_Control_Inspectivo_Linea_Empaque loBDAT_Control_Inspectivo_Linea_Empaque = new BDAT_Control_Inspectivo_Linea_Empaque();
            return loBDAT_Control_Inspectivo_Linea_Empaque.fnSelT_Control_Inspectivo_Linea_EmpaqueMinMax();
        }


	}
}
