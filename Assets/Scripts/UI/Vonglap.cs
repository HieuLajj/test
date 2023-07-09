using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vonglap : MonoBehaviour
{
    // Start is called before the first frame update
    public ResultAdBtn[] arrayButton;
    public ResultAdBtn b1;
    public ResultAdBtn b2;
    private IEnumerator corountine;

    private void Awake() {
        arrayButton = transform.GetComponentsInChildren<ResultAdBtn>(includeInactive: true);
        corountine = Tathien();
    }
    
    private void OnEnable() {
        StartCoroutine(corountine);
    }
    private void Update() {
        if(Input.GetKeyDown(KeyCode.K)){
             StopCoroutine(corountine);
            

        }
    }
    private int i=0;

    IEnumerator Tathien()
    {
        
        while (true)
        {
            if(i==arrayButton.Length){
                i=0;
            }
            if(b2!=null){
                b2.An();
            }
            Debug.Log(i);
            b1 = arrayButton[i];
            b1.Hien();
            b2 = b1;
            i++;
            yield return new WaitForSeconds(1);
        }
    }

}
