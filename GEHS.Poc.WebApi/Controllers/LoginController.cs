using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using GEHS.Poc.Data;

namespace GEHS.Poc.WebApi.Controllers
{
    [EnableCors("*", "*", "*")]
    public class LoginController : ApiController
    {
        /// <summary>
        /// Get Logins
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Login> Get()
        {
            var loginRepository = new LoginRepository();
            return loginRepository.GetLogins();
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
