using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using GEHS.Poc.Data;

namespace GEHS.Poc.WebApi.Controllers
{
    /// <summary>
    /// Manages Logins
    /// </summary>
    [EnableCors("*", "*", "*")]
    public class LoginController : ApiController
    {
        /// <summary>
        /// Get Logins
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Login>> Get()
        {
            var loginRepository = new LoginRepository();
            var logins = await loginRepository.GetLogins();
            return logins;
            //var login1 = new Login() { DomainUserId = 1};
            //var login2 = new Login() { DomainUserId = 2};
            //return new List<Login> {login1, login2};
        }

        // GET api/login/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/login
        public void Post([FromBody]string value)
        {

        }

        // PUT api/login/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/login/5
        public void Delete(int id)
        {
        }
    }
}
