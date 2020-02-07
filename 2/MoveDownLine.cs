using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MoveDownLine : MonoBehaviour
{
    public float speedScale;

//-------------------

        
 
//--------

// 0 = Missed , 1 = Bad, 2 = Good, 3 = Perfect

    // Start is called before the first frame update
    void Start()
    {
        speedScale = ReadersSpawnerGuideCollider._instance.SPEED;
     



/*
try{
 
LocalScoreGO = GameObject.Find("Canvas/txtScore"); 
LocalComboGO = GameObject.Find("Canvas/txtComboVal");

LocalScoreTXT = LocalScoreGO.GetComponent<Text>();
LocalComboTXT = LocalComboGO.GetComponent<Text>();


}
catch  {


} 

*/

  

//LocalScoreTXT = ScoreManager._instance.scoreTXT;
//LocalComboTXT = ScoreManager._instance.comboTXT;


    }

    // Update is called once per frame
    //void Update()
    //{
 //       transform.Translate( speedScale * Vector3.down * Time.deltaTime);


    //}


 void FixedUpdate(){

 transform.Translate( speedScale * Vector3.down * Time.deltaTime);


}




}
 



















