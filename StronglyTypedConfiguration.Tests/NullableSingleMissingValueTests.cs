using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;

namespace StronglyTypedConfiguration.Tests
{
    [TestClass]
    public class NullableSingleMissingValueTests
    {
        [TestMethod]
        public void NullableMissingInt()
        {
            Assert.IsNull(ConfigurationManager.AppSettings.GetValueOrDefault<int?>("_missing!_"));
        }

        [TestMethod]
        public void NullableMissingLong()
        {
            Assert.IsNull(ConfigurationManager.AppSettings.GetValueOrDefault<long?>("_missing!_"));
        }

        [TestMethod]
        public void NullableMissingDouble()
        {
            Assert.IsNull(ConfigurationManager.AppSettings.GetValueOrDefault<double?>("_missing!_"));
        }

        [TestMethod]
        public void NullableMissingGuid()
        {
            Assert.IsNull(ConfigurationManager.AppSettings.GetValueOrDefault<Guid?>("_missing!_"));
        }

        [TestMethod]
        public void NullableMissingDateTime()
        {
            Assert.IsNull(ConfigurationManager.AppSettings.GetValueOrDefault<DateTime?>("_missing!_"));
        }

        [TestMethod]
        public void NullableMissingBool()
        {
            Assert.IsNull(ConfigurationManager.AppSettings.GetValueOrDefault<bool?>("_missing!_"));
        }
    }
}
