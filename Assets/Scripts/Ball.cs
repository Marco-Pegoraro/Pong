using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 200.0f;

    private Rigidbody2D ballRb;

    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
        ResetBallPosition();
        AddStartForce();
    }

    public void AddStartForce()
    {
        float negativeValue = Random.Range(-1.0f, 0.5f);
        float positiveValue = Random.Range(0.5f, 1.0f);

        // Random.value return a number between 0 and 1.
        // Second part is a short if statement. If Random.value goes under 0.5f value goes -1.0, else goes 1.0
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? negativeValue : positiveValue;

        Vector2 direction = new Vector2(x, y);

        ballRb.AddForce(direction * speed);
    }

    public void ResetBallPosition()
    {
        ballRb.position = Vector3.zero;
        ballRb.velocity = Vector3.zero;
    }

    public void AddForce(Vector2 force)
    {
        ballRb.AddForce(force);
    }
}
