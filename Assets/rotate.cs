using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    
   
   
    void Update()
    {
        
        if(Input.GetAxisRaw("Horizontal") == 1)
        {
            
           
            transform.Rotate (new Vector3(0,0,-70 * Time.deltaTime));
            
        }
        
    }
}
