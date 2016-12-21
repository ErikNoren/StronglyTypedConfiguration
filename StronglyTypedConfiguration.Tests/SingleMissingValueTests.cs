using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StronglyTypedConfiguration.Tests
{
    [TestClass]
    public class SingleMissingValueTests
    {
        [TestMethod]
        public void SingleMissingSettingExplicitDefaultString()
        {
            Assert.AreEqual(string.Empty, ConfigurationManager.AppSettings.GetValueOrDefault("_missing!_", string.Empty));
        }

        [TestMethod]
        public void SingleMissingSettingExplicitDefaultInt()
        {
            Assert.AreEqual(10, ConfigurationManager.AppSettings.GetValueOrDefault("_missing!_", 10));
        }

        [TestMethod]
        public void SingleMissingSettingImplicitDefaultString()
        {
            var expected = default(string);
            Assert.AreEqual(expected, ConfigurationManager.AppSettings.GetValueOrDefault<string>("_missing!_"));
        }

        [TestMethod]
        public void SingleMissingSettingImplicitDefaultInt()
        {
            var expected = default(int);
            Assert.AreEqual(expected, ConfigurationManager.AppSettings.GetValueOrDefault<int>("_missing!_"));
        }

        [TestMethod]
        public void SingleMissingSettingImplicitDefaultLong()
        {
            var expected = default(long);
            Assert.AreEqual(expected, ConfigurationManager.AppSettings.GetValueOrDefault<long>("_missing!_"));
        }


        [TestMethod]
        public void SingleMissingSettingImplicitDefaultDouble()
        {
            var expected = default(double);
            Assert.AreEqual(expected, ConfigurationManager.AppSettings.GetValueOrDefault<double>("_missing!_"));
        }


        [TestMethod]
        public void SingleMissingSettingImplicitDefaultGuid()
        {
            var expected = default(Guid);
            Assert.AreEqual(expected, ConfigurationManager.AppSettings.GetValueOrDefault<Guid>("_missing!_"));
        }


        [TestMethod]
        public void SingleMissingSettingImplicitDefaultDateTime()
        {
            var expected = default(DateTime);
            Assert.AreEqual(expected, ConfigurationManager.AppSettings.GetValueOrDefault<DateTime>("_missing!_"));
        }


        [TestMethod]
        public void SingleMissingSettingImplicitDefaultBool()
        {
            var expected = default(bool);
            Assert.AreEqual(expected, ConfigurationManager.AppSettings.GetValueOrDefault<bool>("_missing!_"));
        }
    }
}
