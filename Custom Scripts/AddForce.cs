using UnityEngine;
using System.Collections;

public class AddForce : MonoBehaviour {
	public Rigidbody ship;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		ship.AddForce(Vector3.forward * 20);
	}
}
