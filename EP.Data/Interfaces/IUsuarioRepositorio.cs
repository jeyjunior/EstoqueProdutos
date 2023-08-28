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
    public interface IUsuarioRepositorio
    {
        IEnumerable<Usuario> ObterTabela();
        IEnumerable<Usuario> ObterTabelaFiltroTelaUsuarios(Usuario usuarioParametros);
        bool InserirDadosNaTabela(Usuario usuario);
    }
}
