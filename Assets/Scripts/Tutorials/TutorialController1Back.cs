using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialController1Back : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("Menu1");
    }
}
