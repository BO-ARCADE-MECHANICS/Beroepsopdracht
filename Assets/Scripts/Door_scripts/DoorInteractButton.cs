using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteractButton : MonoBehaviour
{
    [SerializeField] private GameObject MyDoor;
    private IDoor door;

    private void Awake()
    {
        door = MyDoor.GetComponent<IDoor>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            door.ToggleDoor();
        }
    }
}
