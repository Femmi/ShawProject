using System;
using System.Net;
using Newtonsoft.Json;

namespace DataLayer.BusinessObject
{
    class GenericJsonOperator
    {
        private static T SerializedJsonDataRetriver<T>(string url) where T : new()
        {
            using (var webClientInstance = new WebClient())
            {
                var jsonData = string.Empty;
                // attempt to download JSON data as a string
                try
                {
                    jsonData = webClientInstance.DownloadString(url);
                }
                catch (Exception)
                {
                    // ignored
                }
                // if string with JSON data is not empty, deserialize it to class and return its instance 
                return !string.IsNullOrEmpty(jsonData) ? JsonConvert.DeserializeObject<T>(jsonData) : new T();
            }
        }
    }
}
