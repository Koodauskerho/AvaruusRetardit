using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialForce : MonoBehaviour {

    public Vector3 force;

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Rigidbody>().velocity = force;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
