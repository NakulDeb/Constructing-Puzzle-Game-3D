using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager2 : MonoBehaviour
{
    public GameController2 obj;
    bool isGameEnd = false;
    public void EndGame()
    {
        if (isGameEnd == false)
        {
            isGameEnd = true;
            if (obj.FinishOrOver)
            {
                Invoke("Restart", 1f);
            }
            else
            {
                Invoke("GameOver", 1f);
            }

        }

    }
    void Restart()
    {
        Debug.Log("Congraculations!!!....");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Menu3");
    }

    void GameOver()
    {
        Debug.Log("GameOver.....");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Menu2Back");
    }

}
