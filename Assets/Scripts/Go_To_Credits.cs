using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go_To_Credits : MonoBehaviour
{
        void OnCollisionEnter2D(Collision2D col)
        {
            if (col.gameObject.tag.Equals("Player"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
        
}
