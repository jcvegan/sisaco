using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BO_SISACO;
using BDA_SISACO;

namespace BL_SISACO
{
	public partial class BLT_Producto:BLBase
	{
		public Boolean fnInsT_Producto(BOT_Producto poBOT_Producto)
		{
			BDAT_Producto loBDAT_Producto=new BDAT_Producto();
			return loBDAT_Producto.fnInsT_Producto(poBOT_Producto);
		}
		public Boolean fnUpdT_Producto(BOT_Producto poBOT_Producto)
		{
			BDAT_Producto loBDAT_Producto=new BDAT_Producto();
			return loBDAT_Producto.fnUpdT_Producto(poBOT_Producto);
		}

		public Boolean fnInsUpdT_Producto(BOT_Producto poBOT_Producto)
		{
			BDAT_Producto loBDAT_Producto=new BDAT_Producto();
			return loBDAT_Producto.fnInsUpdT_Producto(poBOT_Producto);
		}
		public Boolean fnDelT_Producto(String psCodigo_Producto)
		{
			BDAT_Producto loBDAT_Producto=new BDAT_Producto();
			
			return loBDAT_Producto.fnDelT_Producto(psCodigo_Producto);
		}

		public List<BOT_Producto> fnSelT_ProductoAll()
		{
			BDAT_Producto loBDAT_Producto=new BDAT_Producto();
			return loBDAT_Producto.fnSelT_ProductoAll();
		}

		public BOT_Producto fnSelT_Producto(String psCodigo_Producto)
		{
			BDAT_Producto loBDAT_Producto=new BDAT_Producto();
			return loBDAT_Producto.fnSelT_Producto(psCodigo_Producto);
		}
		public List<BOT_Producto> fnSelT_ProductoDin(string psWhere,string psOrder)
		{
			BDAT_Producto loBDAT_Producto=new BDAT_Producto();
			return loBDAT_Producto.fnSelT_ProductoDin(psWhere,psOrder);

		}
		public Int32[] fnSelT_ProductoMinMax()
        {
            BDAT_Producto loBDAT_Producto = new BDAT_Producto();
            return loBDAT_Producto.fnSelT_ProductoMinMax();
        }
        public String fnSelT_ProductoCodigo() {
            BDAT_Producto loBDAT_Producto = new BDAT_Producto();
            return loBDAT_Producto.fnSelT_ProductoCodigo();
        }

        public bool fnEsReferenciadoT_Producto(BOT_Producto producto) {
            BDAT_Producto loBDAT_Producto = new BDAT_Producto();
            return loBDAT_Producto.fnEsReferenciadoT_Producto(producto);
        }

        public List<BOT_Producto> fnSelT_Producto_conMaterialEmpaque() {
            BDAT_Producto loBDAT_Producto = new BDAT_Producto();
            return loBDAT_Producto.fnSelT_Producto_conMaterialEmpaque();
        }
	}
}
