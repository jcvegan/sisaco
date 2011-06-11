using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BO_SISACO;
using BDA_SISACO;

namespace BL_SISACO
{
	public partial class BLT_Orden_Acondicionamiento:BLBase
	{
		public Boolean fnInsT_Orden_Acondicionamiento(BOT_Orden_Acondicionamiento poBOT_Orden_Acondicionamiento)
		{
			BDAT_Orden_Acondicionamiento loBDAT_Orden_Acondicionamiento=new BDAT_Orden_Acondicionamiento();
			return loBDAT_Orden_Acondicionamiento.fnInsT_Orden_Acondicionamiento(poBOT_Orden_Acondicionamiento);
		}
		public Boolean fnUpdT_Orden_Acondicionamiento(BOT_Orden_Acondicionamiento poBOT_Orden_Acondicionamiento)
		{
			BDAT_Orden_Acondicionamiento loBDAT_Orden_Acondicionamiento=new BDAT_Orden_Acondicionamiento();
			return loBDAT_Orden_Acondicionamiento.fnUpdT_Orden_Acondicionamiento(poBOT_Orden_Acondicionamiento);
		}

		public Boolean fnInsUpdT_Orden_Acondicionamiento(BOT_Orden_Acondicionamiento poBOT_Orden_Acondicionamiento,out string Codigo_Orden_Acondicionamiento)
		{
			BDAT_Orden_Acondicionamiento loBDAT_Orden_Acondicionamiento=new BDAT_Orden_Acondicionamiento();
			return loBDAT_Orden_Acondicionamiento.fnInsUpdT_Orden_Acondicionamiento(poBOT_Orden_Acondicionamiento,out Codigo_Orden_Acondicionamiento);
		}
		public Boolean fnDelT_Orden_Acondicionamiento(String psCodigo_Orden_Acondicionamiento)
		{
			BDAT_Orden_Acondicionamiento loBDAT_Orden_Acondicionamiento=new BDAT_Orden_Acondicionamiento();			
			return loBDAT_Orden_Acondicionamiento.fnDelT_Orden_Acondicionamiento(psCodigo_Orden_Acondicionamiento);
		}

		public List<BOT_Orden_Acondicionamiento> fnSelT_Orden_AcondicionamientoAll()
		{
			BDAT_Orden_Acondicionamiento loBDAT_Orden_Acondicionamiento=new BDAT_Orden_Acondicionamiento();
			return loBDAT_Orden_Acondicionamiento.fnSelT_Orden_AcondicionamientoAll();
		}

		public BOT_Orden_Acondicionamiento fnSelT_Orden_Acondicionamiento(String psCodigo_Orden_Acondicionamiento)
		{
			BDAT_Orden_Acondicionamiento loBDAT_Orden_Acondicionamiento=new BDAT_Orden_Acondicionamiento();
			return loBDAT_Orden_Acondicionamiento.fnSelT_Orden_Acondicionamiento(psCodigo_Orden_Acondicionamiento);
		}
		public List<BOT_Orden_Acondicionamiento> fnSelT_Orden_AcondicionamientoDin(string psWhere,string psOrder)
		{
			BDAT_Orden_Acondicionamiento loBDAT_Orden_Acondicionamiento=new BDAT_Orden_Acondicionamiento();
			return loBDAT_Orden_Acondicionamiento.fnSelT_Orden_AcondicionamientoDin(psWhere,psOrder);

		}
		public Int32[] fnSelT_Orden_AcondicionamientoMinMax()
        {
            BDAT_Orden_Acondicionamiento loBDAT_Orden_Acondicionamiento = new BDAT_Orden_Acondicionamiento();
            return loBDAT_Orden_Acondicionamiento.fnSelT_Orden_AcondicionamientoMinMax();
        }

        public string fnSelT_OrdenAcondicionamientoCodigo() {
            BDAT_Orden_Acondicionamiento loBDAT_Orden_Acondicionamiento = new BDAT_Orden_Acondicionamiento();
            return loBDAT_Orden_Acondicionamiento.fnSelT_OrdenAcondicionamientoCodigo();
        }


	}
}
