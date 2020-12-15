using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void Startgame()
    {
        SceneManager.LoadScene("main level");
    }

    public void Option()
    {

    }
    public void Quit()
    {
        Application.Quit();
    }
}
