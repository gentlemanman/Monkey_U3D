using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
    private Transform t;
	// Use this for initialization
	void Start () {
        t = gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Z))

            open();

        if (Input.GetKeyUp(KeyCode.Z))

            shut();
    }

    public void open()
    {
        t.Rotate(Vector3.up, 90);
    }

    public void shut()
    {
        t.Rotate(Vector3.up, -90);
    }
}
