using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
    private Transform m_Transform;
    // Use this for initialization
    void Start () {
        m_Transform = gameObject.GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
		if(m_Transform.position.y<-5)
        {
            GameObject.Destroy(gameObject);
        }
	}
}
