using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BO_SISACO;
using BDA_SISACO;

namespace BL_SISACO
{
	public partial class BLT_Control_Inspectivo_Linea_Empaque_Embalaje:BLBase
	{
		public Boolean fnInsT_Control_Inspectivo_Linea_Empaque_Embalaje(BOT_Control_Inspectivo_Linea_Empaque_Embalaje poBOT_Control_Inspectivo_Linea_Empaque_Embalaje)
		{
			BDAT_Control_Inspectivo_Linea_Empaque_Embalaje loBDAT_Control_Inspectivo_Linea_Empaque_Embalaje=new BDAT_Control_Inspectivo_Linea_Empaque_Embalaje();
			return loBDAT_Control_Inspectivo_Linea_Empaque_Embalaje.fnInsT_Control_Inspectivo_Linea_Empaque_Embalaje(poBOT_Control_Inspectivo_Linea_Empaque_Embalaje);
		}
		public Boolean fnUpdT_Control_Inspectivo_Linea_Empaque_Embalaje(BOT_Control_Inspectivo_Linea_Empaque_Embalaje poBOT_Control_Inspectivo_Linea_Empaque_Embalaje)
		{
			BDAT_Control_Inspectivo_Linea_Empaque_Embalaje loBDAT_Control_Inspectivo_Linea_Empaque_Embalaje=new BDAT_Control_Inspectivo_Linea_Empaque_Embalaje();
			return loBDAT_Control_Inspectivo_Linea_Empaque_Embalaje.fnUpdT_Control_Inspectivo_Linea_Empaque_Embalaje(poBOT_Control_Inspectivo_Linea_Empaque_Embalaje);
		}

		public Boolean fnInsUpdT_Control_Inspectivo_Linea_Empaque_Embalaje(BOT_Control_Inspectivo_Linea_Empaque_Embalaje poBOT_Control_Inspectivo_Linea_Empaque_Embalaje)
		{
			BDAT_Control_Inspectivo_Linea_Empaque_Embalaje loBDAT_Control_Inspectivo_Linea_Empaque_Embalaje=new BDAT_Control_Inspectivo_Linea_Empaque_Embalaje();
			return loBDAT_Control_Inspectivo_Linea_Empaque_Embalaje.fnInsUpdT_Control_Inspectivo_Linea_Empaque_Embalaje(poBOT_Control_Inspectivo_Linea_Empaque_Embalaje);
		}
		public Boolean fnDelT_Control_Inspectivo_Linea_Empaque_Embalaje(String psCodigo_Control_Inspectivo_Linea_Empaque_Embalaje)
		{
			BDAT_Control_Inspectivo_Linea_Empaque_Embalaje loBDAT_Control_Inspectivo_Linea_Empaque_Embalaje=new BDAT_Control_Inspectivo_Linea_Empaque_Embalaje();
			
			return loBDAT_Control_Inspectivo_Linea_Empaque_Embalaje.fnDelT_Control_Inspectivo_Linea_Empaque_Embalaje(psCodigo_Control_Inspectivo_Linea_Empaque_Embalaje);
		}

		public List<BOT_Control_Inspectivo_Linea_Empaque_Embalaje> fnSelT_Control_Inspectivo_Linea_Empaque_EmbalajeAll()
		{
			BDAT_Control_Inspectivo_Linea_Empaque_Embalaje loBDAT_Control_Inspectivo_Linea_Empaque_Embalaje=new BDAT_Control_Inspectivo_Linea_Empaque_Embalaje();
			return loBDAT_Control_Inspectivo_Linea_Empaque_Embalaje.fnSelT_Control_Inspectivo_Linea_Empaque_EmbalajeAll();
		}

		public BOT_Control_Inspectivo_Linea_Empaque_Embalaje fnSelT_Control_Inspectivo_Linea_Empaque_Embalaje(String psCodigo_Control_Inspectivo_Linea_Empaque_Embalaje)
		{
			BDAT_Control_Inspectivo_Linea_Empaque_Embalaje loBDAT_Control_Inspectivo_Linea_Empaque_Embalaje=new BDAT_Control_Inspectivo_Linea_Empaque_Embalaje();
			return loBDAT_Control_Inspectivo_Linea_Empaque_Embalaje.fnSelT_Control_Inspectivo_Linea_Empaque_Embalaje(psCodigo_Control_Inspectivo_Linea_Empaque_Embalaje);
		}
		public List<BOT_Control_Inspectivo_Linea_Empaque_Embalaje> fnSelT_Control_Inspectivo_Linea_Empaque_EmbalajeDin(string psWhere,string psOrder)
		{
			BDAT_Control_Inspectivo_Linea_Empaque_Embalaje loBDAT_Control_Inspectivo_Linea_Empaque_Embalaje=new BDAT_Control_Inspectivo_Linea_Empaque_Embalaje();
			return loBDAT_Control_Inspectivo_Linea_Empaque_Embalaje.fnSelT_Control_Inspectivo_Linea_Empaque_EmbalajeDin(psWhere,psOrder);

		}
		public Int32[] fnSelT_Control_Inspectivo_Linea_Empaque_EmbalajeMinMax()
        {
            BDAT_Control_Inspectivo_Linea_Empaque_Embalaje loBDAT_Control_Inspectivo_Linea_Empaque_Embalaje = new BDAT_Control_Inspectivo_Linea_Empaque_Embalaje();
            return loBDAT_Control_Inspectivo_Linea_Empaque_Embalaje.fnSelT_Control_Inspectivo_Linea_Empaque_EmbalajeMinMax();
        }


	}
}
