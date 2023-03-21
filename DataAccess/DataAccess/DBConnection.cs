using Microsoft.Data.SqlClient;


namespace DataAccess.DataAccess
{
    public class DBConnection
    {
        public static SqlConnectionStringBuilder _connectionStringBuilder = new()
        {
            DataSource = "",
            InitialCatalog = "",
            UserID = "",
            Password = "",
            Encrypt = false
        };
    }
}
