using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BO_SISACO;
using BDA_SISACO;

namespace BL_SISACO
{
	public partial class BLT_Entrega_Producto_Empacar:BLBase
	{
		public Boolean fnInsT_Entrega_Producto_Empacar(BOT_Entrega_Producto_Empacar poBOT_Entrega_Producto_Empacar)
		{
			BDAT_Entrega_Producto_Empacar loBDAT_Entrega_Producto_Empacar=new BDAT_Entrega_Producto_Empacar();
			return loBDAT_Entrega_Producto_Empacar.fnInsT_Entrega_Producto_Empacar(poBOT_Entrega_Producto_Empacar);
		}
		public Boolean fnUpdT_Entrega_Producto_Empacar(BOT_Entrega_Producto_Empacar poBOT_Entrega_Producto_Empacar)
		{
			BDAT_Entrega_Producto_Empacar loBDAT_Entrega_Producto_Empacar=new BDAT_Entrega_Producto_Empacar();
			return loBDAT_Entrega_Producto_Empacar.fnUpdT_Entrega_Producto_Empacar(poBOT_Entrega_Producto_Empacar);
		}

		public Boolean fnInsUpdT_Entrega_Producto_Empacar(BOT_Entrega_Producto_Empacar poBOT_Entrega_Producto_Empacar)
		{
			BDAT_Entrega_Producto_Empacar loBDAT_Entrega_Producto_Empacar=new BDAT_Entrega_Producto_Empacar();
			return loBDAT_Entrega_Producto_Empacar.fnInsUpdT_Entrega_Producto_Empacar(poBOT_Entrega_Producto_Empacar);
		}
		public Boolean fnDelT_Entrega_Producto_Empacar(String psCodigo_Entrega_Producto_Empacar)
		{
			BDAT_Entrega_Producto_Empacar loBDAT_Entrega_Producto_Empacar=new BDAT_Entrega_Producto_Empacar();
			
			return loBDAT_Entrega_Producto_Empacar.fnDelT_Entrega_Producto_Empacar(psCodigo_Entrega_Producto_Empacar);
		}

		public List<BOT_Entrega_Producto_Empacar> fnSelT_Entrega_Producto_EmpacarAll()
		{
			BDAT_Entrega_Producto_Empacar loBDAT_Entrega_Producto_Empacar=new BDAT_Entrega_Producto_Empacar();
			return loBDAT_Entrega_Producto_Empacar.fnSelT_Entrega_Producto_EmpacarAll();
		}

		public BOT_Entrega_Producto_Empacar fnSelT_Entrega_Producto_Empacar(String psCodigo_Entrega_Producto_Empacar)
		{
			BDAT_Entrega_Producto_Empacar loBDAT_Entrega_Producto_Empacar=new BDAT_Entrega_Producto_Empacar();
			return loBDAT_Entrega_Producto_Empacar.fnSelT_Entrega_Producto_Empacar(psCodigo_Entrega_Producto_Empacar);
		}
		public List<BOT_Entrega_Producto_Empacar> fnSelT_Entrega_Producto_EmpacarDin(string psWhere,string psOrder)
		{
			BDAT_Entrega_Producto_Empacar loBDAT_Entrega_Producto_Empacar=new BDAT_Entrega_Producto_Empacar();
			return loBDAT_Entrega_Producto_Empacar.fnSelT_Entrega_Producto_EmpacarDin(psWhere,psOrder);

		}
		public Int32[] fnSelT_Entrega_Producto_EmpacarMinMax()
        {
            BDAT_Entrega_Producto_Empacar loBDAT_Entrega_Producto_Empacar = new BDAT_Entrega_Producto_Empacar();
            return loBDAT_Entrega_Producto_Empacar.fnSelT_Entrega_Producto_EmpacarMinMax();
        }


	}
}
