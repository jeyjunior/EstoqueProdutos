using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Interfaces
{
    public interface IFecharFormularioBase
    {
        IUCGerenciadorDeTelas GerenciadorDeTelas { get; set; }
        void ObterGerenciadorTelas(IUCGerenciadorDeTelas gerenciadorDeTelas);
        void Fechar();
    }
}
