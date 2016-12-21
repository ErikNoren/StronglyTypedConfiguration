using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StronglyTypedConfiguration.Tests
{
    [TestClass]
    public class SettingsClassTests
    {
        [TestMethod]
        public void SettingsClassAppVersion()
        {
            Assert.AreEqual("1.0.5", Settings.AppVersion);
        }

        [TestMethod]
        public void SettingsClassAdministration()
        {
            Assert.AreEqual(true, Settings.Administration.SupportHasAdministrationRights);
        }

        [TestMethod]
        public void SettingsClassAutocompleteOptions()
        {
            Assert.AreEqual(30, Settings.AutocompleteOptions.MaxResults);
            Assert.AreEqual("[N/A]", Settings.AutocompleteOptions.NoSelectionLabel);
        }
    }
}
