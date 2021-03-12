using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree: MonoBehaviour
{
    [Header("Set in Inspector")]
    //Prefab for instantiating apples
    public GameObject applePrefab;

    //Speed at which the AppleTree move
    public float speed =1f;

    //Distance where AppleTree turns around
    public float leftAndRightEdge =20f;

    //Chance that the AppleTree will change direction
    public float chanceToChangeDirection = .1f;

    //Rate at which Apples 
    public float secondsBetweenAppleDrop = 1f; 

    void Start()
    {
        //Dropping apples every second    
        Invoke("DropApple",2f); 
    }

    
    void Update()
    {
        //Basic Movement
        Vector3 pos = transform.position; 
        pos.x += speed * Time.deltaTime; 
        transform.position = pos;

        // Changing Direction   
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);// Move right     
        }
        
        else if( pos.x > leftAndRightEdge ) 
        {
            speed = -Mathf.Abs(speed);   // Move left      
        }

        
    }

    void fixedUpdate()
    {
        if (Random.value < chanceToChangeDirection)
        {
            speed *= -1; //Change direction  
        }
    }

    void DropApple()
    {
        GameObject apple = Instantiate(applePrefab) as GameObject;
        apple.transform.position = transform.position;
        Invoke("DropApple", secondsBetweenAppleDrop);
    }
}
