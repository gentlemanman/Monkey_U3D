using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour {
    private Door m_door;
	// Use this for initialization
	void Start () {
        m_door= GameObject.Find("DoorParent").GetComponent<Door>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

     void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name=="Student")
        {
            m_door.open();
        }
    }

     void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Student")
        {
            m_door.shut();
        }
    }
}
