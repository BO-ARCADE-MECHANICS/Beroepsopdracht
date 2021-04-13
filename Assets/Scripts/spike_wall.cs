using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spike_wall : MonoBehaviour
{
    float dirX, moveSpeed = 2f;
    bool moveRight = true;
    public float MaxPos;
    public float MinPos;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > MaxPos)
            moveRight = false;
        if (transform.position.x < MinPos)
            moveRight = true;

        if (moveRight)
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
    }
}
