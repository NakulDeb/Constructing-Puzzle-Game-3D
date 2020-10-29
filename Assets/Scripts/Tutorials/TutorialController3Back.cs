using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialController3Back : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("Menu3");
    }
}
