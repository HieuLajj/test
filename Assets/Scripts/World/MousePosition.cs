using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition : MonoBehaviour
{
    public Vector3 screenPosition;
    public Vector3 worldPosition;
    public LayerMask layerToHit;

    Plane plane = new Plane(Vector3.up,0);
    // Update is called once per frame
    void Update()
    {   
        Cach3();
    }

    void Cach1(){
        screenPosition = Input.mousePosition;
        screenPosition.z = Camera.main.nearClipPlane + 1;
        worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
        transform.position = worldPosition;
    }

    void Cach2(){
        screenPosition = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(screenPosition);
        if(Physics.Raycast(ray, out RaycastHit hitInfo, 100, 1<<7)){
            worldPosition = hitInfo.point;
        }
        transform.position = worldPosition;
    }

    void Cach3(){
        screenPosition = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(screenPosition);
        if(plane.Raycast(ray, out float distance)){
            worldPosition = ray.GetPoint(distance);
        }
        transform.position = worldPosition;
    }
}
