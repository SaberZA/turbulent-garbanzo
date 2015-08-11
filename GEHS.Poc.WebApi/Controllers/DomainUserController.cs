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
    [EnableCors("*","*","*")]
    public class DomainUserController : ApiController
    {
        // GET api/domainuser
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Get Domain User
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DomainUser Get(int id)
        {
            return new DomainUserRepository().FindDomainUser(id);
        }

        // POST api/domainuser
        public void Post([FromBody]string value)
        {
        }

        // PUT api/domainuser/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/domainuser/5
        public void Delete(int id)
        {
        }
    }
}
