using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   //Dit zorgt er voor dat wanneer je het aangeeft de volgende scene uit de lijst geladen wordt. 
   //De lijst kan je vinden bij: File > Built Settings
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2); 
    }

    public void HowTo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("This doesn't work with play testing in Unity :(");
        Application.Quit();
    }
}
