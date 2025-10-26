using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;      
    public float CameraSpeed = 5f; 

    private void LateUpdate()
    {
        if (target == null) return;

        Vector3 newPos = transform.position;
        newPos.x = target.position.x;
        newPos.y = target.position.y; 
        transform.position = Vector3.Lerp(transform.position, newPos, CameraSpeed * Time.deltaTime);
    }
}
