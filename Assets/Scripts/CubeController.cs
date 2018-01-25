using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController: MonoBehaviour {

    private Rigidbody rb;
    public float speed = 0 ;
    public float jump = 0;
    private bool canJump = true;
   
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector3(0, rb.velocity.y, speed);

        if ( Input.GetKeyDown(KeyCode.Space) ) 
            {
            canJump = false;
              rb.AddForce(transform.up * jump, ForceMode.Impulse);
            }
    }
    }
