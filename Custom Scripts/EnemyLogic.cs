using UnityEngine;
using System.Collections;

public class EnemyLogic : MonoBehaviour {
	public Transform target;
	public float DetectRadius;
	public Rigidbody projectile;
	public float projectileSpeed;
	public float rotationSpeed;
	public float moveSpeed;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		float DistancetoTarget = Vector3.Distance(this.transform.position, target.position);
		if(DistancetoTarget <= DetectRadius)
		{
			transform.rotation = Quaternion.Slerp(transform.rotation,
     		Quaternion.LookRotation(target.position - transform.position), rotationSpeed*Time.deltaTime);
 
    		//move towards the player
    		transform.position += transform.forward * moveSpeed * Time.deltaTime;
		}
	}
	
}
