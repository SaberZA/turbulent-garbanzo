using System;
using GEHS.Poc.Data;
using NUnit.Framework;

namespace GEHS.Poc.Test
{
    [TestFixture]
    public class TestDomainUserRepository
    {
        [Test]
        public void FindDomainUser_GivenUserId_ShouldReturnDomainUser()
        {
            //---------------Set up test pack-------------------
            var userid = 1;
            var domainUserRepository = new DomainUserRepository();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var domainUser = domainUserRepository.FindDomainUser(userid);
            //---------------Test Result -----------------------
            Assert.IsNotNull(domainUser);
            Assert.AreEqual("Steven",domainUser.FirstName);
        }
    }
}
