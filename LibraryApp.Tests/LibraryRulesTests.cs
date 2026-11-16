using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LibraryApp;

namespace LibraryApp.Tests
{
    [TestClass]
    public class LibraryRulesTests
    {
        [TestMethod]
        public void GetFineLevel_0Days_ReturnsNo()
        {
            Assert.AreEqual("Нет", LibraryRules.GetFineLevel(0));
        }

        [TestMethod]
        public void GetFineLevel_1Day_ReturnsLow()
        {
            Assert.AreEqual("Низкий", LibraryRules.GetFineLevel(1));
        }

        [TestMethod]
        public void GetFineLevel_14Days_ReturnsLow()
        {
            Assert.AreEqual("Низкий", LibraryRules.GetFineLevel(14));
        }

        [TestMethod]
        public void GetFineLevel_15Days_ReturnsMedium()
        {
            Assert.AreEqual("Средний", LibraryRules.GetFineLevel(15));
        }

        [TestMethod]
        public void GetFineLevel_30Days_ReturnsMedium()
        {
            Assert.AreEqual("Средний", LibraryRules.GetFineLevel(30));
        }

        [TestMethod]
        public void GetFineLevel_31Days_ReturnsHigh()
        {
            Assert.AreEqual("Высокий", LibraryRules.GetFineLevel(31));
        }
    }
}