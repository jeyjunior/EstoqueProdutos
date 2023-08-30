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

        public virtual int ObterTotalSetoresRegistrados()
        {
            string sql = "";
            sql = "" +
                "SELECT COUNT(*) AS Total \n" +
                "FROM Setor\n";

            using (var connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();
                return connection.QueryFirstOrDefault<int>(sql);
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
    }
}
