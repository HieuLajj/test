using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject2 : MonoBehaviour
{
    public Space spacehhe;
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate( new Vector3(1,0,0),60, spacehhe);
        Debug.Log(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, new Vector3(100,100,0), Color.red);
    }
}
