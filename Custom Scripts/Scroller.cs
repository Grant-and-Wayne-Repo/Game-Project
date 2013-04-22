using UnityEngine;

using System.Collections;

 

public class Scroller : MonoBehaviour 

{

    public Vector2 scrollSpeed;             // Speed to scroll the material in each direction

    

    // Update is called once per frame

    void Update () 

    {

        renderer.material.mainTextureOffset += scrollSpeed * Time.deltaTime;

    }

}

