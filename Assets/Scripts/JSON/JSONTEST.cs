using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class FromLogin{
    public string ID;
    public string NAME;
    public string INFORMATION;
}

[System.Serializable]
public class LevelData{
    public int levelNumber;
    public Vector3 position;
    public int[] arrayDir;
}

public class JSONTEST : MonoBehaviour
{
    public int Level;
    public Vector3 pos3ition;
    public int[] arrayDirrr;
    // Start is called before the first frame update
    void Start()
    {
      Readata();
    }

    public void SaveData(){
       LevelData leveldata = new LevelData();
       leveldata.levelNumber = 12;
       leveldata.position = new Vector3(2,43,4);
       leveldata.arrayDir = new int[]{1,2,3,4,5,6,7,8,9,0,1,2,34,5,67,78,9,0,-3,12,3,4,5,6,67,8,9};

        string json = JsonUtility.ToJson(leveldata);
        string file = Application.dataPath+"/level.json";
        File.WriteAllText(file, json);
        Debug.Log(file);
        // FromLogin data = new FromLogin();
        // data.ID = "23323";
        // data.NAME = "laiva3232nhieu";
        // data.INFORMATION = "nguy323enthieu";

        // string json = JsonUtility.ToJson(data);
        // string file = Application.dataPath+"/hehehe.json";
        // File.WriteAllText(file, null);
        // Debug.Log(file);
    }

     public void Readata(){
        string json = File.ReadAllText(Application.dataPath+"/level.json");
        if(json==""||json==null){
            Debug.Log("ko co giu lieu");
        }else{
            LevelData leveldata = JsonUtility.FromJson<LevelData>(json);
            Level = leveldata.levelNumber;
            pos3ition = leveldata.position;
            arrayDirrr = leveldata.arrayDir;
        }
        // string json = File.ReadAllText(Application.dataPath+"/hehehe.json");
        // if(json==""||json==null){
        //     Debug.Log("ko co giu lieu");
        // }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
