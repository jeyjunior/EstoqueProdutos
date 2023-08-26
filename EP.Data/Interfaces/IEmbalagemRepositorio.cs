using EstoqueProdutos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.Data.Interfaces
{
    public interface IEmbalagemRepositorio
    {
        IEnumerable<Embalagem> ObterTabela();
        bool InserirDadosNaTabela(Embalagem embalagem);
    }
}
