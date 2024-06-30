using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Ball collied");
            Invoke("Destroycollectables",1.5f);

        }
    }
    void Destroycollectables()
    {
        Destroy(this.gameObject);
    }
}
