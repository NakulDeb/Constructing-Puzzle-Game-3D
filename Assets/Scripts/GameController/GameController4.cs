using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController4 : MonoBehaviour
{
    public GameObject[] ob = new GameObject[4];
    public GameObject[] obUse = new GameObject[4];
    Vector3[] obUsePos = new Vector3[4];

    private bool[] obTrue = new bool[4];
    private bool[] layer = new bool[4];

    public float timeLeft = 120f;

    private float secondCounter = 0;
    public bool FinishOrOver = false;
    private float DistanceForDrag = 0.2f;

    public GameManager4 gameManager;

    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            obTrue[i] = false;
        }
        for (int i = 0; i < 4; i++)
        {
            layer[i] = false;
        }
        for (int i = 0; i < 4; i++)
        {
            obUsePos[i] = obUse[i].transform.position;
        }
    }



    void drag()
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                float distance = Vector3.Distance(ob[i].transform.position, obUse[j].transform.position);
                if (distance < DistanceForDrag)
                {
                    obUse[j].transform.position = ob[i].transform.position;
                }
            }
        }
    }


    void chackKeyBoardLayer()
    {
        layer[0] = true;
        float distance = Vector3.Distance(ob[0].transform.position, obUse[0].transform.position);
        if (distance < DistanceForDrag)
        {
            obTrue[0] = true;
        }
        else
        {
            layer[0] = false;
        }
    }


    void chackMonitorLayer()
    {
        layer[1] = true;
        float distance = Vector3.Distance(ob[1].transform.position, obUse[1].transform.position);
        if (distance < DistanceForDrag)
        {
            obTrue[1] = true;
        }
        else
        {
            layer[1] = false;
        }
    }



    void chackCPULayer()
    {
        layer[2] = true;
        float distance = Vector3.Distance(ob[2].transform.position, obUse[2].transform.position);
        if (distance < DistanceForDrag)
        {
            obTrue[2] = true;
        }
        else
        {
            layer[2] = false;
        }
    }


    void chackMouseLayer()
    {
        layer[3] = true;
        float distance = Vector3.Distance(ob[3].transform.position, obUse[3].transform.position);
        if (distance < DistanceForDrag)
        {
            obTrue[3] = true;
        }
        else
        {
            layer[3] = false;
        }
    }



    void Update()
    {
        drag();

        chackKeyBoardLayer();
        chackMonitorLayer();
        chackCPULayer();
        chackMouseLayer();




        bool gameComplete = true;
        for (int i = 0; i < 4; i++)
        {
            if (!layer[i])
            {
                gameComplete = false;
            }
        }

        if (gameComplete)
        {
            FinishOrOver = true;
            FindObjectOfType<GameManager4>().EndGame();
        }

        secondCounter += Time.deltaTime;
        if (secondCounter > timeLeft)
        {
            FinishOrOver = false;
            FindObjectOfType<GameManager4>().EndGame();
        }
    }
}

