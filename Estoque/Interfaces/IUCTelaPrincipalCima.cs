using EstoqueProdutos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Interfaces
{
    public interface IUCTelaPrincipalCima
    {
        void AtualizarInfoUsuarioLogado();
        void AtualizarInfoTelaAberta(Image logo, string nomeTela);
    }
}
