using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float TorqueAmt = 15f;
    [SerializeField]
    float BoostSped = 30f;
    [SerializeField]
    float BasedSped = 15f;


    Rigidbody2D rgb2d;
    SurfaceEffector2D effectIt;
    bool CanMove = true;
    void Start()
    {
        rgb2d = GetComponent<Rigidbody2D>();
        effectIt = FindObjectOfType<SurfaceEffector2D>();
    }

    void Update()
    {
        if (CanMove == true)
        {        
        Rotate();
        RespondToBoost();
        }

        void Rotate()
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rgb2d.AddTorque(TorqueAmt);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                rgb2d.AddTorque(-TorqueAmt);
            }
        }

    }

    public void DisableControl()
    {
        CanMove = false;
    }
    void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            effectIt.speed = BoostSped;
        }
        else
        {
            effectIt.speed = BasedSped;
        }
    }
}
