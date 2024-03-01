using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 direction;

    private float verticalInput;

    void Start()
    {
        
    }

    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");

        direction = Vector2.up * verticalInput;
    }

    void FixedUpdate()
    {
        if (direction.sqrMagnitude != 0)
        {
            paddleRb.AddForce(direction * speed);
        }
    }
}
