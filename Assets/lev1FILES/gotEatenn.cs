using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gotEatenn : MonoBehaviour
{
    public GameObject food;
   void OnCollisionEnter2D(Collision2D collisionInfo)
   {
    if(collisionInfo.collider.tag == "snake")
    {
        FindObjectOfType<spawnFoods>().snakeTouchFood();
        Destroy(food);
        
    }
   }
}
