using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public QuadraticCurve curve;
    public float speed;

    private float sampleTime;

    private void Start() {
        StartCoroutine(EHE());
    }
    private void Update() {
        // sampleTime += Time.deltaTime * speed;
        // transform.position = Vector3.Lerp(transform.position,curve.evaluate(sampleTime), Time.deltaTime);


        // transform.forward = curve.evaluate(sampleTime + 0.001f) - transform.position;

        // if(sampleTime >=1f){
        //     Debug.Log("Boom, blam, expolision, kaddosh");
        // }
    }
    public IEnumerator EHE(){
        sampleTime = 0f;
        transform.position = curve.evaluate(sampleTime);
        while(sampleTime<=1f){
            sampleTime += Time.deltaTime * speed;
            transform.position = Vector3.Lerp(transform.position,curve.evaluate(sampleTime), Time.deltaTime*10);
            transform.forward = curve.evaluate(sampleTime + 0.001f) - transform.position;
            yield return null;
        }
    }
}
