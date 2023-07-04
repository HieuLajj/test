using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRoateVelocity : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rigidbodyBullet;
    public Transform Target;
    void Start()
    {
        rigidbodyBullet = transform.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 directionBullet = transform.position - Target.position;
        transform.rotation  = Quaternion.LookRotation(Target.position, Vector3.up);
        // directionBullet.Normalize();
        // Vector3 a = Vector3.Cross(directionBullet, transform.forward);
        // if(Input.GetMouseButtonDown(0)){
        //rigidbodyBullet.angularVelocity = a;
        //     Debug.Log("hehe");
        // }
        Debug.DrawLine(transform.position, transform.up*1000, Color.red);
        Debug.DrawLine(transform.position, transform.forward*1000, Color.green);
        Debug.DrawLine(transform.position, transform.right*1000, Color.yellow);
        // Debug.DrawLine(transform.position,transform.position + transform.up*1000, Color.blue);
        // Debug.DrawLine(transform.position,transform.position + transform.forward*1000, Color.green);

    }
}
