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
    public class ConfigColunasProdutoRepositorio : RepositorioGenerico<ConfigColunasProduto>, IConfigColunasProdutoRepositorio
    {

    }
}
