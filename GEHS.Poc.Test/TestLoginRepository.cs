﻿using System.Linq;
using GEHS.Poc.Data;
using NUnit.Framework;

namespace GEHS.Poc.Test
{
    [TestFixture]
    public class TestLoginRepository
    {
        [Test]
        public async void GetLogins_GivenNothing_ShouldReturnLoginList()
        {
            //---------------Set up test pack-------------------
            var loginRepository = new LoginRepository();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var logins = await loginRepository.GetLogins();
            //---------------Test Result -----------------------
            Assert.IsNotNull(logins);
            Assert.IsTrue(logins.Any());
        }
    }
}
