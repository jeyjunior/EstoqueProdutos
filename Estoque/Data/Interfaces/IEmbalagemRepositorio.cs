using EstoqueProdutos.Entidades;
using EstoqueProdutos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.Data.Interfaces
{
    public interface IEmbalagemRepositorio : IRepositorio<Embalagem>
    {
        IEnumerable<Embalagem> ObterTabela();
        bool InserirDadosNaTabela(Embalagem embalagem);
    }
}
