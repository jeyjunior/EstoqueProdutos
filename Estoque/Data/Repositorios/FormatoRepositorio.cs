using Dapper;
using EP.Data.Interfaces;
using EP.Data.sql;
using EstoqueProdutos.Entidades;
using System.Data.SqlClient;


namespace EstoqueProdutos.Repositorios
{
    public class FormatoRepositorio : RepositorioGenerico<Formato>, IFormatoRepositorio
    {
        public virtual IEnumerable<Formato> ObterTabela()
        {
            using (var connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();
                string sql = "SELECT * FROM Formato";
                return connection.Query<Formato>(sql);
            }
        }

        public virtual bool InserirDadosNaTabela(Formato formato)
        {
            using (SqlConnection connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();

                string sql = "" +
                    "INSERT INTO Formato\n" +
                    "VALUES (@Nome, @Descricao)\n";

                var resultado = connection.Execute(sql, formato);
                return Convert.ToBoolean(resultado);
            }
        }
    }
}
