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
        void AbrirTelaSubordinada(Func<FormularioBase> criarFormulario, string nomeFormulario);
        //bool VerificarSeTelaEstaFechada(ITela form);
        bool FecharTelaSubordinada(FormularioBase formularioBase);
    }
}
