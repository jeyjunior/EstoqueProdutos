using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Enums
{
    public class EstoqueEnums
    {

    }

    public enum ModoBotoes
    {
        Inicial,
        Edicao,
        Exclusao,
    }

    public enum NomeBotoes
    {
        Alterar,
        Excluir,
        Cadastrar,
        Pesquisar,
        Cancelar,
        Limpar,
        Salvar
    }

    public enum ModoCRUD
    {
        select,
        insert,
        update,
        delete
    }
}
