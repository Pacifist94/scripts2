﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Line : MonoBehaviour
{
 
   void OnTriggerEnter2D(Collider2D col)
    {
	//audi.PlayOneShot(clips[col.gameObject.GetComponent<MoveDown>().soundID]);

  Destroy(col.gameObject);


    }

}
