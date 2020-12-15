using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public void retry()
    {
        SceneManager.LoadScene("main level");
    }

    public void Exit()
    {
        SceneManager.LoadScene("StartMenu");
    }

}
