using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    Ray rayMoveObject;
    RaycastHit raycastHit;
    Plane plane = new Plane(Vector3.up,0);
    // Start is called before the first frame update
    public GameObject SelectGameObject;

    Ray rayMove;
    // Update is called once per frame
    void Update()
    {
        rayMoveObject = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(rayMoveObject, out raycastHit)){
            if(Input.GetMouseButtonDown(0)){
                if(raycastHit.collider.gameObject.layer==9){
                    SelectGameObject = raycastHit.collider.transform.parent.gameObject;
                }      
            }
        }
        if(Input.GetMouseButtonDown(1)){
            SelectGameObject = null;
        }


        if(Physics.Raycast(rayMoveObject, out raycastHit, Mathf.Infinity, ~(1<<9))){
            if(SelectGameObject!=null){
                SelectGameObject.transform.position = raycastHit.point;
                SelectGameObject.transform.rotation = Quaternion.FromToRotation(Vector3.up, raycastHit.normal);
            }
        }
    }
}
