using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;

namespace StronglyTypedConfiguration.Tests
{
    [TestClass]
    public class NullableSingleValueTests
    {
        [TestMethod]
        public void NullableInt()
        {
            int? expected = 42;
            Assert.AreEqual(expected, ConfigurationManager.AppSettings.GetValueOrDefault<int?>("nullableInt"));
        }

        [TestMethod]
        public void NullableLong()
        {
            long? expected = 9223372036854775806;
            Assert.AreEqual(expected, ConfigurationManager.AppSettings.GetValueOrDefault<long?>("nullableLong"));
        }

        [TestMethod]
        public void NullableDouble()
        {
            double? expected = 123.456;
            Assert.AreEqual(expected, ConfigurationManager.AppSettings.GetValueOrDefault<double?>("nullableDouble"));
        }

        [TestMethod]
        public void NullableGuid()
        {
            Guid? expected = Guid.Parse("{71356C97-3732-45A9-8881-2ADC01D5FFBB}");
            Assert.AreEqual(expected, ConfigurationManager.AppSettings.GetValueOrDefault<Guid?>("nullableGuid"));
        }

        [TestMethod]
        public void NullableDateTime()
        {
            var setting = ConfigurationManager.AppSettings.GetValueOrDefault<DateTime?>("nullableDateTime");
            Assert.AreEqual(624933340200000000, setting.Value.Ticks);
        }

        [TestMethod]
        public void NullableBool()
        {
            bool? expected = true;
            Assert.AreEqual(expected, ConfigurationManager.AppSettings.GetValueOrDefault<bool?>("nullableBool"));
        }
    }
}
