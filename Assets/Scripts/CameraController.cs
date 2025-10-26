using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    float offsexX;
    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
            return;

        offsexX = transform.position.x - target.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
            return;

        Vector3 pos = transform.position;
        pos.x = target.position.x + offsexX;
        transform.position = pos;
    }
}
