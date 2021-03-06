﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovment : MonoBehaviour
{
    public float MoveSpeed = 5f;

    public Rigidbody2D PlayerBody;
    public Animator playerAnimations;

    Vector2 movement = Vector2.zero;

    void Update()
    {
        // uses the unity's input manager to read the inputs
        // convert this inputs into movement over the x and y directions
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // give the animator the varibles so that it can convert it to animation
        playerAnimations.SetFloat("Horizontal", movement.x);
        playerAnimations.SetFloat("Vertical", movement.y);
        playerAnimations.SetFloat("Speed", movement.sqrMagnitude);

    }

    void FixedUpdate()
    {
        // Lets the player move plus it lets the player interact correctly with the platform
        this.transform.position += (Vector3)(movement * MoveSpeed * Time.fixedDeltaTime);
    }

}
