using Dapper;
using EP.Data.Interfaces;
using EstoqueProdutos.Formatacao;
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

            condicao += (condicao != "" ? " AND" : "") + " Nome Like @Nome";
            
            pesquisarProduto.Nome = pesquisarProduto.Nome == "" ? $"%{pesquisarProduto.Nome}%" : pesquisarProduto.Nome;

            if (pesquisarProduto.FK_Categoria > 0) 
            {
                condicao += (condicao != "" ? " AND" : "") + "  FK_Categoria = @FK_Categoria";
            }

            sql = "SELECT * FROM Produto WHERE " + condicao;

            using (SqlConnection connection = new SqlConnection(conexao))
            {
                connection.Open();
                return connection.Query<Produto>(sql, pesquisarProduto);
            }
        }
    }
}
