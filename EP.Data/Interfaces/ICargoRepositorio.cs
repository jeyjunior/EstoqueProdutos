using EP.Data.Entidades;
using EstoqueProdutos.Entidades;
using EstoqueProdutos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.Data.Interfaces
{
    public interface ICargoRepositorio : IRepositorio<Cargo>
    {
        IEnumerable<Cargo> ObterTabela();
        IEnumerable<Cargo> ObterTabela(Cargo setor);
        bool InserirDadosNaTabela(Cargo cargo);
        int ObterTotalCargosRegistrados();
        //bool AtualizarCargo(Cargo cargo);
        bool ExcluirCargo(Cargo cargo);
    }
}
