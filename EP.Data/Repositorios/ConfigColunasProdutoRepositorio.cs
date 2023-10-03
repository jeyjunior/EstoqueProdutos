using Dapper;
using EP.Data.Entidades;
using EP.Data.Interfaces;
using EP.Data.sql;
using EstoqueProdutos.Entidades;
using EstoqueProdutos.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace EstoqueProdutos.Repositorios
{
    public class ConfigColunasProdutoRepositorio : RepositorioGenerico<ConfigColunasProduto>, IConfigColunasProdutoRepositorio
    {
        public IEnumerable<ConfigColunasProduto> ObterTabela(int FK_Usuario)
        {
            string sql = "IF NOT EXISTS(SELECT 1 FROM ConfigColunasProduto WHERE FK_Usuario = @FK_Usuario) \n" +
                         "BEGIN   \n" +
                         "    INSERT INTO ConfigColunasProduto(FK_Usuario, Nome, Volume, Descricao, Altura, Largura, Comprimento, Formato, Imagem, Categoria, Marca, Embalagem, UnidadeMedida) \n" +
                         "    VALUES(@FK_Usuario, 1, 0, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0) \n" +
                         "END \n" +
                         "SELECT* \n" +
                         "FROM ConfigColunasProduto \n" +
                         "WHERE FK_Usuario = @FK_Usuario;";

            using (SqlConnection connection = new SqlConnection(conexao))
            {
                connection.Open();
                return connection.Query<ConfigColunasProduto>(sql, new { FK_Usuario = FK_Usuario });
            }
        }

        public bool AtualizarConfiguracao(ConfigColunasProduto configColunasProduto) 
        {
            string sql = "" +
                "UPDATE ConfigColunasProduto\n" +
                "SET    Nome = @Nome,\n" +
                "       Volume = @Volume,\n " +
                "       Descricao = @Descricao,\n " +
                "       Altura = @Altura,\n " +
                "       Largura = @Largura,\n " +
                "       Comprimento = @Comprimento,\n " +
                "       Formato = @Formato,\n " +
                "       Imagem = @Imagem,\n " +
                "       Categoria = @Categoria,\n " +
                "       Marca = @Marca,\n " +
                "       Embalagem = @Embalagem,\n " +
                "       UnidadeMedida = @UnidadeMedida\n" +
                "WHERE  FK_Usuario = @FK_Usuario;";

            using (SqlConnection connection = new SqlConnection(Conexao.ConexaoBase))
            {
                connection.Open();

                var resultado = connection.Execute(sql, configColunasProduto);
                return Convert.ToBoolean(resultado);
            }
        }
    }
}
