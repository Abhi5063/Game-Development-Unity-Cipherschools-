using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data_Types : MonoBehaviour

{
    public float speed;
    private string tag_wall = "wall";
    private string tag_Wall = "Wall_secret";
    private string Win = "win";


    void Update()
    {
        float horizontalInput=Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (horizontalInput,0.0f ,verticalInput)*speed*Time.deltaTime;
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(movement,ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == tag_wall)
        {
            Debug.Log("Collided with wall");
            ScoreManager.instance.AddScore(-1);
        }
        
        else if (collision.gameObject.tag == tag_Wall)
        {
            Debug.Log("Collided with Wall_secret");
            ScoreManager.instance.AddScore(+1);
        }
        if (collision.gameObject.tag == Win)
        {
            Debug.Log("Player entered win area");
            Timer timer = FindObjectOfType<Timer>(); // Find the Timer script in the scene
            if (timer != null)
            {
                timer.PlayerEnteredWinArea(); // Notify the Timer script that the player entered the win area
            }
        }
    }

}
