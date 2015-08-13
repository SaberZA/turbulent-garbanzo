using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace GEHS.Poc.Data
{
    public class DomainUserRepository
    {
        private string _connectionString = "Data Source=gehs-poc.database.windows.net;Initial Catalog=Gehs-poc;Integrated Security=False;User ID=gehs_reader;Password=Durb@n2015;Connect Timeout=15;Encrypt=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public DomainUser FindDomainUser(int domainUserId)
        {
            IEnumerable<DomainUser> domainUsers = new List<DomainUser>();
            using (var conn = new SqlConnection(_connectionString))
            {
                domainUsers = conn.Query<DomainUser>("select top 1 * from dbo.DomainUser");
            }
            return domainUsers.FirstOrDefault();
        }
    }
}
