using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // to find ver is private or not we use '_' for privae variable 
    int _score = 0;
    public static ScoreManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    public void AddScore(int points)
    {
        _score += points;
        Debug.Log(_score);
    }
}
