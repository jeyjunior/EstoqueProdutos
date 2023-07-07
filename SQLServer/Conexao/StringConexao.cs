using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProdutos.SQLServer.Conexao
{
    public class StringConexao
    {
        private static string autenticacaoWindows = "Data Source=JEY\\JEYJR;Initial Catalog=EstoqueProdutos;Integrated Security=True;";

        public static string Conexao
        {
            get
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(autenticacaoWindows);
                builder.TrustServerCertificate = true;

                return builder.ConnectionString;
            }
        }
    }
}
