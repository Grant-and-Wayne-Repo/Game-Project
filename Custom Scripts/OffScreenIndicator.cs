using UnityEngine;
using System.Collections;

public class OffScreenIndicator : MonoBehaviour {
	public GUITexture indicator;
	public GameObject target;
	// Use this for initialization
	void Start () {
	//Instantiate(indicator);
	}
	
	// Update is called once per frame
	void LateUpdate () {
		paint ();
	}
	
	void paint() {
		Vector3 screenpos = Camera.main.WorldToScreenPoint(target.transform.position);
		//Debug.Log (screenpos);
		if(screenpos.z > 0 && screenpos.x < Screen.width && screenpos.y > 0 && screenpos.y < Screen.height)
		{
			//place gui texture on transform 
			indicator.transform.position = screenpos;
		}	
		else{
			if(screenpos.z < 0)
			{
				screenpos *= -1;
			}
			Vector3 screenCenter = new Vector3(Screen.width, Screen.height,0)/2;
			screenpos -= screenCenter;
			float angle = Mathf.Atan2 (screenpos.y, screenpos.x);
			angle = 90 * Mathf.Deg2Rad;
			float cos = Mathf.Cos(angle);
			float sin = Mathf.Sin (angle);
			screenpos = screenCenter + new Vector3(sin*150, cos*150, 0);
			float m = cos/sin;
			Vector3 screenBounds = screenCenter * 0.9f;
			if(cos > 0)
			{
				screenpos = new Vector3(screenBounds.y/m, screenBounds.y, 0);
			}
			else 
			{
				screenpos = new Vector3(-screenBounds.y/m, screenBounds.y, 0);
			}
			if(screenpos.x > screenBounds.x)
			{
				screenpos = new Vector3(screenBounds.x, screenBounds.x*m, 0);
			}
			else if(screenpos.x < -screenBounds.x)
			{
				screenpos = new Vector3(-screenBounds.x, -screenBounds.x*m, 0);
			}
			screenpos += screenCenter;
			indicator.transform.position = screenpos;
			Debug.Log (indicator.transform.position);
	}
}
}
