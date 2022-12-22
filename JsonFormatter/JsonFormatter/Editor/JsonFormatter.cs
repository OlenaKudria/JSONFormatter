using Newtonsoft.Json;
using UnityEngine;

namespace JsonFormatter
{
    public class JsonFormatter : MonoBehaviour
    {
        public static string FormatJson(string json)
        {
            var parsedJson = JsonConvert.DeserializeObject(json);
            return JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
        }
    }
}
