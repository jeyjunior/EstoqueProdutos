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
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        public virtual IEnumerable<Categoria> ObterTabela()
        {
            using (var connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();
                string sql = "SELECT * FROM Categoria";
                return connection.Query<Categoria>(sql);
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
