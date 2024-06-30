using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public CollecablesManager collecablesManager;
    // Start is called before the first frame update
    public float timeValue = 60f;
    private bool isTimerRunning = false;
    private float currentTime;

    public Text timerText;
    private void Start()
    {
        isTimerRunning = true;  
        currentTime = timeValue;


    }
    private void Update()
    {
        if (isTimerRunning) { 
            currentTime = currentTime - Time.deltaTime;

            if(currentTime<=0.0f && !collecablesManager.allCoinCollected)
            {
                currentTime = 0.0f;
                isTimerRunning=false;

                Debug.Log("Game Lost");
            }
            if(collecablesManager.allCoinCollected) {
                Debug.Log("Game Won");
                isTimerRunning= false;
            }

            UpdateTimerText();  


        }

    }
    void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60.0f);
        int seconds = Mathf.FloorToInt(currentTime % 60.0f);
        
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);     
    }
}