using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController3 : MonoBehaviour
{
    public GameObject[] ob = new GameObject[6];
    public GameObject[] obUse = new GameObject[6];
    Vector3[] obUsePos = new Vector3[6];

    private bool[] obTrue = new bool[6];
    private bool[] layer = new bool[4];

    public float timeLeft = 120f;

    private float secondCounter = 0;
    public bool FinishOrOver = false;
    private float DistanceForDrag = 0.2f;

    public GameManager3 gameManager;

    void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            obTrue[i] = false;
        }
        for (int i = 0; i < 4; i++)
        {
            layer[i] = false;
        }
        for (int i = 0; i < 6; i++)
        {
            obUsePos[i] = obUse[i].transform.position;
        }
    }



    void drag()
    {
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                float distance = Vector3.Distance(ob[i].transform.position, obUse[j].transform.position);
                if (distance < DistanceForDrag)
                {
                    obUse[j].transform.position = ob[i].transform.position;
                }
            }
        }
    }


    void chackPlateLayer()
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


    void chackLegLayer()
    {
        layer[1] = true;
        for (int i = 1; i < 4; i++)
        {
            obTrue[i] = false;
            for (int j = 1; j < 4; j++)
            {
                float distance = Vector3.Distance(ob[i].transform.position, obUse[j].transform.position);
                if (distance < DistanceForDrag)
                {
                    obTrue[i] = true;
                    break;
                }
            }
            if (!obTrue[i])
            {
                layer[1] = false;
                break;
            }
        }
    }



    void chackBoxLayer()
    {
        layer[2] = true;
        float distance = Vector3.Distance(ob[4].transform.position, obUse[4].transform.position);
        if (distance < DistanceForDrag)
        {
            obTrue[4] = true;
        }
        else
        {
            layer[2] = false;
        }
    }


    void chackKeyBoardPlateLayer()
    {
        layer[3] = true;
        float distance = Vector3.Distance(ob[5].transform.position, obUse[5].transform.position);
        if (distance < DistanceForDrag)
        {
            obTrue[5] = true;
        }
        else
        {
            layer[3] = false;
        }
    }



    void Update()
    {
        drag();

        chackPlateLayer();
        chackLegLayer();
        chackBoxLayer();
        chackKeyBoardPlateLayer();

 


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
            FindObjectOfType<GameManager3>().EndGame();
        }


        secondCounter += Time.deltaTime;
        if (secondCounter > timeLeft)
        {
            FinishOrOver = false;
            FindObjectOfType<GameManager3>().EndGame();
        }
    }
}

