using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BO_SISACO;
using BDA_SISACO;

namespace BL_SISACO
{
	public partial class BLT_Entrega_Producto_Terminado_Almacen:BLBase
	{
		public Boolean fnInsT_Entrega_Producto_Terminado_Almacen(BOT_Entrega_Producto_Terminado_Almacen poBOT_Entrega_Producto_Terminado_Almacen)
		{
			BDAT_Entrega_Producto_Terminado_Almacen loBDAT_Entrega_Producto_Terminado_Almacen=new BDAT_Entrega_Producto_Terminado_Almacen();
			return loBDAT_Entrega_Producto_Terminado_Almacen.fnInsT_Entrega_Producto_Terminado_Almacen(poBOT_Entrega_Producto_Terminado_Almacen);
		}
		public Boolean fnUpdT_Entrega_Producto_Terminado_Almacen(BOT_Entrega_Producto_Terminado_Almacen poBOT_Entrega_Producto_Terminado_Almacen)
		{
			BDAT_Entrega_Producto_Terminado_Almacen loBDAT_Entrega_Producto_Terminado_Almacen=new BDAT_Entrega_Producto_Terminado_Almacen();
			return loBDAT_Entrega_Producto_Terminado_Almacen.fnUpdT_Entrega_Producto_Terminado_Almacen(poBOT_Entrega_Producto_Terminado_Almacen);
		}

		public Boolean fnInsUpdT_Entrega_Producto_Terminado_Almacen(BOT_Entrega_Producto_Terminado_Almacen poBOT_Entrega_Producto_Terminado_Almacen)
		{
			BDAT_Entrega_Producto_Terminado_Almacen loBDAT_Entrega_Producto_Terminado_Almacen=new BDAT_Entrega_Producto_Terminado_Almacen();
			return loBDAT_Entrega_Producto_Terminado_Almacen.fnInsUpdT_Entrega_Producto_Terminado_Almacen(poBOT_Entrega_Producto_Terminado_Almacen);
		}
		public Boolean fnDelT_Entrega_Producto_Terminado_Almacen(String psCodigo_Entrega_Producto_Terminado_Almacen)
		{
			BDAT_Entrega_Producto_Terminado_Almacen loBDAT_Entrega_Producto_Terminado_Almacen=new BDAT_Entrega_Producto_Terminado_Almacen();
			
			return loBDAT_Entrega_Producto_Terminado_Almacen.fnDelT_Entrega_Producto_Terminado_Almacen(psCodigo_Entrega_Producto_Terminado_Almacen);
		}

		public List<BOT_Entrega_Producto_Terminado_Almacen> fnSelT_Entrega_Producto_Terminado_AlmacenAll()
		{
			BDAT_Entrega_Producto_Terminado_Almacen loBDAT_Entrega_Producto_Terminado_Almacen=new BDAT_Entrega_Producto_Terminado_Almacen();
			return loBDAT_Entrega_Producto_Terminado_Almacen.fnSelT_Entrega_Producto_Terminado_AlmacenAll();
		}

		public BOT_Entrega_Producto_Terminado_Almacen fnSelT_Entrega_Producto_Terminado_Almacen(String psCodigo_Entrega_Producto_Terminado_Almacen)
		{
			BDAT_Entrega_Producto_Terminado_Almacen loBDAT_Entrega_Producto_Terminado_Almacen=new BDAT_Entrega_Producto_Terminado_Almacen();
			return loBDAT_Entrega_Producto_Terminado_Almacen.fnSelT_Entrega_Producto_Terminado_Almacen(psCodigo_Entrega_Producto_Terminado_Almacen);
		}
		public List<BOT_Entrega_Producto_Terminado_Almacen> fnSelT_Entrega_Producto_Terminado_AlmacenDin(string psWhere,string psOrder)
		{
			BDAT_Entrega_Producto_Terminado_Almacen loBDAT_Entrega_Producto_Terminado_Almacen=new BDAT_Entrega_Producto_Terminado_Almacen();
			return loBDAT_Entrega_Producto_Terminado_Almacen.fnSelT_Entrega_Producto_Terminado_AlmacenDin(psWhere,psOrder);

		}
		public Int32[] fnSelT_Entrega_Producto_Terminado_AlmacenMinMax()
        {
            BDAT_Entrega_Producto_Terminado_Almacen loBDAT_Entrega_Producto_Terminado_Almacen = new BDAT_Entrega_Producto_Terminado_Almacen();
            return loBDAT_Entrega_Producto_Terminado_Almacen.fnSelT_Entrega_Producto_Terminado_AlmacenMinMax();
        }


	}
}
