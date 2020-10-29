using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu2Back : MonoBehaviour
{
    //public GameManager1 gameManagerObj;

    public void PlayLevel2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void Tutorial2()
    {
        SceneManager.LoadScene("Tutorial2");
    }

    public void QuitGame()
    {
        Debug.Log("Quit Level 3...");
        Application.Quit();
    }

    public void TotalTime(float totalTime)
    {
        Debug.Log(totalTime);
    }



    void Update()
    {
        if (Input.GetKey("1"))
        {
            SceneManager.LoadScene("Menu1");
        }
        if (Input.GetKey("2"))
        {
            SceneManager.LoadScene("Menu2");
        }
        if (Input.GetKey("3"))
        {
            SceneManager.LoadScene("Menu3");
        }
        if (Input.GetKey("4"))
        {
            SceneManager.LoadScene("Menu4");
        }
        if (Input.GetKey("5"))
        {
            SceneManager.LoadScene("Menu5");
        }
        if (Input.GetKey("6"))
        {
            SceneManager.LoadScene("Menu6");
        }
    }
}
