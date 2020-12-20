using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float slowDown = 10f ;
    private score theScoreManager;
    public float yourScore;
    public GameObject retryui;
    public GameObject deathFlash;

    public static bool reviveHasBeenUsed = false;

  
    public void EndGame()
    {
        StartCoroutine(RestartLevel());
        theScoreManager = FindObjectOfType<score>();
        
       
     
    }

    IEnumerator RestartLevel()
    {
        deathFlash.SetActive(true);
        Invoke("deathFlashFalse", 1.1f * Time.deltaTime);

        

        Time.timeScale = 1f / slowDown;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowDown;

        yield return new WaitForSeconds(1f / slowDown);

        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowDown;

       


        if (true)
        {
           
           
            if (reviveHasBeenUsed == false)
            {
                retryui.SetActive(true);
                Time.timeScale = 0f;

                reviveHasBeenUsed = true;
            }

            else if (reviveHasBeenUsed == true)
            {
                Time.timeScale = 0f;
                reviveHasBeenUsed = false;
                SceneManager.LoadScene("Restart");
              
            }

        }
        
      
      
      
        

        

    }
    public void RHBU()
    {
        retryui.SetActive(false);
        reviveHasBeenUsed = true;
    }

    public void RHBUFalse()
    {
        
        reviveHasBeenUsed = false;
    }
    public void deathFlashFalse()
    {
        deathFlash.SetActive(false);
    }

}

