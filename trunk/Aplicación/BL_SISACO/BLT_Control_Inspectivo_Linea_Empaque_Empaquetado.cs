using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BO_SISACO;
using BDA_SISACO;

namespace BL_SISACO
{
	public partial class BLT_Control_Inspectivo_Linea_Empaque_Empaquetado:BLBase
	{
		public Boolean fnInsT_Control_Inspectivo_Linea_Empaque_Empaquetado(BOT_Control_Inspectivo_Linea_Empaque_Empaquetado poBOT_Control_Inspectivo_Linea_Empaque_Empaquetado)
		{
			BDAT_Control_Inspectivo_Linea_Empaque_Empaquetado loBDAT_Control_Inspectivo_Linea_Empaque_Empaquetado=new BDAT_Control_Inspectivo_Linea_Empaque_Empaquetado();
			return loBDAT_Control_Inspectivo_Linea_Empaque_Empaquetado.fnInsT_Control_Inspectivo_Linea_Empaque_Empaquetado(poBOT_Control_Inspectivo_Linea_Empaque_Empaquetado);
		}
		public Boolean fnUpdT_Control_Inspectivo_Linea_Empaque_Empaquetado(BOT_Control_Inspectivo_Linea_Empaque_Empaquetado poBOT_Control_Inspectivo_Linea_Empaque_Empaquetado)
		{
			BDAT_Control_Inspectivo_Linea_Empaque_Empaquetado loBDAT_Control_Inspectivo_Linea_Empaque_Empaquetado=new BDAT_Control_Inspectivo_Linea_Empaque_Empaquetado();
			return loBDAT_Control_Inspectivo_Linea_Empaque_Empaquetado.fnUpdT_Control_Inspectivo_Linea_Empaque_Empaquetado(poBOT_Control_Inspectivo_Linea_Empaque_Empaquetado);
		}

		public Boolean fnInsUpdT_Control_Inspectivo_Linea_Empaque_Empaquetado(BOT_Control_Inspectivo_Linea_Empaque_Empaquetado poBOT_Control_Inspectivo_Linea_Empaque_Empaquetado)
		{
			BDAT_Control_Inspectivo_Linea_Empaque_Empaquetado loBDAT_Control_Inspectivo_Linea_Empaque_Empaquetado=new BDAT_Control_Inspectivo_Linea_Empaque_Empaquetado();
			return loBDAT_Control_Inspectivo_Linea_Empaque_Empaquetado.fnInsUpdT_Control_Inspectivo_Linea_Empaque_Empaquetado(poBOT_Control_Inspectivo_Linea_Empaque_Empaquetado);
		}
		public Boolean fnDelT_Control_Inspectivo_Linea_Empaque_Empaquetado(String psCodigo_Control_Inspectivo_Linea_Empaque_Empaquetado)
		{
			BDAT_Control_Inspectivo_Linea_Empaque_Empaquetado loBDAT_Control_Inspectivo_Linea_Empaque_Empaquetado=new BDAT_Control_Inspectivo_Linea_Empaque_Empaquetado();
			
			return loBDAT_Control_Inspectivo_Linea_Empaque_Empaquetado.fnDelT_Control_Inspectivo_Linea_Empaque_Empaquetado(psCodigo_Control_Inspectivo_Linea_Empaque_Empaquetado);
		}

		public List<BOT_Control_Inspectivo_Linea_Empaque_Empaquetado> fnSelT_Control_Inspectivo_Linea_Empaque_EmpaquetadoAll()
		{
			BDAT_Control_Inspectivo_Linea_Empaque_Empaquetado loBDAT_Control_Inspectivo_Linea_Empaque_Empaquetado=new BDAT_Control_Inspectivo_Linea_Empaque_Empaquetado();
			return loBDAT_Control_Inspectivo_Linea_Empaque_Empaquetado.fnSelT_Control_Inspectivo_Linea_Empaque_EmpaquetadoAll();
		}

		public BOT_Control_Inspectivo_Linea_Empaque_Empaquetado fnSelT_Control_Inspectivo_Linea_Empaque_Empaquetado(String psCodigo_Control_Inspectivo_Linea_Empaque_Empaquetado)
		{
			BDAT_Control_Inspectivo_Linea_Empaque_Empaquetado loBDAT_Control_Inspectivo_Linea_Empaque_Empaquetado=new BDAT_Control_Inspectivo_Linea_Empaque_Empaquetado();
			return loBDAT_Control_Inspectivo_Linea_Empaque_Empaquetado.fnSelT_Control_Inspectivo_Linea_Empaque_Empaquetado(psCodigo_Control_Inspectivo_Linea_Empaque_Empaquetado);
		}
		public List<BOT_Control_Inspectivo_Linea_Empaque_Empaquetado> fnSelT_Control_Inspectivo_Linea_Empaque_EmpaquetadoDin(string psWhere,string psOrder)
		{
			BDAT_Control_Inspectivo_Linea_Empaque_Empaquetado loBDAT_Control_Inspectivo_Linea_Empaque_Empaquetado=new BDAT_Control_Inspectivo_Linea_Empaque_Empaquetado();
			return loBDAT_Control_Inspectivo_Linea_Empaque_Empaquetado.fnSelT_Control_Inspectivo_Linea_Empaque_EmpaquetadoDin(psWhere,psOrder);

		}
		public Int32[] fnSelT_Control_Inspectivo_Linea_Empaque_EmpaquetadoMinMax()
        {
            BDAT_Control_Inspectivo_Linea_Empaque_Empaquetado loBDAT_Control_Inspectivo_Linea_Empaque_Empaquetado = new BDAT_Control_Inspectivo_Linea_Empaque_Empaquetado();
            return loBDAT_Control_Inspectivo_Linea_Empaque_Empaquetado.fnSelT_Control_Inspectivo_Linea_Empaque_EmpaquetadoMinMax();
        }


	}
}
