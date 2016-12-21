using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StronglyTypedConfiguration.Tests
{
    [TestClass]
    public class MultiValueTests
    {
        [TestMethod]
        public void MultiValueString()
        {
            var setting = new List<string>(ConfigurationManager.AppSettings.GetValuesOrDefault<string>("multiString"));
            var values = new List<string>() { "Apple", "Banana", "Carrot", "Dish Soap" };

            Assert.AreEqual(4, setting.Count());
            Assert.IsFalse(setting.Except(values).Any());
        }

        [TestMethod]
        public void MultiValueInt()
        {
            var setting = ConfigurationManager.AppSettings.GetValuesOrDefault<int>("multiInt");
            var values = new List<int>() { 16, 8, 32, 500, 2140000000, 1 };
            
            Assert.AreEqual(6, setting.Count());
            Assert.IsFalse(setting.Except(values).Any());
        }

        [TestMethod]
        public void MultiValueLong()
        {
            var setting = ConfigurationManager.AppSettings.GetValuesOrDefault<long>("multiLong");
            var values = new List<long>() { 16, 8, 32, 500, 9223372036854775806, 1 };

            Assert.AreEqual(6, setting.Count());
            Assert.IsFalse(setting.Except(values).Any());
        }

        [TestMethod]
        public void MultiValueDouble()
        {
            var setting = ConfigurationManager.AppSettings.GetValuesOrDefault<double>("multiDouble");
            var values = new List<double>() { 23.99, 100.514, 867.5309, 0 };

            Assert.AreEqual(4, setting.Count());
            Assert.IsFalse(setting.Except(values).Any());
        }

        [TestMethod]
        public void MultiValueGuid()
        {
            var setting = ConfigurationManager.AppSettings.GetValuesOrDefault<Guid>("multiGuid");
            var values = new List<Guid>() { Guid.Parse("{351C24E4-9029-4F86-9F19-CC0629663ED5}"), Guid.Parse("{2883FFBE-8C3C-451F-8C58-794307F9D5BF}"), Guid.Parse("{5D9950ED-079F-4853-9736-35D6C417069B}") };

            Assert.AreEqual(3, setting.Count());
            Assert.IsFalse(setting.Except(values).Any());
        }

        [TestMethod]
        public void MultiValueDateTime()
        {
            var setting = ConfigurationManager.AppSettings.GetValuesOrDefault<DateTime>("multiDateTime");
            var values = new List<DateTime>() { DateTime.Parse("2010-01-01 5:00:00am"), DateTime.Parse("2016 -11-30 6:30:00pm"), DateTime.Parse("1999-12-31 11:59:59pm") };

            Assert.AreEqual(3, setting.Count());
            Assert.IsFalse(setting.Except(values).Any());
        }

        [TestMethod]
        public void MultiValueBool()
        {
            var setting = ConfigurationManager.AppSettings.GetValuesOrDefault<bool>("multiBool");
            var values = new List<bool>() { true, false, false, true };

            Assert.AreEqual(4, setting.Count());
            Assert.IsFalse(setting.Except(values).Any());
        }
    }
}
