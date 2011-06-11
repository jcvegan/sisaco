using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BO_SISACO;
using BDA_SISACO;

namespace BL_SISACO
{
	public partial class BLT_Registro_Entrega:BLBase
	{
		public Boolean fnInsT_Registro_Entrega(BOT_Registro_Entrega poBOT_Registro_Entrega)
		{
			BDAT_Registro_Entrega loBDAT_Registro_Entrega=new BDAT_Registro_Entrega();
			return loBDAT_Registro_Entrega.fnInsT_Registro_Entrega(poBOT_Registro_Entrega);
		}
		public Boolean fnUpdT_Registro_Entrega(BOT_Registro_Entrega poBOT_Registro_Entrega)
		{
			BDAT_Registro_Entrega loBDAT_Registro_Entrega=new BDAT_Registro_Entrega();
			return loBDAT_Registro_Entrega.fnUpdT_Registro_Entrega(poBOT_Registro_Entrega);
		}

		public Boolean fnInsUpdT_Registro_Entrega(BOT_Registro_Entrega poBOT_Registro_Entrega)
		{
			BDAT_Registro_Entrega loBDAT_Registro_Entrega=new BDAT_Registro_Entrega();
			return loBDAT_Registro_Entrega.fnInsUpdT_Registro_Entrega(poBOT_Registro_Entrega);
		}
		public Boolean fnDelT_Registro_Entrega(String psCodigo_Registro_Entrega)
		{
			BDAT_Registro_Entrega loBDAT_Registro_Entrega=new BDAT_Registro_Entrega();
			
			return loBDAT_Registro_Entrega.fnDelT_Registro_Entrega(psCodigo_Registro_Entrega);
		}

		public List<BOT_Registro_Entrega> fnSelT_Registro_EntregaAll()
		{
			BDAT_Registro_Entrega loBDAT_Registro_Entrega=new BDAT_Registro_Entrega();
			return loBDAT_Registro_Entrega.fnSelT_Registro_EntregaAll();
		}

		public BOT_Registro_Entrega fnSelT_Registro_Entrega(String psCodigo_Registro_Entrega)
		{
			BDAT_Registro_Entrega loBDAT_Registro_Entrega=new BDAT_Registro_Entrega();
			return loBDAT_Registro_Entrega.fnSelT_Registro_Entrega(psCodigo_Registro_Entrega);
		}
		public List<BOT_Registro_Entrega> fnSelT_Registro_EntregaDin(string psWhere,string psOrder)
		{
			BDAT_Registro_Entrega loBDAT_Registro_Entrega=new BDAT_Registro_Entrega();
			return loBDAT_Registro_Entrega.fnSelT_Registro_EntregaDin(psWhere,psOrder);

		}
		public Int32[] fnSelT_Registro_EntregaMinMax()
        {
            BDAT_Registro_Entrega loBDAT_Registro_Entrega = new BDAT_Registro_Entrega();
            return loBDAT_Registro_Entrega.fnSelT_Registro_EntregaMinMax();
        }


	}
}
