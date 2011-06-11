using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BO_SISACO;
using BDA_SISACO;

namespace BL_SISACO
{
	public partial class BLT_Adicional:BLBase
	{
		public Boolean fnInsT_Adicional(BOT_Adicional poBOT_Adicional,out string codigo_adicional)
		{
			BDAT_Adicional loBDAT_Adicional=new BDAT_Adicional();
			return loBDAT_Adicional.fnInsT_Adicional(poBOT_Adicional, out codigo_adicional);
		}
		public Boolean fnUpdT_Adicional(BOT_Adicional poBOT_Adicional)
		{
			BDAT_Adicional loBDAT_Adicional=new BDAT_Adicional();
			return loBDAT_Adicional.fnUpdT_Adicional(poBOT_Adicional);
		}

		public Boolean fnInsUpdT_Adicional(BOT_Adicional poBOT_Adicional)
		{
			BDAT_Adicional loBDAT_Adicional=new BDAT_Adicional();
			return loBDAT_Adicional.fnInsUpdT_Adicional(poBOT_Adicional);
		}
		public Boolean fnDelT_Adicional(String psCodigo_Adicional)
		{
			BDAT_Adicional loBDAT_Adicional=new BDAT_Adicional();
			
			return loBDAT_Adicional.fnDelT_Adicional(psCodigo_Adicional);
		}

		public List<BOT_Adicional> fnSelT_AdicionalAll()
		{
			BDAT_Adicional loBDAT_Adicional=new BDAT_Adicional();
			return loBDAT_Adicional.fnSelT_AdicionalAll();
		}

		public BOT_Adicional fnSelT_Adicional(String psCodigo_Adicional)
		{
			BDAT_Adicional loBDAT_Adicional=new BDAT_Adicional();
			return loBDAT_Adicional.fnSelT_Adicional(psCodigo_Adicional);
		}
		public List<BOT_Adicional> fnSelT_AdicionalDin(string psWhere,string psOrder)
		{
			BDAT_Adicional loBDAT_Adicional=new BDAT_Adicional();
			return loBDAT_Adicional.fnSelT_AdicionalDin(psWhere,psOrder);

		}
		public Int32[] fnSelT_AdicionalMinMax()
        {
            BDAT_Adicional loBDAT_Adicional = new BDAT_Adicional();
            return loBDAT_Adicional.fnSelT_AdicionalMinMax();
        }


	}
}
