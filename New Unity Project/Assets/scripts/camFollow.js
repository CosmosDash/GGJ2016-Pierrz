#pragma strict

 var target : Transform;
 var distance : float;
 function Update(){
 
     transform.position.z = target.position.z -distance;
     transform.position.y = target.position.y + 3;
     transform.position.x = target.position.x - 1;
 
 }