using Dapper;
using EstoqueProdutos.Entidades;
using EstoqueProdutos.Interfaces;
using SqlData.Core.CommonSql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EstoqueProdutos.Entidades.Produto;
using static EstoqueProdutos.Repositorios.ProdutoColecao;

namespace EstoqueProdutos.Repositorios
{
    public class ProdutoColecao : IProdutoRepositorio
    {
        private readonly string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public string SelectBasico()
        {
            string sql = "" +
                    " SELECT" +
                    "   Produto.*, Categoria.*, Fornecedor.*, TipoEmbalagem.*, UnidadeMedida.*, Imagem.*" +
                     "FROM " +
                    "    Produto" +
                    " LEFT JOIN Categoria ON Produto.FK_Categoria = Categoria.PK_Categoria" +
                    " LEFT JOIN Fornecedor ON Produto.FK_Fornecedor = Fornecedor.PK_Fornecedor" +
                    " LEFT JOIN TipoEmbalagem ON Produto.FK_TipoEmbalagem = TipoEmbalagem.PK_TipoEmbalagem" +
                    " LEFT JOIN UnidadeMedida ON Produto.FK_UnidadeMedida = UnidadeMedida.PK_UnidadeMedida" +
                    " LEFT JOIN Imagem ON Produto.FK_Imagem = Imagem.PK_Imagem";

            return sql;
        }

        public ProdutoColecao()
        {
        }

        public void AtualizarProduto(Produto produto)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "UPDATE Produtos SET NOME = @Nome, VALOR = @Valor, DESCRICAO = @Descricao, ATIVO = @Ativo WHERE PK_ID = @Id";
                connection.Execute(sql, produto);
            }
        }

        public void ExcluirProduto(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "DELETE FROM Produtos WHERE PK_ID = @Id";
                connection.Execute(sql, new { Id = id });
            }
        }

        public void InserirProduto(Produto produto)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Produtos (NOME, VALOR, DESCRICAO, ATIVO) VALUES (@Nome, @Valor, @Descricao, @Ativo)";
                connection.Execute(sql, produto);
            }
        }

        public IEnumerable<Produto> ObterLista(string personalizado)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM Produtos WHERE " + personalizado;
                return connection.Query<Produto>(sql);
            }
        }

        public IEnumerable<Produto> ObterTodosProdutos()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM Produtos";
                return connection.Query<Produto>(sql);
            }
        }

        public Produto ObterProdutoPorId(ProdutoPesquisarPorID produtoPesquisaPorID)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string condition = "";
                string sql = SelectBasico();

                condition = " WHERE Produto.PK_Produto = @PK_Produto";

                sql = sql + condition;

                // Utilize a opção "splitOn" para informar ao Dapper qual campo usar para separar os objetos mapeados
                var result = connection.Query<Produto, Categoria, Fornecedor, TipoEmbalagem, UnidadeMedida, Imagem, Produto>(
                    sql,
                    (produto, categoria, fornecedor, tipoEmbalagem, unidadeMedida, imagem) =>
                    {
                        produto.tblCategoria = categoria;
                        produto.tblFornecedor = fornecedor;
                        produto.tblTipoEmbalagem = tipoEmbalagem;
                        produto.tblUnidadeMedida = unidadeMedida;
                        produto.tblImagem = imagem;
                        return produto;
                    },
                    produtoPesquisaPorID,
                    splitOn: "PK_Produto, PK_Categoria, PK_Fornecedor, PK_TipoEmbalagem, PK_UnidadeMedida, PK_Imagem"
                );

                return result.FirstOrDefault(); // Retorna o primeiro objeto do resultado, ou null se não houver resultados.
            }
        }
    }
}
