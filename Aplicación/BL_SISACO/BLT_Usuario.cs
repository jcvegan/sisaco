using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BO_SISACO;
using BDA_SISACO;

namespace BL_SISACO
{
	public partial class BLT_Usuario:BLBase
	{
		public Boolean fnInsT_Usuario(BOT_Usuario poBOT_Usuario)
		{
			BDAT_Usuario loBDAT_Usuario=new BDAT_Usuario();
			return loBDAT_Usuario.fnInsT_Usuario(poBOT_Usuario);
		}
		public Boolean fnUpdT_Usuario(BOT_Usuario poBOT_Usuario)
		{
			BDAT_Usuario loBDAT_Usuario=new BDAT_Usuario();
			return loBDAT_Usuario.fnUpdT_Usuario(poBOT_Usuario);
		}

		public Boolean fnInsUpdT_Usuario(BOT_Usuario poBOT_Usuario)
		{
			BDAT_Usuario loBDAT_Usuario=new BDAT_Usuario();
			return loBDAT_Usuario.fnInsUpdT_Usuario(poBOT_Usuario);
		}
		public Boolean fnDelT_Usuario(String psCodigo_Usuario)
		{
			BDAT_Usuario loBDAT_Usuario=new BDAT_Usuario();
			
			return loBDAT_Usuario.fnDelT_Usuario(psCodigo_Usuario);
		}

		public List<BOT_Usuario> fnSelT_UsuarioAll()
		{
			BDAT_Usuario loBDAT_Usuario=new BDAT_Usuario();
			return loBDAT_Usuario.fnSelT_UsuarioAll();
		}

		public BOT_Usuario fnSelT_Usuario(String psCodigo_Usuario)
		{
			BDAT_Usuario loBDAT_Usuario=new BDAT_Usuario();
			return loBDAT_Usuario.fnSelT_Usuario(psCodigo_Usuario);
		}
		public List<BOT_Usuario> fnSelT_UsuarioDin(string psWhere,string psOrder)
		{
			BDAT_Usuario loBDAT_Usuario=new BDAT_Usuario();
			return loBDAT_Usuario.fnSelT_UsuarioDin(psWhere,psOrder);

		}
		public Int32[] fnSelT_UsuarioMinMax()
        {
            BDAT_Usuario loBDAT_Usuario = new BDAT_Usuario();
            return loBDAT_Usuario.fnSelT_UsuarioMinMax();
        }

        public String fnSelT_UsuarioCodigo() {
            BDAT_Usuario loBDAT_Usuario = new BDAT_Usuario();
            return loBDAT_Usuario.fnSelT_UsuarioCodigo();
        }

        public BOT_Usuario fnSelT_Usuario_by_Nombre(String nombre_Usuario) {
            BDAT_Usuario loBDAT_Usuario = new BDAT_Usuario();
            return loBDAT_Usuario.fnSelT_Usuario_by_Nombre(nombre_Usuario);
        }

	}
}
