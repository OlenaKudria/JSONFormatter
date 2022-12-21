using Newtonsoft.Json;
using UnityEditor;
using UnityEngine;

public class JsonFormatter : MonoBehaviour
{
    public static string FormatJson(string json)
    {
        var parsedJson = JsonConvert.DeserializeObject(json);
        return JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
    }
}