using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    // Start is called before the first frame update
    public float Smooth = 25;    
    private Vector2 lookAt;
    public TouchInput touchInput;
    public float sensitivity = 2.0F; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lookAt.x = Mathf.Lerp(lookAt.x, touchInput.LookInput().x , Smooth * Time.deltaTime);
        lookAt.y = Mathf.Lerp(lookAt.y, touchInput.LookInput().y, Smooth * Time.deltaTime);
        // transform.Rotate(lookAt.y * (sensitivity / 10), lookAt.x * (sensitivity / 10), 0.0F);
        //transform.Rotate(0.0F, lookAt.x * (sensitivity / 10), 0.0F);
        transform.Rotate(10,0.0F, 0.0F);
        //transform.localEulerAngles = new Vector3(60, 30F, 0.0F);
    }
}
