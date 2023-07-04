using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public List<GameObject> GameObject;
    public GameObject Player;
    int startcheck = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        Fly();
        DrawObject();
        if(Input.GetKeyDown(KeyCode.Space)){
            CheckDistance(new Vector3( Input.mousePosition.x, Input.mousePosition.y, 2.0f ));
        }
    }

    void DrawObject(){
        for(int i=0 ; i<GameObject.Count; i++){
            int m = i;
            int n = i+1;
            if(n>=GameObject.Count){
                n=0;
            }
            Debug.DrawLine(GameObject[m].transform.position, GameObject[n].transform.position, Color.red);
        }
    }
    void Fly(){
        if(Vector3.Distance(Player.transform.position, GameObject[startcheck].transform.position)<=0){
            startcheck++;
            if(startcheck>= GameObject.Count){
                startcheck = 0;
            }
            Quaternion direction = Quaternion.LookRotation(-Player.transform.position + GameObject[startcheck].transform.position, Vector3.up);
            Player.transform.rotation = direction;
        }
        Player.transform.position = Vector3.MoveTowards(Player.transform.position, GameObject[startcheck].transform.position, 5*Time.deltaTime);
    }
    int[] CheckDistance(Vector3 MouseCheck){
        float min1 = Mathf.Infinity;
        float min2 = Mathf.Infinity;
        int[] a = {0,0};
        for(int i=0; i<GameObject.Count; i++){
            float h = Vector3.Distance(MouseCheck, GameObject[i].transform.position);
            Debug.Log(h+"i"+i);
            if(h<=min1){
                min1 = h;
                a[0] = i;
            }else if(h<=min2){
                min2 = h;
                a[1] = i;
            }
        }
        Debug.Log(a[0]+"hehe"+a[1]+"hffoe"+MouseCheck);
        return a;
    }
}
