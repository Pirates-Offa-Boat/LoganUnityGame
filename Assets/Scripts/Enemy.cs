using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   public float life;

   private void Update()
   {
      
      if(life <=0){

         Destroy(gameObject);

      }

      
   }
}
