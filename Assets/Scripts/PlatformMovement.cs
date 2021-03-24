using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public GameObject player;

    float dirX, moveSpeed = 3f;
    bool moveRight = true;


    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 2f)
            moveRight = false;
        if (transform.position.x < -2f)
            moveRight = true;

        if (moveRight)
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            player.transform.parent = transform;

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            player.transform.parent = null;
        }
    }
}