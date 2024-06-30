using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollecablesManager : MonoBehaviour
{
    int childCount = 0;
    [HideInInspector]public bool allCoinCollected = false;
    private void Start()
    {
        childCount = transform.childCount;
        
    }

    private void Update()
    {
        if(transform.childCount <childCount)
        {
            Debug.Log("A child obj. has been destroyed");

            childCount = transform.childCount;

            if(childCount == 0)
            {
                allCoinCollected = true;
            }
        }
    }
}
