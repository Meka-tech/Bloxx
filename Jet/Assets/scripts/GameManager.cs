using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float slowDown = 10f ;
    private score theScoreManager;
    public float yourScore;
   public void EndGame()
    {
        StartCoroutine(RestartLevel());
        theScoreManager = FindObjectOfType<score>();
    }

    IEnumerator RestartLevel()
    {
        Time.timeScale = 1f / slowDown;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowDown;

        yield return new WaitForSeconds(1f / slowDown);

        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowDown;


       
        SceneManager.LoadScene("Restart"); 
        

    }
}

