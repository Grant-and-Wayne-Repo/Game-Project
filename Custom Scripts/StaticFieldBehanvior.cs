using UnityEngine;
using System.Collections;

public class StaticFieldBehanvior : MonoBehaviour {
	public bool test;
	public float size;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(test)
		{
		transform.localScale += new Vector3(0,2,2);
		}
		if(size > 0f)
			size -= Time.deltaTime;
		if(size < 0f)
			size = 0f;
		if(size == 0f)
		{
			test=false;
			StartCoroutine(Shrink ());
		}
	
	}
	IEnumerator Shrink(){
		yield return new WaitForSeconds(1);
		Destroy(gameObject);
	}
}
