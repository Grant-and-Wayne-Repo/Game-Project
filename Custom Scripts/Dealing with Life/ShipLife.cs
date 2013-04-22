using UnityEngine;
using System.Collections;

public class ShipLife : MonoBehaviour {
	
	public float life;
	public bool invincible;
	public float InvincibleTimer; 
	public float CoolDown;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(invincible == true)
		{
			if(InvincibleTimer > 0f)
				InvincibleTimer-= Time.deltaTime;
			if(InvincibleTimer < 0f)
				InvincibleTimer = 0f;
			if(InvincibleTimer == 0f)
			{
				invincible = false;
				InvincibleTimer = CoolDown;
			}	
		}
		if(life <= 0)
		{
			Destroy(gameObject);
		}
	
	}
}
