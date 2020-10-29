using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController2 : MonoBehaviour
{
    public GameObject[] ob = new GameObject[9];
    public GameObject[] obUse = new GameObject[9];
    Vector3[] obUsePos = new Vector3[9];

    private bool[] obTrue = new bool[9];
    private bool[] layer = new bool[4];

    public float timeLeft = 120f;

    private float secondCounter = 0;
    public bool FinishOrOver = false;
    private float DistanceForDrag = 0.2f;

    public GameManager2 gameManager;

    void Start()
    {
        for (int i = 0; i < 9; i++)
        {
            obTrue[i] = false;
        }
        for (int i = 0; i < 4; i++)
        {
            layer[i] = false;
        }
        for (int i = 0; i < 9; i++)
        {
            obUsePos[i] = obUse[i].transform.position;
        }
    }



    void drag()
    {
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                float distance = Vector3.Distance(ob[i].transform.position, obUse[j].transform.position);
                if (distance < DistanceForDrag)
                {
                   obUse[j].transform.position = ob[i].transform.position;
                }
            }
        }
    }


    void chackLegLayer()
    {
        layer[0] = true;
        for (int i = 0; i < 4; i++)
        {
            obTrue[i] = false;
            for (int j = 0; j < 4; j++)
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
                layer[0] = false;
                break;
            }
        }
    }


    void chackDasaLayer()
    {
        layer[1] = true;
        for (int i = 4; i < 6; i++)
        {
            obTrue[i] = false;
            for (int j = 4; j < 6; j++)
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


    void chackBackbonLayer()
    {
        layer[2] = true;
        for (int i = 6; i < 8; i++)
        {
            obTrue[i] = false;
            for (int j = 6; j < 8; j++)
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
                layer[2] = false;
                break;
            }
        }
    }


    void chackPlateLayer()
    {
        layer[3] = true;
        float distance = Vector3.Distance(ob[8].transform.position, obUse[8].transform.position);
        if (distance < DistanceForDrag)
        {
            obTrue[8] = true;
        }
        else
        {
            layer[3] = false;
        }
    }




    void Update()
    {
        drag();
        chackLegLayer();
        chackDasaLayer();
        chackBackbonLayer();
        chackPlateLayer();


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
            FindObjectOfType<GameManager2>().EndGame();
        }


        secondCounter += Time.deltaTime;
        if (secondCounter > timeLeft)
        {
            FinishOrOver = false;
            FindObjectOfType<GameManager2>().EndGame();
        }
 
    }
}
