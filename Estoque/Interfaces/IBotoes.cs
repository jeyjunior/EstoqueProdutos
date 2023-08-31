using Estoque.Componentes_Base;
using Estoque.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Interfaces
{
    public interface IBotoes
    {
        void Mapear(Botoes botoes, TableLayoutPanel tableLayoutPanel);
        void Layout(ModoBotoes modoBotoes);

    }
}
