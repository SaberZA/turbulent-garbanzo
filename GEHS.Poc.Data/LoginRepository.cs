using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace GEHS.Poc.Data
{
    public class LoginRepository
    {
        private string _connectionString = "Data Source=gehs-poc.database.windows.net;Initial Catalog=Gehs-poc;Integrated Security=False;User ID=gehs_reader;Password=Durb@n2015;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public IEnumerable<Login> GetLogins()
        {
            IEnumerable<Login> logins;
            using (var conn = new SqlConnection(_connectionString))
            {
                logins = conn.Query<Login>("select * from dbo.Login");
            }
            return logins;
        }
    }
}
