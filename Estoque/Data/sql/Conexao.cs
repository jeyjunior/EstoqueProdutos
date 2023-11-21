namespace EP.Data.sql
{
    internal class Conexao
    {
        private readonly static string connectionString = "Data Source=JEYJR;Initial Catalog=EstoqueProduto;Integrated Security=True;TrustServerCertificate=True;";

        public static string ConexaoBase => connectionString;
    }
}
