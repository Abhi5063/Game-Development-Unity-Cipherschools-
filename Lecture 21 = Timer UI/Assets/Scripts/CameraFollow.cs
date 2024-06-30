using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    // The position of camara = position of target  = off set
    private void Update()
    {
        transform.position = target.position + offset;
    }


}
