using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {
	public Transform target;
	public float DetectRadius;
	public int count;
	public GameObject StaticField;
	
	// Use this for initialization
	void Start () {
		count = 0;
	
	
	}
	
	// Update is called once per frame
	void Update () {
		
		float DistancetoTarget = Vector3.Distance(this.transform.position, target.position);
		if((DistancetoTarget <= DetectRadius)&&(count == 0))
		{
			Vector3 positioning = target.position;
			count = 1;
			StartCoroutine(Tele(positioning));
		}
	}
	IEnumerator Tele(Vector3 positioning){
		yield return new WaitForSeconds(5);
		this.transform.position = positioning;
		GameObject Field = (GameObject)Instantiate(StaticField);
		Field.transform.position = this.transform.position;
		Field.transform.rotation = this.transform.rotation;
		count = 0;
	}
}
