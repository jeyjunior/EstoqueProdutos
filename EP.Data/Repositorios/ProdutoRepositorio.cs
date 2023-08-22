using Dapper;
using EP.Data.Interfaces;
using EstoqueProdutos.Formatacao;
using EstoqueProdutos.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;

namespace EstoqueProdutos.Repositorios
{
    public class ProdutoRepositorio : Repositorio<Produto>, IProdutoRepositorio
    {
        public IEnumerable<Produto> ObterProduto(PesquisaProdutoSimples pesquisarProduto)
        {
            string sql = "";
            string where = "WHERE "; 

            string condicao = "";

            if (pesquisarProduto.Nome != "") 
            { 
                condicao += (condicao != "" ? " AND" : "") + " Produto.Nome Like @Nome\n";
            }

            if (pesquisarProduto.Descricao != "")
            {
                condicao += (condicao != "" ? " AND" : "") + " Produto.Descricao Like @Descricao\n";
            }
            
            if (pesquisarProduto.FK_Marca > 0)
            {
                condicao += (condicao != "" ? " AND" : "") + "  FK_Marca = @FK_Marca\n";
            }

            if (pesquisarProduto.FK_Embalagem > 0)
            {
                condicao += (condicao != "" ? " AND" : "") + "  FK_Embalagem = @FK_Embalagem\n";
            }

            if (pesquisarProduto.FK_Formato > 0)
            {
                condicao += (condicao != "" ? " AND" : "") + "  FK_Formato = @FK_Formato\n";
            }

            if (pesquisarProduto.FK_Categoria > 0) 
            {
                condicao += (condicao != "" ? " AND" : "") + "  FK_Categoria = @FK_Categoria\n";
            }

            sql = "" +
               "SELECT\n" +
               "       Produto.*,\n" +
               "       Categoria.*,\n" +
               "       Formato.*,\n" +
               "       Marca.*,\n" +
               "       Embalagem.*\n" +
               "FROM Produto\n" +
               "       INNER JOIN Categoria ON Categoria.PK_Categoria = Produto.FK_Categoria\n" +
               "       INNER JOIN Formato ON Formato.PK_Formato = Produto.FK_Formato\n" +
               "       INNER JOIN Marca ON Marca.PK_Marca = Produto.FK_Marca\n" +
               "       INNER JOIN Embalagem ON Embalagem.PK_Embalagem = Produto.FK_Embalagem\n" +
               " " + (condicao != "" ? where + condicao : "");


            using (SqlConnection connection = new SqlConnection(conexao))
            {
                connection.Open();
                return connection.Query<Produto, Categoria, Formato,Marca,Embalagem, Produto>(
                    sql: sql, 
                    map: (produto, categoria, formato, marca, embalagem) => 
                    {
                        produto.Categoria = categoria;
                        produto.Formato = formato;
                        produto.Marca = marca;
                        produto.Embalagem = embalagem;  
                        return produto;
                    }, 
                    pesquisarProduto,
                    splitOn: "PK_Categoria, PK_Formato, PK_Marca, PK_Embalagem"); //,FK_Formato,FK_Marca,FK_Embalagem
            }
        }
    }
}

