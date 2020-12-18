using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public void retry()
    {
        Time.timeScale = 1f;
        
        SceneManager.LoadScene("main level");
       
       
    }

    public void Exit()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("StartMenu");
    }

}
