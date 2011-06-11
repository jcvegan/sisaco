using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BO_SISACO;
using BDA_SISACO;

namespace BL_SISACO
{
	public partial class BLT_Registro_Empaque_Procedimiento:BLBase
	{
		public Boolean fnInsT_Registro_Empaque_Procedimiento(BOT_Registro_Empaque_Procedimiento poBOT_Registro_Empaque_Procedimiento)
		{
			BDAT_Registro_Empaque_Procedimiento loBDAT_Registro_Empaque_Procedimiento=new BDAT_Registro_Empaque_Procedimiento();
			return loBDAT_Registro_Empaque_Procedimiento.fnInsT_Registro_Empaque_Procedimiento(poBOT_Registro_Empaque_Procedimiento);
		}
		public Boolean fnUpdT_Registro_Empaque_Procedimiento(BOT_Registro_Empaque_Procedimiento poBOT_Registro_Empaque_Procedimiento)
		{
			BDAT_Registro_Empaque_Procedimiento loBDAT_Registro_Empaque_Procedimiento=new BDAT_Registro_Empaque_Procedimiento();
			return loBDAT_Registro_Empaque_Procedimiento.fnUpdT_Registro_Empaque_Procedimiento(poBOT_Registro_Empaque_Procedimiento);
		}

		public Boolean fnInsUpdT_Registro_Empaque_Procedimiento(BOT_Registro_Empaque_Procedimiento poBOT_Registro_Empaque_Procedimiento)
		{
			BDAT_Registro_Empaque_Procedimiento loBDAT_Registro_Empaque_Procedimiento=new BDAT_Registro_Empaque_Procedimiento();
			return loBDAT_Registro_Empaque_Procedimiento.fnInsUpdT_Registro_Empaque_Procedimiento(poBOT_Registro_Empaque_Procedimiento);
		}
		public Boolean fnDelT_Registro_Empaque_Procedimiento(String psCodigo_Registro_Empaque_Procedimiento)
		{
			BDAT_Registro_Empaque_Procedimiento loBDAT_Registro_Empaque_Procedimiento=new BDAT_Registro_Empaque_Procedimiento();
			
			return loBDAT_Registro_Empaque_Procedimiento.fnDelT_Registro_Empaque_Procedimiento(psCodigo_Registro_Empaque_Procedimiento);
		}

		public List<BOT_Registro_Empaque_Procedimiento> fnSelT_Registro_Empaque_ProcedimientoAll()
		{
			BDAT_Registro_Empaque_Procedimiento loBDAT_Registro_Empaque_Procedimiento=new BDAT_Registro_Empaque_Procedimiento();
			return loBDAT_Registro_Empaque_Procedimiento.fnSelT_Registro_Empaque_ProcedimientoAll();
		}

		public BOT_Registro_Empaque_Procedimiento fnSelT_Registro_Empaque_Procedimiento(String psCodigo_Registro_Empaque_Procedimiento)
		{
			BDAT_Registro_Empaque_Procedimiento loBDAT_Registro_Empaque_Procedimiento=new BDAT_Registro_Empaque_Procedimiento();
			return loBDAT_Registro_Empaque_Procedimiento.fnSelT_Registro_Empaque_Procedimiento(psCodigo_Registro_Empaque_Procedimiento);
		}
		public List<BOT_Registro_Empaque_Procedimiento> fnSelT_Registro_Empaque_ProcedimientoDin(string psWhere,string psOrder)
		{
			BDAT_Registro_Empaque_Procedimiento loBDAT_Registro_Empaque_Procedimiento=new BDAT_Registro_Empaque_Procedimiento();
			return loBDAT_Registro_Empaque_Procedimiento.fnSelT_Registro_Empaque_ProcedimientoDin(psWhere,psOrder);

		}
		public Int32[] fnSelT_Registro_Empaque_ProcedimientoMinMax()
        {
            BDAT_Registro_Empaque_Procedimiento loBDAT_Registro_Empaque_Procedimiento = new BDAT_Registro_Empaque_Procedimiento();
            return loBDAT_Registro_Empaque_Procedimiento.fnSelT_Registro_Empaque_ProcedimientoMinMax();
        }


	}
}
