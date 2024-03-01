using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 10;

    protected Rigidbody2D paddleRb;

    void Awake()
    {
        paddleRb = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition()
    {
        paddleRb.position = new Vector2(paddleRb.position.x, 0.0f);
        paddleRb.velocity = Vector2.zero;
    }

}
