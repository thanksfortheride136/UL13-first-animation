using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorScriptExample : MonoBehaviour
{
    int moveSpeed = 10;
    
    Animator walkingAnimation;
    // Start is called before the first frame update
    void Start()
    {
        walkingAnimation = GetComponent<Animator>(); //gets animator component
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Move();
    }

    void Move()
    {
      int currentState = walkingAnimation.GetInteger("state");
      transform.up = Vector3.up;
      transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed, 0f, 0f); 
      currentState = 0;
      Debug.Log(currentState);
    }
}

//NEEDS TO BE FIXED< CANT FIGURE OUT ANIMATION STATE LOGIC