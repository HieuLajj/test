using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    void Start()
    {
        transform.RotateAround(target.transform.position, Vector3.right, 45);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
