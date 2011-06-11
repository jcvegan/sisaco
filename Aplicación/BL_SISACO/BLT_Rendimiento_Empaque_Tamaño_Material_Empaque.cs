using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BO_SISACO;
using BDA_SISACO;

namespace BL_SISACO
{
	public partial class BLT_Rendimiento_Empaque_Tamaño_Material_Empaque:BLBase
	{
		public Boolean fnInsT_Rendimiento_Empaque_Tamaño_Material_Empaque(BOT_Rendimiento_Empaque_Tamaño_Material_Empaque poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque)
		{
			BDAT_Rendimiento_Empaque_Tamaño_Material_Empaque loBDAT_Rendimiento_Empaque_Tamaño_Material_Empaque=new BDAT_Rendimiento_Empaque_Tamaño_Material_Empaque();
			return loBDAT_Rendimiento_Empaque_Tamaño_Material_Empaque.fnInsT_Rendimiento_Empaque_Tamaño_Material_Empaque(poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque);
		}
		public Boolean fnUpdT_Rendimiento_Empaque_Tamaño_Material_Empaque(BOT_Rendimiento_Empaque_Tamaño_Material_Empaque poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque)
		{
			BDAT_Rendimiento_Empaque_Tamaño_Material_Empaque loBDAT_Rendimiento_Empaque_Tamaño_Material_Empaque=new BDAT_Rendimiento_Empaque_Tamaño_Material_Empaque();
			return loBDAT_Rendimiento_Empaque_Tamaño_Material_Empaque.fnUpdT_Rendimiento_Empaque_Tamaño_Material_Empaque(poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque);
		}

		public Boolean fnInsUpdT_Rendimiento_Empaque_Tamaño_Material_Empaque(BOT_Rendimiento_Empaque_Tamaño_Material_Empaque poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque)
		{
			BDAT_Rendimiento_Empaque_Tamaño_Material_Empaque loBDAT_Rendimiento_Empaque_Tamaño_Material_Empaque=new BDAT_Rendimiento_Empaque_Tamaño_Material_Empaque();
			return loBDAT_Rendimiento_Empaque_Tamaño_Material_Empaque.fnInsUpdT_Rendimiento_Empaque_Tamaño_Material_Empaque(poBOT_Rendimiento_Empaque_Tamaño_Material_Empaque);
		}
		public Boolean fnDelT_Rendimiento_Empaque_Tamaño_Material_Empaque(String psCodigo_Rendimiento_Empaque_Tamaño_Empaque)
		{
			BDAT_Rendimiento_Empaque_Tamaño_Material_Empaque loBDAT_Rendimiento_Empaque_Tamaño_Material_Empaque=new BDAT_Rendimiento_Empaque_Tamaño_Material_Empaque();
			
			return loBDAT_Rendimiento_Empaque_Tamaño_Material_Empaque.fnDelT_Rendimiento_Empaque_Tamaño_Material_Empaque(psCodigo_Rendimiento_Empaque_Tamaño_Empaque);
		}

		public List<BOT_Rendimiento_Empaque_Tamaño_Material_Empaque> fnSelT_Rendimiento_Empaque_Tamaño_Material_EmpaqueAll()
		{
			BDAT_Rendimiento_Empaque_Tamaño_Material_Empaque loBDAT_Rendimiento_Empaque_Tamaño_Material_Empaque=new BDAT_Rendimiento_Empaque_Tamaño_Material_Empaque();
			return loBDAT_Rendimiento_Empaque_Tamaño_Material_Empaque.fnSelT_Rendimiento_Empaque_Tamaño_Material_EmpaqueAll();
		}

		public BOT_Rendimiento_Empaque_Tamaño_Material_Empaque fnSelT_Rendimiento_Empaque_Tamaño_Material_Empaque(String psCodigo_Rendimiento_Empaque_Tamaño_Empaque)
		{
			BDAT_Rendimiento_Empaque_Tamaño_Material_Empaque loBDAT_Rendimiento_Empaque_Tamaño_Material_Empaque=new BDAT_Rendimiento_Empaque_Tamaño_Material_Empaque();
			return loBDAT_Rendimiento_Empaque_Tamaño_Material_Empaque.fnSelT_Rendimiento_Empaque_Tamaño_Material_Empaque(psCodigo_Rendimiento_Empaque_Tamaño_Empaque);
		}
		public List<BOT_Rendimiento_Empaque_Tamaño_Material_Empaque> fnSelT_Rendimiento_Empaque_Tamaño_Material_EmpaqueDin(string psWhere,string psOrder)
		{
			BDAT_Rendimiento_Empaque_Tamaño_Material_Empaque loBDAT_Rendimiento_Empaque_Tamaño_Material_Empaque=new BDAT_Rendimiento_Empaque_Tamaño_Material_Empaque();
			return loBDAT_Rendimiento_Empaque_Tamaño_Material_Empaque.fnSelT_Rendimiento_Empaque_Tamaño_Material_EmpaqueDin(psWhere,psOrder);

		}
		public Int32[] fnSelT_Rendimiento_Empaque_Tamaño_Material_EmpaqueMinMax()
        {
            BDAT_Rendimiento_Empaque_Tamaño_Material_Empaque loBDAT_Rendimiento_Empaque_Tamaño_Material_Empaque = new BDAT_Rendimiento_Empaque_Tamaño_Material_Empaque();
            return loBDAT_Rendimiento_Empaque_Tamaño_Material_Empaque.fnSelT_Rendimiento_Empaque_Tamaño_Material_EmpaqueMinMax();
        }


	}
}
