using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BO_SISACO;

namespace SISACO.Eventos {
    public delegate void SesionIniciadaEventHandler(object sender, SesionIniciadaEventArgs e);
    public class SesionIniciadaEventArgs : EventArgs {
        private DateTime fechaHoraInicioSesion;
        private BOT_Usuario usuarioIniciaSesion;

        public BOT_Usuario UsuarioIniciaSesion {
            get { return usuarioIniciaSesion; }
            set { usuarioIniciaSesion = value; }
        }

        public DateTime FechaHoraInicioSesion {
            get { return fechaHoraInicioSesion; }
        }

        public SesionIniciadaEventArgs(BOT_Usuario usuario) {
            usuarioIniciaSesion = usuario;
            fechaHoraInicioSesion = DateTime.Now;
        }

    }
}
