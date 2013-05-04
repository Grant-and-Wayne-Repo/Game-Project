///////////////////////////////////////////////////////////////////////////////////

var rotationMask = Vector3(0, 1, 0); //which axes to rotate around 

var rotationSpeed = 5.0; //degrees per second 

var rotateAroundObject: Transform; 

///////////////////////////////////////////////////////////////////////////////////

function FixedUpdate() { 

   if (rotateAroundObject) {//If true in the inspector orbit <rotateAroundObject>: 

    transform.RotateAround(rotateAroundObject.transform.position, 

    rotationMask, rotationSpeed * Time.deltaTime); 

   } 

   else {//not set -> rotate around own axis/axes: 

    transform.Rotate(Vector3( 

    rotationMask.x * rotationSpeed * Time.deltaTime, 

    rotationMask.y * rotationSpeed * Time.deltaTime, 

    rotationMask.z * rotationSpeed * Time.deltaTime)); 

   } 

}