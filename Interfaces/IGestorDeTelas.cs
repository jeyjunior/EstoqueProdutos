using EstoqueProdutos.Telas_Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProdutos.Interfaces
{
    public interface IGestorDeTelas
    {
        bool AbrirTelaSubordinada(FormularioBase formularioBase);
        //bool VerificarSeTelaEstaFechada(ITela form);
        bool FecharTelaSubordinada(FormularioBase formularioBase);
    }
}
