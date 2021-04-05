using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimated : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // When OpenDoor is called in the script I tell the animator to set open to true
    // So that the animation transitions form close to open
    public void OpenDoor()
    {
        animator.SetBool("open", true);
    }
    // When CloseDoor is called in the script I tell the animator to set open to false
    // So that the animation transitions form open to close
    public void CloseDoor() {
        animator.SetBool("open", false);
    }
}
