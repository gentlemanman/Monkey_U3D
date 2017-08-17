using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceTest : MonoBehaviour {
    private Rigidbody r;
	// Use this for initialization
	void Start () {
        r = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        // r.AddForce(Vector3.forward*10,ForceMode.Force);

        if(Input.GetKeyDown(KeyCode.Z))
        {
            r.AddRelativeForce(Vector3.forward * 1000, ForceMode.Force);
        }
	}

    private void FixedUpdate()
    {
        
    }
}
