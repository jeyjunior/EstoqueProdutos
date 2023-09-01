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

        public virtual IEnumerable<Cargo> ObterTabela(Cargo cargo)
        {
            string sql = "";
            string where = "";
            string condicao = "";

            if (cargo != null && cargo.NomeCargo != "")
            {
                condicao += (condicao != "" ? " AND" : "") + " Cargo.NomeCargo Like @NomeCargo\n";
            }

            if (cargo != null && cargo.FK_Setor > 0)
            {
                condicao += (condicao != "" ? " AND" : "") + " Cargo.FK_Setor = @FK_Setor\n";
            }

            sql = "" +
                "SELECT * \n" +
                "FROM Cargo\n";

            where = condicao != "" ? "WHERE " : "";

            using (var connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();
                sql = sql + where + condicao;
                return connection.Query<Cargo>(sql, cargo);
            }
        }

        public virtual bool InserirDadosNaTabela(Cargo cargo)
        {
            using (SqlConnection connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();

                string sql = "" +
                    "INSERT INTO Cargo\n" +
                    "VALUES (@NomeCargo, @FK_Setor)\n";

                var resultado = connection.Execute(sql, cargo);
                return Convert.ToBoolean(resultado);
            }
        }


        public virtual int ObterTotalCargosRegistrados()
        {
            string sql = "";
            sql = "" +
                "SELECT COUNT(*) AS Total \n" +
                "FROM Cargo\n";

            using (var connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();
                return connection.QueryFirstOrDefault<int>(sql);
            }
        }

        public bool AtualizarCargo(Cargo cargo)
        {
            using (SqlConnection connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();

                string sql = "" +
                    "UPDATE Cargo\n" +
                    "SET NomeCargo = @NomeCargo\n" +
                    "WHERE PK_Cargo = @PK_Cargo\n";

                var resultado = connection.Execute(sql, cargo);
                return Convert.ToBoolean(resultado);
            }
        }

        public bool ExcluirCargo(Cargo cargo)
        {
            using (SqlConnection connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();

                string sql = "" +
                    "DELETE FROM Cargo\n" +
                    "WHERE FK_Cargo = @PK_Cargo \n";
                    //"DELETE FROM Setor\n" +
                    //"WHERE PK_Setor = @PK_Setor\n";

                var resultado = connection.Execute(sql, cargo);
                return Convert.ToBoolean(resultado);
            }
        }
    }
}
