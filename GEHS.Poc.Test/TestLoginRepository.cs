using System.Linq;
using GEHS.Poc.Data;
using NUnit.Framework;

namespace GEHS.Poc.Test
{
    [TestFixture]
    public class TestLoginRepository
    {
        [Test]
        public void GetLogins_GivenNothing_ShouldReturnLoginList()
        {
            //---------------Set up test pack-------------------
            var loginRepository = new LoginRepository();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var logins = loginRepository.GetLogins();
            //---------------Test Result -----------------------
            Assert.IsNotNull(logins);
            Assert.IsTrue(logins.Any());
        }
    }
}
