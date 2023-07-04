using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class TouchInput : MonoBehaviour
{
    // Start is called before the first frame update
    private EventTrigger eventTrigger;
    private Vector2 touchInput, prevDelta, dragInput;
    private bool isPressed;
    void Start()
    {
        //find eventTrigger
        eventTrigger = transform.GetComponent<EventTrigger>();

        //add PointerDown
        var a = new EventTrigger.TriggerEvent();
        a.AddListener(data => {
           var evData = (PointerEventData)data;
           isPressed = true;
           prevDelta = dragInput = evData.position;
        });
        EventTrigger.Entry event1 = new EventTrigger.Entry(){
            callback=a,
            eventID = EventTriggerType.PointerDown
        };
        eventTrigger.triggers.Add(event1);

        // Drag
        var c = new EventTrigger.TriggerEvent();
        c.AddListener(data => {
           var evData = (PointerEventData)data;
           dragInput = evData.position;
        });
        EventTrigger.Entry event3 = new EventTrigger.Entry(){
            callback=c,
            eventID = EventTriggerType.Drag
        };
        eventTrigger.triggers.Add(event3);

        //add EndDrag
        var b = new EventTrigger.TriggerEvent();
        b.AddListener(data => {
           var evData = (PointerEventData)data;
           touchInput = Vector2.zero;
        });
        EventTrigger.Entry event2 = new EventTrigger.Entry(){
            callback=b,
            eventID = EventTriggerType.EndDrag
        };
        eventTrigger.triggers.Add(event2);
    }
    private void Update() {
        touchInput = (dragInput - prevDelta) / Time.deltaTime;
        prevDelta = dragInput;
        Debug.Log(touchInput);
    }
    public Vector2 LookInput(){
        return touchInput * Time.deltaTime;
    }

}
