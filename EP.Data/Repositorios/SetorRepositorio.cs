using Dapper;
using EP.Data.Entidades;
using EP.Data.Interfaces;
using EP.Data.sql;
using EstoqueProdutos.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProdutos.Repositorios
{
    public class SetorRepositorio : ISetorRepositorio
    {
        public virtual IEnumerable<Setor> ObterTabela()
        {
            using (var connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();
                string sql = "SELECT * FROM Setor";
                return connection.Query<Setor>(sql);
            }
        }

        public virtual bool InserirDadosNaTabela(Setor setor)
        {
            using (SqlConnection connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();

                string sql = "" +
                    "INSERT INTO Setor\n" +
                    "VALUES (@NomeSetor, @Descricao)\n";

                var resultado = connection.Execute(sql, setor);
                return Convert.ToBoolean(resultado);
            }
        }
    }
}
