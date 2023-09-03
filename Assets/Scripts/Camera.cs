using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;
    public Vector3 targetOffset;
    void Start()
    {
        targetOffset = transform.position - target.position;
    }

    
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + targetOffset, .125f);
    }
}
