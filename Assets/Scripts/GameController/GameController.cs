using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] b = new GameObject[14];
    public GameObject[] bUse = new GameObject[14];
    private bool[] bTrue = new bool[14];
    Vector3[] bUsePos = new Vector3[14];

    private float secondCounter = 0;
    private float DistanceForDrag = 0.3f;
    private bool[] layer = new bool[3];

    public float leftTime = 120f;

    public GameManager1 gameManager;
    public bool FinishOrOver = false;

    void Start()
    {
        for (int i = 0; i < 14; i++)
        {
            bTrue[i] = false;
        }
        for (int i = 0; i < 3; i++)
        {
            layer[i] = false;
        }
        for (int i=0; i<14; i++)
        {
            bUsePos[i] = bUse[i].transform.position;
        }
    }








    void drag()
    {
        for (int i = 0; i <= 13; i++)
        {
            for (int j = 0; j <= 13; j++)
            {
                float distance = Vector3.Distance(b[i].transform.position, bUse[j].transform.position);
                if (distance < DistanceForDrag)
                {
                    bUse[j].transform.position = b[i].transform.position;
                }
            }
        }
    }


    void chack1stLayer()
    {
        layer[0] = true;
        for (int i = 0; i < 9; i++)
        {
            bTrue[i] = false;
            for (int j = 0; j < 9; j++)
            {
                float distance = Vector3.Distance(b[i].transform.position, bUse[j].transform.position);
                if (distance < DistanceForDrag)
                {
                    bTrue[i] = true;
                    break;
                }
            }
            if (!bTrue[i])
            {
                layer[0] = false;
                break;
            }
        }
    }


    void chack2ndLayer()
    {
        layer[1] = true;
        for (int i = 9; i < 13; i++)
        {
            bTrue[i] = false;
            for (int j = 9; j < 13; j++)
            {
                float distance = Vector3.Distance(b[i].transform.position, bUse[j].transform.position);
                if (distance < DistanceForDrag)
                {
                    bTrue[i] = true;
                    break;
                }
            }
            if (!bTrue[i])
            {
                layer[1] = false;
                break;
            }
        }
    }


    void chack3rdLayer()
    {
        layer[2] = true;
        float distance = Vector3.Distance(b[13].transform.position, bUse[13].transform.position);
        if (distance < DistanceForDrag)
        {
            bTrue[13] = true;
        }
        else
        {
            layer[2] = false;
        }
    }
  






    void Update()
    {
        drag();
        chack1stLayer();
        chack2ndLayer();
        chack3rdLayer();

        bool gameComplete = true;
        for(int i=0; i<3; i++)
        {
            if (!layer[i]){
                gameComplete = false;
            }
        }
        if (gameComplete)
        {
            FinishOrOver = true;
            FindObjectOfType<GameManager1>().EndGame();
        }
        

        secondCounter += Time.deltaTime;
        if (secondCounter > leftTime)
        {
            FinishOrOver = false;
            FindObjectOfType<GameManager1>().EndGame();
        }
    }

}
