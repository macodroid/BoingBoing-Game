using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;  
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;

    private void LateUpdate()
    {
        
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothTime);
        transform.position = new Vector3(0f, smoothPosition.y, smoothPosition.z);
    }
}
