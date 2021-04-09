using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteractPressurePLate : MonoBehaviour
{
    [SerializeField] private GameObject doorGameObject;
    private IDoor door;
    private float timer;

    private void Awake()
    {
        door = doorGameObject.GetComponent<IDoor>();
    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       if (other.CompareTag("Object_Box"))
           {
            door.OpenDoor();
           }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Object_Box"))
        {
            door.CloseDoor();
        }
    }



}
