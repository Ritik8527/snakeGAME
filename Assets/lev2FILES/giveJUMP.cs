using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giveJUMP : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D rbP;
    public Vector2 forceDirection;
    public float thrust = 2f;
    void Awake()
    {
        forceDirection = new Vector2(1f,0.05f);
    }
    void OnTriggerEnter2D()
    {
        rbP.AddForce(forceDirection*thrust,ForceMode2D.Impulse);
    }
}
