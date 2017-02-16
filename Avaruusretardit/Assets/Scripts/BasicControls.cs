using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicControls : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Rigidbody body = GetComponent<Rigidbody>();
        float verticalmove = Input.GetAxis("Vertical") / 2;
        float horizontalmove = Input.GetAxis("Horizontal") / 2;
        float forwardmove = Input.GetAxis("Forward") * speed;
        float rotation = Input.GetAxis("Rotate") / 2;
        
        body.AddRelativeForce(0.0f, 0.0f, forwardmove);

        body.AddRelativeTorque(0.0f, 0.0f, rotation); 
        body.AddRelativeTorque(0.0f, horizontalmove, 0.0f);
        body.AddRelativeTorque(verticalmove, 0.0f, 0.0f);
	}
}
