using System;
using System.Collections.Generic;
using System.Net;
using DataLayer.Model;
using Newtonsoft.Json;

namespace DataLayer.BusinessObject
{
    public class GenericJsonOperator
    {
        public static List<T> SerializedJsonDataRetriver<T>(string url) where T : new()
        {
            using (var webClientInstance = new WebClient())
            {
                var jsonData = string.Empty;
                var jarray = new List<T>();
                // attempt to download JSON data as a string
                try
                {
                    jsonData = webClientInstance.DownloadString(url);
                    jsonData = jsonData.Substring(33);
                    jsonData = jsonData.Remove(jsonData.Length - 2);
                   
                }
                catch (Exception ex)
                {
                    // ignored
                }
                // if string with JSON data is not empty, deserialize it to class and return its instance 
                return !string.IsNullOrEmpty(jsonData) ? JsonConvert.DeserializeObject<List<T>>(jsonData): new List<T>() ;
                
            }
        }
    }
}
