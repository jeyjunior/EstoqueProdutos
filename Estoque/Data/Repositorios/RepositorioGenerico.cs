using Dapper;
using EP.Data.sql;
using EstoqueProdutos.Interfaces;
using System.Data.SqlClient;

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

        public virtual IEnumerable<T> ConsultarDadosNaTabela(T filtro)
        {
            using (SqlConnection connection = new SqlConnection(conexao))
            {
                connection.Open();

                string nomeTabela = typeof(T).Name;
                var propriedades = typeof(T).GetProperties();
                List<string> whereConditions = new List<string>();
                DynamicParameters parameters = new DynamicParameters();

                foreach (var propriedade in propriedades)
                {
                    var valorPropriedade = propriedade.GetValue(filtro);

                    if (propriedade.Name != $"PK_{nomeTabela}" && valorPropriedade != null)
                    {
                        if (propriedade.PropertyType == typeof(string))
                        {
                            // Se for uma string, usamos LIKE
                            whereConditions.Add($"{propriedade.Name} LIKE @{propriedade.Name}");
                            parameters.Add($"@{propriedade.Name}", "%" + valorPropriedade + "%");
                        }
                        else
                        {
                            // Para outros tipos, usamos igualdade (=)
                            whereConditions.Add($"{propriedade.Name} = @{propriedade.Name}");
                            parameters.Add($"@{propriedade.Name}", valorPropriedade);
                        }
                    }
                }

                if (whereConditions.Any())
                {
                    string whereClause = string.Join(" AND ", whereConditions);
                    string sql = $"SELECT * FROM {nomeTabela} WHERE {whereClause}";
                    return connection.Query<T>(sql, parameters);
                }
                else
                {
                    string sql = $"SELECT * FROM {nomeTabela}";
                    return connection.Query<T>(sql);
                }
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

        public virtual bool ExcluirDadosDaTabela(object id)
        {
            using (SqlConnection connection = new SqlConnection(conexao))
            {
                connection.Open();

                string nomeTabela = typeof(T).Name;
                string primaryKeyName = $"PK_{nomeTabela}";
                string sql = $"DELETE FROM {nomeTabela} WHERE {primaryKeyName} = @Id";

                var parameters = new { Id = id };

                var resultado = connection.Execute(sql, parameters);
                return Convert.ToBoolean(resultado);
            }
        }

        public virtual bool AtualizarDadosComValores(T entity)
        {
            using (SqlConnection connection = new SqlConnection(conexao))
            {
                connection.Open();

                string nomeTabela = typeof(T).Name;
                var propriedades = typeof(T).GetProperties();

                List<string> setStatements = new List<string>();
                DynamicParameters parameters = new DynamicParameters();

                foreach (var propriedade in propriedades)
                {
                    if (propriedade.Name != $"PK_{nomeTabela}")
                    {
                        var valorPropriedade = propriedade.GetValue(entity);
                        if (valorPropriedade != null && !string.IsNullOrEmpty(valorPropriedade.ToString()))
                        {
                            setStatements.Add($"{propriedade.Name} = @{propriedade.Name}");
                            parameters.Add($"@{propriedade.Name}", valorPropriedade);
                        }
                    }
                }

                if (setStatements.Count > 0)
                {
                    string setClause = string.Join(", ", setStatements);
                    string primaryKeyName = $"PK_{nomeTabela}";
                    var primaryKeyValue = typeof(T).GetProperty(primaryKeyName).GetValue(entity);
                    string sql = $"UPDATE {nomeTabela} \n" +
                                 $"SET {setClause}     \n" +
                                 $"WHERE {primaryKeyName} = @{primaryKeyName}";

                    parameters.Add($"@{primaryKeyName}", primaryKeyValue);

                    var resultado = connection.Execute(sql, parameters);
                    return Convert.ToBoolean(resultado);
                }
                else
                {
                    // Não há nada para atualizar
                    return false;
                }
            }
        }

        public virtual bool AtualizarTodosOsDados(T entity)
        {
            using (SqlConnection connection = new SqlConnection(conexao))
            {
                connection.Open();

                string nomeTabela = typeof(T).Name;
                var propriedades = typeof(T).GetProperties();

                List<string> setStatements = new List<string>();
                DynamicParameters parameters = new DynamicParameters();

                foreach (var propriedade in propriedades)
                {
                    if (propriedade.Name != $"PK_{nomeTabela}")
                    {
                        var valorPropriedade = propriedade.GetValue(entity);
                        setStatements.Add($"{propriedade.Name} = @{propriedade.Name}");
                        parameters.Add($"@{propriedade.Name}", valorPropriedade);
                    }
                }

                if (setStatements.Count > 0)
                {
                    string setClause = string.Join(", ", setStatements);
                    string primaryKeyName = $"PK_{nomeTabela}";
                    var primaryKeyValue = typeof(T).GetProperty(primaryKeyName).GetValue(entity);
                    string sql = $"UPDATE {nomeTabela} \n" +
                                 $"SET {setClause}     \n" +
                                 $"WHERE {primaryKeyName} = @{primaryKeyName}";

                    parameters.Add($"@{primaryKeyName}", primaryKeyValue);

                    var resultado = connection.Execute(sql, parameters);
                    return Convert.ToBoolean(resultado);
                }
                else
                {
                    // Não há nada para atualizar
                    return false;
                }
            }
        }
    }
}
