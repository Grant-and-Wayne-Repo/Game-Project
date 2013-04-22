using UnityEngine;
using System.Collections;

public class ExplodeTimer : MonoBehaviour {
	
	public float ExplosionTimer;
	public GameObject Explosion;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(ExplosionTimer > 0f)
			ExplosionTimer-= Time.deltaTime;
		if(ExplosionTimer < 0f)
			ExplosionTimer = 0f;
		if(ExplosionTimer == 0f)
		{
			GameObject ExplosionClone = (GameObject)Instantiate(Explosion);
			ExplosionClone.transform.position = this.transform.position;
			Destroy(gameObject);
		}	
	}
}
