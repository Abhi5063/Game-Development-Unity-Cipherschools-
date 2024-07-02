
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    int _score = 0;
    public Text scoreText;
    public static ScoreManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void AddScore(int points)
    {
        _score += points;
        Debug.Log(_score);
        scoreText.text = "Score : " + _score.ToString();
    }

    public int GetCurrentScore()
    {
        return _score;
    }
}