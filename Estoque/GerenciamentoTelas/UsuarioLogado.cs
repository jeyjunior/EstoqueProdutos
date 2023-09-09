using EP.Data.Entidades;
using Estoque.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.GerenciamentoTelas
{
    /// <summary>
    /// Usuario logado
    /// </summary>
    public class UsuarioLogado : IUsuarioLogado
    {
        private Usuario usuario;

        public void AtribuirUsuario(Usuario usuario)
        {
            this.usuario = usuario;
        }

        public Usuario ObterUsuarioLogado() 
        { 
            if(usuario != null)
            {
                return usuario;
            }

            return null;
        }
    }
}
