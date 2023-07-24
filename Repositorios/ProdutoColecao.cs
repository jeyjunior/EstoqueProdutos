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
using static EstoqueProdutos.Repositorios.ProdutoColecao;

namespace EstoqueProdutos.Repositorios
{
    public class ProdutoColecao : IProdutoRepositorio
    {
        private readonly string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

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

        public Produto ObterProdutoPorId(int id)
        {

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = @"
                SELECT p.*, c.*, f.*, te.*, um.*, i.*
                FROM Produto p
                LEFT JOIN Categoria c ON p.FK_Categoria_ID = c.PK_ID
                LEFT JOIN Fornecedor f ON p.FK_Fornecedor_ID = f.PK_ID
                LEFT JOIN TipoEmbalagem te ON p.FK_TipoEmbalagem_ID = te.PK_ID
                LEFT JOIN UnidadeMedida um ON p.FK_UnidadeMedida_ID = um.PK_ID
                LEFT JOIN Imagens i ON p.FK_Imagem_ID = i.PK_ID
                WHERE p.PK_ID = " + 100;

                var result1 = connection.Query<Produto>(sql);

                var result = connection
                    .Query<Produto, Categoria, Fornecedor, TipoEmbalagem, UnidadeMedida, Imagens, Produto>
                    (sql, (produto, categoria, fornecedor, tipoEmbalagem, unidadeMedida, imagem) =>
                    {
                        produto.FK_Categoria_ID = categoria.PK_ID;
                        produto.FK_Fornecedor_ID = fornecedor.PK_ID;
                        produto.FK_TipoEmbalagem_ID = tipoEmbalagem.PK_ID;
                        produto.FK_UnidadeMedida_ID = unidadeMedida.PK_ID;
                        produto.FK_Imagem_ID = imagem.PK_ID;
                        return produto;
                    },
                    new { ProdutoId = id },
                    splitOn: "PK_ID, Nome, Nome, Nome, Sigla, Nome"
                ).FirstOrDefault();

                return result;
            }
        }

        public Produto ObterProdutoMultiMapPorId(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = @"
                        SELECT p.PK_ID, p.Nome, p.Volume, p.Preco, p.Descricao,
                               c.PK_ID AS Categoria_PK_ID, c.Nome AS Categoria_Nome,
                               f.PK_ID AS Fornecedor_PK_ID, f.Nome AS Fornecedor_Nome,
                               te.PK_ID AS TipoEmbalagem_PK_ID, te.Nome AS TipoEmbalagem_Nome,
                               um.PK_ID AS UnidadeMedida_PK_ID, um.Sigla AS UnidadeMedida_Sigla,
                               i.PK_ID AS Imagem_PK_ID, i.Nome AS Imagem_Nome
                        FROM Produto p
                        LEFT JOIN Categoria c ON p.FK_Categoria_ID = c.PK_ID
                        LEFT JOIN Fornecedor f ON p.FK_Fornecedor_ID = f.PK_ID
                        LEFT JOIN TipoEmbalagem te ON p.FK_TipoEmbalagem_ID = te.PK_ID
                        LEFT JOIN UnidadeMedida um ON p.FK_UnidadeMedida_ID = um.PK_ID
                        LEFT JOIN Imagens i ON p.FK_Imagem_ID = i.PK_ID
                        WHERE p.PK_ID >= @ProdutoId";

                var result = connection.Query(sql, new { ProdutoId = id });

                foreach (var row in result)
                {
                    int PK_ID = (int)row.PK_ID;
                    string Nome = (string)row.Nome;
                    decimal Volume = (decimal)row.Volume;
                    decimal Preco = (decimal)row.Preco;
                    string Descricao = (string)row.Descricao;
                    int Categoria_PK_ID = (int)row.Categoria_PK_ID;
                    string Categoria_Nome = (string)row.Categoria_Nome;
                    int Fornecedor_PK_ID = (int)row.Fornecedor_PK_ID;
                    string Fornecedor_Nome = (string)row.Fornecedor_Nome;
                    int TipoEmbalagem_PK_ID = (int)row.TipoEmbalagem_PK_ID;
                    string TipoEmbalagem_Nome = (string)row.TipoEmbalagem_Nome;
                    int UnidadeMedida_PK_ID = (int)row.UnidadeMedida_PK_ID;
                    string UnidadeMedida_Sigla = (string)row.UnidadeMedida_Sigla;
                    int Imagem_PK_ID = (int)row.Imagem_PK_ID;
                    string Imagem_Nome = (string)row.Imagem_Nome;

                    // Faça o que precisar com os valores acima...
                }

                return new Produto();
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
    }
}
