using UnityEngine;
using System.Collections;

public class ScreenPoints : MonoBehaviour {
	public float score;
	public GUIText addScore;
	public Vector3 scorePosition; 
	public Camera cam;
	public GameObject explosion;
	
	private string plus;
	// Use this for initialization
	void Start () {
		score = 0;
		scorePosition = cam.WorldToViewportPoint(this.transform.position); //+ Vector2(-.025, .01);
		plus = "+";
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Mouse0)){
		score += 10;
		var pointClone = Instantiate(addScore, scorePosition, Quaternion.identity) as GUIText;
		pointClone.text = plus + score.ToString();
		var explodeClone = Instantiate (explosion, scorePosition, Quaternion.identity) as GameObject;
		Destroy(explodeClone, 1);
		Destroy(pointClone, .75f);}
		
	}
}
