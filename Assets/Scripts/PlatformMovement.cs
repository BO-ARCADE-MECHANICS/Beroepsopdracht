﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    float dirX, moveSpeed = 3f;
    bool moveRight = true;

    public GameObject DeathPlane;
    public float PlatformMax;
    public float PlatformMin;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > PlatformMax)
            moveRight = false;
        if (transform.position.x < PlatformMin)
            moveRight = true;

        if (moveRight)
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "tim_player")
        {
            collision.transform.parent = transform;
            DeathPlane.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "tim_player")
        {
            collision.transform.parent = null;
            DeathPlane.SetActive(true);
        }
    }
}
