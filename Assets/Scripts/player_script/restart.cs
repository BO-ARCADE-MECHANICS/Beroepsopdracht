using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restart : MonoBehaviour
{
    public GameObject gameOverText, RestartButton;

    public GameObject heart1, heart2, heart3;
    public int playerHealth = 3;
    int playerLayer, enemyLayer;
    bool coroutineAllowed = true;
    Color color;
    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        playerLayer = this.gameObject.layer;
        enemyLayer = LayerMask.NameToLayer("Enemy");
        Physics2D.IgnoreLayerCollision(playerLayer, enemyLayer, false);
        heart1 = GameObject.Find("Heart01");
        heart2 = GameObject.Find("Heart02");
        heart3 = GameObject.Find("Heart03");
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        rend = GetComponent<Renderer>();
        color = rend.material.color;

        gameOverText.SetActive(false);
        RestartButton.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Enemy"))
        {
            playerHealth -= 1;
            switch (playerHealth)
            {
                case 2:
                    heart3.gameObject.SetActive(false);
                    if (coroutineAllowed)
                        StartCoroutine("Immortal");
                    break;
                case 1:
                    heart2.gameObject.SetActive(false);
                    if (coroutineAllowed)
                        StartCoroutine("Immortal");
                    break;
                case 0:
                    heart1.gameObject.SetActive(false);
                    if (coroutineAllowed)
                        StartCoroutine("Immortal");
                    break;
            }

            if (playerHealth < 1)
            {
                gameOverText.SetActive(true);
                RestartButton.SetActive(true);
                gameObject.SetActive(false);
            }
        }
    }

    IEnumerator Immortal()
    {
        coroutineAllowed = false;
        Physics2D.IgnoreLayerCollision(playerLayer, enemyLayer, true);
        color.a = 0.5f;
        rend.material.color = color;
        yield return new WaitForSeconds(1);
        Physics2D.IgnoreLayerCollision(playerLayer, enemyLayer, false);
        color.a = 1f;
        rend.material.color = color;
        coroutineAllowed = true;
    }
}