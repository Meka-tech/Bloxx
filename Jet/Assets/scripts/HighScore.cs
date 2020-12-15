using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{   
    public int Score;
    public Text highScore;
    public void Start()
    {
        //highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
    public void Highscore()
    {
        PlayerPrefs.SetInt("HighScore", Score);
    }
}

