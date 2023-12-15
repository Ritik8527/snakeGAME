using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyFood : MonoBehaviour
{
   public GameObject foods;

   void OnCollisionEnter2D(Collision2D coll)
   {
    if(coll.collider.tag == "food")
    {
        Destroy(foods);
    }
   }
}
