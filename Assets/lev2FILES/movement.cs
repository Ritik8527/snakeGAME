// using UnityEngine;
// using System;
// using System.Linq;
// using System.Collections.Generic;

// public class movement : MonoBehaviour
// {   
//     public Vector2 playerPosition;
//     public float timeBtwMovement;
//     private float eachFrameTime;
//     Vector2 playerMoveDirection;
//     float c;
//     bool rotateUp;
//     public GameObject food;
//     public Transform foodTransform;
//     public Transform snakeHeadPosition;
//     Vector2 dir;
     
//     bool ate=false;
//     //INCREASING SIZE LENGTH
//     //tails
//     public GameObject tail;
//     // containing all bodyparts transform info (except head)
//     List<Transform> bodyPart;
//     // storing position in Vector2 , of head part
//     Vector2 v;
    
//     public float x=0.9f;
//     float time;
//     //NUMBER OF FOODS EATEN
//     int foodEaten;

//     public float runSpeed;

//     //hole of nextLevel
//     public GameObject hole;
//     bool holeShown;  // default false
    
//     void Awake()
//     {
//         playerPosition = new Vector2(0,0);
//         timeBtwMovement = 1f;
//         eachFrameTime = timeBtwMovement;
//         playerMoveDirection = new Vector2(1,0);
//         bodyPart = new List<Transform>();       
//     }
     
    

//     void OnCollisionEnter2D(Collision2D collisionInfo)
//     {
//         if(collisionInfo.collider.tag =="food")
//         {
//            Destroy(food);
           
//            foodEaten++;
//            ate =true;
//            //INCREASING SNAKE SIZE
//             // Instantiate(snakeBodyPart,changingSnakeBodyPosition,Quaternion.identity,transform);
//             // changingSnakeBodyPosition = new Vector2(transform.position.x + nthBodypart*playerMoveDirection.x,transform.position.y + nthBodypart*playerMoveDirection.y);
        
//             // for(int i=0;i<snakeMovePositionList.Count ; i++)
//             // {
//             //     Vector2 snakeBodyPosition = snakeMovePositionList[i];
//             //     Instantiate(snakeBodyPart , snakeBodyPosition,Quaternion.identity,transform);
                
//             // }           
//         }

//         if(collisionInfo.collider.tag == "hole")
//         {
            
            

//             // increase  buildIndex by callijg thru INVOKE after some timedelay.........
//             //...... 
//         }
//     }
    
    
//     void Update()
//     {
//         // snakeBodyPosition = new Vector2(snakeHeadPosition.position.x,snakeHeadPosition.position.y); ||  JUST USE transform.postion
//         // if(snakeMovePositionList.Count >= snakeBodySize+1)
//         // {
//         //     snakeMovePositionList.RemoveAt(snakeMovePositionList.Count-1);
//         // }
//         v = transform.position;
//         time += Time.deltaTime;

//         // INCREASING SNAKE LENGTH
//          if(ate)
//         {
//             GameObject g = (GameObject) Instantiate(tail,v,Quaternion.identity);
//             bodyPart.Insert(0,g.transform);
//             ate = false;
//         }

//         if(time>=x)
//         {
//             if(bodyPart.Count>0)
//         {
//             // take last tail at front (just back of head)
//             bodyPart.Last().position = v;
            
//             // now move last tail transform in first posiiton of list
//             bodyPart.Insert(0,bodyPart.Last());
//             bodyPart.RemoveAt(bodyPart.Count-1);
//             time -= x;
//         }
       
//         }
//         if(foodEaten>=1)
//         {
//             holeShown =true;
//         }
//         if(holeShown)
//         {
//             showHole();
//             holeShown = false;
//         }
        
        
       
//         if(Input.GetKeyDown(KeyCode.UpArrow))
//         {
//             if(playerMoveDirection.y != -1)
//             {
//             playerMoveDirection.x = 0;
//             playerMoveDirection.y = 1 ;
            
//             }
//         }
//         else if(Input.GetKeyDown(KeyCode.DownArrow))
//         {
//             if(playerMoveDirection.y != 1)
//             {
                
//             playerMoveDirection.x = 0;
//             playerMoveDirection.y = -1;
//             }
//         }
//         else if(Input.GetKeyDown(KeyCode.LeftArrow))
//         {
//             if(playerMoveDirection.x != 1)
//             {playerMoveDirection.y = 0;
//            playerMoveDirection.x = -1;}
//         }
//         else if(Input.GetKeyDown(KeyCode.RightArrow))
//         {
//             if(playerMoveDirection.x != -1)
//             {playerMoveDirection.y = 0;
//            playerMoveDirection.x = 1;}
//         }

