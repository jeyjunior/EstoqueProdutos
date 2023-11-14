using EstoqueProdutos.Entidades;
using EstoqueProdutos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.Data.Interfaces
{
    public interface IMarcaRepositorio : IRepositorio<Marca>
    {
        IEnumerable<Marca> ObterTabela();
        bool InserirDadosNaTabela(Marca marca);
    }
}
