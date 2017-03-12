using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EllipticalCurve : MonoBehaviour {

    public float a;
    public float b;
    public float x;
    public float y;
    public float alpha;
    public float X;
    public float Y;

     
     
    void Update()
    {
        alpha += 10;
        ;
        X = x + (a * Mathf.Cos(alpha * .005f));
        Y = y + (b * Mathf.Sin(alpha * .005f));
        this.gameObject.transform.position = new Vector3(X, 4.5f, Y);
    }
}
