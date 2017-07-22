using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {

    public bool onGround;
    private Rigidbody rb;

	// Use this for initialization
	void Start ()
    {
        onGround = true;
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (onGround)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = new Vector3(0f, 5f, 0f);
                onGround = false;
            }
        }
	}
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            onGround = true;
        }
    }
}
