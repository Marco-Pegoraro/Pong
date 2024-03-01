using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : Paddle
{
    [SerializeField] private Rigidbody2D ball;

    void FixedUpdate()
    {
        if (ball.velocity.x > 0)
        {
            if (ball.position.y > transform.position.y)
            {
                paddleRb.AddForce(Vector2.up * speed);
            }
            else
            {
                paddleRb.AddForce(Vector2.down * speed);
            }
        }
        else
        {
            if (transform.position.y > 0)
            {
                paddleRb.AddForce(Vector2.down * speed);
            }
            else
            {
                paddleRb.AddForce(Vector2.up * speed);
            }
        }
    }
}
