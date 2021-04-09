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
        // started a piece of code that allows me to let the system wait a few sec before executing next piece of code
        // when collided with lets player respawn on respawnPoint location
        StartCoroutine(Wait());
        IEnumerator Wait()
        {
            yield return new WaitForSeconds(0);
            player.transform.position = respawnPoint.transform.position;
        }
    }

}
