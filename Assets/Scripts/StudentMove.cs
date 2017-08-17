using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentMove : MonoBehaviour {

    private Transform m_transform;

	// Use this for initialization
	void Start () {
        m_transform = gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            m_transform.Translate(Vector3.forward * 0.1f, Space.World);
        }
        if(Input.GetKey(KeyCode.S))
        {
            m_transform.Translate(Vector3.back * 0.1f, Space.World);
        }
        if (Input.GetKey(KeyCode.A))
        {
            m_transform.Translate(Vector3.left * 0.1f, Space.World);
        }
        if (Input.GetKey(KeyCode.D))
        {
            m_transform.Translate(Vector3.right * 0.1f, Space.World);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
    }
}

