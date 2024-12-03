using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StatuBar_OCME.VistaModelo
{
    public class VMmainpage
    {
        public VMmainpage()
        {
        
        }
        public void Ocultar()
        {
            DependencyService.Get<VMStatusBar>().OcultarStatusBar();
        }
        public void Mostrar()
        {
            DependencyService.Get<VMStatusBar>().MostrarStatusBar();
        }
        public void Traslucido()
        {
            DependencyService.Get<VMStatusBar>().TrasLucido();
        }
        public void Transparente()
        {
            DependencyService.Get<VMStatusBar>().Transparente();
        }
        public void CambiarColor()
        {
            DependencyService.Get<VMStatusBar>().CambiarColor();
        }
        public ICommand OcultarCommand => new Command(Ocultar);
        public ICommand MostrarCommand => new Command(Mostrar);
        public ICommand TraslucidoCommand => new Command(Traslucido);
        public ICommand TransparenteCommand => new Command(Transparente);
        public ICommand CambiarColorCommand => new Command(CambiarColor);

    }
}
