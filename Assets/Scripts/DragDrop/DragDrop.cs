using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class DragDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public Vector3 a;
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("bat dau");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("ket thuc");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("dangkeo");
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        a = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z+Camera.main.nearClipPlane+1);
        Debug.Log(Input.mousePosition+"--"+ Camera.main.ScreenToWorldPoint(a));
    }
}
