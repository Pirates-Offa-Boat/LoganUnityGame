using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
   public Rigidbody body;
   // Start is called before the first frame update
   void Start()
   {
      body = GetComponent<Rigidbody>();
   }

   // Update is called once per frame
   void Update()
   {
      if (Input.GetKeyDown(KeyCode.W))
      {
         body.velocity = new Vector3(0, 6, 0);
      }

      if (Input.GetKey(KeyCode.D))
      {
         body.velocity = new Vector3(5, 0, 0);
      }
      if (Input.GetKey(KeyCode.A))
      {
         body.velocity = new Vector3(-5, 0, 0);
      }
   }
}
