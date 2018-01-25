using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController: MonoBehaviour {

    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        //rb.AddForce(new Vector3(0, 0, ), ForceMode.Force);
	}
}
