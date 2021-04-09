using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    //varibales
    public Transform target;

    // How the smooth the camera will follow
    public float smoothing;

    // The maximum and minimium distance the camara may travel
    public Vector2 MaxPosition;
    public Vector2 MinPosition;

    void LateUpdate()
    {
        // the code checks if it is at the target location if not go to that location
        // this means the camera will follow the player
        if (transform.position != target.position)
        {
            Vector3 targetPostition = new Vector3(target.position.x,
                                                  target.position.y,
                                                  transform.position.z);
            targetPostition.x = Mathf.Clamp(targetPostition.x,
                                            MinPosition.x,
                                            MaxPosition.x);

            targetPostition.y = Mathf.Clamp(targetPostition.y,
                                            MinPosition.y,
                                            MaxPosition.y);

            transform.position = Vector3.Lerp(transform.position,
                                                 targetPostition, smoothing);
        }
    }
}
