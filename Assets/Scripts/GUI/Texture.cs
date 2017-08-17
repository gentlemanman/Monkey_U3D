using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Texture : MonoBehaviour {
    private GUITexture m;
	// Use this for initialization
	void Start () {
        m = gameObject.GetComponent<GUITexture>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseEnter()
    {
        m.color = Color.blue;
    }
    private void OnMouseExit()
    {
        m.color = Color.green;
    }
    private void OnMouseDown()
    {
        m.color = Color.red;
    }
}
