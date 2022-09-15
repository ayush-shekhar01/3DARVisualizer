using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

public class FileAccesser : MonoBehaviour
{
    [MenuItem("Upload .stl file")]
    public void Apply()
    {
        Texture2D texture = Selection.activeObject as Texture2D;
        string path = EditorUtility.OpenFilePanel("Overwrite with stl", "", "stl");
        if (path.Length != 0)
        {
            var fileContent = File.ReadAllBytes(path);
            texture.LoadImage(fileContent);
        }


    }
}
