using EstoqueProdutos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProdutos.Interfaces
{
    public interface IProdutoRepositorio
    {
        IEnumerable<Produto> ObterTodosProdutos();
        IEnumerable<Produto> ObterLista(string personalizado);
        Produto ObterProdutoPorId(int id);
        void InserirProduto(Produto produto);
        void AtualizarProduto(Produto produto);
        void ExcluirProduto(int id);
    }
}
