using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BO_SISACO;
using BDA_SISACO;

namespace BL_SISACO
{
	public partial class BLT_Control_Inspectivo_Linea_Empaque_Caja:BLBase
	{
		public Boolean fnInsT_Control_Inspectivo_Linea_Empaque_Caja(BOT_Control_Inspectivo_Linea_Empaque_Caja poBOT_Control_Inspectivo_Linea_Empaque_Caja)
		{
			BDAT_Control_Inspectivo_Linea_Empaque_Caja loBDAT_Control_Inspectivo_Linea_Empaque_Caja=new BDAT_Control_Inspectivo_Linea_Empaque_Caja();
			return loBDAT_Control_Inspectivo_Linea_Empaque_Caja.fnInsT_Control_Inspectivo_Linea_Empaque_Caja(poBOT_Control_Inspectivo_Linea_Empaque_Caja);
		}
		public Boolean fnUpdT_Control_Inspectivo_Linea_Empaque_Caja(BOT_Control_Inspectivo_Linea_Empaque_Caja poBOT_Control_Inspectivo_Linea_Empaque_Caja)
		{
			BDAT_Control_Inspectivo_Linea_Empaque_Caja loBDAT_Control_Inspectivo_Linea_Empaque_Caja=new BDAT_Control_Inspectivo_Linea_Empaque_Caja();
			return loBDAT_Control_Inspectivo_Linea_Empaque_Caja.fnUpdT_Control_Inspectivo_Linea_Empaque_Caja(poBOT_Control_Inspectivo_Linea_Empaque_Caja);
		}

		public Boolean fnInsUpdT_Control_Inspectivo_Linea_Empaque_Caja(BOT_Control_Inspectivo_Linea_Empaque_Caja poBOT_Control_Inspectivo_Linea_Empaque_Caja)
		{
			BDAT_Control_Inspectivo_Linea_Empaque_Caja loBDAT_Control_Inspectivo_Linea_Empaque_Caja=new BDAT_Control_Inspectivo_Linea_Empaque_Caja();
			return loBDAT_Control_Inspectivo_Linea_Empaque_Caja.fnInsUpdT_Control_Inspectivo_Linea_Empaque_Caja(poBOT_Control_Inspectivo_Linea_Empaque_Caja);
		}
		public Boolean fnDelT_Control_Inspectivo_Linea_Empaque_Caja(String psCodigo_Control_Inspectivo_Linea_Empaque_Caja)
		{
			BDAT_Control_Inspectivo_Linea_Empaque_Caja loBDAT_Control_Inspectivo_Linea_Empaque_Caja=new BDAT_Control_Inspectivo_Linea_Empaque_Caja();
			
			return loBDAT_Control_Inspectivo_Linea_Empaque_Caja.fnDelT_Control_Inspectivo_Linea_Empaque_Caja(psCodigo_Control_Inspectivo_Linea_Empaque_Caja);
		}

		public List<BOT_Control_Inspectivo_Linea_Empaque_Caja> fnSelT_Control_Inspectivo_Linea_Empaque_CajaAll()
		{
			BDAT_Control_Inspectivo_Linea_Empaque_Caja loBDAT_Control_Inspectivo_Linea_Empaque_Caja=new BDAT_Control_Inspectivo_Linea_Empaque_Caja();
			return loBDAT_Control_Inspectivo_Linea_Empaque_Caja.fnSelT_Control_Inspectivo_Linea_Empaque_CajaAll();
		}

		public BOT_Control_Inspectivo_Linea_Empaque_Caja fnSelT_Control_Inspectivo_Linea_Empaque_Caja(String psCodigo_Control_Inspectivo_Linea_Empaque_Caja)
		{
			BDAT_Control_Inspectivo_Linea_Empaque_Caja loBDAT_Control_Inspectivo_Linea_Empaque_Caja=new BDAT_Control_Inspectivo_Linea_Empaque_Caja();
			return loBDAT_Control_Inspectivo_Linea_Empaque_Caja.fnSelT_Control_Inspectivo_Linea_Empaque_Caja(psCodigo_Control_Inspectivo_Linea_Empaque_Caja);
		}
		public List<BOT_Control_Inspectivo_Linea_Empaque_Caja> fnSelT_Control_Inspectivo_Linea_Empaque_CajaDin(string psWhere,string psOrder)
		{
			BDAT_Control_Inspectivo_Linea_Empaque_Caja loBDAT_Control_Inspectivo_Linea_Empaque_Caja=new BDAT_Control_Inspectivo_Linea_Empaque_Caja();
			return loBDAT_Control_Inspectivo_Linea_Empaque_Caja.fnSelT_Control_Inspectivo_Linea_Empaque_CajaDin(psWhere,psOrder);

		}
		public Int32[] fnSelT_Control_Inspectivo_Linea_Empaque_CajaMinMax()
        {
            BDAT_Control_Inspectivo_Linea_Empaque_Caja loBDAT_Control_Inspectivo_Linea_Empaque_Caja = new BDAT_Control_Inspectivo_Linea_Empaque_Caja();
            return loBDAT_Control_Inspectivo_Linea_Empaque_Caja.fnSelT_Control_Inspectivo_Linea_Empaque_CajaMinMax();
        }


	}
}
