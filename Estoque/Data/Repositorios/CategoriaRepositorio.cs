using Dapper;
using EP.Data.Interfaces;
using EP.Data.sql;
using EstoqueProdutos.Entidades;
using System.Data.SqlClient;

namespace EstoqueProdutos.Repositorios
{
    public class CategoriaRepositorio : RepositorioGenerico<Categoria>, ICategoriaRepositorio
    {
        public virtual IEnumerable<Categoria> ObterTabela(Categoria categoria)
        {
            string sql = "";
            string condicao = "";

            condicao = "  WHERE     Categoria.Nome Like @Nome \n";
            condicao += " AND       Categoria.Descricao Like @Descricao \n";

            sql = "SELECT * FROM Categoria\n" + condicao;

            using (var connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();
                return connection.Query<Categoria>(sql, categoria);
            }
        }
        public virtual bool InserirDadosNaTabela(Categoria categoria)
        {
            using (SqlConnection connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();

                string sql = "" +
                    "INSERT INTO Categoria\n" +
                    "VALUES (@Nome, @Descricao)\n";

                var resultado = connection.Execute(sql, categoria);
                return Convert.ToBoolean(resultado);
            }
        }
    }
}
