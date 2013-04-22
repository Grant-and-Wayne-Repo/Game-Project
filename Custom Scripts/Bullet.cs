using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	public float moveSpeed;
	public float life;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		life -= Time.deltaTime;
		transform.position += transform.forward * moveSpeed * Time.deltaTime;
		if(life < 0)
		{
			Destroy(gameObject);
		}
		
		
	
	}
}
