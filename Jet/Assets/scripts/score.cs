using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public float ScoreCount = 0f ;
    public Text ScoreText;
    public Text Highscoretext;
    public float HighscoreCount;
    public bool scoreIncrease = true;
    public float yourScore ;

    
   
   

    public float pointIncreased = 1.5f;
   
    // Start is called before the first frame update
    void Start()
    {
        ScoreCount = 0f;

      

        HighscoreCount = PlayerPrefs.GetFloat("Highscore" , 0 );

    }

    // Update is called once per frame
    void Update()
    {

        ScoreText.text = " " + Mathf.Round(ScoreCount);
        Highscoretext.text = " " + Mathf.Round(HighscoreCount);
        if (scoreIncrease) 
        { ScoreCount += pointIncreased * Time.deltaTime ; }
        
        if (ScoreCount > HighscoreCount)
        {
            HighscoreCount = ScoreCount;
            PlayerPrefs.SetFloat("Highscore", HighscoreCount);
        }

        if (ScoreCount > yourScore)
        {
            yourScore = ScoreCount;
            PlayerPrefs.SetFloat("YourScore", yourScore);
        } 
    }
  





}

