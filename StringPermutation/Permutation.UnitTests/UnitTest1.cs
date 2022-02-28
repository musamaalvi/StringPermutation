using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using StringPermutation;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Permutation obj = new Permutation();

            Assert.IsTrue(obj.CheckPermutation("Pot spot"));
            Assert.IsTrue(obj.CheckPermutation("Racecar"));
            Assert.IsTrue(obj.CheckPermutation("kayk   yak"));
            Assert.IsTrue(obj.CheckPermutation("Ana avlleva al oso la ell ana"));

        }
    }
}
