using System;
using System.Configuration;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StronglyTypedConfiguration.Tests
{
    [TestClass]
    public class MultiValueMiscTests
    {
        [TestMethod]
        public void MultiValueWhitespacePreserved()
        {
            var setting = ConfigurationManager.AppSettings.GetValuesOrDefault<string>("multiStringAltDelimeterPreserveWhitespace", preserveWhitespace: true);

            Assert.AreEqual(4, setting.Count());
            Assert.IsTrue(setting.Contains("   Apple   "));
            Assert.IsTrue(setting.Contains(" Banana"));
            Assert.IsTrue(setting.Contains("Carrot "));
            Assert.IsTrue(setting.Contains("  Dish   Soap  "));
        }

        [TestMethod]
        public void MultiValueEmptySegmentsRemoved()
        {
            var setting = ConfigurationManager.AppSettings.GetValuesOrDefault<int>("multiIntEmptySegments");

            Assert.AreEqual(6, setting.Count());
            Assert.IsTrue(setting.Contains(16));
            Assert.IsTrue(setting.Contains(8));
            Assert.IsTrue(setting.Contains(32));
            Assert.IsTrue(setting.Contains(500));
            Assert.IsTrue(setting.Contains(2140000000));
            Assert.IsTrue(setting.Contains(1));
        }
    }
}
