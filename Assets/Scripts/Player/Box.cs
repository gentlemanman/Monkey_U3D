using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject.Destroy(gameObject,Random.Range(1,5));
	}
	
	// Update is called once per frame
}
