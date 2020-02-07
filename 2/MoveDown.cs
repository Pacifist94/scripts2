using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MoveDown : MonoBehaviour
{
    public float speedScale;
    public sbyte soundID;

public sbyte prefabid ;  
   // public bool wasCol2dDisabled = false;
    public Collider2D col2d;

public GameObject LocalScoreGO;  
public GameObject LocalComboGO;

public Text LocalScoreTXT;
public Text LocalComboTXT;



public bool isCalculable;
public bool isTouchable;
//-------------------

 ScoreManager SM;
        
 
//--------

// 0 = Missed , 1 = Bad, 2 = Good, 3 = Perfect
    public sbyte status = 0; // JUST cHANGED FROM 0 -3   

    // Start is called before the first frame update
    void Start()
    {
        speedScale = ReadersSpawnerGuideCollider._instance.SPEED;
        
        col2d = GetComponent<Collider2D>();



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
SM = (ScoreManager)FindObjectOfType(typeof(ScoreManager));
 

//LocalScoreTXT = ScoreManager._instance.scoreTXT;
//LocalComboTXT = ScoreManager._instance.comboTXT;


    }

    // Update is called once per frame
    void Update()
    {
       

//TOUCH
if (isCalculable){

                for (int i = 0; i < Input.touchCount; i++) //JUST READDED
               
//JUST REMOVED                if  (true)
                {
                    // Convert Screen Coordinated to WorldPoint
                   Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(i).position);//JUST READDED
                    Vector2 touchPos = new Vector2(wp.x, wp.y);//JUST READDED

                //    if (!wasCol2dDisabled)// Prefab is TAP and the collider is not disabled yet
                  //  {



                        //Checks if Position is withing Collider and Phase is Began
                        /*isTouchable*/ 



                        // IF PREFAB ID = 1  TAP

                        if(prefabid == 1){


                        if (  col2d == Physics2D.OverlapPoint(touchPos) && Input.GetTouch(i).phase == TouchPhase.Began)
                        {
                        Debug.Log("Entered prefab 1");

                            Destroyer._instance.PlayAudio(soundID);

                             switch (status)
                            {
                              case 1://bad
                            SM.SetActiveCombo(false);
                           SM.AddScore(status);
                            SM.ResetCombo();
                           //--- ScoreManager._instance.SetActiveCombo(false);
                           //--- ScoreManager._instance.AddScore(status);
                           
                           //--- LocalScoreTXT.text =  Mathf.RoundToInt(ScoreManager._instance.currentScore).ToString();
                            //--ScoreManager._instance.ResetCombo();  
                            //  
                            SM.SpanwAtVector(status, transform.position);

                   

                                  break;
                              case 2://Good

                            SM.AddScore(status);
                            SM.AddCombo(1);
                            

//--                            ScoreManager._instance.AddScore(status);
//--                            LocalScoreTXT.text =  Mathf.RoundToInt(ScoreManager._instance.currentScore).ToString();
//--                            ScoreManager._instance.AddCombo(1);
//--                            LocalComboTXT.text =  Mathf.RoundToInt(ScoreManager._instance.currentCombo).ToString();

  
                                if(SM.currentCombo > 1){
                                SM.AnimateCombo();

                                }
                        

//--                            if(ScoreManager._instance.currentCombo > 1){
//--                                ScoreManager._instance.AnimateCombo();
//--
//--                            }


                            
                                    SM.SpanwAtVector(status, transform.position);
                                  break;
                              case 3://Perfect
                            SM.AddScore(status);
                           //-- LocalScoreTXT.text =  Mathf.RoundToInt(ScoreManager._instance.currentScore).ToString();
                            SM.AddCombo(1);
                            //--LocalComboTXT.text =  Mathf.RoundToInt(ScoreManager._instance.currentCombo).ToString();



                            if(SM.currentCombo > 1){
                                SM.AnimateCombo();  
                            }       

                            SM.SpanwAtVector(status, new Vector3(transform.position.x, 1.75f, transform.position.z) );                            
                            break;
                            

                              default:
                                  
                                  break;
                            }

                            


                                col2d.enabled = false;
//                                wasCol2dDisabled = true;
                            Destroy(gameObject); 


                            ///////////COMMENT START
                            // Bad Tap
                           /*
                            if (transform.position.y >= my_UpperLimitBad || transform.position.y <= my_DownerLimitBad) // Bad
                            {
                                //TEMPOPTIMIZED  PM.ResetCombo();
                                PM.sp.SpawnAudio(soundID);

                                //DO BAD TAP ANIMATION 
                                myAnimator.enabled = false;
                                myAnimator.enabled = true;
                                myAnimator.Play("TapBad");

                                StartCoroutine(DisableGameObject());
                            }
                            // Excellent Tap
                            else if (transform.position.y > my_DownerLimitGood && transform.position.y < my_UpperLimitGood) //Excellent
                            {

                                  SM.AddToCombo();

                                PM.sp.SpawnAudio(soundID);
                                //DO EXCELLENT TAP ANIMATION 
                                myAnimator.enabled = false;
                                myAnimator.enabled = true;
                                myAnimator.Play("TapExcellent");

                                StartCoroutine(DisableGameObject());
                            }
                            else // Good Tap
                            {

                                 SM.AddToCombo();

                                PM.sp.SpawnAudio(soundID);

                                //DO GOOD TAP ANIMATION 
                                myAnimator.enabled = false;
                                myAnimator.enabled = true;
                                myAnimator.Play("TapGood");

                                StartCoroutine(DisableGameObject());
                            }*/


                        
                         
                          
                            }



                        }



                        // IF PREFAB ID = 2  Hold -----------------------------------------------------------

                        if(prefabid == 2){
                            if (   (col2d == Physics2D.OverlapPoint(touchPos))  &&  ( (Input.GetTouch(i).phase == TouchPhase.Moved) || (Input.GetTouch(i).phase == TouchPhase.Stationary) || (Input.GetTouch(i).phase == TouchPhase.Began)) )
                            { 

                                Debug.Log("Entered prefab 2");

                            Destroyer._instance.PlayAudio(soundID);

                             switch (status)
                            {
                              case 1://bad
                              Debug.Log("Entered bad p2");
                            SM.SetActiveCombo(false);
                           SM.AddScore(status);
                            SM.ResetCombo();
                           //--- ScoreManager._instance.SetActiveCombo(false);
                           //--- ScoreManager._instance.AddScore(status);
                           
                           //--- LocalScoreTXT.text =  Mathf.RoundToInt(ScoreManager._instance.currentScore).ToString();
                            //--ScoreManager._instance.ResetCombo();  
                            //  
                            SM.SpanwAtVector(status, transform.position);

                   

                                  break;
                              case 2://Good
        Debug.Log("Entered good p2");
                           SM.AddScore(3);
                           //-- LocalScoreTXT.text =  Mathf.RoundToInt(ScoreManager._instance.currentScore).ToString();
                            SM.AddCombo(1);
                            //--LocalComboTXT.text =  Mathf.RoundToInt(ScoreManager._instance.currentCombo).ToString();



                            if(SM.currentCombo > 1){
                                SM.AnimateCombo();  
                            }       

                            SM.SpanwAtVector(3, new Vector3(transform.position.x, 1.75f, transform.position.z) );     
                            
                            break;
           

                             case 3://Perfect
                                     Debug.Log("Entered perfect p2");
                            SM.AddScore(status);
                           //-- LocalScoreTXT.text =  Mathf.RoundToInt(ScoreManager._instance.currentScore).ToString();
                            SM.AddCombo(1);
                            //--LocalComboTXT.text =  Mathf.RoundToInt(ScoreManager._instance.currentCombo).ToString();



                            if(SM.currentCombo > 1){
                                SM.AnimateCombo();  
                            }       

                            SM.SpanwAtVector(status, new Vector3(transform.position.x, 1.75f, transform.position.z) );                            
                            break;
                            

                              default:
                                  
                                  break;
                            }

                            


                                 col2d.enabled = false;
    //                             wasCol2dDisabled = true;
                            Destroy(gameObject); 


                        }




                        }

 


                    //}
                }




}

    }



 void FixedUpdate(){

 transform.Translate( speedScale * Vector3.down * Time.deltaTime); 


}




}
 



















