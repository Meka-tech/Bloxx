using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }

            else
            {
                Pause();
            }


        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

    }
    public void loadMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void mainmenu()
    {
        FindObjectOfType<GameManager>().RHBUFalse();
        SceneManager.LoadScene("StartMenu");
        Time.timeScale = 1f;
    }
    public void ArrowPause()
    {
       
        
            if (GameIsPaused)
            {
                Resume();
            }

            else
            {
                Pause();
            }


        
    }
    public void Restart()
    {
        FindObjectOfType<GameManager>().RHBUFalse();
        SceneManager.LoadScene("main level");
        Time.timeScale = 1f;
    }
}   
