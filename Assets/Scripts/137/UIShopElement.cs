using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIShopElement : MonoBehaviour
{
    public int id;
    private void Awake() {
        id = transform.GetSiblingIndex();    
        
    }

    public void SetData(int id){
        UpdateView(id);
    }
    public void UpdateView(int id){
       var isOwned =  DataPlayer.IdCheckData(id);
       if (isOwned){}
    }
}
