using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BO_SISACO;
using BDA_SISACO;

namespace BL_SISACO
{
	public partial class BLT_Registro_Codificacion_Codificacion_Cajas:BLBase
	{
		public Boolean fnInsT_Registro_Codificacion_Codificacion_Cajas(BOT_Registro_Codificacion_Codificacion_Cajas poBOT_Registro_Codificacion_Codificacion_Cajas)
		{
			BDAT_Registro_Codificacion_Codificacion_Cajas loBDAT_Registro_Codificacion_Codificacion_Cajas=new BDAT_Registro_Codificacion_Codificacion_Cajas();
			return loBDAT_Registro_Codificacion_Codificacion_Cajas.fnInsT_Registro_Codificacion_Codificacion_Cajas(poBOT_Registro_Codificacion_Codificacion_Cajas);
		}
		public Boolean fnUpdT_Registro_Codificacion_Codificacion_Cajas(BOT_Registro_Codificacion_Codificacion_Cajas poBOT_Registro_Codificacion_Codificacion_Cajas)
		{
			BDAT_Registro_Codificacion_Codificacion_Cajas loBDAT_Registro_Codificacion_Codificacion_Cajas=new BDAT_Registro_Codificacion_Codificacion_Cajas();
			return loBDAT_Registro_Codificacion_Codificacion_Cajas.fnUpdT_Registro_Codificacion_Codificacion_Cajas(poBOT_Registro_Codificacion_Codificacion_Cajas);
		}

		public Boolean fnInsUpdT_Registro_Codificacion_Codificacion_Cajas(BOT_Registro_Codificacion_Codificacion_Cajas poBOT_Registro_Codificacion_Codificacion_Cajas)
		{
			BDAT_Registro_Codificacion_Codificacion_Cajas loBDAT_Registro_Codificacion_Codificacion_Cajas=new BDAT_Registro_Codificacion_Codificacion_Cajas();
			return loBDAT_Registro_Codificacion_Codificacion_Cajas.fnInsUpdT_Registro_Codificacion_Codificacion_Cajas(poBOT_Registro_Codificacion_Codificacion_Cajas);
		}
		public Boolean fnDelT_Registro_Codificacion_Codificacion_Cajas(String psCodigo_Registro_Codificacion_Codificacion_Cajas)
		{
			BDAT_Registro_Codificacion_Codificacion_Cajas loBDAT_Registro_Codificacion_Codificacion_Cajas=new BDAT_Registro_Codificacion_Codificacion_Cajas();
			
			return loBDAT_Registro_Codificacion_Codificacion_Cajas.fnDelT_Registro_Codificacion_Codificacion_Cajas(psCodigo_Registro_Codificacion_Codificacion_Cajas);
		}

		public List<BOT_Registro_Codificacion_Codificacion_Cajas> fnSelT_Registro_Codificacion_Codificacion_CajasAll()
		{
			BDAT_Registro_Codificacion_Codificacion_Cajas loBDAT_Registro_Codificacion_Codificacion_Cajas=new BDAT_Registro_Codificacion_Codificacion_Cajas();
			return loBDAT_Registro_Codificacion_Codificacion_Cajas.fnSelT_Registro_Codificacion_Codificacion_CajasAll();
		}

		public BOT_Registro_Codificacion_Codificacion_Cajas fnSelT_Registro_Codificacion_Codificacion_Cajas(String psCodigo_Registro_Codificacion_Codificacion_Cajas)
		{
			BDAT_Registro_Codificacion_Codificacion_Cajas loBDAT_Registro_Codificacion_Codificacion_Cajas=new BDAT_Registro_Codificacion_Codificacion_Cajas();
			return loBDAT_Registro_Codificacion_Codificacion_Cajas.fnSelT_Registro_Codificacion_Codificacion_Cajas(psCodigo_Registro_Codificacion_Codificacion_Cajas);
		}
		public List<BOT_Registro_Codificacion_Codificacion_Cajas> fnSelT_Registro_Codificacion_Codificacion_CajasDin(string psWhere,string psOrder)
		{
			BDAT_Registro_Codificacion_Codificacion_Cajas loBDAT_Registro_Codificacion_Codificacion_Cajas=new BDAT_Registro_Codificacion_Codificacion_Cajas();
			return loBDAT_Registro_Codificacion_Codificacion_Cajas.fnSelT_Registro_Codificacion_Codificacion_CajasDin(psWhere,psOrder);

		}
		public Int32[] fnSelT_Registro_Codificacion_Codificacion_CajasMinMax()
        {
            BDAT_Registro_Codificacion_Codificacion_Cajas loBDAT_Registro_Codificacion_Codificacion_Cajas = new BDAT_Registro_Codificacion_Codificacion_Cajas();
            return loBDAT_Registro_Codificacion_Codificacion_Cajas.fnSelT_Registro_Codificacion_Codificacion_CajasMinMax();
        }


	}
}
