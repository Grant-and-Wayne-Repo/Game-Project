using UnityEngine;
using System.Collections;

public class EnemyDamage : MonoBehaviour {
	
	public float DamageDealt;
	public GameObject TheShip;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		
	
	}
	
	void OnTriggerEnter(Collider Placeholder)
	{
		ShipLife someScript;
		someScript = TheShip.GetComponent<ShipLife>();
		if(someScript.invincible == false)
		{
			
			someScript.life -= DamageDealt;
			someScript.invincible = true;
		}
	}
}
