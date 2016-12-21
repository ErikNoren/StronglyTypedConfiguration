using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StronglyTypedConfiguration.Tests
{
    /// <summary>
    /// An example settings class used to centralize all your settings.
    /// This is an alternative to using a complex object and serializing
    /// all your settings into a JSON string in a single app setting.
    /// This class is static since settings can only be updated during an app pool recycle
    /// in ASP.NET (except in Core which already has better settings support anyway).
    /// </summary>
    public static class Settings
    {
        public static readonly string AppVersion = ConfigurationManager.AppSettings
            .GetValueOrDefault("ReleaseVersion", string.Empty);

        public static class AutocompleteOptions
        {
            public static readonly int MaxResults = ConfigurationManager.AppSettings
                .GetValueOrDefault("Autocomplete.MaxResults", 25);

            public static readonly string NoSelectionLabel = ConfigurationManager.AppSettings
                .GetValueOrDefault("Autocomplete.NotApplicableOptionLabel", "[none]");
        }

        public static class Administration
        {
            public static readonly bool SupportHasAdministrationRights = ConfigurationManager.AppSettings
                .GetValueOrDefault("Admin.SupportHasAdminRights", false);
        }
    }
}
