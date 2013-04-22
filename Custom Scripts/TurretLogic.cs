using UnityEngine;
using System.Collections;

public class TurretLogic : MonoBehaviour {
	public Transform target;
	public float DetectRadius;
	//public Rigidbody projectile;
	public float attackTimer;
	public float coolDown;

	public GameObject BulletPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.rotation = Quaternion.Slerp(transform.rotation,
     	Quaternion.LookRotation(target.position - this.transform.position), rotationSpeed*Time.deltaTime);
		if(attackTimer > 0f)
			attackTimer -= Time.deltaTime;
		if(attackTimer < 0f)
			attackTimer = 0f;
		if(attackTimer == 0f)
		{
			float DistancetoTarget = Vector3.Distance(this.transform.position, target.position);
			if(DistancetoTarget <= DetectRadius)
			{
				
				GameObject bullet = (GameObject)Instantiate(BulletPrefab);
				bullet.transform.position = this.transform.position;
				bullet.transform.rotation = this.transform.rotation;
				//clone.transform.position = this.transform.forward * projectileSpeed;
			}
			attackTimer = coolDown;
		}
			
			
	}
}
