using System;
using System.Collections.Generic;
using System.Text;

namespace StatuBar_OCME.VistaModelo
{
    public interface VMStatusBar
    {
        void OcultarStatusBar();
        void MostrarStatusBar();
        void TrasLucido();
        void Transparente();
        void CambiarColor();
    }
}
