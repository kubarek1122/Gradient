using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;

    public float smoothSpeed = 0.04f;
    public float smoothSpeed2 = 0.05f;
    public float smoothReturn = 0.125f;
    private Vector3 start;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.position;
        start = transform.position;
    }
    void FixedUpdate()
    {
        if (player.transform.position.y <= 1.4)
        {
            if (player.position.y > 1.4)
                smoothSpeed = smoothSpeed2;
            else
                smoothSpeed = 0.04f;
            if (player.transform.position.y < 1.2)
            {
                Vector3 desiredPosition = start;
                Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothReturn);
                transform.position = smoothedPosition;
            }
            if (player.transform.position.y >= 1.2)
            {
                Vector3 desiredPosition = player.position + offset;
                Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
                transform.position = smoothedPosition;
            }
        }
    }
}
