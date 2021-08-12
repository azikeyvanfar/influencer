using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace EndPoint.WebUI
{
    public interface IDbConnection
    {
        public SqlConnection GetConnection { get; }
    }
    public class DbConnection : IDbConnection
    {
        IConfiguration Configuration;

        public DbConnection(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public SqlConnection GetConnection
        {
            get
            {
                var connectionString = Configuration.GetConnectionString("DefaultConnection");
                return new SqlConnection(connectionString);
            }
        }
    }
}
