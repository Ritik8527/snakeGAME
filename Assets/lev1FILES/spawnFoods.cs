using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnFoods : MonoBehaviour
{
    //bool spawn=true;
    public GameObject points;
    public Transform pointsTransform;
    bool yesAte=true;
    int x,y;
    
   
    
    void Update()
    {
        if(yesAte)
        {
            spawnPoints();
            yesAte = false;
        }
        


        
    }
    void spawnPoints()
    {
        x = (int)Random.Range(-20,20);
        y = (int)Random.Range(-19,19);
        Vector2 pos = new Vector2(x,y);
        Instantiate(points , pos,Quaternion.identity,transform);
    }

    public void snakeTouchFood()
    {
        yesAte = true;
    }
}
