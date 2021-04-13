using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    // creates a private varible that is visible in the inspector
    [SerializeField] private Transform player;

    [SerializeField] private Transform respawnPoint;

    void OnCollisionEnter2D(Collision2D collision)
    {
        // when collided with lets player respawn on respawnPoint location

            player.transform.position = respawnPoint.transform.position;
    }

}
