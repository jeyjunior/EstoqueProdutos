using Dapper;
using EP.Data.Entidades;
using EP.Data.Interfaces;
using EP.Data.sql;
using EstoqueProdutos.Entidades;
using EstoqueProdutos.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProdutos.Repositorios
{
    public class CargoRepositorio : ICargoRepositorio
    {
        public virtual IEnumerable<Cargo> ObterTabela()
        {
            using (var connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();
                string sql = "SELECT * FROM Cargo";
                return connection.Query<Cargo>(sql);
            }
        }

        public virtual bool InserirDadosNaTabela(Cargo cargo)
        {
            using (SqlConnection connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();

                string sql = "" +
                    "INSERT INTO Cargo\n" +
                    "VALUES (@NomeCargo, @FK_Setor, @Descricao)\n";

                var resultado = connection.Execute(sql, cargo);
                return Convert.ToBoolean(resultado);
            }
        }
    }
}
