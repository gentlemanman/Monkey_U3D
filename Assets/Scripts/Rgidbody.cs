using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rgidbody : MonoBehaviour {
    private Rigidbody r;
    private Transform t;
	// Use this for initialization
	void Start () {
        r = gameObject.GetComponent<Rigidbody>();
        t = gameObject.GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            r.MovePosition(t.position+Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            r.MovePosition(t.position + Vector3.back);
        }
        if (Input.GetKey(KeyCode.A))
        {
            r.MovePosition(t.position + Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            r.MovePosition(t.position + Vector3.right);
        }
    }
}
