using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StronglyTypedConfiguration.Tests
{
    [TestClass]
    public class SingleValueTests
    {
        [TestMethod]
        public void SingleString()
        {
            Assert.AreEqual("String Setting Value", ConfigurationManager.AppSettings.GetValueOrDefault("singleString", string.Empty));
        }

        [TestMethod]
        public void SingleInt()
        {
            Assert.AreEqual(42, ConfigurationManager.AppSettings.GetValueOrDefault("singleInt", 0));
        }

        [TestMethod]
        public void SingleLong()
        {
            Assert.AreEqual(9223372036854775806, ConfigurationManager.AppSettings.GetValueOrDefault("singleLong", 0L));
        }

        [TestMethod]
        public void SingleDouble()
        {
            Assert.AreEqual(123.456, ConfigurationManager.AppSettings.GetValueOrDefault("singleDouble", 0.0));
        }

        [TestMethod]
        public void SingleGuid()
        {
            Guid expected = Guid.Parse("{71356C97-3732-45A9-8881-2ADC01D5FFBB}");
            Assert.AreEqual(expected, ConfigurationManager.AppSettings.GetValueOrDefault("singleGuid", Guid.Empty));
        }

        [TestMethod]
        public void SingleDateTime()
        {
            var setting = ConfigurationManager.AppSettings.GetValueOrDefault("singleDateTime", DateTime.MinValue);
            Assert.AreEqual(624933340200000000, setting.Ticks);
        }

        [TestMethod]
        public void SingleBool()
        {
            Assert.AreEqual(true, ConfigurationManager.AppSettings.GetValueOrDefault("singleBool", false));
        }

    }
}
