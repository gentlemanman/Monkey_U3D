using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("任务一");
		Debug.Log("任务二");
		StartCoroutine("Task");
		Debug.Log("任务四");
	}

	IEnumerator Task ()
	{
		yield return new WaitForSeconds(2);
		Debug.Log("任务三");
	}
}
