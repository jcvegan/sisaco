using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BO_SISACO;
using BDA_SISACO;

namespace BL_SISACO
{
	public partial class BLT_Registro_Codificacion_Despeje_Linea_Personal:BLBase
	{
		public Boolean fnInsT_Registro_Codificacion_Despeje_Linea_Personal(BOT_Registro_Codificacion_Despeje_Linea_Personal poBOT_Registro_Codificacion_Despeje_Linea_Personal)
		{
			BDAT_Registro_Codificacion_Despeje_Linea_Personal loBDAT_Registro_Codificacion_Despeje_Linea_Personal=new BDAT_Registro_Codificacion_Despeje_Linea_Personal();
			return loBDAT_Registro_Codificacion_Despeje_Linea_Personal.fnInsT_Registro_Codificacion_Despeje_Linea_Personal(poBOT_Registro_Codificacion_Despeje_Linea_Personal);
		}
		public Boolean fnUpdT_Registro_Codificacion_Despeje_Linea_Personal(BOT_Registro_Codificacion_Despeje_Linea_Personal poBOT_Registro_Codificacion_Despeje_Linea_Personal)
		{
			BDAT_Registro_Codificacion_Despeje_Linea_Personal loBDAT_Registro_Codificacion_Despeje_Linea_Personal=new BDAT_Registro_Codificacion_Despeje_Linea_Personal();
			return loBDAT_Registro_Codificacion_Despeje_Linea_Personal.fnUpdT_Registro_Codificacion_Despeje_Linea_Personal(poBOT_Registro_Codificacion_Despeje_Linea_Personal);
		}

        public Boolean fnInsUpdT_Registro_Codificacion_Despeje_Linea_Personal(BOT_Registro_Codificacion_Despeje_Linea_Personal poBOT_Registro_Codificacion_Despeje_Linea_Personal, out string codigo_registro_codificacion_despeje_linea_personal)
		{
			BDAT_Registro_Codificacion_Despeje_Linea_Personal loBDAT_Registro_Codificacion_Despeje_Linea_Personal=new BDAT_Registro_Codificacion_Despeje_Linea_Personal();
            return loBDAT_Registro_Codificacion_Despeje_Linea_Personal.fnInsUpdT_Registro_Codificacion_Despeje_Linea_Personal(poBOT_Registro_Codificacion_Despeje_Linea_Personal, out codigo_registro_codificacion_despeje_linea_personal);
		}
		public Boolean fnDelT_Registro_Codificacion_Despeje_Linea_Personal(String psCodigo_Registro_Codificacion_Despeje_Linea_Personal)
		{
			BDAT_Registro_Codificacion_Despeje_Linea_Personal loBDAT_Registro_Codificacion_Despeje_Linea_Personal=new BDAT_Registro_Codificacion_Despeje_Linea_Personal();
			
			return loBDAT_Registro_Codificacion_Despeje_Linea_Personal.fnDelT_Registro_Codificacion_Despeje_Linea_Personal(psCodigo_Registro_Codificacion_Despeje_Linea_Personal);
		}

		public List<BOT_Registro_Codificacion_Despeje_Linea_Personal> fnSelT_Registro_Codificacion_Despeje_Linea_PersonalAll()
		{
			BDAT_Registro_Codificacion_Despeje_Linea_Personal loBDAT_Registro_Codificacion_Despeje_Linea_Personal=new BDAT_Registro_Codificacion_Despeje_Linea_Personal();
			return loBDAT_Registro_Codificacion_Despeje_Linea_Personal.fnSelT_Registro_Codificacion_Despeje_Linea_PersonalAll();
		}

		public BOT_Registro_Codificacion_Despeje_Linea_Personal fnSelT_Registro_Codificacion_Despeje_Linea_Personal(String psCodigo_Registro_Codificacion_Despeje_Linea_Personal)
		{
			BDAT_Registro_Codificacion_Despeje_Linea_Personal loBDAT_Registro_Codificacion_Despeje_Linea_Personal=new BDAT_Registro_Codificacion_Despeje_Linea_Personal();
			return loBDAT_Registro_Codificacion_Despeje_Linea_Personal.fnSelT_Registro_Codificacion_Despeje_Linea_Personal(psCodigo_Registro_Codificacion_Despeje_Linea_Personal);
		}
		public List<BOT_Registro_Codificacion_Despeje_Linea_Personal> fnSelT_Registro_Codificacion_Despeje_Linea_PersonalDin(string psWhere,string psOrder)
		{
			BDAT_Registro_Codificacion_Despeje_Linea_Personal loBDAT_Registro_Codificacion_Despeje_Linea_Personal=new BDAT_Registro_Codificacion_Despeje_Linea_Personal();
			return loBDAT_Registro_Codificacion_Despeje_Linea_Personal.fnSelT_Registro_Codificacion_Despeje_Linea_PersonalDin(psWhere,psOrder);

		}
		public Int32[] fnSelT_Registro_Codificacion_Despeje_Linea_PersonalMinMax()
        {
            BDAT_Registro_Codificacion_Despeje_Linea_Personal loBDAT_Registro_Codificacion_Despeje_Linea_Personal = new BDAT_Registro_Codificacion_Despeje_Linea_Personal();
            return loBDAT_Registro_Codificacion_Despeje_Linea_Personal.fnSelT_Registro_Codificacion_Despeje_Linea_PersonalMinMax();
        }


	}
}
