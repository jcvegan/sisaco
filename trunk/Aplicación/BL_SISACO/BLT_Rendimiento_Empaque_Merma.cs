using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BO_SISACO;
using BDA_SISACO;

namespace BL_SISACO
{
	public partial class BLT_Rendimiento_Empaque_Merma:BLBase
	{
		public Boolean fnInsT_Rendimiento_Empaque_Merma(BOT_Rendimiento_Empaque_Merma poBOT_Rendimiento_Empaque_Merma)
		{
			BDAT_Rendimiento_Empaque_Merma loBDAT_Rendimiento_Empaque_Merma=new BDAT_Rendimiento_Empaque_Merma();
			return loBDAT_Rendimiento_Empaque_Merma.fnInsT_Rendimiento_Empaque_Merma(poBOT_Rendimiento_Empaque_Merma);
		}
		public Boolean fnUpdT_Rendimiento_Empaque_Merma(BOT_Rendimiento_Empaque_Merma poBOT_Rendimiento_Empaque_Merma)
		{
			BDAT_Rendimiento_Empaque_Merma loBDAT_Rendimiento_Empaque_Merma=new BDAT_Rendimiento_Empaque_Merma();
			return loBDAT_Rendimiento_Empaque_Merma.fnUpdT_Rendimiento_Empaque_Merma(poBOT_Rendimiento_Empaque_Merma);
		}

		public Boolean fnInsUpdT_Rendimiento_Empaque_Merma(BOT_Rendimiento_Empaque_Merma poBOT_Rendimiento_Empaque_Merma)
		{
			BDAT_Rendimiento_Empaque_Merma loBDAT_Rendimiento_Empaque_Merma=new BDAT_Rendimiento_Empaque_Merma();
			return loBDAT_Rendimiento_Empaque_Merma.fnInsUpdT_Rendimiento_Empaque_Merma(poBOT_Rendimiento_Empaque_Merma);
		}
		public Boolean fnDelT_Rendimiento_Empaque_Merma(String psCodigo_Rendimiento_Empaque_Merma)
		{
			BDAT_Rendimiento_Empaque_Merma loBDAT_Rendimiento_Empaque_Merma=new BDAT_Rendimiento_Empaque_Merma();
			
			return loBDAT_Rendimiento_Empaque_Merma.fnDelT_Rendimiento_Empaque_Merma(psCodigo_Rendimiento_Empaque_Merma);
		}

		public List<BOT_Rendimiento_Empaque_Merma> fnSelT_Rendimiento_Empaque_MermaAll()
		{
			BDAT_Rendimiento_Empaque_Merma loBDAT_Rendimiento_Empaque_Merma=new BDAT_Rendimiento_Empaque_Merma();
			return loBDAT_Rendimiento_Empaque_Merma.fnSelT_Rendimiento_Empaque_MermaAll();
		}

		public BOT_Rendimiento_Empaque_Merma fnSelT_Rendimiento_Empaque_Merma(String psCodigo_Rendimiento_Empaque_Merma)
		{
			BDAT_Rendimiento_Empaque_Merma loBDAT_Rendimiento_Empaque_Merma=new BDAT_Rendimiento_Empaque_Merma();
			return loBDAT_Rendimiento_Empaque_Merma.fnSelT_Rendimiento_Empaque_Merma(psCodigo_Rendimiento_Empaque_Merma);
		}
		public List<BOT_Rendimiento_Empaque_Merma> fnSelT_Rendimiento_Empaque_MermaDin(string psWhere,string psOrder)
		{
			BDAT_Rendimiento_Empaque_Merma loBDAT_Rendimiento_Empaque_Merma=new BDAT_Rendimiento_Empaque_Merma();
			return loBDAT_Rendimiento_Empaque_Merma.fnSelT_Rendimiento_Empaque_MermaDin(psWhere,psOrder);

		}
		public Int32[] fnSelT_Rendimiento_Empaque_MermaMinMax()
        {
            BDAT_Rendimiento_Empaque_Merma loBDAT_Rendimiento_Empaque_Merma = new BDAT_Rendimiento_Empaque_Merma();
            return loBDAT_Rendimiento_Empaque_Merma.fnSelT_Rendimiento_Empaque_MermaMinMax();
        }


	}
}
