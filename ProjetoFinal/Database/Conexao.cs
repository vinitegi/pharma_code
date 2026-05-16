using Npgsql;

namespace ProjetoFinal.Database
{
    public class Conexao
    {
        private readonly string connectionString =
            "Host=localhost;" +
            "Port=5432;" +
            "Database=FarmaciaDB;" +
            "Username=postgres;" +
            "Password=Vg@261105;";

        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}