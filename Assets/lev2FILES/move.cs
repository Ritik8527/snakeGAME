using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Rigidbody2D rb;
    public float velocity;
    public float jumpVelocity;
    bool jump = true;
    void Start()
    {
         
    }
    void Update()
    {
        if(jump)
        {
            if(Input.GetAxisRaw("Horizontal") == 1)
            {
                rb.velocity = new Vector2(1f*velocity,0f);
            }
            if(Input.GetAxisRaw("Horizontal") == -1)
            {
                rb.velocity =  new Vector2(-1f*velocity , 0f) ;
            }
        }
        
        if(Input.GetKey(KeyCode.Space))
        {
            
            if(jump)
            {
                rb.AddForce(transform.up*jumpVelocity , ForceMode2D.Impulse) ;
              //  rb.velocity = new Vector2(0f , jumpVelocity);
              jump = false;
                
            }
            
        }
    }

   
    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.collider.tag == "ground")
        {
            jump=true;
            
        }
        
    }
}
