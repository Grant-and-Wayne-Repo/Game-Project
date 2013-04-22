using UnityEngine;
using System.Collections;

public class WaveSpawn : MonoBehaviour {
	public float SpawnTimer;
	public float WaveTimer;
	public float WaveTimerChange;
	public float StartingSpawnAmount;
	public float DifficultyLevel;
	public GameObject BossClone;	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(SpawnTimer > 0f)
			SpawnTimer-= Time.deltaTime;
		if(SpawnTimer < 0f)
			SpawnTimer = 0f;
		if(SpawnTimer == 0f)
		{
			for(int i = 0; i < StartingSpawnAmount; i++)
			{
				GameObject Boss = (GameObject)Instantiate(BossClone);
				Boss.transform.position = this.transform.position;	
				Boss.transform.rotation = this.transform.rotation;
				Boss.transform.rotation = Quaternion.Euler(Random.value*360, 0, 0);
			}
			SpawnTimer = WaveTimer;
			WaveTimer += WaveTimerChange;
			StartingSpawnAmount +=1;
			DifficultyLevel +=1;
		}
	
	}
}
