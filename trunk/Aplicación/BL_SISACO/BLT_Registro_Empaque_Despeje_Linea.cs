using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BO_SISACO;
using BDA_SISACO;

namespace BL_SISACO
{
	public partial class BLT_Registro_Empaque_Despeje_Linea:BLBase
	{
		public Boolean fnInsT_Registro_Empaque_Despeje_Linea(BOT_Registro_Empaque_Despeje_Linea poBOT_Registro_Empaque_Despeje_Linea)
		{
			BDAT_Registro_Empaque_Despeje_Linea loBDAT_Registro_Empaque_Despeje_Linea=new BDAT_Registro_Empaque_Despeje_Linea();
			return loBDAT_Registro_Empaque_Despeje_Linea.fnInsT_Registro_Empaque_Despeje_Linea(poBOT_Registro_Empaque_Despeje_Linea);
		}
		public Boolean fnUpdT_Registro_Empaque_Despeje_Linea(BOT_Registro_Empaque_Despeje_Linea poBOT_Registro_Empaque_Despeje_Linea)
		{
			BDAT_Registro_Empaque_Despeje_Linea loBDAT_Registro_Empaque_Despeje_Linea=new BDAT_Registro_Empaque_Despeje_Linea();
			return loBDAT_Registro_Empaque_Despeje_Linea.fnUpdT_Registro_Empaque_Despeje_Linea(poBOT_Registro_Empaque_Despeje_Linea);
		}

		public Boolean fnInsUpdT_Registro_Empaque_Despeje_Linea(BOT_Registro_Empaque_Despeje_Linea poBOT_Registro_Empaque_Despeje_Linea)
		{
			BDAT_Registro_Empaque_Despeje_Linea loBDAT_Registro_Empaque_Despeje_Linea=new BDAT_Registro_Empaque_Despeje_Linea();
			return loBDAT_Registro_Empaque_Despeje_Linea.fnInsUpdT_Registro_Empaque_Despeje_Linea(poBOT_Registro_Empaque_Despeje_Linea);
		}
		public Boolean fnDelT_Registro_Empaque_Despeje_Linea(String psCodigo_Registro_Empaque_Despeje_Linea)
		{
			BDAT_Registro_Empaque_Despeje_Linea loBDAT_Registro_Empaque_Despeje_Linea=new BDAT_Registro_Empaque_Despeje_Linea();
			
			return loBDAT_Registro_Empaque_Despeje_Linea.fnDelT_Registro_Empaque_Despeje_Linea(psCodigo_Registro_Empaque_Despeje_Linea);
		}

		public List<BOT_Registro_Empaque_Despeje_Linea> fnSelT_Registro_Empaque_Despeje_LineaAll()
		{
			BDAT_Registro_Empaque_Despeje_Linea loBDAT_Registro_Empaque_Despeje_Linea=new BDAT_Registro_Empaque_Despeje_Linea();
			return loBDAT_Registro_Empaque_Despeje_Linea.fnSelT_Registro_Empaque_Despeje_LineaAll();
		}

		public BOT_Registro_Empaque_Despeje_Linea fnSelT_Registro_Empaque_Despeje_Linea(String psCodigo_Registro_Empaque_Despeje_Linea)
		{
			BDAT_Registro_Empaque_Despeje_Linea loBDAT_Registro_Empaque_Despeje_Linea=new BDAT_Registro_Empaque_Despeje_Linea();
			return loBDAT_Registro_Empaque_Despeje_Linea.fnSelT_Registro_Empaque_Despeje_Linea(psCodigo_Registro_Empaque_Despeje_Linea);
		}
		public List<BOT_Registro_Empaque_Despeje_Linea> fnSelT_Registro_Empaque_Despeje_LineaDin(string psWhere,string psOrder)
		{
			BDAT_Registro_Empaque_Despeje_Linea loBDAT_Registro_Empaque_Despeje_Linea=new BDAT_Registro_Empaque_Despeje_Linea();
			return loBDAT_Registro_Empaque_Despeje_Linea.fnSelT_Registro_Empaque_Despeje_LineaDin(psWhere,psOrder);

		}
		public Int32[] fnSelT_Registro_Empaque_Despeje_LineaMinMax()
        {
            BDAT_Registro_Empaque_Despeje_Linea loBDAT_Registro_Empaque_Despeje_Linea = new BDAT_Registro_Empaque_Despeje_Linea();
            return loBDAT_Registro_Empaque_Despeje_Linea.fnSelT_Registro_Empaque_Despeje_LineaMinMax();
        }


	}
}
