using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileCollider : MonoBehaviour
{


	//Tile_Sprite Variables

public GameObject Tile_Prefab ;

public GameObject Tile_PrefabScript ;

public GameObject Parent ;

GameObject Origin;
GameObject Destination;

//public Vector2 Temp_Point;



  void OnTriggerEnter2D(Collider2D col)
    {
  	
//Debug.Log(col.gameObject.GetComponent<MoveDown>().prefabid);



   //--------------------------------------------------

	if	(col.gameObject.GetComponent<MoveDown>().prefabid == 2){

		




// Check if GO is null
   if( Origin == null ){

      // Set Origin
      Origin =    col.gameObject;
   }
   else{  // Origin was already set up

      // Set Destination
      Destination = col.gameObject;

      //Having both GO set up we will spawn based on objects position if magitude is 5 or less

         if( Vector2.Distance(Origin.transform.position, Destination.transform.position)  <  5f ){
            SpawnFunction(Origin.transform.position,  Destination.transform.position);
         
          	//Change the Origin
         	Origin = Destination;

         	//Set Destination to null
         	Destination = null;
         }
         else{ // it is too far
         
              // Set that new object as Origin
            Origin =    col.gameObject;
         }

   }





 
	}




//            GuideColRef.transform.position = new Vector3(4, GuideColRef.transform.position.y -AMOUNT_TO_MOVE, 1);


	//audi.PlayOneShot(clips[col.gameObject.GetComponent<MoveDown>().soundID]);
//	col.gameObject.GetComponent<MoveDown>().isTouchable = true;

/*
//start tile script
            if(prefab_id == 3){

            	if(Previous_Point == null){
					Previous_Point = prefabs[prefab_id].gameObject;

					Debug.Log(Previous_Point.transform.position);

            	}
            }  

//end tile script
*/

    }





/*



void OnTriggerEntered2D(Collider2d col){

   



}


*/





    


public Vector2 CenterOfVectors( Vector2 vectorA, Vector2 vectorB  )
 {
     Vector2 sum = Vector2.zero;
    
         sum = vectorA + vectorB;
    
     return sum/2;
 }




void SpawnFunction(Vector2 vO,  Vector2 vD){


	float SpriteWidth = Vector2.Distance(vO, vD);
	SpriteRenderer sr; 

	sr = Tile_Prefab.GetComponent<SpriteRenderer>();
  	sr.drawMode = SpriteDrawMode.Tiled;
  	sr.size = new Vector2(SpriteWidth,1);

	Tile_Prefab.transform.position = CenterOfVectors(vO, vD);   


	Vector2 direction = vD - vO; 

	float  angle = Vector2.Angle(Vector2.right, direction);


	if	(vD.y < vO.y){
		Tile_Prefab.transform.rotation = Quaternion.Euler(0f, 0f, 360f -angle );


	}
	else{

	Tile_Prefab.transform.rotation = Quaternion.Euler(0f, 0f, angle );

	}
	 



	GameObject GO = Instantiate(Tile_PrefabScript, Tile_Prefab.transform.position, Tile_Prefab.transform.rotation);
	
	GameObject GOParent  = Instantiate(Parent, Tile_Prefab.transform.position, Quaternion.identity); 

	GO.transform.parent = GOParent.transform; 


}


}
