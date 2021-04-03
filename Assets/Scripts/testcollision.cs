using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testcollision : MonoBehaviour
{
    void onCollisionEnter2D(Collider2D coll)
    {
        Debug.Log("It works!");
    }
}
