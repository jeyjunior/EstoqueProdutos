namespace EP.Data.sql
{
    internal class Conexao
    {
        private readonly static string connectionString = "Data Source=JEYJUNIOR\\SQLEXPRESS;Initial Catalog=Estoque;Integrated Security=True;TrustServerCertificate=True;";

        public static string ConexaoBase => connectionString;
    }
}
