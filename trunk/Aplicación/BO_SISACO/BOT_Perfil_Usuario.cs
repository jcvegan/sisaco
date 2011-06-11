using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Perfil_Usuario:BOBase
	{
		private String _codigoPerfilUsuario;
		private String _perfilUsuario;
		
		public String Codigo_Perfil_Usuario
		{
			get
			{
				return _codigoPerfilUsuario;
			}
			set
			{
				_codigoPerfilUsuario =value;
			}
		}
		public String Perfil_Usuario
		{
			get
			{
				return _perfilUsuario;
			}
			set
			{
				_perfilUsuario =value;
			}
		}
		
		#region CONSTRUCTOR
		public BOT_Perfil_Usuario()
		{
		}
		#endregion
		
	}
}
