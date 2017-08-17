using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private Rigidbody r;
	private Transform t;

	public GameObject prefab_gold;
	// Use this for initialization
	void Start ()
	{
		r = gameObject.GetComponent<Rigidbody> ();
		t = gameObject.GetComponent<Transform> ();

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.W)) {
			r.MovePosition (t.position + Vector3.forward * 0.2f);
		}
		if (Input.GetKey (KeyCode.S)) {
			r.MovePosition (t.position + Vector3.back * 0.2f);
		}
		if (Input.GetKey (KeyCode.A)) {
			r.MovePosition (t.position + Vector3.left * 0.2f);
		}
		if (Input.GetKey (KeyCode.D)) {
			r.MovePosition (t.position + Vector3.right * 0.2f);
		}
	}

	void OnCollisionEnter (Collision coll)
	{
		if (coll.gameObject.tag == "Box") {
			Vector3 position= coll.gameObject.transform.position;
			GameObject.Destroy(coll.gameObject);
			GameObject.Instantiate(prefab_gold,position+Vector3.forward*0.2f,Quaternion.identity);

		}
	}

	void OnTriggerEnter (Collider coll)
	{
		if (coll.gameObject.tag == "Gold") {
			coll.gameObject.SendMessage("addScore");
			//coll.gameObject.GetComponent<Gold>().addScore();
			GameObject.Destroy(coll.gameObject);
		}
	}
}
