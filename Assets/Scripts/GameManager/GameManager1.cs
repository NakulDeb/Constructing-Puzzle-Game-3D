using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager1 : MonoBehaviour
{
    public GameController obj;
    bool isGameEnd = false;

    //public MainMenu2 menuObj;
    public void EndGame()
    {
        if(isGameEnd == false)
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
       // FindObjectOfType<MainMenu2>().TotalTime(obj.secondCounter);
        SceneManager.LoadScene("Menu2");
    }

    void GameOver()
    {
        Debug.Log("GameOver.....");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Menu1Back");
    }


   
}
