using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parashute : MonoBehaviour
{
    public GameObject player;
    public GameObject parashutePlayer;
    bool touch;
    void Update()
    {
        if(touch)
        {
            pFollowPlayer();
        }

    }
    void OnTriggerEnter2D()
    {
        touch = true;
        
        
    }
    void pFollowPlayer()
    {
        parashutePlayer.transform.position = player.transform.position;
    }
}
