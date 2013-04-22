using UnityEngine;
using System.Collections;

public class BossSpawn : MonoBehaviour {
	public float moveSpeedStart;
	public float innerCircle;
	public float moveSpeedMid;
	public float middleCircle;
	public float moveSpeedLate;
	public float outerCircle;
	public bool hit1;
	public bool hit2;
	public bool hit3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(hit1)
		{
			if(innerCircle > 0f)
				innerCircle-= Time.deltaTime;
			if(innerCircle < 0f)
				innerCircle = 0f;
			if(innerCircle == 0f)
			{
				hit1 = false;
				hit2 = true;
			}
			this.transform.Translate(transform.forward * Time.deltaTime * moveSpeedStart);
		}
		if(hit2)
		{
			if(middleCircle > 0f)
				middleCircle -= Time.deltaTime;
			if(middleCircle < 0f)
				middleCircle = 0f;
			if(innerCircle == 0f)
			{
				hit2 = false;
				hit3 = true;
			}
			this.transform.Translate(transform.forward * Time.deltaTime * moveSpeedMid);
		}
		
	}
}
