using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BO_SISACO;
using BDA_SISACO;

namespace BL_SISACO
{
	public partial class BLT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones:BLBase
	{
		public Boolean fnInsT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones(BOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones poBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones)
		{
			BDAT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones loBDAT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones=new BDAT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones();
			return loBDAT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.fnInsT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones(poBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones);
		}
		public Boolean fnUpdT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones(BOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones poBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones)
		{
			BDAT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones loBDAT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones=new BDAT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones();
			return loBDAT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.fnUpdT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones(poBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones);
		}

		public Boolean fnInsUpdT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones(BOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones poBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones)
		{
			BDAT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones loBDAT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones=new BDAT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones();
			return loBDAT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.fnInsUpdT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones(poBOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones);
		}
		public Boolean fnDelT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones(String psCodigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones)
		{
			BDAT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones loBDAT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones=new BDAT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones();
			
			return loBDAT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.fnDelT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones(psCodigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones);
		}

		public List<BOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones> fnSelT_Registro_Empaque_Despeje_Linea_Equipos_InstalacionesAll()
		{
			BDAT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones loBDAT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones=new BDAT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones();
			return loBDAT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.fnSelT_Registro_Empaque_Despeje_Linea_Equipos_InstalacionesAll();
		}

		public BOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones fnSelT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones(String psCodigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones)
		{
			BDAT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones loBDAT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones=new BDAT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones();
			return loBDAT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.fnSelT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones(psCodigo_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones);
		}
		public List<BOT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones> fnSelT_Registro_Empaque_Despeje_Linea_Equipos_InstalacionesDin(string psWhere,string psOrder)
		{
			BDAT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones loBDAT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones=new BDAT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones();
			return loBDAT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.fnSelT_Registro_Empaque_Despeje_Linea_Equipos_InstalacionesDin(psWhere,psOrder);

		}
		public Int32[] fnSelT_Registro_Empaque_Despeje_Linea_Equipos_InstalacionesMinMax()
        {
            BDAT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones loBDAT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones = new BDAT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones();
            return loBDAT_Registro_Empaque_Despeje_Linea_Equipos_Instalaciones.fnSelT_Registro_Empaque_Despeje_Linea_Equipos_InstalacionesMinMax();
        }


	}
}
