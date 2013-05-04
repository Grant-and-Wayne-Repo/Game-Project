using UnityEngine;
using System.Collections;

public class InstantiateEllipse : MonoBehaviour {
	public int numMinions;
	public float radiusX;
	public float radiusY;
	public Transform Boss;
	public GameObject minionPrefab;
	
	private Vector3 center;
	// Use this for initialization
	void Start () {
	center = (Boss.position);
	for(int i = 0; i <  numMinions; i++)
		{
				var g = (i * 1.0)/numMinions;
				float angle = (float)g * Mathf.PI * 2;
 
    			float x = Mathf.Sin(angle) * radiusX;
   				float y = Mathf.Cos(angle) * radiusY;
 
   				Vector3 pos = new Vector3(x, y, 0) + center;
				
				Instantiate(minionPrefab, pos, Quaternion.identity);
		}
				
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
