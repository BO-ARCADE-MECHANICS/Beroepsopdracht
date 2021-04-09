using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sign : MonoBehaviour
{
    public GameObject DialogBox;
    public Text DialogText;
    public string Dialog;
    public bool PlayerInRange;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && PlayerInRange)
        {
            if (DialogBox.activeInHierarchy) {
                DialogBox.SetActive(false);
            } else {
                DialogBox.SetActive(true);
                DialogText.text = Dialog;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // checks if player is in range of the sign
        if (other.CompareTag("Player"))
        {
            PlayerInRange = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInRange = false;
            DialogBox.SetActive(false);
        }
    }
}
