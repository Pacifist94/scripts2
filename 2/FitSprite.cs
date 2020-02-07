using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FitSprite : MonoBehaviour
{

/*
	public Vector2 origin;
	public Vector2 destination;



	
    // Start is called before the first frame update
    void Start()
    {
        

float SpriteWidth = Vector2.Distance(origin, destination);
SpriteRenderer sr; 

      sr = GetComponent<SpriteRenderer>();
      sr.drawMode = SpriteDrawMode.Tiled;
      sr.size = new Vector2(SpriteWidth,1);

transform.position = CenterOfVectors(origin, destination);   


Vector2 direction = destination - origin; 

float  angle = Vector2.Angle(Vector2.right, direction);



transform.rotation = Quaternion.Euler(0f, 0f, angle );


    }


public Vector2 CenterOfVectors( Vector2 vectorA, Vector2 vectorB  )
 {
     Vector2 sum = Vector2.zero;
    
         sum = vectorA + vectorB;
    
     return sum/2;
 }

  */

  //	public Vector2 origin;
  //	public Vector2 destination;
 /*
  	public Transform origin;
	public Transform destination;




	
    // Start is called before the first frame update
    void Start()
    {
        

float SpriteWidth = Vector2.Distance(origin.position, destination.position);
SpriteRenderer sr; 

      sr = GetComponent<SpriteRenderer>();
      sr.drawMode = SpriteDrawMode.Tiled;
      sr.size = new Vector2(SpriteWidth,1);

transform.position = CenterOfVectors(origin.position, destination.position);   


Vector2 direction = destination.position - origin.position; 

float  angle = Vector2.Angle(Vector2.right, direction);


if	(destination.position.y < origin.position.y){
	transform.rotation = Quaternion.Euler(0f, 0f, 360f -angle );


}
else{

transform.rotation = Quaternion.Euler(0f, 0f, angle );

}



    }


public Vector2 CenterOfVectors( Vector2 vectorA, Vector2 vectorB  )
 {
     Vector2 sum = Vector2.zero;
    
         sum = vectorA + vectorB;
    
     return sum/2;
 }



*/
}
