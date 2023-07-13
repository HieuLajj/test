using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIShopPopup : MonoBehaviour
{
    // Start is called before the first frame update
    public UIShopElement[] shopElement;
    private void OnValidate() {
        if(shopElement == null || shopElement.Length == 0){
            shopElement = GetComponentsInChildren<UIShopElement>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
