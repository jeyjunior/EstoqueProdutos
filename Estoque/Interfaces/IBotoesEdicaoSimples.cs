using Estoque.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Interfaces
{
    public interface IBotoesEdicaoSimples
    {
        void AtribuirEventoClick(EventHandler eventoDeClick, NomeBotoes nome);
        void ExecutarEventoBotao(NomeBotoes nome);
        void Layout(ModoBotoes modoBotoes);
    }
}
