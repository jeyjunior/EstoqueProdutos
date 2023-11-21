using Dapper;
using EP.Data.Interfaces;
using EstoqueProdutos.Entidades;
using System.Data.SqlClient;
using System.Drawing;

namespace EstoqueProdutos.Repositorios
{
    public class ProdutoRepositorio : RepositorioGenerico<Produto>, IProdutoRepositorio
    {
        public IEnumerable<Produto> ObterProduto(PesquisaProdutoSimples pesquisarProduto)
        {
            string sql = "";
            string where = "WHERE "; 
            string condicao = "";

            if (pesquisarProduto.PK_Produto > 0 )
            {
                condicao += (condicao != "" ? " AND" : "") + " Produto.PK_Produto = @PK_Produto\n";
            }

            if (pesquisarProduto.Nome.Length > 0) 
            { 
                condicao += (condicao != "" ? " AND" : "") + " Produto.Nome Like @Nome\n";
            }

            if (pesquisarProduto.Descricao.Length > 0)
            {
                condicao += (condicao != "" ? " AND" : "") + " Produto.Descricao Like @Descricao\n";
            }
            
            if (pesquisarProduto.FK_Marca > 0)
            {
                condicao += (condicao != "" ? " AND" : "") + "  FK_Marca = @FK_Marca\n";
            }

            if (pesquisarProduto.FK_Embalagem > 0)
            {
                condicao += (condicao != "" ? " AND" : "") + "  FK_Embalagem = @FK_Embalagem\n";
            }

            if (pesquisarProduto.FK_Formato > 0)
            {
                condicao += (condicao != "" ? " AND" : "") + "  FK_Formato = @FK_Formato\n";
            }

            if (pesquisarProduto.FK_Categoria > 0) 
            {
                condicao += (condicao != "" ? " AND" : "") + "  FK_Categoria = @FK_Categoria\n";
            }

            sql = "" +
               "SELECT\n" +
               "       Produto.*,\n" +
               "       Categoria.*,\n" +
               "       Formato.*,\n" +
               "       Marca.*,\n" +
               "       Embalagem.*,\n" +
               "       UnidadeMedida.*\n" +
               "FROM Produto\n" +
               "       INNER JOIN Categoria ON Categoria.PK_Categoria = Produto.FK_Categoria\n" +
               "       INNER JOIN Formato ON Formato.PK_Formato = Produto.FK_Formato\n" +
               "       INNER JOIN Marca ON Marca.PK_Marca = Produto.FK_Marca\n" +
               "       INNER JOIN Embalagem ON Embalagem.PK_Embalagem = Produto.FK_Embalagem\n" +
               "       INNER JOIN UnidadeMedida ON UnidadeMedida.PK_UnidadeMedida = Produto.FK_UnidadeMedida\n" +
               " " + (condicao != "" ? where + condicao : "");


            using (SqlConnection connection = new SqlConnection(conexao))
            {
                connection.Open();
                return connection.Query<Produto, Categoria, Formato, Marca,Embalagem, UnidadeMedida, Produto>(
                    sql: sql, 
                    map: (produto, categoria, formato, marca, embalagem, unidadeMedida) => 
                    {
                        produto.Categoria = categoria;
                        produto.Formato = formato;
                        produto.Marca = marca;
                        produto.Embalagem = embalagem;  
                        produto.UnidadeMedida = unidadeMedida;
                        return produto;
                    }, 
                    pesquisarProduto,
                    splitOn: "PK_Categoria, PK_Formato, PK_Marca, PK_Embalagem, PK_UnidadeMedida"); //,FK_Formato,FK_Marca,FK_Embalagem
            }
        }

        public bool InserirDados(Produto produto)
        {
            string sql =    "IF NOT EXISTS( \n" +
                            "    SELECT 1 \n" +
                            "    FROM Produto \n" +
                            "    WHERE Nome = @Nome  \n" +
                            "    AND FK_Categoria = @FK_Categoria \n" +
                            "    AND FK_Embalagem = @FK_Embalagem \n" +
                            "    AND FK_Formato = @FK_Formato \n" +
                            "    AND FK_Marca = @FK_Marca \n" +
                            ") \n" +
                            "BEGIN \n" +
                            "    INSERT INTO[dbo].[Produto] \n" +
                            "            ([Nome], [Volume], [Descricao], [DataFabricacao], [DataValidade], [Altura], [Largura], [Comprimento], [FK_Formato], [FK_Imagem], [FK_Categoria], [FK_Marca], [FK_Embalagem], [FK_UnidadeMedida]) \n" +
                            "    VALUES \n" +
                            "    (@Nome, @Volume, @Descricao, @DataFabricacao, @DataValidade, @Altura, @Largura, @Comprimento, @FK_Formato, @FK_Imagem, @FK_Categoria, @FK_Marca, @FK_Embalagem, @FK_UnidadeMedida); \n" +
                            "END";

            using (SqlConnection connection = new SqlConnection(conexao))
            {
                connection.Open();
                int rowsAffected = connection.Execute(sql, produto);

                return rowsAffected > 0;
            }
        }
    }
}

