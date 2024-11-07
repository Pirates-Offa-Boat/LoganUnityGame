using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonScript : MonoBehaviour
{


   private void OnTriggerStay(Collider other)
   {
      var pirate = other.GetComponent<Enemy>();

      float counter = 0;
      counter++;
      
      if(counter ==30){

         if (pirate != null)
         {

            pirate.life -= 20;         

         }
         counter = 0;
      }
   }
}
