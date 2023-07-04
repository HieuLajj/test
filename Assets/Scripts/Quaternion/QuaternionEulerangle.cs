using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionEulerangle : MonoBehaviour
{
    Quaternion rotation1;
    // Start is called before the first frame update
    void Start()
    {
       rotation1.eulerAngles = new Vector3(30,0,0);
       Debug.Log(rotation1.eulerAngles);
       
       Debug.Log(transform.up);
    //    transform.Rotate(0,30,0);
    //    transform.rotation =  Quaternion.AngleAxis(40, transform.up);
        transform.rotation = Quaternion.FromToRotation(Vector3.up, Vector3.down);
        Debug.Log(transform.forward);
    }

    // Update is called once per frame
    void Update()
    {
        // transform.rotation =  Quaternion.Euler(0, 30, 0);
        // Debug.Log("dđ");
        // transform.Rotate(0,30,0);
        // transform.rotation =  Quaternion.AngleAxis(40, transform.up);
        // transform.rotation = Quaternion.Euler(12,32,123213213);
        
    }
}
