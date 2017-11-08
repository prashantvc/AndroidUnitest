using System;
using NUnit.Framework;


namespace UnitTestApp1
{
    [TestFixture]
    public class TestsSample
    {

        [SetUp]
        public void Setup() { }


        [TearDown]
        public void Tear() { }

        [Test]
        public void This_Test_Will_Pass()
        {
            Console.WriteLine("test1");
            Assert.True(true);
        }

        [Test]
        public void This_Test_Will_Fail()
        {
            Assert.False(true);
        }

        [Test]
        [Ignore("another time")]
        public void This_Test_Will_Be_Ignored()
        {
            Assert.True(false);
        }

        [Test]
        public void This_Test_Will_Be_Inconclusive()
        {
            Assert.Inconclusive("Inconclusive");
        }
    }
}