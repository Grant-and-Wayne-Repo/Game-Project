using UnityEngine;
using System.Collections;

public class MLook : MonoBehaviour {
//public Vector2 scrollSpeed; 
	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 mousePos = Input.mousePosition;
		mousePos.z = -(transform.position.x - Camera.mainCamera.transform.position.x);
		Vector3 worldPos = Camera.mainCamera.ScreenToWorldPoint(mousePos);
		transform.LookAt(worldPos);
		Vector3 buffer = new Vector3(worldPos.x *0.5f , worldPos.y *0.5f , 0);
		if(transform.position != buffer){
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
		}
		else if(transform.position == buffer)
		{
				transform.Translate(Vector3.forward * 0);
		}
		
		///renderer.material.mainTextureOffset += scrollSpeed * Time.deltaTime;
	}
}
