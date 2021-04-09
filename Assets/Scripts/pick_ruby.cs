using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pick_ruby : MonoBehaviour
{
    public GameObject Ruby_Score;
    void OnCollisionEnter2D(Collision2D collision)
    {
        // If the player collided with the ruby the score count of the ruby goes up by one
        // after that disable Ruby
        if (collision.transform.name == "tim_player")
        {
            Ruby_Score.GetComponent<score>().RubyCount += 1;
            gameObject.SetActive(false);
        }
    }
}
