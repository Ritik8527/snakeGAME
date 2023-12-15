using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementCAR : MonoBehaviour
{
    public Rigidbody2D rbCAR;
    public float speed;
    public float push;
    public Transform tyre1Rotate;
    public Transform tyre2Rotate;
    void Update()
    {
        
        if(Input.GetAxisRaw("Horizontal") == 1)
        {
            tyre1Rotate.Rotate(new Vector3(0,0,-30 * Time.deltaTime));
            tyre2Rotate.Rotate(new Vector3(0,0,-30 * Time.deltaTime));
            rbCAR.velocity = new Vector2(1f , 0f) * speed;
            
        }
        if(Input.GetKey(KeyCode.Space))
        {
            tyre1Rotate.Rotate(new Vector3(0,0,-30 * Time.deltaTime));
            tyre2Rotate.Rotate(new Vector3(0,0,-30 * Time.deltaTime));
            rbCAR.AddForce(new Vector2(1f , 0f)*push) ;
        }
    }
}
