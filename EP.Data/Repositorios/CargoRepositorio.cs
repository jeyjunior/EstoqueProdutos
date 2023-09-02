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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace EstoqueProdutos.Repositorios
{
    public class CargoRepositorio : ICargoRepositorio
    {
        public virtual IEnumerable<Cargo> ObterTabela()
        {
            return ObterTabela(null);
        }
        public virtual IEnumerable<Cargo> ObterTabela(Cargo cargo)
        {
            string sql = "";
            string where = "";
            string condicao = "";

            if (cargo != null)
            {
                if(cargo.NomeCargo != "")
                {
                    condicao += (condicao != "" ? " AND" : "") + " Cargo.NomeCargo Like @NomeCargo\n";
                }

                if (cargo != null && cargo.FK_Setor > 0)
                {
                    condicao += (condicao != "" ? " AND" : "") + " Cargo.FK_Setor = @FK_Setor\n";
                }
            }

            sql = "" +
                "SELECT \n" +
                "       Cargo.*,  \n" +
                "       Setor.* \n" +
                "FROM Cargo \n" +
                "INNER JOIN     Setor \n" +
                "      ON       Setor.PK_Setor = Cargo.FK_Setor \n";
            where = condicao != "" ? "WHERE " : "";

            sql = sql + where + condicao;

            using (SqlConnection connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();
                return connection.Query<Cargo, Setor, Cargo>(
                    sql: sql,
                    map: (cargo, setor) =>
                    {
                        cargo.Setor = setor;
                        return cargo;
                    },
                    cargo,
                    splitOn: "PK_Cargo, FK_Setor"); 
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
                    "SET NomeCargo = @NomeCargo, FK_Setor = @FK_Setor\n" +
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
                    "WHERE PK_Cargo = @PK_Cargo \n";
                    //"DELETE FROM Setor\n" +
                    //"WHERE PK_Setor = @PK_Setor\n";

                var resultado = connection.Execute(sql, cargo);
                return Convert.ToBoolean(resultado);
            }
        }
    }
}
