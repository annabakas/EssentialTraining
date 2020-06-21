using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining;

namespace EssentialTrainingTests
{
    [TestClass]
    public class SimpleArrayTest
    {
        [TestMethod]
        public void TestInstantiation()
        {
            var testInstance = new SimpleArray();
            Assert.AreEqual(testInstance.groceryList.Length, 4);
            Assert.AreEqual(testInstance.groceryList[1], "Milk");
        }

        [TestMethod]
        public void TesttoString()
        {
            var testInstance = new SimpleArray();
            Assert.IsTrue(testInstance.ToString().StartsWith("There are"));
        }
    }
}
