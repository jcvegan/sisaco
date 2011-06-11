using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISACO.Eventos;

namespace SISACO.Interfaces {
    public interface ISesionInit {
        event SesionIniciadaEventHandler SesionIniciada;
        event EventHandler SesionTerminada;
        event EventHandler ProgramaTerminado;
    }
}
