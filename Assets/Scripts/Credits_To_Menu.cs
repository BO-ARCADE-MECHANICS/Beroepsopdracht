using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits_To_Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Back_To_Menu");
    }

    private IEnumerator Back_To_Menu ()
    {
        yield return new WaitForSeconds(21);
        SceneManager.LoadScene("Start_screen");
    }

}
