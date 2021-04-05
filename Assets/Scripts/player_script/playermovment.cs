using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovment : MonoBehaviour
{
    public float MoveSpeed = 5f;

    public Rigidbody2D PlayerBody;
    public Animator animator;

    Vector2 movement = Vector2.zero;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

    }

    void FixedUpdate()
    {
        //PlayerBody.MovePosition(PlayerBody.position + movement * MoveSpeed * Time.fixedDeltaTime);
        this.transform.position += (Vector3)(movement * MoveSpeed * Time.fixedDeltaTime);
    }

}
