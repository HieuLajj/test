using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class Savesave : MonoBehaviour
{

    public int i=0;
    void Start()
    {
        // string directoryPath = Path.Combine(Application.dataPath, "Resources");
         
        // string filePath = Path.Combine(directoryPath, "level.json");
        // string jsonContent = "Your JSON content here";
        // if (!Directory.Exists(directoryPath))
        // {
        //     Directory.CreateDirectory(directoryPath);
        // }

        // File.WriteAllText(filePath, jsonContent);
        TextAsset jsonFile = Resources.Load<TextAsset>("level");
        string json = jsonFile.text;
        Debug.Log(Random.Range(0,1000)+"đ"+json+"đ"+i);
        i++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
