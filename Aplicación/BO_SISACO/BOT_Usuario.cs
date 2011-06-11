using System;
using System.Collections.Generic;
using System.Text;

namespace BO_SISACO
{
	[Serializable()]
	public partial class BOT_Usuario:BOBase
	{
		private String _codigoUsuario;
		private String _nombreUsuario;
		private String _codigoPerfilUsuario;
		private String _contraseña;
		private String _nombres;
		private String _apellidos;
        private BOT_Perfil_Usuario _descripcionPerfil;

        
		
		public String Codigo_Usuario
		{
			get
			{
				return _codigoUsuario;
			}
			set
			{
				_codigoUsuario =value;
			}
		}
		public String Nombre_Usuario
		{
			get
			{
				return _nombreUsuario;
			}
			set
			{
				_nombreUsuario =value;
			}
		}
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
		public String Contraseña
		{
			get
			{
				return _contraseña;
			}
			set
			{
				_contraseña =value;
			}
		}
		public String Nombres
		{
			get
			{
				return _nombres;
			}
			set
			{
				_nombres =value;
			}
		}
		public String Apellidos
		{
			get
			{
				return _apellidos;
			}
			set
			{
				_apellidos =value;
			}
		}

        public BOT_Perfil_Usuario DescripcionPerfil {
            get { 
                return _descripcionPerfil; 
            }
            set { 
                _descripcionPerfil = value; 
            }
        }

        public string Nombre_Perfil {
            get {
                return _descripcionPerfil.Perfil_Usuario;
            }
        }
		
		#region CONSTRUCTOR
		public BOT_Usuario()
		{
		}
		#endregion
		
	}
}
