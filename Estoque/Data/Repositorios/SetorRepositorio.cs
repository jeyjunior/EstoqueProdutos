using Dapper;
using EP.Data.Entidades;
using EP.Data.Interfaces;
using EP.Data.sql;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public virtual IEnumerable<Setor> ObterTabela(Setor setor)
        {
            string sql = "";
            string where = "";
            string condicao = "";

            if (setor != null && setor.NomeSetor != "")
            {
                condicao += (condicao != "" ? " AND" : "") + " Setor.NomeSetor Like @NomeSetor\n";
            }

            sql = "" +
                "SELECT * \n" +
                "FROM Setor\n";

            where = condicao != "" ? "WHERE " : "";

            using (var connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();
                sql = sql + where + condicao;
                return connection.Query<Setor>(sql, setor);
            }
        }

        public virtual bool InserirDadosNaTabela(Setor setor)
        {
            using (SqlConnection connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();

                string sql = "" +
                    "INSERT INTO Setor\n" +
                    "VALUES (@NomeSetor)\n";

                var resultado = connection.Execute(sql, setor);
                return Convert.ToBoolean(resultado);
            }
        }

        public bool AtualizarSetor(Setor setor)
        {
            using (SqlConnection connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();

                string sql = "" +
                    "UPDATE Setor\n" +
                    "SET NomeSetor = @NomeSetor\n" +
                    "WHERE PK_Setor = @PK_Setor\n";

                var resultado = connection.Execute(sql, setor);
                return Convert.ToBoolean(resultado);
            }
        }

        public bool ExcluirSetor(Setor setor)
        {
            using (SqlConnection connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();

                string sql = "" +
                    "DELETE FROM Cargo\n" +
                    "WHERE FK_Setor = @PK_Setor \n" +
                    "DELETE FROM Setor\n" +
                    "WHERE PK_Setor = @PK_Setor\n";

                var resultado = connection.Execute(sql, setor);
                return Convert.ToBoolean(resultado);
            }
        }
    }
}
