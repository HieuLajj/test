using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testbullet : MonoBehaviour
{
    public Transform object1;
    public Transform object2;
    void Update()
    {
        //object2.rotation = Quaternion.LookRotation((object1.position-object2.position),new Vector3(0.5f, 0.5f, 0));
        Debug.DrawLine(object2.position,object2.position + object2.forward * 100, Color.blue);
        Debug.DrawLine(object2.position,object2.position + object2.up * 100, Color.green);
        Debug.DrawLine(object2.position,object2.position + object2.right* 100, Color.yellow);
       

        object2.rotation = Quaternion.RotateTowards(
            object2.transform.rotation, 
            Quaternion.LookRotation((object1.position-object2.position),new Vector3(0.5f, 0.5f, 0)), 
            Time.deltaTime
        );
       
    }
}
