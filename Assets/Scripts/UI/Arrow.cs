using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("RewardNo")){
            var multipier = other.gameObject.name;
            Debug.Log(500 * float.Parse(multipier) + "");
        }
        else{
            Debug.Log(other.gameObject.name);
        }
    }
}
