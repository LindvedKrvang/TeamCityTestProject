using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamCityTestProject;

namespace DemoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd1()
        {
            var demo = new Demo();
            var result = demo.Add(2, 2);
            var expectedResult = 4;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestAdd2()
        {
            var demo = new Demo();
            var result = demo.Add(0, 5);
            var expectedResult = 5;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestMultiply1()
        {
            var demo = new Demo();
            var result = demo.Multiply(2, 2);
            var expectedResult = 4;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestMultiply2()
        {
            var demo = new Demo();
            var result = demo.Multiply(5, 10);
            var expectedResult = 50;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestMultiply3()
        {
            var demo = new Demo();
            var result = demo.Multiply(20, 30);
            var expectedResult = 600;

            Assert.AreEqual(expectedResult, result);
        }
    }
}
