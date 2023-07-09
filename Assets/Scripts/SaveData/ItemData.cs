using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "ScriptableObject", menuName = "Iteeeetas")]
public class ItemData : ScriptableObject
{
   public List<ItemModel> itemmotluot;
}
[System.Serializable]
public class ItemModel{
    public int id;
    public string name;
    public string damuachua;
}
