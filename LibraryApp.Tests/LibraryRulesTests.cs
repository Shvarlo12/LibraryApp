using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryApp;
using System;

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

        [TestMethod]
        public void IsClassic_101Years_ReturnsTrue()
        {
            Assert.IsTrue(LibraryRules.IsClassic(1925, 2026));
        }

        [TestMethod]
        public void IsClassic_100Years_ReturnsTrue()
        {
            Assert.IsTrue(LibraryRules.IsClassic(1926, 2026));
        }

        [TestMethod]
        public void IsClassic_99Years_ReturnsFalse()
        {
            Assert.IsFalse(LibraryRules.IsClassic(1927, 2026));
        }

        [TestMethod]
        public void IsClassic_FutureYear_ThrowsArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => LibraryRules.IsClassic(2027, 2026));
        }
    }
}
