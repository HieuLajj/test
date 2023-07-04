using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMouse : MonoBehaviour
{
    public Vector3 position1;
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            position1 = camera.ScreenToWorldPoint(Input.mousePosition);
        }
        if(Input.GetMouseButton(0)){
            Vector3 heheehe = position1 - camera.ScreenToWorldPoint(Input.mousePosition);
            camera.transform.position+=heheehe;
            Debug.Log("hfoaiwehfoawe"+heheehe);
        }
        
    }
}
