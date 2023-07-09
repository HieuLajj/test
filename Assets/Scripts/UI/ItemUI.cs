using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class ItemUI : MonoBehaviour
{
    public Sprite[] spriteItem;
    public Image imagePlate;
    // Start is called before the first frame update
    public TextMeshProUGUI TextCoin;
    public GameObject Plate;
    public GameObject TextCoinPanel;

    public void Actived(){
        imagePlate.sprite = spriteItem[0];
        //Plate.gameObject.SetActive(false);
        TextCoinPanel.SetActive(false);
    }

    public void Activeting(){
        imagePlate.sprite = spriteItem[2];
        //Plate.gameObject.SetActive(true);
        TextCoinPanel.SetActive(true);
    }

    public void ActiveAwait(){
        //Plate.gameObject.SetActive(true);
        imagePlate.sprite = spriteItem[1];
        TextCoinPanel.SetActive(false);
    }
    
}
