using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BO_SISACO;
using BDA_SISACO;

namespace BL_SISACO
{
	public partial class BLT_Producto_x_Orden_Acondicionamiento:BLBase
	{
		public Boolean fnInsT_Producto_x_Orden_Acondicionamiento(BOT_Producto_x_Orden_Acondicionamiento poBOT_Producto_x_Orden_Acondicionamiento)
		{
			BDAT_Producto_x_Orden_Acondicionamiento loBDAT_Producto_x_Orden_Acondicionamiento=new BDAT_Producto_x_Orden_Acondicionamiento();
			return loBDAT_Producto_x_Orden_Acondicionamiento.fnInsT_Producto_x_Orden_Acondicionamiento(poBOT_Producto_x_Orden_Acondicionamiento);
		}
		public Boolean fnUpdT_Producto_x_Orden_Acondicionamiento(BOT_Producto_x_Orden_Acondicionamiento poBOT_Producto_x_Orden_Acondicionamiento)
		{
			BDAT_Producto_x_Orden_Acondicionamiento loBDAT_Producto_x_Orden_Acondicionamiento=new BDAT_Producto_x_Orden_Acondicionamiento();
			return loBDAT_Producto_x_Orden_Acondicionamiento.fnUpdT_Producto_x_Orden_Acondicionamiento(poBOT_Producto_x_Orden_Acondicionamiento);
		}

		public Boolean fnInsUpdT_Producto_x_Orden_Acondicionamiento(BOT_Producto_x_Orden_Acondicionamiento poBOT_Producto_x_Orden_Acondicionamiento)
		{
			BDAT_Producto_x_Orden_Acondicionamiento loBDAT_Producto_x_Orden_Acondicionamiento=new BDAT_Producto_x_Orden_Acondicionamiento();
			return loBDAT_Producto_x_Orden_Acondicionamiento.fnInsUpdT_Producto_x_Orden_Acondicionamiento(poBOT_Producto_x_Orden_Acondicionamiento);
		}
		public Boolean fnDelT_Producto_x_Orden_Acondicionamiento(String psCodigo_Producto_x_Orden_Acondicionamiento)
		{
			BDAT_Producto_x_Orden_Acondicionamiento loBDAT_Producto_x_Orden_Acondicionamiento=new BDAT_Producto_x_Orden_Acondicionamiento();
			
			return loBDAT_Producto_x_Orden_Acondicionamiento.fnDelT_Producto_x_Orden_Acondicionamiento(psCodigo_Producto_x_Orden_Acondicionamiento);
		}

		public List<BOT_Producto_x_Orden_Acondicionamiento> fnSelT_Producto_x_Orden_AcondicionamientoAll()
		{
			BDAT_Producto_x_Orden_Acondicionamiento loBDAT_Producto_x_Orden_Acondicionamiento=new BDAT_Producto_x_Orden_Acondicionamiento();
			return loBDAT_Producto_x_Orden_Acondicionamiento.fnSelT_Producto_x_Orden_AcondicionamientoAll();
		}

		public BOT_Producto_x_Orden_Acondicionamiento fnSelT_Producto_x_Orden_Acondicionamiento(String psCodigo_Producto_x_Orden_Acondicionamiento)
		{
			BDAT_Producto_x_Orden_Acondicionamiento loBDAT_Producto_x_Orden_Acondicionamiento=new BDAT_Producto_x_Orden_Acondicionamiento();
			return loBDAT_Producto_x_Orden_Acondicionamiento.fnSelT_Producto_x_Orden_Acondicionamiento(psCodigo_Producto_x_Orden_Acondicionamiento);
		}
		public List<BOT_Producto_x_Orden_Acondicionamiento> fnSelT_Producto_x_Orden_AcondicionamientoDin(string psWhere,string psOrder)
		{
			BDAT_Producto_x_Orden_Acondicionamiento loBDAT_Producto_x_Orden_Acondicionamiento=new BDAT_Producto_x_Orden_Acondicionamiento();
			return loBDAT_Producto_x_Orden_Acondicionamiento.fnSelT_Producto_x_Orden_AcondicionamientoDin(psWhere,psOrder);

		}
		public Int32[] fnSelT_Producto_x_Orden_AcondicionamientoMinMax()
        {
            BDAT_Producto_x_Orden_Acondicionamiento loBDAT_Producto_x_Orden_Acondicionamiento = new BDAT_Producto_x_Orden_Acondicionamiento();
            return loBDAT_Producto_x_Orden_Acondicionamiento.fnSelT_Producto_x_Orden_AcondicionamientoMinMax();
        }


	}
}
