using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    //varibales
    public Transform target;

    public float smoothing;

    public Vector2 MaxPosition;
    public Vector2 MinPosition;

    // Start is called before the first frame update
    void Start()
    {

    }


    void LateUpdate()
    {
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
