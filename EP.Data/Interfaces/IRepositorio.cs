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
        IEnumerable<T> ConsultarDadosNaTabela(T filtro);
        bool InserirDadosNaTabela(T entity);
        int ObterContagemTotal(string nomeEntidade);
        int ObterContagemTotal();
        bool ValidarValorExistente(string coluna, dynamic valor);
        bool AtualizarDadosComValores(T entity);
        bool AtualizarTodosOsDados(T entity);
        bool ExcluirDadosDaTabela(object id);
    }
}
