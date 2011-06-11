using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BO_SISACO;
using BDA_SISACO;

namespace BL_SISACO
{
	public partial class BLT_Material_Empaque_x_Producto:BLBase
	{
		public Boolean fnInsT_Material_Empaque_x_Producto(BOT_Material_Empaque_x_Producto poBOT_Material_Empaque_x_Producto)
		{
			BDAT_Material_Empaque_x_Producto loBDAT_Material_Empaque_x_Producto=new BDAT_Material_Empaque_x_Producto();
			return loBDAT_Material_Empaque_x_Producto.fnInsT_Material_Empaque_x_Producto(poBOT_Material_Empaque_x_Producto);
		}
		public Boolean fnUpdT_Material_Empaque_x_Producto(BOT_Material_Empaque_x_Producto poBOT_Material_Empaque_x_Producto)
		{
			BDAT_Material_Empaque_x_Producto loBDAT_Material_Empaque_x_Producto=new BDAT_Material_Empaque_x_Producto();
			return loBDAT_Material_Empaque_x_Producto.fnUpdT_Material_Empaque_x_Producto(poBOT_Material_Empaque_x_Producto);
		}

		public Boolean fnInsUpdT_Material_Empaque_x_Producto(BOT_Material_Empaque_x_Producto poBOT_Material_Empaque_x_Producto)
		{
			BDAT_Material_Empaque_x_Producto loBDAT_Material_Empaque_x_Producto=new BDAT_Material_Empaque_x_Producto();
			return loBDAT_Material_Empaque_x_Producto.fnInsUpdT_Material_Empaque_x_Producto(poBOT_Material_Empaque_x_Producto);
		}
		public Boolean fnDelT_Material_Empaque_x_Producto(String psCodigo_Material_Empaque_x_Producto)
		{
			BDAT_Material_Empaque_x_Producto loBDAT_Material_Empaque_x_Producto=new BDAT_Material_Empaque_x_Producto();
			return loBDAT_Material_Empaque_x_Producto.fnDelT_Material_Empaque_x_Producto(psCodigo_Material_Empaque_x_Producto);
		}

		public List<BOT_Material_Empaque_x_Producto> fnSelT_Material_Empaque_x_ProductoAll()
		{
			BDAT_Material_Empaque_x_Producto loBDAT_Material_Empaque_x_Producto=new BDAT_Material_Empaque_x_Producto();
			return loBDAT_Material_Empaque_x_Producto.fnSelT_Material_Empaque_x_ProductoAll();
		}

		public BOT_Material_Empaque_x_Producto fnSelT_Material_Empaque_x_Producto(String psCodigo_Material_Empaque_x_Producto)
		{
			BDAT_Material_Empaque_x_Producto loBDAT_Material_Empaque_x_Producto=new BDAT_Material_Empaque_x_Producto();
			return loBDAT_Material_Empaque_x_Producto.fnSelT_Material_Empaque_x_Producto(psCodigo_Material_Empaque_x_Producto);
		}
		public List<BOT_Material_Empaque_x_Producto> fnSelT_Material_Empaque_x_ProductoDin(string psWhere,string psOrder)
		{
			BDAT_Material_Empaque_x_Producto loBDAT_Material_Empaque_x_Producto=new BDAT_Material_Empaque_x_Producto();
			return loBDAT_Material_Empaque_x_Producto.fnSelT_Material_Empaque_x_ProductoDin(psWhere,psOrder);
		}
		public Int32[] fnSelT_Material_Empaque_x_ProductoMinMax()
        {
            BDAT_Material_Empaque_x_Producto loBDAT_Material_Empaque_x_Producto = new BDAT_Material_Empaque_x_Producto();
            return loBDAT_Material_Empaque_x_Producto.fnSelT_Material_Empaque_x_ProductoMinMax();
        }        
        public Boolean fnExsT_Material_Empaque_x_Producto(string cod_Producto, string cod_Material_Empaque,int tamaño_lote) {
            BDAT_Material_Empaque_x_Producto loBDAT_Material_Empaque_x_Producto = new BDAT_Material_Empaque_x_Producto();
            return loBDAT_Material_Empaque_x_Producto.fnExsT_Material_Empaque_x_Producto(cod_Producto, cod_Material_Empaque,tamaño_lote);
        }
        public Boolean fnExsT_Material_Empaque_x_tamaño_Lote(string Cod_Producto, int Tamaño_Lote) {
            BDAT_Material_Empaque_x_Producto loBDAT_Material_Empaque_x_Producto = new BDAT_Material_Empaque_x_Producto();
            return loBDAT_Material_Empaque_x_Producto.fnExsT_Material_Empaque_x_tamaño_Lote(Cod_Producto, Tamaño_Lote);
        }

        public Boolean fnExsT_Material_Empaque_x_Material_Empaque_Producto(string Cod_Material_Empaque) {
            BDAT_Material_Empaque_x_Producto loBDAT_Material_Empaque_x_Producto = new BDAT_Material_Empaque_x_Producto();
            return loBDAT_Material_Empaque_x_Producto.fnExsT_Material_Empaque_x_Material_Empaque_Producto(Cod_Material_Empaque);
        }
        public List<string> fnSelT_Material_Empaque_x_Producto_Tamaño_Lote(string Cod_Producto) {
            BDAT_Material_Empaque_x_Producto loBDAT_Material_Empaque_x_Producto = new BDAT_Material_Empaque_x_Producto();
            return loBDAT_Material_Empaque_x_Producto.fnSelT_Material_Empaque_x_Producto_Tamaño_Lote(Cod_Producto);
        }
	}
}
