using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restart : MonoBehaviour
{
    public GameObject gameOverText, RestartButton;

    // Start is called before the first frame update
    void Start()
    {
        gameOverText.SetActive(false);
        RestartButton.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Enemy"))
        {
            gameOverText.SetActive(true);
            RestartButton.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}