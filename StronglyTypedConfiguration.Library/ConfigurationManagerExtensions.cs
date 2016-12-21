using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;

namespace System.Configuration
{
    public static class ConfigurationManagerExtensions
    {
        public static T GetValueOrDefault<T>(this NameValueCollection appSettings, string appSettingKey, T defaultValue = default(T))
        {
            var setting = appSettings[appSettingKey];
            if (!string.IsNullOrWhiteSpace(setting))
            {
                try
                {
                    return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromInvariantString(setting);
                }
                catch { }
            }

            return defaultValue;
        }

        public static IEnumerable<T> GetValuesOrDefault<T>(this NameValueCollection appSettings, string appSettingKey, string delimeter = ";", bool preserveWhitespace = false, IEnumerable<T> defaultValue = default(IEnumerable<T>))
        {
            var setting = appSettings[appSettingKey];
            if (!string.IsNullOrWhiteSpace(setting))
            {
                try
                {
                    var typeConverter = TypeDescriptor.GetConverter(typeof(T));

                    var splitValues = setting.Split(delimeter.ToCharArray());
                    return splitValues
                        .Where(val => !string.IsNullOrWhiteSpace(val.Trim()))
                        .Select(val => preserveWhitespace ? (T)typeConverter.ConvertFromInvariantString(val) : (T)typeConverter.ConvertFromInvariantString(val.Trim()))
                        .ToList();
                }
                catch { }
            }

            return defaultValue;
        }

        public static T GetObjectOrDefault<T>(this NameValueCollection appSettings, string appSettingKey, T defaultValue = default(T))
        {
            var setting = appSettings[appSettingKey];
            if (!string.IsNullOrWhiteSpace(setting))
            {
                try
                {
                    return JsonConvert.DeserializeObject<T>(setting);
                }
                catch { }
            }

            return defaultValue;
        }
    }
}