using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BO_SISACO;
using BDA_SISACO;

namespace BL_SISACO
{
	public partial class BLT_Devolucion:BLBase
	{
		public Boolean fnInsT_Devolucion(BOT_Devolucion poBOT_Devolucion)
		{
			BDAT_Devolucion loBDAT_Devolucion=new BDAT_Devolucion();
			return loBDAT_Devolucion.fnInsT_Devolucion(poBOT_Devolucion);
		}
		public Boolean fnUpdT_Devolucion(BOT_Devolucion poBOT_Devolucion)
		{
			BDAT_Devolucion loBDAT_Devolucion=new BDAT_Devolucion();
			return loBDAT_Devolucion.fnUpdT_Devolucion(poBOT_Devolucion);
		}

		public Boolean fnInsUpdT_Devolucion(BOT_Devolucion poBOT_Devolucion)
		{
			BDAT_Devolucion loBDAT_Devolucion=new BDAT_Devolucion();
			return loBDAT_Devolucion.fnInsUpdT_Devolucion(poBOT_Devolucion);
		}
		public Boolean fnDelT_Devolucion(String psCodigo_Devolucion)
		{
			BDAT_Devolucion loBDAT_Devolucion=new BDAT_Devolucion();
			
			return loBDAT_Devolucion.fnDelT_Devolucion(psCodigo_Devolucion);
		}

		public List<BOT_Devolucion> fnSelT_DevolucionAll()
		{
			BDAT_Devolucion loBDAT_Devolucion=new BDAT_Devolucion();
			return loBDAT_Devolucion.fnSelT_DevolucionAll();
		}

		public BOT_Devolucion fnSelT_Devolucion(String psCodigo_Devolucion)
		{
			BDAT_Devolucion loBDAT_Devolucion=new BDAT_Devolucion();
			return loBDAT_Devolucion.fnSelT_Devolucion(psCodigo_Devolucion);
		}
		public List<BOT_Devolucion> fnSelT_DevolucionDin(string psWhere,string psOrder)
		{
			BDAT_Devolucion loBDAT_Devolucion=new BDAT_Devolucion();
			return loBDAT_Devolucion.fnSelT_DevolucionDin(psWhere,psOrder);

		}
		public Int32[] fnSelT_DevolucionMinMax()
        {
            BDAT_Devolucion loBDAT_Devolucion = new BDAT_Devolucion();
            return loBDAT_Devolucion.fnSelT_DevolucionMinMax();
        }


	}
}
