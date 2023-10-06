using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProdutos.Interfaces
{
    public interface IRepositorio<T>
    {
        IEnumerable<T> ObterTabela();
        bool InserirDadosNaTabela(T entity);
        int ObterContagemTotal(string nomeEntidade);
        int ObterContagemTotal();
        bool ValidarValorExistente(string coluna, dynamic valor);
    }
}
