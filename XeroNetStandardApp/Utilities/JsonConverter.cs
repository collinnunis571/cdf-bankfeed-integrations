using Newtonsoft.Json;
using System;

namespace XeroNetStandardApp.Utilities
{
    public interface IJsonConverter
    {
        public object Deserialize<T>(string json);
    }

    public class JsonConverter : IJsonConverter
    {
        public object Deserialize<T>(string json)
        {
            if (string.IsNullOrWhiteSpace(json))
            {
                throw new ArgumentNullException(nameof(json));
            }

            var result = JsonConvert.DeserializeObject<T>(json);
            return result;
        }
    }
}
