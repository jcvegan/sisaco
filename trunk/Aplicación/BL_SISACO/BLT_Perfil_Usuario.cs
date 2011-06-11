using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BO_SISACO;
using BDA_SISACO;

namespace BL_SISACO
{
	public partial class BLT_Perfil_Usuario:BLBase
	{
		public Boolean fnInsT_Perfil_Usuario(BOT_Perfil_Usuario poBOT_Perfil_Usuario)
		{
			BDAT_Perfil_Usuario loBDAT_Perfil_Usuario=new BDAT_Perfil_Usuario();
			return loBDAT_Perfil_Usuario.fnInsT_Perfil_Usuario(poBOT_Perfil_Usuario);
		}
		public Boolean fnUpdT_Perfil_Usuario(BOT_Perfil_Usuario poBOT_Perfil_Usuario)
		{
			BDAT_Perfil_Usuario loBDAT_Perfil_Usuario=new BDAT_Perfil_Usuario();
			return loBDAT_Perfil_Usuario.fnUpdT_Perfil_Usuario(poBOT_Perfil_Usuario);
		}

		public Boolean fnInsUpdT_Perfil_Usuario(BOT_Perfil_Usuario poBOT_Perfil_Usuario)
		{
			BDAT_Perfil_Usuario loBDAT_Perfil_Usuario=new BDAT_Perfil_Usuario();
			return loBDAT_Perfil_Usuario.fnInsUpdT_Perfil_Usuario(poBOT_Perfil_Usuario);
		}
		public Boolean fnDelT_Perfil_Usuario(String psCodigo_Perfil_Usuario)
		{
			BDAT_Perfil_Usuario loBDAT_Perfil_Usuario=new BDAT_Perfil_Usuario();
			
			return loBDAT_Perfil_Usuario.fnDelT_Perfil_Usuario(psCodigo_Perfil_Usuario);
		}

		public List<BOT_Perfil_Usuario> fnSelT_Perfil_UsuarioAll()
		{
			BDAT_Perfil_Usuario loBDAT_Perfil_Usuario=new BDAT_Perfil_Usuario();
			return loBDAT_Perfil_Usuario.fnSelT_Perfil_UsuarioAll();
		}

		public BOT_Perfil_Usuario fnSelT_Perfil_Usuario(String psCodigo_Perfil_Usuario)
		{
			BDAT_Perfil_Usuario loBDAT_Perfil_Usuario=new BDAT_Perfil_Usuario();
			return loBDAT_Perfil_Usuario.fnSelT_Perfil_Usuario(psCodigo_Perfil_Usuario);
		}
		public List<BOT_Perfil_Usuario> fnSelT_Perfil_UsuarioDin(string psWhere,string psOrder)
		{
			BDAT_Perfil_Usuario loBDAT_Perfil_Usuario=new BDAT_Perfil_Usuario();
			return loBDAT_Perfil_Usuario.fnSelT_Perfil_UsuarioDin(psWhere,psOrder);

		}
		public Int32[] fnSelT_Perfil_UsuarioMinMax()
        {
            BDAT_Perfil_Usuario loBDAT_Perfil_Usuario = new BDAT_Perfil_Usuario();
            return loBDAT_Perfil_Usuario.fnSelT_Perfil_UsuarioMinMax();
        }


	}
}
