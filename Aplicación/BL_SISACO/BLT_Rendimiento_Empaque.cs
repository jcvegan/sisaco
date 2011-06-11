using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BO_SISACO;
using BDA_SISACO;

namespace BL_SISACO
{
	public partial class BLT_Rendimiento_Empaque:BLBase
	{
		public Boolean fnInsT_Rendimiento_Empaque(BOT_Rendimiento_Empaque poBOT_Rendimiento_Empaque)
		{
			BDAT_Rendimiento_Empaque loBDAT_Rendimiento_Empaque=new BDAT_Rendimiento_Empaque();
			return loBDAT_Rendimiento_Empaque.fnInsT_Rendimiento_Empaque(poBOT_Rendimiento_Empaque);
		}
		public Boolean fnUpdT_Rendimiento_Empaque(BOT_Rendimiento_Empaque poBOT_Rendimiento_Empaque)
		{
			BDAT_Rendimiento_Empaque loBDAT_Rendimiento_Empaque=new BDAT_Rendimiento_Empaque();
			return loBDAT_Rendimiento_Empaque.fnUpdT_Rendimiento_Empaque(poBOT_Rendimiento_Empaque);
		}

		public Boolean fnInsUpdT_Rendimiento_Empaque(BOT_Rendimiento_Empaque poBOT_Rendimiento_Empaque)
		{
			BDAT_Rendimiento_Empaque loBDAT_Rendimiento_Empaque=new BDAT_Rendimiento_Empaque();
			return loBDAT_Rendimiento_Empaque.fnInsUpdT_Rendimiento_Empaque(poBOT_Rendimiento_Empaque);
		}
		public Boolean fnDelT_Rendimiento_Empaque(String psCodigo_Rendimiento_Empaque)
		{
			BDAT_Rendimiento_Empaque loBDAT_Rendimiento_Empaque=new BDAT_Rendimiento_Empaque();
			
			return loBDAT_Rendimiento_Empaque.fnDelT_Rendimiento_Empaque(psCodigo_Rendimiento_Empaque);
		}

		public List<BOT_Rendimiento_Empaque> fnSelT_Rendimiento_EmpaqueAll()
		{
			BDAT_Rendimiento_Empaque loBDAT_Rendimiento_Empaque=new BDAT_Rendimiento_Empaque();
			return loBDAT_Rendimiento_Empaque.fnSelT_Rendimiento_EmpaqueAll();
		}

		public BOT_Rendimiento_Empaque fnSelT_Rendimiento_Empaque(String psCodigo_Rendimiento_Empaque)
		{
			BDAT_Rendimiento_Empaque loBDAT_Rendimiento_Empaque=new BDAT_Rendimiento_Empaque();
			return loBDAT_Rendimiento_Empaque.fnSelT_Rendimiento_Empaque(psCodigo_Rendimiento_Empaque);
		}
		public List<BOT_Rendimiento_Empaque> fnSelT_Rendimiento_EmpaqueDin(string psWhere,string psOrder)
		{
			BDAT_Rendimiento_Empaque loBDAT_Rendimiento_Empaque=new BDAT_Rendimiento_Empaque();
			return loBDAT_Rendimiento_Empaque.fnSelT_Rendimiento_EmpaqueDin(psWhere,psOrder);

		}
		public Int32[] fnSelT_Rendimiento_EmpaqueMinMax()
        {
            BDAT_Rendimiento_Empaque loBDAT_Rendimiento_Empaque = new BDAT_Rendimiento_Empaque();
            return loBDAT_Rendimiento_Empaque.fnSelT_Rendimiento_EmpaqueMinMax();
        }


	}
}
