using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour {
	private Transform m_Transform;
	private GUIText m_GUIText;
	// Use this for initialization
	void Start () {
		m_Transform=gameObject.GetComponent<Transform>();

		m_GUIText=GameObject.Find("Score").GetComponent<GUIText>();
	}
	
	// Update is called once per frame
	void Update () {
		m_Transform.Rotate(Vector3.forward,10);
	}

	public void addScore ()
	{
		int s=int.Parse(m_GUIText.text);
		m_GUIText.text=(s+1).ToString();
	}
}
