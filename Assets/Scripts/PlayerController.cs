using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    Rigidbody2D rb2d;

    SurfaceEffector2D surfaceEffector2D;
    [SerializeField] float tourqueAmount = 10f;

    bool canMove = true;

    void Start()
    {
         rb2d = GetComponent<Rigidbody2D>();
         surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    void Update()
    {
        if(canMove)
        {
            RotatePlayer();
            RespondToBoost();
        }
        
    }


    public void DisableControls()
    {
        canMove = false;
    }

    void RespondToBoost()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = 25f;
            Debug.Log(surfaceEffector2D.speed);
        }
        else
        {
            surfaceEffector2D.speed = 20f;
        }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(tourqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-tourqueAmount);
        }
    }
}
