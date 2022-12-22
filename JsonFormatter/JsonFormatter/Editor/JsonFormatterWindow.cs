using System.IO;
using UnityEditor;
using UnityEngine;

namespace JsonFormatter
{
    public class JsonFormatterWindow : EditorWindow
    {
        public TextAsset json;
        private string jsonFilePath;
        [MenuItem("JsonFormatter/MakeItPretty")]
        public static void ShowWindow() => GetWindow(typeof(JsonFormatterWindow));

        private void OnGUI()
        {
            GUILayout.Label("Make this json pretty!", EditorStyles.boldLabel);
            json = EditorGUILayout.ObjectField("Json", json, typeof(TextAsset), false) as TextAsset;
            jsonFilePath = AssetDatabase.GetAssetPath(json);
            
            if (json == null || jsonFilePath == null) return;
            var formattedText = JsonFormatter.FormatJson(json.ToString());
            if (GUILayout.Button("Prettify"))
                File.WriteAllText(jsonFilePath, formattedText);
        }
    }
}
