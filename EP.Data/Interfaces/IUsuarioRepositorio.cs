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
        IEnumerable<Usuario> ObterUsuario(Usuario usuarioParametros);
        IEnumerable<Usuario> ObterTabelaFiltroTelaUsuarios(Usuario usuarioParametros);
        bool InserirDadosNaTabela(Usuario usuario);
        bool AtualizarDadosNaTabela(Usuario usuario);
        bool ExcluirUsuario(Usuario usuario);
        bool AlterarAtivoUsuario(Usuario usuario);
    }
}
