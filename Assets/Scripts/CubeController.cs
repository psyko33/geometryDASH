using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController: MonoBehaviour {

    private Rigidbody rb;
    public float speed = 0 ;
    public float jump = 0;
    private bool canJump = false;
    private bool isGrounded = true;
   
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector3(0, rb.velocity.y, -speed);

        if (canJump )
        {
            rb.AddForce(transform.up * jump, ForceMode.Impulse);
            canJump = false;
            isGrounded = false;
        }
    }
    private void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& isGrounded)
        {
                canJump = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("sol"))
            {
            isGrounded = true;
            }
    }
}
