using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer3 : MonoBehaviour
{
    float currentTime = 0f;
    public float startingTime = 120f;
    [SerializeField] TextMeshProUGUI countDownText;

    void Start()
    {
        currentTime = startingTime;
    }



    void Update()
    {
        currentTime -= 1 * Time.deltaTime;

        if (currentTime <= 0)
        {
            currentTime = 0;
        }
        if (currentTime <= 30)
        {
            countDownText.color = Color.yellow;
        }
        if (currentTime <= 10)
        {
            countDownText.color = Color.red;
        }

        string m = ((int)currentTime / 60).ToString("0");
        string s = ((int)currentTime % 60).ToString("0");
        countDownText.text = "Time Left  " + m + ":" + s;
    }
}
