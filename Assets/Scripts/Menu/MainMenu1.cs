using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour
{
    public void PlayLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Tutorial1()
    {
        SceneManager.LoadScene("Tutorial1");
    }

    public void QuitLevel1()
    {
        Debug.Log("Quit Level 1...");
        Application.Quit();
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
