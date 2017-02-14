using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationY : MonoBehaviour {

    public float rotationSpeed = 1;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        this.gameObject.transform.Rotate(Vector3.up * Time.deltaTime * this.rotationSpeed, Space.World);
	}
}
