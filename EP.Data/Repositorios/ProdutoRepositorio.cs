using Dapper;
using EP.Data.Interfaces;
using EstoqueProdutos.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProdutos.Repositorios
{
    public class ProdutoRepositorio : Repositorio<Produto>, IProdutoRepositorio
    {
        public IEnumerable<Produto> ObterProduto(PesquisaProdutoSimples pesquisarProduto)
        {
            string sql = "";
            string condicao = "";

            if (pesquisarProduto.Nome != "") 
            {
                condicao += (condicao != "" ? " AND" : "") + " Nome Like @Nome";
            }

            if (pesquisarProduto.FK_Categoria > 0) 
            {
                condicao += (condicao != "" ? " AND" : "") + "  FK_Categoria = @FK_Categoria";
            }

            using (SqlConnection connection = new SqlConnection(conexao))
            {
                connection.Open();
                sql = "SELECT * FROM Produto WHERE " + condicao;
                return connection.Query<Produto>(sql, pesquisarProduto);
            }
        }
    }
}
