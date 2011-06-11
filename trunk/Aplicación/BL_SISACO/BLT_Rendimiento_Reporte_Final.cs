using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BO_SISACO;
using BDA_SISACO;

namespace BL_SISACO
{
	public partial class BLT_Rendimiento_Reporte_Final:BLBase
	{
		public Boolean fnInsT_Rendimiento_Reporte_Final(BOT_Rendimiento_Reporte_Final poBOT_Rendimiento_Reporte_Final)
		{
			BDAT_Rendimiento_Reporte_Final loBDAT_Rendimiento_Reporte_Final=new BDAT_Rendimiento_Reporte_Final();
			return loBDAT_Rendimiento_Reporte_Final.fnInsT_Rendimiento_Reporte_Final(poBOT_Rendimiento_Reporte_Final);
		}
		public Boolean fnUpdT_Rendimiento_Reporte_Final(BOT_Rendimiento_Reporte_Final poBOT_Rendimiento_Reporte_Final)
		{
			BDAT_Rendimiento_Reporte_Final loBDAT_Rendimiento_Reporte_Final=new BDAT_Rendimiento_Reporte_Final();
			return loBDAT_Rendimiento_Reporte_Final.fnUpdT_Rendimiento_Reporte_Final(poBOT_Rendimiento_Reporte_Final);
		}

		public Boolean fnInsUpdT_Rendimiento_Reporte_Final(BOT_Rendimiento_Reporte_Final poBOT_Rendimiento_Reporte_Final)
		{
			BDAT_Rendimiento_Reporte_Final loBDAT_Rendimiento_Reporte_Final=new BDAT_Rendimiento_Reporte_Final();
			return loBDAT_Rendimiento_Reporte_Final.fnInsUpdT_Rendimiento_Reporte_Final(poBOT_Rendimiento_Reporte_Final);
		}
		public Boolean fnDelT_Rendimiento_Reporte_Final(String psCodigo_Rendimiento_Reporte_Final)
		{
			BDAT_Rendimiento_Reporte_Final loBDAT_Rendimiento_Reporte_Final=new BDAT_Rendimiento_Reporte_Final();
			
			return loBDAT_Rendimiento_Reporte_Final.fnDelT_Rendimiento_Reporte_Final(psCodigo_Rendimiento_Reporte_Final);
		}

		public List<BOT_Rendimiento_Reporte_Final> fnSelT_Rendimiento_Reporte_FinalAll()
		{
			BDAT_Rendimiento_Reporte_Final loBDAT_Rendimiento_Reporte_Final=new BDAT_Rendimiento_Reporte_Final();
			return loBDAT_Rendimiento_Reporte_Final.fnSelT_Rendimiento_Reporte_FinalAll();
		}

		public BOT_Rendimiento_Reporte_Final fnSelT_Rendimiento_Reporte_Final(String psCodigo_Rendimiento_Reporte_Final)
		{
			BDAT_Rendimiento_Reporte_Final loBDAT_Rendimiento_Reporte_Final=new BDAT_Rendimiento_Reporte_Final();
			return loBDAT_Rendimiento_Reporte_Final.fnSelT_Rendimiento_Reporte_Final(psCodigo_Rendimiento_Reporte_Final);
		}
		public List<BOT_Rendimiento_Reporte_Final> fnSelT_Rendimiento_Reporte_FinalDin(string psWhere,string psOrder)
		{
			BDAT_Rendimiento_Reporte_Final loBDAT_Rendimiento_Reporte_Final=new BDAT_Rendimiento_Reporte_Final();
			return loBDAT_Rendimiento_Reporte_Final.fnSelT_Rendimiento_Reporte_FinalDin(psWhere,psOrder);

		}
		public Int32[] fnSelT_Rendimiento_Reporte_FinalMinMax()
        {
            BDAT_Rendimiento_Reporte_Final loBDAT_Rendimiento_Reporte_Final = new BDAT_Rendimiento_Reporte_Final();
            return loBDAT_Rendimiento_Reporte_Final.fnSelT_Rendimiento_Reporte_FinalMinMax();
        }


	}
}
