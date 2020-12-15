using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestartMenu : MonoBehaviour
{
    public float HighscoreCount;
    public float YourScore;
    public Text ScoreText;
    public Text Highscoretext;
    // Start is called before the first frame update
    void Start()
    {

        HighscoreCount = PlayerPrefs.GetFloat("Highscore");
        YourScore = PlayerPrefs.GetFloat("YourScore");


    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score : " + Mathf.Round(YourScore);
        Highscoretext.text = "HighScore : " + Mathf.Round(HighscoreCount);
    }
}
