using EstoqueProdutos.Interfaces.Telas;
using EstoqueProdutos.Telas_Base;
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
    }
}
