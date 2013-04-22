using UnityEngine;
using System.Collections;

public class CircleLock : MonoBehaviour {
	
	void OnCollisionEnter(Collision firstLink) {
		if(firstLink.gameObject.tag == "FirstLink")//if it is the first link 
		{
			var link = this.GetComponent("FixedJoint") as FixedJoint;
			link.connectedBody = firstLink.rigidbody;//connect the bodies to complete the circle
			transform.parent = firstLink.transform;
			var lastLink = firstLink.gameObject.GetComponent ("FixedJoint") as FixedJoint;
			lastLink.connectedBody = GameObject.Find("HullBody").rigidbody;//connect the closed circle with the ship's hull for transport
			firstLink.transform.parent = GameObject.Find ("HullBody").transform;//Make the firstLink's parent the ship's hull for smooth movement 
			//GameObject.Find ("HullBody").AddComponent("RopeLine");
			//GameObject.Find ("HullBody").GetComponent("RopeLine").target = firstLink.transform;
		}
	}
			
}
