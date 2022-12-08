using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour
{
   [SerializeField] private float speed;
   [SerializeField] private float destroyRange;
   

   private void Update()
   {
         Move();
         DestroyFood();
   }

   private void Move()
   {
      transform.Translate(Vector3.forward * (Time.deltaTime * speed));
   }

   private void DestroyFood()
   {
       if (transform.position.z > destroyRange)
       {
           Destroy(gameObject);
       }
   }
}
