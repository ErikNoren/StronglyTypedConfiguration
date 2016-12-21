using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StronglyTypedConfiguration.Tests
{
    [TestClass]
    public class MultiValueAlternateDelimeterTests
    {
        [TestMethod]
        public void MultiValueStringAltDelimeter()
        {
            var setting = new List<string>(ConfigurationManager.AppSettings.GetValuesOrDefault<string>("multiStringAltDelimeter", ","));
            var values = new List<string>() { "Apple", "Banana", "Carrot", "Dish Soap" };

            Assert.AreEqual(4, setting.Count());
            Assert.IsFalse(setting.Except(values).Any());
        }

        [TestMethod]
        public void MultiValueIntAltDelimeter()
        {
            var setting = ConfigurationManager.AppSettings.GetValuesOrDefault<int>("multiIntAltDelimeter", ",");
            var values = new List<int>() { 16, 8, 32, 500, 2140000000, 1 };

            Assert.AreEqual(6, setting.Count());
            Assert.IsFalse(setting.Except(values).Any());
        }

        [TestMethod]
        public void MultiValueLongAltDelimeter()
        {
            var setting = ConfigurationManager.AppSettings.GetValuesOrDefault<long>("multiLongAltDelimeter", ",");
            var values = new List<long>() { 16, 8, 32, 500, 9223372036854775806, 1 };

            Assert.AreEqual(6, setting.Count());
            Assert.IsFalse(setting.Except(values).Any());
        }

        [TestMethod]
        public void MultiValueDoubleAltDelimeter()
        {
            var setting = ConfigurationManager.AppSettings.GetValuesOrDefault<double>("multiDoubleAltDelimeter", ",");
            var values = new List<double>() { 23.99, 100.514, 867.5309, 0 };

            Assert.AreEqual(4, setting.Count());
            Assert.IsFalse(setting.Except(values).Any());
        }

        [TestMethod]
        public void MultiValueGuidAltDelimeter()
        {
            var setting = ConfigurationManager.AppSettings.GetValuesOrDefault<Guid>("multiGuidAltDelimeter", ",");
            var values = new List<Guid>() { Guid.Parse("{351C24E4-9029-4F86-9F19-CC0629663ED5}"), Guid.Parse("{2883FFBE-8C3C-451F-8C58-794307F9D5BF}"), Guid.Parse("{5D9950ED-079F-4853-9736-35D6C417069B}") };

            Assert.AreEqual(3, setting.Count());
            Assert.IsFalse(setting.Except(values).Any());
        }

        [TestMethod]
        public void MultiValueDateTimeAltDelimeter()
        {
            var setting = ConfigurationManager.AppSettings.GetValuesOrDefault<DateTime>("multiDateTimeAltDelimeter", ",");
            var values = new List<DateTime>() { DateTime.Parse("2010-01-01 5:00:00am"), DateTime.Parse("2016 -11-30 6:30:00pm"), DateTime.Parse("1999-12-31 11:59:59pm") };

            Assert.AreEqual(3, setting.Count());
            Assert.IsFalse(setting.Except(values).Any());
        }

        [TestMethod]
        public void MultiValueBoolAltDelimeter()
        {
            var setting = ConfigurationManager.AppSettings.GetValuesOrDefault<bool>("multiBoolAltDelimeter", ",");
            var values = new List<bool>() { true, false, false, true };

            Assert.AreEqual(4, setting.Count());
            Assert.IsFalse(setting.Except(values).Any());
        }
    }
}
