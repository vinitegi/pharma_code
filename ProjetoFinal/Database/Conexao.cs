using System.Data.SqlClient;

namespace ProjetoFinal.Database
{
    public class Conexao
    {
        private string connectionString =
            "Server=localhost;Database=FarmaciaDB;Trusted_Connection=True;"; //muda isso aq vitao

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}