//         eachFrameTime += Time.deltaTime;

//         if(eachFrameTime >= timeBtwMovement)
//         {
           
//             playerPosition += playerMoveDirection;
//             eachFrameTime -= timeBtwMovement;
//         }
//         // if(foodEaten<=2 )
//         // {
//         //     timeBtwMovement = 0.5f; 
//         //     x = 0.6f;    
//         // }
       

        
//         transform.position = new Vector3(playerPosition.x,playerPosition.y);    
//         transform.eulerAngles = new Vector3(0,0,GetAngleFromVector(playerMoveDirection));



        
//     }
//     void Move()
//     {
//         transform.position = new Vector3(playerPosition.x,playerPosition.y);    
//     }
//     // void Start()
//     // {
//     //     InvokeRepeating("Move" , 0.99f , 0.99f);
//     // }

//     // void Move()
//     // {
//     //     dir = new Vector2(playerPosition.x , playerPosition.y);
//     //     transform.Translate(dir);
//     // }

    

    




    
//     //roatating snake method1
//     private void RotateBy90DegreesDown()
//     {
//         // Get the current rotation of the rectangle
//         Quaternion currentRotation = transform.rotation;

//         // Calculate the new rotation by adding a 90-degree rotation along the Z-axis
//         Quaternion newRotation = currentRotation * Quaternion.Euler(0,0,c);

//         // Apply the new rotation to the rectangle
//         transform.rotation = newRotation;
//     }
//     // rotatinf the snake method2
//     private float GetAngleFromVector(Vector2 dir)
//     {
//         float n = Mathf.Atan2(dir.y , dir.x)* Mathf.Rad2Deg;
//         if(n<0)
//         {
//             n += 360;
//         }
//         return n;
//     }


//     void showHole()
//     {
        
//         Instantiate(hole , new Vector2(0,0) , Quaternion.identity);
        
//     }

     
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
//     // public GameObject snakePlayer;
//     // public Rigidbody2D rb;
//     // public SpriteRenderer sp;
//     // public Transform t;
//     // bool rotateDown = true;
//     // bool rotateUp = true;
//     // bool rotateLeft = true;
//     // bool rotateRight = false;

//     // void Update()
//     // {
//     //     //  if(Input.GetAxisRaw("Horizontal") == 1)
//     //     // {
//     //     //     // snakePlayer = GameObject.Find("snake");
//     //     //     // snakePlayer.SetActive(true);
//     //     // }
//     // }

//     // void OnCollisionEnter2D(Collision2D collisionInfo)
//     // {
//     //     if(collisionInfo.collider.tag == "food")
//     //     {
//     //         snakePlayer.SetActive(true);
//     //     }
//     // }

//     // MOVING SNAKE WITH SOME VELOCITY
//     // bool a = true;

//     // void Update()
//     // {
//     //     if(Input.GetAxisRaw("Horizontal") == 1 && a)
//     //     {
//     //         a =false;
//     //         snakePlayer.SetActive(true);
//     //     }
//     //     a = true;
//     // }
//     // void FixedUpdate()
//     // { 
//     //     if(Input.GetAxisRaw("Horizontal") == 1 && rotateRight)
//     //     {
//     //         RotateBy90DegreesDown();
//     //         rotateRight = false;
//     //         rotateUp = true;
//     //         rotateDown = true;
//     //         rotateLeft = true;
//     //         rb.velocity = new Vector2(2f,0f);
//     //     }
//     //     else if(Input.GetAxisRaw("Horizontal") == -1 && rotateLeft)
//     //     {
//     //         RotateBy90DegreesDown();
//     //         rotateLeft = false;
//     //         rotateUp = true;
//     //         rotateDown = true;
//     //         rotateRight = true;            
//     //         rb.velocity = new Vector2(-2f,0f);
//     //     }
//     //     else if(Input.GetAxisRaw("Vertical") == 1 && rotateUp)
//     //     {
//     //         RotateBy90DegreesDown();
//     //         rotateUp = false;
//     //         rotateDown = true;
//     //         rotateRight = true;
//     //         rotateLeft = true;
//     //         rb.velocity = new Vector2(0f,2f);
//     //     }
//     //     else if(Input.GetAxisRaw("Vertical") == -1 && rotateDown)
//     //     {

//     //         RotateBy90DegreesDown();         
//     //         rotateDown = false;
//     //         rotateUp =true;
//     //         rotateRight = true;
//     //         rotateLeft = true;
//     //         rb.velocity = new Vector2(0f,-2f);
//     //     }

//     // }
    

    

     
    

    
   
// }
