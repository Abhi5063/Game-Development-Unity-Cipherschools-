using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeValue = 60f;
    private bool isTimerRunning = false;
    private float currentTime;
    //private int coinsCollected = 0;
    private bool playerInWinArea = false;

    public Text timerText;
    public int winScore = 20;
    public int loseScore = -5;

    private void Start()
    {
        isTimerRunning = true;
        currentTime = timeValue;
    }

    private void Update()
    {
        if (isTimerRunning)
        {
            currentTime -= Time.deltaTime;

            if (currentTime <= 0.0f)
            {
                
                currentTime = 0.0f;
                isTimerRunning = false;
                Debug.Log("Game Lost: Time ran out");
                if (GameManager.instance != null)
                {
                    GameManager.instance.GameOveScreen(false);
                }
            }
            int currentScore = ScoreManager.instance.GetCurrentScore();
            //Debug.Log("score pp : "+currentScore);

            if (currentScore >= winScore && playerInWinArea)
            {
                Debug.Log("Game Won");
                isTimerRunning = false;
                if (GameManager.instance != null)
                {
                    GameManager.instance.GameOveScreen(true);
                }
            }

            if (ScoreManager.instance != null && ScoreManager.instance.GetCurrentScore() <= loseScore)
            {
                Debug.Log("Game Lost: Score too low");
                isTimerRunning = false;
                if (GameManager.instance != null)
                {
                    GameManager.instance.GameOveScreen(false);
                }
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

    

    public void PlayerEnteredWinArea()
    {
        playerInWinArea = true;
        Debug.Log("Player in Win Area: " + playerInWinArea);
    }
}
