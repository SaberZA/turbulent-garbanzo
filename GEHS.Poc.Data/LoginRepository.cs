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
        private string _connectionString = "Data Source=gehs-poc.database.windows.net;Initial Catalog=Gehs-poc;Integrated Security=False;User ID=gehs_reader;Password=Durb@n2015;Connect Timeout=15;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public async Task<IEnumerable<Login>> GetLogins()
        {
            IEnumerable<Login> logins;
            using (var conn = new SqlConnection(_connectionString))
            {
                logins = await conn.QueryAsync<Login>("select * from dbo.Login");
            }
            return logins;
        }
    }
}
