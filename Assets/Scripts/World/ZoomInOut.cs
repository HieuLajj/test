using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomInOut : MonoBehaviour
{
    bool isLongTouch = false;
    public float touchStartTime =0f;
void Update()
{
    if (Input.touchCount > 0)
    {
        Touch touch = Input.GetTouch(0);

        if (touch.phase == TouchPhase.Began)
        {
            // touchStartTime = Time.time;
            // isLongTouch = false;
            Debug.Log("cham");
            touchStartTime = Time.time;
        }
        else if (touch.phase == TouchPhase.Moved)
        {
            Debug.Log("di chuyen");
            // float touchEndTime = Time.time;
            // float touchDuration = touchEndTime - touchStartTime;

            // if (touchDuration > 3f)
            // {
            //     isLongTouch = true;
            // }
        } else if (touch.phase == TouchPhase.Ended)
        {
            float touchEndTime = Time.time;
            float touchDuration = touchEndTime - touchStartTime;
            if(touchDuration<0.5f){
                Debug.Log("Thời gian giữa lần chạm vào và lần bỏ chạm: " + touchDuration + " giây");
            }
            
        }
    }

    // if (isLongTouch)
    // {
    //     Debug.Log("cham qua 3s");
    //     // Thực hiện các hành động cho chạm lâu
    // }
}
}
