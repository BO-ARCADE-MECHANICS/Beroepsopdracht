using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteractButton : MonoBehaviour
{
    [SerializeField] private GameObject MyDoorA;

    private IDoor doorA;

    private void Awake()
    {
        doorA = MyDoorA.GetComponent<IDoor>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            doorA.ToggleDoor();
        }
    }
}
