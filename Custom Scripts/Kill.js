#pragma strict

function OnCollisionEnter(collision : Collision) { 
    if (collision.gameObject.tag == "Enemy"){ // if the hit object's name is Enemy...
    	Debug.Log("hit");
        Destroy(collision.gameObject); // destroy it
    }
}