using UnityEngine;
using System.Collections;

public class GUI_Layout : MonoBehaviour {
	//public GUIText cash;
	//public Texture2D health;
		public GUIStyle style;
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame 
	void OnGUI () { 
		    GUI.Label (new Rect (10, 525, 50, 50), "CASH $: 0", style);
			//GUI.Label (new Rect (30, 40, health.width, health.height),health);
			var timeString = System.DateTime.Now.ToString("mm:ss");
			var timeRect = new Rect(10, 500, 50, 50);
			GUI.Label (timeRect, timeString, style);
			//GUI.Label (timeRect, timeString);
	}
}
