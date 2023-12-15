// using UnityEngine;
// using System;
// using System.Linq;
// using System.Collections.Generic;
// public class gowww : MonoBehaviour
// {
//     public GameObject tail;
//     List<Transform> bodyPart;
//     Vector2 v;
//     bool ate =false;
    
   
    
//     void OnCollisionEnter2D(Collision2D collisionInfo)
//     {
//         ate = true;
//         Move();
//     }

//     void Move()
//     {
//         v = transform.position;
        
//         if(ate)
//         {
//             GameObject g = (GameObject) Instantiate(tail,v,Quaternion.identity);
//             bodyPart.Insert(0,g.transform);
//             ate = false;
//         }

//         else if(bodyPart.Count>0)
//         {
//             // take last tail at front (just back of head)
//             bodyPart.Last().position = v;
            
//             // now move last tail transform in first posiiton of list
//             bodyPart.Insert(0,bodyPart.Last());
//             bodyPart.RemoveAt(bodyPart.Count-1);
//         }

//     }
    
// }
