using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_manager : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform instationPos;
    // Start is called before the first frame update
    public CameraFollow cameraFollow;
    void Start()
    {
        GameObject go = Instantiate(ballPrefab,instationPos.position, Quaternion.identity);
        cameraFollow.target = go.transform;
    }

    // Update is called once per frame
    
}
