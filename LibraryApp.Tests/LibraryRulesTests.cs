using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LibraryApp;

namespace LibraryApp.Tests
{
    [TestClass]
    public class LibraryRulesTests
    {
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