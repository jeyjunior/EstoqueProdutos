using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Interfaces
{
    public interface IFrmPrincipal
    {
        void AbrirTelaPanelCentral<T>() where T : UserControl, new();
    }
}
