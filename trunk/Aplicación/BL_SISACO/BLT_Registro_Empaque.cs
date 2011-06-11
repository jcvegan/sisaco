using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BO_SISACO;
using BDA_SISACO;

namespace BL_SISACO
{
	public partial class BLT_Registro_Empaque:BLBase
	{
		public Boolean fnInsT_Registro_Empaque(BOT_Registro_Empaque poBOT_Registro_Empaque)
		{
			BDAT_Registro_Empaque loBDAT_Registro_Empaque=new BDAT_Registro_Empaque();
			return loBDAT_Registro_Empaque.fnInsT_Registro_Empaque(poBOT_Registro_Empaque);
		}
		public Boolean fnUpdT_Registro_Empaque(BOT_Registro_Empaque poBOT_Registro_Empaque)
		{
			BDAT_Registro_Empaque loBDAT_Registro_Empaque=new BDAT_Registro_Empaque();
			return loBDAT_Registro_Empaque.fnUpdT_Registro_Empaque(poBOT_Registro_Empaque);
		}

		public Boolean fnInsUpdT_Registro_Empaque(BOT_Registro_Empaque poBOT_Registro_Empaque)
		{
			BDAT_Registro_Empaque loBDAT_Registro_Empaque=new BDAT_Registro_Empaque();
			return loBDAT_Registro_Empaque.fnInsUpdT_Registro_Empaque(poBOT_Registro_Empaque);
		}
		public Boolean fnDelT_Registro_Empaque(String psCodigo_Registro_Empaque)
		{
			BDAT_Registro_Empaque loBDAT_Registro_Empaque=new BDAT_Registro_Empaque();
			
			return loBDAT_Registro_Empaque.fnDelT_Registro_Empaque(psCodigo_Registro_Empaque);
		}

		public List<BOT_Registro_Empaque> fnSelT_Registro_EmpaqueAll()
		{
			BDAT_Registro_Empaque loBDAT_Registro_Empaque=new BDAT_Registro_Empaque();
			return loBDAT_Registro_Empaque.fnSelT_Registro_EmpaqueAll();
		}

		public BOT_Registro_Empaque fnSelT_Registro_Empaque(String psCodigo_Registro_Empaque)
		{
			BDAT_Registro_Empaque loBDAT_Registro_Empaque=new BDAT_Registro_Empaque();
			return loBDAT_Registro_Empaque.fnSelT_Registro_Empaque(psCodigo_Registro_Empaque);
		}
		public List<BOT_Registro_Empaque> fnSelT_Registro_EmpaqueDin(string psWhere,string psOrder)
		{
			BDAT_Registro_Empaque loBDAT_Registro_Empaque=new BDAT_Registro_Empaque();
			return loBDAT_Registro_Empaque.fnSelT_Registro_EmpaqueDin(psWhere,psOrder);

		}
		public Int32[] fnSelT_Registro_EmpaqueMinMax()
        {
            BDAT_Registro_Empaque loBDAT_Registro_Empaque = new BDAT_Registro_Empaque();
            return loBDAT_Registro_Empaque.fnSelT_Registro_EmpaqueMinMax();
        }


	}
}
