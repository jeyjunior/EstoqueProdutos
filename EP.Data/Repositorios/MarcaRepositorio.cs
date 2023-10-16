using Dapper;
using EP.Data.Interfaces;
using EP.Data.sql;
using EstoqueProdutos.Entidades;
using EstoqueProdutos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace EstoqueProdutos.Repositorios
{
    public class MarcaRepositorio : RepositorioGenerico<Marca>, IMarcaRepositorio
    {
        public virtual IEnumerable<Marca> ObterTabela()
        {
            using (var connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();
                string sql = "SELECT * FROM Marca";
                return connection.Query<Marca>(sql); 
            }
        }

        public virtual bool InserirDadosNaTabela(Marca marca)
        {
            using (SqlConnection connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();

                string sql = "" +
                    "INSERT INTO Marca\n" +
                    "VALUES (@Nome, @Descricao)\n";

                var resultado = connection.Execute(sql, marca);
                return Convert.ToBoolean(resultado);
            }
        }
    }
}
