using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BO_SISACO;
using BDA_SISACO;

namespace BL_SISACO
{
	public partial class BLT_Material_Empaque:BLBase
	{
		public Boolean fnInsT_Material_Empaque(BOT_Material_Empaque poBOT_Material_Empaque)
		{
			BDAT_Material_Empaque loBDAT_Material_Empaque=new BDAT_Material_Empaque();
			return loBDAT_Material_Empaque.fnInsT_Material_Empaque(poBOT_Material_Empaque);
		}
		public Boolean fnUpdT_Material_Empaque(BOT_Material_Empaque poBOT_Material_Empaque)
		{
			BDAT_Material_Empaque loBDAT_Material_Empaque=new BDAT_Material_Empaque();
			return loBDAT_Material_Empaque.fnUpdT_Material_Empaque(poBOT_Material_Empaque);
		}

		public Boolean fnInsUpdT_Material_Empaque(BOT_Material_Empaque poBOT_Material_Empaque)
		{
			BDAT_Material_Empaque loBDAT_Material_Empaque=new BDAT_Material_Empaque();
			return loBDAT_Material_Empaque.fnInsUpdT_Material_Empaque(poBOT_Material_Empaque);
		}
		public Boolean fnDelT_Material_Empaque(String psCodigo_Material_Empaque)
		{
			BDAT_Material_Empaque loBDAT_Material_Empaque=new BDAT_Material_Empaque();
			
			return loBDAT_Material_Empaque.fnDelT_Material_Empaque(psCodigo_Material_Empaque);
		}

		public List<BOT_Material_Empaque> fnSelT_Material_EmpaqueAll()
		{
			BDAT_Material_Empaque loBDAT_Material_Empaque=new BDAT_Material_Empaque();
			return loBDAT_Material_Empaque.fnSelT_Material_EmpaqueAll();
		}

		public BOT_Material_Empaque fnSelT_Material_Empaque(String psCodigo_Material_Empaque)
		{
			BDAT_Material_Empaque loBDAT_Material_Empaque=new BDAT_Material_Empaque();
			return loBDAT_Material_Empaque.fnSelT_Material_Empaque(psCodigo_Material_Empaque);
		}
		public List<BOT_Material_Empaque> fnSelT_Material_EmpaqueDin(string psWhere,string psOrder)
		{
			BDAT_Material_Empaque loBDAT_Material_Empaque=new BDAT_Material_Empaque();
			return loBDAT_Material_Empaque.fnSelT_Material_EmpaqueDin(psWhere,psOrder);

		}
		public Int32[] fnSelT_Material_EmpaqueMinMax()
        {
            BDAT_Material_Empaque loBDAT_Material_Empaque = new BDAT_Material_Empaque();
            return loBDAT_Material_Empaque.fnSelT_Material_EmpaqueMinMax();
        }

        public string fnSelT_Material_EmpaqueCodigo()
        {
            BDAT_Material_Empaque loBDAT_Material_Empque = new BDAT_Material_Empaque();
            return loBDAT_Material_Empque.fnSelT_Material_EmpaqueCodigo();
        }

	}
}
