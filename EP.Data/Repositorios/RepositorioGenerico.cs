﻿using Dapper;
using EP.Data.sql;
using EstoqueProdutos.Interfaces;
using Microsoft.Data.SqlClient;

namespace EstoqueProdutos.Repositorios
{
    /// <summary>
    /// Fornecer os metodos base para consultas na base de dados
    /// </summary>
    /// <typeparam name="T">Entidade Repositorio </typeparam>
    public partial class RepositorioGenerico<T> : IRepositorio<T>
    {
        protected readonly string conexao = Conexao.ConexaoBase;
        public virtual IEnumerable<T> ObterTabela()
        {
            using (SqlConnection connection = new SqlConnection(conexao))
            {
                connection.Open();
                string sql = $"SELECT * FROM {typeof(T).Name}";
                IEnumerable<T> resultado = connection.Query<T>(sql);
                return resultado;
            }
        }
        public virtual bool ValidarValorExistente(string coluna, dynamic valor)
        {
            if (coluna == "" || valor  == null) 
            {
                throw new Exception("Não foi possível validar valores existente devido a coluna ou valor estarem inválidos!");
                return false;
            }

            using (SqlConnection connection = new SqlConnection(conexao))
            {
                connection.Open();
                string sql = $"SELECT * FROM {typeof(T).Name} WHERE {coluna} = '{valor}'";
                var resultado = connection.QueryFirstOrDefault<bool>(sql);
                return resultado;
            }
        }
        public virtual int ObterContagemTotal(string nomeEntidade)
        {
            if(nomeEntidade != "")
            {
                string sql = "SELECT COUNT(*) AS Total FROM " + nomeEntidade;

                using (var connection = new SqlConnection(Conexao.ConexaoBase))
                {
                    connection.Open();
                    return connection.QueryFirstOrDefault<int>(sql);
                }
            }
            else
            {
                return 0;
            }
        }

        public virtual int ObterContagemTotal()
        {
            if (typeof(T).Name != "")
            {
                string sql = "SELECT COUNT(*) AS Total FROM " + typeof(T).Name;

                using (var connection = new SqlConnection(Conexao.ConexaoBase))
                {
                    connection.Open();
                    return connection.QueryFirstOrDefault<int>(sql);
                }
            }
            else
            {
                return 0;
            }
        }
        public virtual bool InserirDadosNaTabela(T entity)
        {
            using (SqlConnection connection = new SqlConnection(conexao))
            {
                connection.Open();

                string nomeTabela = typeof(T).Name;
                var propriedades = typeof(T).GetProperties();

                List<string> parametros = new List<string>();

                foreach (var propriedade in propriedades)
                {
                    if(propriedade.Name != $"PK_{nomeTabela}") 
                    { 
                        parametros.Add($"@{propriedade.Name}");
                    }
                }

                string parametrosStr = string.Join(", ", parametros);
                string sql = $"INSERT INTO {nomeTabela} VALUES ({parametrosStr})";
                var resultado = connection.Execute(sql, entity);
                return Convert.ToBoolean(resultado);
            }
        }
    }
}
