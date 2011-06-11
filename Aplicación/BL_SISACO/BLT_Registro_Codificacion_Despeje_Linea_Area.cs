using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BO_SISACO;
using BDA_SISACO;

namespace BL_SISACO
{
	public partial class BLT_Registro_Codificacion_Despeje_Linea_Area:BLBase
	{
		public Boolean fnInsT_Registro_Codificacion_Despeje_Linea_Area(BOT_Registro_Codificacion_Despeje_Linea_Area poBOT_Registro_Codificacion_Despeje_Linea_Area)
		{
			BDAT_Registro_Codificacion_Despeje_Linea_Area loBDAT_Registro_Codificacion_Despeje_Linea_Area=new BDAT_Registro_Codificacion_Despeje_Linea_Area();
			return loBDAT_Registro_Codificacion_Despeje_Linea_Area.fnInsT_Registro_Codificacion_Despeje_Linea_Area(poBOT_Registro_Codificacion_Despeje_Linea_Area);
		}
		public Boolean fnUpdT_Registro_Codificacion_Despeje_Linea_Area(BOT_Registro_Codificacion_Despeje_Linea_Area poBOT_Registro_Codificacion_Despeje_Linea_Area)
		{
			BDAT_Registro_Codificacion_Despeje_Linea_Area loBDAT_Registro_Codificacion_Despeje_Linea_Area=new BDAT_Registro_Codificacion_Despeje_Linea_Area();
			return loBDAT_Registro_Codificacion_Despeje_Linea_Area.fnUpdT_Registro_Codificacion_Despeje_Linea_Area(poBOT_Registro_Codificacion_Despeje_Linea_Area);
		}

		public Boolean fnInsUpdT_Registro_Codificacion_Despeje_Linea_Area(BOT_Registro_Codificacion_Despeje_Linea_Area poBOT_Registro_Codificacion_Despeje_Linea_Area,out string codigo_registro_codificacion_despeje_linea_area)
		{
			BDAT_Registro_Codificacion_Despeje_Linea_Area loBDAT_Registro_Codificacion_Despeje_Linea_Area=new BDAT_Registro_Codificacion_Despeje_Linea_Area();
			return loBDAT_Registro_Codificacion_Despeje_Linea_Area.fnInsUpdT_Registro_Codificacion_Despeje_Linea_Area(poBOT_Registro_Codificacion_Despeje_Linea_Area,out codigo_registro_codificacion_despeje_linea_area);
		}
		public Boolean fnDelT_Registro_Codificacion_Despeje_Linea_Area(String psCodigo_Registro_Codificacion_Despeje_Linea_Area)
		{
			BDAT_Registro_Codificacion_Despeje_Linea_Area loBDAT_Registro_Codificacion_Despeje_Linea_Area=new BDAT_Registro_Codificacion_Despeje_Linea_Area();
			
			return loBDAT_Registro_Codificacion_Despeje_Linea_Area.fnDelT_Registro_Codificacion_Despeje_Linea_Area(psCodigo_Registro_Codificacion_Despeje_Linea_Area);
		}

		public List<BOT_Registro_Codificacion_Despeje_Linea_Area> fnSelT_Registro_Codificacion_Despeje_Linea_AreaAll()
		{
			BDAT_Registro_Codificacion_Despeje_Linea_Area loBDAT_Registro_Codificacion_Despeje_Linea_Area=new BDAT_Registro_Codificacion_Despeje_Linea_Area();
			return loBDAT_Registro_Codificacion_Despeje_Linea_Area.fnSelT_Registro_Codificacion_Despeje_Linea_AreaAll();
		}

		public BOT_Registro_Codificacion_Despeje_Linea_Area fnSelT_Registro_Codificacion_Despeje_Linea_Area(String psCodigo_Registro_Codificacion_Despeje_Linea_Area)
		{
			BDAT_Registro_Codificacion_Despeje_Linea_Area loBDAT_Registro_Codificacion_Despeje_Linea_Area=new BDAT_Registro_Codificacion_Despeje_Linea_Area();
			return loBDAT_Registro_Codificacion_Despeje_Linea_Area.fnSelT_Registro_Codificacion_Despeje_Linea_Area(psCodigo_Registro_Codificacion_Despeje_Linea_Area);
		}
		public List<BOT_Registro_Codificacion_Despeje_Linea_Area> fnSelT_Registro_Codificacion_Despeje_Linea_AreaDin(string psWhere,string psOrder)
		{
			BDAT_Registro_Codificacion_Despeje_Linea_Area loBDAT_Registro_Codificacion_Despeje_Linea_Area=new BDAT_Registro_Codificacion_Despeje_Linea_Area();
			return loBDAT_Registro_Codificacion_Despeje_Linea_Area.fnSelT_Registro_Codificacion_Despeje_Linea_AreaDin(psWhere,psOrder);

		}
		public Int32[] fnSelT_Registro_Codificacion_Despeje_Linea_AreaMinMax()
        {
            BDAT_Registro_Codificacion_Despeje_Linea_Area loBDAT_Registro_Codificacion_Despeje_Linea_Area = new BDAT_Registro_Codificacion_Despeje_Linea_Area();
            return loBDAT_Registro_Codificacion_Despeje_Linea_Area.fnSelT_Registro_Codificacion_Despeje_Linea_AreaMinMax();
        }


	}
}
