using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatBoxs : MonoBehaviour
{
	public GameObject goPrefab;
	// Use this for initialization
	void Start ()
	{
		//Invoke("CreatMoreBox",4);
		InvokeRepeating("CreatMoreBox",1.0f,1.0f);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			CreatMoreBox ();
		}
		if (Input.GetKeyDown (KeyCode.C)) {
			CancelInvoke();
		}
	}

	void CreatMoreBox ()
	{
		for (int i = 0; i < 5; i++) {
			Vector3 position = new Vector3 (Random.Range (-10, 10), 1, Random.Range (-10, 10));
			GameObject.Instantiate (goPrefab, position, Quaternion.identity);
		}
	}
}
