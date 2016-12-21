using System;
using System.Linq;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StronglyTypedConfiguration.Tests
{
    [TestClass]
    public class ComplexObjectTests
    {
        [TestMethod]
        public void ComplexObject()
        {
            var setting = ConfigurationManager.AppSettings.GetObjectOrDefault<ComplexSetting>("complexObject");
            var expectedEODTicks = DateTime.Parse("2010-10-04 11:27:00am").Ticks;

            Assert.AreEqual("Erik", setting.Name);
            Assert.AreEqual(35, setting.Age);
            Assert.AreEqual(expectedEODTicks, setting.EmployedOnDate.Ticks);
            Assert.AreEqual("123A", setting.Address.HouseNumber);
            Assert.AreEqual("Main", setting.Address.Street);
            Assert.AreEqual("New York", setting.Address.City);
            Assert.AreEqual("NY", setting.Address.State);
            
            Assert.AreEqual(4, setting.Aliases.Length);
            Assert.IsTrue(setting.Aliases.Contains("Enrique"));
            Assert.IsTrue(setting.Aliases.Contains("Quique"));
            Assert.IsTrue(setting.Aliases.Contains("Eriko"));
            Assert.IsTrue(setting.Aliases.Contains("Hey you"));
        }

        [TestMethod]
        public void ComplexObjectMissingSetting()
        {
            var setting = ConfigurationManager.AppSettings.GetObjectOrDefault<ComplexSetting>("_missing!_");
            Assert.IsNull(setting);
        }
    }
}
