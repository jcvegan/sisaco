using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BO_SISACO;
using BDA_SISACO;

namespace BL_SISACO
{
	public partial class BLT_Material_Empaque_x_Orden_Acondicionamiento:BLBase
	{
		public Boolean fnInsT_Material_Empaque_x_Orden_Acondicionamiento(BOT_Material_Empaque_x_Orden_Acondicionamiento poBOT_Material_Empaque_x_Orden_Acondicionamiento)
		{
			BDAT_Material_Empaque_x_Orden_Acondicionamiento loBDAT_Material_Empaque_x_Orden_Acondicionamiento=new BDAT_Material_Empaque_x_Orden_Acondicionamiento();
			return loBDAT_Material_Empaque_x_Orden_Acondicionamiento.fnInsT_Material_Empaque_x_Orden_Acondicionamiento(poBOT_Material_Empaque_x_Orden_Acondicionamiento);
		}
		public Boolean fnUpdT_Material_Empaque_x_Orden_Acondicionamiento(BOT_Material_Empaque_x_Orden_Acondicionamiento poBOT_Material_Empaque_x_Orden_Acondicionamiento)
		{
			BDAT_Material_Empaque_x_Orden_Acondicionamiento loBDAT_Material_Empaque_x_Orden_Acondicionamiento=new BDAT_Material_Empaque_x_Orden_Acondicionamiento();
			return loBDAT_Material_Empaque_x_Orden_Acondicionamiento.fnUpdT_Material_Empaque_x_Orden_Acondicionamiento(poBOT_Material_Empaque_x_Orden_Acondicionamiento);
		}

		public Boolean fnInsUpdT_Material_Empaque_x_Orden_Acondicionamiento(BOT_Material_Empaque_x_Orden_Acondicionamiento poBOT_Material_Empaque_x_Orden_Acondicionamiento)
		{
			BDAT_Material_Empaque_x_Orden_Acondicionamiento loBDAT_Material_Empaque_x_Orden_Acondicionamiento=new BDAT_Material_Empaque_x_Orden_Acondicionamiento();
			return loBDAT_Material_Empaque_x_Orden_Acondicionamiento.fnInsUpdT_Material_Empaque_x_Orden_Acondicionamiento(poBOT_Material_Empaque_x_Orden_Acondicionamiento);
		}
		public Boolean fnDelT_Material_Empaque_x_Orden_Acondicionamiento(String psCodigo_Material_Empaque_x_Orden_Acondiconamiento)
		{
			BDAT_Material_Empaque_x_Orden_Acondicionamiento loBDAT_Material_Empaque_x_Orden_Acondicionamiento=new BDAT_Material_Empaque_x_Orden_Acondicionamiento();
			
			return loBDAT_Material_Empaque_x_Orden_Acondicionamiento.fnDelT_Material_Empaque_x_Orden_Acondicionamiento(psCodigo_Material_Empaque_x_Orden_Acondiconamiento);
		}

		public List<BOT_Material_Empaque_x_Orden_Acondicionamiento> fnSelT_Material_Empaque_x_Orden_AcondicionamientoAll()
		{
			BDAT_Material_Empaque_x_Orden_Acondicionamiento loBDAT_Material_Empaque_x_Orden_Acondicionamiento=new BDAT_Material_Empaque_x_Orden_Acondicionamiento();
			return loBDAT_Material_Empaque_x_Orden_Acondicionamiento.fnSelT_Material_Empaque_x_Orden_AcondicionamientoAll();
		}

		public BOT_Material_Empaque_x_Orden_Acondicionamiento fnSelT_Material_Empaque_x_Orden_Acondicionamiento(String psCodigo_Material_Empaque_x_Orden_Acondiconamiento)
		{
			BDAT_Material_Empaque_x_Orden_Acondicionamiento loBDAT_Material_Empaque_x_Orden_Acondicionamiento=new BDAT_Material_Empaque_x_Orden_Acondicionamiento();
			return loBDAT_Material_Empaque_x_Orden_Acondicionamiento.fnSelT_Material_Empaque_x_Orden_Acondicionamiento(psCodigo_Material_Empaque_x_Orden_Acondiconamiento);
		}
		public List<BOT_Material_Empaque_x_Orden_Acondicionamiento> fnSelT_Material_Empaque_x_Orden_AcondicionamientoDin(string psWhere,string psOrder)
		{
			BDAT_Material_Empaque_x_Orden_Acondicionamiento loBDAT_Material_Empaque_x_Orden_Acondicionamiento=new BDAT_Material_Empaque_x_Orden_Acondicionamiento();
			return loBDAT_Material_Empaque_x_Orden_Acondicionamiento.fnSelT_Material_Empaque_x_Orden_AcondicionamientoDin(psWhere,psOrder);

		}
		public Int32[] fnSelT_Material_Empaque_x_Orden_AcondicionamientoMinMax()
        {
            BDAT_Material_Empaque_x_Orden_Acondicionamiento loBDAT_Material_Empaque_x_Orden_Acondicionamiento = new BDAT_Material_Empaque_x_Orden_Acondicionamiento();
            return loBDAT_Material_Empaque_x_Orden_Acondicionamiento.fnSelT_Material_Empaque_x_Orden_AcondicionamientoMinMax();
        }


	}
}
