using System;
using NUnit.Framework;

namespace IosUnitFail.Test
{
    [TestFixture]
    public class SampleTest
    {
        [Test]
        public void TestAdd()
        {
            Assert.AreEqual(2, 1 + 1);
        }

        [Test]
        public void TestRepository()
        {
            var val = new RepositoryCustomer();
            Assert.IsNotNull(val);
        }

        [Test]
        public void TestStubRepository()
        {
            var val = new StubRepositoryCustomer();
            Assert.IsNotNull(val);
        }
    }
}

